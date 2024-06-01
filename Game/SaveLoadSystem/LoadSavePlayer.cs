using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class LoadSavePlayer
    {
        //---------Хранится------bin-Debug-----net8.0-gameplayerdata.txt---------------------------------------
        //-------------------------------------------СБРОС---СТАТОВ--ИГРОКА-------------------------------
        public void ResetPlayerDataBase()
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");
            string[] lines =
            {"Default", "1", "4", "1", "1",
            "1", "30", "30", "8", "8",
            "0", "0", "0", "0", "0",
            "0", "0", "40", "10", "1", "0", "40", "1"};
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (string line in lines)
                {
                    writer.WriteLine(line);
                    Console.WriteLine("Статы Игрока " + line);
                }
            }
        }
        //-------------------------------------------ЧТЕНИЕ---ИМЕНИ--ИГРОКА-----0--------------------------
        public string GetPlayerName()
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line = sr.ReadLine();
                    string nameLine = line;
                    return nameLine;
                }
            }
            catch (Exception)
            {
                return "none";
            }
        }
        //-------------------------------------------ЧТЕНИЕ---LEVEL--ИГРОКА----1---------------------------
        public int GetPlayerLevel()
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    sr.ReadLine();
                    string line = sr.ReadLine();
                    int levelLine = int.Parse(line);
                    return levelLine;
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }
        //-------------------------------------------ЧТЕНИЕ---ATTACK--ИГРОКА---------2----------------------
        public int GetPlayerAttack()
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");
            try
            {
                LoadSaveItems loadSaveItems = new LoadSaveItems();
                using (StreamReader sr = new StreamReader(filePath))
                {
                    sr.ReadLine();
                    sr.ReadLine();
                    string line = sr.ReadLine();
                    int attackLine = int.Parse(line);
                    int finalAttackLine = attackLine + loadSaveItems.GetItemSwordStats();
                    return finalAttackLine;
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }
        //-------------------------------------------ЧТЕНИЕ---CRIT--ИГРОКА-----------3--------------------
        public int GetPlayerCrit()
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");

            try
            {
                LoadSaveItems loadSaveItems = new LoadSaveItems();
                using (StreamReader sr = new StreamReader(filePath))
                {
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    string line = sr.ReadLine();
                    int critLine = int.Parse(line);
                    int finalCritLine = critLine + loadSaveItems.GetItemPantsStatsOne();
                    return finalCritLine;
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }
        //-------------------------------------------ЧТЕНИЕ---DEFENSE--ИГРОКА-------4------------------------
        public int GetPlayerDefense()
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");

            try
            {
                LoadSaveItems loadSaveItems = new LoadSaveItems();
                using (StreamReader sr = new StreamReader(filePath))
                {
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    string line = sr.ReadLine();
                    int defenseLine = int.Parse(line);
                    int finalDefenseLine = defenseLine + loadSaveItems.GetItemHelmetStatTwo() + loadSaveItems.GetItemArmorStatsTwo() + loadSaveItems.GetItemPantsStatsTwo() + loadSaveItems.GetItemBootsStatsTwo();
                    return finalDefenseLine;
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }
        //-------------------------------------------ЧТЕНИЕ---DODGE--ИГРОКА---------5----------------------
        public int GetPlayerDodge()
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");

            try
            {
                LoadSaveItems loadSaveItems = new LoadSaveItems();
                using (StreamReader sr = new StreamReader(filePath))
                {
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    string line = sr.ReadLine();
                    int dodgeLine = int.Parse(line);
                    int finalDodgeLine = dodgeLine + loadSaveItems.GetItemPantsStatsOne();
                    return finalDodgeLine;
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }
        //-------------------------------------------ЧТЕНИЕ---HP--ИГРОКА------------6-------------------
        public int GetPlayerHp()
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    string line = sr.ReadLine();
                    int hpLine = int.Parse(line);
                    return hpLine;
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }
        //-------------------------------------------ЧТЕНИЕ---MAXHP--ИГРОКА--------7-----------------------
        public int GetPlayerMaxHp()
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");

            try
            {
                LoadSaveItems loadSaveItems = new LoadSaveItems();
                using (StreamReader sr = new StreamReader(filePath))
                {
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    string line = sr.ReadLine();
                    int maxHpLine = int.Parse(line);
                    int finalMaxHpLineLine = maxHpLine + loadSaveItems.GetItemArmorStatsOne();
                    return finalMaxHpLineLine;
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }
        //-------------------------------------------ЧТЕНИЕ---MP--ИГРОКА------------8-------------------
        public int GetPlayerMp()
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    string line = sr.ReadLine();
                    int mpLine = int.Parse(line);
                    return mpLine;
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }
        //-------------------------------------------ЧТЕНИЕ---MAXMP--ИГРОКА----------9---------------------
        public int GetPlayerMaxMp()
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");

            try
            {
                LoadSaveItems loadSaveItems = new LoadSaveItems();
                using (StreamReader sr = new StreamReader(filePath))
                {
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    string line = sr.ReadLine();
                    int maxMpLine = int.Parse(line);
                    int finalMaxMpLineLine = maxMpLine + loadSaveItems.GetItemHelmetStatOne();
                    return finalMaxMpLineLine;
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }
        //-------------------------------------------ЧТЕНИЕ---BRONZE--ИГРОКА---------10----------------------
        public int GetPlayerBronze()
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    string line = sr.ReadLine();
                    int bronzeLine = int.Parse(line);
                    return bronzeLine;
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }
        //-------------------------------------------ЧТЕНИЕ---SILVER--ИГРОКА--------11-----------------------
        public int GetPlayerSilver()
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    string line = sr.ReadLine();
                    int silverLine = int.Parse(line);
                    return silverLine;
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }
        //-------------------------------------------ЧТЕНИЕ---GOLD--ИГРОКА-----------12--------------------
        public int GetPlayerGold()
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    string line = sr.ReadLine();
                    int goldLine = int.Parse(line);
                    return goldLine;
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }
        //-------------------------------------------ЧТЕНИЕ---DIAMOND--ИГРОКА---------13----------------------
        public int GetPlayerDiamond()
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    string line = sr.ReadLine();
                    int diamondLine = int.Parse(line);
                    return diamondLine;
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }
        //-------------------------------------------ЧТЕНИЕ---FOOD--ИГРОКА------------14-------------------
        public int GetPlayerFood()
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    string line = sr.ReadLine();
                    int foodLine = int.Parse(line);
                    return foodLine;
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }
        //-------------------------------------------ЧТЕНИЕ---RESURCES--ИГРОКА--------15-----------------------
        public int GetPlayerResources()
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    string line = sr.ReadLine();
                    int resourcesLine = int.Parse(line);
                    return resourcesLine;
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }
        //-------------------------------------------ЧТЕНИЕ---ExpAmount--ИГРОКА---------16----------------------
        public int GetPlayerExpAmount()
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    string line = sr.ReadLine();
                    int expAmountLine = int.Parse(line);
                    return expAmountLine;
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }
        //-------------------------------------------ЧТЕНИЕ---ExpForNextLvl--ИГРОКА----17---------------------------
        public int GetPlayerExpForNextLvl()
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    string line = sr.ReadLine();
                    int expForNextLevelLine = int.Parse(line);
                    return expForNextLevelLine;
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }
        //-------------------------------------------ЧТЕНИЕ---Energy--ИГРОКА----------18---------------------
        public int GetPlayerEnergy()
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    string line = sr.ReadLine();
                    int energyLine = int.Parse(line);
                    return energyLine;
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }
        //-------------------------------------------ЧТЕНИЕ---DungeonEnergy--ИГРОКА----19---------------------------
        public int GetPlayerDungeonEnergy()
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    string line = sr.ReadLine();
                    int dungeonEnergyLine = int.Parse(line);
                    return dungeonEnergyLine;
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }
        //-------------------------------------------ЧТЕНИЕ---ExpAmountFarm--ИГРОКА----20---------------------------
        public int GetPlayerExpAmountFarm()
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    string line = sr.ReadLine();
                    int expAmountLine = int.Parse(line);
                    return expAmountLine;
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }
        //-------------------------------------------ЧТЕНИЕ---ExpForNextLvlFarm--ИГРОКА----21---------------------------
        public int GetPlayerExpForNextLvlFarm()
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    string line = sr.ReadLine();
                    int expForNextLevelLine = int.Parse(line);
                    return expForNextLevelLine;
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }
        //-------------------------------------------ЧТЕНИЕ---LEVEL--ИГРОКА---FARM---22-------------------------
        public int GetPlayerLevelFarm()
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    string line = sr.ReadLine();
                    int levelLine = int.Parse(line);
                    return levelLine;
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }
        //###############################################################################################################################
        //-------------------------------------------ЗАПИСЬ---АТАКИ--ИГРОКА-------------------------------
        public void RecordPlayerAttack()
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");
            int setPlayerAttack = GetPlayerLevel() > 1 ? GetPlayerLevel() * 2 : 4;
            {
                try
                {
                    string[] lines = File.ReadAllLines(filePath);
                    lines[2] = setPlayerAttack.ToString();
                    File.WriteAllLines(filePath, lines);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                }
            }
        }
        //-------------------------------------------ЗАПИСЬ---DEFENSE--ИГРОКА-------------------------------
        public void RecordPlayerDefense()
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");
            int setPlayerDefense = GetPlayerLevel() > 1 ? 1 + (GetPlayerLevel() - 1) : 1;
            {
                try
                {
                    string[] lines = File.ReadAllLines(filePath);
                    lines[4] = setPlayerDefense.ToString();
                    File.WriteAllLines(filePath, lines);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                }
            }
        }
        //-------------------------------------------ЗАПИСЬ---Hp--ИГРОКА-------------------------------
        public void RecordPlayerHp()
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");
            int setPlayerHp = 30 + (GetPlayerLevel() - 1) * 16;
            {
                try
                {
                    string[] lines = File.ReadAllLines(filePath);
                    lines[6] = setPlayerHp.ToString();
                    File.WriteAllLines(filePath, lines);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                }
            }
        }
        //-------------------------------------------ЗАПИСЬ---MaxHp--ИГРОКА-------------------------------
        public void RecordPlayerMaxHp()
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");
            int setPlayerMaxHp = 30 + (GetPlayerLevel() - 1) * 14;
            {
                try
                {
                    string[] lines = File.ReadAllLines(filePath);
                    lines[7] = setPlayerMaxHp.ToString();
                    File.WriteAllLines(filePath, lines);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                }
            }
        }
        //-------------------------------------------ЗАПИСЬ---Mp--ИГРОКА-------------------------------
        public void RecordPlayerMp()
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");
            int setPlayerMp = 10 + (GetPlayerLevel() - 1) * 2;
            {
                try
                {
                    string[] lines = File.ReadAllLines(filePath);
                    lines[8] = setPlayerMp.ToString();
                    File.WriteAllLines(filePath, lines);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                }
            }
        }
        //-------------------------------------------ЗАПИСЬ---MaxMp--ИГРОКА-------------------------------
        public void RecordPlayerMaxMp()
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");
            int setPlayerMaxMp = 10 + (GetPlayerLevel() - 1) * 2;
            {
                try
                {
                    string[] lines = File.ReadAllLines(filePath);
                    lines[9] = setPlayerMaxMp.ToString();
                    File.WriteAllLines(filePath, lines);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                }
            }
        }
        //-------------------------------------------ЗАПИСЬ---ExpForNextLvl--ИГРОКА-------------------------------
        public void RecordPlayerExpForNextLvl()
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");
            if (GetPlayerLevel() >= 1 && GetPlayerLevel() < 10)
            {
                int setPlayerExpForNextLvl = GetPlayerLevel() > 1 ? 20 * GetPlayerLevel() * 2 : 40;
                {
                    try
                    {
                        string[] lines = File.ReadAllLines(filePath);
                        lines[17] = setPlayerExpForNextLvl.ToString();
                        File.WriteAllLines(filePath, lines);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                    }
                }
            }
            else if (GetPlayerLevel() >= 10 && GetPlayerLevel() <= 19)
            {
                int setPlayerExpForNextLvl = GetPlayerLevel() > 1 ? 20 * GetPlayerLevel() * 3 : 40;
                {
                    try
                    {
                        string[] lines = File.ReadAllLines(filePath);
                        lines[17] = setPlayerExpForNextLvl.ToString();
                        File.WriteAllLines(filePath, lines);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                    }
                }
            }
            else if (GetPlayerLevel() >= 20 && GetPlayerLevel() <= 29)
            {
                int setPlayerExpForNextLvl = GetPlayerLevel() > 1 ? 20 * GetPlayerLevel() * 4 : 40;
                {
                    try
                    {
                        string[] lines = File.ReadAllLines(filePath);
                        lines[17] = setPlayerExpForNextLvl.ToString();
                        File.WriteAllLines(filePath, lines);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                    }
                }
            }
            else if (GetPlayerLevel() >= 30 && GetPlayerLevel() <= 39)
            {
                int setPlayerExpForNextLvl = GetPlayerLevel() > 1 ? 20 * GetPlayerLevel() * 5 : 40;
                {
                    try
                    {
                        string[] lines = File.ReadAllLines(filePath);
                        lines[17] = setPlayerExpForNextLvl.ToString();
                        File.WriteAllLines(filePath, lines);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                    }
                }
            }
            else if (GetPlayerLevel() >= 40 && GetPlayerLevel() <= 49)
            {
                int setPlayerExpForNextLvl = GetPlayerLevel() > 1 ? 20 * GetPlayerLevel() * 6 : 40;
                {
                    try
                    {
                        string[] lines = File.ReadAllLines(filePath);
                        lines[17] = setPlayerExpForNextLvl.ToString();
                        File.WriteAllLines(filePath, lines);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                    }
                }
            }
            else if (GetPlayerLevel() >= 50 && GetPlayerLevel() <= 59)
            {
                int setPlayerExpForNextLvl = GetPlayerLevel() > 1 ? 20 * GetPlayerLevel() * 7 : 40;
                {
                    try
                    {
                        string[] lines = File.ReadAllLines(filePath);
                        lines[17] = setPlayerExpForNextLvl.ToString();
                        File.WriteAllLines(filePath, lines);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                    }
                }
            }
            else if (GetPlayerLevel() >= 60 && GetPlayerLevel() <= 70)
            {
                int setPlayerExpForNextLvl = GetPlayerLevel() > 1 ? 20 * GetPlayerLevel() * 8 : 40;
                {
                    try
                    {
                        string[] lines = File.ReadAllLines(filePath);
                        lines[17] = setPlayerExpForNextLvl.ToString();
                        File.WriteAllLines(filePath, lines);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                    }
                }
            }
        }
        //-------------------------------------------ЗАПИСЬ---ExpForNextLvlFarm--ИГРОКА-------------------------------
        public void RecordPlayerExpForNextLvlFarm()
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");
            if (GetPlayerLevel() >= 1 && GetPlayerLevel() < 10)
            {
                int setPlayerExpForNextLvlFarm = GetPlayerLevelFarm() > 1 ? 20 * GetPlayerLevelFarm() * 2 : 40;
                {
                    try
                    {
                        string[] lines = File.ReadAllLines(filePath);
                        lines[21] = setPlayerExpForNextLvlFarm.ToString();
                        File.WriteAllLines(filePath, lines);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                    }
                }
            }
            else if (GetPlayerLevelFarm() >= 10 && GetPlayerLevelFarm() <= 19)
            {
                int setPlayerExpForNextLvlFarm = GetPlayerLevelFarm() > 1 ? 20 * GetPlayerLevelFarm() * 3 : 40;
                {
                    try
                    {
                        string[] lines = File.ReadAllLines(filePath);
                        lines[21] = setPlayerExpForNextLvlFarm.ToString();
                        File.WriteAllLines(filePath, lines);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                    }
                }
            }
            else if (GetPlayerLevelFarm() >= 20 && GetPlayerLevelFarm() <= 29)
            {
                int setPlayerExpForNextLvlFarm = GetPlayerLevelFarm() > 1 ? 20 * GetPlayerLevelFarm() * 4 : 40;
                {
                    try
                    {
                        string[] lines = File.ReadAllLines(filePath);
                        lines[21] = setPlayerExpForNextLvlFarm.ToString();
                        File.WriteAllLines(filePath, lines);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                    }
                }
            }
            else if (GetPlayerLevelFarm() >= 30 && GetPlayerLevelFarm() <= 39)
            {
                int setPlayerExpForNextLvlFarm = GetPlayerLevelFarm() > 1 ? 20 * GetPlayerLevelFarm() * 5 : 40;
                {
                    try
                    {
                        string[] lines = File.ReadAllLines(filePath);
                        lines[21] = setPlayerExpForNextLvlFarm.ToString();
                        File.WriteAllLines(filePath, lines);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                    }
                }
            }
            else if (GetPlayerLevelFarm() >= 40 && GetPlayerLevelFarm() <= 49)
            {
                int setPlayerExpForNextLvlFarm = GetPlayerLevelFarm() > 1 ? 20 * GetPlayerLevelFarm() * 6 : 40;
                {
                    try
                    {
                        string[] lines = File.ReadAllLines(filePath);
                        lines[21] = setPlayerExpForNextLvlFarm.ToString();
                        File.WriteAllLines(filePath, lines);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                    }
                }
            }
            else if (GetPlayerLevelFarm() >= 50 && GetPlayerLevelFarm() <= 59)
            {
                int setPlayerExpForNextLvlFarm = GetPlayerLevelFarm() > 1 ? 20 * GetPlayerLevelFarm() * 7 : 40;
                {
                    try
                    {
                        string[] lines = File.ReadAllLines(filePath);
                        lines[21] = setPlayerExpForNextLvlFarm.ToString();
                        File.WriteAllLines(filePath, lines);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                    }
                }
            }
            else if (GetPlayerLevelFarm() >= 60 && GetPlayerLevelFarm() <= 70)
            {
                int setPlayerExpForNextLvlFarm = GetPlayerLevelFarm() > 1 ? 20 * GetPlayerLevelFarm() * 8 : 40;
                {
                    try
                    {
                        string[] lines = File.ReadAllLines(filePath);
                        lines[21] = setPlayerExpForNextLvlFarm.ToString();
                        File.WriteAllLines(filePath, lines);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                    }
                }
            }
        }
    }
    }
