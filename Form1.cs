namespace Ejercicio9_Descuento_Articulos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double Precio, Descuento1, Descuento2, Descuento3, Descuento4, Itbis, MontoNeto;

            Precio = double.Parse(txtPrecio.Text);
            Descuento1 = Precio * 0.03;
            Descuento2 = Precio * 0.05;
            Descuento3 = Precio * 0.08;
            Descuento4 = Precio * 0.10;
            Itbis = Precio * 0.18;


            if (Precio <= 5000)

            {

                txtDescuento.Text = "No Aplica";
                txtDescuento.ForeColor = Color.Red;
                txtResultadoMonto.Text = String.Empty;
                txtResultadoDescuento.Text = String.Empty;
                txtResultadoItbis.Text = String.Empty;
                txtResultadoMontoNeto.Text = String.Empty;


            }


            else if (Precio <= 10000)
            {
                MontoNeto = (Precio - Descuento1 + Itbis);
                txtDescuento.Text = "Aplica";
                txtDescuento.ForeColor = Color.Green;
                txtResultadoMonto.Text = Precio.ToString();
                txtResultadoDescuento.Text = Descuento1.ToString();
                txtResultadoItbis.Text = Itbis.ToString();
                txtResultadoMontoNeto.Text = MontoNeto.ToString();


            }

            else if (Precio <= 15000)
            {
                MontoNeto = (Precio - Descuento2 + Itbis);
                txtDescuento.Text = "Aplica";
                txtDescuento.ForeColor = Color.Green;
                txtResultadoMonto.Text = Precio.ToString();
                txtResultadoDescuento.Text = Descuento2.ToString();
                txtResultadoItbis.Text = Itbis.ToString();
                txtResultadoMontoNeto.Text = MontoNeto.ToString();


            }

            else if (Precio <= 20000)
            {
                MontoNeto = (Precio - Descuento3 + Itbis);
                txtDescuento.Text = "Aplica";
                txtDescuento.ForeColor = Color.Green;
                txtResultadoMonto.Text = Precio.ToString();
                txtResultadoDescuento.Text = Descuento3.ToString();
                txtResultadoItbis.Text = Itbis.ToString();
                txtResultadoMontoNeto.Text = MontoNeto.ToString();



            }

            else if (Precio > 20000)
            {
                MontoNeto = (Precio - Descuento4 + Itbis);
                txtDescuento.Text = "Aplica";
                txtDescuento.ForeColor = Color.Green;
                txtResultadoMonto.Text = Precio.ToString();
                txtResultadoDescuento.Text = Descuento4.ToString();
                txtResultadoItbis.Text = Itbis.ToString();
                txtResultadoMontoNeto.Text = MontoNeto.ToString();


            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtResultadoMonto.Text = String.Empty;
            txtResultadoDescuento.Text = String.Empty;
            txtResultadoItbis.Text = String.Empty;
            txtResultadoMontoNeto.Text = String.Empty;
            txtDescuento.Clear();
            txtPrecio.Clear();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}