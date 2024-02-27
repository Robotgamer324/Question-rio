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
    public partial class FormAlterar : Form
    {
        public FormAlterar()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            perguntasBindingSource.DataSource = new PerguntasBLL().BuscarPorId(int.Parse(textBoxIdDeBusca.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PerguntasBLL perguntasBLL = new PerguntasBLL();
            perguntasBLL.Id = int.Parse(textBoxIdDeBusca.Text);
            perguntasBLL.Pergunta = textBoxPergunta.Text;
            perguntasBLL.id_categoria = int.Parse(textBoxCategoria.Text);
            perguntasBLL.Alterar();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
