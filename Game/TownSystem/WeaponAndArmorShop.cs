using Game.WeaponAndArmorSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.TownSystem
{
    internal class WeaponAndArmorShop
    {
        public void ArmorShop()
        {
            WeaponSystem weaponSystem = new WeaponSystem();

            for (int i = 1; i > 0; i++)
            {
                Console.WriteLine("-----------Лавка Брони и Оружия---------");
                Console.WriteLine("Покупка Оружия: 1");
                Console.WriteLine("Выход: 2");
                Console.WriteLine("-------------------------------------------");
                int learn = Convert.ToInt32(Console.ReadLine());
                if (learn == 1)
                {
                    weaponSystem.WeaponLevelCheckOne();
                }
                else if (learn == 2)
                {
                    break;
                }
            }
        }
    }
}
