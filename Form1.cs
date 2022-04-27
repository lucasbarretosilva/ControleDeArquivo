using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ControleDeArquivo
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string CriaPasta = @"C:\\" + txtCriarPasta.Text;

            if (!Directory.Exists(CriaPasta))
            {
                Directory.CreateDirectory(CriaPasta);
                MessageBox.Show("AEHOO PASTA CRIADA");
            }
            else
            {
                MessageBox.Show("Já existe uma pasta com esse nome! ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string deletaPasta = @"C:\\" + txtDeletarPasta.Text;

            if (Directory.Exists(deletaPasta))
            {
                Directory.Delete(deletaPasta, true);
            }
            else
            {
                MessageBox.Show("A pasta que você quer apagar não existe! ");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
          

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
                string origem = Path.Combine(@"C:\" + txtPastaOrigem.Text, txtArquivoOrigem.Text);
                string destino = Path.Combine(@"C:\" + txtPastaDestino.Text, txtArquivoOrigem.Text);

                File.Move(origem, destino);
                MessageBox.Show("Arquivo Movido!");
                txtArquivoOrigem.Clear();
                txtPastaDestino.Clear();
                txtPastaOrigem.Clear();
            
           
        }
    }
}
