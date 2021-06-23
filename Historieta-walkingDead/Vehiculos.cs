using System;

namespace tareaConsola
{
    public class Transportes
    {
        public string VPrimero { get; set; }
        public string VSegundo { get; set; }
        public string VTercero { get; set; }
        public string VCuarto { get; set; }
         public string VQuinto { get; set; }
        public string VSexto { get; set; }
        public string VSeptimo { get; set; }
        public string VOctavo { get; set; }
        public string VNoveno { get; set; }
        public string VDecimo { get; set; }
        public void Vehiculo1()
        {
            var VPrimero = $" por medio de un gran {this.VPrimero} podras abrirte paso por medio de grandes hordas";
            Console.WriteLine(VPrimero);
        }
        public void Vehiculo2()
        {
            var VSegundo = $"aunque al momento que encuentres lugares con mucha comida llevate el {this.VSegundo}, aunque aveces suele dañarse, ";
            Console.WriteLine(VSegundo);
        }
        public void Vehiculo3()
        {
            var VTercero = $"tambien una {this.VTercero },es para terrenos dificiles pero es una gran ayuda para llevar objetos pesados y pequeños, ";
            Console.WriteLine(VTercero);
        }
        public void Vehiculo4()
        {
            var VCuarto = $" Hace años encontramos un {this.VCuarto} lo volamos para rescatar varios sobrevivientes cuando aun eramos mas,";
            Console.WriteLine(VCuarto);
        }
        public void Vehiculo5()
        {
            var VQuinto = $" cuando sepas que necesitas ir por senderos estrechos enzonas rurales ten en cuenta la {this.VQuinto} es muy agil";
            Console.WriteLine(VQuinto);
        }
        public void Vehiculo6()
        {
            var VSexto = $" si deseas descansar y hacer un poco de deporte aqui usa nuestra {this.VSexto} ";
            Console.WriteLine(VSexto);
        }
        public void Vehiculo7()
        {
            var VSeptimo = $" si deseas ir por terrenos sumamente dañados o incluso por montañas el {this.VSeptimo} es exelente";
            Console.WriteLine(VSeptimo);
        }
        public void Vehiculo8()
        {
            var VOctavo = $" si haz encontrado gente usa el {this.VOctavo} por su amplitud puede llevar a muchos sobrevivientes";
            Console.WriteLine(VOctavo);
        }
        public void Vehiculo9()
        {
            var VNoveno = $" para movilizarte pronto y lugares cercanos el {this.VNoveno} muy usado porque tiene una bomba dentro";
            Console.WriteLine(VNoveno);
        }
        public void Vehiculo10()
        {
            var VDecimo = $" buscando entre tantos coches encontramos un {this.VDecimo} es el mas veloz de todos";
            Console.WriteLine(VDecimo);
        }
    }
}