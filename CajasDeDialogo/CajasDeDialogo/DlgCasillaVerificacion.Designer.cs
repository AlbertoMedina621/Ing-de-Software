namespace CajasDeDialogo
{
    partial class DlgCasillaVerificacion
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
            this.ctTexto = new System.Windows.Forms.TextBox();
            this.cvConverMayus = new System.Windows.Forms.CheckBox();
            this.btAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctTexto
            // 
            this.ctTexto.Location = new System.Drawing.Point(71, 98);
            this.ctTexto.Name = "ctTexto";
            this.ctTexto.Size = new System.Drawing.Size(354, 22);
            this.ctTexto.TabIndex = 0;
            this.ctTexto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ctTexto_KeyPress);
            // 
            // cvConverMayus
            // 
            this.cvConverMayus.AutoSize = true;
            this.cvConverMayus.Location = new System.Drawing.Point(71, 127);
            this.cvConverMayus.Name = "cvConverMayus";
            this.cvConverMayus.Size = new System.Drawing.Size(177, 21);
            this.cvConverMayus.TabIndex = 1;
            this.cvConverMayus.Text = "&Convertir a Mayúsculas";
            this.cvConverMayus.ThreeState = true;
            this.cvConverMayus.UseVisualStyleBackColor = true;
            this.cvConverMayus.Click += new System.EventHandler(this.cvConverMayus_Click);
            // 
            // btAceptar
            // 
            this.btAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btAceptar.Location = new System.Drawing.Point(350, 191);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 2;
            this.btAceptar.Text = "&Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            // 
            // DlgCasillaVerificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 281);
            this.ControlBox = false;
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.cvConverMayus);
            this.Controls.Add(this.ctTexto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DlgCasillaVerificacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Casilla de Verificación";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ctTexto;
        private System.Windows.Forms.CheckBox cvConverMayus;
        private System.Windows.Forms.Button btAceptar;
    }
}