using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DBCore.Classes;
using DevComponents.Editors;

namespace YBS.Reporting
{
    public partial class frmRepMemberAll : DevComponents.DotNetBar.Office2007Form
    {
        public frmRepMemberAll()
        {
            InitializeComponent();
        }

        private void frmRepMember_Load(object sender, EventArgs e)
        {

            RefreshOccupationList();
            RefreshEduQualificationList();
            RefreshSchoolList();
            //RefreshTagList();
           
        }


        private void RefreshOccupationList()
        {
            using (Occupation occ = new Occupation(true))
            {
                occ.BindToCombo(occuCombo);

                occuCombo.SelectedIndex = -1;
            }
        }

        private void RefreshSchoolList()
        {
            using (School sch = new School(true))
            {
                sch.BindToCombo(schoolCombo);

                schoolCombo.SelectedIndex = -1;
            }
        }

        //private void RefreshTagList()
        //{
        //    using (Tag tg = new Tag(true))
        //    {
        //        tg.BindToCombo(tagCombobox);

        //        tagCombobox.SelectedIndex = -1;
        //    }
        //}

        private void RefreshEduQualificationList()
        {
            using (EduQualifications edu = new EduQualifications(true))
            {
                edu.BindToCombo(eduQuaCombo);

                eduQuaCombo.SelectedIndex = -1;
            }
        }

        private void showbutton_Click(object sender, EventArgs e)
        {
            string bloodgroup = "";
              if (bloodGroupCombo.SelectedItem != null)
                        {
             ComboItem item = (ComboItem)bloodGroupCombo.SelectedItem;
             bloodgroup = item.Text;
              }
              member_Rep_AllTableAdapter.Fill(reportingDataset.Member_Rep_All, bloodgroup, occuCombo.SelectedValue == null ? -1 : (int)occuCombo.SelectedValue, sexCombo.SelectedIndex,
                                                civilStatusCombo.SelectedIndex, schoolCombo.SelectedValue == null ? -1 : (int)schoolCombo.SelectedValue, eduQuaCombo.SelectedValue == null ? -1 : (int)eduQuaCombo.SelectedValue,
                                                abilityText.Text, contribText.Text);
            this.reportViewer1.RefreshReport();
        }

    }
}
