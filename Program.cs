using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            weaponObject sword = new weaponObject();
            weaponObject.createWeapon(sword, "Sword", 150, 100, 60);
            weaponObject hammer = new weaponObject();
            weaponObject.createWeapon(hammer, "Hammer", 170, 120, 70);
            weaponObject axe = new weaponObject();
            weaponObject.createWeapon(axe,"Axe", 190, 170, 115);
            weaponObject pistol = new weaponObject();
            weaponObject.createWeapon(pistol, "Pistol", 155, 160, 95);
            weaponObject boomstick = new weaponObject();
            weaponObject.createWeapon(boomstick, "Boomstick", 200, 185, 110);
            weaponObject bfg = new weaponObject();
            weaponObject.createWeapon(bfg, "BFG", 250, 280, 190);
            weaponObject brassKnuckles = new weaponObject();
            weaponObject.createWeapon(brassKnuckles, "Brass Knuckles", 130, 50, 30.5);
            weaponObject whip = new weaponObject();
            weaponObject.createWeapon(whip, "Whip", 140, 80, 40);
            weaponObject chainWhip = new weaponObject();
            weaponObject.createWeapon(chainWhip, "Chain Whip", 170, 110, 85);

            playerObject Fighter = new playerObject();
            playerObject Gunner = new playerObject();
            playerObject Melee = new playerObject();

            List<weaponObject> fighterInv = new List<weaponObject>();
            List<weaponObject> gunnerInv = new List<weaponObject>();
            List<weaponObject> meleeInv = new List<weaponObject>();

            playerObject.makeInv(fighterInv, sword, axe, hammer);
            playerObject.makeInv(gunnerInv, pistol, boomstick, bfg);
            playerObject.makeInv(meleeInv, brassKnuckles, whip, chainWhip);


            playerObject.createPlayer(Fighter, "Swordman", 3, fighterInv);
            playerObject.createPlayer(Gunner, "Shootman", 2, gunnerInv);
            playerObject.createPlayer(Melee, "Punch/whip-man", 1, meleeInv);

            List<playerObject> players = new List<playerObject>();
            players.Add(Fighter);
            players.Add(Gunner);
            players.Add(Melee);

            foreach(playerObject x in players)
            {
                Console.ReadLine();
                Console.Write(x.name);
                Console.Write(" is carrying:");
                Console.WriteLine();
                foreach(weaponObject w in x.inventory)
                {
                    Console.WriteLine(w.name);
                }
            }
            Console.ReadLine();
        }
    }
}