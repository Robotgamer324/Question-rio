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
        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonComfirmar_Click(object sender, EventArgs e)
        {
            try
            {

                if (new UsuarioBLL().ConfirmarUsuario(textBoxLogin.Text, textBoxSenha.Text)) 
                {
                  
                    using (FormPrincipalADM frm = new FormPrincipalADM())
                    {
                        frm.ShowDialog();
                        
                    }
                   
                }
                else
                {
                    MessageBox.Show("Usuario ou senha estão errados tente novamente mais tarde");
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Usuario ou senha estão errados tente novamente mais tarde");
            }
        }
    }
}
