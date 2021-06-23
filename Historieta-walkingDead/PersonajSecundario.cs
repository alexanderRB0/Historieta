using System;

namespace tareaConsola
{
    public class PersonajeSecundario
    {
        public string PPrimero { get; set; }
        public string PSegundo { get; set; }
        public string PTercero { get; set; }
        public string PCuarto { get; set; }
        public string PQuinto { get; set; }
        public string PSexto { get; set; }
        public string PSeptimo { get; set; }
        public string POctavo { get; set; }
        public string PNoveno { get; set; }
        public string PDecimo { get; set; }
        public void Personajes1()
        {
            var PPrimero = $" Nuestro mecanico Principal {this.PPrimero} ";
            Console.WriteLine(PPrimero);
        }
        public void Personajes2()
        {
            var PSegundo = $" En carpinteria tenemos a {this.PSegundo} ";
            Console.WriteLine(PSegundo);
        }
        public void Personajes3()
        {
            var PTercero = $" como nuestro condutor encontraras a {this.PTercero } ";
            Console.WriteLine(PTercero);
        }
        public void Personajes4()
        {
            var PCuarto = $" En conocimiento electricos e inventos habla con {this.PCuarto} ";
            Console.WriteLine(PCuarto);
        }
        public void Personajes5()
        {
            var PQuinto = $" Experta en exploracion tienes a {this.PQuinto} ";
            Console.WriteLine(PQuinto);
        }
        public void Personajes6()
        {
            var PSexto = $" Para compra de objetos extraños puedes visitar a {this.PSexto} ";
            Console.WriteLine(PSexto);
        }
        public void Personajes7()
        {
            var PSeptimo = $" Reparaciones de cualquier tipo esta {this.PSeptimo} ";
            Console.WriteLine(PSeptimo);
        }
        public void Personajes8()
        {
            var POctavo = $" Como doctor experimentado contacta a {this.POctavo} ";
            Console.WriteLine(POctavo);
        }
        public void Personajes9()
        {
            var PNoveno = $" Para compra y venta de armas busca a alguien llamada {this.PNoveno} ";
            Console.WriteLine(PNoveno);
        }
        public void Personajes10()
        {
            var PDecimo = $" Muy buena exploracion y ubicacion puedes hablar con {this.PDecimo} ";
            Console.WriteLine(PDecimo);
        }
    }
        
}