using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carrera
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btnc_Click(object sender, EventArgs e)
        {
            Liebre Liebre = new Liebre(player2Name.Text);
            Tortuga Tortuga = new Tortuga(player1Name.Text);
         
            do
            {
                Liebre.Mover();
                Tortuga.Mover();
                Player1.Text += Tortuga.ToString() + "\r\n";
                Player2.Text += Liebre.ToString() + "\r\n";
            } while (Tortuga.Posicion<100 && Liebre.Posicion<100);
            if (Liebre.Posicion > Tortuga.Posicion)
                label1.Text = $"El ganador es: Liebre ({Liebre.Name})";
            else if (Tortuga.Posicion > Liebre.Posicion)
                label1.Text = $"El ganador es: Tortuga ({Tortuga.Name})";
            else
                label1.Text = "Es un empate";
        }
        /// <summary>
        /// Botón que limpia la caja de texto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BorrarBtn_Click(object sender, EventArgs e)
        {
            Player1.Text = "";
            Player2.Text = "";
            label1.Text = "Carrera";
        }
    }
}
