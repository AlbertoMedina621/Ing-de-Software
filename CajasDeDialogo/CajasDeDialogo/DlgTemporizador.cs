using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajasDeDialogo
{
    public partial class DlgTemporizador : Form
    {
        private TimeSpan tAntes;
        private TimeSpan tDespues;

        public DlgTemporizador()
        {
            InitializeComponent();
        }

        private void DlgTemporizador_Load(object sender, EventArgs e)
        {
        }
        private void Temporizador_Tick(object sender, EventArgs e)
        {
        }
    }
}
