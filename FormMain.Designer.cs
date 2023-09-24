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
            textBoxDir = new TextBox();
            buttonOpen = new Button();
            groupBoxText = new GroupBox();
            textBoxBack = new TextBox();
            textBoxMid = new TextBox();
            textBoxFront = new TextBox();
            groupBoxGraph = new GroupBox();
            numericQuality = new NumericUpDown();
            labelQuality = new Label();
            checkBoxJpg = new CheckBox();
            comboBoxCorner = new ComboBox();
            labelCorner = new Label();
            buttonFont = new Button();
            textBoxFont = new TextBox();
            groupBoxFont = new GroupBox();
            statusStripBottom = new StatusStrip();
            toolStripProgressBar = new ToolStripProgressBar();
            buttonStart = new Button();
            openFileDialog = new OpenFileDialog();
            fontDialog = new FontDialog();
            checkBoxDrawText = new CheckBox();
            groupBoxText.SuspendLayout();
            groupBoxGraph.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericQuality).BeginInit();
            groupBoxFont.SuspendLayout();
            statusStripBottom.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxDir
            // 
            textBoxDir.Location = new Point(12, 12);
            textBoxDir.Name = "textBoxDir";
            textBoxDir.Size = new Size(393, 27);
            textBoxDir.TabIndex = 0;
            // 
            // buttonOpen
            // 
            buttonOpen.Location = new Point(411, 12);
            buttonOpen.Name = "buttonOpen";
            buttonOpen.Size = new Size(75, 27);
            buttonOpen.TabIndex = 1;
            buttonOpen.Text = "打开";
            buttonOpen.UseVisualStyleBackColor = true;
            buttonOpen.Click += buttonOpen_Click;
            // 
            // groupBoxText
            // 
            groupBoxText.Controls.Add(textBoxBack);
            groupBoxText.Controls.Add(textBoxMid);
            groupBoxText.Controls.Add(textBoxFront);
            groupBoxText.Location = new Point(13, 42);
            groupBoxText.Name = "groupBoxText";
            groupBoxText.Size = new Size(473, 62);
            groupBoxText.TabIndex = 2;
            groupBoxText.TabStop = false;
            groupBoxText.Text = "文本";
            // 
            // textBoxBack
            // 
            textBoxBack.Location = new Point(315, 23);
            textBoxBack.Name = "textBoxBack";
            textBoxBack.Size = new Size(151, 27);
            textBoxBack.TabIndex = 2;
            // 
            // textBoxMid
            // 
            textBoxMid.Location = new Point(161, 23);
            textBoxMid.Name = "textBoxMid";
            textBoxMid.ReadOnly = true;
            textBoxMid.Size = new Size(143, 27);
            textBoxMid.TabIndex = 1;
            textBoxMid.Text = "日期";
            textBoxMid.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxFront
            // 
            textBoxFront.Location = new Point(7, 23);
            textBoxFront.Name = "textBoxFront";
            textBoxFront.Size = new Size(143, 27);
            textBoxFront.TabIndex = 0;
            // 
            // groupBoxGraph
            // 
            groupBoxGraph.Controls.Add(checkBoxDrawText);
            groupBoxGraph.Controls.Add(numericQuality);
            groupBoxGraph.Controls.Add(labelQuality);
            groupBoxGraph.Controls.Add(checkBoxJpg);
            groupBoxGraph.Controls.Add(comboBoxCorner);
            groupBoxGraph.Controls.Add(labelCorner);
            groupBoxGraph.Location = new Point(13, 111);
            groupBoxGraph.Name = "groupBoxGraph";
            groupBoxGraph.Size = new Size(226, 138);
            groupBoxGraph.TabIndex = 3;
            groupBoxGraph.TabStop = false;
            groupBoxGraph.Text = "图像";
            // 
            // numericQuality
            // 
            numericQuality.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            numericQuality.Location = new Point(52, 64);
            numericQuality.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            numericQuality.Name = "numericQuality";
            numericQuality.Size = new Size(100, 27);
            numericQuality.TabIndex = 3;
            numericQuality.Value = new decimal(new int[] { 80, 0, 0, 0 });
            // 
            // labelQuality
            // 
            labelQuality.AutoSize = true;
            labelQuality.Location = new Point(7, 66);
            labelQuality.Name = "labelQuality";
            labelQuality.Size = new Size(43, 20);
            labelQuality.TabIndex = 2;
            labelQuality.Text = "质量:";
            // 
            // checkBoxJpg
            // 
            checkBoxJpg.AutoSize = true;
            checkBoxJpg.Checked = true;
            checkBoxJpg.CheckState = CheckState.Checked;
            checkBoxJpg.Enabled = false;
            checkBoxJpg.Location = new Point(7, 97);
            checkBoxJpg.Name = "checkBoxJpg";
            checkBoxJpg.Size = new Size(85, 24);
            checkBoxJpg.TabIndex = 0;
            checkBoxJpg.Text = "转为jpg";
            checkBoxJpg.UseVisualStyleBackColor = true;
            // 
            // comboBoxCorner
            // 
            comboBoxCorner.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCorner.FormattingEnabled = true;
            comboBoxCorner.Items.AddRange(new object[] { "顶部左边", "顶部中间", "顶部右边", "底部左边", "底部中间", "底部右边" });
            comboBoxCorner.Location = new Point(52, 25);
            comboBoxCorner.Name = "comboBoxCorner";
            comboBoxCorner.Size = new Size(100, 28);
            comboBoxCorner.TabIndex = 1;
            // 
            // labelCorner
            // 
            labelCorner.AutoSize = true;
            labelCorner.Location = new Point(7, 31);
            labelCorner.Name = "labelCorner";
            labelCorner.Size = new Size(47, 20);
            labelCorner.TabIndex = 0;
            labelCorner.Text = "方位 :";
            // 
            // buttonFont
            // 
            buttonFont.Location = new Point(15, 25);
            buttonFont.Name = "buttonFont";
            buttonFont.Size = new Size(85, 28);
            buttonFont.TabIndex = 6;
            buttonFont.Text = "选择字体";
            buttonFont.UseVisualStyleBackColor = true;
            buttonFont.Click += buttonFont_Click;
            // 
            // textBoxFont
            // 
            textBoxFont.Location = new Point(15, 66);
            textBoxFont.Multiline = true;
            textBoxFont.Name = "textBoxFont";
            textBoxFont.ReadOnly = true;
            textBoxFont.Size = new Size(216, 63);
            textBoxFont.TabIndex = 7;
            // 
            // groupBoxFont
            // 
            groupBoxFont.Controls.Add(buttonFont);
            groupBoxFont.Controls.Add(textBoxFont);
            groupBoxFont.Location = new Point(245, 111);
            groupBoxFont.Name = "groupBoxFont";
            groupBoxFont.Size = new Size(241, 138);
            groupBoxFont.TabIndex = 8;
            groupBoxFont.TabStop = false;
            groupBoxFont.Text = "字体";
            // 
            // statusStripBottom
            // 
            statusStripBottom.ImageScalingSize = new Size(20, 20);
            statusStripBottom.Items.AddRange(new ToolStripItem[] { toolStripProgressBar });
            statusStripBottom.Location = new Point(0, 305);
            statusStripBottom.Name = "statusStripBottom";
            statusStripBottom.Size = new Size(498, 24);
            statusStripBottom.SizingGrip = false;
            statusStripBottom.TabIndex = 10;
            statusStripBottom.Text = "statusStrip";
            // 
            // toolStripProgressBar
            // 
            toolStripProgressBar.Name = "toolStripProgressBar";
            toolStripProgressBar.Size = new Size(494, 16);
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(411, 267);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(75, 35);
            buttonStart.TabIndex = 11;
            buttonStart.Text = "开始";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.Filter = "图片|*.heic;*.jpg;*.jpeg;*.png;";
            openFileDialog.Multiselect = true;
            // 
            // checkBoxDrawText
            // 
            checkBoxDrawText.AutoSize = true;
            checkBoxDrawText.Checked = true;
            checkBoxDrawText.CheckState = CheckState.Checked;
            checkBoxDrawText.Location = new Point(98, 97);
            checkBoxDrawText.Name = "checkBoxDrawText";
            checkBoxDrawText.Size = new Size(91, 24);
            checkBoxDrawText.TabIndex = 4;
            checkBoxDrawText.Text = "绘制文本";
            checkBoxDrawText.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(498, 329);
            Controls.Add(buttonStart);
            Controls.Add(statusStripBottom);
            Controls.Add(groupBoxFont);
            Controls.Add(groupBoxGraph);
            Controls.Add(groupBoxText);
            Controls.Add(buttonOpen);
            Controls.Add(textBoxDir);
            Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MonkeyImage v1.0";
            groupBoxText.ResumeLayout(false);
            groupBoxText.PerformLayout();
            groupBoxGraph.ResumeLayout(false);
            groupBoxGraph.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericQuality).EndInit();
            groupBoxFont.ResumeLayout(false);
            groupBoxFont.PerformLayout();
            statusStripBottom.ResumeLayout(false);
            statusStripBottom.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
    }
}

