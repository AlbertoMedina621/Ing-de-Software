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
    public partial class DlgListaSimple : Form
    {
        public DlgListaSimple()
        {
            InitializeComponent();
        }

        private void btAñadir_Click(object sender, EventArgs e)
        {
            // Añadir el elemento introducido en la
            // caja de texto ctAñadir
            if (ctAñadir.Text.Length != 0)
                lsLista1.Items.Add(ctAñadir.Text);
        }

        private void btBorrar_Click(object sender, EventArgs e)
        {
            if (lsLista1.SelectedIndex < 0) return;
            lsLista1.Items.RemoveAt(lsLista1.SelectedIndex);
        }
    }
}
