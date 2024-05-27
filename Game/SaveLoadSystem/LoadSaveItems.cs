using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    //0 weapon
    //1 helmet
    //2 armor
    //3 pants
    //4 boots
    //5 hpSmallBottle
    //6 hpNormalBottle
    //7 hpLargeBottle
    //8 mpSmallBottle
    //9 mpNormalBottle
    //10 mpLargeBottle
    //11 weapon stats
    //12 helmet stats
    //13 helmet stats
    //14 armor stats
    //15 armor stats
    //16 pants stats
    //17 pants stats
    //18 boots stats
    //19 boots stats

    internal class LoadSaveItems
    {
        LoadSavePlayer loadSavePlayer = new LoadSavePlayer();
        //---------Хранится------bin-Debug-----net8.0-gameitemdata.txt---------------------------------------
        //-------------------------------------------СБРОС---СТАТОВ--ВЕЩЕЙ-------------------------------
        public void ResetItemDataBase()
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameitemdata.txt");
            string[] lines =
            {"0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"};
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (string line in lines)
                {
                    writer.WriteLine(line);
                    Console.WriteLine("Статы Предметов " + line);
                }
            }
        }
        //-------------------------------------------ЧТЕНИЕ---SWORD--ИГРОКА-------------------------------
        public int GetItemSword()
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameitemdata.txt");

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line = sr.ReadLine();
                    int itemLine = int.Parse(line);
                    return itemLine;
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }
        //-------------------------------------------ЧТЕНИЕ---SWORD-STATS-ИГРОКА-------------------------------
        public int GetItemSwordStats()
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameitemdata.txt");

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
                    int itemLine = int.Parse(line);
                    return itemLine;
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }
        //-------------------------------------------ЧТЕНИЕ---HELMET-STAT-ONE-ИГРОКА-------------------------------
        public int GetItemHelmetStatOne()
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameitemdata.txt");

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
                    int itemLine = int.Parse(line);
                    return itemLine;
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }
        //-------------------------------------------ЧТЕНИЕ---HELMET-STAT-TWO-ИГРОКА-------------------------------
        public int GetItemHelmetStatTwo()
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameitemdata.txt");

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
                    int itemLine = int.Parse(line);
                    return itemLine;
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }
        //-------------------------------------------ЧТЕНИЕ---HELMET--ИГРОКА-------------------------------
        public int GetItemHelmet()
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameitemdata.txt");

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    sr.ReadLine();
                    string line = sr.ReadLine();
                    int itemLine = int.Parse(line);
                    return itemLine;
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }
        //-------------------------------------------ЧТЕНИЕ---ARMOR--ИГРОКА-------------------------------
        public int GetItemArmor()
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameitemdata.txt");

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    sr.ReadLine();
                    sr.ReadLine();
                    string line = sr.ReadLine();
                    int itemLine = int.Parse(line);
                    return itemLine;
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }
        //-------------------------------------------ЧТЕНИЕ-STATS-ONE-ARMOR--ИГРОКА-------------------------------
        public int GetItemArmorStatsOne()
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameitemdata.txt");

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
                    int itemLine = int.Parse(line);
                    return itemLine;
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }
        //-------------------------------------------ЧТЕНИЕ-STATS-TWO-ARMOR--ИГРОКА-------------------------------
        public int GetItemArmorStatsTwo()
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameitemdata.txt");

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
                    int itemLine = int.Parse(line);
                    return itemLine;
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }
        //-------------------------------------------ЧТЕНИЕ---PANTS--ИГРОКА-------------------------------
        public int GetItemPants()
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameitemdata.txt");

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    string line = sr.ReadLine();
                    int itemLine = int.Parse(line);
                    return itemLine;
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }
        //-------------------------------------------ЧТЕНИЕ---PANTS-Stats-One-ИГРОКА-------------------------------
        public int GetItemPantsStatsOne()
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameitemdata.txt");

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
                    int itemLine = int.Parse(line);
                    return itemLine;
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }
        //-------------------------------------------ЧТЕНИЕ---PANTS-Stats-Two-ИГРОКА-------------------------------
        public int GetItemPantsStatsTwo()
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameitemdata.txt");

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
                    int itemLine = int.Parse(line);
                    return itemLine;
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }
        //-------------------------------------------ЧТЕНИЕ---BOOTS--ИГРОКА-------------------------------
        public int GetItemBoots()
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameitemdata.txt");

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    string line = sr.ReadLine();
                    int itemLine = int.Parse(line);
                    return itemLine;
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }
        //-------------------------------------------ЧТЕНИЕ---BOOTS-StatsOne-ИГРОКА-------------------------------
        public int GetItemBootsStatsOne()
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameitemdata.txt");

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
                    int itemLine = int.Parse(line);
                    return itemLine;
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }
        //-------------------------------------------ЧТЕНИЕ---BOOTS-StatsTwo-ИГРОКА-------------------------------
        public int GetItemBootsStatsTwo()
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameitemdata.txt");

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
                    int itemLine = int.Parse(line);
                    return itemLine;
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }
        //-------------------------------------------ЧТЕНИЕ---HPSMALLPOTION--ИГРОКА-------------------------------
        public int GetItemHpSmallPotion()
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameitemdata.txt");

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    string line = sr.ReadLine();
                    int itemLine = int.Parse(line);
                    return itemLine;
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }
        //-------------------------------------------ЧТЕНИЕ---HPNORMALPOTION--ИГРОКА-------------------------------
        public int GetItemHpNormalPotion()
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameitemdata.txt");

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
                    int itemLine = int.Parse(line);
                    return itemLine;
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }
        //-------------------------------------------ЧТЕНИЕ---HPLARGEPOTION--ИГРОКА-------------------------------
        public int GetItemHpLargePotion()
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameitemdata.txt");

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
                    string line = sr.ReadLine();
                    int itemLine = int.Parse(line);
                    return itemLine;
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }
        //-------------------------------------------ЧТЕНИЕ---MPSMALLPOTION--ИГРОКА-------------------------------
        public int GetItemMpSmallPotion()
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameitemdata.txt");

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
                    int itemLine = int.Parse(line);
                    return itemLine;
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }
        //-------------------------------------------ЧТЕНИЕ---MPNORMALPOTION--ИГРОКА-------------------------------
        public int GetItemMpNormalPotion()
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameitemdata.txt");

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
                    string line = sr.ReadLine();
                    int itemLine = int.Parse(line);
                    return itemLine;
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }
        //-------------------------------------------ЧТЕНИЕ---MPLARGEPOTION--ИГРОКА-------------------------------
        public int GetItemMpLargePotion()
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameitemdata.txt");

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
                    int itemLine = int.Parse(line);
                    return itemLine;
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }
        //###########################################################################################################################################
        //-------------------------------------------ЗАПИСЬ---УРОВНЯ-ОРУЖИЯ-------------------------------
        public void RecordPlayerWeaponLevel()
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameitemdata.txt");
            int setWeaponAttackPlayer = GetItemSword() + 1;
            {
                try
                {
                    string[] lines = File.ReadAllLines(filePath);
                    lines[0] = setWeaponAttackPlayer.ToString();
                    File.WriteAllLines(filePath, lines);

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                }
            }
        }
        //-----------------------ЗАПИСЬ---УРОНА-ОТ-ОРУЖИЯ---ИСПОЛЬЗОВАТЬ--ДАННЫЙ--МЕТОД---ПРЕДИДУЩИЙ--ЗАПИСЫВАЕТ--УРОВЕНЬ--ПРЕДМЕТА---------------
        public void RecordPlayerWeaponAttack()
        {
            RecordPlayerWeaponLevel();
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameitemdata.txt");
            int setPlayerAttack = GetItemSword() * 8;
            {
                try
                {
                    if (GetItemSword() <= 29)
                    {
                        string[] lines = File.ReadAllLines(filePath);
                        lines[11] = setPlayerAttack.ToString();
                        File.WriteAllLines(filePath, lines);
                    }
                    else
                    {
                        Console.WriteLine("Достигнут максимальный уровень!");
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                }
            }
        }
    //###########################################################################################################################################
    //-------------------------------------------ЗАПИСЬ---УРОВНЯ--ШЛЕМА------------------------------
        public void RecordPlayerHelmetLevel()
    {
        string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
        string filePath = Path.Combine(directoryPath, "gameitemdata.txt");
        int setHelmetPlayer = GetItemHelmet() + 1;
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath);
                lines[1] = setHelmetPlayer.ToString();
                File.WriteAllLines(filePath, lines);

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
            }
        }
    }
        //-----------------------ЗАПИСЬ---ШЛЕМА----ИСПОЛЬЗОВАТЬ--ДАННЫЙ--МЕТОД---ПРЕДИДУЩИЙ--ЗАПИСЫВАЕТ--УРОВЕНЬ--ПРЕДМЕТА---------------
        public void RecordPlayerHelmetStats()
        {
            RecordPlayerHelmetLevel();
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameitemdata.txt");
            int setHelmetMpPlayer = GetItemHelmet() * 2;
            int setHelmetDefPlayer = GetItemHelmet() * 1;
            {
                try
                {
                    if (GetItemHelmet() <= 29)
                    {
                        string[] lines = File.ReadAllLines(filePath);
                        lines[12] = setHelmetMpPlayer.ToString();
                        lines[13] = setHelmetDefPlayer.ToString();
                        File.WriteAllLines(filePath, lines);
                    }
                    else
                    {
                        Console.WriteLine("Достигнут максимальный уровень!");
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                }
            }
        }
        //###########################################################################################################################################
        //-------------------------------------------ЗАПИСЬ---УРОВНЯ--Armor------------------------------
        public void RecordPlayerArmorLevel()
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameitemdata.txt");
            int setArmorPlayer = GetItemArmor() + 1;
            {
                try
                {
                    string[] lines = File.ReadAllLines(filePath);
                    lines[2] = setArmorPlayer.ToString();
                    File.WriteAllLines(filePath, lines);

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                }
            }
        }
        //-----------------------ЗАПИСЬ---Armor----ИСПОЛЬЗОВАТЬ--ДАННЫЙ--МЕТОД---ПРЕДИДУЩИЙ--ЗАПИСЫВАЕТ--УРОВЕНЬ--ПРЕДМЕТА---------------
        public void RecordPlayerArmorStats()
        {
            RecordPlayerArmorLevel();
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameitemdata.txt");
            int setArmorHpPlayer = GetItemArmor() * 26;
            int setArmorDefPlayer = GetItemArmor() * 1;
            {
                try
                {
                    if (GetItemArmor() <= 29)
                    {
                        string[] lines = File.ReadAllLines(filePath);
                        lines[14] = setArmorHpPlayer.ToString();
                        lines[15] = setArmorDefPlayer.ToString();
                        File.WriteAllLines(filePath, lines);
                    }
                    else
                    {
                        Console.WriteLine("Достигнут максимальный уровень!");
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                }
            }
        }
        //###########################################################################################################################################
        //-------------------------------------------ЗАПИСЬ---УРОВНЯ--Pants------------------------------
        public void RecordPlayerPantsLevel()
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameitemdata.txt");
            int setPantsPlayer = GetItemPants() + 1;
            {
                try
                {
                    string[] lines = File.ReadAllLines(filePath);
                    lines[3] = setPantsPlayer.ToString();
                    File.WriteAllLines(filePath, lines);

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при перезаписи строки в файле эх: {ex.Message}");
                }
            }
        }
        //-----------------------ЗАПИСЬ---Pants----ИСПОЛЬЗОВАТЬ--ДАННЫЙ--МЕТОД---ПРЕДИДУЩИЙ--ЗАПИСЫВАЕТ--УРОВЕНЬ--ПРЕДМЕТА---------------
        public void RecordPlayerPantsStats()
        {
            RecordPlayerPantsLevel();
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameitemdata.txt");
            int setPantsCritPlayer = GetItemPants() * 1;
            int setPantsDefPlayer = GetItemPants() * 1;
            {
                try
                {
                    if (GetItemPants() <= 29)
                    {
                        string[] lines = File.ReadAllLines(filePath);
                        lines[16] = setPantsCritPlayer.ToString();
                        lines[17] = setPantsDefPlayer.ToString();
                        File.WriteAllLines(filePath, lines);
                    }
                    else
                    {
                        Console.WriteLine("Достигнут максимальный уровень!");
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                }
            }
        }
        //###########################################################################################################################################
        //-------------------------------------------ЗАПИСЬ---УРОВНЯ--Boots------------------------------
        public void RecordPlayerBootsLevel()
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameitemdata.txt");
            int setBootsPlayer = GetItemBoots() + 1;
            {
                try
                {
                    string[] lines = File.ReadAllLines(filePath);
                    lines[4] = setBootsPlayer.ToString();
                    File.WriteAllLines(filePath, lines);

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                }
            }
        }
        //-----------------------ЗАПИСЬ---Boots----ИСПОЛЬЗОВАТЬ--ДАННЫЙ--МЕТОД---ПРЕДИДУЩИЙ--ЗАПИСЫВАЕТ--УРОВЕНЬ--ПРЕДМЕТА---------------
        public void RecordPlayerBootsStats()
        {
            RecordPlayerBootsLevel();
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameitemdata.txt");
            int setBootsDodgePlayer = GetItemBoots() * 1;
            int setBootsDefPlayer = GetItemBoots() * 1;
            {
                try
                {
                    if (GetItemBoots() <= 29)
                    {
                        string[] lines = File.ReadAllLines(filePath);
                        lines[18] = setBootsDodgePlayer.ToString();
                        lines[19] = setBootsDefPlayer.ToString();
                        File.WriteAllLines(filePath, lines);
                    }
                    else
                    {
                        Console.WriteLine("Достигнут максимальный уровень!");
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при перезаписи строки в файле!: {ex.Message}");
                }
            }
        }
    }
}
