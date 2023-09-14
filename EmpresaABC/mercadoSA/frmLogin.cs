using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mercadoSA
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //frmMenuPrincipal abrir = new frmMenuPrincipal();
            //abrir.Show();
            //this.Hide();


            //declaração de variavel
            string usuario, senha;

            //inicializaçao das variaveis
            usuario = txtUsuario.Text;

            senha = txtSenha.Text;


        }

      

     

 

        }
    }

