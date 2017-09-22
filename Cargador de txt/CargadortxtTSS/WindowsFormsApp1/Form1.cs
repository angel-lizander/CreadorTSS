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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();


        }

        private void lectortxt()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void leer(string dir, string rnc, string proceso, string fecha)
        {
            string[] rows = File.ReadAllLines(dir);
            string[] encabezado = rows[0].Split(',');
            encabezado[1] = proceso;
            encabezado[2] = rnc;
            encabezado[3] = fecha;




        }
        public void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Filter = "Text Files (.txt)|*.txt";
            abrir.ShowDialog();

            string[] rows = File.ReadAllLines(abrir.FileName);
            //Aquï empieza la lectura
            string[] encabezado = rows[0].Split(',');
            string[] sumario = rows[rows.GetLength(0) - 1].Split(',');

            //Aquí se ejecuta el código si cumple con las exigencias

            for (int i = 1; i < rows.GetLength(0) - 1; i++)
            {
                if (Convert.ToString(encabezado[0]) != "E" | rows[i].Split(',')[0] != "D" | sumario[0] != "S")
                {
                    MessageBox.Show("Su documento tiene un formato erróneo");

                }

                else
                {

                    using (Cargador cargar = new Cargador(abrir.FileName))
                    {
                        cargar.ShowDialog();
                    }



                }
            }
        }
    }
}
