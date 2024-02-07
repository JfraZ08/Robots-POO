using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
      
    
        public class Robot(string? nom, int positionX, int positionY) : RobotAbstrait
            { 
            public string? Nom = nom;
            internal int PositionX = positionX;
            internal int PositionY = positionY;

        public void Avancer(int newPosX, int newPosY) 
            {
                 PositionX = newPosX + 4;
                 PositionY = newPosY + 6;
            }

            public void AfficherPosition()
            {
            Console.WriteLine($"Position X:{PositionX} Position Y{PositionY}");
            }

            public override void Demarrer() 
            {
            Console.WriteLine("Je démarre");
            }
        }
 
}
