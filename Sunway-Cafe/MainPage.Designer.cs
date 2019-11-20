﻿namespace Sunway_Cafe
{
    partial class MainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.kitchen = new System.Windows.Forms.Button();
            this.item = new System.Windows.Forms.Button();
            this.account = new System.Windows.Forms.Button();
            this.order = new System.Windows.Forms.Button();
            this.sidepanel = new System.Windows.Forms.Panel();
            this.home = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.profile = new MetroSet_UI.Controls.MetroSetButton();
            this.logOutBtn = new MetroSet_UI.Controls.MetroSetButton();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.kitchen);
            this.panel1.Controls.Add(this.item);
            this.panel1.Controls.Add(this.account);
            this.panel1.Controls.Add(this.order);
            this.panel1.Controls.Add(this.sidepanel);
            this.panel1.Controls.Add(this.home);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 978);
            this.panel1.TabIndex = 0;
            // 
            // kitchen
            // 
            this.kitchen.FlatAppearance.BorderSize = 0;
            this.kitchen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kitchen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kitchen.ForeColor = System.Drawing.Color.SeaShell;
            this.kitchen.Image = ((System.Drawing.Image)(resources.GetObject("kitchen.Image")));
            this.kitchen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kitchen.Location = new System.Drawing.Point(12, 406);
            this.kitchen.Name = "kitchen";
            this.kitchen.Size = new System.Drawing.Size(148, 54);
            this.kitchen.TabIndex = 7;
            this.kitchen.Text = "Kitchen";
            this.kitchen.UseVisualStyleBackColor = true;
            this.kitchen.Click += new System.EventHandler(this.Kitchen_Click);
            // 
            // item
            // 
            this.item.FlatAppearance.BorderSize = 0;
            this.item.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.item.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item.ForeColor = System.Drawing.Color.SeaShell;
            this.item.Image = ((System.Drawing.Image)(resources.GetObject("item.Image")));
            this.item.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.item.Location = new System.Drawing.Point(12, 346);
            this.item.Name = "item";
            this.item.Size = new System.Drawing.Size(148, 54);
            this.item.TabIndex = 6;
            this.item.Text = "Item";
            this.item.UseVisualStyleBackColor = true;
            this.item.Click += new System.EventHandler(this.item_Click);
            // 
            // account
            // 
            this.account.FlatAppearance.BorderSize = 0;
            this.account.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.account.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.account.ForeColor = System.Drawing.Color.SeaShell;
            this.account.Image = ((System.Drawing.Image)(resources.GetObject("account.Image")));
            this.account.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.account.Location = new System.Drawing.Point(12, 286);
            this.account.Name = "account";
            this.account.Size = new System.Drawing.Size(148, 54);
            this.account.TabIndex = 4;
            this.account.Text = "Account";
            this.account.UseVisualStyleBackColor = true;
            this.account.Click += new System.EventHandler(this.manage_Click);
            // 
            // order
            // 
            this.order.FlatAppearance.BorderSize = 0;
            this.order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.order.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order.ForeColor = System.Drawing.Color.SeaShell;
            this.order.Image = ((System.Drawing.Image)(resources.GetObject("order.Image")));
            this.order.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.order.Location = new System.Drawing.Point(12, 226);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(148, 54);
            this.order.TabIndex = 5;
            this.order.Text = "Order";
            this.order.UseVisualStyleBackColor = true;
            this.order.Click += new System.EventHandler(this.order_Click);
            // 
            // sidepanel
            // 
            this.sidepanel.BackColor = System.Drawing.Color.Khaki;
            this.sidepanel.Location = new System.Drawing.Point(0, 166);
            this.sidepanel.Name = "sidepanel";
            this.sidepanel.Size = new System.Drawing.Size(13, 54);
            this.sidepanel.TabIndex = 3;
            // 
            // home
            // 
            this.home.FlatAppearance.BorderSize = 0;
            this.home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home.ForeColor = System.Drawing.Color.SeaShell;
            this.home.Image = ((System.Drawing.Image)(resources.GetObject("home.Image")));
            this.home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.home.Location = new System.Drawing.Point(12, 166);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(148, 54);
            this.home.TabIndex = 3;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = true;
            this.home.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(160, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1454, 23);
            this.panel2.TabIndex = 1;
            // 
            // profile
            // 
            this.profile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profile.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.profile.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.profile.DisabledForeColor = System.Drawing.Color.Gray;
            this.profile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profile.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.profile.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.profile.HoverTextColor = System.Drawing.Color.White;
            this.profile.Location = new System.Drawing.Point(662, 30);
            this.profile.Name = "profile";
            this.profile.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.profile.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.profile.NormalTextColor = System.Drawing.Color.White;
            this.profile.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.profile.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.profile.PressTextColor = System.Drawing.Color.White;
            this.profile.Size = new System.Drawing.Size(95, 40);
            this.profile.Style = MetroSet_UI.Design.Style.Light;
            this.profile.StyleManager = null;
            this.profile.TabIndex = 12;
            this.profile.Text = "Profile";
            this.profile.ThemeAuthor = "Narwin";
            this.profile.ThemeName = "MetroLite";
            this.profile.Click += new System.EventHandler(this.profile_Click);
            // 
            // logOutBtn
            // 
            this.logOutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logOutBtn.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.logOutBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.logOutBtn.DisabledForeColor = System.Drawing.Color.Gray;
            this.logOutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutBtn.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.logOutBtn.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.logOutBtn.HoverTextColor = System.Drawing.Color.White;
            this.logOutBtn.Location = new System.Drawing.Point(793, 30);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.logOutBtn.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.logOutBtn.NormalTextColor = System.Drawing.Color.White;
            this.logOutBtn.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.logOutBtn.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.logOutBtn.PressTextColor = System.Drawing.Color.White;
            this.logOutBtn.Size = new System.Drawing.Size(95, 40);
            this.logOutBtn.Style = MetroSet_UI.Design.Style.Light;
            this.logOutBtn.StyleManager = null;
            this.logOutBtn.TabIndex = 11;
            this.logOutBtn.Text = "Logout";
            this.logOutBtn.ThemeAuthor = "Narwin";
            this.logOutBtn.ThemeName = "MetroLite";
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // mainpanel
            // 
            this.mainpanel.Location = new System.Drawing.Point(160, 166);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(1442, 800);
            this.mainpanel.TabIndex = 4;
            this.mainpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Mainpanel_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(48, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Peru;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(160, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(188, 167);
            this.panel3.TabIndex = 2;
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(100, 23);
            this.title.TabIndex = 0;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1614, 978);
            this.Controls.Add(this.profile);
            this.Controls.Add(this.logOutBtn);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sunway Cafe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button account;
        private System.Windows.Forms.Button order;
        private System.Windows.Forms.Panel sidepanel;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Button item;
        private MetroSet_UI.Controls.MetroSetButton logOutBtn;
        private MetroSet_UI.Controls.MetroSetButton profile;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button kitchen;
    }
}

