using System;

namespace tareaConsola
{
    public class Contenido
    {
        public string AOPrimero { get; set; }
        public string AOSegundo { get; set; }
        public string AOTercero { get; set; }
        public string AOCuarto { get; set; }
        public string AOQuinto { get; set; }
        public string AOSexto { get; set; }
        public string AOSeptimo { get; set; }
        public string AOOctavo { get; set; }
        public string AONoveno { get; set; }
        public string AODecimo { get; set; }
        public void AOBJETOS1()
        {
            var AOPrimero = $" si buscas madera los {this.AOPrimero} seran una gran fuente para la recoleccion de los mismos";
            Console.WriteLine(AOPrimero);
        }
        public void AOBJETOS2()
        {
            var AOSegundo = $" mientras que en los {this.AOSegundo} podras encontrar municiones o cosas utiles pero igualmente ocultan peligros escondidos";
            Console.WriteLine(AOSegundo);
        }
        public void AOBJETOS3()
        {
            var AOTercero = $" ten mucho cuidado cerca de las {this.AOTercero } podras encontrar varios grupos de almenos 80 zombies, hibernan alli";
            Console.WriteLine(AOTercero);
        }
        public void AOBJETOS4()
        {
            var AOCuarto = $"pero si encuentras una {this.AOCuarto} intenta ser cauteloso al acercarte por haber sido saqueada y ser una trampa de otros bandos ";
            Console.WriteLine(AOCuarto);
        }
        public void AOBJETOS5()
        {
            var AOQuinto = $" al igual que los {this.AOQuinto} les atrae el olor de la gasolina y esta cerca de estas zonas. ";
            Console.WriteLine(AOQuinto);
        }
        public void AOBJETOS6()
        {
            var AOSexto = $" no sabemos como decirlo pero encontramos algo como un {this.AOSexto} es lo mejor que lo describimos ya que es una combinacion muy extraña, gigante y peligrosa ";
            
            Console.WriteLine(AOSexto);
        }
        public void AOBJETOS7()
        {
            var AOSeptimo = $" lo mas importante para nosostros son las {this.AOSeptimo} ya que son fundamentales al momento de enfermedades ";
            Console.WriteLine(AOSeptimo);
        }
        public void AOBJETOS8()
        {
            var AOOctavo = $" existen muchimas {this.AOOctavo} puedes encontrar comida y dispensa para el campamento ";
            Console.WriteLine(AOOctavo);
        }
        public void AOBJETOS9()
        {
            var AONoveno = $" hemos sobrevivido con {this.AONoveno} puede sacarles provecho tambien usandolos o sacando sus partes para reparaciones de otros vehiculos ";
            Console.WriteLine(AONoveno);
        }
        public void AOBJETOS10()
        {
            var AOecimo = $" los mas dificil de pasar en los viajes aparte de zombies son las {this.AODecimo}, puestas por bandas enemigas que querian saquearnos ";
            Console.WriteLine(AOecimo);
        }
    }
}