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

namespace Creador_de_txt
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GeneradorArchivo(string ruta)
        {
            using (System.IO.StreamWriter w = File.AppendText(ruta))
            {
      
                w.WriteLine("E, 130-99999-1, GRUPO CORTEFIEL, 17/09/2017");
                w.WriteLine("D, 001-00223225-4, Angel Lizander, Evangelista, Valenzuela, 19.000.00, 1.200.00");
                w.WriteLine("S, 4, 100.000.00, 50.000.00");
                MessageBox.Show("Archivo generado con exito");

            }
          
        }

         private void btnSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile1 = new SaveFileDialog();
            savefile1.Filter = "Text Files (.txt)|*.txt";
            savefile1.DefaultExt = "txt";
            savefile1.AddExtension = true;
            savefile1.DefaultExt = "txt";
            savefile1.ShowDialog();
            string saveas = savefile1.FileName;
            GeneradorArchivo(saveas);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string a = "D://TSS.txt";
            GeneradorArchivo(a);
        }
    }
}
