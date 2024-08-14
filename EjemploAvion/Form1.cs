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
            //conversión mediante el método Parse = se convierte el valor de un tipo de dato a otro.
            //en este caso de cadena a entero.
            objetoAvion2.AniosDeServicio = int.Parse(textBoxAniosDeServicio.Text);

            objetoAvion2.CantidadPasajeros = int.Parse(textBoxCantidadPasajeros.Text);

            objetoAvion2.PrimerVuelo = dateTimePickerPrimerVuelo.Value;

            /*MessageBox.Show("El modelo del avión es: " + objetoAvion2.Modelo + "\n" +
                            "El tiempo de servicio del avión es: " + objetoAvion2.TiempoDeServicio + "\n" +
                            "El avión está activo: " + objetoAvion2.EstaActivo + "\n" +
                            "Los años de servicio del avión son: " + objetoAvion2.AniosDeServicio + "\n" +
                            "La cantidad de pasajeros del avión es: " + objetoAvion2.CantidadPasajeros + "\n" +
                            "El primer vuelo del avión fue: " + objetoAvion2.PrimerVuelo);*/


            avionList.Add(objetoAvion2);     
            
            //una vez que tengo un nuevo avion, actualizo el grid
            ActualizarDataGridView();

        }

        //formatear tabla
        private void InicializarDataGridView()
        {
            tablaAviones.Columns.Add("Modelo", "Modelo");
            tablaAviones.Columns.Add("TiempoDeServicio", "Tiempo de Servicio");
            tablaAviones.Columns.Add("EstaActivo", "Está activo");
            tablaAviones.Columns.Add("AniosDeServicio", "Años de servicio");
            tablaAviones.Columns.Add("CantidadPasajeros", "Cantidad Pasajeros");
            tablaAviones.Columns.Add("PrimerVuelo", "Primer vuelo");

            // Añadir columnas de botones editar  
            DataGridViewButtonColumn editarColumna = new DataGridViewButtonColumn();
            editarColumna.Name = "Editar";
            editarColumna.HeaderText = "Editar";
            editarColumna.Text = "Editar";
            editarColumna.UseColumnTextForButtonValue = true;
            tablaAviones.Columns.Add(editarColumna);

            //añadir columnas de botones eliminar
            DataGridViewButtonColumn eliminarColumna = new DataGridViewButtonColumn();
            eliminarColumna.Name = "Eliminar";
            eliminarColumna.HeaderText = "Eliminar";
            eliminarColumna.Text = "Eliminar";
            eliminarColumna.UseColumnTextForButtonValue = true;
            tablaAviones.Columns.Add(eliminarColumna);


            //agregar evento a grid para cuando se haga click en cualquier celda (ver método tablaAviones_CellClick para entender que ocurre)
            tablaAviones.CellClick += tablaAviones_CellClick;

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

        //evento que se dispara cuando se hace click en una celda del grid
        private void tablaAviones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //si se hace click en una celda que no sea el header...
            if (e.RowIndex >= 0)
            {
                //verifica si la celda pertenece a la columna con nombre "Eliminar"
                if (tablaAviones.Columns[e.ColumnIndex].Name == "Eliminar")
                {
                    //rescata el row index de la fila seleccionada y elimina el avion que corresponde a esa fila
                    avionList.RemoveAt(e.RowIndex);
                    //actualiza el grid
                    ActualizarDataGridView();
                }

                //verifica si la celda pertenece a la columna con nombre "Editar"
                else if (tablaAviones.Columns[e.ColumnIndex].Name == "Editar")
                {
                    // Código para editar los valores de la fila seleccionada
                    Avion avion = avionList[e.RowIndex];

                    textBoxModelo.Text = avion.Modelo;
                    numericUpDownTiempoDeServicio.Value = avion.TiempoDeServicio;
                    activo.Checked = avion.EstaActivo;
                    textBoxAniosDeServicio.Text = avion.AniosDeServicio.ToString();
                    textBoxCantidadPasajeros.Text = avion.CantidadPasajeros.ToString();
                    dateTimePickerPrimerVuelo.Value = avion.PrimerVuelo;

                    avionList.RemoveAt(e.RowIndex);
                    ActualizarDataGridView();
                }
            }
        }
    }
}