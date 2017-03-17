using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiempos.Model
{
    class Jugador
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public int password { get; set; }
        public bool admin { get; set; }
        public string correo { get; set; }


        public Jugador()
        {

        }

        public Jugador(int id, string nombre,int password,bool admin, string correo)
        {
            this.id = id;
            this.nombre = nombre;
            this.password = password;
            this.admin = admin;
            this.correo = correo;
        }
    }
}
