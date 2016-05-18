using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponsPlayers
{
    class Program
    {
        static void Main(string[] args)
        {
            weaponObject sword = new weaponObject("sword", 150, 100, 60);
            weaponObject hammer = new weaponObject("Hammer", 170, 120, 70);
            weaponObject axe = new weaponObject("Axe", 190, 170, 115);
            weaponObject pistol = new weaponObject("Pistol", 155, 160, 95);
            weaponObject boomstick = new weaponObject("Boomstick", 200, 185, 110);
            weaponObject bfg = new weaponObject("BFG", 250, 280, 190);
            weaponObject brassKnuckles = new weaponObject("Brass Knuckles", 130, 50, 30.5);
            weaponObject whip = new weaponObject("Whip", 140, 80, 40);
            weaponObject chainWhip = new weaponObject("Chain Whip", 170, 110, 85);

            List<weaponObject> fighterInv = new List<weaponObject>();
            List<weaponObject> gunnerInv = new List<weaponObject>();
            List<weaponObject> meleeInv = new List<weaponObject>();

            playerObject Fighter = new playerObject("Swordman", 3, fighterInv);
            playerObject Gunner = new playerObject("Shootman", 2, gunnerInv);
            playerObject Melee = new playerObject("Punch/whip-man", 1, meleeInv);

            Fighter.makeInv(sword, axe, hammer);         
            Gunner.makeInv(pistol, boomstick, bfg);
            Melee.makeInv(brassKnuckles, whip, chainWhip);

        
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
                Console.WriteLine("And has: ");
                Console.Write(x.lives);
                Console.Write(" lives.");
            }
            Console.ReadLine();
        }
    }
}