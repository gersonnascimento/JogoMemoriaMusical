using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo
{
    public partial class Form1 : Form
    {
        int[] sorteados = new int[20];//vetor que armazena os números sorteados.
        int contagem = 0;//variável que vai passar pelos valores do vetor.
        int final = 0; //variável que vai marcar a última passagem do vetor.
        int nivel = 0;
        private void comecar()
        {
           Random random = new Random();
            sorteados[0] = random.Next(1, 5);

            int c = 1;
            while (c<= sorteados.Length - 1)
            {
                Random rand = new Random();
                int a = rand.Next(1,5);

                if (a != sorteados[c - 1])
                {
                    sorteados[c] = a;
                    c++;
                }
            }
            acender();
        }

        public void tentativa(int botao)
        {

            if (botao == sorteados[contagem] && contagem < final)
                contagem++;
           
            else if (botao == sorteados[contagem] && contagem >= final) {
                if (contagem + 1 == final)
                    MessageBox.Show("Parabens você ganhou!!");
                final++;
                acender();

            }

            else if (botao != sorteados[contagem])
            {
                final++;
                MessageBox.Show("Você perdeu!\n Chegou até o nível "+final+".");
                final = 0;
                nivel = 0;
                contagem = 0;
                desabilitarBtn();
                btnRecomecar.Visible = true;
            }

       
        }
        
        public void acender()
        {
            contagem = 0;//para repassar a sequencia;
            desabilitarBtn();
            timer1.Enabled = true;
            nivel++;
            label1.Text = ("Nível: " + nivel);
            habilitarBtn();

        }
        private void desabilitarBtn() {
            verde.Enabled = false;
            vermelho.Enabled = false;
            amarelo.Enabled = false;
            azul.Enabled = false;
        }
        private void habilitarBtn()
        {
            verde.Enabled = true;
            vermelho.Enabled = true;
            amarelo.Enabled = true;
            azul.Enabled = true;;
        }

        private void voltaCor()
        {
            azul.Image = Properties.Resources.AzulApagado;
            verde.Image = Properties.Resources.VdApagado;
            amarelo.Image = Properties.Resources.amareloApagado;
            vermelho.Image = Properties.Resources.VrmApagado;
           
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            voltaCor();
            desabilitarBtn();
            
            if (contagem > final)
            {
                habilitarBtn();
                contagem = 0;
                timer1.Enabled = false;
            }
            else
            {
                if (sorteados[contagem] == 1)
                {
                    verde.Image = Properties.Resources.qqAceso;
                   // System.Console.Beep(1000, 300);
                    //System.Threading.Thread.Sleep(50);
                }
                else if(sorteados[contagem] == 2)
                {
                    vermelho.Image = Properties.Resources.qqAceso;
                   // System.Console.Beep(1200, 300);
                   // System.Threading.Thread.Sleep(50);
                }
                else if (sorteados[contagem] == 3)
                {
                    amarelo.Image = Properties.Resources.qqAceso;
                   // System.Console.Beep(1400, 300);
                   // System.Threading.Thread.Sleep(50);
                }
                else if (sorteados[contagem] == 4) {
                    azul.Image = Properties.Resources.qqAceso;
                   // System.Console.Beep(1600, 300);
                   // System.Threading.Thread.Sleep(50);
                }
                contagem++;
            }
        }

        private void btnComecar_Click(object sender, EventArgs e)
        {
            comecar();
            btnComecar.Visible = false;
        }
      
        private void verde_Click(object sender, EventArgs e)
        {
            verde.Image = Properties.Resources.qqAceso;
            timer2.Enabled = true;
            System.Console.Beep(1000, 300);
            tentativa(1);
        }

        private void vermelho_Click(object sender, EventArgs e)
        {
            vermelho.Image = Properties.Resources.qqAceso;
            timer2.Enabled = true;
            System.Console.Beep(1200, 300);
            tentativa(2);
        }

        private void amarelo_Click(object sender, EventArgs e)
        {
            amarelo.Image = Properties.Resources.qqAceso;
            timer2.Enabled = true;
            System.Console.Beep(1400, 300);
            tentativa(3);
        }

        private void azul_Click(object sender, EventArgs e)
        {
            azul.Image = Properties.Resources.qqAceso;
            timer2.Enabled = true;
            System.Console.Beep(1600, 300);
            tentativa(4);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            voltaCor();
            timer2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            habilitarBtn();
            comecar();
            btnComecar.Enabled = false;
            btnRecomecar.Visible = false;
        }
    }
}
