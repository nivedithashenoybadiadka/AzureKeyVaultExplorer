﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Microsoft.PS.Common.Vault.Explorer
{
    public partial class PasswordDialog : Form
    {
        public PasswordDialog()
        {
            InitializeComponent();
        }

        public string Password => uxTextBoxPassword.Text;

        private void uxCheckBoxDisplayPwd_CheckedChanged(object sender, EventArgs e)
        {
            uxTextBoxPassword.UseSystemPasswordChar = !uxCheckBoxDisplayPwd.Checked;
        }
    }
}
