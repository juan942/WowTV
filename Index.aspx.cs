using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CalculaBonos.Models;

namespace CalculaBonos
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Creamos una lista vacia de empleados
            List<Empleado> misEmpleados = new List<Empleado>();
            //Creamos los empleados
            Empleado empleado1 = new Empleado(1, "Juan Soto", 5000.43, 1, 1, 45, true, false, true, 6);
            Empleado empleado2 = new Empleado(2, "Elena CasaBlanca", 10000.00, 2, 1, 23, true, true, false, 11);
            Empleado empleado3 = new Empleado(3, "Martha Kauffman", 3500.00, 2, 2, 25, false, false, true, 5);
            Empleado empleado4 = new Empleado(4, "Mireya Arteaga", 8000.00, 2, 1, 35, false, true, false, 3);
            Empleado empleado5 = new Empleado(5, "Richard Belzart", 3200.03, 1, 2, 53, false, false, false, 2);
            //Agregamos los empleados a la lista creada anteriormente
            misEmpleados.Add(empleado1);
            misEmpleados.Add(empleado2);
            misEmpleados.Add(empleado3);
            misEmpleados.Add(empleado4);
            misEmpleados.Add(empleado5);
            //Guardamos la lista en la variable de session
            Session["Empleados"] = misEmpleados;
            //Creamos una DataTable para llenar nuestra tabla
            DataTable data = new DataTable();
            data.Columns.Add("ID");
            data.Columns.Add("name");
            data.Columns.Add("sueldo");
            data.Columns.Add("sexo");
            data.Columns.Add("nacionalidad");
            //LLenamos los registros de la tabla
            foreach (var item in misEmpleados)
            {
                DataRow row;
                row = data.NewRow();
                row["ID"] = item.ID;
                row["name"] = item.name;
                row["sueldo"] = item.sueldo;
                if (item.sexo == 1)
                {
                    row["sexo"] = "Masculino";
                }else
                {
                    row["sexo"] = "Femenino";
                }

                if (item.nacionalidad == 1)
                {
                    row["nacionalidad"] = "Nacional";
                }else
                {
                    row["nacionalidad"] = "Extranjero";
                }
                data.Rows.Add(row);
            }
            //Enviamos la data a la tabla
            this.ListaEmpleados.DataSource = data;
            this.ListaEmpleados.DataBind();
        }
    }
}