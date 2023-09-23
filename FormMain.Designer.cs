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
            textBoxDir = new TextBox();
            buttonOpen = new Button();
            groupBoxText = new GroupBox();
            textBoxBack = new TextBox();
            textBoxMid = new TextBox();
            textBoxFront = new TextBox();
            groupBoxPlace = new GroupBox();
            comboBoxCorner = new ComboBox();
            labelCorner = new Label();
            buttonFont = new Button();
            textBoxFont = new TextBox();
            groupBoxFont = new GroupBox();
            checkBoxJpg = new CheckBox();
            statusStripBottom = new StatusStrip();
            toolStripProgressBar = new ToolStripProgressBar();
            buttonStart = new Button();
            openFileDialog = new OpenFileDialog();
            fontDialog = new FontDialog();
            groupBoxText.SuspendLayout();
            groupBoxPlace.SuspendLayout();
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
            buttonOpen.Size = new Size(75, 23);
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
            // groupBoxPlace
            // 
            groupBoxPlace.Controls.Add(comboBoxCorner);
            groupBoxPlace.Controls.Add(labelCorner);
            groupBoxPlace.Location = new Point(13, 111);
            groupBoxPlace.Name = "groupBoxPlace";
            groupBoxPlace.Size = new Size(226, 129);
            groupBoxPlace.TabIndex = 3;
            groupBoxPlace.TabStop = false;
            groupBoxPlace.Text = "位置";
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
            buttonFont.Size = new Size(75, 23);
            buttonFont.TabIndex = 6;
            buttonFont.Text = "选择字体";
            buttonFont.UseVisualStyleBackColor = true;
            buttonFont.Click += buttonFont_Click;
            // 
            // textBoxFont
            // 
            textBoxFont.Location = new Point(15, 54);
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
            groupBoxFont.Size = new Size(241, 129);
            groupBoxFont.TabIndex = 8;
            groupBoxFont.TabStop = false;
            groupBoxFont.Text = "字体";
            // 
            // checkBoxJpg
            // 
            checkBoxJpg.AutoSize = true;
            checkBoxJpg.Checked = true;
            checkBoxJpg.CheckState = CheckState.Checked;
            checkBoxJpg.Enabled = false;
            checkBoxJpg.Location = new Point(13, 246);
            checkBoxJpg.Name = "checkBoxJpg";
            checkBoxJpg.Size = new Size(85, 24);
            checkBoxJpg.TabIndex = 0;
            checkBoxJpg.Text = "转为jpg";
            checkBoxJpg.UseVisualStyleBackColor = true;
            // 
            // statusStripBottom
            // 
            statusStripBottom.ImageScalingSize = new Size(20, 20);
            statusStripBottom.Items.AddRange(new ToolStripItem[] { toolStripProgressBar });
            statusStripBottom.Location = new Point(0, 293);
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
            buttonStart.Size = new Size(75, 23);
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
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 317);
            Controls.Add(checkBoxJpg);
            Controls.Add(buttonStart);
            Controls.Add(statusStripBottom);
            Controls.Add(groupBoxFont);
            Controls.Add(groupBoxPlace);
            Controls.Add(groupBoxText);
            Controls.Add(buttonOpen);
            Controls.Add(textBoxDir);
            Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FormMain";
            Text = "MonkeyImage v1.0";
            groupBoxText.ResumeLayout(false);
            groupBoxText.PerformLayout();
            groupBoxPlace.ResumeLayout(false);
            groupBoxPlace.PerformLayout();
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
        private GroupBox groupBoxPlace;
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
    }
}

