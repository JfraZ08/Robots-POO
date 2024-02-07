using MDS;
using Robots;

Class1 class1 = new Class1();

Robot robot = new("test", 2, 3);
robot.Nom = "test";
RobotsMobile r = new("test", 2, 3, vitesse: 25);
RobotsMobile.Demarrer();
RobotAbstrait.Arreter();
// Instancier un objet de la classe RobotsMobile
RobotsMobile _ = new RobotsMobile("test",5,5,5);
Point p = new Point();
Utils.CalculerDistance(p,p);
Point newPosition = new Point();
Utils.CalculerDistance(newPosition,p);
// création nouveau RobotsMobile
RobotsMobile robots = new RobotsMobile("ro", 4, 2, 4);
//Modification du nom;
string newNom = ModifierNomDuRobot(robots, "ROB");
//passage d'une valeur mais pas une référance de la variable
newNom = "ROBI";
Console.WriteLine($"Le nouveau nom du robot est : {robots.Nom}");
//Procédure pour modifier le nom

static string ModifierNomDuRobot(RobotsMobile robot, string nouveauNom)
{
    robot.ModifieNom(nouveauNom);
    return nouveauNom;
}
//initialisation de deux int(entier)
int inta = 5;
int intb = 10;

Console.WriteLine($"Avant l'échange : a ={inta} b ={intb}");
//échange de valeurs 
EchangerValeurs(ref inta, ref intb);

Console.WriteLine($"Après l'échange : a ={inta} b ={intb}");
//Procédure pour échanger les valeurs de dexu entiers
static void EchangerValeurs(ref int x, ref int y)
{
    int temp = x; 
    x = y; 
    y = temp;
}
Console.ReadLine();