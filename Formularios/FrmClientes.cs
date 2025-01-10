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
    public partial class FrmClientes : Form
    {
        public int ClienteID { get; private set; }
        public bool IsEditMode { get; private set; }

        public FrmClientes()
        {
            InitializeComponent();
            IsEditMode = false;
        }

        public FrmClientes(int clienteID)
        {
            InitializeComponent();
            ClienteID = clienteID;
            IsEditMode = true;

            CargarDatosCliente();
        }

        private void CargarDatosCliente()
        {
            string connectionString = "Server=localhost;Database=examen;Trusted_Connection=True;";
            string query = "SELECT Nombre, Apellido, Telefono, Email, Direccion FROM Clientes WHERE ClienteID = @ClienteID";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ClienteID", ClienteID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                textBoxNombre.Text = reader["Nombre"].ToString();
                                textBoxApellido.Text = reader["Apellido"].ToString();
                                textBoxTelefono.Text = reader["Telefono"].ToString();
                                textBoxEmail.Text = reader["Email"].ToString();
                                textBoxDirecc.Text = reader["Direccion"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos del cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=examen;Trusted_Connection=True;";
            string query;

            if (IsEditMode)
            {
                query = "UPDATE Clientes SET Nombre = @Nombre, Apellido = @Apellido, Telefono = @Telefono, " +
                        "Email = @Email, Direccion = @Direccion WHERE ClienteID = @ClienteID";
            }
            else
            {
                query = "INSERT INTO Clientes (Nombre, Apellido, Telefono, Email, Direccion) " +
                        "VALUES (@Nombre, @Apellido, @Telefono, @Email, @Direccion)";
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Nombre", textBoxNombre.Text);
                        command.Parameters.AddWithValue("@Apellido", textBoxApellido.Text);
                        command.Parameters.AddWithValue("@Telefono", textBoxTelefono.Text);
                        command.Parameters.AddWithValue("@Email", textBoxEmail.Text);
                        command.Parameters.AddWithValue("@Direccion", textBoxDirecc.Text);

                        if (IsEditMode)
                        {
                            command.Parameters.AddWithValue("@ClienteID", ClienteID);
                        }

                        command.ExecuteNonQuery();

                        MessageBox.Show(IsEditMode ? "Cliente actualizado correctamente." : "Cliente añadido correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los datos del cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
