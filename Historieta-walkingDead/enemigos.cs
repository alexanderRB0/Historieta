using System;

namespace tareaConsola
{
    public class Malos
    {
        public string EPrimero { get; set; }
        public string ESegundo { get; set; }
        public string ETercero { get; set; }
        public string ECuarto { get; set; }
        public string EQuinto { get; set; }
        public string ESexto { get; set; }
        public string ESeptimo { get; set; }
        public string EOctavo { get; set; }
        public string ENoveno { get; set; }
        public string EDecimo { get; set; }
        public void Enemy1()
        {
            var EPrimero = $" Los Zombies {this.EPrimero} son muy lentos y faciles de vencer  aunque,";
            Console.WriteLine(EPrimero);
        }
        public void Enemy2()
        {
            var ESegundo = $" empezamos a ver {this.ESegundo} estos suelen ser muy buenos con su oido y emitian gitos espantosos ";
            Console.WriteLine(ESegundo);
        }
        public void Enemy3()
        {
            var ETercero = $" debes tener cuidado de los {this.ETercero } a pesar que les dispares muchas veces no caeran facilmente ";
            Console.WriteLine(ETercero);
        }
        public void Enemy4()
        {
            var ECuarto = $" hemos visto unos zombies gordos que los llamamos {this.ECuarto} ya que al momento de estar cerca o dispararles explotan ";
            Console.WriteLine(ECuarto);
        }
        public void Enemy5()
        {
            var EQuinto = $" los {this.EQuinto} son muy buenos exploradores pero sobre todo avisaran a los demas tu ubicacion";
            Console.WriteLine(EQuinto);
        }
        public void Enemy6()
        {
            var ESexto = $" existe una rara especie que denominamos {this.ESexto} por iniciar una combuistion en si mismos ";
            Console.WriteLine(ESexto);
        }
        public void Enemy7()
        {
            var ESeptimo = $" tambien hemos visto {this.ESeptimo} las cuales son sumamente silenciosas y emiten un gran llanto al ser molestadas";
            Console.WriteLine(ESeptimo);
        }
        public void Enemy8()
        {
            var EOctavo = $" los mas rapidos que hemos visto son los {this.EOctavo} son muy agresivos y te perseguiran hasta matarte";
            Console.WriteLine(EOctavo);
        }
        public void Enemy9()
        {
            var ENoveno = $" una especie de zombie animales que encontramos les decimos {this.ENoveno}  ";
            Console.WriteLine(ENoveno);
        }
        public void Enemy10()
        {
            var EDecimo = $" y con una altura de casi 2.30 metros de altura los designamos como {this.EDecimo} ";
            Console.WriteLine(EDecimo);
        }
    }
}