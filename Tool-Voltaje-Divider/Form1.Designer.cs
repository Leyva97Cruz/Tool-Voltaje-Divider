
namespace Tool_Voltaje_Divider
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.TxtVou = new System.Windows.Forms.TextBox();
            this.TxtR1 = new System.Windows.Forms.TextBox();
            this.TxtVin = new System.Windows.Forms.TextBox();
            this.TxtR2 = new System.Windows.Forms.TextBox();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(20)))), ((int)(((byte)(60)))));
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("JetBrainsMono Nerd Font Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Obtener R1",
            "Obtener R2",
            "Obtener Vou"});
            this.comboBox1.Location = new System.Drawing.Point(46, 83);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(202, 28);
            this.comboBox1.TabIndex = 0;
            // 
            // TxtVou
            // 
            this.TxtVou.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(20)))), ((int)(((byte)(66)))));
            this.TxtVou.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtVou.ForeColor = System.Drawing.Color.White;
            this.TxtVou.Location = new System.Drawing.Point(45, 191);
            this.TxtVou.Name = "TxtVou";
            this.TxtVou.Size = new System.Drawing.Size(202, 27);
            this.TxtVou.TabIndex = 1;
            this.TxtVou.Text = "Voltaje de Salida";
            // 
            // TxtR1
            // 
            this.TxtR1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(20)))), ((int)(((byte)(66)))));
            this.TxtR1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtR1.ForeColor = System.Drawing.Color.White;
            this.TxtR1.Location = new System.Drawing.Point(45, 285);
            this.TxtR1.Name = "TxtR1";
            this.TxtR1.Size = new System.Drawing.Size(202, 27);
            this.TxtR1.TabIndex = 1;
            this.TxtR1.Text = "Resistencia 1";
            // 
            // TxtVin
            // 
            this.TxtVin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(20)))), ((int)(((byte)(66)))));
            this.TxtVin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtVin.ForeColor = System.Drawing.Color.White;
            this.TxtVin.Location = new System.Drawing.Point(45, 240);
            this.TxtVin.Name = "TxtVin";
            this.TxtVin.Size = new System.Drawing.Size(202, 27);
            this.TxtVin.TabIndex = 1;
            this.TxtVin.Text = "Voltaje de Entrada";
            // 
            // TxtR2
            // 
            this.TxtR2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(20)))), ((int)(((byte)(66)))));
            this.TxtR2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtR2.ForeColor = System.Drawing.Color.White;
            this.TxtR2.Location = new System.Drawing.Point(45, 337);
            this.TxtR2.Name = "TxtR2";
            this.TxtR2.Size = new System.Drawing.Size(202, 27);
            this.TxtR2.TabIndex = 1;
            this.TxtR2.Text = "Resistencia 2";
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCalcular.ForeColor = System.Drawing.Color.White;
            this.BtnCalcular.Location = new System.Drawing.Point(72, 389);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(150, 31);
            this.BtnCalcular.TabIndex = 2;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(20)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.TxtVin);
            this.Controls.Add(this.TxtR2);
            this.Controls.Add(this.TxtR1);
            this.Controls.Add(this.TxtVou);
            this.Controls.Add(this.comboBox1);
            this.Font = new System.Drawing.Font("JetBrainsMono Nerd Font Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Divisor de Voltaje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox TxtVou;
        private System.Windows.Forms.TextBox TxtR1;
        private System.Windows.Forms.TextBox TxtVin;
        private System.Windows.Forms.TextBox TxtR2;
        private System.Windows.Forms.Button BtnCalcular;
    }
}

