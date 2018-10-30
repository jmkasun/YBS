using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace YBS.Reporting
{
    public partial class frmRepMember : DevComponents.DotNetBar.Office2007Form
    {
        public frmRepMember()
        {
            InitializeComponent();
        }

        private void frmRepMember_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'reportingDataset1.Member_sel_All' table. You can move, or remove it, as needed.
            this.member_sel_AllTableAdapter.Fill(this.reportingDataset1.Member_sel_All);
           
        }

        private void showbutton_Click(object sender, EventArgs e)
        {
            member_rep_sel_memberTableAdapter.Fill(reportingDataset.Member_rep_sel_member, (int)NICComboBox.SelectedValue);
            this.reportViewer1.RefreshReport();
        }
    }
}
