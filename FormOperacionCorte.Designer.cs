
namespace ProyectoFinal_Bankomex
{
    partial class FormOperacionCorte
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbtnMonthAnnualFee = new System.Windows.Forms.RadioButton();
            this.rdbtnMonthFee = new System.Windows.Forms.RadioButton();
            this.btnCorte = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Corte";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbtnMonthAnnualFee);
            this.groupBox1.Controls.Add(this.rdbtnMonthFee);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(549, 190);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parámetro de corte";
            // 
            // rdbtnMonthAnnualFee
            // 
            this.rdbtnMonthAnnualFee.Location = new System.Drawing.Point(7, 97);
            this.rdbtnMonthAnnualFee.Name = "rdbtnMonthAnnualFee";
            this.rdbtnMonthAnnualFee.Size = new System.Drawing.Size(413, 79);
            this.rdbtnMonthAnnualFee.TabIndex = 1;
            this.rdbtnMonthAnnualFee.TabStop = true;
            this.rdbtnMonthAnnualFee.Text = "Ultimo día del mes y del año (mensualidad y anualidad)";
            this.rdbtnMonthAnnualFee.UseVisualStyleBackColor = true;
            // 
            // rdbtnMonthFee
            // 
            this.rdbtnMonthFee.AutoSize = true;
            this.rdbtnMonthFee.Location = new System.Drawing.Point(7, 41);
            this.rdbtnMonthFee.Name = "rdbtnMonthFee";
            this.rdbtnMonthFee.Size = new System.Drawing.Size(457, 36);
            this.rdbtnMonthFee.TabIndex = 0;
            this.rdbtnMonthFee.TabStop = true;
            this.rdbtnMonthFee.Text = "Ultimo día del mes (mensualidad)";
            this.rdbtnMonthFee.UseVisualStyleBackColor = true;
            // 
            // btnCorte
            // 
            this.btnCorte.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorte.Location = new System.Drawing.Point(175, 321);
            this.btnCorte.Name = "btnCorte";
            this.btnCorte.Size = new System.Drawing.Size(216, 59);
            this.btnCorte.TabIndex = 2;
            this.btnCorte.Text = "Realizar corte";
            this.btnCorte.UseVisualStyleBackColor = true;
            this.btnCorte.Click += new System.EventHandler(this.btnCorte_Click);
            // 
            // FormOperacionCorte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.btnCorte);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormOperacionCorte";
            this.Text = "FormOperacionCorte";
            this.Load += new System.EventHandler(this.FormOperacionCorte_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbtnMonthAnnualFee;
        private System.Windows.Forms.RadioButton rdbtnMonthFee;
        private System.Windows.Forms.Button btnCorte;
    }
}