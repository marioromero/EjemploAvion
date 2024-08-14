using System.Drawing.Text;

namespace EjemploAvion
{
    public partial class Form1 : Form
    {
        private List<Avion> avionList = new List<Avion>();
        

        public Form1()
        {
            InitializeComponent();
            InicializarDataGridView();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            /*Avion objetoAvion = new Avion()
            {
                Modelo = textBoxModelo.Text,
            };*/


            Avion objetoAvion2 = new();

            objetoAvion2.Modelo = textBoxModelo.Text;

            //con (int) se convierte el valor de numericUpDownTiempoDeServicio a entero.
            //Conversion explicita = quiere decir que se esta forzando la conversion
            //desde un tipo de dato a otro. en este caso de decimal a entero.
            objetoAvion2.TiempoDeServicio = (int)numericUpDownTiempoDeServicio.Value;

            objetoAvion2.EstaActivo = activo.Checked ? true : false;

            //con int.Parse se convierte el valor de textBoxAniosDeServicio a entero.
            //conversi�n mediante el m�todo Parse = se convierte el valor de un tipo de dato a otro.
            //en este caso de cadena a entero.
            objetoAvion2.AniosDeServicio = int.Parse(textBoxAniosDeServicio.Text);

            objetoAvion2.CantidadPasajeros = int.Parse(textBoxCantidadPasajeros.Text);

            objetoAvion2.PrimerVuelo = dateTimePickerPrimerVuelo.Value;

            /*MessageBox.Show("El modelo del avi�n es: " + objetoAvion2.Modelo + "\n" +
                            "El tiempo de servicio del avi�n es: " + objetoAvion2.TiempoDeServicio + "\n" +
                            "El avi�n est� activo: " + objetoAvion2.EstaActivo + "\n" +
                            "Los a�os de servicio del avi�n son: " + objetoAvion2.AniosDeServicio + "\n" +
                            "La cantidad de pasajeros del avi�n es: " + objetoAvion2.CantidadPasajeros + "\n" +
                            "El primer vuelo del avi�n fue: " + objetoAvion2.PrimerVuelo);*/


            avionList.Add(objetoAvion2);     
            
            //una vez que tengo un nuevo avion, actualizo el grid
            ActualizarDataGridView();

        }

        //formatear tabla
        private void InicializarDataGridView()
        {
            tablaAviones.Columns.Add("Modelo", "Modelo");
            tablaAviones.Columns.Add("TiempoDeServicio", "Tiempo de Servicio");
            tablaAviones.Columns.Add("EstaActivo", "Est� activo");
            tablaAviones.Columns.Add("AniosDeServicio", "A�os de servicio");
            tablaAviones.Columns.Add("CantidadPasajeros", "Cantidad Pasajeros");
            tablaAviones.Columns.Add("PrimerVuelo", "Primer vuelo");

        }

        //actualizar datos en tabla
        private void ActualizarDataGridView()
        {
            tablaAviones.Rows.Clear();

            foreach (var avion in avionList)
            {
                tablaAviones.Rows.Add(avion.Modelo,
                    avion.TiempoDeServicio,
                    avion.EstaActivo,
                    avion.AniosDeServicio,
                    avion.CantidadPasajeros,
                    avion.PrimerVuelo.ToShortDateString());
            }
        }



    }
}