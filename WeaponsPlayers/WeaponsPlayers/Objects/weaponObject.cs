using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponsPlayers
{
    public class weaponObject
    {
        public string name;
        int hitpoints;
        double valueBuy;
        double valueSell;

        public weaponObject(string name, int hp, double price, double sellPrice)
        {
            this.name = name;
            this.hitpoints = hp;
            this.valueBuy = price;
            this.valueSell = sellPrice;
        }
    }
}
