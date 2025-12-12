namespace Tyuiu.PavlovaVV.Sprint6.Task7.V26
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBox1 = new GroupBox();
            dataGridViewOutPut_PVV = new DataGridView();
            groupBox2 = new GroupBox();
            dataGridViewInPut_PVV = new DataGridView();
            textBox1 = new TextBox();
            buttonSaveFile_PVV = new Button();
            buttonDone_PVV = new Button();
            ButtonOpenFile_PVV = new Button();
            buttonHelp_PVV = new Button();
            openFileDialogTask_PVV = new OpenFileDialog();
            toolTipButton_PVV = new ToolTip(components);
            saveFileDialogMatrix_PVV = new SaveFileDialog();
            groupBox3 = new GroupBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutPut_PVV).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInPut_PVV).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridViewOutPut_PVV);
            groupBox1.Location = new Point(945, 334);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(673, 628);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Вывод:";
            // 
            // dataGridViewOutPut_PVV
            // 
            dataGridViewOutPut_PVV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutPut_PVV.Location = new Point(6, 38);
            dataGridViewOutPut_PVV.Name = "dataGridViewOutPut_PVV";
            dataGridViewOutPut_PVV.RowHeadersWidth = 82;
            dataGridViewOutPut_PVV.Size = new Size(650, 570);
            dataGridViewOutPut_PVV.TabIndex = 6;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridViewInPut_PVV);
            groupBox2.Location = new Point(18, 334);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(895, 628);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ввод:";
            // 
            // dataGridViewInPut_PVV
            // 
            dataGridViewInPut_PVV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInPut_PVV.Location = new Point(6, 38);
            dataGridViewInPut_PVV.Name = "dataGridViewInPut_PVV";
            dataGridViewInPut_PVV.RowHeadersWidth = 82;
            dataGridViewInPut_PVV.Size = new Size(883, 570);
            dataGridViewInPut_PVV.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(0, 38);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1583, 133);
            textBox1.TabIndex = 0;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // buttonSaveFile_PVV
            // 
            buttonSaveFile_PVV.Image = (Image)resources.GetObject("buttonSaveFile_PVV.Image");
            buttonSaveFile_PVV.Location = new Point(355, 12);
            buttonSaveFile_PVV.Name = "buttonSaveFile_PVV";
            buttonSaveFile_PVV.Size = new Size(93, 67);
            buttonSaveFile_PVV.TabIndex = 1;
            buttonSaveFile_PVV.UseVisualStyleBackColor = true;
            buttonSaveFile_PVV.Click += buttonSaveFile_PVV_Click;
            buttonSaveFile_PVV.MouseEnter += buttonSaveFile_PVV_MouseEnter;
            // 
            // buttonDone_PVV
            // 
            buttonDone_PVV.Image = (Image)resources.GetObject("buttonDone_PVV.Image");
            buttonDone_PVV.Location = new Point(199, 12);
            buttonDone_PVV.Name = "buttonDone_PVV";
            buttonDone_PVV.Size = new Size(98, 67);
            buttonDone_PVV.TabIndex = 2;
            buttonDone_PVV.UseVisualStyleBackColor = true;
            buttonDone_PVV.Click += buttonDone_PVV_Click;
            buttonDone_PVV.MouseEnter += buttonDone_PVV_MouseEnter;
            // 
            // ButtonOpenFile_PVV
            // 
            ButtonOpenFile_PVV.Image = (Image)resources.GetObject("ButtonOpenFile_PVV.Image");
            ButtonOpenFile_PVV.Location = new Point(33, 12);
            ButtonOpenFile_PVV.Name = "ButtonOpenFile_PVV";
            ButtonOpenFile_PVV.Size = new Size(104, 67);
            ButtonOpenFile_PVV.TabIndex = 3;
            ButtonOpenFile_PVV.UseVisualStyleBackColor = true;
            ButtonOpenFile_PVV.Click += ButtonOpenFile_PVV_Click;
            ButtonOpenFile_PVV.MouseEnter += buttonOpenFile_PVV_MouseEnter;
            // 
            // buttonHelp_PVV
            // 
            buttonHelp_PVV.Image = (Image)resources.GetObject("buttonHelp_PVV.Image");
            buttonHelp_PVV.Location = new Point(1490, 12);
            buttonHelp_PVV.Name = "buttonHelp_PVV";
            buttonHelp_PVV.Size = new Size(85, 67);
            buttonHelp_PVV.TabIndex = 4;
            buttonHelp_PVV.UseVisualStyleBackColor = true;
            buttonHelp_PVV.Click += buttonHelp_PVV_Click;
            buttonHelp_PVV.MouseEnter += buttonHelp_PVV_MouseEnter;
            // 
            // openFileDialogTask_PVV
            // 
            openFileDialogTask_PVV.FileName = "openFileDialog1";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox1);
            groupBox3.Location = new Point(18, 121);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1600, 200);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Условие:";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1648, 992);
            Controls.Add(groupBox3);
            Controls.Add(buttonSaveFile_PVV);
            Controls.Add(buttonDone_PVV);
            Controls.Add(ButtonOpenFile_PVV);
            Controls.Add(groupBox2);
            Controls.Add(buttonHelp_PVV);
            Controls.Add(groupBox1);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 7 | Вариант 26 | Павлова В.В";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutPut_PVV).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInPut_PVV).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox textBox1;
        private Button buttonSaveFile_PVV;
        private Button buttonDone_PVV;
        private Button ButtonOpenFile_PVV;
        private Button buttonHelp_PVV;
        private OpenFileDialog openFileDialogTask_PVV;
        private ToolTip toolTipButton_PVV;
        private SaveFileDialog saveFileDialogMatrix_PVV;
        private GroupBox groupBox3;
        private DataGridView dataGridViewOutPut_PVV;
        private DataGridView dataGridViewInPut_PVV;
    }
}
