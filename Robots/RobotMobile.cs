using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    internal class RobotsMobile(string? nom, int positionX, int positionY, int vitesse) : Robot(nom, positionX, positionY), IRobotNettoyage // RobotsMobile hérite de Robots(':')
    {
        public int Vitesse = vitesse;
        public Point? Position; 

        public int CalculerDureeDeDéplacement( int newPosX, int newPosY)
        {
            return ((newPosX - PositionX) + (newPosY - PositionY)) / Vitesse;
        }

        public new void AfficherPosition()
        {
            Console.WriteLine($"Position X:{PositionX} Position Y{PositionY}");
        }

        public void Nettoyer()
        {
            Console.WriteLine($"Le robot mobile:{ Nom } nettoie le sol");
            throw new NotImplementedException();
        }

        public static new void Demarrer() {
            Console.WriteLine("Je démarre");
        }

        public Point? GetPosition()
        {
            return Position;
        }

        public void SeDeplacer(Point destination, Point Position)
        {
            int distance = Utils.CalculerDistance(a: Position, b: destination);

            Console.WriteLine($"Distance entre la position actuelle du robot et la destination : {distance}"); 
        }

        public void ModifieNom(string nouveauNom)
        {
            Nom = nouveauNom;
            
        }





    }
}
