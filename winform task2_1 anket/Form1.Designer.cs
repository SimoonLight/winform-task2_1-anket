namespace winform_task2_1_anket
{
    partial class Form1
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
            anket_grpbx = new GroupBox();
            SuspendLayout();
            // 
            // anket_grpbx
            // 
            anket_grpbx.Location = new Point(12, 43);
            anket_grpbx.Name = "anket_grpbx";
            anket_grpbx.Size = new Size(421, 380);
            anket_grpbx.TabIndex = 0;
            anket_grpbx.TabStop = false;
            anket_grpbx.Text = "ANKETT";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 520);
            Controls.Add(anket_grpbx);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private GroupBox anket_grpbx;
    }
}
