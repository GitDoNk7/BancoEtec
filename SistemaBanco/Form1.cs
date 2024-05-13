using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBanco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
               
        Conta conta1 = new Conta();
        Conta conta2 = new Conta();
        private void Form1_Load(object sender, EventArgs e)
        {
            conta1.numero = 1001;
            conta1.titular = "Joaquim";

            conta2.numero = 1002;
            conta2.titular = "Fernando";

            lbl_C1_numero.Text = conta1.numero.ToString();
            lbl_C1_titula.Text = conta1.titular.ToString();
            lbl_C1_saldo.Text = conta1.getSaldo().ToString("C");

            lbl_C2_numero.Text = conta2.numero.ToString();
            lbl_C2_titular.Text = conta2.titular.ToString();
            lbl_C2_saldo.Text = conta2.getSaldo().ToString("C");
        }

        private void btn_C1_sacar_Click(object sender, EventArgs e)
        {
            try
            {
                double valor = Convert.ToDouble(txt_C1_valor.Text);
                if (conta1.sacar(valor))
                {
                    lbl_C1_saldo.Text = conta1.getSaldo().ToString("C");
                }
                else
                {
                    MessageBox.Show($"Motivo: {conta1.getErro()}", "Erro ao Sacar");
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Motivo: {erro.Message}", "Erro");
            }
        }

        private void btn_C1_depositar_Click(object sender, EventArgs e)
        {
            try
            {
                double valor = Convert.ToDouble(txt_C1_valor.Text);
                if (conta1.depositar(valor))
                {
                    lbl_C1_saldo.Text = conta1.getSaldo().ToString("C");
                }
                else
                {
                    MessageBox.Show($"Motivo: {conta1.getErro()}", "Erro ao depositar");
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Motivo: {erro.Message}", "Erro");
            }
        }

        private void btn_C1_transferir_Click(object sender, EventArgs e)
        {
            try
            {
                double valor = Convert.ToDouble(txt_C1_valor.Text);
                if(conta1.transferir(valor, conta2))
                {
                    lbl_C1_saldo.Text = conta1.getSaldo().ToString("C");
                    lbl_C2_saldo.Text = conta2.getSaldo().ToString("C");
                }
                else
                {
                    MessageBox.Show($"Motivo: {conta1.getErro()}", "Erro ao transferir");
                }

            }
            catch (Exception erro)
            {
                MessageBox.Show($"Motivo: {erro.Message}", "Erro");
            }
        }

        private void btn_C2_sacar_Click(object sender, EventArgs e)
        {
            try
            {
                double valor = Convert.ToDouble(txt_C2_valor.Text);
                if (conta2.sacar(valor))
                {
                    lbl_C2_saldo.Text = conta2.getSaldo().ToString("C");
                }
                else
                {
                    MessageBox.Show($"Motivo: {conta2.getErro()}", "Erro ao Sacar");
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Motivo: {erro.Message}", "Erro");
            }
        }

        private void btn_C2_depositar_Click(object sender, EventArgs e)
        {
            try
            {
                double valor = Convert.ToDouble(txt_C2_valor.Text);
                if (conta2.depositar(valor))
                {
                    lbl_C2_saldo.Text = conta2.getSaldo().ToString("C");
                }
                else
                {
                    MessageBox.Show($"Motivo: {conta2.getErro()}", "Erro ao depositar");
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Motivo: {erro.Message}", "Erro");
            }
        }

        private void btn_C2_transferir_Click(object sender, EventArgs e)
        {
            try
            {
                double valor = Convert.ToDouble(txt_C2_valor.Text);
                if (conta2.transferir(valor, conta1))
                {
                    lbl_C2_saldo.Text = conta2.getSaldo().ToString("C");
                    lbl_C1_saldo.Text = conta1.getSaldo().ToString("C");
                }
                else
                {
                    MessageBox.Show($"Motivo: {conta2.getErro()}", "Erro ao transferir");
                }

            }
            catch (Exception erro)
            {
                MessageBox.Show($"Motivo: {erro.Message}", "Erro");
            }
        }

        
    }
}
