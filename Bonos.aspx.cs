using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CalculaBonos.Models;

namespace CalculaBonos
{
    public partial class Bonos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Empleado> misEmpleados = new List<Empleado>();
                Empleado empleado1 = new Empleado(1, "Juan Soto", 5000.43, 1, 1,45, true, false, true, 6);
                Empleado empleado2 = new Empleado(2, "Elena CasaBlanca", 10000.00, 2, 1, 23, true, true, false, 11);
                Empleado empleado3 = new Empleado(3, "Martha Kauffman", 3500.00, 2, 2, 25 ,false, false, true, 5);
                Empleado empleado4 = new Empleado(4, "Mireya Arteaga", 8000.00, 2, 1, 35, false, true, false, 3);
                Empleado empleado5 = new Empleado(5, "Richard Belzart", 3200.03, 1, 2,53, false, false, false, 2);
                misEmpleados.Add(empleado1);
                misEmpleados.Add(empleado2);
                misEmpleados.Add(empleado3);
                misEmpleados.Add(empleado4);
                misEmpleados.Add(empleado5);

                Session["Empleados"] = misEmpleados;

                //Agregar los empleados el drop
                ListItem itemLis;
                itemLis = new ListItem("Elige un opcion", "0");
                ddlEmpleados.Items.Add(itemLis);
                foreach (var item in misEmpleados)
                {
                    itemLis = new ListItem(item.name, item.ID.ToString());
                    ddlEmpleados.Items.Add(itemLis);
                }
                //Todos los controles en blanco
            }
        }

        protected void ddlEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            int IDEmpleado = Convert.ToInt32(ddlEmpleados.SelectedIndex);
            List<Empleado> newList = Session["Empleados"] as List<Empleado>;
            newList.ToList();
            Empleado nuevoEmpleado = newList.Find(x => x.ID == IDEmpleado);

            LabelID2.Text = nuevoEmpleado.ID.ToString();
            LabelSueldo2.Text = nuevoEmpleado.sueldo.ToString();
            LabelEdad2.Text = nuevoEmpleado.edad.ToString();
            if (nuevoEmpleado.sexo == 1)
            {
                LabelSexo2.Text = "Masculino";
            }
            else
            {
                LabelSexo2.Text = "Femenino";
            }
            if (nuevoEmpleado.nacionalidad == 1)
            {
                LabelNac2.Text = "Nacional";
            }
            else
            {
                LabelNac2.Text = "Extranjero"; 
            }

            //CheckBox de los cursos
            if (nuevoEmpleado.cursos[0])
            {
                PHP.Checked = true;
            }
            else
            {
                PHP.Checked = false;
            }

            if (nuevoEmpleado.cursos[1])
            {
                Java.Checked = true;
            }
            else
            {
                Java.Checked = false;
            }

            if (nuevoEmpleado.cursos[2])
            {
                Asp.Checked = true;
            }
            else
            {
                Asp.Checked = false;
            }

            //Check de los Rediobuttons
            if (nuevoEmpleado.antiguedad <= 10)
            {
                Radio1.Checked = true;
            }
            else
            {
                Radio2.Checked = true;
            }
        }

        protected void Button1_Click(Object sender,EventArgs e)
        {
            try
            {
                string sueldo = LabelSueldo2.Text;
                double salario = Convert.ToDouble(sueldo);
                double Bono;
                salario = salario * 0.15;
                double AumentoSexo = 0.0;
                double AumentoEdad = 0.0;
                double DecrementoNAc = 0.0;
                if (LabelSexo2.Text == "Femenino")
                {
                    AumentoSexo = salario * 0.03;
                    AumentoSexo2.Text = AumentoSexo.ToString();
                }
                if (Convert.ToInt32(LabelEdad2.Text) > 45)
                {
                    AumentoEdad = salario * 0.02;
                    AumentoEdad2.Text = AumentoEdad.ToString();
                }
                if (LabelNac2.Text == "Extranjero")
                {
                    DecrementoNAc = salario * 0.05;
                    DecrementoNac2.Text = DecrementoNAc.ToString();
                }
                Bono = salario + AumentoSexo + AumentoEdad - DecrementoNAc;
                LabelBono2.Text = Bono.ToString();
            }
            catch(Exception)
            {
                Response.Write("<script>alert('Favor de elegir un empleado');</script>");
            }
        }
    }
}