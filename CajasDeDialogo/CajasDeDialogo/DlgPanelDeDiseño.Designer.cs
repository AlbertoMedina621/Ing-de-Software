namespace CajasDeDialogo
{
    partial class DlgPanelDeDiseño
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
            this.flpLista = new System.Windows.Forms.FlowLayoutPanel();
            this.btAceptar = new System.Windows.Forms.Button();
            this.btAñadir = new System.Windows.Forms.Button();
            this.ctAñadir = new System.Windows.Forms.TextBox();
            this.btBorrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flpLista
            // 
            this.flpLista.AutoScroll = true;
            this.flpLista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpLista.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpLista.Location = new System.Drawing.Point(13, 13);
            this.flpLista.Margin = new System.Windows.Forms.Padding(4);
            this.flpLista.Name = "flpLista";
            this.flpLista.Size = new System.Drawing.Size(234, 176);
            this.flpLista.TabIndex = 5;
            this.flpLista.WrapContents = false;
            // 
            // btAceptar
            // 
            this.btAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btAceptar.Location = new System.Drawing.Point(255, 13);
            this.btAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(100, 28);
            this.btAceptar.TabIndex = 6;
            this.btAceptar.Text = "&Aceptar";
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // btAñadir
            // 
            this.btAñadir.Location = new System.Drawing.Point(255, 49);
            this.btAñadir.Margin = new System.Windows.Forms.Padding(4);
            this.btAñadir.Name = "btAñadir";
            this.btAñadir.Size = new System.Drawing.Size(100, 28);
            this.btAñadir.TabIndex = 7;
            this.btAñadir.Text = "Aña&dir";
            this.btAñadir.Click += new System.EventHandler(this.btAñadir_Click);
            // 
            // ctAñadir
            // 
            this.ctAñadir.Location = new System.Drawing.Point(255, 85);
            this.ctAñadir.Margin = new System.Windows.Forms.Padding(4);
            this.ctAñadir.Name = "ctAñadir";
            this.ctAñadir.Size = new System.Drawing.Size(99, 22);
            this.ctAñadir.TabIndex = 8;
            // 
            // btBorrar
            // 
            this.btBorrar.Location = new System.Drawing.Point(254, 115);
            this.btBorrar.Margin = new System.Windows.Forms.Padding(4);
            this.btBorrar.Name = "btBorrar";
            this.btBorrar.Size = new System.Drawing.Size(100, 28);
            this.btBorrar.TabIndex = 9;
            this.btBorrar.Text = "&Borrar";
            this.btBorrar.Click += new System.EventHandler(this.btBorrar_Click);
            // 
            // DlgPanelDeDiseño
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 209);
            this.Controls.Add(this.btBorrar);
            this.Controls.Add(this.ctAñadir);
            this.Controls.Add(this.btAñadir);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.flpLista);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DlgPanelDeDiseño";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Panel de Diseño";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpLista;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Button btAñadir;
        private System.Windows.Forms.TextBox ctAñadir;
        private System.Windows.Forms.Button btBorrar;
    }
}