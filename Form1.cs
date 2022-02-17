using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula03_escopo
{
    public partial class Form1 : Form
    {
        double media;
        public Form1()
        {
            InitializeComponent();
        }

      
        

        private void button1_Click(object sender, EventArgs e)
        {
            double nota1 = double.Parse(texnota1.Text);
            double nota2 = double.Parse(textnota2.Text);
            double nota3 = double.Parse(textnota3.Text);

            //processamento

            media = (nota1 + nota2 + nota3) / 3;

            lblresultado.Text = media.ToString();
            
        }

        private void btnValidarSituacao_Click(object sender, EventArgs e)
        {
            if( media >= 5)
            {
                lblsituacao.Text = "APROVADO";
            }
            else
            {
                lblsituacao.Text = "REPROVADO";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntNovoCalculo_Click(object sender, EventArgs e)
        {
            texnota1.Clear();
            textnota2.Clear();
            textnota3.Clear();

            lblresultado.Text = "";
            lblsituacao.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
