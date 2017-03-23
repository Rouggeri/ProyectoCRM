using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using seguridad;

namespace crm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        FormActividadesCalendario cal = new FormActividadesCalendario();
        FormContactos con = new FormContactos();
        FormNegociaciones neg = new FormNegociaciones();
        frm_estadistica_empresa em = new frm_estadistica_empresa();
        frm_estadistica_personal per = new frm_estadistica_personal();
        frm_pronostico pro = new frm_pronostico();
        frm_cliente cliente_form = new frm_cliente();
        frm_empresa emp = new frm_empresa();
        Form_inicio ini = new Form_inicio();
        frm_NuevoEmpleado empleado_form = new frm_NuevoEmpleado();
        Form_Casos caso = new Form_Casos();
        Historial bitacora = new Historial();
        agregarapp ap = new agregarapp();
        Modificar_aplicacion modap = new Modificar_aplicacion();
        FormAsignarPermisosUsuario crearu = new FormAsignarPermisosUsuario();
        Form_EditarPrivilegios edi = new Form_EditarPrivilegios();
        FormDeshabilitarUsuario desh = new FormDeshabilitarUsuario();
        FormAsignacionPerfil asper = new FormAsignacionPerfil();
        Form_EditarPerfil edper = new Form_EditarPerfil();
        FormEliminarPerfil elper = new FormEliminarPerfil();
        CambioPass camb = new CambioPass();
 
        private void LimpiarMDI()
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
        }

        private void ClearAllMDIs()
        {
            foreach (Form f in this.MdiChildren)
            {
                f.Close();
               // f.Dispose();
            }
        }

        private void otroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void caToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // conexion odbc
            //try
            //{
            //    seguridad.Conexion.DSN = "crm";
            //    seguridad.Conexion.PassWord = "1234";
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);

            //}




            cal = null;
            con = null;
            neg = null;
            em = null;
            per = null;
            pro = null;
            cliente_form = null;
            emp = null;
            ini = null;
            empleado_form = null;
            caso = null;
            bitacora = null;
            ap = null;
            modap = null;
            crearu = null;
            edi = null;
            desh = null;
            asper = null;
            edper = null;
            elper = null;
            camb = null;


            if (ini == null)
            {
                ini = new Form_inicio();
                ini.MdiParent = this;

                ini.FormClosed += new FormClosedEventHandler(frm_inicio_FormClosed);
                ini.Show();
            }
        }

        private void actividadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // ClearAllMDIs();
            LimpiarMDI();
            if (cal == null)
            {
                cal = new FormActividadesCalendario();
                cal.MdiParent = this;

                cal.FormClosed += new FormClosedEventHandler(FormActividadesCalendario_FormClosed);
                cal.Show();
            }
        }

      

        private void FormActividadesCalendario_FormClosed(object sender, FormClosedEventArgs e)
        {
            cal = null;
        }

        private void contactoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // ClearAllMDIs();
            LimpiarMDI();
            if (con == null)
            {
                con = new FormContactos();
                con.MdiParent = this;

                con.FormClosed += new FormClosedEventHandler(FormCotactos_FormClosed);
                con.Show();
            }

        }

        private void FormCotactos_FormClosed(object sender, FormClosedEventArgs e)
        {
            con = null;
        }


        private void gToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ClearAllMDIs();
             LimpiarMDI();
            if (neg == null)
            {
                neg = new FormNegociaciones();
                neg.MdiParent = this;

                neg.FormClosed += new FormClosedEventHandler(FormNegociaciones_FormClosed);
                neg.Show();
            }
        }

        private void FormNegociaciones_FormClosed(object sender, FormClosedEventArgs e)
        {
            neg = null;
        }

        private void personalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ClearAllMDIs();
            LimpiarMDI();
            if (em == null)
            {
                em = new frm_estadistica_empresa();
                em.MdiParent = this;

                em.FormClosed += new FormClosedEventHandler(frm_estadistica_empresa_FormClosed);
                em.Show();
            }
        }

        private void frm_estadistica_empresa_FormClosed(object sender, FormClosedEventArgs e)
        {
            em = null;
        }

        private void personalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //ClearAllMDIs();
            LimpiarMDI();
            if (per == null)
            {
                per = new frm_estadistica_personal();
                per.MdiParent = this;

                per.FormClosed += new FormClosedEventHandler(frm_estadistica_personal_FormClosed);
                per.Show();
            }
        }

        private void frm_estadistica_personal_FormClosed(object sender, FormClosedEventArgs e)
        {
            per = null;
        }

        private void proyeccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ClearAllMDIs();
            LimpiarMDI();
            if (pro == null)
            {
                pro = new frm_pronostico();
                pro.MdiParent = this;

                pro.FormClosed += new FormClosedEventHandler(frm_pronostico_FormClosed);
                pro.Show();
            }
        }

        private void frm_pronostico_FormClosed(object sender, FormClosedEventArgs e)
        {
            pro = null;
        }


       


        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LimpiarMDI();
            if (cliente_form == null)
            {
                cliente_form = new frm_cliente();
                cliente_form.MdiParent = this;

                cliente_form.FormClosed += new FormClosedEventHandler(frm_cliente_FormClosed);
                cliente_form.Show();
            }

        }
        private void frm_cliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            cliente_form = null;
        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // LimpiarMDI();
            if (emp == null)
            {
                emp = new frm_empresa();
                emp.MdiParent = this;

                emp.FormClosed += new FormClosedEventHandler(frm_empresa_FormClosed);
                emp.Show();
            }
        }

        private void frm_empresa_FormClosed(object sender, FormClosedEventArgs e)
        {
            emp = null;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // LimpiarMDI();
            if (ini == null)
            {
                ini = new Form_inicio();
                ini.MdiParent = this;

                ini.FormClosed += new FormClosedEventHandler(frm_inicio_FormClosed);
                ini.Show();
            }
        }

        private void frm_inicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            ini = null;
        }


        // Pestaña de Empleados
        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (empleado_form == null)
            {
                empleado_form = new frm_NuevoEmpleado();
                empleado_form.MdiParent = this;

                empleado_form.FormClosed += new FormClosedEventHandler(frm_NuevoEmpleado_FormClosed);
                empleado_form.Show();
            }
        }
        private void frm_NuevoEmpleado_FormClosed(object sender, FormClosedEventArgs e)
        {
            empleado_form = null;
        }

        private void casosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LimpiarMDI();
            if (caso == null)
            {
                caso = new Form_Casos();
                caso.MdiParent = this;

                caso.FormClosed += new FormClosedEventHandler(Form_Casos_FormClosed);
                caso.Show();
            }
        }

        private void Form_Casos_FormClosed(object sender, FormClosedEventArgs e)
        {
            caso = null;
        }

        private void bitacoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //LimpiarMDI();
            if (bitacora == null)
            {
                bitacora = new Historial();
                bitacora.MdiParent = this;

                bitacora.FormClosed += new FormClosedEventHandler(Historial_FormClosed);
                bitacora.Show();
            }
        }

        private void Historial_FormClosed(object sender, FormClosedEventArgs e)
        {
            bitacora = null;
        }

        private void agregarAplicaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ap == null)
            {
                ap = new agregarapp();
                ap.MdiParent = this;

                ap.FormClosed += new FormClosedEventHandler(agregarap_FormClosed);
                ap.Show();
            }
        }

        private void agregarap_FormClosed(object sender, FormClosedEventArgs e)
        {
            ap = null;
        }

        private void modificarAplicaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (modap == null)
            {
                modap = new Modificar_aplicacion();
                modap.MdiParent = this;
                modap.FormClosed += new FormClosedEventHandler(ModificarAplicacion_FormClosed);
                modap.Show();
            }
        }

        private void ModificarAplicacion_FormClosed(object sender, FormClosedEventArgs e)
        {
            modap = null;
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (crearu == null)
            {
                crearu = new FormAsignarPermisosUsuario();
                crearu.MdiParent = this;

                crearu.FormClosed += new FormClosedEventHandler(FormAsignarPermisosUsuario_FormClosed);
                crearu.Show();
            }
        }

        private void FormAsignarPermisosUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            crearu = null;
        }

        private void editarPermisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (edi == null)
            {
                edi = new Form_EditarPrivilegios();
                edi.MdiParent = this;

                edi.FormClosed += new FormClosedEventHandler(FormEditarPrivilegios_FormClosed);
                edi.Show();
            }
        }

        private void FormEditarPrivilegios_FormClosed(object sender, FormClosedEventArgs e)
        {
            edi = null;
        }

        private void deshabilitarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (desh == null)
            {
                desh = new FormDeshabilitarUsuario();
                desh.MdiParent = this;
                desh.FormClosed += new FormClosedEventHandler(FormDeshabilitarUsuario_FormClosed);
                desh.Show();
            }
        }

        private void FormDeshabilitarUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            desh = null;
        }

        private void crearPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (asper == null)
            {
                asper = new FormAsignacionPerfil();
                asper.MdiParent = this;
                asper.FormClosed += new FormClosedEventHandler(FormAsignacionPerfil_FormClosed);
                asper.Show();
            }
        }

        private void FormAsignacionPerfil_FormClosed(object sender, FormClosedEventArgs e)
        {
            asper = null;
        }

        private void editarPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (edper == null)
            {
                edper = new Form_EditarPerfil();
                edper.MdiParent = this;
                edper.FormClosed += new FormClosedEventHandler(Form_EditarPerfil_FormClosed);
                edper.Show();
            }
        }

        private void Form_EditarPerfil_FormClosed(object sender, FormClosedEventArgs e)
        {
            edper = null;
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (elper == null)
            {
                elper = new FormEliminarPerfil();
                elper.MdiParent = this;
                elper.FormClosed += new FormClosedEventHandler(FormEliminarPerfil_FormClosed);
                elper.Show();
            }
        }

        private void FormEliminarPerfil_FormClosed(object sender, FormClosedEventArgs e)
        {
            elper = null;
        }

        private void gToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (camb == null)
            {
                camb = new CambioPass();
                camb.MdiParent = this;
                camb.FormClosed += new FormClosedEventHandler(CambioPass_FormClosed);
                camb.Show();
            }
        }

        private void CambioPass_FormClosed(object sender, FormClosedEventArgs e)
        {
            camb = null;
        }

        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            f.Show();
            this.Close();
        }
    }
}
