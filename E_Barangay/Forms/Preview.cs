﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using E_Barangay.Interface;
using System.IO;
using E_Barangay.Class;
using System.Drawing.Imaging;

namespace E_Barangay.Forms
{
    public partial class Preview : Form
    {

        Citizen target;
        public event EventHandler OnRecordDeleted;
        public Preview()
        {
            InitializeComponent();
        }
        private void Preview_Load(object sender, EventArgs e)
        {
            if (Class.UserManager.instance == null)
                return;
            User user = Class.UserManager.instance.currentUser;
            if (user == null)
                return;
            EditBtn.Visible = user.Rec_Edit ? true : false;
            DeleteBtn.Visible = user.Rec_Delete ? true : false;
        }
        public void AcceptDetails(Citizen c)
        {
            target = c;
            AssignValuesToText();
        }

        private void OkayBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// EditPage epage;
        // PasswordForm passwordForm;
        //Class.PasswordToFormHandler<EditCitizen> passwordToFormHandler;
        private void EditBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Disposed += (a, b) =>
            {
                var passwordToFormHandler = new Class.PasswordToFormHandler<EditCitizen>();
                passwordToFormHandler.InitNextForm += PasswordToFormHandler_InitNextForm;
                passwordToFormHandler.Start();
            };
        }

        private void PasswordToFormHandler_InitNextForm(object sender, EditCitizen e)
        {
            e.AssignCitizen(target);
        }

        string emptyField = string.Empty;
        void AssignValuesToText()
        {
            if (target == null)
            {
                MessageBox.Show("Citizen instance not assigned.");
                return;
            }
            IDTxt.Text = target.IdNumber;
            NameTxt.Text = target.getNameWithSpace();
            AddressTxt.Text = target.Address;
            BdayTxt.Text = target.Birthday.ToString("MMMM dd, yyyy");
            SexTxt.Text = target.Gender;
            ContactTxt.Text = target.ContactInfo;


            CivilStatusTxt.Text = target.CivilStatus;

            MotherTxt.Text = target.MothersName;
            FatherTxt.Text = target.FathersName;

            SpouseTxt.Text = target.SpouseName ?? emptyField;
            VotersID.Text = target.VoterID ?? emptyField;
            PrecinctNumber.Text = target.PrecinctNumber ?? emptyField;

            SSS.Text = target.SSS ?? emptyField;
            PagIbig.Text = target.PagIbig ?? emptyField;
            Philhealth.Text = target.Philhealth ?? emptyField;

            Class.Date date = new Class.Date();
            Class.DateTimeExtension.ToAgeString(target.Birthday, ref date);

            AgeTxt.Text = target.getAGe().ToString();
            //AgeTxt.Text = Class.DateTimeExtension.ToAge(target.Birthday).years.ToString();
            IsIndigent.Checked = target.Indigent ? true : false;
            IsStudent.Checked = target.Student ? true : false;
            IsSenior.Checked = target.SeniorCitizen ? true : false;
            IsPwd.Checked = target.PWD ? true : false;

            RecordsTable.Rows.Clear();
            using (var ent = new EBarangayEntities())
            {
                var t = ent.Citizens.FirstOrDefault(r => r.ID == target.ID);
                ImageBox.Image = t.Picture == null ? null : Class.ImageConverter.byteArrayToImage(t.Picture);
                area.Text = (t.Area?.Name)??"Not Asigned";
                var connector = ent.CitizenToComplaints.Where(x => x.CitizenId == target.ID);
                foreach (var c in connector)
                {
                    var comp = c.Complaint;
                    RecordsTable.Rows.Add(comp.ID, comp.SettlementDate.ToString("MMMM dd, yyyy"), comp.Status);
                }
                foreach( var c in ent.Documents.Where(x=>x.CitizenId ==target.ID ).OrderByDescending(y=>y.DateIssued))
                {
                    docTable.Rows.Add(c.ControlNumber,
                                      c.DateIssued.Value.ToString("MMMM dd, yyyy hh:mm tt"),
                                      c.DocumentTitle);
                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {

            using (YesOrNoPrompt yesOrNo = new YesOrNoPrompt("Are you sure you want to delete this item?"))
            {
                yesOrNo.onBtnClick += YesOrNo_onBtnClick;
                yesOrNo.ShowDialog();
            }


        }

        private void YesOrNo_onBtnClick(object sender, bool e)
        {
            this.Enabled = true;
            Form f = (Form)sender;

            //this.Close();
            if (e)
            {
                using (var eb = new EBarangayEntities())
                {
                    var c = eb.Citizens.FirstOrDefault(x => x.IdNumber == IDTxt.Text);

                    //foreach (var rec in c.Records.ToArray())
                    //    eb.Records.Remove(rec);
                    var instances = eb.CitizenToComplaints.Where(x => x.Citizen.IdNumber == IDTxt.Text);
                    foreach (var i in instances)
                        eb.CitizenToComplaints.Remove(i);
                    eb.Citizens.Remove(c);

                    eb.SaveChanges();

                    f.Close();

                    MessageBox.Show("successfully deleted Entry with id(" + IDTxt.Text + ")");
                    OnRecordDeleted?.Invoke(this, new EventArgs());
                    this.Close();
                }
            }
            ///throw new NotImplementedException();
        }

        private void RecordsTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            DataGridView v = (DataGridView)sender;
            var x = (int)(v.SelectedCells[0].Value);

            var view = new ComplaintViewForm(x);
            view.FormClosed += (ee, ss) => { this.Enabled = true; };
            this.Enabled = false;
            view.Show();
        }
    }
}
