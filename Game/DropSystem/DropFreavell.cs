using Game.BattleSystem;
using Game.Enemies;
using Game.SaveLoadSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.DropSystem
{
    internal class DropFreavell
    {
        EnemyFreavell enemyFreavell = new EnemyFreavell();
        LoadSavePlayer loadSavePlayer = new LoadSavePlayer();
        LevelUpSystem levelUpSystem = new LevelUpSystem();  
        Random rand = new Random();
        public void DropFreavellOne()
        {
            //Запись дропа экспы
            int expDrop = loadSavePlayer.GetPlayerExpAmount() + enemyFreavell.expEnemyFreavellOne;
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");
            string[] lines = File.ReadAllLines(filePath);
            lines[16] = expDrop.ToString();
            File.WriteAllLines(filePath, lines);
            //прокрутка и если нужно повышение уровня
            levelUpSystem.RecordPlayerLevelUp();

            //####################################################################################################################
            //Запись энергии игрока
            int energyMinus = loadSavePlayer.GetPlayerExpAmount() - 1;
            string directoryPathEnergy = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePathEnergy = Path.Combine(directoryPathEnergy, "gameplayerdata.txt");
            string[] linesEnergy = File.ReadAllLines(filePathEnergy);
            lines[18] = energyMinus.ToString();
            File.WriteAllLines(filePathEnergy, linesEnergy);

            //Рандом дропа голды
            int randomBronzeDrop = rand.Next(1, 11);
            if (randomBronzeDrop > 5)
            {
                //Запись дропа голды
                int BronzeDropOne = loadSavePlayer.GetPlayerBronze() + enemyFreavell.bronzeEnemyFreavellOne;
                string directoryPathTwo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                string filePathTwo = Path.Combine(directoryPathTwo, "gameplayerdata.txt");
                string[] linesTwo = File.ReadAllLines(filePath);
                lines[10] = BronzeDropOne.ToString();
                File.WriteAllLines(filePathTwo, linesTwo);
                Console.WriteLine("Получено: " + BronzeDropOne + " Бронзы");
            }
            else if (randomBronzeDrop == 5 && randomBronzeDrop == 4)
            {
                //Запись дропа голды + 1
                int BronzeDropTwo = loadSavePlayer.GetPlayerBronze() + enemyFreavell.bronzeEnemyFreavellOne + 1;
                string directoryPathTwo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                string filePathThree = Path.Combine(directoryPathTwo, "gameplayerdata.txt");
                string[] linesThree = File.ReadAllLines(filePath);
                lines[10] = BronzeDropTwo.ToString();
                File.WriteAllLines(filePathThree, linesThree);
                Console.WriteLine("Получено: " + BronzeDropTwo + " Бронзы");
            }
            else
            {
                //Нет дропа голды
            }
        }
        public void DropFreavellTwo()
        {
            //Запись дропа экспы
            int expDrop = loadSavePlayer.GetPlayerExpAmount() + enemyFreavell.expEnemyFreavellTwo;
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");
            string[] lines = File.ReadAllLines(filePath);
            lines[16] = expDrop.ToString();
            File.WriteAllLines(filePath, lines);
            //прокрутка и если нужно повышение уровня
            levelUpSystem.RecordPlayerLevelUp();

            //Рандом дропа голды
            int randomBronzeDrop = rand.Next(1, 11);
            if (randomBronzeDrop > 5)
            {
                //Запись дропа голды
                int BronzeDropOne = loadSavePlayer.GetPlayerBronze() + enemyFreavell.bronzeEnemyFreavellTwo;
                string directoryPathTwo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                string filePathTwo = Path.Combine(directoryPathTwo, "gameplayerdata.txt");
                string[] linesTwo = File.ReadAllLines(filePath);
                lines[10] = BronzeDropOne.ToString();
                File.WriteAllLines(filePathTwo, linesTwo);
                Console.WriteLine("Получено: " + BronzeDropOne + " Бронзы");
            }
            else if (randomBronzeDrop == 5 && randomBronzeDrop == 4)
            {
                //Запись дропа голды + 1
                int BronzeDropTwo = loadSavePlayer.GetPlayerBronze() + enemyFreavell.bronzeEnemyFreavellTwo + 1;
                string directoryPathTwo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                string filePathThree = Path.Combine(directoryPathTwo, "gameplayerdata.txt");
                string[] linesThree = File.ReadAllLines(filePath);
                lines[10] = BronzeDropTwo.ToString();
                File.WriteAllLines(filePathThree, linesThree);
                Console.WriteLine("Получено: " + BronzeDropTwo + " Бронзы");
            }
            else
            {
                //Нет дропа голды
            }
        }
        public void DropFreavellThree()
        {
            //Запись дропа экспы
            int expDrop = loadSavePlayer.GetPlayerExpAmount() + enemyFreavell.expEnemyFreavellThree;
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");
            string[] lines = File.ReadAllLines(filePath);
            lines[16] = expDrop.ToString();
            File.WriteAllLines(filePath, lines);
            //прокрутка и если нужно повышение уровня
            levelUpSystem.RecordPlayerLevelUp();

            //Рандом дропа голды
            int randomBronzeDrop = rand.Next(1, 11);
            if (randomBronzeDrop > 5)
            {
                //Запись дропа голды
                int BronzeDropOne = loadSavePlayer.GetPlayerBronze() + enemyFreavell.bronzeEnemyFreavellThree;
                string directoryPathTwo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                string filePathTwo = Path.Combine(directoryPathTwo, "gameplayerdata.txt");
                string[] linesTwo = File.ReadAllLines(filePath);
                lines[10] = BronzeDropOne.ToString();
                File.WriteAllLines(filePathTwo, linesTwo);
                Console.WriteLine("Получено: " + BronzeDropOne + " Бронзы");
            }
            else if (randomBronzeDrop == 5 && randomBronzeDrop == 4)
            {
                //Запись дропа голды + 1
                int BronzeDropTwo = loadSavePlayer.GetPlayerBronze() + enemyFreavell.bronzeEnemyFreavellThree + 1;
                string directoryPathTwo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                string filePathThree = Path.Combine(directoryPathTwo, "gameplayerdata.txt");
                string[] linesThree = File.ReadAllLines(filePath);
                lines[10] = BronzeDropTwo.ToString();
                File.WriteAllLines(filePathThree, linesThree);
                Console.WriteLine("Получено: " + BronzeDropTwo + " Бронзы");
            }
            else
            {
                //Нет дропа голды
            }
        }
        public void DropFreavellFour()
        {
            //Запись дропа экспы
            int expDrop = loadSavePlayer.GetPlayerExpAmount() + enemyFreavell.expEnemyFreavellFour;
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");
            string[] lines = File.ReadAllLines(filePath);
            lines[16] = expDrop.ToString();
            File.WriteAllLines(filePath, lines);
            //прокрутка и если нужно повышение уровня
            levelUpSystem.RecordPlayerLevelUp();

            //Рандом дропа голды
            int randomBronzeDrop = rand.Next(1, 11);
            if (randomBronzeDrop > 5)
            {
                //Запись дропа голды
                int BronzeDropOne = loadSavePlayer.GetPlayerBronze() + enemyFreavell.bronzeEnemyFreavellFour;
                string directoryPathTwo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                string filePathTwo = Path.Combine(directoryPathTwo, "gameplayerdata.txt");
                string[] linesTwo = File.ReadAllLines(filePath);
                lines[10] = BronzeDropOne.ToString();
                File.WriteAllLines(filePathTwo, linesTwo);
                Console.WriteLine("Получено: " + BronzeDropOne + " Бронзы");
            }
            else if (randomBronzeDrop == 5 && randomBronzeDrop == 4)
            {
                //Запись дропа голды + 1
                int BronzeDropTwo = loadSavePlayer.GetPlayerBronze() + enemyFreavell.bronzeEnemyFreavellFour + 1;
                string directoryPathTwo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                string filePathThree = Path.Combine(directoryPathTwo, "gameplayerdata.txt");
                string[] linesThree = File.ReadAllLines(filePath);
                lines[10] = BronzeDropTwo.ToString();
                File.WriteAllLines(filePathThree, linesThree);
                Console.WriteLine("Получено: " + BronzeDropTwo + " Бронзы");
            }
            else
            {
                //Нет дропа голды
            }
        }
        public void DropFreavellFive()
        {
            //Запись дропа экспы
            int expDrop = loadSavePlayer.GetPlayerExpAmount() + enemyFreavell.expEnemyFreavellFive;
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");
            string[] lines = File.ReadAllLines(filePath);
            lines[16] = expDrop.ToString();
            File.WriteAllLines(filePath, lines);
            //прокрутка и если нужно повышение уровня
            levelUpSystem.RecordPlayerLevelUp();

            //Рандом дропа голды
            int randomBronzeDrop = rand.Next(1, 11);
            if (randomBronzeDrop > 5)
            {
                //Запись дропа голды
                int BronzeDropOne = loadSavePlayer.GetPlayerBronze() + enemyFreavell.bronzeEnemyFreavellFive;
                string directoryPathTwo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                string filePathTwo = Path.Combine(directoryPathTwo, "gameplayerdata.txt");
                string[] linesTwo = File.ReadAllLines(filePath);
                lines[10] = BronzeDropOne.ToString();
                File.WriteAllLines(filePathTwo, linesTwo);
                Console.WriteLine("Получено: " + BronzeDropOne + " Бронзы");
            }
            else if (randomBronzeDrop == 5 && randomBronzeDrop == 4)
            {
                //Запись дропа голды + 1
                int BronzeDropTwo = loadSavePlayer.GetPlayerBronze() + enemyFreavell.bronzeEnemyFreavellFive + 1;
                string directoryPathTwo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                string filePathThree = Path.Combine(directoryPathTwo, "gameplayerdata.txt");
                string[] linesThree = File.ReadAllLines(filePath);
                lines[10] = BronzeDropTwo.ToString();
                File.WriteAllLines(filePathThree, linesThree);
                Console.WriteLine("Получено: " + BronzeDropTwo + " Бронзы");
            }
            else
            {
                //Нет дропа голды
            }
        }
        //###############################################################################################################
        //-----------------------------------BOSSES-----------------------------------------------------------------------
        //-----------------------------------BOSS-----1------------------------------------------------------------------
        public void DropFreavellBossOne()
        {
            //Запись дропа экспы
            int expDrop = loadSavePlayer.GetPlayerExpAmount() + enemyFreavell.expEnemyFreavellBossOne;
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");
            string[] lines = File.ReadAllLines(filePath);
            lines[16] = expDrop.ToString();
            File.WriteAllLines(filePath, lines);
            //прокрутка и если нужно повышение уровня
            levelUpSystem.RecordPlayerLevelUp();

            //Рандом дропа голды
            int randomBronzeDrop = rand.Next(1, 11);
            if (randomBronzeDrop > 5)
            {
                //Запись дропа голды
                int BronzeDropTwo = loadSavePlayer.GetPlayerBronze() + enemyFreavell.bronzeEnemyFreavellBossOne;
                string directoryPathTwo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                string filePathTwo = Path.Combine(directoryPathTwo, "gameplayerdata.txt");
                string[] linesTwo = File.ReadAllLines(filePath);
                linesTwo[10] = BronzeDropTwo.ToString();
                File.WriteAllLines(filePathTwo, linesTwo);
                Console.WriteLine("Получено: " + BronzeDropTwo + " Бронзы");
            }
            else if (randomBronzeDrop == 5 && randomBronzeDrop == 4)
            {
                //Запись дропа голды + 1
                int BronzeDropThree = loadSavePlayer.GetPlayerBronze() + enemyFreavell.bronzeEnemyFreavellBossOne + 1;
                string directoryPathThree = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                string filePathThree = Path.Combine(directoryPathThree, "gameplayerdata.txt");
                string[] linesThree = File.ReadAllLines(filePathThree);
                linesThree[10] = BronzeDropThree.ToString();
                File.WriteAllLines(filePathThree, linesThree);
                Console.WriteLine("Получено: " + BronzeDropThree + " Бронзы");
            }
            else
            {
                //Нет дропа голды
            }

            //Рандом дропа diamond
            int randomDiamondDrop = rand.Next(1, 11);
            if (randomDiamondDrop < 4)
            {
                //Запись дропа diamond
                int DiamondDropFour = loadSavePlayer.GetPlayerDiamond() + enemyFreavell.diamondEnemyFreavellBossOne;
                string directoryPathFour = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                string filePathFour = Path.Combine(directoryPathFour, "gameplayerdata.txt");
                string[] linesFour = File.ReadAllLines(filePathFour);
                linesFour[13] = DiamondDropFour.ToString();
                File.WriteAllLines(filePathFour, linesFour);
                Console.WriteLine("Получено: " + DiamondDropFour + " Алмазов");
            }
            else
            {
                //Нет дропа diamond
            }
        }
        //----------------------------------------------------------BOSS------2--------------------------------------------------------
        public void DropFreavellBossTwo()
        {
            //Запись дропа экспы
            int expDrop = loadSavePlayer.GetPlayerExpAmount() + enemyFreavell.expEnemyFreavellBossTwo;
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");
            string[] lines = File.ReadAllLines(filePath);
            lines[16] = expDrop.ToString();
            File.WriteAllLines(filePath, lines);
            //прокрутка и если нужно повышение уровня
            levelUpSystem.RecordPlayerLevelUp();

            //Рандом дропа голды
            int randomBronzeDrop = rand.Next(1, 11);
            if (randomBronzeDrop > 5)
            {
                //Запись дропа голды
                int BronzeDropTwo = loadSavePlayer.GetPlayerBronze() + enemyFreavell.bronzeEnemyFreavellBossOne;
                string directoryPathTwo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                string filePathTwo = Path.Combine(directoryPathTwo, "gameplayerdata.txt");
                string[] linesTwo = File.ReadAllLines(filePath);
                linesTwo[10] = BronzeDropTwo.ToString();
                File.WriteAllLines(filePathTwo, linesTwo);
                Console.WriteLine("Получено: " + BronzeDropTwo + " Бронзы");
            }
            else if (randomBronzeDrop == 5 && randomBronzeDrop == 4)
            {
                //Запись дропа голды + 1
                int BronzeDropThree = loadSavePlayer.GetPlayerBronze() + enemyFreavell.bronzeEnemyFreavellBossOne + 1;
                string directoryPathThree = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                string filePathThree = Path.Combine(directoryPathThree, "gameplayerdata.txt");
                string[] linesThree = File.ReadAllLines(filePathThree);
                linesThree[10] = BronzeDropThree.ToString();
                File.WriteAllLines(filePathThree, linesThree);
                Console.WriteLine("Получено: " + BronzeDropThree + " Бронзы");
            }
            else
            {
                //Нет дропа голды
            }

            //Рандом дропа diamond
            int randomDiamondDrop = rand.Next(1, 11);
            if (randomDiamondDrop < 4)
            {
                //Запись дропа diamond
                int DiamondDropFour = loadSavePlayer.GetPlayerDiamond() + enemyFreavell.diamondEnemyFreavellBossOne;
                string directoryPathFour = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                string filePathFour = Path.Combine(directoryPathFour, "gameplayerdata.txt");
                string[] linesFour = File.ReadAllLines(filePathFour);
                linesFour[13] = DiamondDropFour.ToString();
                File.WriteAllLines(filePathFour, linesFour);
                Console.WriteLine("Получено: " + DiamondDropFour + " Алмазов");
            }
            else
            {
                //Нет дропа diamond
            }
        }
        //----------------------------------------------------BOSS------------3--------------------------------------------------------
        public void DropFreavellBossThree()
        {
            //Запись дропа экспы
            int expDrop = loadSavePlayer.GetPlayerExpAmount() + enemyFreavell.expEnemyFreavellBossThree;
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");
            string[] lines = File.ReadAllLines(filePath);
            lines[16] = expDrop.ToString();
            File.WriteAllLines(filePath, lines);
            //прокрутка и если нужно повышение уровня
            levelUpSystem.RecordPlayerLevelUp();

            //Рандом дропа голды
            int randomBronzeDrop = rand.Next(1, 11);
            if (randomBronzeDrop > 5)
            {
                //Запись дропа голды
                int BronzeDropTwo = loadSavePlayer.GetPlayerBronze() + enemyFreavell.bronzeEnemyFreavellBossOne;
                string directoryPathTwo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                string filePathTwo = Path.Combine(directoryPathTwo, "gameplayerdata.txt");
                string[] linesTwo = File.ReadAllLines(filePath);
                linesTwo[10] = BronzeDropTwo.ToString();
                File.WriteAllLines(filePathTwo, linesTwo);
                Console.WriteLine("Получено: " + BronzeDropTwo + " Бронзы");
            }
            else if (randomBronzeDrop == 5 && randomBronzeDrop == 4)
            {
                //Запись дропа голды + 1
                int BronzeDropThree = loadSavePlayer.GetPlayerBronze() + enemyFreavell.bronzeEnemyFreavellBossOne + 1;
                string directoryPathThree = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                string filePathThree = Path.Combine(directoryPathThree, "gameplayerdata.txt");
                string[] linesThree = File.ReadAllLines(filePathThree);
                linesThree[10] = BronzeDropThree.ToString();
                File.WriteAllLines(filePathThree, linesThree);
                Console.WriteLine("Получено: " + BronzeDropThree + " Бронзы");
            }
            else
            {
                //Нет дропа голды
            }

            //Рандом дропа diamond
            int randomDiamondDrop = rand.Next(1, 11);
            if (randomDiamondDrop < 4)
            {
                //Запись дропа diamond
                int DiamondDropFour = loadSavePlayer.GetPlayerDiamond() + enemyFreavell.diamondEnemyFreavellBossOne;
                string directoryPathFour = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                string filePathFour = Path.Combine(directoryPathFour, "gameplayerdata.txt");
                string[] linesFour = File.ReadAllLines(filePathFour);
                linesFour[13] = DiamondDropFour.ToString();
                File.WriteAllLines(filePathFour, linesFour);
                Console.WriteLine("Получено: " + DiamondDropFour + " Алмазов");
            }
            else
            {
                //Нет дропа diamond
            }
        }
    }
}
