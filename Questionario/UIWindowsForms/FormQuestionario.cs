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

        public FormQuestionario()
        {
            InitializeComponent();
        }
        private void buttonProximo_Click(object sender, EventArgs e)
        {
            FormQuestionario_Load(this, EventArgs.Empty);
            checkBoxNao.Checked = false;
            checkBoxSim.Enabled=false;
            checkBoxTalvez.Checked = false;

        }
        public void FormQuestionario_Load(object sender, EventArgs e)
        {
            IDs++;
            labelPergunta.Text = new PerguntasBLL().BuscarPorId(IDs).pergunta;

            if (labelPergunta.Text == "")
            {
                using (FormIntroducao frm = new FormIntroducao())
                {
                    frm.ShowDialog();
                }
            }

            checkBoxNao.DataBindings.Clear();
            checkBoxNao.Checked = false;


        }


        private void checkBoxSim_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNao.Checked == true || checkBoxTalvez.Checked == true)
            {
                checkBoxNao.Checked = false;
                checkBoxTalvez.Checked = false;
            }
            else
            {
                checkBoxSim.Checked = true;
            }
        }
        private void checkBoxNao_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSim.Checked == true || checkBoxTalvez.Checked == true)
            {
                checkBoxSim.Checked = false;
                checkBoxTalvez.Checked = false;
            }
            else
            {
                checkBoxNao.Checked = true;
            }
        }

        private void checkBoxTalvez_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNao.Checked == true || checkBoxSim.Checked == true)
            {
                checkBoxNao.Checked = false;
                checkBoxSim.Checked = false;
            }
            else
            {
                checkBoxTalvez.Checked = true;
            }
        }

        
    }
}
