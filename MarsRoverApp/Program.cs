using MarsRoverApp.Models;
using MarsRoverApp.Process;
using System;

namespace MarsRoverApp
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Planet Size: ");
            var planetSize = Console.ReadLine().Split(" ");

            if(planetSize.Length==2)
            {

                MarsPlateauModel marsPlateauModel = new MarsPlateauModel();
                marsPlateauModel.xCoordinate= Convert.ToByte(planetSize[0]);
                marsPlateauModel.yCoordinate= Convert.ToByte(planetSize[1]);
                while (true)
                {
                    Console.Write("Rover Location:");
                var position = Console.ReadLine().ToUpper().Split(" ");
               
                    if (position.Length == 3)
                    {
                        MoveProcessor moveProcessor = new MoveProcessor();
                        RoverModel roverModel = new RoverModel();
                        roverModel.roverXCoordinate = Convert.ToByte(position[0]);
                        roverModel.roverYCoordinate = Convert.ToByte(position[1]);
                        roverModel.roverDirection = Convert.ToChar(position[2]);
                        moveProcessor.RoverFirstLocation(roverModel, marsPlateauModel);

                        Console.Write("Move Rover:");
                        var commands = Console.ReadLine().ToUpper().ToCharArray();
                        moveProcessor.RoverLocationDirector(commands);
                        Console.WriteLine("LAST ROVER COORDINATE: " + moveProcessor.RoverLocationWriter());

                    }
                }
 
            }

            Console.ReadKey();

        }
    }
}
