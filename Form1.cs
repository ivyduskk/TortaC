using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        private Dictionary<int, string> obsequios = new Dictionary<int, string>();
        private Dictionary<string, decimal> preciosProductos = new Dictionary<string, decimal>
            {
            {"PAQUETE KIDS", 55},
            {"JALAPENO", 25},
            {"ITALIANA", 30},
            {"JAMON", 25},
            {"CHICA", 12},
            {"MEDIANA", 15},
            {"GRANDE", 18},
            {"GALLETAS", 13},
            {"PAY DE QUESO", 22},
            {"NIEVE", 15}
        };

        

        public Form1()
        {
            InitializeComponent();
            InitializeObsequios();
            Form1_Load(null, null);
        }
        private void InitializeObsequios()
        {
            obsequios.Add(1, "Paquete Avengers");
            obsequios.Add(2, "Paquete Barbie");
            obsequios.Add(3, "Paquete Sorpresa");
        }

        private void btnBuscarObsequio_Click(object sender, EventArgs e)
        {

            // Verificar Paquete kids seleccionado
            if (listBoxTortas.SelectedItem != null && listBoxTortas.SelectedItem.ToString() == "PAQUETE KIDS")
            {
                //Obtener ID 
                if (int.TryParse(txtCodigoObsequio.Text, out int codigo))
                {
                    // Descripción diccionario
                    if (obsequios.TryGetValue(codigo, out string descripcion))
                    {
                        txtDescripcionObsequio.Text = descripcion;
                    }
                    else
                    {
                        MessageBox.Show("Código de obsequio no válido.");

                        txtCodigoObsequio.Text = "";
                        txtDescripcionObsequio.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un código de obsequio válido.");

                    txtCodigoObsequio.Text = "";
                    txtDescripcionObsequio.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Paquete kids para buscar un obsequio.");
            }
        }
        private void btnCalcularPago_Click(object sender, EventArgs e)
        {
            decimal subtotal = 0;

            // Sumar torrtas
            foreach (var item in listBoxTortas.SelectedItems)
            {
                if (preciosProductos.TryGetValue(item.ToString(), out decimal precio))
                {
                    subtotal += precio;
                }
            }

            // Sumar refrescos 
            foreach (var item in listBoxRefresco.SelectedItems)
            {
                if (preciosProductos.TryGetValue(item.ToString(), out decimal precio))
                {
                    subtotal += precio;
                }
            }

            // Sumar postres 
            foreach (var item in listBoxPostre.SelectedItems)
            {
                if (preciosProductos.TryGetValue(item.ToString(), out decimal precio))
                {
                    subtotal += precio;
                }
            }

            //  IVA y Total
            decimal iva = subtotal * 0.16m;
            decimal total = subtotal + iva;

            // Resultados 
            txtSubtotal.Text = subtotal.ToString("C");
            txtIVA.Text = iva.ToString("C");
            txtTotal.Text = total.ToString("C");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            txtSubtotal.Enabled = false;
            txtIVA.Enabled = false;
            txtTotal.Enabled = false;
            btnBuscarObsequio.Enabled = false; // Deshabilitar al inicio
        }

        private void txtCodigoObsequio_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBoxTortas_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isPaqueteKidsSelected = listBoxTortas.SelectedItem != null && listBoxTortas.SelectedItem.ToString() == "PAQUETE KIDS";

            txtCodigoObsequio.Enabled = isPaqueteKidsSelected;
            txtDescripcionObsequio.Enabled = isPaqueteKidsSelected;
            btnBuscarObsequio.Enabled = isPaqueteKidsSelected;

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBoxRefresco_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxPostre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
