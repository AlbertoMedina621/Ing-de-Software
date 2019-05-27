namespace CajasDeDialogo
{
    partial class DlgPalabraDePaso
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
            this.etPalabraDePaso = new System.Windows.Forms.Label();
            this.ctPalabraDePaso = new System.Windows.Forms.TextBox();
            this.btAceptar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // etPalabraDePaso
            // 
            this.etPalabraDePaso.AutoSize = true;
            this.etPalabraDePaso.Location = new System.Drawing.Point(179, 110);
            this.etPalabraDePaso.Name = "etPalabraDePaso";
            this.etPalabraDePaso.Size = new System.Drawing.Size(206, 17);
            this.etPalabraDePaso.TabIndex = 0;
            this.etPalabraDePaso.Text = "Introduzca la Palabra de Paso: ";
            // 
            // ctPalabraDePaso
            // 
            this.ctPalabraDePaso.Location = new System.Drawing.Point(182, 148);
            this.ctPalabraDePaso.Name = "ctPalabraDePaso";
            this.ctPalabraDePaso.Size = new System.Drawing.Size(336, 22);
            this.ctPalabraDePaso.TabIndex = 1;
            this.ctPalabraDePaso.Text = "*";
            // 
            // btAceptar
            // 
            this.btAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btAceptar.Location = new System.Drawing.Point(322, 236);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 2;
            this.btAceptar.Text = "&Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            // 
            // btCancelar
            // 
            this.btCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancelar.Location = new System.Drawing.Point(404, 235);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 3;
            this.btCancelar.Text = "&Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // DlgPalabraDePaso
            // 
            this.AcceptButton = this.btAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancelar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.ctPalabraDePaso);
            this.Controls.Add(this.etPalabraDePaso);
            this.Name = "DlgPalabraDePaso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Palabra de Paso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label etPalabraDePaso;
        internal System.Windows.Forms.TextBox ctPalabraDePaso;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Button btCancelar;
    }
}