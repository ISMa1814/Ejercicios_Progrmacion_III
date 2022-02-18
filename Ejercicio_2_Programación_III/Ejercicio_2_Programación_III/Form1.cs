namespace Ejercicio_2_Programación_III
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Arreglos Estáticos
        static string[] nombre = new string[5];
        static int[] edad = new int[5];
        static int contador = -1;

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            contador = contador + 1;

            if (contador < nombre.Length)
            {
                nombre[contador] = NombreTextBox.Text;
                edad[contador] = Convert.ToInt32(EdadTextBox.Text);
            }
            else
            {
                MessageBox.Show("Lo siento, ha alcazando el número máximo de alumnos ingresados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarListaButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < nombre.Length; i++)
            {
                ComboBox.Items.Add("N." + (i + 1) + " Nombre: " + nombre[i] + " Edad: " + edad[i] + " Años");
            }
        }
    }
}