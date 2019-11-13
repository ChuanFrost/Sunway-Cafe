﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunway_Cafe.Model;

namespace Sunway_Cafe
{

    public partial class ProfilePage : Form
    {

        public ProfilePage()
        {
            InitializeComponent();
            //try
            //{
            //    using (var db = new SunwayCafeContext())
            //    {
            //        var query = db.Accounts.Where(acc => acc.Id == 1).Select(acc => new { acc.GivenName, acc.FamilyName, acc.Gender, acc.Contact, acc.Email, acc.Role }).ToList();

            //        position.Text = query[0].Role;
            //        familyName.Text = query[0].FamilyName;
            //        givenName.Text = query[0].GivenName;
            //        gender.Text = query[0].Gender;
            //        contact.Text = query[0].Contact.ToString();
            //        email.Text = query[0].Email;

            //    }
            //}
            //catch (InvalidCastException ice)
            //{
            //    if (ice == null)
            //    {
            //        MessageBox.Show("Null Value Detected");
            //    }
            //}

            position.Text = Global.user.Details.Role;
            familyName.Text = Global.user.Details.FamilyName;
            givenName.Text = Global.user.Details.GivenName;
            gender.Text = Global.user.Details.Gender;
            contact.Text = Global.user.Details.Contact.ToString();
            email.Text = Global.user.Details.Email;
        }



        private void editProfile_Click(object sender, EventArgs e)
        {
            //EditProfilePage editProfile = new EditProfilePage();
            //editProfile.ShowDialog();
            //this.Refresh();
            EditProfilePage editProfile = new EditProfilePage(Global.user.Details); //create new isntance of form
            editProfile.FormClosed += new FormClosedEventHandler(EditProfilePage_FormClosed); //add handler to catch when child form is closed
            editProfile.Show(); //show child
        }

        private void EditProfilePage_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.InitializeComponent();
        }

    }
}
