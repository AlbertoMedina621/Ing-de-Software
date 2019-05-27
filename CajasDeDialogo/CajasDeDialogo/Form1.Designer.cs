namespace CajasDeDialogo
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ArchivoSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.dialogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dialogoCasillaDeVerificacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.botónDeOpciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaSimpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDesplegableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlConPestañasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeFechasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelDeDiseñoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ArchivoAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.ArchivoGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ArchivoColor = new System.Windows.Forms.ToolStripMenuItem();
            this.ArchivoFuente = new System.Windows.Forms.ToolStripMenuItem();
            this.DialogoTimer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.dialogosToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ArchivoAbrir,
            this.ArchivoGuardar,
            this.toolStripSeparator1,
            this.ArchivoSalir});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // ArchivoSalir
            // 
            this.ArchivoSalir.Name = "ArchivoSalir";
            this.ArchivoSalir.Size = new System.Drawing.Size(216, 26);
            this.ArchivoSalir.Text = "&Salir";
            this.ArchivoSalir.Click += new System.EventHandler(this.ArchivoSalir_Click);
            // 
            // dialogosToolStripMenuItem
            // 
            this.dialogosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dialogoCasillaDeVerificacionToolStripMenuItem,
            this.botónDeOpciónToolStripMenuItem,
            this.listaSimpleToolStripMenuItem,
            this.listaDesplegableToolStripMenuItem,
            this.controlConPestañasToolStripMenuItem,
            this.gestionDeFechasToolStripMenuItem,
            this.panelDeDiseñoToolStripMenuItem,
            this.toolStripSeparator2,
            this.ArchivoColor,
            this.ArchivoFuente,
            this.toolStripSeparator3,
            this.DialogoTimer});
            this.dialogosToolStripMenuItem.Name = "dialogosToolStripMenuItem";
            this.dialogosToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.dialogosToolStripMenuItem.Text = "&Dialogos";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.ayudaToolStripMenuItem.Text = "Ay&uda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // dialogoCasillaDeVerificacionToolStripMenuItem
            // 
            this.dialogoCasillaDeVerificacionToolStripMenuItem.Name = "dialogoCasillaDeVerificacionToolStripMenuItem";
            this.dialogoCasillaDeVerificacionToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.dialogoCasillaDeVerificacionToolStripMenuItem.Text = "Casilla de Verificación";
            this.dialogoCasillaDeVerificacionToolStripMenuItem.Click += new System.EventHandler(this.dialogoCasillaDeVerificacionToolStripMenuItem_Click);
            // 
            // botónDeOpciónToolStripMenuItem
            // 
            this.botónDeOpciónToolStripMenuItem.Name = "botónDeOpciónToolStripMenuItem";
            this.botónDeOpciónToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.botónDeOpciónToolStripMenuItem.Text = "Botón de Opción";
            this.botónDeOpciónToolStripMenuItem.Click += new System.EventHandler(this.botónDeOpciónToolStripMenuItem_Click);
            // 
            // listaSimpleToolStripMenuItem
            // 
            this.listaSimpleToolStripMenuItem.Name = "listaSimpleToolStripMenuItem";
            this.listaSimpleToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.listaSimpleToolStripMenuItem.Text = "Lista Simple";
            this.listaSimpleToolStripMenuItem.Click += new System.EventHandler(this.listaSimpleToolStripMenuItem_Click);
            // 
            // listaDesplegableToolStripMenuItem
            // 
            this.listaDesplegableToolStripMenuItem.Name = "listaDesplegableToolStripMenuItem";
            this.listaDesplegableToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.listaDesplegableToolStripMenuItem.Text = "Lista Desplegable";
            this.listaDesplegableToolStripMenuItem.Click += new System.EventHandler(this.listaDesplegableToolStripMenuItem_Click);
            // 
            // controlConPestañasToolStripMenuItem
            // 
            this.controlConPestañasToolStripMenuItem.Name = "controlConPestañasToolStripMenuItem";
            this.controlConPestañasToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.controlConPestañasToolStripMenuItem.Text = "Control con Pestañas";
            this.controlConPestañasToolStripMenuItem.Click += new System.EventHandler(this.controlConPestañasToolStripMenuItem_Click);
            // 
            // gestionDeFechasToolStripMenuItem
            // 
            this.gestionDeFechasToolStripMenuItem.Name = "gestionDeFechasToolStripMenuItem";
            this.gestionDeFechasToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.gestionDeFechasToolStripMenuItem.Text = "Gestion de Fechas";
            this.gestionDeFechasToolStripMenuItem.Click += new System.EventHandler(this.gestionDeFechasToolStripMenuItem_Click);
            // 
            // panelDeDiseñoToolStripMenuItem
            // 
            this.panelDeDiseñoToolStripMenuItem.Name = "panelDeDiseñoToolStripMenuItem";
            this.panelDeDiseñoToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.panelDeDiseñoToolStripMenuItem.Text = "Panel de Diseño";
            this.panelDeDiseñoToolStripMenuItem.Click += new System.EventHandler(this.panelDeDiseñoToolStripMenuItem_Click);
            // 
            // ArchivoAbrir
            // 
            this.ArchivoAbrir.Name = "ArchivoAbrir";
            this.ArchivoAbrir.Size = new System.Drawing.Size(216, 26);
            this.ArchivoAbrir.Text = "&Abrir";
            this.ArchivoAbrir.Click += new System.EventHandler(this.ArchivoAbrir_Click);
            // 
            // ArchivoGuardar
            // 
            this.ArchivoGuardar.Name = "ArchivoGuardar";
            this.ArchivoGuardar.Size = new System.Drawing.Size(216, 26);
            this.ArchivoGuardar.Text = "&Guardar";
            this.ArchivoGuardar.Click += new System.EventHandler(this.ArchivoGuardar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(213, 6);
            // 
            // ArchivoColor
            // 
            this.ArchivoColor.Name = "ArchivoColor";
            this.ArchivoColor.Size = new System.Drawing.Size(229, 26);
            this.ArchivoColor.Text = "Color";
            this.ArchivoColor.Click += new System.EventHandler(this.ArchivoColor_Click);
            // 
            // ArchivoFuente
            // 
            this.ArchivoFuente.Name = "ArchivoFuente";
            this.ArchivoFuente.Size = new System.Drawing.Size(229, 26);
            this.ArchivoFuente.Text = "Fuente";
            this.ArchivoFuente.Click += new System.EventHandler(this.ArchivoFuente_Click);
            // 
            // DialogoTimer
            // 
            this.DialogoTimer.Name = "DialogoTimer";
            this.DialogoTimer.Size = new System.Drawing.Size(229, 26);
            this.DialogoTimer.Text = "Timer";
            this.DialogoTimer.Click += new System.EventHandler(this.DialogoTimer_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(226, 6);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(226, 6);
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(126, 160);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(488, 22);
            this.TextBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cajas de diálogo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ArchivoSalir;
        private System.Windows.Forms.ToolStripMenuItem dialogosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dialogoCasillaDeVerificacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem botónDeOpciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaSimpleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDesplegableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlConPestañasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeFechasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem panelDeDiseñoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ArchivoAbrir;
        private System.Windows.Forms.ToolStripMenuItem ArchivoGuardar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ArchivoColor;
        private System.Windows.Forms.ToolStripMenuItem ArchivoFuente;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem DialogoTimer;
        private System.Windows.Forms.TextBox TextBox1;
    }
}

