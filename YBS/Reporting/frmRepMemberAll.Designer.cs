namespace YBS.Reporting
{
    partial class frmRepMemberAll : DevComponents.DotNetBar.Office2007Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRepMemberAll));
            this.memberRepAllBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportingDataset = new YBS.ReportingDataset();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.showbutton = new System.Windows.Forms.Button();
            this.eduQuaCombo = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX16 = new DevComponents.DotNetBar.LabelX();
            this.schoolCombo = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX14 = new DevComponents.DotNetBar.LabelX();
            this.sexCombo = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem10 = new DevComponents.Editors.ComboItem();
            this.comboItem9 = new DevComponents.Editors.ComboItem();
            this.civilStatusCombo = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem11 = new DevComponents.Editors.ComboItem();
            this.comboItem12 = new DevComponents.Editors.ComboItem();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.labelX27 = new DevComponents.DotNetBar.LabelX();
            this.bloodGroupCombo = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.comboItem4 = new DevComponents.Editors.ComboItem();
            this.comboItem5 = new DevComponents.Editors.ComboItem();
            this.comboItem6 = new DevComponents.Editors.ComboItem();
            this.comboItem7 = new DevComponents.Editors.ComboItem();
            this.comboItem8 = new DevComponents.Editors.ComboItem();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.contribText = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.abilityText = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.occuCombo = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX15 = new DevComponents.DotNetBar.LabelX();
            this.member_Rep_AllTableAdapter = new YBS.ReportingDatasetTableAdapters.Member_Rep_AllTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.memberRepAllBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportingDataset)).BeginInit();
            this.SuspendLayout();
            // 
            // memberRepAllBindingSource
            // 
            this.memberRepAllBindingSource.DataMember = "Member_Rep_All";
            this.memberRepAllBindingSource.DataSource = this.reportingDataset;
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
            reportDataSource1.Name = "ReportDataset";
            reportDataSource1.Value = this.memberRepAllBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "YBS.Reporting.Rpt.memberAll.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 76);
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
            this.reportViewer1.Size = new System.Drawing.Size(1274, 522);
            this.reportViewer1.TabIndex = 0;
            // 
            // showbutton
            // 
            this.showbutton.Location = new System.Drawing.Point(981, 7);
            this.showbutton.Name = "showbutton";
            this.showbutton.Size = new System.Drawing.Size(71, 63);
            this.showbutton.TabIndex = 7;
            this.showbutton.Text = "Show";
            this.showbutton.UseVisualStyleBackColor = true;
            this.showbutton.Click += new System.EventHandler(this.showbutton_Click);
            // 
            // eduQuaCombo
            // 
            this.eduQuaCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.eduQuaCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.eduQuaCombo.DisplayMember = "Text";
            this.eduQuaCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.eduQuaCombo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eduQuaCombo.FormattingEnabled = true;
            this.eduQuaCombo.ItemHeight = 20;
            this.eduQuaCombo.Location = new System.Drawing.Point(517, 7);
            this.eduQuaCombo.Name = "eduQuaCombo";
            this.eduQuaCombo.Size = new System.Drawing.Size(160, 26);
            this.eduQuaCombo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.eduQuaCombo.TabIndex = 95;
            // 
            // labelX16
            // 
            this.labelX16.AutoSize = true;
            this.labelX16.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX16.BackgroundStyle.Class = "";
            this.labelX16.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX16.ForeColor = System.Drawing.Color.Black;
            this.labelX16.Location = new System.Drawing.Point(385, 7);
            this.labelX16.Name = "labelX16";
            this.labelX16.Size = new System.Drawing.Size(126, 21);
            this.labelX16.TabIndex = 96;
            this.labelX16.Text = "Edu Qualifications :";
            // 
            // schoolCombo
            // 
            this.schoolCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.schoolCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.schoolCombo.DisplayMember = "Text";
            this.schoolCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.schoolCombo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schoolCombo.FormattingEnabled = true;
            this.schoolCombo.ItemHeight = 20;
            this.schoolCombo.Location = new System.Drawing.Point(283, 39);
            this.schoolCombo.Name = "schoolCombo";
            this.schoolCombo.Size = new System.Drawing.Size(123, 26);
            this.schoolCombo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.schoolCombo.TabIndex = 93;
            // 
            // labelX14
            // 
            this.labelX14.AutoSize = true;
            this.labelX14.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX14.BackgroundStyle.Class = "";
            this.labelX14.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX14.ForeColor = System.Drawing.Color.Black;
            this.labelX14.Location = new System.Drawing.Point(223, 39);
            this.labelX14.Name = "labelX14";
            this.labelX14.Size = new System.Drawing.Size(54, 21);
            this.labelX14.TabIndex = 94;
            this.labelX14.Text = "School :";
            // 
            // sexCombo
            // 
            this.sexCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.sexCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.sexCombo.DisplayMember = "Text";
            this.sexCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.sexCombo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexCombo.FormattingEnabled = true;
            this.sexCombo.ItemHeight = 20;
            this.sexCombo.Items.AddRange(new object[] {
            this.comboItem10,
            this.comboItem9});
            this.sexCombo.Location = new System.Drawing.Point(109, 39);
            this.sexCombo.Name = "sexCombo";
            this.sexCombo.Size = new System.Drawing.Size(75, 26);
            this.sexCombo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.sexCombo.TabIndex = 81;
            // 
            // comboItem10
            // 
            this.comboItem10.Text = "ස්ත්‍රී";
            // 
            // comboItem9
            // 
            this.comboItem9.Text = "පුරුෂ";
            // 
            // civilStatusCombo
            // 
            this.civilStatusCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.civilStatusCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.civilStatusCombo.DisplayMember = "Text";
            this.civilStatusCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.civilStatusCombo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.civilStatusCombo.FormattingEnabled = true;
            this.civilStatusCombo.ItemHeight = 20;
            this.civilStatusCombo.Items.AddRange(new object[] {
            this.comboItem11,
            this.comboItem12});
            this.civilStatusCombo.Location = new System.Drawing.Point(283, 7);
            this.civilStatusCombo.Name = "civilStatusCombo";
            this.civilStatusCombo.Size = new System.Drawing.Size(87, 26);
            this.civilStatusCombo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.civilStatusCombo.TabIndex = 82;
            // 
            // comboItem11
            // 
            this.comboItem11.Text = "විවාහක";
            // 
            // comboItem12
            // 
            this.comboItem12.Text = "අවිවාහක";
            // 
            // labelX9
            // 
            this.labelX9.AutoSize = true;
            this.labelX9.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.Class = "";
            this.labelX9.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX9.ForeColor = System.Drawing.Color.Black;
            this.labelX9.Location = new System.Drawing.Point(65, 43);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(34, 21);
            this.labelX9.TabIndex = 92;
            this.labelX9.Text = "Sex :";
            // 
            // labelX10
            // 
            this.labelX10.AutoSize = true;
            this.labelX10.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.Class = "";
            this.labelX10.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX10.ForeColor = System.Drawing.Color.Black;
            this.labelX10.Location = new System.Drawing.Point(195, 7);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(82, 21);
            this.labelX10.TabIndex = 91;
            this.labelX10.Text = "Civil Status :";
            // 
            // labelX27
            // 
            this.labelX27.AutoSize = true;
            this.labelX27.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX27.BackgroundStyle.Class = "";
            this.labelX27.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX27.ForeColor = System.Drawing.Color.Black;
            this.labelX27.Location = new System.Drawing.Point(12, 7);
            this.labelX27.Name = "labelX27";
            this.labelX27.Size = new System.Drawing.Size(91, 21);
            this.labelX27.TabIndex = 90;
            this.labelX27.Text = "Blood Group :";
            // 
            // bloodGroupCombo
            // 
            this.bloodGroupCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.bloodGroupCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.bloodGroupCombo.DisplayMember = "Text";
            this.bloodGroupCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.bloodGroupCombo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bloodGroupCombo.FormattingEnabled = true;
            this.bloodGroupCombo.ItemHeight = 20;
            this.bloodGroupCombo.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2,
            this.comboItem3,
            this.comboItem4,
            this.comboItem5,
            this.comboItem6,
            this.comboItem7,
            this.comboItem8});
            this.bloodGroupCombo.Location = new System.Drawing.Point(109, 7);
            this.bloodGroupCombo.Name = "bloodGroupCombo";
            this.bloodGroupCombo.Size = new System.Drawing.Size(75, 26);
            this.bloodGroupCombo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bloodGroupCombo.TabIndex = 83;
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "A+";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "B+";
            // 
            // comboItem3
            // 
            this.comboItem3.Text = "O+";
            // 
            // comboItem4
            // 
            this.comboItem4.Text = "AB+";
            // 
            // comboItem5
            // 
            this.comboItem5.Text = "A-";
            // 
            // comboItem6
            // 
            this.comboItem6.Text = "B-";
            // 
            // comboItem7
            // 
            this.comboItem7.Text = "AB-";
            // 
            // comboItem8
            // 
            this.comboItem8.Text = "O-";
            // 
            // labelX8
            // 
            this.labelX8.AutoSize = true;
            this.labelX8.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.Class = "";
            this.labelX8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX8.ForeColor = System.Drawing.Color.Black;
            this.labelX8.Location = new System.Drawing.Point(688, 39);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(89, 21);
            this.labelX8.TabIndex = 89;
            this.labelX8.Text = "Contribution :";
            // 
            // contribText
            // 
            // 
            // 
            // 
            this.contribText.Border.Class = "TextBoxBorder";
            this.contribText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contribText.Location = new System.Drawing.Point(782, 39);
            this.contribText.Multiline = true;
            this.contribText.Name = "contribText";
            this.contribText.Size = new System.Drawing.Size(171, 31);
            this.contribText.TabIndex = 86;
            // 
            // abilityText
            // 
            // 
            // 
            // 
            this.abilityText.Border.Class = "TextBoxBorder";
            this.abilityText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abilityText.Location = new System.Drawing.Point(782, 7);
            this.abilityText.Multiline = true;
            this.abilityText.Name = "abilityText";
            this.abilityText.Size = new System.Drawing.Size(171, 30);
            this.abilityText.TabIndex = 85;
            // 
            // labelX7
            // 
            this.labelX7.AutoSize = true;
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.Class = "";
            this.labelX7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX7.ForeColor = System.Drawing.Color.Black;
            this.labelX7.Location = new System.Drawing.Point(683, 7);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(62, 21);
            this.labelX7.TabIndex = 88;
            this.labelX7.Text = "Abilities :";
            // 
            // occuCombo
            // 
            this.occuCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.occuCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.occuCombo.DisplayMember = "Text";
            this.occuCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.occuCombo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.occuCombo.FormattingEnabled = true;
            this.occuCombo.ItemHeight = 20;
            this.occuCombo.Location = new System.Drawing.Point(517, 39);
            this.occuCombo.Name = "occuCombo";
            this.occuCombo.Size = new System.Drawing.Size(165, 26);
            this.occuCombo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.occuCombo.TabIndex = 84;
            // 
            // labelX15
            // 
            this.labelX15.AutoSize = true;
            this.labelX15.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX15.BackgroundStyle.Class = "";
            this.labelX15.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX15.ForeColor = System.Drawing.Color.Black;
            this.labelX15.Location = new System.Drawing.Point(420, 39);
            this.labelX15.Name = "labelX15";
            this.labelX15.Size = new System.Drawing.Size(91, 21);
            this.labelX15.TabIndex = 87;
            this.labelX15.Text = "Occupatition :";
            // 
            // member_Rep_AllTableAdapter
            // 
            this.member_Rep_AllTableAdapter.ClearBeforeFill = true;
            // 
            // frmRepMemberAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 598);
            this.Controls.Add(this.eduQuaCombo);
            this.Controls.Add(this.labelX16);
            this.Controls.Add(this.schoolCombo);
            this.Controls.Add(this.labelX14);
            this.Controls.Add(this.sexCombo);
            this.Controls.Add(this.civilStatusCombo);
            this.Controls.Add(this.labelX9);
            this.Controls.Add(this.labelX10);
            this.Controls.Add(this.labelX27);
            this.Controls.Add(this.bloodGroupCombo);
            this.Controls.Add(this.labelX8);
            this.Controls.Add(this.contribText);
            this.Controls.Add(this.abilityText);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.occuCombo);
            this.Controls.Add(this.labelX15);
            this.Controls.Add(this.showbutton);
            this.Controls.Add(this.reportViewer1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRepMemberAll";
            this.Text = "Member Report";
            this.Load += new System.EventHandler(this.frmRepMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.memberRepAllBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportingDataset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button showbutton;
        private DevComponents.DotNetBar.Controls.ComboBoxEx eduQuaCombo;
        private DevComponents.DotNetBar.LabelX labelX16;
        private DevComponents.DotNetBar.Controls.ComboBoxEx schoolCombo;
        private DevComponents.DotNetBar.LabelX labelX14;
        private DevComponents.DotNetBar.Controls.ComboBoxEx sexCombo;
        private DevComponents.Editors.ComboItem comboItem10;
        private DevComponents.Editors.ComboItem comboItem9;
        private DevComponents.DotNetBar.Controls.ComboBoxEx civilStatusCombo;
        private DevComponents.Editors.ComboItem comboItem11;
        private DevComponents.Editors.ComboItem comboItem12;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.LabelX labelX27;
        private DevComponents.DotNetBar.Controls.ComboBoxEx bloodGroupCombo;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.Editors.ComboItem comboItem3;
        private DevComponents.Editors.ComboItem comboItem4;
        private DevComponents.Editors.ComboItem comboItem5;
        private DevComponents.Editors.ComboItem comboItem6;
        private DevComponents.Editors.ComboItem comboItem7;
        private DevComponents.Editors.ComboItem comboItem8;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.Controls.TextBoxX contribText;
        private DevComponents.DotNetBar.Controls.TextBoxX abilityText;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.Controls.ComboBoxEx occuCombo;
        private DevComponents.DotNetBar.LabelX labelX15;
        private System.Windows.Forms.BindingSource memberRepAllBindingSource;
        private ReportingDataset reportingDataset;
        private ReportingDatasetTableAdapters.Member_Rep_AllTableAdapter member_Rep_AllTableAdapter;
    }
}