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
    public partial class MainPage : Form
    {
        private static MainPage _obj;

        public static MainPage Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new MainPage();
                }
                return _obj;
            }
        }

        public Panel SidePanel
        {
            get
            {
                return sidepanel;
            }
            set
            {
                sidepanel = value;
            }
        }

        public Panel MainPanel
        {
            get
            {
                return mainpanel;
            }
            set
            {
                mainpanel = value;
            }
        }

        public Button Order
        {
            get
            {
                return order;
            }
            set
            {
                order = value;
            }
        }

        public Button Manage
        {
            get
            {
                return account;
            }
            set
            {
                account = value;
            }
        }

        public Button Item
        {
            get
            {
                return item;
            }
            set
            {
                item = value;
            }
        }



        public MainPage()
        {
            InitializeComponent();
            using (var db = new SunwayCafeContext())
            {
                var query = db.Items.ToList();
            }
        }

        public void button1_Click(object sender, EventArgs e)
        {
            NavPage(new HomePage(), home);
            title.Text = "Home";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _obj = this;
            MainPanel.Controls.Add(new HomePage());
            title.Text = "Home";
        }

        public void order_Click(object sender, EventArgs e)
        {
            //order_Page();
            NavPage(new OrderPage(), order);
            title.Text = "Order";

        }

        public void manage_Click(object sender, EventArgs e)
        {
            //manage_Page();
            nav(new AccountPage(), mainpanel, account);
            title.Text = "Account";
            //NavPage(UserControl2.Instance, manage);
        }

        private void item_Click(object sender, EventArgs e)
        {
            //item_Page();
            NavPage(new ItemPage(), Item);
            title.Text = "Item";

        }


        public void nav(Form form, Panel panel, Button navButton)
        {
            MainPanel.Controls.Clear();
            SidePanel.Height = navButton.Height;
            SidePanel.Top = navButton.Top;
            form.TopLevel = false;
            panel.Controls.Clear();
            panel.Controls.Add(form);
            form.Show();
        }

        public void NavPage(UserControl navPage, Button navButton)
        {
            MainPanel.Controls.Clear();
            SidePanel.Height = navButton.Height;
            SidePanel.Top = navButton.Top;
            MainPanel.Controls.Add(navPage);
            navPage.Show();
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            Form signIn = new SignInPage();
            this.Close();
            signIn.Show();
            Global.user = new User();
        }

        private void profile_Click(object sender, EventArgs e)
        {
            ProfilePage pp = new ProfilePage();
            nav(pp, mainpanel, home);
        }

        private void Mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Kitchen_Click(object sender, EventArgs e)
        {
            NavPage(new KitchenPage(), kitchen);
            title.Text = "Kitchen";
        }
    }

   
}
