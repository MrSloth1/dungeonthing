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
    
    //https://docs.microsoft.com/de-de/dotnet/api/system.linq.enumerable?view=netframework-4.8
    //https://www.tutorialspoint.com/csharp/csharp_enums.htm
    //https://www.tutorialspoint.com/csharp/csharp_struct.htm
}
