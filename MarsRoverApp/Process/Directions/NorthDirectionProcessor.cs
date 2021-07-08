using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverApp.Process.Directions
{
    public class NorthDirectionProcessor
    {
        public char LocationDirection(char direction)
        {
           
          if(direction=='R')
            {
                return TurnRight();
            }
          else
            {
               return TurnLeft();
            }
        }
        public  byte Move(byte yCoordinate)
        {
            return (byte)(yCoordinate+1);
        }
        char TurnRight()
        {
            return 'E';
        }
        char  TurnLeft()
        {
            return 'W';
        }
    }
}
