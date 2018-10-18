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
    public partial class FrmListarDepartamentos : Form
    {
        public FrmListarDepartamentos()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Se encarga de listar, mostrar todos los datos que se encuentran en esta tabla en la BD
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmListarDepartamentos_Load(object sender, EventArgs e)
        {
            // Escribir la conexión
            string conn = @"server = (local); database = AdventureWorks2014;
                integrated security = true;";

            // Hacer el query
            string sql = @"SELECT *
                           FROM HumanResources.Department";


            // Crear la conexión
            SqlConnection connection = new SqlConnection(conn);

            try
            {
                // Establecer la conexión
                connection.Open();

                // Crear el DataAdapter
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);

                // Crear el DataSet
                DataSet ds = new DataSet();

                // Popular (llenar) el DataSet
                da.Fill(ds, "HumanResources.Department");

                dgvListarDepartamentos.DataSource = ds.Tables["HumanResources.Department"];
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "Detalles de la excepción");
            }
            finally
            {
                // Cerrar la conexión
                connection.Close();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
