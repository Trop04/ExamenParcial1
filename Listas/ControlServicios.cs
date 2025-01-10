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
    public partial class ControlServicios : UserControl
    {
        private void CargarServicios()
        {
            string connectionString = "Server=localhost;Database=examen;Trusted_Connection=True;";
            string query = @"
                SELECT S.ServicioID, V.Marca + ' ' + V.Modelo AS Vehiculo, 
                       S.Descripcion, S.Costo
                FROM Servicios S
                INNER JOIN Vehiculos V ON S.VehiculoID = V.VehiculoID";

            try
            {
                listBoxServicios.Items.Clear();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string servicioInfo = $"{reader["ServicioID"]}: {reader["Vehiculo"]} | {reader["Descripcion"]} (${reader["Costo"]})";
                                listBoxServicios.Items.Add(servicioInfo);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la lista de servicios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public ControlServicios()
        {
            InitializeComponent();
            CargarServicios();
        }

        private void buttonAñadir_Click(object sender, EventArgs e)
        {
            FrmServicios frmServicios = new FrmServicios();
            frmServicios.ShowDialog();
            CargarServicios();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (listBoxServicios.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un servicio para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string servicioSeleccionado = listBoxServicios.SelectedItem.ToString();
            int servicioID = int.Parse(servicioSeleccionado.Split(':')[0]);

            FrmServicios frmServicios = new FrmServicios(servicioID);
            frmServicios.ShowDialog();
            CargarServicios();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (listBoxServicios.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un servicio para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string servicioSeleccionado = listBoxServicios.SelectedItem.ToString();
                int servicioID = int.Parse(servicioSeleccionado.Split(':')[0]);

                string connectionString = "Server=localhost;Database=examen;Trusted_Connection=True;";
                string query = "DELETE FROM Servicios WHERE ServicioID = @ServicioID";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ServicioID", servicioID);
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Servicio eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarServicios();
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el servicio para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el servicio: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}