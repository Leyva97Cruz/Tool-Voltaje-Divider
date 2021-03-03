
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
            this.CboSelect = new System.Windows.Forms.ComboBox();
            this.TxtVou = new System.Windows.Forms.TextBox();
            this.TxtR1 = new System.Windows.Forms.TextBox();
            this.TxtVin = new System.Windows.Forms.TextBox();
            this.TxtR2 = new System.Windows.Forms.TextBox();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PrbVou = new System.Windows.Forms.ProgressBar();
            this.TracVin = new System.Windows.Forms.TrackBar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TracVin)).BeginInit();
            this.SuspendLayout();
            // 
            // CboSelect
            // 
            this.CboSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(20)))), ((int)(((byte)(255)))));
            this.CboSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CboSelect.Font = new System.Drawing.Font("JetBrainsMono Nerd Font Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboSelect.ForeColor = System.Drawing.Color.White;
            this.CboSelect.FormattingEnabled = true;
            this.CboSelect.Items.AddRange(new object[] {
            "Obtener R1",
            "Obtener R2",
            "Obtener Vou",
            "Simulacion"});
            this.CboSelect.Location = new System.Drawing.Point(33, 52);
            this.CboSelect.Margin = new System.Windows.Forms.Padding(5);
            this.CboSelect.Name = "CboSelect";
            this.CboSelect.Size = new System.Drawing.Size(202, 28);
            this.CboSelect.TabIndex = 0;
            this.CboSelect.SelectedValueChanged += new System.EventHandler(this.CboSelect_SelectedValueChanged);
            // 
            // TxtVou
            // 
            this.TxtVou.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(14)))), ((int)(((byte)(250)))));
            this.TxtVou.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtVou.ForeColor = System.Drawing.Color.White;
            this.TxtVou.Location = new System.Drawing.Point(33, 275);
            this.TxtVou.Name = "TxtVou";
            this.TxtVou.Size = new System.Drawing.Size(202, 27);
            this.TxtVou.TabIndex = 1;
            this.TxtVou.Text = "Voltaje de Salida";
            this.TxtVou.Enter += new System.EventHandler(this.TxtVou_Enter);
            this.TxtVou.Leave += new System.EventHandler(this.TxtVou_Leave);
            // 
            // TxtR1
            // 
            this.TxtR1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(14)))), ((int)(((byte)(250)))));
            this.TxtR1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtR1.ForeColor = System.Drawing.Color.White;
            this.TxtR1.Location = new System.Drawing.Point(33, 143);
            this.TxtR1.Name = "TxtR1";
            this.TxtR1.Size = new System.Drawing.Size(202, 27);
            this.TxtR1.TabIndex = 1;
            this.TxtR1.Text = "Resistencia 1";
            this.TxtR1.Enter += new System.EventHandler(this.TxtR1_Enter);
            this.TxtR1.Leave += new System.EventHandler(this.TxtR1_Leave);
            // 
            // TxtVin
            // 
            this.TxtVin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(14)))), ((int)(((byte)(250)))));
            this.TxtVin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtVin.ForeColor = System.Drawing.Color.White;
            this.TxtVin.Location = new System.Drawing.Point(33, 342);
            this.TxtVin.Name = "TxtVin";
            this.TxtVin.Size = new System.Drawing.Size(202, 27);
            this.TxtVin.TabIndex = 1;
            this.TxtVin.Text = "Voltaje de Entrada";
            this.TxtVin.Enter += new System.EventHandler(this.TxtVin_Enter);
            this.TxtVin.Leave += new System.EventHandler(this.TxtVin_Leave);
            // 
            // TxtR2
            // 
            this.TxtR2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(14)))), ((int)(((byte)(250)))));
            this.TxtR2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtR2.ForeColor = System.Drawing.Color.White;
            this.TxtR2.Location = new System.Drawing.Point(33, 209);
            this.TxtR2.Name = "TxtR2";
            this.TxtR2.Size = new System.Drawing.Size(202, 27);
            this.TxtR2.TabIndex = 1;
            this.TxtR2.Text = "Resistencia 2";
            this.TxtR2.Enter += new System.EventHandler(this.TxtR2_Enter);
            this.TxtR2.Leave += new System.EventHandler(this.TxtR2_Leave);
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCalcular.ForeColor = System.Drawing.Color.White;
            this.BtnCalcular.Location = new System.Drawing.Point(55, 396);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(150, 31);
            this.BtnCalcular.TabIndex = 2;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(20)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.CboSelect);
            this.panel1.Controls.Add(this.BtnCalcular);
            this.panel1.Controls.Add(this.TxtVou);
            this.panel1.Controls.Add(this.TxtR2);
            this.panel1.Controls.Add(this.TxtVin);
            this.panel1.Controls.Add(this.TxtR1);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 457);
            this.panel1.TabIndex = 3;
            // 
            // PrbVou
            // 
            this.PrbVou.Location = new System.Drawing.Point(364, 264);
            this.PrbVou.Name = "PrbVou";
            this.PrbVou.Size = new System.Drawing.Size(564, 23);
            this.PrbVou.Step = 1;
            this.PrbVou.TabIndex = 4;
            // 
            // TracVin
            // 
            this.TracVin.Location = new System.Drawing.Point(364, 115);
            this.TracVin.Maximum = 100;
            this.TracVin.Name = "TracVin";
            this.TracVin.Size = new System.Drawing.Size(564, 45);
            this.TracVin.TabIndex = 5;
            this.TracVin.Scroll += new System.EventHandler(this.TracVin_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(20)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.TracVin);
            this.Controls.Add(this.PrbVou);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("JetBrainsMono Nerd Font Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Divisor de Voltaje";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TracVin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CboSelect;
        private System.Windows.Forms.TextBox TxtVou;
        private System.Windows.Forms.TextBox TxtR1;
        private System.Windows.Forms.TextBox TxtVin;
        private System.Windows.Forms.TextBox TxtR2;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar PrbVou;
        private System.Windows.Forms.TrackBar TracVin;
    }
}

