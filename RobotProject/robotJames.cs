using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotProject
{
    class RobotJames : RobotParent
    {
        public RobotJames(string name, int batteryPercent)
        {
            this.name = name;
            this.batteryPercent = batteryPercent;
            
        }

    }
}
