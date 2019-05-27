namespace CajasDeDialogo
{
    partial class DlgTemporizador
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
            this.etHora = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // etHora
            // 
            this.etHora.AutoSize = true;
            this.etHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etHora.Location = new System.Drawing.Point(70, 85);
            this.etHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.etHora.Name = "etHora";
            this.etHora.Size = new System.Drawing.Size(174, 46);
            this.etHora.TabIndex = 2;
            this.etHora.Text = "00:00:00";
            // 
            // DlgTemporizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 232);
            this.Controls.Add(this.etHora);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DlgTemporizador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Temporizador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label etHora;
    }
}