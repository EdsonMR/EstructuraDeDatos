using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad.Agenda
{
    class Agenda
    {
        public int tamaño = 4;
        private Contacto[] agenda = new Contacto[5];
        public int contador = 0;

        public void agregar(Contacto conti) // hay que modificar
        {
            agenda[contador] = conti;
            contador++;
        }

        public Contacto buscar(string telefono)
        {
            for (int x = 0; x < tamaño; x++)
            if (agenda[x].Telefono == telefono) return agenda[x];

            return null;
        }

        public void eliminar(string telefono)
        {
            for (int x = 0; x < tamaño; x++)
                if (agenda[x].Telefono == telefono)
                    for (int y = x; y < tamaño - 1; y++) agenda[y] = agenda[y + 1];

            agenda[tamaño - 1] = null;
            contador--;
        }

        public string listar()
        {
            string cadena = "";
            for (int x = 0; x < contador; x++)
            {
                cadena += agenda[x].Nombre +  " " + agenda[x].APaterno + " " + agenda[x].AMaterno + " , " + agenda[x].Telefono + " , " + agenda[x].Edad + " , " + agenda[x].Email + Environment.NewLine;
            }

            return cadena;
        }
    }
}
