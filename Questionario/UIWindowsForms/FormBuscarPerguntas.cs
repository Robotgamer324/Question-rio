using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIWindowsForms
{
    public partial class FormBuscarPerguntas : Form
    {
        public FormBuscarPerguntas()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comboBoxBuscarPor.SelectedIndex)
                {
                    case 0:
                        perguntasBindingSource.DataSource = new PerguntasBLL().BuscarPorPergunta(textBoxBuscarPor.Text);
                        break;
                    case 1:
                        perguntasBindingSource.DataSource = new PerguntasBLL().BuscarPorId(int.Parse(textBoxBuscarPor.Text));
                        break;
                    case 2:
                        perguntasBindingSource.DataSource = new PerguntasBLL().BuscarPorIdCategoria(int.Parse(textBoxBuscarPor.Text));
                        break;

                    default:
                        perguntasBindingSource.DataSource = new PerguntasBLL().BuscarTodos();
                        break;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            using FormAlterar frm = new FormAlterar();
            {
                frm.ShowDialog();
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
