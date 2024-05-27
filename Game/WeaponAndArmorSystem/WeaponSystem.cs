using Game.Enemies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.WeaponAndArmorSystem
{
    internal class WeaponSystem
    {

        LoadSaveItems loadSaveItems = new LoadSaveItems();
        LoadSavePlayer loadSavePlayer = new LoadSavePlayer();

        public void WeaponLevelCheckOne()
        {
            //##########################################################################################################################
            //---------------------------------------------------------повышение до 1 уровня--------------------------------------------
            if (loadSaveItems.GetItemSword() == 0 && loadSavePlayer.GetPlayerLevel() >= 10)
            {
                //проверка на алмазы серебро и ресурсы!!!
                if (loadSavePlayer.GetPlayerDiamond() >= 2 && loadSavePlayer.GetPlayerSilver() >= 1 && loadSavePlayer.GetPlayerResources() >= 10)
                {
                    //Повышение уровня предмета!!!
                    loadSaveItems.RecordPlayerWeaponAttack();
                    Console.WriteLine($"Теперь уровень оружия {loadSaveItems.GetItemSword()}");

                    //уменьшение diamond -2
                    int DiamondMinus = loadSavePlayer.GetPlayerDiamond() - 2;
                    string directoryPathTwo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathTwo = Path.Combine(directoryPathTwo, "gameplayerdata.txt");
                    string[] linesTwo = File.ReadAllLines(filePathTwo);
                    linesTwo[13] = DiamondMinus.ToString();
                    File.WriteAllLines(filePathTwo, linesTwo);
                    Console.WriteLine("Потрачено: " + DiamondMinus + " Алмазов");

                    //уменьшение silver -1
                    int SilverMinus = loadSavePlayer.GetPlayerSilver() - 1;
                    string directoryPathThree = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathThree = Path.Combine(directoryPathThree, "gameplayerdata.txt");
                    string[] linesThree = File.ReadAllLines(filePathThree);
                    linesThree[11] = SilverMinus.ToString();
                    File.WriteAllLines(filePathThree, linesThree);
                    Console.WriteLine("Потрачено: " + SilverMinus + " Серебра");

                    //уменьшение Resources -10
                    int ResourcesMinus = loadSavePlayer.GetPlayerResources() - 10;
                    string directoryPathFour = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathFour = Path.Combine(directoryPathFour, "gameplayerdata.txt");
                    string[] linesFour = File.ReadAllLines(filePathFour);
                    linesFour[15] = ResourcesMinus.ToString();
                    File.WriteAllLines(filePathFour, linesFour);
                    Console.WriteLine("Потрачено: " + ResourcesMinus + " Ресурсов");
                }
                else
                {
                    Console.WriteLine("Необходимо 2 алмаза и 1 сербрянная монета и 10 ресурсов для повышения уровня");
                }
            }
            //##########################################################################################################################
            //---------------------------------------------------------повышение до 2 уровня--------------------------------------------
            else if (loadSaveItems.GetItemSword() == 1 && loadSavePlayer.GetPlayerLevel() >= 12)
            {
                //проверка на алмазы серебро и ресурсы!!!
                if (loadSavePlayer.GetPlayerDiamond() >= 4 && loadSavePlayer.GetPlayerSilver() >= 2 && loadSavePlayer.GetPlayerResources() >= 20)
                {
                    //Повышение уровня предмета!!!
                    loadSaveItems.RecordPlayerWeaponAttack();
                    Console.WriteLine($"Теперь уровень оружия {loadSaveItems.GetItemSword()}");

                    //уменьшение diamond -4
                    int DiamondMinus = loadSavePlayer.GetPlayerDiamond() - 4;
                    string directoryPathTwo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathTwo = Path.Combine(directoryPathTwo, "gameplayerdata.txt");
                    string[] linesTwo = File.ReadAllLines(filePathTwo);
                    linesTwo[13] = DiamondMinus.ToString();
                    File.WriteAllLines(filePathTwo, linesTwo);
                    Console.WriteLine("Потрачено: " + DiamondMinus + " Алмазов");

                    //уменьшение silver -2
                    int SilverMinus = loadSavePlayer.GetPlayerSilver() - 2;
                    string directoryPathThree = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathThree = Path.Combine(directoryPathThree, "gameplayerdata.txt");
                    string[] linesThree = File.ReadAllLines(filePathThree);
                    linesThree[11] = SilverMinus.ToString();
                    File.WriteAllLines(filePathThree, linesThree);
                    Console.WriteLine("Потрачено: " + SilverMinus + " Серебра");

                    //уменьшение Resources -20
                    int ResourcesMinus = loadSavePlayer.GetPlayerResources() - 20;
                    string directoryPathFour = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathFour = Path.Combine(directoryPathFour, "gameplayerdata.txt");
                    string[] linesFour = File.ReadAllLines(filePathFour);
                    linesFour[15] = ResourcesMinus.ToString();
                    File.WriteAllLines(filePathFour, linesFour);
                    Console.WriteLine("Потрачено: " + ResourcesMinus + " Ресурсов");
                }
                else
                {
                    Console.WriteLine("Необходимо 4 алмаза и 2 сербрянная монета и 20 ресурсов для повышения уровня");
                }
            }
            //##########################################################################################################################
            //---------------------------------------------------------повышение до 3 уровня--------------------------------------------
            else if (loadSaveItems.GetItemSword() == 2 && loadSavePlayer.GetPlayerLevel() >= 14)
            {
                //проверка на алмазы серебро и ресурсы!!!
                if (loadSavePlayer.GetPlayerDiamond() >= 6 && loadSavePlayer.GetPlayerSilver() >= 3 && loadSavePlayer.GetPlayerResources() >= 30)
                {
                    //Повышение уровня предмета!!!
                    loadSaveItems.RecordPlayerWeaponAttack();
                    Console.WriteLine($"Теперь уровень оружия {loadSaveItems.GetItemSword()}");

                    //уменьшение diamond -6
                    int DiamondMinus = loadSavePlayer.GetPlayerDiamond() - 6;
                    string directoryPathTwo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathTwo = Path.Combine(directoryPathTwo, "gameplayerdata.txt");
                    string[] linesTwo = File.ReadAllLines(filePathTwo);
                    linesTwo[13] = DiamondMinus.ToString();
                    File.WriteAllLines(filePathTwo, linesTwo);
                    Console.WriteLine("Потрачено: " + DiamondMinus + " Алмазов");

                    //уменьшение silver -3
                    int SilverMinus = loadSavePlayer.GetPlayerSilver() - 3;
                    string directoryPathThree = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathThree = Path.Combine(directoryPathThree, "gameplayerdata.txt");
                    string[] linesThree = File.ReadAllLines(filePathThree);
                    linesThree[11] = SilverMinus.ToString();
                    File.WriteAllLines(filePathThree, linesThree);
                    Console.WriteLine("Потрачено: " + SilverMinus + " Серебра");

                    //уменьшение Resources -30
                    int ResourcesMinus = loadSavePlayer.GetPlayerResources() - 30;
                    string directoryPathFour = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathFour = Path.Combine(directoryPathFour, "gameplayerdata.txt");
                    string[] linesFour = File.ReadAllLines(filePathFour);
                    linesFour[15] = ResourcesMinus.ToString();
                    File.WriteAllLines(filePathFour, linesFour);
                    Console.WriteLine("Потрачено: " + ResourcesMinus + " Ресурсов");
                }
                else
                {
                    Console.WriteLine("Необходимо 6 алмаза и 3 сербрянная монета и 30 ресурсов для повышения уровня");
                }
            }
            //##########################################################################################################################
            //---------------------------------------------------------повышение до 4 уровня--------------------------------------------
            else if (loadSaveItems.GetItemSword() == 3 && loadSavePlayer.GetPlayerLevel() >= 16)
            {
                //проверка на алмазы серебро и ресурсы!!!
                if (loadSavePlayer.GetPlayerDiamond() >= 8 && loadSavePlayer.GetPlayerSilver() >= 4 && loadSavePlayer.GetPlayerResources() >= 40)
                {
                    //Повышение уровня предмета!!!
                    loadSaveItems.RecordPlayerWeaponAttack();
                    Console.WriteLine($"Теперь уровень оружия {loadSaveItems.GetItemSword()}");

                    //уменьшение diamond -8
                    int DiamondMinus = loadSavePlayer.GetPlayerDiamond() - 8;
                    string directoryPathTwo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathTwo = Path.Combine(directoryPathTwo, "gameplayerdata.txt");
                    string[] linesTwo = File.ReadAllLines(filePathTwo);
                    linesTwo[13] = DiamondMinus.ToString();
                    File.WriteAllLines(filePathTwo, linesTwo);
                    Console.WriteLine("Потрачено: " + DiamondMinus + " Алмазов");

                    //уменьшение silver -4
                    int SilverMinus = loadSavePlayer.GetPlayerSilver() - 4;
                    string directoryPathThree = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathThree = Path.Combine(directoryPathThree, "gameplayerdata.txt");
                    string[] linesThree = File.ReadAllLines(filePathThree);
                    linesThree[11] = SilverMinus.ToString();
                    File.WriteAllLines(filePathThree, linesThree);
                    Console.WriteLine("Потрачено: " + SilverMinus + " Серебра");

                    //уменьшение Resources -40
                    int ResourcesMinus = loadSavePlayer.GetPlayerResources() - 40;
                    string directoryPathFour = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathFour = Path.Combine(directoryPathFour, "gameplayerdata.txt");
                    string[] linesFour = File.ReadAllLines(filePathFour);
                    linesFour[15] = ResourcesMinus.ToString();
                    File.WriteAllLines(filePathFour, linesFour);
                    Console.WriteLine("Потрачено: " + ResourcesMinus + " Ресурсов");
                }
                else
                {
                    Console.WriteLine("Необходимо 8 алмаза и 4 сербрянная монета и 40 ресурсов для повышения уровня");
                }
            }
            //##########################################################################################################################
            //---------------------------------------------------------повышение до 5 уровня--------------------------------------------
            else if (loadSaveItems.GetItemSword() == 4 && loadSavePlayer.GetPlayerLevel() >= 18)
            {
                //проверка на алмазы серебро и ресурсы!!!
                if (loadSavePlayer.GetPlayerDiamond() >= 10 && loadSavePlayer.GetPlayerSilver() >= 5 && loadSavePlayer.GetPlayerResources() >= 50)
                {
                    //Повышение уровня предмета!!!
                    loadSaveItems.RecordPlayerWeaponAttack();
                    Console.WriteLine($"Теперь уровень оружия {loadSaveItems.GetItemSword()}");

                    //уменьшение diamond -10
                    int DiamondMinus = loadSavePlayer.GetPlayerDiamond() - 10;
                    string directoryPathTwo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathTwo = Path.Combine(directoryPathTwo, "gameplayerdata.txt");
                    string[] linesTwo = File.ReadAllLines(filePathTwo);
                    linesTwo[13] = DiamondMinus.ToString();
                    File.WriteAllLines(filePathTwo, linesTwo);
                    Console.WriteLine("Потрачено: " + DiamondMinus + " Алмазов");

                    //уменьшение silver -5
                    int SilverMinus = loadSavePlayer.GetPlayerSilver() - 5;
                    string directoryPathThree = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathThree = Path.Combine(directoryPathThree, "gameplayerdata.txt");
                    string[] linesThree = File.ReadAllLines(filePathThree);
                    linesThree[11] = SilverMinus.ToString();
                    File.WriteAllLines(filePathThree, linesThree);
                    Console.WriteLine("Потрачено: " + SilverMinus + " Серебра");

                    //уменьшение Resources -50
                    int ResourcesMinus = loadSavePlayer.GetPlayerResources() - 50;
                    string directoryPathFour = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathFour = Path.Combine(directoryPathFour, "gameplayerdata.txt");
                    string[] linesFour = File.ReadAllLines(filePathFour);
                    linesFour[15] = ResourcesMinus.ToString();
                    File.WriteAllLines(filePathFour, linesFour);
                    Console.WriteLine("Потрачено: " + ResourcesMinus + " Ресурсов");
                }
                else
                {
                    Console.WriteLine("Необходимо 10 алмаза и 5 сербрянная монета и 50 ресурсов для повышения уровня");
                }
            }
            //##########################################################################################################################
            //---------------------------------------------------------повышение до 6 уровня--------------------------------------------
            else if (loadSaveItems.GetItemSword() == 5 && loadSavePlayer.GetPlayerLevel() >= 20)
            {
                //проверка на алмазы серебро и ресурсы!!!
                if (loadSavePlayer.GetPlayerDiamond() >= 12 && loadSavePlayer.GetPlayerSilver() >= 6 && loadSavePlayer.GetPlayerResources() >= 60)
                {
                    //Повышение уровня предмета!!!
                    loadSaveItems.RecordPlayerWeaponAttack();
                    Console.WriteLine($"Теперь уровень оружия {loadSaveItems.GetItemSword()}");

                    //уменьшение diamond -12
                    int DiamondMinus = loadSavePlayer.GetPlayerDiamond() - 12;
                    string directoryPathTwo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathTwo = Path.Combine(directoryPathTwo, "gameplayerdata.txt");
                    string[] linesTwo = File.ReadAllLines(filePathTwo);
                    linesTwo[13] = DiamondMinus.ToString();
                    File.WriteAllLines(filePathTwo, linesTwo);
                    Console.WriteLine("Потрачено: " + DiamondMinus + " Алмазов");

                    //уменьшение silver -6
                    int SilverMinus = loadSavePlayer.GetPlayerSilver() - 6;
                    string directoryPathThree = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathThree = Path.Combine(directoryPathThree, "gameplayerdata.txt");
                    string[] linesThree = File.ReadAllLines(filePathThree);
                    linesThree[11] = SilverMinus.ToString();
                    File.WriteAllLines(filePathThree, linesThree);
                    Console.WriteLine("Потрачено: " + SilverMinus + " Серебра");

                    //уменьшение Resources -60
                    int ResourcesMinus = loadSavePlayer.GetPlayerResources() - 60;
                    string directoryPathFour = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathFour = Path.Combine(directoryPathFour, "gameplayerdata.txt");
                    string[] linesFour = File.ReadAllLines(filePathFour);
                    linesFour[15] = ResourcesMinus.ToString();
                    File.WriteAllLines(filePathFour, linesFour);
                    Console.WriteLine("Потрачено: " + ResourcesMinus + " Ресурсов");
                }
                else
                {
                    Console.WriteLine("Необходимо 12 алмаза и 6 сербрянная монета и 60 ресурсов для повышения уровня");
                }
            }
            //##########################################################################################################################
            //---------------------------------------------------------повышение до 7 уровня--------------------------------------------
            else if (loadSaveItems.GetItemSword() == 6 && loadSavePlayer.GetPlayerLevel() >= 22)
            {
                //проверка на алмазы серебро и ресурсы!!!
                if (loadSavePlayer.GetPlayerDiamond() >= 14 && loadSavePlayer.GetPlayerSilver() >= 7 && loadSavePlayer.GetPlayerResources() >= 70)
                {
                    //Повышение уровня предмета!!!
                    loadSaveItems.RecordPlayerWeaponAttack();
                    Console.WriteLine($"Теперь уровень оружия {loadSaveItems.GetItemSword()}");

                    //уменьшение diamond -14
                    int DiamondMinus = loadSavePlayer.GetPlayerDiamond() - 14;
                    string directoryPathTwo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathTwo = Path.Combine(directoryPathTwo, "gameplayerdata.txt");
                    string[] linesTwo = File.ReadAllLines(filePathTwo);
                    linesTwo[13] = DiamondMinus.ToString();
                    File.WriteAllLines(filePathTwo, linesTwo);
                    Console.WriteLine("Потрачено: " + DiamondMinus + " Алмазов");

                    //уменьшение silver -7
                    int SilverMinus = loadSavePlayer.GetPlayerSilver() - 7;
                    string directoryPathThree = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathThree = Path.Combine(directoryPathThree, "gameplayerdata.txt");
                    string[] linesThree = File.ReadAllLines(filePathThree);
                    linesThree[11] = SilverMinus.ToString();
                    File.WriteAllLines(filePathThree, linesThree);
                    Console.WriteLine("Потрачено: " + SilverMinus + " Серебра");

                    //уменьшение Resources -70
                    int ResourcesMinus = loadSavePlayer.GetPlayerResources() - 70;
                    string directoryPathFour = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathFour = Path.Combine(directoryPathFour, "gameplayerdata.txt");
                    string[] linesFour = File.ReadAllLines(filePathFour);
                    linesFour[15] = ResourcesMinus.ToString();
                    File.WriteAllLines(filePathFour, linesFour);
                    Console.WriteLine("Потрачено: " + ResourcesMinus + " Ресурсов");
                }
                else
                {
                    Console.WriteLine("Необходимо 14 алмаза и 7 сербрянная монета и 70 ресурсов для повышения уровня");
                }
            }
            //##########################################################################################################################
            //---------------------------------------------------------повышение до 8 уровня--------------------------------------------
            else if (loadSaveItems.GetItemSword() == 7 && loadSavePlayer.GetPlayerLevel() >= 24)
            {
                //проверка на алмазы серебро и ресурсы!!!
                if (loadSavePlayer.GetPlayerDiamond() >= 16 && loadSavePlayer.GetPlayerSilver() >= 8 && loadSavePlayer.GetPlayerResources() >= 80)
                {
                    //Повышение уровня предмета!!!
                    loadSaveItems.RecordPlayerWeaponAttack();
                    Console.WriteLine($"Теперь уровень оружия {loadSaveItems.GetItemSword()}");

                    //уменьшение diamond -16
                    int DiamondMinus = loadSavePlayer.GetPlayerDiamond() - 16;
                    string directoryPathTwo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathTwo = Path.Combine(directoryPathTwo, "gameplayerdata.txt");
                    string[] linesTwo = File.ReadAllLines(filePathTwo);
                    linesTwo[13] = DiamondMinus.ToString();
                    File.WriteAllLines(filePathTwo, linesTwo);
                    Console.WriteLine("Потрачено: " + DiamondMinus + " Алмазов");

                    //уменьшение silver -8
                    int SilverMinus = loadSavePlayer.GetPlayerSilver() - 8;
                    string directoryPathThree = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathThree = Path.Combine(directoryPathThree, "gameplayerdata.txt");
                    string[] linesThree = File.ReadAllLines(filePathThree);
                    linesThree[11] = SilverMinus.ToString();
                    File.WriteAllLines(filePathThree, linesThree);
                    Console.WriteLine("Потрачено: " + SilverMinus + " Серебра");

                    //уменьшение Resources -80
                    int ResourcesMinus = loadSavePlayer.GetPlayerResources() - 80;
                    string directoryPathFour = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathFour = Path.Combine(directoryPathFour, "gameplayerdata.txt");
                    string[] linesFour = File.ReadAllLines(filePathFour);
                    linesFour[15] = ResourcesMinus.ToString();
                    File.WriteAllLines(filePathFour, linesFour);
                    Console.WriteLine("Потрачено: " + ResourcesMinus + " Ресурсов");
                }
                else
                {
                    Console.WriteLine("Необходимо 16 алмаза и 8 сербрянная монета и 80 ресурсов для повышения уровня");
                }
            }
            //##########################################################################################################################
            //---------------------------------------------------------повышение до 9 уровня--------------------------------------------
            else if (loadSaveItems.GetItemSword() == 8 && loadSavePlayer.GetPlayerLevel() >= 26)
            {
                //проверка на алмазы серебро и ресурсы!!!
                if (loadSavePlayer.GetPlayerDiamond() >= 18 && loadSavePlayer.GetPlayerSilver() >= 9 && loadSavePlayer.GetPlayerResources() >= 90)
                {
                    //Повышение уровня предмета!!!
                    loadSaveItems.RecordPlayerWeaponAttack();
                    Console.WriteLine($"Теперь уровень оружия {loadSaveItems.GetItemSword()}");

                    //уменьшение diamond -18
                    int DiamondMinus = loadSavePlayer.GetPlayerDiamond() - 18;
                    string directoryPathTwo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathTwo = Path.Combine(directoryPathTwo, "gameplayerdata.txt");
                    string[] linesTwo = File.ReadAllLines(filePathTwo);
                    linesTwo[13] = DiamondMinus.ToString();
                    File.WriteAllLines(filePathTwo, linesTwo);
                    Console.WriteLine("Потрачено: " + DiamondMinus + " Алмазов");

                    //уменьшение silver -9
                    int SilverMinus = loadSavePlayer.GetPlayerSilver() - 9;
                    string directoryPathThree = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathThree = Path.Combine(directoryPathThree, "gameplayerdata.txt");
                    string[] linesThree = File.ReadAllLines(filePathThree);
                    linesThree[11] = SilverMinus.ToString();
                    File.WriteAllLines(filePathThree, linesThree);
                    Console.WriteLine("Потрачено: " + SilverMinus + " Серебра");

                    //уменьшение Resources -90
                    int ResourcesMinus = loadSavePlayer.GetPlayerResources() - 90;
                    string directoryPathFour = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathFour = Path.Combine(directoryPathFour, "gameplayerdata.txt");
                    string[] linesFour = File.ReadAllLines(filePathFour);
                    linesFour[15] = ResourcesMinus.ToString();
                    File.WriteAllLines(filePathFour, linesFour);
                    Console.WriteLine("Потрачено: " + ResourcesMinus + " Ресурсов");
                }
                else
                {
                    Console.WriteLine("Необходимо 18 алмаза и 9 сербрянная монета и 90 ресурсов для повышения уровня");
                }
            }
            //##########################################################################################################################
            //---------------------------------------------------------повышение до 10 уровня-------------------------------------------
            else if (loadSaveItems.GetItemSword() == 9 && loadSavePlayer.GetPlayerLevel() >= 28)
            {
                //проверка на алмазы серебро и ресурсы!!!
                if (loadSavePlayer.GetPlayerDiamond() >= 20 && loadSavePlayer.GetPlayerSilver() >= 10 && loadSavePlayer.GetPlayerResources() >= 100)
                {
                    //Повышение уровня предмета!!!
                    loadSaveItems.RecordPlayerWeaponAttack();
                    Console.WriteLine($"Теперь уровень оружия {loadSaveItems.GetItemSword()}");

                    //уменьшение diamond -20
                    int DiamondMinus = loadSavePlayer.GetPlayerDiamond() - 20;
                    string directoryPathTwo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathTwo = Path.Combine(directoryPathTwo, "gameplayerdata.txt");
                    string[] linesTwo = File.ReadAllLines(filePathTwo);
                    linesTwo[13] = DiamondMinus.ToString();
                    File.WriteAllLines(filePathTwo, linesTwo);
                    Console.WriteLine("Потрачено: " + DiamondMinus + " Алмазов");

                    //уменьшение silver -10
                    int SilverMinus = loadSavePlayer.GetPlayerSilver() - 10;
                    string directoryPathThree = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathThree = Path.Combine(directoryPathThree, "gameplayerdata.txt");
                    string[] linesThree = File.ReadAllLines(filePathThree);
                    linesThree[11] = SilverMinus.ToString();
                    File.WriteAllLines(filePathThree, linesThree);
                    Console.WriteLine("Потрачено: " + SilverMinus + " Серебра");

                    //уменьшение Resources -100
                    int ResourcesMinus = loadSavePlayer.GetPlayerResources() - 100;
                    string directoryPathFour = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathFour = Path.Combine(directoryPathFour, "gameplayerdata.txt");
                    string[] linesFour = File.ReadAllLines(filePathFour);
                    linesFour[15] = ResourcesMinus.ToString();
                    File.WriteAllLines(filePathFour, linesFour);
                    Console.WriteLine("Потрачено: " + ResourcesMinus + " Ресурсов");
                }
                else
                {
                    Console.WriteLine("Необходимо 20 алмаза и 10 сербрянная монета и 100 ресурсов для повышения уровня");
                }
            }
            //##########################################################################################################################
            //---------------------------------------------------------повышение до 11 уровня-------------------------------------------
            else if (loadSaveItems.GetItemSword() == 10 && loadSavePlayer.GetPlayerLevel() >= 30)
            {
                //проверка на алмазы серебро и ресурсы!!!
                if (loadSavePlayer.GetPlayerDiamond() >= 22 && loadSavePlayer.GetPlayerSilver() >= 11 && loadSavePlayer.GetPlayerResources() >= 110)
                {
                    //Повышение уровня предмета!!!
                    loadSaveItems.RecordPlayerWeaponAttack();
                    Console.WriteLine($"Теперь уровень оружия {loadSaveItems.GetItemSword()}");

                    //уменьшение diamond -22
                    int DiamondMinus = loadSavePlayer.GetPlayerDiamond() - 22;
                    string directoryPathTwo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathTwo = Path.Combine(directoryPathTwo, "gameplayerdata.txt");
                    string[] linesTwo = File.ReadAllLines(filePathTwo);
                    linesTwo[13] = DiamondMinus.ToString();
                    File.WriteAllLines(filePathTwo, linesTwo);
                    Console.WriteLine("Потрачено: " + DiamondMinus + " Алмазов");

                    //уменьшение silver -11
                    int SilverMinus = loadSavePlayer.GetPlayerSilver() - 11;
                    string directoryPathThree = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathThree = Path.Combine(directoryPathThree, "gameplayerdata.txt");
                    string[] linesThree = File.ReadAllLines(filePathThree);
                    linesThree[11] = SilverMinus.ToString();
                    File.WriteAllLines(filePathThree, linesThree);
                    Console.WriteLine("Потрачено: " + SilverMinus + " Серебра");

                    //уменьшение Resources -110
                    int ResourcesMinus = loadSavePlayer.GetPlayerResources() - 110;
                    string directoryPathFour = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathFour = Path.Combine(directoryPathFour, "gameplayerdata.txt");
                    string[] linesFour = File.ReadAllLines(filePathFour);
                    linesFour[15] = ResourcesMinus.ToString();
                    File.WriteAllLines(filePathFour, linesFour);
                    Console.WriteLine("Потрачено: " + ResourcesMinus + " Ресурсов");
                }
                else
                {
                    Console.WriteLine("Необходимо 22 алмаза и 11 сербрянная монета и 110 ресурсов для повышения уровня");
                }
            }
            //##########################################################################################################################
            //---------------------------------------------------------повышение до 12 уровня-------------------------------------------
            else if (loadSaveItems.GetItemSword() == 11 && loadSavePlayer.GetPlayerLevel() >= 32)
            {
                //проверка на алмазы серебро и ресурсы!!!
                if (loadSavePlayer.GetPlayerDiamond() >= 24 && loadSavePlayer.GetPlayerSilver() >= 12 && loadSavePlayer.GetPlayerResources() >= 120)
                {
                    //Повышение уровня предмета!!!
                    loadSaveItems.RecordPlayerWeaponAttack();
                    Console.WriteLine($"Теперь уровень оружия {loadSaveItems.GetItemSword()}");

                    //уменьшение diamond -24
                    int DiamondMinus = loadSavePlayer.GetPlayerDiamond() - 24;
                    string directoryPathTwo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathTwo = Path.Combine(directoryPathTwo, "gameplayerdata.txt");
                    string[] linesTwo = File.ReadAllLines(filePathTwo);
                    linesTwo[13] = DiamondMinus.ToString();
                    File.WriteAllLines(filePathTwo, linesTwo);
                    Console.WriteLine("Потрачено: " + DiamondMinus + " Алмазов");

                    //уменьшение silver -12
                    int SilverMinus = loadSavePlayer.GetPlayerSilver() - 12;
                    string directoryPathThree = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathThree = Path.Combine(directoryPathThree, "gameplayerdata.txt");
                    string[] linesThree = File.ReadAllLines(filePathThree);
                    linesThree[11] = SilverMinus.ToString();
                    File.WriteAllLines(filePathThree, linesThree);
                    Console.WriteLine("Потрачено: " + SilverMinus + " Серебра");

                    //уменьшение Resources -120
                    int ResourcesMinus = loadSavePlayer.GetPlayerResources() - 120;
                    string directoryPathFour = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathFour = Path.Combine(directoryPathFour, "gameplayerdata.txt");
                    string[] linesFour = File.ReadAllLines(filePathFour);
                    linesFour[15] = ResourcesMinus.ToString();
                    File.WriteAllLines(filePathFour, linesFour);
                    Console.WriteLine("Потрачено: " + ResourcesMinus + " Ресурсов");
                }
                else
                {
                    Console.WriteLine("Необходимо 24 алмаза и 12 сербрянная монета и 120 ресурсов для повышения уровня");
                }
            }
            //##########################################################################################################################
            //---------------------------------------------------------повышение до 13 уровня-------------------------------------------
            else if (loadSaveItems.GetItemSword() == 12 && loadSavePlayer.GetPlayerLevel() >= 34)
            {
                //проверка на алмазы серебро и ресурсы!!!
                if (loadSavePlayer.GetPlayerDiamond() >= 26 && loadSavePlayer.GetPlayerSilver() >= 13 && loadSavePlayer.GetPlayerResources() >= 130)
                {
                    //Повышение уровня предмета!!!
                    loadSaveItems.RecordPlayerWeaponAttack();
                    Console.WriteLine($"Теперь уровень оружия {loadSaveItems.GetItemSword()}");

                    //уменьшение diamond -26
                    int DiamondMinus = loadSavePlayer.GetPlayerDiamond() - 26;
                    string directoryPathTwo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathTwo = Path.Combine(directoryPathTwo, "gameplayerdata.txt");
                    string[] linesTwo = File.ReadAllLines(filePathTwo);
                    linesTwo[13] = DiamondMinus.ToString();
                    File.WriteAllLines(filePathTwo, linesTwo);
                    Console.WriteLine("Потрачено: " + DiamondMinus + " Алмазов");

                    //уменьшение silver -13
                    int SilverMinus = loadSavePlayer.GetPlayerSilver() - 13;
                    string directoryPathThree = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathThree = Path.Combine(directoryPathThree, "gameplayerdata.txt");
                    string[] linesThree = File.ReadAllLines(filePathThree);
                    linesThree[11] = SilverMinus.ToString();
                    File.WriteAllLines(filePathThree, linesThree);
                    Console.WriteLine("Потрачено: " + SilverMinus + " Серебра");

                    //уменьшение Resources -130
                    int ResourcesMinus = loadSavePlayer.GetPlayerResources() - 130;
                    string directoryPathFour = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathFour = Path.Combine(directoryPathFour, "gameplayerdata.txt");
                    string[] linesFour = File.ReadAllLines(filePathFour);
                    linesFour[15] = ResourcesMinus.ToString();
                    File.WriteAllLines(filePathFour, linesFour);
                    Console.WriteLine("Потрачено: " + ResourcesMinus + " Ресурсов");
                }
                else
                {
                    Console.WriteLine("Необходимо 26 алмаза и 13 сербрянная монета и 130 ресурсов для повышения уровня");
                }
            }
            //##########################################################################################################################
            //---------------------------------------------------------повышение до 14 уровня-------------------------------------------
            else if (loadSaveItems.GetItemSword() == 13 && loadSavePlayer.GetPlayerLevel() >= 36)
            {
                //проверка на алмазы серебро и ресурсы!!!
                if (loadSavePlayer.GetPlayerDiamond() >= 28 && loadSavePlayer.GetPlayerSilver() >= 14 && loadSavePlayer.GetPlayerResources() >= 140)
                {
                    //Повышение уровня предмета!!!
                    loadSaveItems.RecordPlayerWeaponAttack();
                    Console.WriteLine($"Теперь уровень оружия {loadSaveItems.GetItemSword()}");

                    //уменьшение diamond -28
                    int DiamondMinus = loadSavePlayer.GetPlayerDiamond() - 28;
                    string directoryPathTwo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathTwo = Path.Combine(directoryPathTwo, "gameplayerdata.txt");
                    string[] linesTwo = File.ReadAllLines(filePathTwo);
                    linesTwo[13] = DiamondMinus.ToString();
                    File.WriteAllLines(filePathTwo, linesTwo);
                    Console.WriteLine("Потрачено: " + DiamondMinus + " Алмазов");

                    //уменьшение silver -14
                    int SilverMinus = loadSavePlayer.GetPlayerSilver() - 14;
                    string directoryPathThree = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathThree = Path.Combine(directoryPathThree, "gameplayerdata.txt");
                    string[] linesThree = File.ReadAllLines(filePathThree);
                    linesThree[11] = SilverMinus.ToString();
                    File.WriteAllLines(filePathThree, linesThree);
                    Console.WriteLine("Потрачено: " + SilverMinus + " Серебра");

                    //уменьшение Resources -140
                    int ResourcesMinus = loadSavePlayer.GetPlayerResources() - 140;
                    string directoryPathFour = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathFour = Path.Combine(directoryPathFour, "gameplayerdata.txt");
                    string[] linesFour = File.ReadAllLines(filePathFour);
                    linesFour[15] = ResourcesMinus.ToString();
                    File.WriteAllLines(filePathFour, linesFour);
                    Console.WriteLine("Потрачено: " + ResourcesMinus + " Ресурсов");
                }
                else
                {
                    Console.WriteLine("Необходимо 28 алмаза и 14 сербрянная монета и 140 ресурсов для повышения уровня");
                }
            }
            //##########################################################################################################################
            //---------------------------------------------------------повышение до 15 уровня-------------------------------------------
            else if (loadSaveItems.GetItemSword() == 14 && loadSavePlayer.GetPlayerLevel() >= 38)
            {
                //проверка на алмазы серебро и ресурсы!!!
                if (loadSavePlayer.GetPlayerDiamond() >= 30 && loadSavePlayer.GetPlayerSilver() >= 15 && loadSavePlayer.GetPlayerResources() >= 150)
                {
                    //Повышение уровня предмета!!!
                    loadSaveItems.RecordPlayerWeaponAttack();
                    Console.WriteLine($"Теперь уровень оружия {loadSaveItems.GetItemSword()}");

                    //уменьшение diamond -30
                    int DiamondMinus = loadSavePlayer.GetPlayerDiamond() - 30;
                    string directoryPathTwo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathTwo = Path.Combine(directoryPathTwo, "gameplayerdata.txt");
                    string[] linesTwo = File.ReadAllLines(filePathTwo);
                    linesTwo[13] = DiamondMinus.ToString();
                    File.WriteAllLines(filePathTwo, linesTwo);
                    Console.WriteLine("Потрачено: " + DiamondMinus + " Алмазов");

                    //уменьшение silver -15
                    int SilverMinus = loadSavePlayer.GetPlayerSilver() - 15;
                    string directoryPathThree = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathThree = Path.Combine(directoryPathThree, "gameplayerdata.txt");
                    string[] linesThree = File.ReadAllLines(filePathThree);
                    linesThree[11] = SilverMinus.ToString();
                    File.WriteAllLines(filePathThree, linesThree);
                    Console.WriteLine("Потрачено: " + SilverMinus + " Серебра");

                    //уменьшение Resources -150
                    int ResourcesMinus = loadSavePlayer.GetPlayerResources() - 150;
                    string directoryPathFour = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathFour = Path.Combine(directoryPathFour, "gameplayerdata.txt");
                    string[] linesFour = File.ReadAllLines(filePathFour);
                    linesFour[15] = ResourcesMinus.ToString();
                    File.WriteAllLines(filePathFour, linesFour);
                    Console.WriteLine("Потрачено: " + ResourcesMinus + " Ресурсов");
                }
                else
                {
                    Console.WriteLine("Необходимо 30 алмаза и 15 сербрянная монета и 150 ресурсов для повышения уровня");
                }
            }
            //##########################################################################################################################
            //---------------------------------------------------------повышение до 16 уровня-------------------------------------------
            else if (loadSaveItems.GetItemSword() == 15 && loadSavePlayer.GetPlayerLevel() >= 40)
            {
                //проверка на алмазы серебро и ресурсы!!!
                if (loadSavePlayer.GetPlayerDiamond() >= 32 && loadSavePlayer.GetPlayerSilver() >= 16 && loadSavePlayer.GetPlayerResources() >= 160)
                {
                    //Повышение уровня предмета!!!
                    loadSaveItems.RecordPlayerWeaponAttack();
                    Console.WriteLine($"Теперь уровень оружия {loadSaveItems.GetItemSword()}");

                    //уменьшение diamond -32
                    int DiamondMinus = loadSavePlayer.GetPlayerDiamond() - 32;
                    string directoryPathTwo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathTwo = Path.Combine(directoryPathTwo, "gameplayerdata.txt");
                    string[] linesTwo = File.ReadAllLines(filePathTwo);
                    linesTwo[13] = DiamondMinus.ToString();
                    File.WriteAllLines(filePathTwo, linesTwo);
                    Console.WriteLine("Потрачено: " + DiamondMinus + " Алмазов");

                    //уменьшение silver -16
                    int SilverMinus = loadSavePlayer.GetPlayerSilver() - 16;
                    string directoryPathThree = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathThree = Path.Combine(directoryPathThree, "gameplayerdata.txt");
                    string[] linesThree = File.ReadAllLines(filePathThree);
                    linesThree[11] = SilverMinus.ToString();
                    File.WriteAllLines(filePathThree, linesThree);
                    Console.WriteLine("Потрачено: " + SilverMinus + " Серебра");

                    //уменьшение Resources -160
                    int ResourcesMinus = loadSavePlayer.GetPlayerResources() - 160;
                    string directoryPathFour = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathFour = Path.Combine(directoryPathFour, "gameplayerdata.txt");
                    string[] linesFour = File.ReadAllLines(filePathFour);
                    linesFour[15] = ResourcesMinus.ToString();
                    File.WriteAllLines(filePathFour, linesFour);
                    Console.WriteLine("Потрачено: " + ResourcesMinus + " Ресурсов");
                }
                else
                {
                    Console.WriteLine("Необходимо 32 алмаза и 16 сербрянная монета и 160 ресурсов для повышения уровня");
                }
            }
            //##########################################################################################################################
            //---------------------------------------------------------повышение до 17 уровня-------------------------------------------
            else if (loadSaveItems.GetItemSword() == 16 && loadSavePlayer.GetPlayerLevel() >= 42)
            {
                //проверка на алмазы серебро и ресурсы!!!
                if (loadSavePlayer.GetPlayerDiamond() >= 34 && loadSavePlayer.GetPlayerSilver() >= 17 && loadSavePlayer.GetPlayerResources() >= 170)
                {
                    //Повышение уровня предмета!!!
                    loadSaveItems.RecordPlayerWeaponAttack();
                    Console.WriteLine($"Теперь уровень оружия {loadSaveItems.GetItemSword()}");

                    //уменьшение diamond -34
                    int DiamondMinus = loadSavePlayer.GetPlayerDiamond() - 34;
                    string directoryPathTwo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathTwo = Path.Combine(directoryPathTwo, "gameplayerdata.txt");
                    string[] linesTwo = File.ReadAllLines(filePathTwo);
                    linesTwo[13] = DiamondMinus.ToString();
                    File.WriteAllLines(filePathTwo, linesTwo);
                    Console.WriteLine("Потрачено: " + DiamondMinus + " Алмазов");

                    //уменьшение silver -17
                    int SilverMinus = loadSavePlayer.GetPlayerSilver() - 17;
                    string directoryPathThree = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathThree = Path.Combine(directoryPathThree, "gameplayerdata.txt");
                    string[] linesThree = File.ReadAllLines(filePathThree);
                    linesThree[11] = SilverMinus.ToString();
                    File.WriteAllLines(filePathThree, linesThree);
                    Console.WriteLine("Потрачено: " + SilverMinus + " Серебра");

                    //уменьшение Resources -170
                    int ResourcesMinus = loadSavePlayer.GetPlayerResources() - 170;
                    string directoryPathFour = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathFour = Path.Combine(directoryPathFour, "gameplayerdata.txt");
                    string[] linesFour = File.ReadAllLines(filePathFour);
                    linesFour[15] = ResourcesMinus.ToString();
                    File.WriteAllLines(filePathFour, linesFour);
                    Console.WriteLine("Потрачено: " + ResourcesMinus + " Ресурсов");
                }
                else
                {
                    Console.WriteLine("Необходимо 34 алмаза и 17 сербрянная монета и 170 ресурсов для повышения уровня");
                }
            }
            //##########################################################################################################################
            //---------------------------------------------------------повышение до 18 уровня-------------------------------------------
            else if (loadSaveItems.GetItemSword() == 17 && loadSavePlayer.GetPlayerLevel() >= 44)
            {
                //проверка на алмазы серебро и ресурсы!!!
                if (loadSavePlayer.GetPlayerDiamond() >= 36 && loadSavePlayer.GetPlayerSilver() >= 18 && loadSavePlayer.GetPlayerResources() >= 180)
                {
                    //Повышение уровня предмета!!!
                    loadSaveItems.RecordPlayerWeaponAttack();
                    Console.WriteLine($"Теперь уровень оружия {loadSaveItems.GetItemSword()}");

                    //уменьшение diamond -36
                    int DiamondMinus = loadSavePlayer.GetPlayerDiamond() - 36;
                    string directoryPathTwo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathTwo = Path.Combine(directoryPathTwo, "gameplayerdata.txt");
                    string[] linesTwo = File.ReadAllLines(filePathTwo);
                    linesTwo[13] = DiamondMinus.ToString();
                    File.WriteAllLines(filePathTwo, linesTwo);
                    Console.WriteLine("Потрачено: " + DiamondMinus + " Алмазов");

                    //уменьшение silver -18
                    int SilverMinus = loadSavePlayer.GetPlayerSilver() - 18;
                    string directoryPathThree = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathThree = Path.Combine(directoryPathThree, "gameplayerdata.txt");
                    string[] linesThree = File.ReadAllLines(filePathThree);
                    linesThree[11] = SilverMinus.ToString();
                    File.WriteAllLines(filePathThree, linesThree);
                    Console.WriteLine("Потрачено: " + SilverMinus + " Серебра");

                    //уменьшение Resources -180
                    int ResourcesMinus = loadSavePlayer.GetPlayerResources() - 180;
                    string directoryPathFour = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathFour = Path.Combine(directoryPathFour, "gameplayerdata.txt");
                    string[] linesFour = File.ReadAllLines(filePathFour);
                    linesFour[15] = ResourcesMinus.ToString();
                    File.WriteAllLines(filePathFour, linesFour);
                    Console.WriteLine("Потрачено: " + ResourcesMinus + " Ресурсов");
                }
                else
                {
                    Console.WriteLine("Необходимо 36 алмаза и 18 сербрянная монета и 180 ресурсов для повышения уровня");
                }
            }
            //##########################################################################################################################
            //---------------------------------------------------------повышение до 19 уровня-------------------------------------------
            else if (loadSaveItems.GetItemSword() == 18 && loadSavePlayer.GetPlayerLevel() >= 46)
            {
                //проверка на алмазы серебро и ресурсы!!!
                if (loadSavePlayer.GetPlayerDiamond() >= 38 && loadSavePlayer.GetPlayerSilver() >= 19 && loadSavePlayer.GetPlayerResources() >= 190)
                {
                    //Повышение уровня предмета!!!
                    loadSaveItems.RecordPlayerWeaponAttack();
                    Console.WriteLine($"Теперь уровень оружия {loadSaveItems.GetItemSword()}");

                    //уменьшение diamond -38
                    int DiamondMinus = loadSavePlayer.GetPlayerDiamond() - 38;
                    string directoryPathTwo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathTwo = Path.Combine(directoryPathTwo, "gameplayerdata.txt");
                    string[] linesTwo = File.ReadAllLines(filePathTwo);
                    linesTwo[13] = DiamondMinus.ToString();
                    File.WriteAllLines(filePathTwo, linesTwo);
                    Console.WriteLine("Потрачено: " + DiamondMinus + " Алмазов");

                    //уменьшение silver -19
                    int SilverMinus = loadSavePlayer.GetPlayerSilver() - 19;
                    string directoryPathThree = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathThree = Path.Combine(directoryPathThree, "gameplayerdata.txt");
                    string[] linesThree = File.ReadAllLines(filePathThree);
                    linesThree[11] = SilverMinus.ToString();
                    File.WriteAllLines(filePathThree, linesThree);
                    Console.WriteLine("Потрачено: " + SilverMinus + " Серебра");

                    //уменьшение Resources -190
                    int ResourcesMinus = loadSavePlayer.GetPlayerResources() - 190;
                    string directoryPathFour = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathFour = Path.Combine(directoryPathFour, "gameplayerdata.txt");
                    string[] linesFour = File.ReadAllLines(filePathFour);
                    linesFour[15] = ResourcesMinus.ToString();
                    File.WriteAllLines(filePathFour, linesFour);
                    Console.WriteLine("Потрачено: " + ResourcesMinus + " Ресурсов");
                }
                else
                {
                    Console.WriteLine("Необходимо 38 алмаза и 19 сербрянная монета и 190 ресурсов для повышения уровня");
                }
            }
            //##########################################################################################################################
            //---------------------------------------------------------повышение до 20 уровня-------------------------------------------
            else if (loadSaveItems.GetItemSword() == 19 && loadSavePlayer.GetPlayerLevel() >= 48)
            {
                //проверка на алмазы серебро и ресурсы!!!
                if (loadSavePlayer.GetPlayerDiamond() >= 40 && loadSavePlayer.GetPlayerSilver() >= 20 && loadSavePlayer.GetPlayerResources() >= 200)
                {
                    //Повышение уровня предмета!!!
                    loadSaveItems.RecordPlayerWeaponAttack();
                    Console.WriteLine($"Теперь уровень оружия {loadSaveItems.GetItemSword()}");

                    //уменьшение diamond -40
                    int DiamondMinus = loadSavePlayer.GetPlayerDiamond() - 40;
                    string directoryPathTwo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathTwo = Path.Combine(directoryPathTwo, "gameplayerdata.txt");
                    string[] linesTwo = File.ReadAllLines(filePathTwo);
                    linesTwo[13] = DiamondMinus.ToString();
                    File.WriteAllLines(filePathTwo, linesTwo);
                    Console.WriteLine("Потрачено: " + DiamondMinus + " Алмазов");

                    //уменьшение silver -20
                    int SilverMinus = loadSavePlayer.GetPlayerSilver() - 20;
                    string directoryPathThree = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathThree = Path.Combine(directoryPathThree, "gameplayerdata.txt");
                    string[] linesThree = File.ReadAllLines(filePathThree);
                    linesThree[11] = SilverMinus.ToString();
                    File.WriteAllLines(filePathThree, linesThree);
                    Console.WriteLine("Потрачено: " + SilverMinus + " Серебра");

                    //уменьшение Resources -200
                    int ResourcesMinus = loadSavePlayer.GetPlayerResources() - 200;
                    string directoryPathFour = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathFour = Path.Combine(directoryPathFour, "gameplayerdata.txt");
                    string[] linesFour = File.ReadAllLines(filePathFour);
                    linesFour[15] = ResourcesMinus.ToString();
                    File.WriteAllLines(filePathFour, linesFour);
                    Console.WriteLine("Потрачено: " + ResourcesMinus + " Ресурсов");
                }
                else
                {
                    Console.WriteLine("Необходимо 40 алмаза и 20 сербрянная монета и 200 ресурсов для повышения уровня");
                }
            }
            //##########################################################################################################################
            //---------------------------------------------------------повышение до 21 уровня-------------------------------------------
            else if (loadSaveItems.GetItemSword() == 20 && loadSavePlayer.GetPlayerLevel() >= 50)
            {
                //проверка на алмазы серебро и ресурсы!!!
                if (loadSavePlayer.GetPlayerDiamond() >= 42 && loadSavePlayer.GetPlayerSilver() >= 21 && loadSavePlayer.GetPlayerResources() >= 210)
                {
                    //Повышение уровня предмета!!!
                    loadSaveItems.RecordPlayerWeaponAttack();
                    Console.WriteLine($"Теперь уровень оружия {loadSaveItems.GetItemSword()}");

                    //уменьшение diamond -42
                    int DiamondMinus = loadSavePlayer.GetPlayerDiamond() - 42;
                    string directoryPathTwo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathTwo = Path.Combine(directoryPathTwo, "gameplayerdata.txt");
                    string[] linesTwo = File.ReadAllLines(filePathTwo);
                    linesTwo[13] = DiamondMinus.ToString();
                    File.WriteAllLines(filePathTwo, linesTwo);
                    Console.WriteLine("Потрачено: " + DiamondMinus + " Алмазов");

                    //уменьшение silver -21
                    int SilverMinus = loadSavePlayer.GetPlayerSilver() - 21;
                    string directoryPathThree = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathThree = Path.Combine(directoryPathThree, "gameplayerdata.txt");
                    string[] linesThree = File.ReadAllLines(filePathThree);
                    linesThree[11] = SilverMinus.ToString();
                    File.WriteAllLines(filePathThree, linesThree);
                    Console.WriteLine("Потрачено: " + SilverMinus + " Серебра");

                    //уменьшение Resources -210
                    int ResourcesMinus = loadSavePlayer.GetPlayerResources() - 210;
                    string directoryPathFour = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathFour = Path.Combine(directoryPathFour, "gameplayerdata.txt");
                    string[] linesFour = File.ReadAllLines(filePathFour);
                    linesFour[15] = ResourcesMinus.ToString();
                    File.WriteAllLines(filePathFour, linesFour);
                    Console.WriteLine("Потрачено: " + ResourcesMinus + " Ресурсов");
                }
                else
                {
                    Console.WriteLine("Необходимо 42 алмаза и 21 сербрянная монета и 210 ресурсов для повышения уровня");
                }
            }
            //##########################################################################################################################
            //---------------------------------------------------------повышение до 22 уровня-------------------------------------------
            else if (loadSaveItems.GetItemSword() == 21 && loadSavePlayer.GetPlayerLevel() >= 52)
            {
                //проверка на алмазы серебро и ресурсы!!!
                if (loadSavePlayer.GetPlayerDiamond() >= 44 && loadSavePlayer.GetPlayerSilver() >= 22 && loadSavePlayer.GetPlayerResources() >= 220)
                {
                    //Повышение уровня предмета!!!
                    loadSaveItems.RecordPlayerWeaponAttack();
                    Console.WriteLine($"Теперь уровень оружия {loadSaveItems.GetItemSword()}");

                    //уменьшение diamond -44
                    int DiamondMinus = loadSavePlayer.GetPlayerDiamond() - 44;
                    string directoryPathTwo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathTwo = Path.Combine(directoryPathTwo, "gameplayerdata.txt");
                    string[] linesTwo = File.ReadAllLines(filePathTwo);
                    linesTwo[13] = DiamondMinus.ToString();
                    File.WriteAllLines(filePathTwo, linesTwo);
                    Console.WriteLine("Потрачено: " + DiamondMinus + " Алмазов");

                    //уменьшение silver -22
                    int SilverMinus = loadSavePlayer.GetPlayerSilver() - 22;
                    string directoryPathThree = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathThree = Path.Combine(directoryPathThree, "gameplayerdata.txt");
                    string[] linesThree = File.ReadAllLines(filePathThree);
                    linesThree[11] = SilverMinus.ToString();
                    File.WriteAllLines(filePathThree, linesThree);
                    Console.WriteLine("Потрачено: " + SilverMinus + " Серебра");

                    //уменьшение Resources -220
                    int ResourcesMinus = loadSavePlayer.GetPlayerResources() - 220;
                    string directoryPathFour = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathFour = Path.Combine(directoryPathFour, "gameplayerdata.txt");
                    string[] linesFour = File.ReadAllLines(filePathFour);
                    linesFour[15] = ResourcesMinus.ToString();
                    File.WriteAllLines(filePathFour, linesFour);
                    Console.WriteLine("Потрачено: " + ResourcesMinus + " Ресурсов");
                }
                else
                {
                    Console.WriteLine("Необходимо 44 алмаза и 22 сербрянная монета и 220 ресурсов для повышения уровня");
                }
            }
            //##########################################################################################################################
            //---------------------------------------------------------повышение до 23 уровня-------------------------------------------
            else if (loadSaveItems.GetItemSword() == 22 && loadSavePlayer.GetPlayerLevel() >= 54)
            {
                //проверка на алмазы серебро и ресурсы!!!
                if (loadSavePlayer.GetPlayerDiamond() >= 46 && loadSavePlayer.GetPlayerSilver() >= 23 && loadSavePlayer.GetPlayerResources() >= 230)
                {
                    //Повышение уровня предмета!!!
                    loadSaveItems.RecordPlayerWeaponAttack();
                    Console.WriteLine($"Теперь уровень оружия {loadSaveItems.GetItemSword()}");

                    //уменьшение diamond -46
                    int DiamondMinus = loadSavePlayer.GetPlayerDiamond() - 46;
                    string directoryPathTwo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathTwo = Path.Combine(directoryPathTwo, "gameplayerdata.txt");
                    string[] linesTwo = File.ReadAllLines(filePathTwo);
                    linesTwo[13] = DiamondMinus.ToString();
                    File.WriteAllLines(filePathTwo, linesTwo);
                    Console.WriteLine("Потрачено: " + DiamondMinus + " Алмазов");

                    //уменьшение silver -23
                    int SilverMinus = loadSavePlayer.GetPlayerSilver() - 23;
                    string directoryPathThree = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathThree = Path.Combine(directoryPathThree, "gameplayerdata.txt");
                    string[] linesThree = File.ReadAllLines(filePathThree);
                    linesThree[11] = SilverMinus.ToString();
                    File.WriteAllLines(filePathThree, linesThree);
                    Console.WriteLine("Потрачено: " + SilverMinus + " Серебра");

                    //уменьшение Resources -230
                    int ResourcesMinus = loadSavePlayer.GetPlayerResources() - 230;
                    string directoryPathFour = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathFour = Path.Combine(directoryPathFour, "gameplayerdata.txt");
                    string[] linesFour = File.ReadAllLines(filePathFour);
                    linesFour[15] = ResourcesMinus.ToString();
                    File.WriteAllLines(filePathFour, linesFour);
                    Console.WriteLine("Потрачено: " + ResourcesMinus + " Ресурсов");
                }
                else
                {
                    Console.WriteLine("Необходимо 46 алмаза и 23 сербрянная монета и 230 ресурсов для повышения уровня");
                }
            }
            //##########################################################################################################################
            //---------------------------------------------------------повышение до 24 уровня-------------------------------------------
            else if (loadSaveItems.GetItemSword() == 23 && loadSavePlayer.GetPlayerLevel() >= 56)
            {
                //проверка на алмазы серебро и ресурсы!!!
                if (loadSavePlayer.GetPlayerDiamond() >= 48 && loadSavePlayer.GetPlayerSilver() >= 24 && loadSavePlayer.GetPlayerResources() >= 240)
                {
                    //Повышение уровня предмета!!!
                    loadSaveItems.RecordPlayerWeaponAttack();
                    Console.WriteLine($"Теперь уровень оружия {loadSaveItems.GetItemSword()}");

                    //уменьшение diamond -48
                    int DiamondMinus = loadSavePlayer.GetPlayerDiamond() - 48;
                    string directoryPathTwo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathTwo = Path.Combine(directoryPathTwo, "gameplayerdata.txt");
                    string[] linesTwo = File.ReadAllLines(filePathTwo);
                    linesTwo[13] = DiamondMinus.ToString();
                    File.WriteAllLines(filePathTwo, linesTwo);
                    Console.WriteLine("Потрачено: " + DiamondMinus + " Алмазов");

                    //уменьшение silver -24
                    int SilverMinus = loadSavePlayer.GetPlayerSilver() - 24;
                    string directoryPathThree = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathThree = Path.Combine(directoryPathThree, "gameplayerdata.txt");
                    string[] linesThree = File.ReadAllLines(filePathThree);
                    linesThree[11] = SilverMinus.ToString();
                    File.WriteAllLines(filePathThree, linesThree);
                    Console.WriteLine("Потрачено: " + SilverMinus + " Серебра");

                    //уменьшение Resources -240
                    int ResourcesMinus = loadSavePlayer.GetPlayerResources() - 240;
                    string directoryPathFour = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathFour = Path.Combine(directoryPathFour, "gameplayerdata.txt");
                    string[] linesFour = File.ReadAllLines(filePathFour);
                    linesFour[15] = ResourcesMinus.ToString();
                    File.WriteAllLines(filePathFour, linesFour);
                    Console.WriteLine("Потрачено: " + ResourcesMinus + " Ресурсов");
                }
                else
                {
                    Console.WriteLine("Необходимо 48 алмаза и 24 сербрянная монета и 240 ресурсов для повышения уровня");
                }
            }
            //##########################################################################################################################
            //---------------------------------------------------------повышение до 25 уровня-------------------------------------------
            else if (loadSaveItems.GetItemSword() == 24 && loadSavePlayer.GetPlayerLevel() >= 58)
            {
                //проверка на алмазы серебро и ресурсы!!!
                if (loadSavePlayer.GetPlayerDiamond() >= 50 && loadSavePlayer.GetPlayerSilver() >= 25 && loadSavePlayer.GetPlayerResources() >= 250)
                {
                    //Повышение уровня предмета!!!
                    loadSaveItems.RecordPlayerWeaponAttack();
                    Console.WriteLine($"Теперь уровень оружия {loadSaveItems.GetItemSword()}");

                    //уменьшение diamond -50
                    int DiamondMinus = loadSavePlayer.GetPlayerDiamond() - 50;
                    string directoryPathTwo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathTwo = Path.Combine(directoryPathTwo, "gameplayerdata.txt");
                    string[] linesTwo = File.ReadAllLines(filePathTwo);
                    linesTwo[13] = DiamondMinus.ToString();
                    File.WriteAllLines(filePathTwo, linesTwo);
                    Console.WriteLine("Потрачено: " + DiamondMinus + " Алмазов");

                    //уменьшение silver -25
                    int SilverMinus = loadSavePlayer.GetPlayerSilver() - 25;
                    string directoryPathThree = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathThree = Path.Combine(directoryPathThree, "gameplayerdata.txt");
                    string[] linesThree = File.ReadAllLines(filePathThree);
                    linesThree[11] = SilverMinus.ToString();
                    File.WriteAllLines(filePathThree, linesThree);
                    Console.WriteLine("Потрачено: " + SilverMinus + " Серебра");

                    //уменьшение Resources -250
                    int ResourcesMinus = loadSavePlayer.GetPlayerResources() - 250;
                    string directoryPathFour = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathFour = Path.Combine(directoryPathFour, "gameplayerdata.txt");
                    string[] linesFour = File.ReadAllLines(filePathFour);
                    linesFour[15] = ResourcesMinus.ToString();
                    File.WriteAllLines(filePathFour, linesFour);
                    Console.WriteLine("Потрачено: " + ResourcesMinus + " Ресурсов");
                }
                else
                {
                    Console.WriteLine("Необходимо 50 алмаза и 25 сербрянная монета и 250 ресурсов для повышения уровня");
                }
            }
            //##########################################################################################################################
            //---------------------------------------------------------повышение до 26 уровня-------------------------------------------
            else if (loadSaveItems.GetItemSword() == 25 && loadSavePlayer.GetPlayerLevel() >= 60)
            {
                //проверка на алмазы серебро и ресурсы!!!
                if (loadSavePlayer.GetPlayerDiamond() >= 52 && loadSavePlayer.GetPlayerSilver() >= 26 && loadSavePlayer.GetPlayerResources() >= 260)
                {
                    //Повышение уровня предмета!!!
                    loadSaveItems.RecordPlayerWeaponAttack();
                    Console.WriteLine($"Теперь уровень оружия {loadSaveItems.GetItemSword()}");

                    //уменьшение diamond -52
                    int DiamondMinus = loadSavePlayer.GetPlayerDiamond() - 52;
                    string directoryPathTwo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathTwo = Path.Combine(directoryPathTwo, "gameplayerdata.txt");
                    string[] linesTwo = File.ReadAllLines(filePathTwo);
                    linesTwo[13] = DiamondMinus.ToString();
                    File.WriteAllLines(filePathTwo, linesTwo);
                    Console.WriteLine("Потрачено: " + DiamondMinus + " Алмазов");

                    //уменьшение silver -26
                    int SilverMinus = loadSavePlayer.GetPlayerSilver() - 26;
                    string directoryPathThree = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathThree = Path.Combine(directoryPathThree, "gameplayerdata.txt");
                    string[] linesThree = File.ReadAllLines(filePathThree);
                    linesThree[11] = SilverMinus.ToString();
                    File.WriteAllLines(filePathThree, linesThree);
                    Console.WriteLine("Потрачено: " + SilverMinus + " Серебра");

                    //уменьшение Resources -260
                    int ResourcesMinus = loadSavePlayer.GetPlayerResources() - 260;
                    string directoryPathFour = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathFour = Path.Combine(directoryPathFour, "gameplayerdata.txt");
                    string[] linesFour = File.ReadAllLines(filePathFour);
                    linesFour[15] = ResourcesMinus.ToString();
                    File.WriteAllLines(filePathFour, linesFour);
                    Console.WriteLine("Потрачено: " + ResourcesMinus + " Ресурсов");
                }
                else
                {
                    Console.WriteLine("Необходимо 52 алмаза и 26 сербрянная монета и 260 ресурсов для повышения уровня");
                }
            }
            //##########################################################################################################################
            //---------------------------------------------------------повышение до 27 уровня-------------------------------------------
            else if (loadSaveItems.GetItemSword() == 26 && loadSavePlayer.GetPlayerLevel() >= 62)
            {
                //проверка на алмазы серебро и ресурсы!!!
                if (loadSavePlayer.GetPlayerDiamond() >= 54 && loadSavePlayer.GetPlayerSilver() >= 27 && loadSavePlayer.GetPlayerResources() >= 270)
                {
                    //Повышение уровня предмета!!!
                    loadSaveItems.RecordPlayerWeaponAttack();
                    Console.WriteLine($"Теперь уровень оружия {loadSaveItems.GetItemSword()}");

                    //уменьшение diamond -54
                    int DiamondMinus = loadSavePlayer.GetPlayerDiamond() - 54;
                    string directoryPathTwo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathTwo = Path.Combine(directoryPathTwo, "gameplayerdata.txt");
                    string[] linesTwo = File.ReadAllLines(filePathTwo);
                    linesTwo[13] = DiamondMinus.ToString();
                    File.WriteAllLines(filePathTwo, linesTwo);
                    Console.WriteLine("Потрачено: " + DiamondMinus + " Алмазов");

                    //уменьшение silver -27
                    int SilverMinus = loadSavePlayer.GetPlayerSilver() - 27;
                    string directoryPathThree = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathThree = Path.Combine(directoryPathThree, "gameplayerdata.txt");
                    string[] linesThree = File.ReadAllLines(filePathThree);
                    linesThree[11] = SilverMinus.ToString();
                    File.WriteAllLines(filePathThree, linesThree);
                    Console.WriteLine("Потрачено: " + SilverMinus + " Серебра");

                    //уменьшение Resources -270
                    int ResourcesMinus = loadSavePlayer.GetPlayerResources() - 270;
                    string directoryPathFour = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathFour = Path.Combine(directoryPathFour, "gameplayerdata.txt");
                    string[] linesFour = File.ReadAllLines(filePathFour);
                    linesFour[15] = ResourcesMinus.ToString();
                    File.WriteAllLines(filePathFour, linesFour);
                    Console.WriteLine("Потрачено: " + ResourcesMinus + " Ресурсов");
                }
                else
                {
                    Console.WriteLine("Необходимо 54 алмаза и 27 сербрянная монета и 270 ресурсов для повышения уровня");
                }
            }
            //##########################################################################################################################
            //---------------------------------------------------------повышение до 28 уровня-------------------------------------------
            else if (loadSaveItems.GetItemSword() == 27 && loadSavePlayer.GetPlayerLevel() >= 64)
            {
                //проверка на алмазы серебро и ресурсы!!!
                if (loadSavePlayer.GetPlayerDiamond() >= 56 && loadSavePlayer.GetPlayerSilver() >= 28 && loadSavePlayer.GetPlayerResources() >= 280)
                {
                    //Повышение уровня предмета!!!
                    loadSaveItems.RecordPlayerWeaponAttack();
                    Console.WriteLine($"Теперь уровень оружия {loadSaveItems.GetItemSword()}");

                    //уменьшение diamond -56
                    int DiamondMinus = loadSavePlayer.GetPlayerDiamond() - 56;
                    string directoryPathTwo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathTwo = Path.Combine(directoryPathTwo, "gameplayerdata.txt");
                    string[] linesTwo = File.ReadAllLines(filePathTwo);
                    linesTwo[13] = DiamondMinus.ToString();
                    File.WriteAllLines(filePathTwo, linesTwo);
                    Console.WriteLine("Потрачено: " + DiamondMinus + " Алмазов");

                    //уменьшение silver -28
                    int SilverMinus = loadSavePlayer.GetPlayerSilver() - 28;
                    string directoryPathThree = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathThree = Path.Combine(directoryPathThree, "gameplayerdata.txt");
                    string[] linesThree = File.ReadAllLines(filePathThree);
                    linesThree[11] = SilverMinus.ToString();
                    File.WriteAllLines(filePathThree, linesThree);
                    Console.WriteLine("Потрачено: " + SilverMinus + " Серебра");

                    //уменьшение Resources -280
                    int ResourcesMinus = loadSavePlayer.GetPlayerResources() - 280;
                    string directoryPathFour = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathFour = Path.Combine(directoryPathFour, "gameplayerdata.txt");
                    string[] linesFour = File.ReadAllLines(filePathFour);
                    linesFour[15] = ResourcesMinus.ToString();
                    File.WriteAllLines(filePathFour, linesFour);
                    Console.WriteLine("Потрачено: " + ResourcesMinus + " Ресурсов");
                }
                else
                {
                    Console.WriteLine("Необходимо 56 алмаза и 28 сербрянная монета и 280 ресурсов для повышения уровня");
                }
            }
            //##########################################################################################################################
            //---------------------------------------------------------повышение до 29 уровня-------------------------------------------
            else if (loadSaveItems.GetItemSword() == 28 && loadSavePlayer.GetPlayerLevel() >= 66)
            {
                //проверка на алмазы серебро и ресурсы!!!
                if (loadSavePlayer.GetPlayerDiamond() >= 58 && loadSavePlayer.GetPlayerSilver() >= 29 && loadSavePlayer.GetPlayerResources() >= 290)
                {
                    //Повышение уровня предмета!!!
                    loadSaveItems.RecordPlayerWeaponAttack();
                    Console.WriteLine($"Теперь уровень оружия {loadSaveItems.GetItemSword()}");

                    //уменьшение diamond -58
                    int DiamondMinus = loadSavePlayer.GetPlayerDiamond() - 58;
                    string directoryPathTwo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathTwo = Path.Combine(directoryPathTwo, "gameplayerdata.txt");
                    string[] linesTwo = File.ReadAllLines(filePathTwo);
                    linesTwo[13] = DiamondMinus.ToString();
                    File.WriteAllLines(filePathTwo, linesTwo);
                    Console.WriteLine("Потрачено: " + DiamondMinus + " Алмазов");

                    //уменьшение silver -29
                    int SilverMinus = loadSavePlayer.GetPlayerSilver() - 29;
                    string directoryPathThree = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathThree = Path.Combine(directoryPathThree, "gameplayerdata.txt");
                    string[] linesThree = File.ReadAllLines(filePathThree);
                    linesThree[11] = SilverMinus.ToString();
                    File.WriteAllLines(filePathThree, linesThree);
                    Console.WriteLine("Потрачено: " + SilverMinus + " Серебра");

                    //уменьшение Resources -290
                    int ResourcesMinus = loadSavePlayer.GetPlayerResources() - 290;
                    string directoryPathFour = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathFour = Path.Combine(directoryPathFour, "gameplayerdata.txt");
                    string[] linesFour = File.ReadAllLines(filePathFour);
                    linesFour[15] = ResourcesMinus.ToString();
                    File.WriteAllLines(filePathFour, linesFour);
                    Console.WriteLine("Потрачено: " + ResourcesMinus + " Ресурсов");
                }
                else
                {
                    Console.WriteLine("Необходимо 58 алмаза и 29 сербрянная монета и 290 ресурсов для повышения уровня");
                }
            }
            //##########################################################################################################################
            //---------------------------------------------------------повышение до 30 уровня-------------------------------------------
            else if (loadSaveItems.GetItemSword() == 29 && loadSavePlayer.GetPlayerLevel() >= 68)
            {
                //проверка на алмазы серебро и ресурсы!!!
                if (loadSavePlayer.GetPlayerDiamond() >= 60 && loadSavePlayer.GetPlayerSilver() >= 30 && loadSavePlayer.GetPlayerResources() >= 300)
                {
                    //Повышение уровня предмета!!!
                    loadSaveItems.RecordPlayerWeaponAttack();
                    Console.WriteLine($"Теперь уровень оружия {loadSaveItems.GetItemSword()}");

                    //уменьшение diamond -60
                    int DiamondMinus = loadSavePlayer.GetPlayerDiamond() - 60;
                    string directoryPathTwo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathTwo = Path.Combine(directoryPathTwo, "gameplayerdata.txt");
                    string[] linesTwo = File.ReadAllLines(filePathTwo);
                    linesTwo[13] = DiamondMinus.ToString();
                    File.WriteAllLines(filePathTwo, linesTwo);
                    Console.WriteLine("Потрачено: " + DiamondMinus + " Алмазов");

                    //уменьшение silver -30
                    int SilverMinus = loadSavePlayer.GetPlayerSilver() - 30;
                    string directoryPathThree = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathThree = Path.Combine(directoryPathThree, "gameplayerdata.txt");
                    string[] linesThree = File.ReadAllLines(filePathThree);
                    linesThree[11] = SilverMinus.ToString();
                    File.WriteAllLines(filePathThree, linesThree);
                    Console.WriteLine("Потрачено: " + SilverMinus + " Серебра");

                    //уменьшение Resources -300
                    int ResourcesMinus = loadSavePlayer.GetPlayerResources() - 300;
                    string directoryPathFour = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathFour = Path.Combine(directoryPathFour, "gameplayerdata.txt");
                    string[] linesFour = File.ReadAllLines(filePathFour);
                    linesFour[15] = ResourcesMinus.ToString();
                    File.WriteAllLines(filePathFour, linesFour);
                    Console.WriteLine("Потрачено: " + ResourcesMinus + " Ресурсов");
                }
                else
                {
                    Console.WriteLine("Необходимо 60 алмаза и 30 сербрянная монета и 300 ресурсов для повышения уровня");
                }
            }
            else
            {
                Console.WriteLine("Персонаж должен быть минимум 10 уровня");
            }
        }


    }
}
