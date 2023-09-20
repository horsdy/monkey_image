namespace monkey_image
{
    partial class FormMain
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
            this.textBoxDir = new System.Windows.Forms.TextBox();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.groupBoxText = new System.Windows.Forms.GroupBox();
            this.textBoxBack = new System.Windows.Forms.TextBox();
            this.textBoxMid = new System.Windows.Forms.TextBox();
            this.textBoxFront = new System.Windows.Forms.TextBox();
            this.groupBoxPlace = new System.Windows.Forms.GroupBox();
            this.textBoxVMargin = new System.Windows.Forms.TextBox();
            this.labelVMargin = new System.Windows.Forms.Label();
            this.textBoxHMargin = new System.Windows.Forms.TextBox();
            this.labelHMargin = new System.Windows.Forms.Label();
            this.comboBoxCorner = new System.Windows.Forms.ComboBox();
            this.labelCorner = new System.Windows.Forms.Label();
            this.buttonFont = new System.Windows.Forms.Button();
            this.textBoxFont = new System.Windows.Forms.TextBox();
            this.groupBoxFont = new System.Windows.Forms.GroupBox();
            this.groupBoxConvert = new System.Windows.Forms.GroupBox();
            this.checkBoxJpg = new System.Windows.Forms.CheckBox();
            this.statusStripBottom = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.buttonStart = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.groupBoxText.SuspendLayout();
            this.groupBoxPlace.SuspendLayout();
            this.groupBoxFont.SuspendLayout();
            this.groupBoxConvert.SuspendLayout();
            this.statusStripBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxDir
            // 
            this.textBoxDir.Location = new System.Drawing.Point(12, 12);
            this.textBoxDir.Name = "textBoxDir";
            this.textBoxDir.Size = new System.Drawing.Size(393, 23);
            this.textBoxDir.TabIndex = 0;
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(411, 12);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(75, 23);
            this.buttonOpen.TabIndex = 1;
            this.buttonOpen.Text = "打开";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // groupBoxText
            // 
            this.groupBoxText.Controls.Add(this.textBoxBack);
            this.groupBoxText.Controls.Add(this.textBoxMid);
            this.groupBoxText.Controls.Add(this.textBoxFront);
            this.groupBoxText.Location = new System.Drawing.Point(13, 42);
            this.groupBoxText.Name = "groupBoxText";
            this.groupBoxText.Size = new System.Drawing.Size(473, 62);
            this.groupBoxText.TabIndex = 2;
            this.groupBoxText.TabStop = false;
            this.groupBoxText.Text = "文本";
            // 
            // textBoxBack
            // 
            this.textBoxBack.Location = new System.Drawing.Point(315, 23);
            this.textBoxBack.Name = "textBoxBack";
            this.textBoxBack.Size = new System.Drawing.Size(151, 23);
            this.textBoxBack.TabIndex = 2;
            // 
            // textBoxMid
            // 
            this.textBoxMid.Location = new System.Drawing.Point(161, 23);
            this.textBoxMid.Name = "textBoxMid";
            this.textBoxMid.ReadOnly = true;
            this.textBoxMid.Size = new System.Drawing.Size(143, 23);
            this.textBoxMid.TabIndex = 1;
            this.textBoxMid.Text = "日期";
            this.textBoxMid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxFront
            // 
            this.textBoxFront.Location = new System.Drawing.Point(7, 23);
            this.textBoxFront.Name = "textBoxFront";
            this.textBoxFront.Size = new System.Drawing.Size(143, 23);
            this.textBoxFront.TabIndex = 0;
            // 
            // groupBoxPlace
            // 
            this.groupBoxPlace.Controls.Add(this.textBoxVMargin);
            this.groupBoxPlace.Controls.Add(this.labelVMargin);
            this.groupBoxPlace.Controls.Add(this.textBoxHMargin);
            this.groupBoxPlace.Controls.Add(this.labelHMargin);
            this.groupBoxPlace.Controls.Add(this.comboBoxCorner);
            this.groupBoxPlace.Controls.Add(this.labelCorner);
            this.groupBoxPlace.Location = new System.Drawing.Point(13, 111);
            this.groupBoxPlace.Name = "groupBoxPlace";
            this.groupBoxPlace.Size = new System.Drawing.Size(226, 129);
            this.groupBoxPlace.TabIndex = 3;
            this.groupBoxPlace.TabStop = false;
            this.groupBoxPlace.Text = "位置";
            // 
            // textBoxVMargin
            // 
            this.textBoxVMargin.Location = new System.Drawing.Point(118, 94);
            this.textBoxVMargin.Name = "textBoxVMargin";
            this.textBoxVMargin.Size = new System.Drawing.Size(100, 23);
            this.textBoxVMargin.TabIndex = 5;
            // 
            // labelVMargin
            // 
            this.labelVMargin.AutoSize = true;
            this.labelVMargin.Location = new System.Drawing.Point(8, 97);
            this.labelVMargin.Name = "labelVMargin";
            this.labelVMargin.Size = new System.Drawing.Size(116, 17);
            this.labelVMargin.TabIndex = 4;
            this.labelVMargin.Text = "离上下边界的距离：";
            // 
            // textBoxHMargin
            // 
            this.textBoxHMargin.Location = new System.Drawing.Point(118, 61);
            this.textBoxHMargin.Name = "textBoxHMargin";
            this.textBoxHMargin.Size = new System.Drawing.Size(100, 23);
            this.textBoxHMargin.TabIndex = 3;
            // 
            // labelHMargin
            // 
            this.labelHMargin.AutoSize = true;
            this.labelHMargin.Location = new System.Drawing.Point(8, 64);
            this.labelHMargin.Name = "labelHMargin";
            this.labelHMargin.Size = new System.Drawing.Size(116, 17);
            this.labelHMargin.TabIndex = 2;
            this.labelHMargin.Text = "离左右边界的距离：";
            // 
            // comboBoxCorner
            // 
            this.comboBoxCorner.DisplayMember = "右下角";
            this.comboBoxCorner.FormattingEnabled = true;
            this.comboBoxCorner.Items.AddRange(new object[] {
            "右下角"});
            this.comboBoxCorner.Location = new System.Drawing.Point(118, 23);
            this.comboBoxCorner.Name = "comboBoxCorner";
            this.comboBoxCorner.Size = new System.Drawing.Size(100, 25);
            this.comboBoxCorner.TabIndex = 1;
            this.comboBoxCorner.ValueMember = "右下角";
            // 
            // labelCorner
            // 
            this.labelCorner.AutoSize = true;
            this.labelCorner.Location = new System.Drawing.Point(73, 31);
            this.labelCorner.Name = "labelCorner";
            this.labelCorner.Size = new System.Drawing.Size(39, 17);
            this.labelCorner.TabIndex = 0;
            this.labelCorner.Text = "方位 :";
            // 
            // buttonFont
            // 
            this.buttonFont.Location = new System.Drawing.Point(15, 25);
            this.buttonFont.Name = "buttonFont";
            this.buttonFont.Size = new System.Drawing.Size(75, 23);
            this.buttonFont.TabIndex = 6;
            this.buttonFont.Text = "选择字体";
            this.buttonFont.UseVisualStyleBackColor = true;
            // 
            // textBoxFont
            // 
            this.textBoxFont.Location = new System.Drawing.Point(15, 54);
            this.textBoxFont.Multiline = true;
            this.textBoxFont.Name = "textBoxFont";
            this.textBoxFont.ReadOnly = true;
            this.textBoxFont.Size = new System.Drawing.Size(216, 63);
            this.textBoxFont.TabIndex = 7;
            // 
            // groupBoxFont
            // 
            this.groupBoxFont.Controls.Add(this.buttonFont);
            this.groupBoxFont.Controls.Add(this.textBoxFont);
            this.groupBoxFont.Location = new System.Drawing.Point(245, 111);
            this.groupBoxFont.Name = "groupBoxFont";
            this.groupBoxFont.Size = new System.Drawing.Size(241, 129);
            this.groupBoxFont.TabIndex = 8;
            this.groupBoxFont.TabStop = false;
            this.groupBoxFont.Text = "字体";
            // 
            // groupBoxConvert
            // 
            this.groupBoxConvert.Controls.Add(this.checkBoxJpg);
            this.groupBoxConvert.Location = new System.Drawing.Point(13, 247);
            this.groupBoxConvert.Name = "groupBoxConvert";
            this.groupBoxConvert.Size = new System.Drawing.Size(226, 100);
            this.groupBoxConvert.TabIndex = 9;
            this.groupBoxConvert.TabStop = false;
            this.groupBoxConvert.Text = "转换";
            // 
            // checkBoxJpg
            // 
            this.checkBoxJpg.AutoSize = true;
            this.checkBoxJpg.Location = new System.Drawing.Point(7, 23);
            this.checkBoxJpg.Name = "checkBoxJpg";
            this.checkBoxJpg.Size = new System.Drawing.Size(70, 21);
            this.checkBoxJpg.TabIndex = 0;
            this.checkBoxJpg.Text = "转为jpg";
            this.checkBoxJpg.UseVisualStyleBackColor = true;
            // 
            // statusStripBottom
            // 
            this.statusStripBottom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar});
            this.statusStripBottom.Location = new System.Drawing.Point(0, 391);
            this.statusStripBottom.Name = "statusStripBottom";
            this.statusStripBottom.Size = new System.Drawing.Size(498, 22);
            this.statusStripBottom.SizingGrip = false;
            this.statusStripBottom.TabIndex = 10;
            this.statusStripBottom.Text = "statusStrip";
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(494, 16);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(410, 359);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 11;
            this.buttonStart.Text = "开始";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "图片|*.heic;*.jpg;*.jpeg;";
            this.openFileDialog.Multiselect = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 413);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.statusStripBottom);
            this.Controls.Add(this.groupBoxConvert);
            this.Controls.Add(this.groupBoxFont);
            this.Controls.Add(this.groupBoxPlace);
            this.Controls.Add(this.groupBoxText);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.textBoxDir);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "MonkeyImage v1.0";
            this.groupBoxText.ResumeLayout(false);
            this.groupBoxText.PerformLayout();
            this.groupBoxPlace.ResumeLayout(false);
            this.groupBoxPlace.PerformLayout();
            this.groupBoxFont.ResumeLayout(false);
            this.groupBoxFont.PerformLayout();
            this.groupBoxConvert.ResumeLayout(false);
            this.groupBoxConvert.PerformLayout();
            this.statusStripBottom.ResumeLayout(false);
            this.statusStripBottom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDir;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.GroupBox groupBoxText;
        private System.Windows.Forms.TextBox textBoxBack;
        private System.Windows.Forms.TextBox textBoxMid;
        private System.Windows.Forms.TextBox textBoxFront;
        private System.Windows.Forms.GroupBox groupBoxPlace;
        private System.Windows.Forms.ComboBox comboBoxCorner;
        private System.Windows.Forms.Label labelCorner;
        private System.Windows.Forms.TextBox textBoxVMargin;
        private System.Windows.Forms.Label labelVMargin;
        private System.Windows.Forms.TextBox textBoxHMargin;
        private System.Windows.Forms.Label labelHMargin;
        private System.Windows.Forms.Button buttonFont;
        private System.Windows.Forms.TextBox textBoxFont;
        private System.Windows.Forms.GroupBox groupBoxFont;
        private System.Windows.Forms.GroupBox groupBoxConvert;
        private System.Windows.Forms.CheckBox checkBoxJpg;
        private System.Windows.Forms.StatusStrip statusStripBottom;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.FontDialog fontDialog;
    }
}

