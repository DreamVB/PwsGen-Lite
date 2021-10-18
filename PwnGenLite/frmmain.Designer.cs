namespace PwnGenLite
{
    partial class frmmain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmain));
            this.pTop = new System.Windows.Forms.Panel();
            this.lblAppInfo = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gPwnOptions = new System.Windows.Forms.GroupBox();
            this.chkSpecial = new System.Windows.Forms.CheckBox();
            this.chkDigits = new System.Windows.Forms.CheckBox();
            this.chkLower = new System.Windows.Forms.CheckBox();
            this.chkUpper = new System.Windows.Forms.CheckBox();
            this.gPwsLen = new System.Windows.Forms.GroupBox();
            this.lblValue = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.NumericUpDown();
            this.gPwsCount = new System.Windows.Forms.GroupBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.NumericUpDown();
            this.lstPasswords = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Password = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ImgLst = new System.Windows.Forms.ImageList(this.components);
            this.lblPasswords = new System.Windows.Forms.Label();
            this.sBar1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.cmdGen = new System.Windows.Forms.Button();
            this.cmdCpySelected = new System.Windows.Forms.Button();
            this.cmdSelectAll = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.cmdbout = new System.Windows.Forms.Button();
            this.lblHelp = new System.Windows.Forms.LinkLabel();
            this.pTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.gPwnOptions.SuspendLayout();
            this.gPwsLen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLength)).BeginInit();
            this.gPwsCount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCount)).BeginInit();
            this.sBar1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pTop
            // 
            this.pTop.BackColor = System.Drawing.Color.White;
            this.pTop.Controls.Add(this.lblHelp);
            this.pTop.Controls.Add(this.lblAppInfo);
            this.pTop.Controls.Add(this.picLogo);
            this.pTop.Controls.Add(this.lblTitle);
            this.pTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTop.Location = new System.Drawing.Point(0, 0);
            this.pTop.Name = "pTop";
            this.pTop.Size = new System.Drawing.Size(432, 48);
            this.pTop.TabIndex = 0;
            // 
            // lblAppInfo
            // 
            this.lblAppInfo.AutoSize = true;
            this.lblAppInfo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppInfo.ForeColor = System.Drawing.Color.Gray;
            this.lblAppInfo.Location = new System.Drawing.Point(206, 25);
            this.lblAppInfo.Name = "lblAppInfo";
            this.lblAppInfo.Size = new System.Drawing.Size(172, 13);
            this.lblAppInfo.TabIndex = 2;
            this.lblAppInfo.Text = "Free password generator";
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(12, 9);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(32, 32);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Orange;
            this.lblTitle.Location = new System.Drawing.Point(59, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(141, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "PwsGen Lite";
            // 
            // gPwnOptions
            // 
            this.gPwnOptions.Controls.Add(this.chkSpecial);
            this.gPwnOptions.Controls.Add(this.chkDigits);
            this.gPwnOptions.Controls.Add(this.chkLower);
            this.gPwnOptions.Controls.Add(this.chkUpper);
            this.gPwnOptions.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gPwnOptions.Location = new System.Drawing.Point(12, 63);
            this.gPwnOptions.Name = "gPwnOptions";
            this.gPwnOptions.Size = new System.Drawing.Size(239, 152);
            this.gPwnOptions.TabIndex = 1;
            this.gPwnOptions.TabStop = false;
            this.gPwnOptions.Text = "Character Set";
            // 
            // chkSpecial
            // 
            this.chkSpecial.AutoSize = true;
            this.chkSpecial.Location = new System.Drawing.Point(18, 103);
            this.chkSpecial.Name = "chkSpecial";
            this.chkSpecial.Size = new System.Drawing.Size(171, 18);
            this.chkSpecial.TabIndex = 3;
            this.chkSpecial.Text = "Special !@#$%^&*_-=+";
            this.chkSpecial.UseVisualStyleBackColor = true;
            this.chkSpecial.MouseLeave += new System.EventHandler(this.chkUpper_MouseLeave);
            this.chkSpecial.MouseHover += new System.EventHandler(this.chkUpper_MouseHover);
            // 
            // chkDigits
            // 
            this.chkDigits.AutoSize = true;
            this.chkDigits.Checked = true;
            this.chkDigits.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDigits.Location = new System.Drawing.Point(18, 79);
            this.chkDigits.Name = "chkDigits";
            this.chkDigits.Size = new System.Drawing.Size(99, 18);
            this.chkDigits.TabIndex = 2;
            this.chkDigits.Text = "Digits [0..9]";
            this.chkDigits.UseVisualStyleBackColor = true;
            this.chkDigits.MouseLeave += new System.EventHandler(this.chkUpper_MouseLeave);
            this.chkDigits.MouseHover += new System.EventHandler(this.chkUpper_MouseHover);
            // 
            // chkLower
            // 
            this.chkLower.AutoSize = true;
            this.chkLower.Checked = true;
            this.chkLower.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLower.Location = new System.Drawing.Point(18, 55);
            this.chkLower.Name = "chkLower";
            this.chkLower.Size = new System.Drawing.Size(170, 18);
            this.chkLower.TabIndex = 1;
            this.chkLower.Text = "Lowercase alpha [a..z]";
            this.chkLower.UseVisualStyleBackColor = true;
            this.chkLower.MouseLeave += new System.EventHandler(this.chkUpper_MouseLeave);
            this.chkLower.MouseHover += new System.EventHandler(this.chkUpper_MouseHover);
            // 
            // chkUpper
            // 
            this.chkUpper.AutoSize = true;
            this.chkUpper.Checked = true;
            this.chkUpper.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUpper.Location = new System.Drawing.Point(18, 31);
            this.chkUpper.Name = "chkUpper";
            this.chkUpper.Size = new System.Drawing.Size(170, 18);
            this.chkUpper.TabIndex = 0;
            this.chkUpper.Text = "Uppercase alpha [A..Z]";
            this.chkUpper.UseVisualStyleBackColor = true;
            this.chkUpper.MouseLeave += new System.EventHandler(this.chkUpper_MouseLeave);
            this.chkUpper.MouseHover += new System.EventHandler(this.chkUpper_MouseHover);
            // 
            // gPwsLen
            // 
            this.gPwsLen.Controls.Add(this.lblValue);
            this.gPwsLen.Controls.Add(this.txtLength);
            this.gPwsLen.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gPwsLen.Location = new System.Drawing.Point(258, 63);
            this.gPwsLen.Name = "gPwsLen";
            this.gPwsLen.Size = new System.Drawing.Size(162, 73);
            this.gPwsLen.TabIndex = 2;
            this.gPwsLen.TabStop = false;
            this.gPwsLen.Text = "Password Length";
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(16, 35);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(41, 14);
            this.lblValue.TabIndex = 1;
            this.lblValue.Text = "Value";
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(63, 33);
            this.txtLength.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.txtLength.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(81, 22);
            this.txtLength.TabIndex = 0;
            this.txtLength.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // gPwsCount
            // 
            this.gPwsCount.Controls.Add(this.lblCount);
            this.gPwsCount.Controls.Add(this.txtCount);
            this.gPwsCount.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gPwsCount.Location = new System.Drawing.Point(258, 142);
            this.gPwsCount.Name = "gPwsCount";
            this.gPwsCount.Size = new System.Drawing.Size(162, 73);
            this.gPwsCount.TabIndex = 3;
            this.gPwsCount.TabStop = false;
            this.gPwsCount.Text = "Password Amount";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(16, 35);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(41, 14);
            this.lblCount.TabIndex = 1;
            this.lblCount.Text = "Value";
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(63, 33);
            this.txtCount.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.txtCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(81, 22);
            this.txtCount.TabIndex = 0;
            this.txtCount.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // lstPasswords
            // 
            this.lstPasswords.CheckBoxes = true;
            this.lstPasswords.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Password});
            this.lstPasswords.FullRowSelect = true;
            this.lstPasswords.Location = new System.Drawing.Point(12, 253);
            this.lstPasswords.Name = "lstPasswords";
            this.lstPasswords.Size = new System.Drawing.Size(289, 187);
            this.lstPasswords.SmallImageList = this.ImgLst;
            this.lstPasswords.TabIndex = 4;
            this.lstPasswords.UseCompatibleStateImageBehavior = false;
            this.lstPasswords.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 41;
            // 
            // Password
            // 
            this.Password.Text = "Password";
            // 
            // ImgLst
            // 
            this.ImgLst.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgLst.ImageStream")));
            this.ImgLst.TransparentColor = System.Drawing.Color.Fuchsia;
            this.ImgLst.Images.SetKeyName(0, "pws.png");
            // 
            // lblPasswords
            // 
            this.lblPasswords.AutoSize = true;
            this.lblPasswords.Location = new System.Drawing.Point(12, 227);
            this.lblPasswords.Name = "lblPasswords";
            this.lblPasswords.Size = new System.Drawing.Size(120, 13);
            this.lblPasswords.TabIndex = 5;
            this.lblPasswords.Text = "Generatoted Passwords";
            // 
            // sBar1
            // 
            this.sBar1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.sBar1.Location = new System.Drawing.Point(0, 460);
            this.sBar1.Name = "sBar1";
            this.sBar1.Size = new System.Drawing.Size(432, 22);
            this.sBar1.TabIndex = 6;
            this.sBar1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(204, 17);
            this.toolStripStatusLabel1.Text = "PwsGen Lite | Version 1.0 | By DreamVB";
            // 
            // cmdGen
            // 
            this.cmdGen.FlatAppearance.BorderSize = 0;
            this.cmdGen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGen.ForeColor = System.Drawing.Color.DimGray;
            this.cmdGen.Location = new System.Drawing.Point(310, 253);
            this.cmdGen.Name = "cmdGen";
            this.cmdGen.Size = new System.Drawing.Size(113, 28);
            this.cmdGen.TabIndex = 7;
            this.cmdGen.Text = "Generate";
            this.cmdGen.UseVisualStyleBackColor = true;
            this.cmdGen.Click += new System.EventHandler(this.cmdGen_Click);
            // 
            // cmdCpySelected
            // 
            this.cmdCpySelected.FlatAppearance.BorderSize = 0;
            this.cmdCpySelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCpySelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCpySelected.ForeColor = System.Drawing.Color.DimGray;
            this.cmdCpySelected.Location = new System.Drawing.Point(310, 321);
            this.cmdCpySelected.Name = "cmdCpySelected";
            this.cmdCpySelected.Size = new System.Drawing.Size(113, 28);
            this.cmdCpySelected.TabIndex = 8;
            this.cmdCpySelected.Text = "Copy Selected";
            this.cmdCpySelected.UseVisualStyleBackColor = true;
            this.cmdCpySelected.Click += new System.EventHandler(this.cmdCpySelected_Click);
            // 
            // cmdSelectAll
            // 
            this.cmdSelectAll.FlatAppearance.BorderSize = 0;
            this.cmdSelectAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSelectAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSelectAll.ForeColor = System.Drawing.Color.DimGray;
            this.cmdSelectAll.Location = new System.Drawing.Point(310, 287);
            this.cmdSelectAll.Name = "cmdSelectAll";
            this.cmdSelectAll.Size = new System.Drawing.Size(113, 28);
            this.cmdSelectAll.TabIndex = 9;
            this.cmdSelectAll.Text = "Select All";
            this.cmdSelectAll.UseVisualStyleBackColor = true;
            this.cmdSelectAll.Click += new System.EventHandler(this.cmdSelectAll_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.FlatAppearance.BorderSize = 0;
            this.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSave.ForeColor = System.Drawing.Color.DimGray;
            this.cmdSave.Location = new System.Drawing.Point(310, 355);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(113, 28);
            this.cmdSave.TabIndex = 10;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdbout
            // 
            this.cmdbout.FlatAppearance.BorderSize = 0;
            this.cmdbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdbout.ForeColor = System.Drawing.Color.DimGray;
            this.cmdbout.Location = new System.Drawing.Point(310, 389);
            this.cmdbout.Name = "cmdbout";
            this.cmdbout.Size = new System.Drawing.Size(113, 28);
            this.cmdbout.TabIndex = 11;
            this.cmdbout.Text = "About";
            this.cmdbout.UseVisualStyleBackColor = true;
            this.cmdbout.Click += new System.EventHandler(this.cmdbout_Click);
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.Location = new System.Drawing.Point(394, 12);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(29, 13);
            this.lblHelp.TabIndex = 3;
            this.lblHelp.TabStop = true;
            this.lblHelp.Text = "Help";
            this.lblHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblHelp_LinkClicked);
            // 
            // frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 482);
            this.Controls.Add(this.cmdbout);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.cmdSelectAll);
            this.Controls.Add(this.cmdCpySelected);
            this.Controls.Add(this.cmdGen);
            this.Controls.Add(this.sBar1);
            this.Controls.Add(this.lblPasswords);
            this.Controls.Add(this.lstPasswords);
            this.Controls.Add(this.gPwsCount);
            this.Controls.Add(this.gPwsLen);
            this.Controls.Add(this.gPwnOptions);
            this.Controls.Add(this.pTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmmain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.pTop.ResumeLayout(false);
            this.pTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.gPwnOptions.ResumeLayout(false);
            this.gPwnOptions.PerformLayout();
            this.gPwsLen.ResumeLayout(false);
            this.gPwsLen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLength)).EndInit();
            this.gPwsCount.ResumeLayout(false);
            this.gPwsCount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCount)).EndInit();
            this.sBar1.ResumeLayout(false);
            this.sBar1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pTop;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAppInfo;
        private System.Windows.Forms.GroupBox gPwnOptions;
        private System.Windows.Forms.CheckBox chkDigits;
        private System.Windows.Forms.CheckBox chkLower;
        private System.Windows.Forms.CheckBox chkUpper;
        private System.Windows.Forms.CheckBox chkSpecial;
        private System.Windows.Forms.GroupBox gPwsLen;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.NumericUpDown txtLength;
        private System.Windows.Forms.GroupBox gPwsCount;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.NumericUpDown txtCount;
        private System.Windows.Forms.ListView lstPasswords;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Password;
        private System.Windows.Forms.Label lblPasswords;
        private System.Windows.Forms.StatusStrip sBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button cmdGen;
        private System.Windows.Forms.Button cmdCpySelected;
        private System.Windows.Forms.Button cmdSelectAll;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Button cmdbout;
        private System.Windows.Forms.ImageList ImgLst;
        private System.Windows.Forms.LinkLabel lblHelp;
    }
}

