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
    public partial class FrmServicios : Form
    {
        public int ServicioID { get; private set; }
        public bool IsEditMode { get; private set; }

        public FrmServicios()
        {
            InitializeComponent();
            IsEditMode = false;
            CargarVehiculos();
        }

        public FrmServicios(int servicioID)
        {
            InitializeComponent();
            ServicioID = servicioID;
            IsEditMode = true;
            CargarVehiculos();
            CargarDatosServicio();
        }

        private void CargarVehiculos()
        {
            string connectionString = "Server=localhost;Database=examen;Trusted_Connection=True;";
            string query = "SELECT VehiculoID, Marca + ' ' + Modelo AS Vehiculo FROM Vehiculos";

            try
            {
                comboBoxVehiculoID.Items.Clear();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                comboBoxVehiculoID.Items.Add(new { Id = reader["VehiculoID"], Name = reader["Vehiculo"] });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los vehículos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarDatosServicio()
        {
            string connectionString = "Server=localhost;Database=examen;Trusted_Connection=True;";
            string query = "SELECT VehiculoID, Descripcion, Costo FROM Servicios WHERE ServicioID = @ServicioID";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ServicioID", ServicioID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                comboBoxVehiculoID.SelectedValue = reader["VehiculoID"];
                                textBoxDescripcion.Text = reader["Descripcion"].ToString();
                                numericUpDownCosto.Value = Convert.ToDecimal(reader["Costo"]);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos del servicio: " + ex.Message);
            }
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=examen;Trusted_Connection=True;";
            string query = IsEditMode
                ? "UPDATE Servicios SET VehiculoID = @VehiculoID, Descripcion = @Descripcion, Costo = @Costo WHERE ServicioID = @ServicioID"
                : "INSERT INTO Servicios (VehiculoID, Descripcion, Costo) VALUES (@VehiculoID, @Descripcion, @Costo)";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@VehiculoID", ((dynamic)comboBoxVehiculoID.SelectedItem).Id);
                        command.Parameters.AddWithValue("@Descripcion", textBoxDescripcion.Text);
                        command.Parameters.AddWithValue("@Costo", numericUpDownCosto.Value);

                        if (IsEditMode)
                            command.Parameters.AddWithValue("@ServicioID", ServicioID);

                        command.ExecuteNonQuery();
                        MessageBox.Show(IsEditMode ? "Servicio actualizado correctamente." : "Servicio registrado correctamente.");
                        Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el servicio: " + ex.Message);
            }
        }
    }
}
