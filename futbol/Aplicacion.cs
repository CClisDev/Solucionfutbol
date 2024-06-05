using futbol.Enum;
using System;

namespace futbol
{
    public class Aplicacion
    {
        private League league = new League("Champions League");
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
            // Listar clubes
            // solicitar equipo local
            // Solicatar equipo visitante
            // fecha y hora
            // Lugar
            // Mostrar el resultado del partido
        }

        public void AddAPlayer()
        {
            //Equipo de futbol
            Console.WriteLine(league.GetListTeams());
            Team team = RequestTeam();

            // Datos personales del jugador
            Console.Write("Posición del Jugador: ");
            string position = RequestPositionPlayer();

            Console.Write("Numero dorsal del Jugador: ");
            int dorsalNumber = RequestNumber(0, 99);

            Console.Write("Nombre del jugador: ");
            string namePlayer = Console.ReadLine();

            Console.Write("Apellidos del jugador: ");
            string lastNamePlayer = Console.ReadLine();

            Console.Write("Edad del jugador: ");
            int age = RequestNumber(0, 99);

            Console.Write("Altura del jugador (cm): ");
            int height = RequestNumber(0, int.MaxValue);

            Console.Write("Peso del jugador (kg): ");
            int weight = RequestNumber(0, int.MaxValue);

            league.AddPlayer(team, new Player(team, position, dorsalNumber, namePlayer, lastNamePlayer, age, height, weight));
        }

        public string RequestPositionPlayer()
        {
            Console.Write(@"
(0) Portero
(1) Defensa
(2) Mediocentro
(3) Delantero
Introduce la posición:");
            int position = RequestNumber(0, 3);

            switch ((ePositionPlayer)position)
            {
                case ePositionPlayer.Portero:
                    return ePositionPlayer.Portero.ToString();
                case ePositionPlayer.Defensa:
                    return ePositionPlayer.Defensa.ToString();
                case ePositionPlayer.Mediocentro:
                    return ePositionPlayer.Mediocentro.ToString();
                case ePositionPlayer.Delantero:
                    return ePositionPlayer.Delantero.ToString();
                default:
                    return null;
            }
        }

        public Team RequestTeam()
        {
            Console.Write("Introduce el numero del equipo: ");
            int teamNumber = RequestNumber(0, league.Teams.Count-1);

            return league.Teams[teamNumber];
        }

        public void DeleteAPlayer() 
        { 
            // Listar jugadores
            // Pregunstar cual eliminar
        }

        public void ListPlayersByTeam()
        {
            // Listar clubes
            Console.WriteLine(league.GetListTeams());
            Team team = RequestTeam();

            Console.Write(league.GetPlayersByTeam(team));
        }
    }
}
