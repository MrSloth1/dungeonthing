using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonSkr
{
    abstract class Item
    {
       
    }
    struct WeaponClass
    {
        string Name;
        string Type;
        string Description;
        string leonstinktheftig
    }
    abstract class Consumables : Item
    {

    }
    abstract class Weapons : Item
    {
        struct WeaponClass { };
    }
    abstract class Augment : Item
    {

    }
    abstract class Wearables : Item
    {

    }
    

}
