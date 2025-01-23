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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.textBoxDir = new System.Windows.Forms.TextBox();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.groupBoxText = new System.Windows.Forms.GroupBox();
            this.textBoxBack = new System.Windows.Forms.TextBox();
            this.textBoxMid = new System.Windows.Forms.TextBox();
            this.textBoxFront = new System.Windows.Forms.TextBox();
            this.groupBoxGraph = new System.Windows.Forms.GroupBox();
            this.checkBoxDrawText = new System.Windows.Forms.CheckBox();
            this.numericQuality = new System.Windows.Forms.NumericUpDown();
            this.labelQuality = new System.Windows.Forms.Label();
            this.checkBoxJpg = new System.Windows.Forms.CheckBox();
            this.comboBoxCorner = new System.Windows.Forms.ComboBox();
            this.labelCorner = new System.Windows.Forms.Label();
            this.buttonFont = new System.Windows.Forms.Button();
            this.textBoxFont = new System.Windows.Forms.TextBox();
            this.groupBoxFont = new System.Windows.Forms.GroupBox();
            this.statusStripBottom = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.buttonStart = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.groupBoxText.SuspendLayout();
            this.groupBoxGraph.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuality)).BeginInit();
            this.groupBoxFont.SuspendLayout();
            this.statusStripBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxDir
            // 
            this.textBoxDir.Location = new System.Drawing.Point(10, 10);
            this.textBoxDir.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDir.Name = "textBoxDir";
            this.textBoxDir.Size = new System.Drawing.Size(315, 23);
            this.textBoxDir.TabIndex = 0;
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(329, 10);
            this.buttonOpen.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(60, 22);
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
            this.groupBoxText.Location = new System.Drawing.Point(10, 34);
            this.groupBoxText.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxText.Name = "groupBoxText";
            this.groupBoxText.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxText.Size = new System.Drawing.Size(378, 50);
            this.groupBoxText.TabIndex = 2;
            this.groupBoxText.TabStop = false;
            this.groupBoxText.Text = "文本";
            // 
            // textBoxBack
            // 
            this.textBoxBack.Location = new System.Drawing.Point(252, 18);
            this.textBoxBack.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBack.Name = "textBoxBack";
            this.textBoxBack.Size = new System.Drawing.Size(122, 23);
            this.textBoxBack.TabIndex = 2;
            // 
            // textBoxMid
            // 
            this.textBoxMid.Location = new System.Drawing.Point(129, 18);
            this.textBoxMid.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMid.Name = "textBoxMid";
            this.textBoxMid.ReadOnly = true;
            this.textBoxMid.Size = new System.Drawing.Size(115, 23);
            this.textBoxMid.TabIndex = 1;
            this.textBoxMid.Text = "日期";
            this.textBoxMid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxFront
            // 
            this.textBoxFront.Location = new System.Drawing.Point(6, 18);
            this.textBoxFront.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFront.Name = "textBoxFront";
            this.textBoxFront.Size = new System.Drawing.Size(115, 23);
            this.textBoxFront.TabIndex = 0;
            // 
            // groupBoxGraph
            // 
            this.groupBoxGraph.Controls.Add(this.checkBoxDrawText);
            this.groupBoxGraph.Controls.Add(this.numericQuality);
            this.groupBoxGraph.Controls.Add(this.labelQuality);
            this.groupBoxGraph.Controls.Add(this.checkBoxJpg);
            this.groupBoxGraph.Controls.Add(this.comboBoxCorner);
            this.groupBoxGraph.Controls.Add(this.labelCorner);
            this.groupBoxGraph.Location = new System.Drawing.Point(10, 89);
            this.groupBoxGraph.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxGraph.Name = "groupBoxGraph";
            this.groupBoxGraph.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxGraph.Size = new System.Drawing.Size(181, 110);
            this.groupBoxGraph.TabIndex = 3;
            this.groupBoxGraph.TabStop = false;
            this.groupBoxGraph.Text = "图像";
            // 
            // checkBoxDrawText
            // 
            this.checkBoxDrawText.AutoSize = true;
            this.checkBoxDrawText.Checked = true;
            this.checkBoxDrawText.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDrawText.Location = new System.Drawing.Point(78, 78);
            this.checkBoxDrawText.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxDrawText.Name = "checkBoxDrawText";
            this.checkBoxDrawText.Size = new System.Drawing.Size(75, 21);
            this.checkBoxDrawText.TabIndex = 4;
            this.checkBoxDrawText.Text = "绘制文本";
            this.checkBoxDrawText.UseVisualStyleBackColor = true;
            // 
            // numericQuality
            // 
            this.numericQuality.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericQuality.Location = new System.Drawing.Point(42, 51);
            this.numericQuality.Margin = new System.Windows.Forms.Padding(2);
            this.numericQuality.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericQuality.Name = "numericQuality";
            this.numericQuality.Size = new System.Drawing.Size(80, 23);
            this.numericQuality.TabIndex = 3;
            this.numericQuality.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // labelQuality
            // 
            this.labelQuality.AutoSize = true;
            this.labelQuality.Location = new System.Drawing.Point(6, 53);
            this.labelQuality.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelQuality.Name = "labelQuality";
            this.labelQuality.Size = new System.Drawing.Size(35, 17);
            this.labelQuality.TabIndex = 2;
            this.labelQuality.Text = "质量:";
            // 
            // checkBoxJpg
            // 
            this.checkBoxJpg.AutoSize = true;
            this.checkBoxJpg.Checked = true;
            this.checkBoxJpg.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxJpg.Enabled = false;
            this.checkBoxJpg.Location = new System.Drawing.Point(6, 78);
            this.checkBoxJpg.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxJpg.Name = "checkBoxJpg";
            this.checkBoxJpg.Size = new System.Drawing.Size(70, 21);
            this.checkBoxJpg.TabIndex = 0;
            this.checkBoxJpg.Text = "转为jpg";
            this.checkBoxJpg.UseVisualStyleBackColor = true;
            // 
            // comboBoxCorner
            // 
            this.comboBoxCorner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCorner.FormattingEnabled = true;
            this.comboBoxCorner.Items.AddRange(new object[] {
            "顶部左边",
            "顶部中间",
            "顶部右边",
            "底部左边",
            "底部中间",
            "底部右边"});
            this.comboBoxCorner.Location = new System.Drawing.Point(42, 20);
            this.comboBoxCorner.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxCorner.Name = "comboBoxCorner";
            this.comboBoxCorner.Size = new System.Drawing.Size(81, 25);
            this.comboBoxCorner.TabIndex = 1;
            // 
            // labelCorner
            // 
            this.labelCorner.AutoSize = true;
            this.labelCorner.Location = new System.Drawing.Point(6, 25);
            this.labelCorner.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCorner.Name = "labelCorner";
            this.labelCorner.Size = new System.Drawing.Size(39, 17);
            this.labelCorner.TabIndex = 0;
            this.labelCorner.Text = "方位 :";
            // 
            // buttonFont
            // 
            this.buttonFont.Location = new System.Drawing.Point(12, 20);
            this.buttonFont.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFont.Name = "buttonFont";
            this.buttonFont.Size = new System.Drawing.Size(68, 24);
            this.buttonFont.TabIndex = 6;
            this.buttonFont.Text = "选择字体";
            this.buttonFont.UseVisualStyleBackColor = true;
            this.buttonFont.Click += new System.EventHandler(this.buttonFont_Click);
            // 
            // textBoxFont
            // 
            this.textBoxFont.Location = new System.Drawing.Point(12, 53);
            this.textBoxFont.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFont.Multiline = true;
            this.textBoxFont.Name = "textBoxFont";
            this.textBoxFont.ReadOnly = true;
            this.textBoxFont.Size = new System.Drawing.Size(174, 51);
            this.textBoxFont.TabIndex = 7;
            // 
            // groupBoxFont
            // 
            this.groupBoxFont.Controls.Add(this.buttonFont);
            this.groupBoxFont.Controls.Add(this.textBoxFont);
            this.groupBoxFont.Location = new System.Drawing.Point(196, 89);
            this.groupBoxFont.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxFont.Name = "groupBoxFont";
            this.groupBoxFont.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxFont.Size = new System.Drawing.Size(193, 110);
            this.groupBoxFont.TabIndex = 8;
            this.groupBoxFont.TabStop = false;
            this.groupBoxFont.Text = "字体";
            // 
            // statusStripBottom
            // 
            this.statusStripBottom.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStripBottom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar});
            this.statusStripBottom.Location = new System.Drawing.Point(0, 241);
            this.statusStripBottom.Name = "statusStripBottom";
            this.statusStripBottom.Padding = new System.Windows.Forms.Padding(1, 0, 11, 0);
            this.statusStripBottom.Size = new System.Drawing.Size(398, 22);
            this.statusStripBottom.SizingGrip = false;
            this.statusStripBottom.TabIndex = 10;
            this.statusStripBottom.Text = "statusStrip";
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(395, 16);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(329, 214);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(60, 28);
            this.buttonStart.TabIndex = 11;
            this.buttonStart.Text = "开始";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "图片|*.heic;*.jpg;*.jpeg;*.png;";
            this.openFileDialog.Multiselect = true;
            // 
            // buttonAbout
            // 
            this.buttonAbout.Location = new System.Drawing.Point(10, 214);
            this.buttonAbout.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(40, 28);
            this.buttonAbout.TabIndex = 12;
            this.buttonAbout.Text = "关于";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // bgWorker
            // 
            this.bgWorker.WorkerReportsProgress = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(398, 263);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.statusStripBottom);
            this.Controls.Add(this.groupBoxFont);
            this.Controls.Add(this.groupBoxGraph);
            this.Controls.Add(this.groupBoxText);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.textBoxDir);
            this.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MonkeyImage " + version;
            this.groupBoxText.ResumeLayout(false);
            this.groupBoxText.PerformLayout();
            this.groupBoxGraph.ResumeLayout(false);
            this.groupBoxGraph.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuality)).EndInit();
            this.groupBoxFont.ResumeLayout(false);
            this.groupBoxFont.PerformLayout();
            this.statusStripBottom.ResumeLayout(false);
            this.statusStripBottom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxDir;
        private Button buttonOpen;
        private GroupBox groupBoxText;
        private TextBox textBoxBack;
        private TextBox textBoxMid;
        private TextBox textBoxFront;
        private GroupBox groupBoxGraph;
        private ComboBox comboBoxCorner;
        private Label labelCorner;
        private Button buttonFont;
        private TextBox textBoxFont;
        private GroupBox groupBoxFont;
        private CheckBox checkBoxJpg;
        private StatusStrip statusStripBottom;
        private ToolStripProgressBar toolStripProgressBar;
        private Button buttonStart;
        private OpenFileDialog openFileDialog;
        private FontDialog fontDialog;
        private NumericUpDown numericQuality;
        private Label labelQuality;
        private CheckBox checkBoxDrawText;
        private Button buttonAbout;
        private System.ComponentModel.BackgroundWorker bgWorker;
    }
}

