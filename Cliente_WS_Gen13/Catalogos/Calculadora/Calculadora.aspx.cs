using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cliente_WS_Gen13.Catalogos.Calculadora
{
    public partial class Calculadora : System.Web.UI.Page
    {
        // Crear un cliente que resuelva las peticiones del servicio SOAP.
        Calculadora_Service.Calculadora_ServiceSoapClient Cliente_WS;

        protected void Page_Load(object sender, EventArgs e)
        {
            // Iniacializo mi cliente SOAP.
            Cliente_WS = new Calculadora_Service.Calculadora_ServiceSoapClient();
        }

        protected void btnSumar_Click(object sender, EventArgs e)
        {
            // Recupero los datos del formulario.
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            // Invoco a mi servicio pasando los datos que se requieran.
            double resultado = Cliente_WS.Suma(a, b);
            // Muestro el resultado del servicio en mi página.
            lblResultado.Text = resultado.ToString();
        }

        protected void btnRestar_Click(object sender, EventArgs e)
        {
            // Recupero los datos del formulario.
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            // Invoco a mi servicio pasando los datos que se requieran.
            double resultado = Cliente_WS.Resta(a, b);
            // Muestro el resultado del servicio en mi página.
            lblResultado.Text = resultado.ToString();
        }

        protected void btnMultiplicar_Click(object sender, EventArgs e)
        {
            // Recupero los datos del formulario.
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            // Invoco a mi servicio pasando los datos que se requieran.
            double resultado = Cliente_WS.Multiplicacion(a, b);
            // Muestro el resultado del servicio en mi página.
            lblResultado.Text = resultado.ToString();
        }

        protected void btnDividir_Click(object sender, EventArgs e)
        {
            // Recupero los datos del formulario.
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            // Invoco a mi servicio pasando los datos que se requieran.
            double resultado = Cliente_WS.Division(a, b);
            // Muestro el resultado del servicio en mi página.
            lblResultado.Text = resultado.ToString();
        }
    }
}