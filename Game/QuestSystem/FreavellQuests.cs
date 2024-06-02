using Game.SkillsSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.QuestSystem
{
    internal class FreavellQuests
    {
        QuestRewards questRewards = new QuestRewards();

        //---------Хранится------bin-Debug-----net8.0-gamequestdata.txt---------------------------------------
        //-------------------------------------------СБРОС---СТАТОВ--Квестов-------------------------------
        public void ResetFreavellQuest()
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gamequestdata.txt");
            string[] lines =
            {"0", "0", "0", "0", "0", "0"};
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (string line in lines)
                {
                    writer.WriteLine(line);
                    Console.WriteLine("Инфо квестов " + line);
                }
            }
        }
        //###############################################################################################################################
        //-------------------------------------------Чтение---Убитых--Существ--Фреавелла---0--------------------------
        public int GetFreavellQuestMonsters()
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gamequestdata.txt");

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    //sr.ReadLine();
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
        //-------------------------------------------Чтение---Complete--Существ--Фреавелла---1--------------------------
        public int GetFreavellQuestMonstersComplete()
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gamequestdata.txt");

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
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
        //-------------------------------------------ЗАПИСЬ---Убитых--Существ--Фреавелла---0------------------------
        public void RecordFreavellQuestMonsters()
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gamequestdata.txt");
            int setFreavellQuestMonsters = GetFreavellQuestMonsters() + 1;
            {
                try
                {
                    string[] lines = File.ReadAllLines(filePath);
                    lines[0] = setFreavellQuestMonsters.ToString();
                    File.WriteAllLines(filePath, lines);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                }
            }
        }
        //-------------------------------------------ЗАПИСЬ---Complete-Quest-Существ--Фреавелла---1------------------------
        public void RecordFreavellQuestMonstersComplete()
        {
            if (GetFreavellQuestMonstersComplete() >= 20 && GetFreavellQuestMonstersComplete() != 1)
            {
                string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                string filePath = Path.Combine(directoryPath, "gamequestdata.txt");
                int setFreavellQuestMonsters = 1;
                {
                    try
                    {
                        string[] lines = File.ReadAllLines(filePath);
                        lines[1] = setFreavellQuestMonsters.ToString();
                        File.WriteAllLines(filePath, lines);
                        questRewards.RewardFreavellOne();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                    }
                }
            }
        }
        //###############################################################################################################################
        //-------------------------------------------Чтение---Complete--Существ--Фреавелла---2--------------------------
        public int GetFreavellQuestMonstersCompleteTwo()
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gamequestdata.txt");

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
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
        //-------------------------------------------ЗАПИСЬ---Complete-Quest-Существ--Фреавелла---2------------------------
        public void RecordFreavellQuestMonstersCompleteTwo()
        {
            if (GetFreavellQuestMonstersComplete() >= 60 && GetFreavellQuestMonstersCompleteTwo() != 1)
            {
                string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                string filePath = Path.Combine(directoryPath, "gamequestdata.txt");
                int setFreavellQuestMonsters = 1;
                {
                    try
                    {
                        string[] lines = File.ReadAllLines(filePath);
                        lines[2] = setFreavellQuestMonsters.ToString();
                        File.WriteAllLines(filePath, lines);
                        questRewards.RewardFreavellTwo();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                    }
                }
            }
        }
        //###############################################################################################################################
        //-------------------------------------------Чтение---Farm--Ресурсов--Фреавелла---3--------------------------
        public int GetFreavellQuestFarm()
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gamequestdata.txt");

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
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
        //-------------------------------------------Чтение---Complete--Farm--Ресурсов--Фреавелла---4--------------------------
        public int GetFreavellQuestFarmComplete()
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gamequestdata.txt");

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
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
        //-------------------------------------------ЗАПИСЬ---Farm--Ресурсов--Фреавелла---3------------------------
        public void RecordFreavellQuestFarm()
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gamequestdata.txt");
            int setFreavellQuestFarm = GetFreavellQuestFarm() + 1;
            {
                try
                {
                    string[] lines = File.ReadAllLines(filePath);
                    lines[3] = setFreavellQuestFarm.ToString();
                    File.WriteAllLines(filePath, lines);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                }
            }
        }
        //-------------------------------------------ЗАПИСЬ---Complete-Quest-Farm--Ресурсов--Фреавелла---4------------------------
        public void RecordFreavellQuestFarmComplete()
        {
            if (GetFreavellQuestFarmComplete() >= 20 && GetFreavellQuestFarmComplete() != 1)
            {
                string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                string filePath = Path.Combine(directoryPath, "gamequestdata.txt");
                int setFreavellQuestMonsters = 1;
                {
                    try
                    {
                        string[] lines = File.ReadAllLines(filePath);
                        lines[4] = setFreavellQuestMonsters.ToString();
                        File.WriteAllLines(filePath, lines);
                        questRewards.RewardFreavellOne();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                    }
                }
            }
        }
        //###############################################################################################################################
        //-------------------------------------------Чтение---Complete--Farm--Фреавелла---5--------------------------
        public int GetFreavellQuestFarmCompleteTwo()
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gamequestdata.txt");

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
                    int energyLine = int.Parse(line);
                    return energyLine;
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }
        //-------------------------------------------ЗАПИСЬ---Complete-Quest-Farm--Фреавелла---5------------------------
        public void RecordFreavellQuestFarmCompleteTwo()
        {
            if (GetFreavellQuestFarmComplete() >= 60 && GetFreavellQuestFarmCompleteTwo() != 1)
            {
                string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                string filePath = Path.Combine(directoryPath, "gamequestdata.txt");
                int setFreavellQuestFarm = 1;
                {
                    try
                    {
                        string[] lines = File.ReadAllLines(filePath);
                        lines[5] = setFreavellQuestFarm.ToString();
                        File.WriteAllLines(filePath, lines);
                        questRewards.RewardFreavellTwo();
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
