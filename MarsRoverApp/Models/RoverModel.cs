using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverApp.Models
{
    public class RoverModel
    {
        public byte _roverXCoordinate { get; set; }
        public byte _roverYCoordinate { get; set; }
        public char _roverDirection { get; set; }
        public byte roverXCoordinate
        {
            get { return _roverXCoordinate; }
            set { _roverXCoordinate = value; }
        }
        public byte roverYCoordinate
        {
            get { return _roverYCoordinate; }
            set { _roverYCoordinate = value; }
        }
        public char roverDirection
        {
            get { return _roverDirection; }
            set { _roverDirection = value; }
        }
    }
}
