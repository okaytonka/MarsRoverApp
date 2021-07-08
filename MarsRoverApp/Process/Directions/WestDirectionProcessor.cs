﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverApp.Process.Directions
{
   public class WestDirectionProcessor
    {
        public char LocationDirection(char direction)
        {

            if (direction == 'R')
            {
                return TurnRight();
            }
            else
            {
                return TurnLeft();
            }
        }
        public byte Move(byte xCoordinate)
        {
            return (byte)(xCoordinate - 1);
        }
        char TurnRight()
        {
            return 'N';
        }
        char TurnLeft()
        {
            return 'S';
        }
    }
}
