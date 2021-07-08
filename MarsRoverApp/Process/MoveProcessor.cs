using MarsRoverApp.Models;
using MarsRoverApp.Process.Directions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverApp.Process
{
   public class MoveProcessor
    {
        RoverModel roverProcessorModel = new RoverModel();
        MarsPlateauModel marsProcessPlateauModel = new MarsPlateauModel();
        //FIRST LOCATION
        public void RoverFirstLocation(RoverModel roverModel, MarsPlateauModel marsPlateauModel)
        {
            roverProcessorModel = roverModel;
            marsProcessPlateauModel = marsPlateauModel;
        }
        //NOW LOCATION
        public string RoverLocationWriter()
        {

            if (roverProcessorModel.roverXCoordinate >=0 && roverProcessorModel.roverXCoordinate <=marsProcessPlateauModel.xCoordinate
                && roverProcessorModel.roverYCoordinate>=0 && roverProcessorModel.roverYCoordinate <=marsProcessPlateauModel.yCoordinate)
            {
                return "X:"+roverProcessorModel.roverXCoordinate + " Y:" + roverProcessorModel.roverYCoordinate + " DIRECTION:" + roverProcessorModel.roverDirection;

            }

             return "Invalid Move";
        }
        public void RoverLocationDirector(char [] command)
        {
            foreach(var item in command)
            {
                switch(item)
                {
                    case 'M':
                        RoverMove(roverProcessorModel.roverDirection);
                        break;
                    case 'R':
                        RoverDirection(item,roverProcessorModel.roverDirection);
                        break;
                    case 'L':
                        RoverDirection(item, roverProcessorModel.roverDirection);
                        break;
                }
            }
        }

        //MOVE
        public void RoverMove(char currentDirection)
        {
            switch (currentDirection)
            {
                case 'N':
                    NorthDirectionProcessor northDirectionProcessor = new NorthDirectionProcessor();
                    roverProcessorModel.roverYCoordinate = northDirectionProcessor.Move(roverProcessorModel.roverYCoordinate);

                    break;
                case 'W':
                    WestDirectionProcessor westDirectionProcessor = new WestDirectionProcessor();
                    roverProcessorModel.roverXCoordinate = westDirectionProcessor.Move(roverProcessorModel.roverXCoordinate);

                    break;
                case 'E':
                    EastDirectionProcessor eastDirectionProcessor = new EastDirectionProcessor();
                    roverProcessorModel.roverXCoordinate = eastDirectionProcessor.Move(roverProcessorModel.roverXCoordinate);

                    break;
                case 'S':
                    SouthDirectionProcessor southDirectionProcessor = new SouthDirectionProcessor();
                    roverProcessorModel.roverYCoordinate = southDirectionProcessor.Move(roverProcessorModel.roverYCoordinate);

                    break;
            }
        }
        //LR DIRECTION
        public void RoverDirection(char direction,char currentDirection)
        {
            switch (currentDirection)
            {
                case 'N':
                    NorthDirectionProcessor northDirectionProcessor = new NorthDirectionProcessor();
                    roverProcessorModel.roverDirection= northDirectionProcessor.LocationDirection(direction);

                    break;
                case 'W':
                    WestDirectionProcessor westDirectionProcessor = new WestDirectionProcessor();
                    roverProcessorModel.roverDirection = westDirectionProcessor.LocationDirection(direction);

                    break;
                case 'E':
                    EastDirectionProcessor eastDirectionProcessor = new EastDirectionProcessor();
                    roverProcessorModel.roverDirection = eastDirectionProcessor.LocationDirection(direction);

                    break;
                case 'S':
                    SouthDirectionProcessor southDirectionProcessor = new SouthDirectionProcessor();
                    roverProcessorModel.roverDirection = southDirectionProcessor.LocationDirection(direction);

                    break;
            }
        }

    }
}
