using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using System.Collections;
using System.Runtime.InteropServices;
using System.Threading;
using System.Net;
using System.Xml;
using System.Globalization;

namespace crm
{
    public partial class frm_estadistica_personal : DevExpress.XtraEditors.XtraForm
    {
        public frm_estadistica_personal()
        {
            InitializeComponent();
        }

        
        CapaDatosPersonas CapaDatos = new CapaDatosPersonas();
        // -------------------------------------AREA DE VARIABLES

        string var_id_usuario = ""; // id de usuario para consultar en la base de datos, tomado del combobox
        // variables para determinar fecha y dia
        DateTime fecha_hoy = DateTime.Today; // fecha hoy
        DateTime fecha_fin_semana; // variable usada para calcular los valores de la semana anterior

        Calendar calendario = CultureInfo.InvariantCulture.Calendar;
        string nombre = ""; // nombre del dia de la semana
        DateTime fecha_inicio; // usada para determinar el inicio del rango de fechas


        // ------------------------ Variables para cuantificar las tareas
        string tipo_tarea="";
        int num_almuerzo = 0;
        int num_tarea = 0;
        int num_llamada = 0;
        int num_reunion = 0;
        int num_plazo = 0;
        int cont;

        // --------------------------------------------------------------------------------------------------


        private void frm_estadistica_personal_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            pcb_foto.Image = Image.FromFile("andre.jpg");

            // carga de combobox de usuarios de la empresa
            DataTable empleados = new DataTable();
            empleados = CapaDatos.cargar_empleados();
            cmb_usuarios.DataSource = empleados;
            cmb_usuarios.DisplayMember = "nombres";
            cmb_usuarios.ValueMember = "id_empleado";
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_NuevoCaso caso = new frm_NuevoCaso();
            caso.Show();
        }


        // combobox de usuarios
        private void cmb_usuarios_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                var_id_usuario = cmb_usuarios.SelectedValue.ToString();
              
                if (cmb_usuarios.SelectedValue.ToString() == "System.Data.DataRowView" || cmb_usuarios.Text=="")
                {
                    pcb_foto.Image = Image.FromFile("andre.jpg");

                }

                else
                {

                    DataTable datos_usuario = new DataTable();
                    datos_usuario = CapaDatos.consultar_empleado_especifico(var_id_usuario);
                    DataRow fila = datos_usuario.Rows[0];
                    lbl_nombres.Text = fila["nombres"].ToString();
                    lbl_apellidos.Text = fila["apellidos"].ToString();
                    lbl_email.Text = fila["correo"].ToString();
                    pcb_foto.ImageLocation = fila["foto"].ToString();



                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            //DataRow casilla = datos_usuario.Rows[];
            
        }


        // boton para generar todos los resultados estadisticos generados el dia de hoy
        private void btn_hoy_Click(object sender, EventArgs e)
        {

            //MessageBox.Show(fecha_hoy.ToString("yyyy-MM-dd"));
            nombre = calendario.GetDayOfWeek(fecha_hoy).ToString();

            MessageBox.Show("Hoy es: " + nombre + " con fecha: " + fecha_hoy.ToString("yyyy-MM-dd"));
        }


        // Boton para generar todos los registros de ayer
        private void btn_ayer_Click(object sender, EventArgs e)
        {
            DateTime fecha_ayer = fecha_hoy.AddDays(-1);
            nombre = calendario.GetDayOfWeek(fecha_ayer).ToString();
            //MessageBox.Show(fecha_ayer.ToString("yyyy-MM-dd"),nombre);
            MessageBox.Show("Ayer fue: " + nombre + " con fecha: " + fecha_ayer.ToString("yyyy-MM-dd"));


        }


