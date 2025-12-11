namespace Tyuiu.PavlovaVV.Sprint6.Task4.V3
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
            textBoxEnd_PVV = new TextBox();
            SuspendLayout();
            // 
            // textBoxStart_PVV
            // 
            textBoxStart_PVV.Location = new Point(48, 366);
            textBoxStart_PVV.Name = "textBoxStart_PVV";
            textBoxStart_PVV.Size = new Size(200, 39);
            textBoxStart_PVV.TabIndex = 0;
            // 
            // textBoxEnd_PVV
            // 
            textBoxEnd_PVV.Location = new Point(372, 366);
            textBoxEnd_PVV.Name = "textBoxEnd_PVV";
            textBoxEnd_PVV.Size = new Size(200, 39);
            textBoxEnd_PVV.TabIndex = 1;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxEnd_PVV);
            Controls.Add(textBoxStart_PVV);
            Name = "FormMain";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxStart_PVV;
        private TextBox textBoxEnd_PVV;
    }
}
