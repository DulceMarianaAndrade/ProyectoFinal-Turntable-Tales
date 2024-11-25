using System.Data;
using Tabla_Nombre_y_Edad.Dato;
using Tabla_Nombre_y_Edad.Modelo;

namespace Tabla_Nombre_y_Edad
{
    public partial class Form1 : Form
    {
        DataTable tabla;
        Usuario dato = new Usuario();
        public Form1()
        {
            InitializeComponent();
            Iniciar();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            Guardar();
            Iniciar();
            Limpiar();
            Consultar();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Iniciar()
        {
            tabla = new DataTable();
            tabla.Columns.Add("Nombre");
            tabla.Columns.Add("Edad");
            grilla.DataSource = tabla;
        }

        private void Guardar()
        {
            UsuarioModel modelo = new UsuarioModel()
            {
                Nombre = txtnombre.Text,
                Edad = int.Parse(txtedad.Text)
            };
            dato.Guardar(modelo);
        }

        private void Consultar()
        {
            foreach (var item in dato.Consultar())
            {
                DataRow fila = tabla.NewRow();
                fila["Nombre"] = item.Nombre;
                fila["Edad"] = item.Edad;
                tabla.Rows.Add(fila);
            }
        }
        private void Limpiar()
        {
            txtnombre.Text = "";
            txtedad.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
