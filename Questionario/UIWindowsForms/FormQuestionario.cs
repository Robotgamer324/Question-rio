using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace UIWindowsForms
{
    public partial class FormQuestionario : Form
    {
        public int IDs;
        public int i;
        public int idCategoriaMaisFrequente;

        public FormQuestionario(int _id)
        {
            InitializeComponent();
            IDs = _id;
            if (IDs == 0)
            {
                IDs = 1;
            }
        }
        private void buttonProximo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void FormQuestionario_Load(object sender, EventArgs e)
        {
            labelPergunta.Text = new PerguntasBLL().BuscarPorId(IDs).pergunta;

            if (labelPergunta.Text == "")
            {
                FinalizarQuestionario();
                IDs = -1;
                using (FormIntroducao frm = new FormIntroducao(idCategoriaMaisFrequente))
                {
                    frm.ShowDialog();
                    return;
                }

            }
        }

        private void buttonProximo_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormQuestionario_Load(this, EventArgs.Empty);
        }


        private void radioButtonNao_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonSim_CheckedChanged(object sender, EventArgs e)
        {
            sim.Add(new PerguntasBLL().BuscarPorId(IDs).id_categoria);

        }

        private void radioButtonTalvez_CheckedChanged(object sender, EventArgs e)
        {

        }
        List<int> sim = new List<int>();
        public int FinalizarQuestionario()
        {
            // Calcular a contagem de repetições para cada ID de categoria
            Dictionary<int, int> contagem = sim.GroupBy(id => id)
                                                .ToDictionary(group => group.Key, group => group.Count());

            // Obter a categoria com a maior contagem de repetições
            idCategoriaMaisFrequente = contagem.OrderByDescending(pair => pair.Value).First().Key;

            // Retornar o ID da categoria mais frequente
            return idCategoriaMaisFrequente;
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            // Close the current form
            this.Close();

            // Open a new instance of the same form
            FormQuestionario newForm = new FormQuestionario(1024); // Adjust the ID as needed
            newForm.ShowDialog();
        }

        private void buttonSair_KeyPress(object sender, KeyPressEventArgs e)
        {


        }
    }
}
