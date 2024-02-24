using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIWindowsForms
{
    public partial class FormLogin : Form
    {
        public int id1;
        public int id2;
        public string Login;
        public string Senha;
        public bool administrador;

        public FormLogin()
        {
            InitializeComponent();
        }


        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSair_Click(object sender, EventArgs e)
        {

        }

        private void buttonComfirmar_Click(object sender, EventArgs e)
        {
            id1 = new UsuarioBLL().BuscarPorUsuario(textBoxLogin.Text).FirstOrDefault()?.id; // Assuming 'Login' is a property of the Usuario class



        }

        private void labelSenha_Click(object sender, EventArgs e)
        {

        }

        private void labelLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
