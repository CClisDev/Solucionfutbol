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
                Console.WriteLine(@"
(1) Crear un partido
(2) Alta a un jugador
(3) Eliminar a un jugador
(4) Listar los jugadores de un club
(5) Listar equipos de futbol
(0) Salir
");
                int option = RequestNumber(0, 5);

                switch ((eMenuOptions)option)
                {
                    case eMenuOptions.CreateAMatch:
                        break;
                    case eMenuOptions.AddAPlayer:
                        break;
                    case eMenuOptions.DeleteAPlayer:
                        break;
                    case eMenuOptions.ListPlayersByTeam:
                        Console.WriteLine();
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

        }

        public void AddAPlayer()
        {

        }

        public void DeleteAPlayer() 
        { 
        
        }

        public void ListPlayersByTeam()
        {
            
        }
    }
}
