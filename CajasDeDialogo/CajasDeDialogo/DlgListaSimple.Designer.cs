namespace CajasDeDialogo
{
    partial class DlgListaSimple
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
            this.lsLista1 = new System.Windows.Forms.ListBox();
            this.btAceptar = new System.Windows.Forms.Button();
            this.btAñadir = new System.Windows.Forms.Button();
            this.ctAñadir = new System.Windows.Forms.TextBox();
            this.btBorrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsLista1
            // 
            this.lsLista1.FormattingEnabled = true;
            this.lsLista1.ItemHeight = 16;
            this.lsLista1.Location = new System.Drawing.Point(13, 13);
            this.lsLista1.Name = "lsLista1";
            this.lsLista1.Size = new System.Drawing.Size(305, 260);
            this.lsLista1.TabIndex = 0;
            // 
            // btAceptar
            // 
            this.btAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btAceptar.Location = new System.Drawing.Point(324, 73);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(119, 33);
            this.btAceptar.TabIndex = 1;
            this.btAceptar.Text = "&Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            // 
            // btAñadir
            // 
            this.btAñadir.Location = new System.Drawing.Point(325, 132);
            this.btAñadir.Name = "btAñadir";
            this.btAñadir.Size = new System.Drawing.Size(118, 34);
            this.btAñadir.TabIndex = 2;
            this.btAñadir.Text = "&Añadir";
            this.btAñadir.UseVisualStyleBackColor = true;
            this.btAñadir.Click += new System.EventHandler(this.btAñadir_Click);
            // 
            // ctAñadir
            // 
            this.ctAñadir.Location = new System.Drawing.Point(325, 172);
            this.ctAñadir.Name = "ctAñadir";
            this.ctAñadir.Size = new System.Drawing.Size(118, 22);
            this.ctAñadir.TabIndex = 3;
            // 
            // btBorrar
            // 
            this.btBorrar.Location = new System.Drawing.Point(325, 201);
            this.btBorrar.Name = "btBorrar";
            this.btBorrar.Size = new System.Drawing.Size(118, 38);
            this.btBorrar.TabIndex = 4;
            this.btBorrar.Text = "&Borrar";
            this.btBorrar.UseVisualStyleBackColor = true;
            this.btBorrar.Click += new System.EventHandler(this.btBorrar_Click);
            // 
            // DlgListaSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 300);
            this.Controls.Add(this.btBorrar);
            this.Controls.Add(this.ctAñadir);
            this.Controls.Add(this.btAñadir);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.lsLista1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DlgListaSimple";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lista Simple";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsLista1;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Button btAñadir;
        private System.Windows.Forms.TextBox ctAñadir;
        private System.Windows.Forms.Button btBorrar;
    }
}