namespace Ariketa2
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
            lbZenbakia = new Label();
            tbZenbakia = new TextBox();
            btnHurrengoa = new Button();
            btnGarbitu = new Button();
            btnIrten = new Button();
            SuspendLayout();
            // 
            // lbZenbakia
            // 
            lbZenbakia.AutoSize = true;
            lbZenbakia.BackColor = Color.Blue;
            lbZenbakia.Font = new Font("Segoe UI", 12F);
            lbZenbakia.ForeColor = Color.FromArgb(255, 242, 142);
            lbZenbakia.Location = new Point(57, 63);
            lbZenbakia.Name = "lbZenbakia";
            lbZenbakia.Size = new Size(109, 28);
            lbZenbakia.TabIndex = 0;
            lbZenbakia.Text = "1. zenbakia";
            // 
            // tbZenbakia
            // 
            tbZenbakia.Location = new Point(172, 63);
            tbZenbakia.Name = "tbZenbakia";
            tbZenbakia.Size = new Size(265, 27);
            tbZenbakia.TabIndex = 1;
            tbZenbakia.TextChanged += textBox1_TextChanged;
            // 
            // btnHurrengoa
            // 
            btnHurrengoa.Location = new Point(81, 145);
            btnHurrengoa.Name = "btnHurrengoa";
            btnHurrengoa.Size = new Size(94, 29);
            btnHurrengoa.TabIndex = 2;
            btnHurrengoa.Text = "Hurrengoa";
            btnHurrengoa.UseVisualStyleBackColor = true;
            btnHurrengoa.Click += btnHurrengoa_Click;
            // 
            // btnGarbitu
            // 
            btnGarbitu.Location = new Point(202, 145);
            btnGarbitu.Name = "btnGarbitu";
            btnGarbitu.Size = new Size(94, 29);
            btnGarbitu.TabIndex = 3;
            btnGarbitu.Text = "Garbitu";
            btnGarbitu.UseVisualStyleBackColor = true;
            btnGarbitu.Click += btnGarbitu_Click;
            // 
            // btnIrten
            // 
            btnIrten.Location = new Point(324, 145);
            btnIrten.Name = "btnIrten";
            btnIrten.Size = new Size(94, 29);
            btnIrten.TabIndex = 4;
            btnIrten.Text = "Irten";
            btnIrten.UseVisualStyleBackColor = true;
            btnIrten.Click += btnIrten_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 212);
            Controls.Add(btnIrten);
            Controls.Add(btnGarbitu);
            Controls.Add(btnHurrengoa);
            Controls.Add(tbZenbakia);
            Controls.Add(lbZenbakia);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbZenbakia;
        private TextBox tbZenbakia;
        private Button btnHurrengoa;
        private Button btnGarbitu;
        private Button btnIrten;
    }
}
