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
    public partial class DlgPalabraDePaso : Form
    {
        public DlgPalabraDePaso()
        {
            InitializeComponent();
        }
        private void ctPalabraDePaso_KeyPress(
            object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13))
                DialogResult = DialogResult.OK;
            if (e.KeyChar == Convert.ToChar(27))
                DialogResult = DialogResult.Cancel;
        }
       
    }
}
