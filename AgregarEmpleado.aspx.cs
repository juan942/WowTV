using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CalculaBonos.Models;

namespace CalculaBonos
{
    public partial class AgregarEmpleado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Empleado> misEmpleados = Session["Empleados"] as List<Empleado>;
                int indice = misEmpleados.Count();
                Empleado emp = misEmpleados[indice - 1];
                int newID = emp.ID + 1;
                Label6.Text = newID.ToString();

                //Agregar los items al drop de Sexo
                ListItem itemLisSexo1;
                ListItem itemLisSexo2;
                itemLisSexo1 = new ListItem("Masculino", "1");
                itemLisSexo2 = new ListItem("Femenino", "2");
                DDLSexo.Items.Add(itemLisSexo1);
                DDLSexo.Items.Add(itemLisSexo2);

                //Agregar los items al drop de Nacionalidad
                ListItem itemLisNac1;
                ListItem itemLisNac2;
                itemLisNac1 = new ListItem("Nacional", "1");
                itemLisNac2 = new ListItem("Extranjero", "2");
                DDLNac.Items.Add(itemLisNac1);
                DDLNac.Items.Add(itemLisNac2);
            }
        }
    }
}