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

namespace UIWindowsForms
{
    public partial class FormPrincipalADM : Form
    {
        public string _usuario;
        public FormPrincipalADM(string _nome)
        {
            _usuario = _nome;
            InitializeComponent();
        }

        private void FormPrincipalADM_Load(object sender, EventArgs e)
        {
            label1.Text = ("Bem vindo " + _usuario);

        }

        private void buttonAlterarQuetionario_Click(object sender, EventArgs e)
        {
            using FormBuscarPerguntas frm = new FormBuscarPerguntas();
            {
                frm.ShowDialog();
            }

        }
    }
}
