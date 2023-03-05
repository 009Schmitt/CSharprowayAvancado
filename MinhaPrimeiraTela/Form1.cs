using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinhaPrimeiraTela
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            string[] bancoDeDados = File.ReadAllLines(@"C:\BD\Cliente.txt");
            //List<string> bancoDeDados = bD.ToList<string>();
            //bancoDeDados.RemoveAt(0);


            bool loginEncontrado = false;
            foreach (var item in bancoDeDados)
            {
                string[] temp = item.Split('|');
                try
                {
                    Cliente cli = new Cliente()
                    {
                        ID = Convert.ToInt32(temp[0]),
                        Nome = temp[1],
                        Idade = Convert.ToInt32(temp[2]),
                        Cpf = temp[3],
                        Login = temp[4],
                        Senha = temp[5]
                    };

                    if (cli.Login == txtLogin.Text)
                    {
                        loginEncontrado = true;
                        if (cli.Senha == txtSenha.Text)
                        {
                            MessageBox.Show("Login Efetuado");
                        }
                        else
                        {
                            MessageBox.Show("Senha incorreta");
                        }
                    }
                }
                catch (Exception)
                {

                }
            }

            if (!loginEncontrado)
            {
                MessageBox.Show("Login Não encontrado na base");
            }
        }

    }
}
