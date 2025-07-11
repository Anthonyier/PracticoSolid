using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocio;

namespace PracticoSolid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {

            cargarComboxFabricante();
        }

        private void cargarComboxFabricante()
        {
            NegocioFabricante objFabricante = new NegocioFabricante();
            comboBoxFabricante.DataSource = objFabricante.obtenerFabricantes();
            comboBoxFabricante.DisplayMember = "nombre";
            comboBoxFabricante.ValueMember = "id";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string nombreProducto = textBoxNombreProducto.Text;
            decimal pesoProdcuto = Convert.ToDecimal(textBoxPeso.Text);
            string um = textBoxUM.Text;
            decimal precioLista = Convert.ToDecimal(textBoxPrecioLista.Text);
            string codBarra = textBoxCodBarra.Text;
            int idfabrcia = Convert.ToInt32(comboBoxFabricante.SelectedValue);

            NegocioProducto objNegocioProducto = new NegocioProductosLacteos();
            objNegocioProducto.RegistrarProducto(nombreProducto, pesoProdcuto, um, precioLista, codBarra, idfabrcia); // principio de susticion de liskov
            label1.Text = objNegocioProducto.obtenerClasificacion();

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string nombreProducto = textBoxNombreProducto.Text;
            decimal pesoProdcuto = Convert.ToDecimal(textBoxPeso.Text);
            string um = textBoxUM.Text;
            decimal precioLista = Convert.ToDecimal(textBoxPrecioLista.Text);
            string codBarra = textBoxCodBarra.Text;
            int idfabrcia = Convert.ToInt32(comboBoxFabricante.SelectedValue);

            NegocioProducto objNegocioProducto = new NegocioProductosVegetales();
            objNegocioProducto.RegistrarProducto(nombreProducto, pesoProdcuto, um, precioLista, codBarra, idfabrcia);
            label1.Text = objNegocioProducto.obtenerClasificacion();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string nombreProducto = textBoxNombreProducto.Text;
            decimal pesoProdcuto = Convert.ToDecimal(textBoxPeso.Text);
            string um = textBoxUM.Text;
            decimal precioLista = Convert.ToDecimal(textBoxPrecioLista.Text);
            string codBarra = textBoxCodBarra.Text;
            int idfabrcia = Convert.ToInt32(comboBoxFabricante.SelectedValue);

            NegocioProducto objNegocioProducto = new NegocioProductosBebidas();
            objNegocioProducto.RegistrarProducto(nombreProducto, pesoProdcuto, um, precioLista, codBarra, idfabrcia);
            label1.Text = objNegocioProducto.obtenerClasificacion();
        }
    }
}
