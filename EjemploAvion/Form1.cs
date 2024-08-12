namespace EjemploAvion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            /*Avion objetoAvion = new Avion()
            {
                Modelo = textBoxModelo.Text,
            };*/


            Avion objetoAvion2 = new();

            objetoAvion2.Modelo = textBoxModelo.Text;

            objetoAvion2.TiempoDeServicio = (int)numericUpDownTiempoDeServicio.Value;

            objetoAvion2.EstaActivo = 

            objetoAvion2.AniosDeServicio =  int.Parse(textBoxAniosDeServicio.Text);



                

        }
    }
}