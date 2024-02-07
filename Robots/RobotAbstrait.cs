using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
     public abstract class RobotAbstrait
    {

        public abstract void Demarrer();  
        
        public static void Arreter()
        {
            Console.WriteLine("Robot arrêté");
        }


        
    }
}
