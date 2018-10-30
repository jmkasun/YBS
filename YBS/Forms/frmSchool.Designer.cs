namespace YBS.Forms
{
    partial class frmSchool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSchool));
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.deleteBtn = new DevComponents.DotNetBar.ButtonX();
            this.cancelbtn = new DevComponents.DotNetBar.ButtonX();
            this.addbtn = new DevComponents.DotNetBar.ButtonX();
            this.findButton = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.nameTextBoxX = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX12 = new DevComponents.DotNetBar.LabelX();
            this.panelEx1.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.deleteBtn);
            this.panelEx1.Controls.Add(this.cancelbtn);
            this.panelEx1.Controls.Add(this.addbtn);
            this.panelEx1.Controls.Add(this.findButton);
            this.panelEx1.Controls.Add(this.groupPanel1);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(409, 157);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // deleteBtn
            // 
            this.deleteBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.deleteBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.deleteBtn.Enabled = false;
            this.deleteBtn.Location = new System.Drawing.Point(186, 120);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 25);
            this.deleteBtn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.deleteBtn.TabIndex = 42;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cancelbtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cancelbtn.Location = new System.Drawing.Point(282, 120);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(75, 25);
            this.cancelbtn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cancelbtn.TabIndex = 41;
            this.cancelbtn.Text = "Clear";
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // addbtn
            // 
            this.addbtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.addbtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.addbtn.Location = new System.Drawing.Point(90, 120);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(75, 25);
            this.addbtn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.addbtn.TabIndex = 40;
            this.addbtn.Text = "Insert";
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // findButton
            // 
            this.findButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.findButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.findButton.Location = new System.Drawing.Point(347, 7);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(54, 24);
            this.findButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.findButton.TabIndex = 38;
            this.findButton.Text = "Find";
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.nameTextBoxX);
            this.groupPanel1.Controls.Add(this.labelX12);
            this.groupPanel1.Location = new System.Drawing.Point(4, 36);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(397, 65);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.Class = "";
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.Class = "";
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.Class = "";
            this.groupPanel1.TabIndex = 37;
            // 
            // nameTextBoxX
            // 
            // 
            // 
            // 
            this.nameTextBoxX.Border.Class = "TextBoxBorder";
            this.nameTextBoxX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBoxX.Location = new System.Drawing.Point(115, 12);
            this.nameTextBoxX.Name = "nameTextBoxX";
            this.nameTextBoxX.Size = new System.Drawing.Size(274, 26);
            this.nameTextBoxX.TabIndex = 35;
            // 
            // labelX12
            // 
            this.labelX12.AutoSize = true;
            this.labelX12.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX12.BackgroundStyle.Class = "";
            this.labelX12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX12.Location = new System.Drawing.Point(9, 13);
            this.labelX12.Name = "labelX12";
            this.labelX12.Size = new System.Drawing.Size(54, 21);
            this.labelX12.TabIndex = 36;
            this.labelX12.Text = "Name :";
            // 
            // frmSchool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 157);
            this.Controls.Add(this.panelEx1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSchool";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YBS: School";
            this.Load += new System.EventHandler(this.frmSchool_Load);
            this.panelEx1.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.TextBoxX nameTextBoxX;
        private DevComponents.DotNetBar.LabelX labelX12;
        private DevComponents.DotNetBar.ButtonX findButton;
        private DevComponents.DotNetBar.ButtonX deleteBtn;
        private DevComponents.DotNetBar.ButtonX cancelbtn;
        private DevComponents.DotNetBar.ButtonX addbtn;

    }
}