using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class Jugador
    {

        private string nombre;
        private int puntuacion;
        private int perdidas;

        public Jugador(string nombre, int puntuacion)
        {
            this.nombre = nombre;
            this.puntuacion = puntuacion;
            this.perdidas = 0;
        }

        public Jugador(string nombre, int puntuacion, int perdidas)
        {
            this.nombre = nombre;
            this.puntuacion = puntuacion;
            this.perdidas = perdidas;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public int GetPuntuacion()
        {
            return puntuacion;
        }

        public void SetPuntuacion(int puntuacion)
        {
            this.puntuacion = puntuacion;
        }

        public int GetPerdidas()
        {
            return perdidas;
        }

        public void SetPerdidas(int perdidas)
        {
            this.perdidas = perdidas;
        }
    }
}
