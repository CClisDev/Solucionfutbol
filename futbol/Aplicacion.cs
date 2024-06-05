using futbol.Enum;
using System;
using System.Linq;

namespace futbol
{
    public class Aplicacion
    {
        League league = new League("Champions League");

        public void Aplication()
        {

            while (true)
            {
                Console.Write(@"
(1) Crear un partido
(2) Alta a un jugador
(3) Eliminar a un jugador
(4) Listar los jugadores de un club
(5) Listar equipos de futbol
(0) Salir
Introduce el numero: ");
                int option = RequestNumber(0, 5);

                switch ((eMenuOptions)option)
                {
                    case eMenuOptions.CreateAMatch:
                        CreateAMatch();
                        break;
                    case eMenuOptions.AddAPlayer:
                        AddAPlayer();
                        break;
                    case eMenuOptions.DeleteAPlayer:
                        DeleteAPlayer();
                        break;
                    case eMenuOptions.ListPlayersByTeam:
                        ListPlayersByTeam();
                        break;
                    case eMenuOptions.ListTeams:
                        Console.WriteLine(league.GetListTeams());
                        break;
                    case eMenuOptions.exit:
                        return;
                }
            }
        }

        public int RequestNumber(int min, int max)
        {
            bool validNumber;
            int number;

            while (true)
            {
                validNumber = int.TryParse(Console.ReadLine(), out number);

                if (!validNumber)
                    Console.Write("Introduce un numero!!!: ");
                else if (number < min || number > max)
                    Console.Write($"Introduce un numero entre {min} - {max}: ");
                else
                    return number;
            }
        }

        public void CreateAMatch()
        {
            int sel;
            // Listar clubes
            Console.WriteLine(league.GetListTeams());
            Console.WriteLine(league.Teams.Count);
            Console.WriteLine("Selecciona el equipo local");
            sel = RequestNumber(0,league.Teams.Count - 1);
            
            Team x = league.Teams[sel];
            Console.WriteLine("Selecciona el equipo visitante");
            sel = RequestNumber(0, league.Teams.Count - 1);
            Team y = league.Teams[sel];

            Console.WriteLine("Introduce la fecha del partido:");
            DateTime fecha = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la hora del partido:");

            TimeSpan ts = TimeSpan.Parse(Console.ReadLine());
            Game game = new Game(fecha,ts,"Club trinchera",x,y);

            Console.WriteLine(game.ProcessGame());
        }

        public void AddAPlayer()
        {
            // Posición
            // numbero dorsal
            // nombre
            // apellido
            //edad
            // altura
            // peso
        }

        public void DeleteAPlayer() 
        {
            // Listar jugadores
            if (league.Players.Count == 0)
            {
                Console.WriteLine("Aun no hay jugdores");
            }
            else {
                Console.WriteLine("Que jugador quieres eliminar");
                Console.WriteLine(league.GetPlayerList());
                int number = RequestNumber(0, league.Players.Count - 1);
                league.RemovePlayer(league.Players[number]);
            }
        
        }

        public void ListPlayersByTeam()
        {
            // Listar clubes
            // pedir club
            // Mostrar lista
        }
    }
}
