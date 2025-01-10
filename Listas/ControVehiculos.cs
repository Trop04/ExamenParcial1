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
using ExamenParcial1.Formularios;

namespace ExamenParcial1.Listas
{
    public partial class ControVehiculos : UserControl
    {
        private void CargarVehiculos()
        {
            string connectionString = "Server=localhost;Database=examen;Trusted_Connection=True;";
            string query = @"
                SELECT V.VehiculoID, C.Nombre + ' ' + C.Apellido AS Cliente, 
                       V.Marca, V.Modelo, V.Anio, V.Placa
                FROM Vehiculos V
                INNER JOIN Clientes C ON V.ClienteID = C.ClienteID";

            try
            {
                listBoxVehiculos.Items.Clear();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string vehiculoInfo = $"{reader["VehiculoID"]}: {reader["Cliente"]} | {reader["Marca"]} {reader["Modelo"]} ({reader["Anio"]}) | Placa: {reader["Placa"]}";
                                listBoxVehiculos.Items.Add(vehiculoInfo);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la lista de vehículos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public ControVehiculos()
        {
            InitializeComponent();
            CargarVehiculos();
        }

        private void buttonAñadir_Click(object sender, EventArgs e)
        {
            FrmVehiculos frmVehiculos = new FrmVehiculos();
            frmVehiculos.ShowDialog();
            CargarVehiculos();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (listBoxVehiculos.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un vehículo para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string vehiculoSeleccionado = listBoxVehiculos.SelectedItem.ToString();
            int vehiculoID = int.Parse(vehiculoSeleccionado.Split(':')[0]);

            FrmVehiculos frmVehiculos = new FrmVehiculos(vehiculoID);
            frmVehiculos.ShowDialog();
            CargarVehiculos();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (listBoxVehiculos.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un vehículo para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string vehiculoSeleccionado = listBoxVehiculos.SelectedItem.ToString();
                int vehiculoID = int.Parse(vehiculoSeleccionado.Split(':')[0]);

                string connectionString = "Server=localhost;Database=examen;Trusted_Connection=True;";
                string query = "DELETE FROM Vehiculos WHERE VehiculoID = @VehiculoID";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@VehiculoID", vehiculoID);
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Vehículo eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarVehiculos();
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el vehículo para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el vehículo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}