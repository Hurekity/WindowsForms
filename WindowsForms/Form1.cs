﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Width = this.Width-10;
            label2.Width = this.Width-10;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("hh:mm:ss");
            label2.Text = DateTime.Now.ToString("yyyy.MM.dd ddd");
            label2.Visible = cbShowDate.Checked;
        }
        void ConrtolsVisibility(bool visible)
        {
            cbShowDate.Visible = visible;
            btnExit.Visible = visible;
            btnHideControls.Visible = visible;
            this.ShowInTaskbar = visible;
            this.TransparencyKey = !visible ? SystemColors.Control : Color.White;
            this.FormBorderStyle = !visible ?  FormBorderStyle.None : FormBorderStyle.Sizable;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHideControls_Click(object sender, EventArgs e)
        {
            ConrtolsVisibility(false);
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            ConrtolsVisibility(true);
        }
    }
}
