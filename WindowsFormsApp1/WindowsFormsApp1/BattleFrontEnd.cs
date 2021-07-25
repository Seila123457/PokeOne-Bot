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
    public partial class BattleFrontEnd : Form
    {
        AutoItX3 au3 = new AutoItX3();
        public object[] pixCoord;

        public BattleFrontEnd()
        {
            InitializeComponent();
        }


        private void BattleFrontEnd_Load(object sender, EventArgs e)
        {
            backgroundWorker1.WorkerSupportsCancellation = true;
        }
        bool detectarPixel(int pixel, int xcima, int ycima, int xbaixo, int ybaixo)
        {
            Object pix = au3.PixelSearch(xcima, ycima, xbaixo, ybaixo, pixel);
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
        private void button1_Click(object sender, EventArgs e)
        {
            PegarPokemon passar = new PegarPokemon();
            passar.Show();
            this.Hide();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void Testes_Click(object sender, EventArgs e)
        {
            au3.MouseMove(54,14,2);
            au3.MouseDown();
            Thread.Sleep(2000);
            if (detectarPixel(0xB22D29, 0, 0, 1920, 1080) == true)
            {
                if (detectarPixel(0x6890F0, 99, 1, 117, 45) == true) // tipo Água
                {
                    Thread.Sleep(50);
                    au3.MouseClick("LEFT", 730, 709, 1, 2);//Move 1
                }
            }
        }
    }
}
