﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlueLime
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void cboLocation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                webBrowser1.Navigate(cboLocation.Text);
            }
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();   
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(cboLocation.Text);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            Text = "GreenSky - " + webBrowser1.Document.Title;
        }
    }
}
