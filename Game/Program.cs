using Game;
using Game.BattleSystem;
using Game.Enemies;
using Game.FarmSystem;
using Game.SaveLoadSystem;

internal class Program
{
    private static void Main(string[] args)
    {


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


        for (int i = 1; i > 0; i++) 
        {
            Console.WriteLine("-----------ТЕСТОВОЕ-МЕНЮ-ТЕАДЕРОНА---------");
            Console.WriteLine("Бой с противником: 1");
            Console.WriteLine("Сброс статов Предметов и Игрока: 2");
            Console.WriteLine("Увеличение Уровня Оружия и Брони: 3");
            Console.WriteLine("Использование малой банки HP +20: 4");
            Console.WriteLine("Купить Банки HP: 5");
            Console.WriteLine("Прокачка Персонажа: 6");
            Console.WriteLine("Статистика: 7");
            Console.WriteLine("Фарм Енергии: 8");
            Console.WriteLine("Выход: 9");
            Console.WriteLine("-------------------------------------------");
            int learn = Convert.ToInt32(Console.ReadLine());
            if (learn == 1)
            {
                for (int iTwo = 1; iTwo > 0; iTwo++)
                {
                    Console.WriteLine("-----------ТЕСТОВОЕ-МЕНЮ-БИТВЫ---------");
                    Console.WriteLine(loadSavePlayer.GetPlayerHp() + "/" + loadSavePlayer.GetPlayerMaxHp() + ": Здоровье игрока");
                    Console.WriteLine(loadSaveItems.GetItemHpSmallPotion() + ": Оставшиеся Малые Банки HP");
                    Console.WriteLine(loadSaveItems.GetItemHpNormalPotion() + ": Оставшиеся Средние Банки HP");
                    Console.WriteLine(loadSaveItems.GetItemHpLargePotion() + ": Оставшиеся Большие Банки HP");
                    Console.WriteLine("-------------------------------------------");
                    Console.WriteLine("Атака: 1");
                    Console.WriteLine("Бонка НР: 2");
                    Console.WriteLine("Выход: 3");
                    Console.WriteLine("-------------------------------------------");
                    int learnBattle = Convert.ToInt32(Console.ReadLine());
                    if (learnBattle == 1)
                    {
                        battlePlayerFreavell.AttackEnemyFreavellOne();
                        Thread.Sleep(2000);
                        battleMonsterFreavell.AttackEnemyFreavellOne();
                    }
                    else if (learnBattle == 2)
                    {
                        bottles.UseSmallHpPotion();
                        Thread.Sleep(2000);
                        if (battleMonsterFreavell.GetEnemyHp() > 0)
                        {
                            battleMonsterFreavell.AttackEnemyFreavellOne();
                        }
                        else
                        {

                        }
                    }
                    else if (learnBattle == 3)
                    {
                        battleMonsterFreavell.RecordEnemyHpFreavellOne();
                        break;
                    }
                }
            }
            if (learn == 2)
            {
                loadSavePlayer.ResetPlayerDataBase();
                loadSaveItems.ResetItemDataBase();
            }
            else if (learn == 3)
            {
                loadSaveItems.RecordPlayerWeaponAttack();
                Thread.Sleep(50);
                loadSaveItems.RecordPlayerHelmetStats();
                Thread.Sleep(50);
                loadSaveItems.RecordPlayerArmorStats();
                Thread.Sleep(50);
                loadSaveItems.RecordPlayerPantsStats();
                Thread.Sleep(50);
                loadSaveItems.RecordPlayerBootsStats();
                Thread.Sleep(50);
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine(loadSaveItems.GetItemSword() + ": Уровень Оружия");
                Console.WriteLine(loadSaveItems.GetItemHelmet() + ": Уровень Шлема");
                Console.WriteLine(loadSaveItems.GetItemArmor() + ": Уровень Брони");
                Console.WriteLine(loadSaveItems.GetItemPants() + ": Уровень Штанов");
                Console.WriteLine(loadSaveItems.GetItemBoots() + ": Уровень Ботинок");
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine(loadSavePlayer.GetPlayerAttack() + ": Уровень атаки");
                Console.WriteLine(loadSavePlayer.GetPlayerDefense() + ": Защита");
                Console.WriteLine(loadSavePlayer.GetPlayerHp() + "/" + loadSavePlayer.GetPlayerMaxHp() + ": Здоровье");
                Console.WriteLine(loadSavePlayer.GetPlayerMp() + "/" + loadSavePlayer.GetPlayerMaxMp() + ": Мана");
                Console.WriteLine(loadSavePlayer.GetPlayerCrit() + "%: Крит урон");
                Console.WriteLine(loadSavePlayer.GetPlayerDodge() + "%: Уворот");

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
                bottles.RecordSmallHpPotionPlus();
                bottles.RecordNormalHpPotionPlus();
                bottles.RecordLargeHpPotionPlus();
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine(loadSaveItems.GetItemHpSmallPotion() + ": Оставшиеся Малые Банки HP");
                Console.WriteLine(loadSaveItems.GetItemHpNormalPotion() + ": Оставшиеся Средние Банки HP");
                Console.WriteLine(loadSaveItems.GetItemHpLargePotion() + ": Оставшиеся Большие Банки HP");
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
                Console.WriteLine(loadSavePlayer.GetPlayerAttack() + ": Уровень атаки");
                Console.WriteLine(loadSavePlayer.GetPlayerDefense() + ": Защита");
                Console.WriteLine(loadSavePlayer.GetPlayerHp() + "/" + loadSavePlayer.GetPlayerMaxHp() + ": Здоровье");
                Console.WriteLine(loadSavePlayer.GetPlayerMp() + "/" + loadSavePlayer.GetPlayerMaxMp() + ": Мана");
                Console.WriteLine(loadSavePlayer.GetPlayerCrit() + "%: Крит урон");
                Console.WriteLine(loadSavePlayer.GetPlayerDodge() + "%: Уворот");
                Console.WriteLine(loadSaveItems.GetItemHpSmallPotion() + ": Оставшиеся Банки");
                Console.WriteLine(loadSavePlayer.GetPlayerEnergy() + " Очков Енергии");
                Console.WriteLine("--------------------------------------------");
            }
            else if (learn == 8)
            {
                energyFarm.EnergyFarmOne();
            }
            else if (learn == 9)
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