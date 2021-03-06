﻿using E_Barangay.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using E_Barangay.Forms;
namespace E_Barangay.Documents
{
    public partial class BuildingPermit : DocumentForm
    {
        OfficerInfo o = new OfficerInfo();
        public BuildingPermit()
        {
            InitializeComponent();
        }

        public override void Printing_PrintPage(object sender, PrintPageEventArgs e)
        {
            base.Printing_PrintPage(sender, e);
            
            string name = Printing.GetFullName(firstName, middleName, lastName, extension);
            string first = "To whom it may concern," + Printing.LineSpace +
                           Printing.Indention + "This certification is issued to " + Printing.GetFullName(firstName, middleName, lastName, extension) + ", of legal age, Filipino and a residing at " + Printing.IfControlEmpty(Address) + ", per TD No." + Printing.IfControlEmpty(tdNoField) + " in support of " + Printing.HisOrHer(SexOption.Text) + " application for " + Printing.IfControlEmpty(specField) + " permit with the Local Government Unit (LGU) Kalibo." + Printing.LineSpace +
                           Printing.Indention + "Issued this " + IssuedOn.customFormat() + " at Barangay Poblacion, Kalibo, Aklan.";

            e.Graphics.DrawString(first, Printing.font, Brushes.Black, rect);
            DrawDebugRecs(rect, e);
            Printing.DrawSpecimenSignature(e, Printing.GetName(firstName, middleName, lastName, extension));
            Printing.DrawCap(e, o.captName);
        }
        public override void InitializeControls()
        {
            AddControls(firstName,
                        middleName,
                        lastName,
                        extension,
                        Address,
                        SexOption,
                        tdNoField,
                        specField,
                        IssuedOn);
        }
        public override void AcceptCitizen(Citizen c)
        {
            if (c == null)
            {
                MessageBox.Show("Not found");
                return;
            }
            firstName.Text = c.FirstName;
            middleName.Text = c.MiddleName;
            lastName.Text = c.LastName;
            extension.Text = c.Extension;
            SexOption.Text = c.Gender;
            Address.Text = c.Address;
        }
    }
}
