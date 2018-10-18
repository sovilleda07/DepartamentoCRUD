using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace frmPrincipal
{
    public partial class FrmEliminarDepartamento : Form
    {
        // Creamos la conexion
        SqlConnection conn = new SqlConnection(@"server = (local);
                    integrated security = true; database = AdventureWorks2014");
        

        public FrmEliminarDepartamento()
        {
            InitializeComponent();
        }

        private void FrmEliminarDepartamento_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Se encarga de listar los departamentos por medio del evento de click en el boton de listar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnListar_Click(object sender, EventArgs e)
        {
            // Hacer el query
            string sqlSelect = @"SELECT DepartmentID, Name 
                                    FROM HumanResources.Department";
            // Se crea el comando
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);

            try
            {
                // Abrir conexion
                conn.Open();

                // Ejecutamos el query
                SqlDataReader rdr = cmd.ExecuteReader();

                // Mientras lea los campos, se va a ir llenado la lista
                while (rdr.Read())
                {
                    lstbCargarDeptos.Items.Add(rdr[0]);
                    lstbCargarDeptos.Items.Add(rdr[1]);
                }

            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace, "Detalles en excepcion");
            }
            finally
            {
                // Cerramos la conexion 
                conn.Close();
            }




        }

        /// <summary>
        /// Se encarga de la eliminación de un Departamente por medio de un Stored Procedure
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Crear el comando que va a llamar al Stored Procedure
            SqlCommand cmd = new SqlCommand("sp_EliminarDepartamento", conn);

            // Establecer el comando como un Stored Procedure
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                // Parámetro del Stored Procedure
                cmd.Parameters.Add(new SqlParameter("@Codigo", SqlDbType.SmallInt, 50));
                cmd.Parameters["@Codigo"].Value = lstbCargarDeptos.SelectedItems[0];

                // Establecer la conexión
                conn.Open();

                // Eliminación del depto
                if (lstbCargarDeptos.SelectedIndex == -1)
                {
                    MessageBox.Show("Favor seleccionar un depto. antes de ejecutar la acción de eliminar", "Información");
                }
                else
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Departamento Eliminado Exitosamente", "Información");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "Detalles de la excepción");
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Recarge el valor del listado de departamentos" + ex.StackTrace, "Detalles de la excepción");
            }
            finally
            {
                // Cerrar la conexión
                conn.Close();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
