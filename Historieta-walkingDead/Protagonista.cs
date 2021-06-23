using System;

namespace tareaConsola
{
    class Protagonista
    {
        public static void Main(string[] arg)
        {
            Console.WriteLine("WalkingDead");
            var protagonista = new PersonajePrincipal
            {
                Nombre = "Edmus",
                Apellido = "Garfeldt",
                ArmaEquipada = " la escopeta",
                CantidadDeArmas = "4",
                TipoDeArmas = "rifles, sub-fusibles, escopetas o pistolas",
                LugarDeBusqueda = "Alabama",
                NumeroDeCompañeros = "5 sobrevivientes",
                Destino = "Canada",
                Objetivo = "salvar a los sobrevivientes que encontremos y llevarlos al refujio en Canada",
                Recompensa = "unirte a una comunidad en la cual tendras un puesto importante"

            };
            protagonista.PNombre();
            protagonista.PSecundario();
            protagonista.AEquipada();
            protagonista.CArmas();
            protagonista.TArmas();
            protagonista.LBusqueda();
            protagonista.NCompañeros();
            protagonista.Destiny();
            protagonista.Objetive();
            protagonista.Reward();


            var Personajes = new PersonajeSecundario
            {
                PPrimero = "Alex",
                PSegundo = "Michael",
                PTercero = "Jeremy",
                PCuarto = "Abraham",
                PQuinto = "Shena",
                PSexto = "Elena",
                PSeptimo = "Tommas",
                POctavo = "Richard",
                PNoveno = "Edna",
                PDecimo = "Noelia"
            };

            Personajes.Personajes1();
            Personajes.Personajes2();
            Personajes.Personajes3();
            Personajes.Personajes4();
            Personajes.Personajes5();
            Personajes.Personajes6();
            Personajes.Personajes8();
            Personajes.Personajes1();
            Personajes.Personajes9();
            Personajes.Personajes10();

            var Vehiculo = new Transportes
            {
                VPrimero = "Trailer",
                VSegundo = "Camion de Carga",
                VTercero = "Camioneta",
                VCuarto = "Helicoptero",
                VQuinto = "Motocicleta",
                VSexto = "Bicicleta",
                VSeptimo = "TodoTerreno",
                VOctavo = "Hibrido",
                VNoveno = "carroMediano",
                VDecimo = "Mustang"
            };

            Vehiculo.Vehiculo1();
            Vehiculo.Vehiculo2();
            Vehiculo.Vehiculo3();
            Vehiculo.Vehiculo4();
            Vehiculo.Vehiculo5();
            Vehiculo.Vehiculo6();
            Vehiculo.Vehiculo8();
            Vehiculo.Vehiculo1();
            Vehiculo.Vehiculo9();
            Vehiculo.Vehiculo10();

            var Enemigo = new Malos
            {
                EPrimero = "Lentos",
                ESegundo = "Carroñeros",
                ETercero = "Colericos",
                ECuarto = "Blooms",
                EQuinto = "Hunters",
                ESexto = "Flamers",
                ESeptimo = "Witchers",
                EOctavo = "Golpeadores",
                ENoveno = "Bestias",
                EDecimo = "Tanque"
            };

            Enemigo.Enemy1();
            Enemigo.Enemy2();
            Enemigo.Enemy3();
            Enemigo.Enemy4();
            Enemigo.Enemy5();
            Enemigo.Enemy6();
            Enemigo.Enemy7();
            Enemigo.Enemy8();
            Enemigo.Enemy9();
            Enemigo.Enemy10();

            var AnimalsObjetos = new Contenido
            {
                AOPrimero = "Arboles",
                AOSegundo = "Edificios en Ruina",
                AOTercero = "Alcantarillas",
                AOCuarto = "Gasolineras",
                AOQuinto = "Perros infectados",
                AOSexto = "Mutaciones desconocidas",
                AOSeptimo = "Farmaceuticas",
                AOOctavo = "Tiendas de Abarrotes",
                AONoveno = "carros csi nuevos",
                AODecimo = "Trampas de otras bandas"
            };

            AnimalsObjetos.AOBJETOS1();
            AnimalsObjetos.AOBJETOS2();
            AnimalsObjetos.AOBJETOS3();
            AnimalsObjetos.AOBJETOS4();
            AnimalsObjetos.AOBJETOS5();
            AnimalsObjetos.AOBJETOS6();
            AnimalsObjetos.AOBJETOS7();
            AnimalsObjetos.AOBJETOS8();
            AnimalsObjetos.AOBJETOS9();
            AnimalsObjetos.AOBJETOS10();
        }
    
    }
}