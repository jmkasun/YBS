namespace YBS.Reporting
{
    partial class frmRepMember : DevComponents.DotNetBar.Office2007Form
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRepMember));
            this.memberrepselmemberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportingDataset = new YBS.ReportingDataset();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.member_rep_sel_memberTableAdapter = new YBS.ReportingDatasetTableAdapters.Member_rep_sel_memberTableAdapter();
            this.memberIDcomboBox = new System.Windows.Forms.ComboBox();
            this.memberselAllBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportingDataset1 = new YBS.ReportingDataset();
            this.NameComboBox = new System.Windows.Forms.ComboBox();
            this.NICComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.showbutton = new System.Windows.Forms.Button();
            this.member_sel_AllTableAdapter = new YBS.ReportingDatasetTableAdapters.Member_sel_AllTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.memberrepselmemberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportingDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberselAllBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportingDataset1)).BeginInit();
            this.SuspendLayout();
            // 
            // memberrepselmemberBindingSource
            // 
            this.memberrepselmemberBindingSource.DataMember = "Member_rep_sel_member";
            this.memberrepselmemberBindingSource.DataSource = this.reportingDataset;
            // 
            // reportingDataset
            // 
            this.reportingDataset.DataSetName = "ReportingDataset";
            this.reportingDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "SelectMember";
            reportDataSource1.Value = this.memberrepselmemberBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "YBS.Reporting.Rpt.Member.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 51);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ShowBackButton = false;
            this.reportViewer1.ShowContextMenu = false;
            this.reportViewer1.ShowCredentialPrompts = false;
            this.reportViewer1.ShowDocumentMapButton = false;
            this.reportViewer1.ShowFindControls = false;
            this.reportViewer1.ShowPageNavigationControls = false;
            this.reportViewer1.ShowProgress = false;
            this.reportViewer1.ShowPromptAreaButton = false;
            this.reportViewer1.ShowStopButton = false;
            this.reportViewer1.ShowZoomControl = false;
            this.reportViewer1.Size = new System.Drawing.Size(723, 547);
            this.reportViewer1.TabIndex = 0;
            // 
            // member_rep_sel_memberTableAdapter
            // 
            this.member_rep_sel_memberTableAdapter.ClearBeforeFill = true;
            // 
            // memberIDcomboBox
            // 
            this.memberIDcomboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.memberIDcomboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.memberIDcomboBox.DataSource = this.memberselAllBindingSource;
            this.memberIDcomboBox.DisplayMember = "IndexNumber";
            this.memberIDcomboBox.FormattingEnabled = true;
            this.memberIDcomboBox.Location = new System.Drawing.Point(12, 24);
            this.memberIDcomboBox.Name = "memberIDcomboBox";
            this.memberIDcomboBox.Size = new System.Drawing.Size(121, 21);
            this.memberIDcomboBox.TabIndex = 1;
            this.memberIDcomboBox.ValueMember = "ID";
            // 
            // memberselAllBindingSource
            // 
            this.memberselAllBindingSource.DataMember = "Member_sel_All";
            this.memberselAllBindingSource.DataSource = this.reportingDataset1;
            // 
            // reportingDataset1
            // 
            this.reportingDataset1.DataSetName = "ReportingDataset";
            this.reportingDataset1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // NameComboBox
            // 
            this.NameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.NameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.NameComboBox.DataSource = this.memberselAllBindingSource;
            this.NameComboBox.DisplayMember = "Name";
            this.NameComboBox.FormattingEnabled = true;
            this.NameComboBox.Location = new System.Drawing.Point(322, 24);
            this.NameComboBox.Name = "NameComboBox";
            this.NameComboBox.Size = new System.Drawing.Size(247, 21);
            this.NameComboBox.TabIndex = 2;
            this.NameComboBox.ValueMember = "ID";
            // 
            // NICComboBox
            // 
            this.NICComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.NICComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.NICComboBox.DataSource = this.memberselAllBindingSource;
            this.NICComboBox.DisplayMember = "NIC";
            this.NICComboBox.FormattingEnabled = true;
            this.NICComboBox.Location = new System.Drawing.Point(167, 24);
            this.NICComboBox.Name = "NICComboBox";
            this.NICComboBox.Size = new System.Drawing.Size(121, 21);
            this.NICComboBox.TabIndex = 3;
            this.NICComboBox.ValueMember = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Index Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(164, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "NIC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(319, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name";
            // 
            // showbutton
            // 
            this.showbutton.Location = new System.Drawing.Point(592, 3);
            this.showbutton.Name = "showbutton";
            this.showbutton.Size = new System.Drawing.Size(81, 42);
            this.showbutton.TabIndex = 7;
            this.showbutton.Text = "Show";
            this.showbutton.UseVisualStyleBackColor = true;
            this.showbutton.Click += new System.EventHandler(this.showbutton_Click);
            // 
            // member_sel_AllTableAdapter
            // 
            this.member_sel_AllTableAdapter.ClearBeforeFill = true;
            // 
            // frmRepMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 598);
            this.Controls.Add(this.showbutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NICComboBox);
            this.Controls.Add(this.NameComboBox);
            this.Controls.Add(this.memberIDcomboBox);
            this.Controls.Add(this.reportViewer1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRepMember";
            this.Text = "Member Report";
            this.Load += new System.EventHandler(this.frmRepMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.memberrepselmemberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportingDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberselAllBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportingDataset1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource memberrepselmemberBindingSource;
        private ReportingDataset reportingDataset;
        private ReportingDatasetTableAdapters.Member_rep_sel_memberTableAdapter member_rep_sel_memberTableAdapter;
        private System.Windows.Forms.ComboBox memberIDcomboBox;
        private System.Windows.Forms.ComboBox NameComboBox;
        private System.Windows.Forms.ComboBox NICComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button showbutton;
        private ReportingDataset reportingDataset1;
        private System.Windows.Forms.BindingSource memberselAllBindingSource;
        private ReportingDatasetTableAdapters.Member_sel_AllTableAdapter member_sel_AllTableAdapter;
    }
}