using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverApp.Models
{
   public class MarsPlateauModel
    {
        private byte _xCoordinate { get; set; }
        private byte _yCoordinate { get; set; }

        public byte xCoordinate
        {
            get { return _xCoordinate; }
            set {_xCoordinate = value;}
        }
        public byte yCoordinate
        {
            get { return _yCoordinate; }
            set { _yCoordinate = value; }
        }
    }
}
