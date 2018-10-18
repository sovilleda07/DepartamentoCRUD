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
    public partial class FrmActualizarDepartamentos : Form
    {
        public FrmActualizarDepartamentos()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Se encarga de actualizar los datos de un departamento existente por medio de un StoredProcedure
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtCodigoDepto.Text == "")
            {
                MessageBox.Show("Ingrese el Codigo del Departamento a Modificar", "Detalles de Excepción");
            }
            else
            {
                // Creamos la conexión
                SqlConnection conn = new SqlConnection(@"server = (local);
                            integrated security = true; database = AdventureWorks2014");

                // Creamos el comando para el StoredProcedure
                SqlCommand cmd = new SqlCommand("sp_ActualizarDepartamento", conn);

                // Indicamos el tipo de comando 
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    // Definir los parametros y sus valores para el StoredProcedure
                    cmd.Parameters.Add(new SqlParameter("@Codigo", SqlDbType.SmallInt, 10));
                    cmd.Parameters["@Codigo"].Value = txtCodigoDepto.Text;

                    cmd.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.NVarChar, 50));
                    cmd.Parameters["@Nombre"].Value = txtNombreDepto.Text;

                    cmd.Parameters.Add(new SqlParameter("@Descripcion", SqlDbType.NVarChar, 50));
                    cmd.Parameters["@Descripcion"].Value = txtDescripcion.Text;

                    cmd.Parameters.Add(new SqlParameter("@FechaModificacion", SqlDbType.DateTime));
                    cmd.Parameters["@FechaModificacion"].Value = dtpFechaMod.Value;

                    // Abrir la conexion
                    conn.Open();

                    // Ejecutar el query
                    cmd.ExecuteNonQuery();

                    // Mensaje de Confirmación de Actualización de Depto
                    MessageBox.Show("Departamento Actualizado Exitosamente", "Actualizar Departamento");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace, "Detales en la Excepcion");
                }
                finally
                {
                    conn.Close();

                    // Limpiar el formulario
                    txtCodigoDepto.Text = "";
                    txtNombreDepto.Text = "";
                    txtDescripcion.Text = "";
                }
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
