using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenParcial1.Formularios
{
    public partial class ControlClientes : UserControl
    {
        private void CargarClientes()
        {
            string connectionString = "Server=localhost;Database=examen;Trusted_Connection=True;";
            string query = "SELECT ClienteID, Nombre, Apellido, Telefono, Email, Direccion FROM Clientes";

            try
            {
                listBoxClientes.Items.Clear();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string clienteInfo = $"{reader["ClienteID"]}: {reader["Nombre"]} {reader["Apellido"]} | {reader["Telefono"]} | {reader["Email"]} | {reader["Direccion"]}";
                                listBoxClientes.Items.Add(clienteInfo);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la lista de clientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //debug
            }
        }

        public ControlClientes()
        {
            InitializeComponent();
            CargarClientes();
        }

        private void buttonAñadir_Click(object sender, EventArgs e)
        {
            FrmClientes frmClientes = new FrmClientes();
            frmClientes.ShowDialog();
            CargarClientes();
        }


        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (listBoxClientes.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un cliente para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string clienteSeleccionado = listBoxClientes.SelectedItem.ToString();
            int clienteID = int.Parse(clienteSeleccionado.Split(':')[0]);

            FrmClientes frmClientes = new FrmClientes(clienteID);
            frmClientes.ShowDialog();

            CargarClientes();
        }


        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (listBoxClientes.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona un cliente para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string clienteSeleccionado = listBoxClientes.SelectedItem.ToString();
                int clienteID = int.Parse(clienteSeleccionado.Split(':')[0]);
                string connectionString = "Server=localhost;Database=examen;Trusted_Connection=True;";
                string query = "DELETE FROM Clientes WHERE ClienteID = @ClienteID";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ClienteID", clienteID);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cliente eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarClientes(); //rld
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el cliente para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
