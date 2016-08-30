using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Reporte.LoginDataSetTableAdapters;

namespace Reporte
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void CargarGrid()
        {
            string cadena = CadenaCon();
            SqlConnection Conexion = new SqlConnection(cadena);            
            DataSet ds = new DataSet();
            DatosTableAdapter data = new DatosTableAdapter("Select * from Datos", Conexion);
            Conexion.Open();
            data.Fill(ds, "Datos");
            Conexion.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            CargarGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
