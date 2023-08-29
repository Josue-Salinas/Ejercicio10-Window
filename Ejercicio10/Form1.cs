namespace Ejercicio10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double montoDesc, impuesto, subTotal, costo, importePago;
            costo=double.Parse(textcosto.Text);              
            if (costo <= 100)
            {
                montoDesc = costo * 0.1;
                
            }
            else
            {
                montoDesc = costo * 0.2;
            }
            subTotal = costo - montoDesc;
            impuesto = subTotal * 0.18;
            importePago = subTotal + impuesto;
            textdescuento.Text = "S/." + montoDesc;
            textimpuesto.Text = "S/." + impuesto;
            textsubtotal.Text = "S/." + subTotal;
            lblimportetotal.Text = "El importe total es: S/." + importePago;
            
        }
    }
}