using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ds2_banco
{
    public partial class Frm_NovaConta : Form
    {
        public Frm_NovaConta()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if(txtNome.Text == string.Empty || txtSobrenome.Text == string.Empty || txtCpf.Text == string.Empty || txtNumero.Text == string.Empty || txtSaldo.Text == string.Empty || txtLimite.Text == string.Empty)
            {
                MessageBox.Show("Verifique se todos os campos estão preenchidos!");
            } else {
                Cliente clie = new Cliente();

                clie.nome = txtNome.Text;
                clie.sobrenome = txtSobrenome.Text;
                clie.cpf = txtCpf.Text;

                Conta cc = new Conta(clie);

                cc.numero = Convert.ToInt32(txtNumero.Text);
                cc.limite = Convert.ToInt32(txtLimite.Text);
                cc.saldo = Convert.ToInt32(txtSaldo.Text);

                if (rdbSaque.Checked) {
                    cc.sacar(Convert.ToDouble(txtValor.Text));
                    MessageBox.Show(Convert.ToString(cc.saldo));
                } else {
                    cc.depositar(Convert.ToDouble(txtValor.Text));
                    MessageBox.Show(Convert.ToString(cc.saldo));
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = string.Empty;
            txtCpf.Text = string.Empty;
            txtLimite.Text = string.Empty;
            txtNumero.Text = string.Empty;
            txtSaldo.Text = string.Empty;
            txtSobrenome.Text = string.Empty;
            txtValor.Text = string.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja Sair?", "Confirmação ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
