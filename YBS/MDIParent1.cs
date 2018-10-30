using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using DBCore.Classes;
using YBS.Common;
using YBS.Forms;
using YBS.Admin;
using DBCore;
//using YBS.Reporting;

namespace YBS
{
    public partial class MDIParent1 : Form
    {
        User user = null;

        private Form frmMember;
        private Form frmUser;
        private Form frmOccupatition;
        private Form frmSchool;
        private Form frmEduLevel;
        private Form frmRepMember;
        private Form frmRepMemberAll;


        //private int frmLocationX = 400;
        //private int frmLocationY = 400;

        public MDIParent1()
        {
            InitializeComponent();
        }

        //private void agaDivisionButtonItem_Click(object sender, EventArgs e)
        //{
        //    ShowAGADivisionForm();
        //}

        public void ViewChildForm(Form frmObj)
        {
            try
            {
                ViewChildForm(frmObj, false);
            }
            catch (Exception ex)
            {
                MessageView.ExceptionError(ex);
            }
        }



        public void ViewChildForm(Form frmObj, bool isMax)
        {
            try
            {

                frmObj.StartPosition = FormStartPosition.CenterScreen;
                frmObj.MdiParent = this;
                frmObj.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }





        private void mdiMain_Load_1(object sender, EventArgs e)
        {
            try
            {
                logginHandle();

                SetBGImage();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void logginHandle()
        {
            frmLoginWindow login = new frmLoginWindow(this);

            if (login.ShowDialog() == DialogResult.OK)
            {
                user = login.user;
            }

            PrepareTabs();
        }

        private void SetBGImage()
        {

            string bgImageFile = DBCore.Utility.GetAppsetting(DBCore.AppSetting.BgImage);

            if (!string.IsNullOrEmpty(bgImageFile) && File.Exists(bgImageFile))
            {

                this.BackgroundImage = Image.FromFile(DBCore.Utility.GetAppsetting(DBCore.AppSetting.BgImage));
            }
            else
            {
                //this.BackgroundImage = global::CCMPData.Properties.Resources.bg1231;
            }
        }

        private void PrepareTabs()
        {
            if (user.PermissionLevel == (int)UserLevel.SystemAdmin)
            {
                userButton.Enabled = true;
            }
            else
            {
                userButton.Enabled = false;
            }

            if (user.PermissionLevel > -1)
            {
                myDataButton.Enabled = true;
                youthBtn.Enabled = true;
                upasthanaBtn.Enabled = true;
                otherBtn.Enabled = true;

            }
            else
            {
                myDataButton.Enabled = false;
                youthBtn.Enabled = false;
                upasthanaBtn.Enabled = false;
                otherBtn.Enabled = false;
            }
        }

        private void youthButtonItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (frmMember == null || frmMember.MdiParent == null)
                {
                    frmMember = new frmMemberNDF(user.PermissionLevel,MemberType.Youth);
                    ViewChildForm(frmMember);
                }
                else
                {
                    frmMember.Activate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void asapuwaButtonItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (frmOccupatition == null || frmOccupatition.MdiParent == null)
                {
                    frmOccupatition = new frmOccupatition(user.PermissionLevel);
                    ViewChildForm(frmOccupatition);
                }
                else
                {
                    frmOccupatition.Activate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonItem3_Click(object sender, EventArgs e)
        {
            try
            {
                //if (frmReportViwer == null || frmReportViwer.MdiParent == null)
                //{
                //    //frmReportViwer = new frmReportViwer();
                //    //ViewChildForm(frmReportViwer);
                //}
                //else
                //{
                //    frmReportViwer.Activate();
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void userButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (frmUser == null || frmUser.MdiParent == null)
                {
                    frmUser = new frmUser();
                    ViewChildForm(frmUser);
                }
                else
                {
                    frmUser.Activate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonItem7_Click(object sender, EventArgs e)
        {
            if (MessageView.ShowQuestionMsg("Close Application ?") == System.Windows.Forms.DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void buttonItem13_Click(object sender, EventArgs e)
        {
            buttonItem7_Click(sender, e);
        }

        private void buttonItem3_Click_1(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }

            logginHandle();
        }

        private void buttonItem4_Click(object sender, EventArgs e)
        {
            try
            {
                if (frmSchool == null || frmSchool.MdiParent == null)
                {
                    frmSchool = new frmSchool(user.PermissionLevel);
                    ViewChildForm(frmSchool);
                }
                else
                {
                    frmSchool.Activate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonItem6_Click(object sender, EventArgs e)
        {
            try
            {
                if (frmEduLevel == null || frmEduLevel.MdiParent == null)
                {
                    frmEduLevel = new frmEduQualification(user.PermissionLevel);
                    ViewChildForm(frmEduLevel);
                }
                else
                {
                    frmEduLevel.Activate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void sysAbminTab_Click(object sender, EventArgs e)
        {

        }

        private void memberButtonItem_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (frmRepMember == null || frmRepMember.MdiParent == null)
            //    {
            //        frmRepMember = new frmRepMember();
            //        ViewChildForm(frmRepMember);
            //       // frmRepMember.Width = this.Width - 100;
            //        frmRepMember.Height = this.Height - 130;
            //        frmRepMember.Location = new Point(50, 5);
            //    }
            //    else
            //    {
            //        frmRepMember.Activate();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void buttonItem4_Click_1(object sender, EventArgs e)
        {
            //try
            //{
            //    if (frmRepMemberAll == null || frmRepMemberAll.MdiParent == null)
            //    {
            //        frmRepMemberAll = new frmRepMemberAll();
            //        ViewChildForm(frmRepMemberAll);
            //        // frmRepMember.Width = this.Width - 100;
            //        frmRepMemberAll.Height = this.Height - 150;
            //        frmRepMemberAll.Width = this.Width - 10;
            //        frmRepMemberAll.Location = new Point(5, 5);
            //    }
            //    else
            //    {
            //        frmRepMemberAll.Activate();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void upasthanaBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (frmMember == null || frmMember.MdiParent == null)
                {
                    frmMember = new frmMemberUpasthana(user.PermissionLevel, MemberType.Upasthana);
                    ViewChildForm(frmMember);
                }
                else
                {
                    frmMember.Activate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void otherBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (frmMember == null || frmMember.MdiParent == null)
                {
                    frmMember = new frmMemberOther(user.PermissionLevel, MemberType.Other);
                    ViewChildForm(frmMember);
                }
                else
                {
                    frmMember.Activate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
