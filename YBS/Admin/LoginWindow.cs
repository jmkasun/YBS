﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using YBS.Common;

namespace YBS.Admin
{
    public partial class frmLoginWindow : Form
    {
        public DBCore.Classes.User user = null;
        public Form mdiParent = null;

        public frmLoginWindow(Form parent)
        {
            mdiParent = parent;
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            try
            {
                using (user = new DBCore.Classes.User(true))
                {
                    user.UserName = usenameTxt.Text;
                    user.Password = pwdTxt.Text.GetHashCode();

                    if (user.Login())
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageView.ShowErrorMsg("Invalied Usename or Password");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageView.ShowErrorMsg(ex.Message);
            }
        }

        private void usenameTxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.mdiParent.Close();
        }
    }
}
