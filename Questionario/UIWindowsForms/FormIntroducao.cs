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
    public partial class FormIntroducao : Form
    {
        public int _id_categoria;
        public string NomeCategoria;

        private FormQuestionario _questionario;
        public FormIntroducao(int idCategoriaMaisFrequente, FormQuestionario questionario)
        {
            InitializeComponent();
            _questionario = questionario;
            _id_categoria = idCategoriaMaisFrequente;
            CategoriaBLL categoriaBLL = new CategoriaBLL();
            NomeCategoria = categoriaBLL.BuscarPorId(_id_categoria).categoria;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormIntroducao_Load(object sender, EventArgs e)
        {
            label1.Text = ("Parabens você uma grande vocação para " + NomeCategoria.ToString());
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            _questionario.sair = false;
            this.Close();
        }
    }
}
