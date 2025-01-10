using System.Diagnostics;
using ExamenParcial1.Formularios;
using ExamenParcial1.Listas;
using ExamenParcial1.SQL;

namespace ExamenParcial1
{
    public partial class Form1 : Form
    {
        conexion conectar = new conexion();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        conectar.obtenerConexion();
            Debug.WriteLine("conectado");
            ControlClientes formuClientes = new ControlClientes();
            PanelPrincipal.Controls.Clear();
            PanelPrincipal.Controls.Add(formuClientes);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conectar.obtenerConexion();
            ControVehiculos formuVehiculos = new ControVehiculos();
            PanelPrincipal.Controls.Clear();
            PanelPrincipal.Controls.Add(formuVehiculos);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conectar.obtenerConexion();
            ControlServicios formuServicios = new ControlServicios();   
            PanelPrincipal.Controls.Clear();
            PanelPrincipal.Controls.Add(formuServicios);
        }
    }
}
