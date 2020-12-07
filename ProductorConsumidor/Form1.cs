using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace ProductorConsumidor
{
    public partial class Form1 : Form
    {
        List<int> productor = new List<int>();
        List<int> consumidor = new List<int>();

        int cont = 0;
        int tnoc = 0;
        int value = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            producirInicio();
        }

        private void producirInicio(){
            for(int a = 0; a < 25; a++) {
                consumidor.Add(a);
            }

            Console.WriteLine(consumidor.Count);
            numRandom();
            crono.Start();
        }

        private void turno()
        {
            var seed = Environment.TickCount;
            var random = new Random(seed);
            value = random.Next(0, 2);

            if(value == 0)
            {
                numRandom();
                crono.Start();
            }
            else if(value == 1)
            {
                numRandom();
                onorc.Start();
            }

        }

        private void crono_Tick(object sender, EventArgs e){
            if(consumidor.Count != 0)
            {
                productorstate.Text = "Trabajando";
                productortime.Text = (value - 1).ToString();
                turn.Text = "Productor";
                time.Text = (value - 1).ToString();
                consumidorstate.Text = "Descansando";
                consumidortime.Text = "-";

                dibujar(cont);
                cont++;
                value--;

                if (value == 0 || productor.Count == 25)
                {
                    crono.Stop();

                    productorstate.Text = "-";
                    productortime.Text = "-";
                    turn.Text = "-";
                    time.Text = "-";
                    consumidorstate.Text = "-";
                    consumidortime.Text = "-";

                    turno();
                }

                productor.Add(consumidor[0]);
                consumidor.RemoveAt(0);

                if (cont == 25)
                {
                    cont = 0;
                }
            }
            else
            {
                productorstate.Text = "Descansando";
                productortime.Text = "-";
                turn.Text = "Producción completa";
                time.Text = "-";
                consumidorstate.Text = "Iniciando";
                consumidortime.Text = "-";

                crono.Stop();
                numRandom();
                onorc.Start();
            }
            
        }

        private void onorc_Tick(object sender, EventArgs e)
        {
            if (productor.Count != 0)
            {
                consumidorstate.Text = "Trabajando";
                consumidortime.Text = (value - 1).ToString();
                turn.Text = "Consumidor";
                time.Text = (value - 1).ToString();
                productorstate.Text = "Descansando";
                productortime.Text = "-";

                limpiar(tnoc);
                tnoc++;
                value--;

                if (value == 0 || consumidor.Count == 25)
                {
                    onorc.Stop();

                    consumidorstate.Text = "-";
                    consumidortime.Text = "-";
                    turn.Text = "-";
                    time.Text = "-";
                    productorstate.Text = "-";
                    productortime.Text = "-";

                    turno();
                }

                consumidor.Add(productor[0]);
                productor.RemoveAt(0);

                if (tnoc == 25){
                    tnoc = 0;
                }
            }
            else
            {
                consumidorstate.Text = "Descansando";
                consumidortime.Text = "-";
                turn.Text = "Productos terminados";
                time.Text = "-";
                productorstate.Text = "Iniciando";
                productortime.Text = "-";

                onorc.Stop();
                numRandom();
                crono.Start();
            }
            

            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.ToString() == "27")
            {
                state.Text = "Finalizado";

                productorstate.Text = "-";
                productortime.Text = "-";
                turn.Text = "-";
                time.Text = "-";
                consumidorstate.Text = "-";
                consumidortime.Text = "-";

                crono.Stop();
                onorc.Stop();
            }
        }

        //////////////////////////////////////////////////////// Funciones auxiliares

        // Dibuja para el productor
        private void dibujar(int pos){
            if (pos + 1 == 1)
            {
                pictureBox2.Visible = true;
            }
            else if (pos + 1 == 2)
            {
                pictureBox3.Visible = true;
            }
            else if (pos +1  == 3)
            {
                pictureBox4.Visible = true;
            }
            else if (pos + 1 == 4)
            {
                pictureBox5.Visible = true;
            }
            else if (pos + 1 == 5)
            {
                pictureBox6.Visible = true;
            }
            else if (pos + 1 == 6)
            {
                pictureBox7.Visible = true;
            }
            else if (pos + 1 == 7)
            {
                pictureBox8.Visible = true;
            }
            else if (pos + 1 == 8)
            {
                pictureBox9.Visible = true;
            }
            else if (pos + 1 == 9)
            {
                pictureBox10.Visible = true;
            }
            else if (pos + 1 == 10)
            {
                pictureBox11.Visible = true;
            }
            else if (pos + 1 == 11)
            {
                pictureBox12.Visible = true;
            }
            else if (pos + 1 == 12)
            {
                pictureBox13.Visible = true;
            }
            else if (pos + 1 == 13)
            {
                pictureBox14.Visible = true;
            }
            else if (pos + 1 == 14)
            {
                pictureBox15.Visible = true;
            }
            else if (pos + 1 == 15)
            {
                pictureBox16.Visible = true;
            }
            else if (pos + 1 == 16)
            {
                pictureBox17.Visible = true;
            }
            else if (pos + 1 == 17)
            {
                pictureBox18.Visible = true;
            }
            else if (pos + 1 == 18)
            {
                pictureBox19.Visible = true;
            }
            else if (pos + 1 == 19)
            {
                pictureBox20.Visible = true;
            }
            else if (pos + 1 == 20)
            {
                pictureBox21.Visible = true;
            }
            else if (pos + 1 == 21)
            {
                pictureBox22.Visible = true;
            }
            else if (pos + 1 == 22)
            {
                pictureBox23.Visible = true;
            }
            else if (pos + 1 == 23)
            {
                pictureBox24.Visible = true;
            }
            else if (pos + 1 == 24)
            {
                pictureBox25.Visible = true;
            }
            else if (pos + 1 == 25)
            {
                pictureBox26.Visible = true;
            }
        }
        
        // Limpia para el consumidor
        private void limpiar(int pos){
            if (pos + 1 == 1)
            {
                pictureBox2.Visible = false;
            }
            else if (pos + 1 == 2)
            {
                pictureBox3.Visible = false;
            }
            else if (pos + 1 == 3)
            {
                pictureBox4.Visible = false;
            }
            else if (pos + 1 == 4)
            {
                pictureBox5.Visible = false;
            }
            else if (pos + 1 == 5)
            {
                pictureBox6.Visible = false;
            }
            else if (pos + 1 == 6)
            {
                pictureBox7.Visible = false;
            }
            else if (pos + 1 == 7)
            {
                pictureBox8.Visible = false;
            }
            else if (pos + 1 == 8)
            {
                pictureBox9.Visible = false;
            }
            else if (pos + 1 == 9)
            {
                pictureBox10.Visible = false;
            }
            else if (pos + 1 == 10)
            {
                pictureBox11.Visible = false;
            }
            else if (pos + 1 == 11)
            {
                pictureBox12.Visible = false;
            }
            else if (pos + 1 == 12)
            {
                pictureBox13.Visible = false;
            }
            else if (pos + 1 == 13)
            {
                pictureBox14.Visible = false;
            }
            else if (pos + 1 == 14)
            {
                pictureBox15.Visible = false;
            }
            else if (pos + 1 == 15)
            {
                pictureBox16.Visible = false;
            }
            else if (pos + 1 == 16)
            {
                pictureBox17.Visible = false;
            }
            else if (pos + 1 == 17)
            {
                pictureBox18.Visible = false;
            }
            else if (pos + 1 == 18)
            {
                pictureBox19.Visible = false;
            }
            else if (pos + 1 == 19)
            {
                pictureBox20.Visible = false;
            }
            else if (pos + 1 == 20)
            {
                pictureBox21.Visible = false;
            }
            else if (pos + 1 == 21)
            {
                pictureBox22.Visible = false;
            }
            else if (pos + 1 == 22)
            {
                pictureBox23.Visible = false;
            }
            else if (pos + 1 == 23)
            {
                pictureBox24.Visible = false;
            }
            else if (pos + 1 == 24)
            {
                pictureBox25.Visible = false;
            }
            else if (pos + 1 == 25)
            {
                pictureBox26.Visible = false;
            }
        }

        // Genera numero aleatorio entre 4 y 8
        private void numRandom(){
            var seed = Environment.TickCount;
            var random = new Random(seed);
            value = random.Next(4, 8);
        }

        // Errores

        private void label39_Click(object sender, EventArgs e)
        { }

        private void label47_Click(object sender, EventArgs e)
        { }

        private void turn_Click(object sender, EventArgs e)
        { }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        { }
    }
}
