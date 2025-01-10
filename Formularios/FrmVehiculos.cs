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
    public partial class FrmVehiculos : Form
    {
        public int VehiculoID { get; private set; }
        public bool IsEditMode { get; private set; }

        public FrmVehiculos()
        {
            InitializeComponent();
            IsEditMode = false;
            CargarClientes();
        }

        public FrmVehiculos(int vehiculoID)
        {
            InitializeComponent();
            VehiculoID = vehiculoID;
            IsEditMode = true;
            CargarClientes();
            CargarDatosVehiculo();
        }

        private void CargarClientes()
        {
            string connectionString = "Server=localhost;Database=examen;Trusted_Connection=True;";
            string query = "SELECT ClienteID, Nombre + ' ' + Apellido AS NombreCompleto FROM Clientes";

            try
            {
                comboBoxClienteID.Items.Clear();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                comboBoxClienteID.Items.Add(new { Id = reader["ClienteID"], Name = reader["NombreCompleto"] });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los clientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarDatosVehiculo()
        {
            string connectionString = "Server=localhost;Database=examen;Trusted_Connection=True;";
            string query = "SELECT ClienteID, Marca, Modelo, Anio, Placa FROM Vehiculos WHERE VehiculoID = @VehiculoID";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@VehiculoID", VehiculoID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                comboBoxClienteID.SelectedValue = reader["ClienteID"];
                                textBoxMarca.Text = reader["Marca"].ToString();
                                textBoxModelo.Text = reader["Modelo"].ToString();
                                numericUpDownAnio.Value = Convert.ToDecimal(reader["Anio"]);
                                // Configura textBox para placa aquí...
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos del vehículo: " + ex.Message);
            }
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=examen;Trusted_Connection=True;";
            string query = IsEditMode
                ? "UPDATE Vehiculos SET ClienteID = @ClienteID, Marca = @Marca, Modelo = @Modelo, Anio = @Anio, Placa = @Placa WHERE VehiculoID = @VehiculoID"
                : "INSERT INTO Vehiculos (ClienteID, Marca, Modelo, Anio, Placa) VALUES (@ClienteID, @Marca, @Modelo, @Anio, @Placa)";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ClienteID", ((dynamic)comboBoxClienteID.SelectedItem).Id);
                        command.Parameters.AddWithValue("@Marca", textBoxMarca.Text);
                        command.Parameters.AddWithValue("@Modelo", textBoxModelo.Text);
                        command.Parameters.AddWithValue("@Anio", numericUpDownAnio.Value);
                        command.Parameters.AddWithValue("@Placa", textBoxPlaca.Text);

                        if (IsEditMode)
                            command.Parameters.AddWithValue("@VehiculoID", VehiculoID);

                        command.ExecuteNonQuery();
                        MessageBox.Show(IsEditMode ? "Vehículo actualizado correctamente." : "Vehículo registrado correctamente.");
                        Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el vehículo: " + ex.Message);
            }
        }
    }

}
