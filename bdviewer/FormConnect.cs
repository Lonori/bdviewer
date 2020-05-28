﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bdviewer
{
    public partial class FormConnect : Form
    {
        public bool ClickedButton = false;

        public FormConnect()
        {
            InitializeComponent();
        }

        public string Hostname
        {
            get
            {
                return input_host.Text;
            }
        }

        public string Username
        {
            get
            {
                return input_user.Text;
            }
        }

        public string Password
        {
            get
            {
                return input_pass.Text;
            }
        }

        public string Status
        {
            set
            {
                label_status.Text = value;
            }
        }

        private void connect_Click(object sender, EventArgs e)
        {
            ClickedButton = true;
            Close();
        }
    }
}
