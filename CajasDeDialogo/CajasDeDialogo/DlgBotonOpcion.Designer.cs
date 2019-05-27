namespace CajasDeDialogo
{
    partial class DlgBotonOpcion
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
            this.ctDato = new System.Windows.Forms.TextBox();
            this.gbGrupoBotones1 = new System.Windows.Forms.GroupBox();
            this.btopDecimal = new System.Windows.Forms.RadioButton();
            this.btopOctal = new System.Windows.Forms.RadioButton();
            this.btopHex = new System.Windows.Forms.RadioButton();
            this.btAceptar = new System.Windows.Forms.Button();
            this.gbGrupoBotones1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctDato
            // 
            this.ctDato.Location = new System.Drawing.Point(40, 34);
            this.ctDato.Name = "ctDato";
            this.ctDato.Size = new System.Drawing.Size(268, 22);
            this.ctDato.TabIndex = 0;
            this.ctDato.TextChanged += new System.EventHandler(this.ctDato_TextChanged);
            // 
            // gbGrupoBotones1
            // 
            this.gbGrupoBotones1.Controls.Add(this.btopHex);
            this.gbGrupoBotones1.Controls.Add(this.btopOctal);
            this.gbGrupoBotones1.Controls.Add(this.btopDecimal);
            this.gbGrupoBotones1.Location = new System.Drawing.Point(40, 63);
            this.gbGrupoBotones1.Name = "gbGrupoBotones1";
            this.gbGrupoBotones1.Size = new System.Drawing.Size(268, 140);
            this.gbGrupoBotones1.TabIndex = 1;
            this.gbGrupoBotones1.TabStop = false;
            // 
            // btopDecimal
            // 
            this.btopDecimal.AutoSize = true;
            this.btopDecimal.Checked = true;
            this.btopDecimal.Location = new System.Drawing.Point(7, 22);
            this.btopDecimal.Name = "btopDecimal";
            this.btopDecimal.Size = new System.Drawing.Size(79, 21);
            this.btopDecimal.TabIndex = 0;
            this.btopDecimal.TabStop = true;
            this.btopDecimal.Text = "&Decimal";
            this.btopDecimal.UseVisualStyleBackColor = true;
            this.btopDecimal.CheckedChanged += new System.EventHandler(this.btopDecOcHex_CheckedChanged);
            // 
            // btopOctal
            // 
            this.btopOctal.AutoSize = true;
            this.btopOctal.Location = new System.Drawing.Point(7, 50);
            this.btopOctal.Name = "btopOctal";
            this.btopOctal.Size = new System.Drawing.Size(62, 21);
            this.btopOctal.TabIndex = 1;
            this.btopOctal.TabStop = true;
            this.btopOctal.Text = "&Octal";
            this.btopOctal.UseVisualStyleBackColor = true;
            this.btopOctal.CheckedChanged += new System.EventHandler(this.btopDecOcHex_CheckedChanged);
            // 
            // btopHex
            // 
            this.btopHex.AutoSize = true;
            this.btopHex.Location = new System.Drawing.Point(7, 78);
            this.btopHex.Name = "btopHex";
            this.btopHex.Size = new System.Drawing.Size(109, 21);
            this.btopHex.TabIndex = 2;
            this.btopHex.TabStop = true;
            this.btopHex.Text = "&Hexadecimal";
            this.btopHex.UseVisualStyleBackColor = true;
            this.btopHex.CheckedChanged += new System.EventHandler(this.btopDecOcHex_CheckedChanged);
            // 
            // btAceptar
            // 
            this.btAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btAceptar.Location = new System.Drawing.Point(232, 223);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 2;
            this.btAceptar.Text = "&Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            // 
            // DlgBotonOpcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 311);
            this.ControlBox = false;
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.gbGrupoBotones1);
            this.Controls.Add(this.ctDato);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DlgBotonOpcion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Botones de Opción";
            this.gbGrupoBotones1.ResumeLayout(false);
            this.gbGrupoBotones1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ctDato;
        private System.Windows.Forms.GroupBox gbGrupoBotones1;
        private System.Windows.Forms.RadioButton btopHex;
        private System.Windows.Forms.RadioButton btopOctal;
        private System.Windows.Forms.RadioButton btopDecimal;
        private System.Windows.Forms.Button btAceptar;
    }
}