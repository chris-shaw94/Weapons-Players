using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    public class playerObject
    {
        public string name;
        int lives;
        public List<weaponObject> inventory; 
        public static void makeInv(List<weaponObject> playerInv, weaponObject weap1, weaponObject weap2, weaponObject weap3)
        {
            playerInv.Add(weap1);
            playerInv.Add(weap2);
            playerInv.Add(weap3);
        }
        public static void createPlayer(playerObject player, string name, int lives, List<weaponObject> inventory)
        {
            player.name = name;
            player.lives = lives;
            player.inventory = inventory;
        }
    }
}
