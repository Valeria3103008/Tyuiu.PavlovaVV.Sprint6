namespace Tyuiu.PavlovaVV.Sprint6.Task1.V10
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
            textBoxStart_PVV = new TextBox();
            textBoxFinish_PVV = new TextBox();
            textBoxResult_PVV = new TextBox();
            Button2_PVV = new Button();
            button1_PVV = new Button();
            SuspendLayout();
            // 
            // textBoxStart_PVV
            // 
            textBoxStart_PVV.Location = new Point(86, 444);
            textBoxStart_PVV.Name = "textBoxStart_PVV";
            textBoxStart_PVV.Size = new Size(200, 39);
            textBoxStart_PVV.TabIndex = 2;
            // 
            // textBoxFinish_PVV
            // 
            textBoxFinish_PVV.Location = new Point(395, 444);
            textBoxFinish_PVV.Name = "textBoxFinish_PVV";
            textBoxFinish_PVV.Size = new Size(200, 39);
            textBoxFinish_PVV.TabIndex = 3;
            // 
            // textBoxResult_PVV
            // 
            textBoxResult_PVV.Location = new Point(996, 455);
            textBoxResult_PVV.Name = "textBoxResult_PVV";
            textBoxResult_PVV.Size = new Size(200, 39);
            textBoxResult_PVV.TabIndex = 4;
            // 
            // Button2_PVV
            // 
            Button2_PVV.Location = new Point(776, 471);
            Button2_PVV.Name = "Button2_PVV";
            Button2_PVV.Size = new Size(150, 46);
            Button2_PVV.TabIndex = 5;
            Button2_PVV.Text = "button";
            Button2_PVV.UseVisualStyleBackColor = true;
            Button2_PVV.Click += buttonDone_PVV_Click;
            // 
            // button1_PVV
            // 
            button1_PVV.Location = new Point(269, 136);
            button1_PVV.Name = "button1_PVV";
            button1_PVV.Size = new Size(150, 46);
            button1_PVV.TabIndex = 6;
            button1_PVV.Text = "button1";
            button1_PVV.UseVisualStyleBackColor = true;
            button1_PVV.Click += buttonHelp_PVV_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1477, 797);
            Controls.Add(button1_PVV);
            Controls.Add(Button2_PVV);
            Controls.Add(textBoxResult_PVV);
            Controls.Add(textBoxFinish_PVV);
            Controls.Add(textBoxStart_PVV);
            Name = "FormMain";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxStart_PVV;
        private TextBox textBoxFinish_PVV;
        private TextBox textBoxResult_PVV;
        private Button Button2_PVV;
        private Button button1_PVV;
        //private Button buttonDone_PVV_Click;
        //private Button buttonDone_PVV_Click;
    }
}
