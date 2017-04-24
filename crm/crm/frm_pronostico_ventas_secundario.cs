using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace crm
{
    public partial class frm_pronostico_ventas_secundario : Form
    {
        public frm_pronostico_ventas_secundario()
        {
            InitializeComponent();
        }
        // Llamada a la capaDeDatos 
        CapaDatosPersonas capadatos = new CapaDatosPersonas();

        // Datatables:
        DataTable dt_cat_negos = new DataTable(); // dt que sirve para cargar las categorias de negocios
        DataTable dt_negos_finalizados = new DataTable(); //dt que sirve para almacenar los negocios en estado finalizado
        DataTable dt_nego_ganado_hijo = new DataTable(); // dt que almacenara la matriz de la grafica

        // Variables Globales
        string id_nego_venta = ""; // variable para almacenar el id de la categoria del negocio o venta
        string uno = "1";
        string dos = "2";
        string tres = "3";
        int contador_negos_este_mes = 0; // contador para determinar la cantidad de ventas "Y"
        int contador_negos_ant_mes = 0; // contador para determinar la cantidad de ventas "Y"
        int contador_negos_2ant_mes = 0; // contador para determinar la cantidad de ventas "Y"
        // Variables de tiempo
        DateTime hoy = DateTime.Today;  // Fecha de hoy
        DateTime fecha_inicio_mes = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
        // Fecha de inicio de mes


        // Clasificacion es para Negocios o Ventas de productos
        // Categoria es para subcategoria de negocios o subcategoria de productos


        // Radio button para seleccionar negocios O ventas en especifico
        private void rbt_seleccionar_clasificacion_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_seleccionar_clasificacion.Checked)
            {
                cmb_clasificacion.Enabled = true;
                rbt_seleccionar_categoria.Enabled = true;
            }
            
        }

        // Radio button para seleccionar negocios Y ventas en especifico
        private void rbt_todos_clasificacion_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_todos_clasificacion.Checked)
            {
                cmb_clasificacion.Enabled = false;
                cmb_categoria.Enabled = false;
                cmb_clasificacion.Text = "";

                rbt_todos_categoria.Checked = true;
                rbt_seleccionar_categoria.Enabled = false;

                dt_cat_negos.Clear();

            }
            
        }
        // Radio button para seleccionar un producto o servicio en especifico
        private void rbt_seleccionar_categoria_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_seleccionar_categoria.Enabled)
            {
                cmb_categoria.Enabled = true;
            }
        }

        // Radio button para seleccionar un producto Y servicios
        private void rbt_todos_categoria_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_todos_categoria.Enabled)
            {
                cmb_categoria.Enabled = false;
            }
        }



        // ComboBox, sirve para llamar a las categorias
        private void cmb_clasificacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_clasificacion.SelectedItem.ToString() == "Negocios")
            {
                dt_cat_negos =  capadatos.seleccionar_cat_negos();
                cmb_categoria.DataSource = dt_cat_negos;
                cmb_categoria.ValueMember = "id_cat";
                cmb_categoria.DisplayMember = "nombre_cat";
                
            }

        }

        // ComboBox, para subcategorias
        private void cmb_categoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            id_nego_venta = cmb_categoria.SelectedValue.ToString(); // id de la categoria que va a ser enviada al dt para almacenar negocios por fecha
            MessageBox.Show(id_nego_venta);

            if (cmb_clasificacion.SelectedItem.ToString() == "")
            {

            }
            else if (cmb_clasificacion.SelectedItem.ToString() == "Negocios")
            {
                dt_negos_finalizados = capadatos.seleccionar_negos_historial(id_nego_venta);
                dgv_consulta_negos_ventas.DataSource = dt_negos_finalizados;

                
            }
        }


        // Boton para generar todos los calculos de la proyección
        private void btn_pronosticar_Click(object sender, EventArgs e)
        {
            DataRow columna1 = dt_nego_ganado_hijo.NewRow(); // llamada a columna de dt de dt creado hijo de negos ganados
            DataRow columna = dt_nego_ganado_hijo.NewRow(); // llamada a columna de dt de dt creado hijo de negos ganados
            DataRow columna3 = dt_nego_ganado_hijo.NewRow(); // llamada a columna de dt de dt creado hijo de negos ganados

            DataRow columna_x2 = dt_nego_ganado_hijo.NewRow(); // columna x2, 1,3


            DateTime fecha_inicio_mes_ant = fecha_inicio_mes.AddMonths(-1); // fecha de inicio del mes anterior
            DateTime fecha_fin_mes = fecha_inicio_mes_ant.AddMonths(1).AddDays(-1); // fecha de fin de mes anterior

            DateTime fecha_inicio_2mes_ant = fecha_inicio_mes.AddMonths(-2); // fecha de inicio de 2 meses anteriores
            DateTime fecha_fin_2mes = fecha_inicio_2mes_ant.AddMonths(1).AddDays(-1); // fecha de fin de 2 meses anteriores

            //MessageBox.Show("mes pasado inicio: " + fecha_inicio_mes_ant.ToString() + " fin: " + fecha_fin_mes.ToString());
            //MessageBox.Show(" 2 meses anteriores inicio: " + fecha_inicio_2mes_ant.ToString() + " fin: " + fecha_fin_2mes.ToString());



            foreach (DataRow row in dt_negos_finalizados.Rows) // foreach que va a recorrer todo el dt_negos_finalizados para ir clasificando por meses y creando el nuevo datatable
            {
                if (Convert.ToDateTime(row["fecha_est_cierre"].ToString()) >= Convert.ToDateTime(fecha_inicio_2mes_ant.ToString()) && Convert.ToDateTime(row["fecha_est_cierre"].ToString()) <= Convert.ToDateTime(fecha_fin_2mes.ToString()))
                {
                    contador_negos_2ant_mes = contador_negos_2ant_mes + 1;

                    foreach (DataRow row_hijo in dt_nego_ganado_hijo.Rows)
                    {

                        //columna_x2["x2"] = Convert.ToDouble( columna_x2["x"].ToString()) * Convert.ToDouble( columna_x2["x"].ToString());
                        //columna_x2["x2"] = columna_x2["x"].ToString() + columna_x2["x"].ToString();
                        columna_x2["x2"] = row_hijo["x"].ToString() + row_hijo["x"].ToString();

                        dt_nego_ganado_hijo.Rows.Add(columna_x2);
                        //dgv_tabla_result.DataSource = dt_nego_ganado_hijo;

                        MessageBox.Show("1");
                    }


                }

                else if (Convert.ToDateTime(row["fecha_est_cierre"].ToString()) >= Convert.ToDateTime(fecha_inicio_mes_ant.ToString()) && Convert.ToDateTime(row["fecha_est_cierre"].ToString()) <= Convert.ToDateTime(fecha_fin_mes.ToString()))
                {
                    contador_negos_ant_mes = contador_negos_ant_mes + 1;


                }


                else if (Convert.ToDateTime( row["fecha_est_cierre"].ToString()) >= Convert.ToDateTime( fecha_inicio_mes.ToString()) && Convert.ToDateTime(row["fecha_est_cierre"].ToString()) <= Convert.ToDateTime(hoy.ToString()))
                {
                    contador_negos_este_mes =  contador_negos_este_mes + 1;

                    
                }
            }

            // relleno de la primera fila, mes ante-pasado
            columna1["x"] = uno;
            columna1["y"] = contador_negos_2ant_mes;
            dt_nego_ganado_hijo.Rows.Add(columna1);

            // relleno de la segunda fila, mes pasado
            columna["x"] = dos;
            columna["y"] = contador_negos_ant_mes;
            dt_nego_ganado_hijo.Rows.Add(columna);

            // relleno de la tercera fila, este mes
            columna3["x"] = tres;
            columna3["y"] = contador_negos_este_mes;
            dt_nego_ganado_hijo.Rows.Add(columna3);

            dgv_tabla_result.DataSource = dt_nego_ganado_hijo;


            //foreach (DataRow row_hijo in dt_nego_ganado_hijo.Rows)
            //{
            //    DataRow columna_x2 = dt_nego_ganado_hijo.NewRow(); // llamada a columna de dt de dt creado hijo de negos ganados

            //    //columna_x2["x2"] = Convert.ToDouble( columna_x2["x"].ToString()) * Convert.ToDouble( columna_x2["x"].ToString());
            //    //columna_x2["x2"] = columna_x2["x"].ToString() + columna_x2["x"].ToString();
            //    columna_x2["x2"] = row_hijo["x"].ToString() + row_hijo["x"].ToString();

            //    dt_nego_ganado_hijo.Rows.Add(columna_x2 );
            //    dgv_tabla_result.DataSource = dt_nego_ganado_hijo;

            //    MessageBox.Show("1");
            //}

            dgv_tabla_result.DataSource = dt_nego_ganado_hijo;

        }


        // LOAD DE PRONOSTICO VENTAS-NEGOCIOS
        private void frm_pronostico_ventas_secundario_Load(object sender, EventArgs e)
        {
            // creacion de nuevo datatable hijo de negocios ganados
            DataColumn column_nego_ganados = new DataColumn();
            column_nego_ganados.DataType = System.Type.GetType("System.String");
            column_nego_ganados.ColumnName = "nom_mes";
            dt_nego_ganado_hijo.Columns.Add(column_nego_ganados);

            column_nego_ganados = new DataColumn();
            column_nego_ganados.DataType = System.Type.GetType("System.String");
            column_nego_ganados.ColumnName = "x"; // num de mes
            dt_nego_ganado_hijo.Columns.Add(column_nego_ganados);


            column_nego_ganados = new DataColumn();
            column_nego_ganados.DataType = System.Type.GetType("System.String");
            column_nego_ganados.ColumnName = "y"; // cant de negocios ganados
            dt_nego_ganado_hijo.Columns.Add(column_nego_ganados);

            column_nego_ganados = new DataColumn();
            column_nego_ganados.DataType = System.Type.GetType("System.String");
            column_nego_ganados.ColumnName = "x2";
            dt_nego_ganado_hijo.Columns.Add(column_nego_ganados);

            column_nego_ganados = new DataColumn();
            column_nego_ganados.DataType = System.Type.GetType("System.String");
            column_nego_ganados.ColumnName = "y2";
            dt_nego_ganado_hijo.Columns.Add(column_nego_ganados);

            column_nego_ganados = new DataColumn();
            column_nego_ganados.DataType = System.Type.GetType("System.String");
            column_nego_ganados.ColumnName = "xy";
            dt_nego_ganado_hijo.Columns.Add(column_nego_ganados);
        }

        private void cmb_metodo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
