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
    public partial class frmCalcu : Form
    {
        public frmCalcu()
        {
            InitializeComponent();
        }

        private void frmCalcu_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void btoSair_Click(object sender, EventArgs e)
        {
            //declarando varivael para receber o valor do botao

         DialogResult resp = MessageBox.Show("Deseja seja sair?","messagem do sistema",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Information,MessageBoxDefaultButton.Button3);
         Application.Exit();
        }

        private void btoCalcular_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado= 0;

            num1 = Convert.ToDouble(txt1.Text);
            num2 = Convert.ToDouble (txt2.Text);

            if (rdoAdicao.Checked)
            {
                resultado = num1 + num2;
            }

            if (rdoSubtracao.Checked)
            {
                resultado = num1 + num2;
            }

            if (rdoMultiplicacao.Checked)
            {
                resultado = num1 + num2;
            }

            if (rdoDivisao.Checked)
            {
                resultado = num1 + num2;
            }
            if (num2==0)
            {
                DialogResult resp = MessageBox.Show("Impossivel dividir por zero!!", "messagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {
                resultado = num1 / num2;
            }







            lblVariavel3.Text = resultado.ToString();
        }

        private void lblVariavel3_Click(object sender, EventArgs e)
        {

        }
    }
}
