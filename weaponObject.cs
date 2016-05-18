using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    public class weaponObject
    {
        public string name;
        int hitpoints;
        double valueBuy;
        double valueSell;

        
        public static void createWeapon(weaponObject weap, string name, int hp, double price, double sellPrice)
        {
            weap.name = name;
            weap.hitpoints = hp;
            weap.valueBuy = price;
            weap.valueSell = sellPrice;
        }
    }
}
