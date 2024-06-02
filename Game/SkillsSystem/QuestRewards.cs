using Game.Enemies;
using Game.SaveLoadSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.SkillsSystem
{
    internal class QuestRewards
    {
        LoadSavePlayer loadSavePlayer = new LoadSavePlayer();
        LevelUpSystem levelUpSystem = new LevelUpSystem();
        public void RewardFreavellOne()
        {
            //Запись дропа экспы
            int expDrop = loadSavePlayer.GetPlayerExpAmount() + 80;
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");
            string[] lines = File.ReadAllLines(filePath);
            lines[16] = expDrop.ToString();
            File.WriteAllLines(filePath, lines);
            Console.WriteLine("Получено: " + "80" + " Опыта");
            //прокрутка и если нужно повышение уровня
            levelUpSystem.RecordPlayerLevelUp();

            //Запись дропа голды
            int BronzeDropOne = loadSavePlayer.GetPlayerBronze() + 40;
            string directoryPathTwo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePathTwo = Path.Combine(directoryPathTwo, "gameplayerdata.txt");
            string[] linesTwo = File.ReadAllLines(filePath);
            lines[10] = BronzeDropOne.ToString();
            File.WriteAllLines(filePathTwo, linesTwo);
            Console.WriteLine("Получено: " + "40" + " Бронзы");

        }

        public void RewardFreavellTwo()
        {
            //Запись дропа экспы
            int expDrop = loadSavePlayer.GetPlayerExpAmount() + 160;
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");
            string[] lines = File.ReadAllLines(filePath);
            lines[16] = expDrop.ToString();
            File.WriteAllLines(filePath, lines);
            Console.WriteLine("Получено: " + "160" + " Опыта");
            //прокрутка и если нужно повышение уровня
            levelUpSystem.RecordPlayerLevelUp();

            //Запись дропа голды
            int BronzeDropOne = loadSavePlayer.GetPlayerBronze() + 80;
            string directoryPathTwo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePathTwo = Path.Combine(directoryPathTwo, "gameplayerdata.txt");
            string[] linesTwo = File.ReadAllLines(filePath);
            lines[10] = BronzeDropOne.ToString();
            File.WriteAllLines(filePathTwo, linesTwo);
            Console.WriteLine("Получено: " + "80" + " Бронзы");

        }
    }
}
