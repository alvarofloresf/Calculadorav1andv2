using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MascotasTeam1
{


    public partial class Mascotas : Form
    {
        int cont = 0;
        public Mascotas()
        {
            InitializeComponent();
        }

        private void Mascotas_Load(object sender, EventArgs e)
        {
            rbHembra.Checked = true;
        }

        private void tbEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (cont < 10)
            {
                cont++;
                ListViewItem fila = new ListViewItem(tbNombre.Text);
                fila.SubItems.Add(tbEdad.Text);
                if (rbHembra.Checked)
                {
                    fila.SubItems.Add("Hembra");
                }
                else
                {
                    fila.SubItems.Add("Macho");
                }

                lvCompleta.Items.Add(fila);

                if (int.Parse(tbEdad.Text) > 3)
                {
                    ListViewItem filaM = new ListViewItem(tbNombre.Text);
                    filaM.SubItems.Add(tbEdad.Text);
                    if (rbHembra.Checked)
                    {
                        filaM.SubItems.Add("Hembra");
                    }
                    else
                    {
                        filaM.SubItems.Add("Macho");
                    }
                    lvMayor3an.Items.Add(filaM);
                    

                }
            }
            else
            {
                MessageBox.Show("Solo es permitido ingresar 10 mascotas");
            }
        }
    }


}