        // Boton para genear todos los registros de esta semana
        private void btn_eshta_semana_Click(object sender, EventArgs e)
        {
            nombre = calendario.GetDayOfWeek(fecha_hoy).ToString();
            string nombre_inicio = "";
            //DateTime fecha_inicio;

            switch (nombre)
            {

                case "Monday":
                    fecha_inicio = fecha_hoy.AddDays(0);
                    
                    break;

                case "Tuesday":
                    fecha_inicio = fecha_hoy.AddDays(-1);
                    break;

                case "Wednesday":
                    fecha_inicio = fecha_hoy.AddDays(-2);
                    break;

                case "Thursday":
                    fecha_inicio = fecha_hoy.AddDays(-3);
                    break;

                case "Friday":
                    fecha_inicio = fecha_hoy.AddDays(-4);
                    break;

                case "Saturday":
                    fecha_inicio = fecha_hoy.AddDays(-5);
                    break;

                case "Sunday":
                    fecha_inicio = fecha_hoy.AddDays(-6);
                    break;
                    

            }
            nombre_inicio = calendario.GetDayOfWeek(fecha_inicio).ToString();
            MessageBox.Show("Toma de inicio de datos: " + nombre_inicio + ", " + fecha_inicio.ToString("yyyy-MM-dd") + " al " + nombre + ", " + fecha_hoy.ToString("yyyy-MM-dd"));


            // -------------------- Envio de datos a clase capadatos
            DataTable negocios =  CapaDatos.consultar_negocios(var_id_usuario,fecha_inicio.ToString("yyyy-MM-dd"),fecha_hoy.ToString("yyyy-MM-dd"));
            dgv_prueba.DataSource = negocios;
            //string tipo_tarea =  columna["tipo"].ToString();
            //MessageBox.Show(tipo_tarea);
            //int cont;
            foreach (DataRow columna in negocios.Rows)
            {
                
                if (columna["tipo"].ToString()=="Almuerzo")
                {
                    cont = cont + 1;
                }
            }
            lbl_cant_almuerzo1.Text = cont.ToString();
            lbl_cant_almuerzo2.Text = cont.ToString();
        }


        // boton para seleccionar los datos de la semana pasada
        private void btn_semana_pasada_Click(object sender, EventArgs e)
        {
            //DateTime fecha_inicio_mes = new DateTime(DateTime.Now.Year, DateTime.Now.Month,DateTime.Now.Day);
            //MessageBox.Show(fecha_inicio_mes.ToString("yyyy-MM-dd"));
            nombre = calendario.GetDayOfWeek(fecha_hoy).ToString();
            string nombre_inicio = "";
            //DateTime fecha_inicio;

            switch (nombre)
            {

                case "Monday":
                    fecha_inicio = fecha_hoy.AddDays(-7);
                    fecha_fin_semana = fecha_hoy.AddDays(-1);

                    break;

                case "Tuesday":
                    fecha_inicio = fecha_hoy.AddDays(-8);
                    fecha_fin_semana = fecha_hoy.AddDays(-2);

                    break;

                case "Wednesday":
                    fecha_inicio = fecha_hoy.AddDays(-9);
                    fecha_fin_semana = fecha_hoy.AddDays(-3);

                    break;

                case "Thursday":
                    fecha_inicio = fecha_hoy.AddDays(-10);
                    fecha_fin_semana = fecha_hoy.AddDays(-4);

                    break;

                case "Friday":
                    fecha_inicio = fecha_hoy.AddDays(-11);
                    fecha_fin_semana = fecha_hoy.AddDays(-5);

                    break;

                case "Saturday":
                    fecha_inicio = fecha_hoy.AddDays(-12);
                    fecha_fin_semana = fecha_hoy.AddDays(-6);

                    break;

                case "Sunday":
                    fecha_inicio = fecha_hoy.AddDays(-13);
                    fecha_fin_semana = fecha_hoy.AddDays(-7);

                    break;


            }
            nombre_inicio = calendario.GetDayOfWeek(fecha_inicio).ToString();
            MessageBox.Show("Toma de inicio de datos: " + nombre_inicio + ", " + fecha_inicio.ToString("yyyy-MM-dd") + " al " + "Domingo" + ", " + fecha_fin_semana.ToString("yyyy-MM-dd"));
        }


        // boton para seleccionar los datos de este mes
               
        private void btn_mensual_Click(object sender, EventArgs e)
        {
            
            DateTime fecha_inicio_mes = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            string nombre_inicio_mes = calendario.GetDayOfWeek(fecha_inicio_mes).ToString(); ;
            MessageBox.Show("Toma de inicio de datos: " + nombre_inicio_mes + ", " + fecha_inicio_mes.ToString("yyyy-MM-dd") + " al " + nombre + ", " + fecha_hoy.ToString("yyyy-MM-dd"));
        }

        // boton para seleccionar los datos del mes anterior
        private void btn_mes_pasado_Click(object sender, EventArgs e)
        {
            DateTime fecha_referencia = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1); // fecha de inicio de este mes
            DateTime fecha_inicio_mes = fecha_referencia.AddMonths(-1); // fecha de inicio del mes anterior
            DateTime fecha_fin_mes = fecha_inicio_mes.AddMonths(1).AddDays(-1); // fecha de fin de mes anterior
            MessageBox.Show("inicio: "+fecha_inicio_mes.ToString("yyy-MM-dd")+" fin: "+fecha_fin_mes.ToString("yyy-MM-dd"));

        }
    }
}