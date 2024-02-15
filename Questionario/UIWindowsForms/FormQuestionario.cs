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

        public FormQuestionario(int _id, int _i)
        {
            InitializeComponent();
            IDs = _id;
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
                IDs = -1;
                using (FormIntroducao frm = new FormIntroducao())
                {
                    frm.ShowDialog();
                }
                this.Close();
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

        }

        private void radioButtonTalvez_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
