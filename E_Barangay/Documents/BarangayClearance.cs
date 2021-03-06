﻿using E_Barangay.Forms;
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
using E_Barangay.Class;

namespace E_Barangay.Documents
{
    public partial class BarangayClearance : DocumentForm
    {
        OfficerInfo o = new OfficerInfo();
        public BarangayClearance()
        {
            InitializeComponent();
        }
        public override void AcceptCitizen(Citizen c)
        {
            if (c == null)
            {
                MessageBox.Show("Not found");
                return;
            }

            firstText.Text = c.FirstName;
            middleText.Text = c.MiddleName;
            lastText.Text = c.LastName;
            extText.Text = c.Extension;

            int age = DateTime.Today.Year - c.Birthday.Year;
            Age.Text = age > 0 ? age.ToString() : 1.ToString();
            Address.Text = c.Address;
            CStatusOption.Text = c.CivilStatus;
            SexOption.Text = c.Gender;

        }
        public override void Printing_PrintPage(object sender, PrintPageEventArgs e)
        {
            Console.WriteLine(e.PageBounds.Width * 3 / 5 + 20);
            //e.Graphics.DrawImage(Properties.Resources.Certificate_Template, Point.Empty);
            CustomHeaderCert(e, "BARANGAY CLEARANCE");

            InitBodyRect(e);
            //Rectangle bodyRect = new Rectangle(e.PageBounds.Width / 3 - 30, e.PageBounds.Height / 3, 548, 300);
            string name = Printing.GetName(firstText,middleText,lastText,extText);
            string text = "To whom it may concern:" + Printing.LineSpace
                          + Printing.Indention + "This is to certify that as per record of this Barangay " + name + ", " + Printing.IfControlEmpty(Age) + " years old, " + Printing.IfControlEmpty(CStatusOption) + ", Filipino and a resident of " + Printing.IfControlEmpty(Address) + ", whose signature appears below has no criminal, civil or administrative charges before this office and has good moral standing in the community." + Printing.LineSpace
                          + Printing.Indention + "This certification is issued upon the request of " + Printing.MrOrMrs(SexOption.Text) + " " + lastText.Text + (string.IsNullOrEmpty(extText.Text) ? "" : " " + extText.Text) + " for " + Printing.IfControlEmpty(Purpose) + "." + Printing.LineSpace
                          + "WITNESS MY HAND SEAL, this " + IssuedOn.customFormat() + ", at Barangay Poblacion, Kalibo, Aklan, Philippines.";

            e.Graphics.DrawString(text, Printing.font, Brushes.Black, rect);
            Printing.DrawSpecimenSignature(e, name);
            DrawDebugRecs(rect, e);

            Printing.DrawCapSb(e, o.captName, officerOption.Text);
        }
        public override void InitializeControls()
        {
            AddControls(firstText, middleText, lastText, extText, Age, SexOption, Address, Purpose, CStatusOption, officerOption, IssuedOn);
            o.InitDropdowns(officerOption);
        }
    }
}
