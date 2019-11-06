﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sunway_Cafe
{
    public partial class ItemPage : UserControl
    {
        private static ItemPage _instance;
        public ItemPage()
        {
            InitializeComponent();
        }

        public static ItemPage Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ItemPage();
                return _instance;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateItem create = new CreateItem();
            create.Show();
        }

        private void load_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            using (var db = new SunwayCafeContext())
            {
                var query = db.ItemTestss.ToList();

                foreach (var itemList in query)
                {
                 
                    ListViewItem item = new ListViewItem(itemList.ID.ToString());
                    item.SubItems.Add(itemList.Name);

                    listView1.Items.Add(item);
                   
                }

            }
        }

        private void delete_Click(object sender, EventArgs e)
        {

        }
    }
}
