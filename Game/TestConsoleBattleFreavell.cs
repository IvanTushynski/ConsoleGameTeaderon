using Game.BattleSystem;
using Game.DropSystem;
using Game.Enemies;
using Game.FarmSystem;
using Game.SaveLoadSystem;
using Game.SkillsSystem;
using Game.TownSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class TestConsoleBattleFreavell
    {
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

        public void TestBattleOne()
        {
            for (int iTwo = 1; iTwo > 0; iTwo++)
            {
                Console.WriteLine("-----------ТЕСТОВОЕ-МЕНЮ-БИТВЫ---------");
                Console.WriteLine(loadSavePlayer.GetPlayerHp() + "/" + loadSavePlayer.GetPlayerMaxHp() + ": Здоровье игрока");
                Console.WriteLine(loadSavePlayer.GetPlayerMp() + "/" + loadSavePlayer.GetPlayerMaxMp() + ": Мана игрока");
                Console.WriteLine(loadSaveItems.GetItemHpSmallPotion() + ": Малые Банки HP");
                Console.WriteLine(loadSaveItems.GetItemHpNormalPotion() + ": Средние Банки HP");
                Console.WriteLine(loadSaveItems.GetItemHpLargePotion() + ": Большие Банки HP");
                Console.WriteLine(loadSaveItems.GetItemMpSmallPotion() + ": Малые Банки MP");
                Console.WriteLine(loadSaveItems.GetItemMpNormalPotion() + ": Средние Банки MP");
                Console.WriteLine(loadSaveItems.GetItemMpLargePotion() + ": Большие Банки MP");
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("Атака: 1");
                Console.WriteLine("Удар Берсерка: 2");
                Console.WriteLine("Малая Банка HP: 3");
                Console.WriteLine("Малая Банка MP: 4");
                Console.WriteLine("Выход: 5");
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
                    berserkSkillFreavell.BerserkSkillFreavellOne();
                    Thread.Sleep(2000);
                    battleMonsterFreavell.AttackEnemyFreavellOne();
                }
                else if (learnBattle == 3)
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
                else if (learnBattle == 4)
                {
                    bottles.UseSmallMpPotion();
                    Thread.Sleep(2000);
                    if (battleMonsterFreavell.GetEnemyHp() > 0)
                    {
                        battleMonsterFreavell.AttackEnemyFreavellOne();
                    }
                    else
                    {

                    }
                }
                else if (learnBattle == 5)
                {
                    battleMonsterFreavell.RecordEnemyHpFreavellOne();
                    break;
                }
            }
        }
    }
}
