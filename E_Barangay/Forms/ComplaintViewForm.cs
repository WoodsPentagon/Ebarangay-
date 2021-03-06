﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using E_Barangay.Class;

namespace E_Barangay.Forms
{
    public partial class ComplaintViewForm : Form
    {
        public event EventHandler OnComplaintChanges;

        Complaint currRec;
        public ComplaintViewForm()
        {
            InitializeComponent();
        }
        public ComplaintViewForm(int id)
        {
            InitializeComponent();
            using (var ent = new EBarangayEntities())
            {
                currRec = ent.Complaints.FirstOrDefault(x => x.ID == id);
                initializeFields();
            }

        }
        void initializeFields()
        {
            controlNumberField.Text = currRec.ID.ToString();
            Status.Text = currRec.Status;
            Status.ForeColor = currRec.Status == "Pending" ? Color.Red : Color.Green;
            locationTxt.Text = currRec.Location;
            narrativeField.Text = currRec.Narrative;

            During.Text = currRec.DateHappened.ToString("MMMM dd, yyyy hh:mm tt");
            RecordedOn.Text = currRec.DateIssued.ToString("MMMM dd, yyyy hh:mm tt");
            settleSched.Value = currRec.SettlementDate;

            //var compNames = currRec.CompNames.Split(',');
            //foreach (var c in compNames)
            //    lvComplainants.Items.Add(c);
           
            //var respNames = currRec.RespNames.Split(',');
            //foreach (var c in respNames)
            //    lvRespondents.Items.Add(c);           
        }
        User user;
        private void RecordView_Load(object sender, EventArgs e)
        {
            user = UserManager.instance != null ? UserManager.instance.currentUser : null;

            DoneBtn.Visible = user.Comp_Edit ? true : false;
            settleSched.Enabled = user.Comp_Edit ? true : false;
        }

        private void DoneBtn_Click(object sender, EventArgs e)
        {
            using (var yesorno = new YesOrNoPrompt("Are you sure you want to mark this record as settled?"))
            {
                yesorno.onBtnClick += (se, ee) =>
                 {

                     if (ee)
                     {
                         markAsDone();
                         Status.Text = "Settled";
                         Status.ForeColor = Color.Green;
                         DoneBtn.Enabled = false;
                     }
                 };
                yesorno.ShowDialog();
            }

        }
        void markAsDone()
        {
            using (var eb = new EBarangayEntities())
            {
                var rec = eb.Complaints.FirstOrDefault(r => r.ID == currRec.ID);
                if (rec == null)
                {
                    MessageBox.Show("error in changing");
                    return;
                }
                if (rec.Status == ComplaintStatus.Settled.ToString())
                    return;

                rec.Status = "Settled";
                eb.SaveChanges();
                OnComplaintChanges?.Invoke(this, new EventArgs());

            }
        }

        private void controlNumberField_TextChanged(object sender, EventArgs e)
        {

        }

        private void locationTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void RecordedOn_TextChanged(object sender, EventArgs e)
        {

        }

        private void During_TextChanged(object sender, EventArgs e)
        {

        }

        private void Status_TextChanged(object sender, EventArgs e)
        {

        }

        private void settleSched_ValueChanged(object sender, EventArgs e)
        {
            using (var eb = new EBarangayEntities())
            {
                var id = Convert.ToInt32(controlNumberField.Text);
                var c = eb.Complaints.FirstOrDefault(x => x.ID == id);
                c.SettlementDate = settleSched.Value;
                eb.SaveChanges();
            }
            OnComplaintChanges?.Invoke(this, new EventArgs());
        }
    }
}
