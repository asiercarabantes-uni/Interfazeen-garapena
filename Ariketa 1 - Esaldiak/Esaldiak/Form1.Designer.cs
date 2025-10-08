namespace Esaldiak
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
            btnEsaldi1 = new Button();
            btnEsaldi2 = new Button();
            btnEsaldi3 = new Button();
            btnEsaldi4 = new Button();
            btnEsaldi5 = new Button();
            btnLotu = new Button();
            btnGarbitu = new Button();
            tbHitza = new TextBox();
            SuspendLayout();
            // 
            // btnEsaldi1
            // 
            btnEsaldi1.Location = new Point(78, 216);
            btnEsaldi1.Name = "btnEsaldi1";
            btnEsaldi1.Size = new Size(150, 48);
            btnEsaldi1.TabIndex = 1;
            btnEsaldi1.Text = "Esaldi1";
            btnEsaldi1.UseVisualStyleBackColor = true;
            btnEsaldi1.Click += btnEsaldi1_Click;
            // 
            // btnEsaldi2
            // 
            btnEsaldi2.Enabled = false;
            btnEsaldi2.Location = new Point(317, 216);
            btnEsaldi2.Name = "btnEsaldi2";
            btnEsaldi2.Size = new Size(150, 47);
            btnEsaldi2.TabIndex = 2;
            btnEsaldi2.Text = "Esaldi2";
            btnEsaldi2.UseVisualStyleBackColor = true;
            btnEsaldi2.Click += btnEsaldi2_Click;
            // 
            // btnEsaldi3
            // 
            btnEsaldi3.Enabled = false;
            btnEsaldi3.Location = new Point(559, 216);
            btnEsaldi3.Name = "btnEsaldi3";
            btnEsaldi3.Size = new Size(150, 47);
            btnEsaldi3.TabIndex = 3;
            btnEsaldi3.Text = "Esaldi3";
            btnEsaldi3.UseVisualStyleBackColor = true;
            btnEsaldi3.Click += btnEsaldi3_Click;
            // 
            // btnEsaldi4
            // 
            btnEsaldi4.Enabled = false;
            btnEsaldi4.Location = new Point(78, 292);
            btnEsaldi4.Name = "btnEsaldi4";
            btnEsaldi4.Size = new Size(150, 42);
            btnEsaldi4.TabIndex = 4;
            btnEsaldi4.Text = "Esaldi4";
            btnEsaldi4.UseVisualStyleBackColor = true;
            btnEsaldi4.Click += btnEsaldi4_Click;
            // 
            // btnEsaldi5
            // 
            btnEsaldi5.Enabled = false;
            btnEsaldi5.Location = new Point(317, 292);
            btnEsaldi5.Name = "btnEsaldi5";
            btnEsaldi5.Size = new Size(150, 42);
            btnEsaldi5.TabIndex = 5;
            btnEsaldi5.Text = "Esaldi5";
            btnEsaldi5.UseVisualStyleBackColor = true;
            btnEsaldi5.Click += btnEsaldi5_Click;
            // 
            // btnLotu
            // 
            btnLotu.Enabled = false;
            btnLotu.Location = new Point(559, 292);
            btnLotu.Name = "btnLotu";
            btnLotu.Size = new Size(150, 42);
            btnLotu.TabIndex = 6;
            btnLotu.Text = "Lotu";
            btnLotu.UseVisualStyleBackColor = true;
            btnLotu.Click += btnLotu_Click;
            // 
            // btnGarbitu
            // 
            btnGarbitu.Location = new Point(180, 368);
            btnGarbitu.Name = "btnGarbitu";
            btnGarbitu.Size = new Size(432, 39);
            btnGarbitu.TabIndex = 7;
            btnGarbitu.Text = "Garbitu";
            btnGarbitu.UseVisualStyleBackColor = true;
            btnGarbitu.Click += btnGarbitu_Click;
            // 
            // tbHitza
            // 
            tbHitza.Location = new Point(180, 54);
            tbHitza.Multiline = true;
            tbHitza.Name = "tbHitza";
            tbHitza.Size = new Size(432, 117);
            tbHitza.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbHitza);
            Controls.Add(btnGarbitu);
            Controls.Add(btnLotu);
            Controls.Add(btnEsaldi5);
            Controls.Add(btnEsaldi4);
            Controls.Add(btnEsaldi3);
            Controls.Add(btnEsaldi2);
            Controls.Add(btnEsaldi1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEsaldi1;
        private Button btnEsaldi2;
        private Button btnEsaldi3;
        private Button btnEsaldi4;
        private Button btnEsaldi5;
        private Button btnLotu;
        private Button btnGarbitu;
        private TextBox tbHitza;
    }
}
