using System;

namespace EjemploAvion
{
    internal class Avion
    {
        public string Modelo { get; set; }
        public int TiempoDeServicio { get; set; }
        public bool EstaActivo { get; set; }
        public int AniosDeServicio { get; set; }
        public int CantidadPasajeros { get; set; }
        public DateTime PrimerVuelo { get; set; }
    }
}
