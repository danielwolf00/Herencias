using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFC
{
    public partial class Form1 : Form
    {
        public string RFC { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string ApellidoP, ApellidoM, Nombre, Año, Mes, Dia;

            int Codigo;

            ApellidoP = txtApellidoP.Text;
            ApellidoM = txtApellidoM.Text;
            Nombre = txtNombre.Text;
            Año = txtAño.Text;
            Mes = txtMes.Text;
            Dia = txtDia.Text;

            Codigo = Año.Length;

            ApellidoP = ApellidoP.Substring(0, 2);
            ApellidoM = ApellidoM.Substring(0, 2);
            Nombre = Nombre.Substring(0, 2);
            Año = Año.Substring(0, 2);
            Mes = Mes.Substring(0, 2);
            Dia = Dia.Substring(0, 2);


            RFC = ApellidoP + ApellidoM + Nombre + Año + Mes + Dia;
            txtRFC.Text = RFC;  
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtApellidoP.Clear();
            txtApellidoM.Clear();
            txtNombre.Clear();
            txtAño.Clear();
            txtMes.Clear();
            txtDia.Clear();
            txtRFC.Clear();
            txtApellidoP.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
