using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Cargador : Form
    {
        private string directorio;
        public Cargador(string dir)
        {
            InitializeComponent();
            this.directorio = dir;

        }

        public void Cargador_Load(object sender, EventArgs e)
        {

            string[] rows = File.ReadAllLines(this.directorio);
            string[] encabezado = rows[0].Split(',');
            txtproceso.Text = encabezado[1];
            txtRNC.Text = encabezado[2];
            txtperiodo.Text = encabezado[3];


            //Aquí se ejecuta el código si cumple con las exigencias

          
          
          
            var dt = new DataTable();
            dt.Clear();
            dt.Columns.Add("Código de nómina", typeof(string));
            dt.Columns.Add("Tipo de documento", typeof(string));
            dt.Columns.Add("Documento", typeof(string));
            dt.Columns.Add("Nombre", typeof(string));
            dt.Columns.Add("Sexo", typeof(string));
            dt.Columns.Add("Primer Apellido", typeof(string));
            dt.Columns.Add("Segundo Apellido", typeof(string));
            dt.Columns.Add("Fecha de nacimiento", typeof(DateTime));
            dt.Columns.Add("Sueldo Neto", typeof(string));
            dt.Columns.Add("Descuento", typeof(string));
            dt.Columns.Add("Sueldo secundario", typeof(string));

            // string a = string.Concat(encabezado[1]);

                for (int i = 1; i < rows.GetLength(0) - 1; i++)
                {
                    DataRow dr = dt.NewRow();
                    dr["Código de nómina"] = rows[i].Split(',')[1];
                    dr["Tipo de documento"] = rows[i].Split(',')[2];
                    dr["Documento"] = rows[i].Split(',')[3];
                    dr["Nombre"] = rows[i].Split(',')[4];
                    dr["Sexo"] = rows[i].Split(',')[5];
                    dr["Primer apellido"] = rows[i].Split(',')[6];
                    dr["Segundo Apellido"] = rows[i].Split(',')[7];
                    dr["Fecha de nacimiento"] = Convert.ToDateTime(rows[i].Split(',')[8]);
                    dr["Sueldo neto"] = rows[i].Split(',')[9];
                    dr["Descuento"] = rows[i].Split(',')[10];
                    dr["Sueldo secundario"] = rows[i].Split(',')[11];
                    dt.Rows.Add(dr);
                }
            

            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();


            //Tomando el resumen
            string[] resumen = rows[rows.GetLength(0) - 1].Split(',');
            txtdatos.Text = resumen[1];

                }

}
        }

       

