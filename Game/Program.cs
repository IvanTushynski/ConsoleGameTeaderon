using Game;
using Game.BattleSystem;
using Game.DropSystem;
using Game.Enemies;
using Game.FarmSystem;
using Game.SaveLoadSystem;
using Game.SkillsSystem;
using Game.TownSystem;

internal class Program
{
    private static void Main(string[] args)
    {

        //#################################################
        //ТЕСТЫ РАБОТОСПОСОБНОСТИ МЕХАНИК ИГРЫ!!!!!!!
        /*int level = 50;

        int valueOne = level > 1 ? 2 + (level - 1) : 2; //Attack +1 all levels, if level == 1, stat == 2!

        int valueTwo = 30 + (level - 1) * 10; //HP

        int valueThree = 20 + ((level - 1) * 2); //Mana

        int valueFour = level > 1 ? 20 * level * 3 : 40; //ExpPerLvl

        int weapon = 10 + ((level - 1) * 2); //weapon damage

        int helmetDef = level > 1 ? 2 + (level - 1) : 1; //+1 all levels, if level == 1, stat == 1!
        int helmetMp = 10 + ((level - 1) * 10);  //Mana Helmet

        int a = level > 1 ? 20 * level * 3 : 40;

        Console.WriteLine(a);*/


        LoadSavePlayer loadSavePlayer = new LoadSavePlayer();
        LoadSaveItems loadSaveItems = new LoadSaveItems();
        LevelUpSystem levelUpSystem = new LevelUpSystem();
        BattlePlayerFreavell battlePlayerFreavell = new BattlePlayerFreavell();
        BattleMonsterFreavell battleMonsterFreavell = new BattleMonsterFreavell();
        EnemyFreavell enemyFreavell = new EnemyFreavell();
        Bottles bottles = new Bottles();
        EnergyFarm energyFarm = new EnergyFarm();
        WeaponAndArmorShop weaponAndArmorShop = new WeaponAndArmorShop();
        DropFreavell drop = new DropFreavell();
        ResourcesFarm resourcesFarm = new ResourcesFarm();
        BerserkSkillFreavell berserkSkillFreavell = new BerserkSkillFreavell();
        TestConsoleBattleFreavell testConsoleBattleFreavell = new TestConsoleBattleFreavell();


        for (int i = 1; i > 0; i++) 
        {
            Console.WriteLine("-----------ТЕСТОВОЕ-МЕНЮ-ТЕАДЕРОНА---------");
            Console.WriteLine("Бой с противником: 1");
            Console.WriteLine("Сброс статов Предметов и Игрока: 2");
            Console.WriteLine("Дроп с босса: 3");
            Console.WriteLine("Использование малой банки HP +20: 4");
            Console.WriteLine("Купить Банки HP/MP: 5");
            Console.WriteLine("Прокачка Персонажа: 6");
            Console.WriteLine("Статистика: 7");
            Console.WriteLine("Фарм Енергии: 8");
            Console.WriteLine("Лавка Оружия и Брони: 9");
            Console.WriteLine("Фарм Ресурсов: 10");
            Console.WriteLine("Выход: 11");
            Console.WriteLine("-------------------------------------------");
            int learn = Convert.ToInt32(Console.ReadLine());
            if (learn == 1)
            {
                testConsoleBattleFreavell.TestBattleOne();
            }
            if (learn == 2)
            {
                loadSavePlayer.ResetPlayerDataBase();
                loadSaveItems.ResetItemDataBase();
            }
            else if (learn == 3)
            {
                MoneyExchange moneyExchange = new MoneyExchange();

                moneyExchange.BronzeToSilver();
                Console.WriteLine("Бронза:" + loadSavePlayer.GetPlayerBronze());
                Console.WriteLine("Серебро:" + loadSavePlayer.GetPlayerSilver());
                Console.WriteLine("Золото:" + loadSavePlayer.GetPlayerGold());
                Console.WriteLine("Алмазы:" + loadSavePlayer.GetPlayerDiamond());

                drop.DropFreavellBossOne();

            }
            else if (learn == 4)
            {
                bottles.UseSmallHpPotion();
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine(loadSavePlayer.GetPlayerHp() + "/" + loadSavePlayer.GetPlayerMaxHp() + ": Здоровье");
                Console.WriteLine(loadSaveItems.GetItemHpSmallPotion() + ": Оставшиеся Малые Банки HP");
                Console.WriteLine(loadSaveItems.GetItemHpNormalPotion() + ": Оставшиеся Средние Банки HP");
                Console.WriteLine(loadSaveItems.GetItemHpLargePotion() + ": Оставшиеся Большие Банки HP");
                Console.WriteLine("--------------------------------------------");
            }
            else if (learn == 5)
            {
                bottles.BuySmallHpPotionPlus();
                bottles.BuyNormalHpPotionPlus();
                bottles.BuyLargeHpPotionPlus();
                bottles.BuySmallMpPotionPlus();
                bottles.BuyNormalMpPotionPlus();
                bottles.BuyLargeMpPotionPlus();
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine(loadSaveItems.GetItemHpSmallPotion() + ": Оставшиеся Малые Банки HP");
                Console.WriteLine(loadSaveItems.GetItemHpNormalPotion() + ": Оставшиеся Средние Банки HP");
                Console.WriteLine(loadSaveItems.GetItemHpLargePotion() + ": Оставшиеся Большие Банки HP");
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine(loadSaveItems.GetItemMpSmallPotion() + ": Оставшиеся Малые Банки MP");
                Console.WriteLine(loadSaveItems.GetItemMpNormalPotion() + ": Оставшиеся Средние Банки MP");
                Console.WriteLine(loadSaveItems.GetItemMpLargePotion() + ": Оставшиеся Большие Банки MP");
                Console.WriteLine("--------------------------------------------");
            }
            else if (learn == 6)
            {
                levelUpSystem.RecordPlayerExpAmount();
                levelUpSystem.RecordPlayerLevelUp();
                Console.WriteLine(loadSavePlayer.GetPlayerLevel() + ": Уровень");
                Thread.Sleep(50);
            }
            else if (learn == 7)
            {
                Console.WriteLine("-----------------Статистика-----------------");
                Console.WriteLine(loadSavePlayer.GetPlayerLevel() + ": Уровень Игрока");
                Console.WriteLine(loadSavePlayer.GetPlayerExpAmount() + "/" + loadSavePlayer.GetPlayerExpForNextLvl() + ": Опыт");
                Console.WriteLine(loadSavePlayer.GetPlayerLevelFarm() + ": Уровень Профессий");
                Console.WriteLine(loadSavePlayer.GetPlayerExpAmountFarm() + "/" + loadSavePlayer.GetPlayerExpForNextLvlFarm() + ": Опыт Профессий");
                Console.WriteLine(loadSavePlayer.GetPlayerAttack() + ": Уровень атаки");
                Console.WriteLine(loadSavePlayer.GetPlayerDefense() + ": Защита");
                Console.WriteLine(loadSavePlayer.GetPlayerHp() + "/" + loadSavePlayer.GetPlayerMaxHp() + ": Здоровье");
                Console.WriteLine(loadSavePlayer.GetPlayerMp() + "/" + loadSavePlayer.GetPlayerMaxMp() + ": Мана");
                Console.WriteLine(loadSavePlayer.GetPlayerCrit() + "%: Крит урон");
                Console.WriteLine(loadSavePlayer.GetPlayerDodge() + "%: Уворот");
                Console.WriteLine(loadSaveItems.GetItemHpSmallPotion() + ": Оставшиеся Малые Банки HP");
                Console.WriteLine(loadSaveItems.GetItemHpNormalPotion() + ": Оставшиеся Средние Банки HP");
                Console.WriteLine(loadSaveItems.GetItemHpLargePotion() + ": Оставшиеся Большие Банки HP");
                Console.WriteLine(loadSaveItems.GetItemMpSmallPotion() + ": Оставшиеся Малые Банки MP");
                Console.WriteLine(loadSaveItems.GetItemMpNormalPotion() + ": Оставшиеся Средние Банки MP");
                Console.WriteLine(loadSaveItems.GetItemMpLargePotion() + ": Оставшиеся Большие Банки MP");
                Console.WriteLine(loadSavePlayer.GetPlayerEnergy() + " Очков Енергии");
                Console.WriteLine("Бронза:" + loadSavePlayer.GetPlayerBronze());
                Console.WriteLine("Серебро:" + loadSavePlayer.GetPlayerSilver());
                Console.WriteLine("Золото:" + loadSavePlayer.GetPlayerGold());
                Console.WriteLine("Алмазы:" + loadSavePlayer.GetPlayerDiamond());
                Console.WriteLine("--------------------------------------------");
            }
            else if (learn == 8)
            {
                energyFarm.EnergyFarmOne();
            }
            else if (learn == 9)
            {
                weaponAndArmorShop.ArmorShop();
            }
            else if (learn == 10)
            {
                resourcesFarm.ResourcesFarmOne();
            }
            else if (learn == 11)
            {
                break;
            }
            else
            {
                Console.WriteLine("-------------------Неверная Цифра-------------------------");
            }
        }

    }
}