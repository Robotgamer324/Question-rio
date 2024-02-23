using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BLL;
using Models;

namespace UIWindowsForms
{
    public partial class FormPrincipal : Form
    {
        public int id;
        public readonly List<int> _categoriasSelecionadas;
        public bool sair=true;

        public FormPrincipal()
        {
            InitializeComponent();
            _categoriasSelecionadas = new List<int>();
        }

        private void buttonIniciar_Click(object sender, EventArgs e)
        {
            id = 0;

            while (sair==true)
            {
                using (FormQuestionario frm = new FormQuestionario(id, this))
                {
                    if (sair == false) { break; }
                    frm.ShowDialog();
                    id = frm.IDs + 1;
                }
            }
            sair =true  ;
            
            
        }

        public void SaveSelectedCategoria(int idCategoria)
        {
            _categoriasSelecionadas.Add(idCategoria);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (FormLogin frm = new FormLogin())
            {
                frm.ShowDialog();
            }
        }
    }
}
