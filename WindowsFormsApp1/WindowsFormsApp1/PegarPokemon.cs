using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoItX3Lib;


namespace WindowsFormsApp1
{
    public partial class PegarPokemon : Form
    {
        AutoItX3 au3 = new AutoItX3();
        public object[] pixCoord;

        public PegarPokemon()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            backgroundWorker1.WorkerSupportsCancellation = true;
        }

        private void Moverato_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy != true)
            {
                backgroundWorker1.RunWorkerAsync();
            }
            else
            {
                  backgroundWorker1.CancelAsync();  
            }
        }
        
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            Random randNum = new Random();
            string[] andar = new string[] {"www", "sss", "ddd","aaa"};
            while (true)
            {
                if (worker.CancellationPending == true)
                {
                    break;
                    
                }
                if (checkBox1.Checked)
                {
                    moverBoneco("ddd", 2);
                    moverBoneco("aaa", 2);
                }
                else
                {
                    moverBoneco(andar[randNum.Next(4)], 2);
                }
                if(detectarPixel(0xA32A28, 0, 0, 1920, 1080) == true)
                {
                    if (detectarPixel(0x512F00, 0, 0, 1920, 1080) == true) 
                    {
                        MessageBox.Show("ALGO ESPECIAL ENCONTRADO MAS NAO IDENTIFICADO :(");
                        break;
                    }
                    else
                    {
                        if (mudarpoke.Checked)
                        {
                            au3.MouseClick("LEFT", 647, 835);
                            Thread.Sleep(100);
                            au3.MouseClick("LEFT",786, 478);
                            Thread.Sleep(10000);
                            if (!fugir.Checked)
                            {
                                atacar();
                            }
                        }
                        else
                        {
                            au3.MouseClick("LEFT", 934, 830, 1, 2);
                        }
                    }
                }
            }
        }
        bool detectarPixel(int pixel,int xcima,int ycima ,int xbaixo, int ybaixo)
        {
            Object pix = au3.PixelSearch(xcima, ycima, 1920, 1080,pixel);
            if (pix.ToString() != "1")
            {
                try
                {
                    pixCoord = (object[])pix;
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        void atacar()
        {
            au3.MouseClick("LEFT", 772, 780, 1, 2);
            Thread.Sleep(500);
            if (detectarPixel(0x828282, 917, 882,1920,1080) == false && move1.Checked)
            {
                Thread.Sleep(50);
                au3.MouseClick("LEFT", 730, 709, 1, 2);//Move 1
            }
            else if (detectarPixel(0x828282, 1145, 879,1920,1080) == false && move2.Checked)
            {
                Thread.Sleep(50);
                au3.MouseClick("LEFT", 924, 709, 1, 2);//Move 2
            }
            else if (detectarPixel(0x828282, 908, 960,1920,1080) == false && move3.Checked)
            {
                Thread.Sleep(50);
                au3.MouseClick("LEFT", 685, 771, 1, 2);//Move 3
            }
            else if (move4.Checked)
            {
                Thread.Sleep(50);
                au3.MouseClick("LEFT", 911, 779, 1, 2);//Move 4
            }
        }
        void moverBoneco (string direcao,int mover)
        {
            for(int i = 0; i < mover;i++)
            {
                au3.Send(direcao);
                Thread.Sleep(300);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BattleFrontEnd passar = new BattleFrontEnd();
            passar.Show();
            this.Hide();
        }
    }
}
