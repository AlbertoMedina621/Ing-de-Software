namespace CajasDeDialogo
{
    partial class DlgListaDesplegable
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
            this.btAceptar = new System.Windows.Forms.Button();
            this.btAñadir = new System.Windows.Forms.Button();
            this.ctAñadir = new System.Windows.Forms.TextBox();
            this.btBorrar = new System.Windows.Forms.Button();
            this.ldLista1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btAceptar
            // 
            this.btAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btAceptar.Location = new System.Drawing.Point(272, 12);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(106, 36);
            this.btAceptar.TabIndex = 1;
            this.btAceptar.Text = "&Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // btAñadir
            // 
            this.btAñadir.Location = new System.Drawing.Point(272, 54);
            this.btAñadir.Name = "btAñadir";
            this.btAñadir.Size = new System.Drawing.Size(106, 36);
            this.btAñadir.TabIndex = 2;
            this.btAñadir.Text = "&Añadir";
            this.btAñadir.UseVisualStyleBackColor = true;
            this.btAñadir.Click += new System.EventHandler(this.btAñadir_Click);
            // 
            // ctAñadir
            // 
            this.ctAñadir.Location = new System.Drawing.Point(272, 110);
            this.ctAñadir.Name = "ctAñadir";
            this.ctAñadir.Size = new System.Drawing.Size(106, 22);
            this.ctAñadir.TabIndex = 3;
            // 
            // btBorrar
            // 
            this.btBorrar.Location = new System.Drawing.Point(272, 153);
            this.btBorrar.Name = "btBorrar";
            this.btBorrar.Size = new System.Drawing.Size(106, 39);
            this.btBorrar.TabIndex = 4;
            this.btBorrar.Text = "&Borrar";
            this.btBorrar.UseVisualStyleBackColor = true;
            this.btBorrar.Click += new System.EventHandler(this.btBorrar_Click);
            // 
            // ldLista1
            // 
            this.ldLista1.FormattingEnabled = true;
            this.ldLista1.Location = new System.Drawing.Point(12, 12);
            this.ldLista1.Name = "ldLista1";
            this.ldLista1.Size = new System.Drawing.Size(235, 24);
            this.ldLista1.TabIndex = 5;
            // 
            // DlgListaDesplegable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 214);
            this.Controls.Add(this.ldLista1);
            this.Controls.Add(this.btBorrar);
            this.Controls.Add(this.ctAñadir);
            this.Controls.Add(this.btAñadir);
            this.Controls.Add(this.btAceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DlgListaDesplegable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lista Desplegable";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Button btAñadir;
        private System.Windows.Forms.TextBox ctAñadir;
        private System.Windows.Forms.Button btBorrar;
        private System.Windows.Forms.ComboBox ldLista1;
    }
}