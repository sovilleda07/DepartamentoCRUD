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
    public partial class FrmCrearDepartamento : Form
    {
        public FrmCrearDepartamento()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Se encarga de guardar un nuevo departamento por medio de un StoredProcedure
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Creamos la conexion
            SqlConnection conn = new SqlConnection(@"server = (local);
                            integrated security = true; database = AdventureWorks2014");

            // Creamos el comando para el StoredProcedure
            SqlCommand cmd = new SqlCommand("sp_CrearDepartamento", conn);

            // Especificamos el tipo de comando que es un StoredProcedure
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                // Verificar si los campos estna vacíos
                if (txtNombreDepto.Text == "" || txtDescripcion.Text == "")
                {
                    MessageBox.Show("Llene los campos", "Detalles de excepcion");
                }
                else
                {
                    // Definir los parametros y sus valores para el StoredProcedure
                    cmd.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.NVarChar, 50));
                    cmd.Parameters["@Nombre"].Value = txtNombreDepto.Text;

                    cmd.Parameters.Add(new SqlParameter("@Descripcion", SqlDbType.NVarChar, 50));
                    cmd.Parameters["@Descripcion"].Value = txtDescripcion.Text;

                    cmd.Parameters.Add(new SqlParameter("@FechaModificacion", SqlDbType.DateTime));
                    cmd.Parameters["@FechaModificacion"].Value = dtpFechaMod.Value;

                    // Abrir la conexión
                    conn.Open();

                    // Ejecutar el query
                    cmd.ExecuteNonQuery();

                    // Mensaje de Confirmación de Creacion de Depto
                    MessageBox.Show("Departamento Creado Exitosamente", "Crear Departamento");

                }                

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "Detalles de la excepción");
            }
            finally
            {
                // Cerramos la conexión
                conn.Close();

                // Limpiar formulario
                txtNombreDepto.Text = "";
                txtDescripcion.Text = "";
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
