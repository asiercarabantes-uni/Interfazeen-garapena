namespace Agenda
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbIzena = new System.Windows.Forms.TextBox();
            this.tbAbizena = new System.Windows.Forms.TextBox();
            this.tbTelefonoa = new System.Windows.Forms.TextBox();
            this.tbPrefijoa = new System.Windows.Forms.TextBox();
            this.cbGeneroa = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.tbBilatu = new System.Windows.Forms.TextBox();
            this.grafikoa2 = new GrafikoaLib.GrafikoControl();
            this.grafikoa1 = new GrafikoaLib.GrafikoControl();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Izena:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Abizena:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefonoa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Generoa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Prefijoa:";
            // 
            // tbIzena
            // 
            this.tbIzena.Location = new System.Drawing.Point(135, 60);
            this.tbIzena.Name = "tbIzena";
            this.tbIzena.Size = new System.Drawing.Size(180, 22);
            this.tbIzena.TabIndex = 5;
            // 
            // tbAbizena
            // 
            this.tbAbizena.Location = new System.Drawing.Point(135, 90);
            this.tbAbizena.Name = "tbAbizena";
            this.tbAbizena.Size = new System.Drawing.Size(180, 22);
            this.tbAbizena.TabIndex = 6;
            // 
            // tbTelefonoa
            // 
            this.tbTelefonoa.Location = new System.Drawing.Point(135, 120);
            this.tbTelefonoa.Name = "tbTelefonoa";
            this.tbTelefonoa.Size = new System.Drawing.Size(180, 22);
            this.tbTelefonoa.TabIndex = 7;
            // 
            // tbPrefijoa
            // 
            this.tbPrefijoa.Location = new System.Drawing.Point(135, 180);
            this.tbPrefijoa.Name = "tbPrefijoa";
            this.tbPrefijoa.Size = new System.Drawing.Size(180, 22);
            this.tbPrefijoa.TabIndex = 8;
            // 
            // cbGeneroa
            // 
            this.cbGeneroa.FormattingEnabled = true;
            this.cbGeneroa.Items.AddRange(new object[] {
            "Gizona",
            "Emakumea",
            "Ez-bitarra"});
            this.cbGeneroa.Location = new System.Drawing.Point(135, 150);
            this.cbGeneroa.Name = "cbGeneroa";
            this.cbGeneroa.Size = new System.Drawing.Size(180, 24);
            this.cbGeneroa.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(30, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(285, 40);
            this.button1.TabIndex = 10;
            this.button1.Text = "Gorde";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnGorde);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(30, 380);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 40);
            this.button2.TabIndex = 11;
            this.button2.Text = "Ikusi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnIkusi);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(677, 381);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 39);
            this.button3.TabIndex = 12;
            this.button3.Text = "Bilatu";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnBilatu);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(30, 426);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(737, 336);
            this.dataGridView.TabIndex = 13;
            // 
            // tbBilatu
            // 
            this.tbBilatu.Location = new System.Drawing.Point(436, 397);
            this.tbBilatu.Name = "tbBilatu";
            this.tbBilatu.Size = new System.Drawing.Size(235, 22);
            this.tbBilatu.TabIndex = 14;
            // 
            // grafikoa2
            // 
            this.grafikoa2.Location = new System.Drawing.Point(466, 50);
            this.grafikoa2.Name = "grafikoa2";
            this.grafikoa2.Size = new System.Drawing.Size(301, 306);
            this.grafikoa2.TabIndex = 16;
            // 
            // grafikoa1
            // 
            this.grafikoa1.Location = new System.Drawing.Point(852, 50);
            this.grafikoa1.Name = "grafikoa1";
            this.grafikoa1.Size = new System.Drawing.Size(301, 306);
            this.grafikoa1.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 866);
            this.Controls.Add(this.grafikoa2);
            this.Controls.Add(this.grafikoa1);
            this.Controls.Add(this.tbBilatu);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbGeneroa);
            this.Controls.Add(this.tbPrefijoa);
            this.Controls.Add(this.tbTelefonoa);
            this.Controls.Add(this.tbAbizena);
            this.Controls.Add(this.tbIzena);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbIzena;
        private System.Windows.Forms.TextBox tbAbizena;
        private System.Windows.Forms.TextBox tbTelefonoa;
        private System.Windows.Forms.TextBox tbPrefijoa;
        private System.Windows.Forms.ComboBox cbGeneroa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox tbBilatu;
        private GrafikoaLib.GrafikoControl grafikoa1;
        private GrafikoaLib.GrafikoControl grafikoa2;
    }
}

