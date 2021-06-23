using System;

namespace tareaConsola
{
    public class PersonajePrincipal
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string ArmaEquipada { get; set; }
        public string CantidadDeArmas { get; set; }
        public string TipoDeArmas { get; set; }
        public string LugarDeBusqueda { get; set; }
        public string NumeroDeCompañeros { get; set; }
        public string Destino { get; set; }
        public string Objetivo { get; set; }
        public string Recompensa { get; set; }


        public void PNombre()
        {
            var Nombre = $"saludos amigo, ya despertaste mi nombre es {this.Nombre}";
            Console.WriteLine(Nombre);
        }
        public void PSecundario()
        {
            var Apellido = $"y mi apellido es {this.Apellido}";
            Console.WriteLine(Apellido);
        }
        public void AEquipada()
        {
            var ArmaEquipada = $" El arma que portaras sera {this.ArmaEquipada}, hasta que encuentres otras armas en tus viajes.";
            Console.WriteLine(ArmaEquipada);
        }
        public void CArmas()
        {
            var CantidadDeArmas = $" puedes tener {this.CantidadDeArmas}, como un maximo de armas que puedas llevar ";
            Console.WriteLine(CantidadDeArmas);
        }
        public void TArmas()
        {
            var TipoDeArmas = $" existen algunas armas como {this.TipoDeArmas}, las mismas que econtrataras en zonas de busqueda especifica ";
            Console.WriteLine(TipoDeArmas);
        }
        public void LBusqueda()
        {
            var LugarDeBusqueda = $" Por el momento nos encontramos en  {this.LugarDeBusqueda}, esperamos no ser los ultimos sobrevivientes ";
            Console.WriteLine(LugarDeBusqueda);
        }
        public void NCompañeros()
        {
            var NumeroDeCompañeros = $" Como puedes observar vivimos en una comunidad de {this.NumeroDeCompañeros} , los mismos que te ayudaran y los ayudaras con sus respectivas tareas a lo largo de tu estadia";
            Console.WriteLine(NumeroDeCompañeros);
        }
        public void Destiny()
        {
            var Destino = $" Debemos llegar en una semana hacia {this.Destino}, ya que nos embarcaran a una isla sin contagios";
            Console.WriteLine(Destino);
        }
        public void Objetive()
        {
            var Objetivo = $" Debes {this.Objetivo} ";
            Console.WriteLine(Objetivo);
        }
        public void Reward()
        {
            var Recompensa = $" Entonces podras {this.Recompensa} ";
            Console.WriteLine(Recompensa);
        }
    }
}