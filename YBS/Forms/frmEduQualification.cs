using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DBCore.Classes;
using YBS.Common;
using System.Collections;

namespace YBS.Forms
{
    public partial class frmEduQualification : DevComponents.DotNetBar.Office2007Form
    {
        int occuID = 0;

         DBCore.UserLevel userLevel = DBCore.UserLevel.SystemUser;

         public frmEduQualification(int permissionLevel)
        {
            userLevel = (DBCore.UserLevel)permissionLevel;
            InitializeComponent();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateBeforeAdd())
                {
                    using (EduQualifications edu = new EduQualifications(true))
                    {

                        edu.Name = nameTextBoxX.Text;

                        if (occuID == 0)
                        {
                            if (edu.Add() == 1)
                            {
                                MessageView.ShowMsg("Sucessfully Added");

                                //errorProvider1.SetError(idTxt, string.Empty);
                                //errorProvider1.SetError(nameTxt, string.Empty);

                                clear();
                            }

                        }
                        else
                        {
                            edu.ID = occuID;

                            if (MessageView.ShowQuestionMsg("Update EduQualifications") == DialogResult.OK)
                            {

                                if (edu.Update() == 1)
                                {
                                    MessageView.ShowMsg("Sucessfully Updated");

                                    //errorProvider1.SetError(idTxt, string.Empty);
                                    //errorProvider1.SetError(nameTxt, string.Empty);

                                    clear();
                                }
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageView.ShowErrorMsg(ex.Message);
            }
        }

        private void clear()
        {
            occuID = 0;
            addbtn.Text = "Insert";
            deleteBtn.Enabled = false;

            nameTextBoxX.Clear();
            setUserPermissions();
        }

        private bool ValidateBeforeAdd()
        {
            return true;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            using (EduQualifications edu = new EduQualifications(true))
            {
                edu.ID = occuID;

                if (MessageView.ShowQuestionMsg("Delete Details of '" + nameTextBoxX.Text + "'") == DialogResult.OK)
                {
                    edu.Delete();
                    clear();
                    MessageView.ShowMsg("Sucessfully Deleted");
                }
            }
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void findButton_Click(object sender, EventArgs e)
        {

            try
            {
                using (EduQualifications edu = new EduQualifications(true))
                {
                    edu.Name = nameTextBoxX.Text;

                    DataTable ds = edu.SelectFind();
                    frmSearch frmSub = new frmSearch(ds, this.Text,1);
                    frmSub.Width = 800;
                    HandleSearch(frmSub);
                }
            }
            catch (Exception ex)
            {
                MessageView.ExceptionError(ex);
            }
        }

        // hadle operations after search
        private void HandleSearch(frmSearch frmSub)
        {
            //ApplicationSettings.ChildFormView(this.MdiParent, ref frmSub);
            if (frmSub.ShowDialog() == DialogResult.OK)
            {
                FillSearchFilds(frmSub.DataRowValues);

                if (userLevel == DBCore.UserLevel.SystemAdmin || userLevel == DBCore.UserLevel.SystemUser_IUD)
                {
                    deleteBtn.Enabled = true;
                    addbtn.Text = "Update";
                }
            }
            frmSub.Dispose();
        }

        public void FillSearchFilds(Hashtable hashtable)
        {
            try
            {
                occuID = (int)hashtable["ID"];
                nameTextBoxX.Text = hashtable["Name"].ToString();
            }
            catch (Exception ex)
            {
                MessageView.ExceptionError(ex);
            }
        }

        private void setUserPermissions()
        {
            if (userLevel == DBCore.UserLevel.SystemUser)
            {
                addbtn.Enabled = deleteBtn.Enabled = false;
            }

            if (userLevel == DBCore.UserLevel.SystemUser_I)
            {
                addbtn.Enabled = true;
                deleteBtn.Enabled = false;
            }

            if (userLevel == DBCore.UserLevel.SystemUser_IUD || userLevel == DBCore.UserLevel.SystemAdmin)
            {
                addbtn.Enabled =  true;
            }
        }

        private void frmEduQualification_Load(object sender, EventArgs e)
        {
            setUserPermissions();
        }
    }
}
