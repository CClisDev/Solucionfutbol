using futbol.Enum;
using System;

namespace futbol
{
    public class Aplicacion
    {
        public void Aplication()
        {
            League league = new League("Champions League");

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
            // Pregunstar cual eliminar
        
        }

        public void ListPlayersByTeam()
        {
            // Listar clubes
            // pedir club
            // Mostrar lista
        }
    }
}
