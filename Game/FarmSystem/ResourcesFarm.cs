using Game.SaveLoadSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.FarmSystem
{
    internal class ResourcesFarm
    {

        public void ResourcesFarmOne()
        {
            LoadSavePlayer loadSavePlayer = new LoadSavePlayer();
            LevelUpSystem levelUpSystem = new LevelUpSystem();

            if (loadSavePlayer.GetPlayerLevelFarm() >= 2 && loadSavePlayer.GetPlayerEnergy() >= 1)
            {
                //оплата крафта энергии
                int EnergyResourcesSell = loadSavePlayer.GetPlayerEnergy() - 1;
                string directoryPathResourcesSell = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                string filePathResourcesSell = Path.Combine(directoryPathResourcesSell, "gameplayerdata.txt");
                string[] linesResourcesSell = File.ReadAllLines(filePathResourcesSell);
                linesResourcesSell[18] = EnergyResourcesSell.ToString();
                File.WriteAllLines(filePathResourcesSell, linesResourcesSell);
                Console.WriteLine("Оплачено: " + EnergyResourcesSell + " Энергии");

                Console.WriteLine("1: Добыча ресурсов начата! Ждите!");

                Random random = new Random();
                string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");
                int randomResourcesDrop = random.Next(1, 16);

                if (randomResourcesDrop == 1)
                {
                    int setPlayerResources = loadSavePlayer.GetPlayerResources() + 3;
                    {
                        try
                        {
                            string[] lines = File.ReadAllLines(filePath);
                            lines[15] = setPlayerResources.ToString();
                            File.WriteAllLines(filePath, lines);
                            Thread.Sleep(4000);
                            Console.WriteLine("Получено Три очка Ресурсов, теперь у вас: " + loadSavePlayer.GetPlayerResources() + " Ресурсов");

                            //##############################################################################################################
                            //Запись дропа экспы
                            int expDropFarm = loadSavePlayer.GetPlayerExpAmountFarm() + 3;
                            string directoryPathFarm = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                            string filePathFarm = Path.Combine(directoryPathFarm, "gameplayerdata.txt");
                            string[] linesFarm = File.ReadAllLines(filePathFarm);
                            linesFarm[20] = expDropFarm.ToString();
                            File.WriteAllLines(filePathFarm, linesFarm);
                            Console.WriteLine("Получено 3 очка Опыта Профессий");
                            //прокрутка и если нужно повышение уровня
                            levelUpSystem.RecordPlayerLevelUpFarm();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                        }
                    }
                }
                else if (randomResourcesDrop == 2 && randomResourcesDrop <= 4)
                {
                    int setPlayerResources = loadSavePlayer.GetPlayerResources() + 2;
                    {
                        try
                        {
                            string[] lines = File.ReadAllLines(filePath);
                            lines[15] = setPlayerResources.ToString();
                            File.WriteAllLines(filePath, lines);
                            Thread.Sleep(4000);
                            Console.WriteLine("Получено Два очка Ресурсов, теперь у вас: " + loadSavePlayer.GetPlayerResources() + " Ресурсов");

                            //##############################################################################################################
                            //Запись дропа экспы
                            int expDropFarm = loadSavePlayer.GetPlayerExpAmountFarm() + 2;
                            string directoryPathFarm = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                            string filePathFarm = Path.Combine(directoryPathFarm, "gameplayerdata.txt");
                            string[] linesFarm = File.ReadAllLines(filePathFarm);
                            linesFarm[20] = expDropFarm.ToString();
                            File.WriteAllLines(filePathFarm, linesFarm);
                            Console.WriteLine("Получено 2 очка Опыта Профессий");
                            //прокрутка и если нужно повышение уровня
                            levelUpSystem.RecordPlayerLevelUpFarm();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                        }
                    }
                }
                else
                {
                    int setPlayerResources = loadSavePlayer.GetPlayerResources() + 1;
                    {
                        try
                        {
                            string[] lines = File.ReadAllLines(filePath);
                            lines[15] = setPlayerResources.ToString();
                            File.WriteAllLines(filePath, lines);
                            Thread.Sleep(4000);
                            Console.WriteLine("Получено Одно очко Ресурсов, теперь у вас: " + loadSavePlayer.GetPlayerResources() + " Ресурсов");


                            //##############################################################################################################
                            //Запись дропа экспы
                            int expDropFarm = loadSavePlayer.GetPlayerExpAmountFarm() + 1;
                            string directoryPathFarm = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                            string filePathFarm = Path.Combine(directoryPathFarm, "gameplayerdata.txt");
                            string[] linesFarm = File.ReadAllLines(filePathFarm);
                            linesFarm[20] = expDropFarm.ToString();
                            File.WriteAllLines(filePathFarm, linesFarm);
                            Console.WriteLine("Получено 1 очко Опыта Профессий");
                            //прокрутка и если нужно повышение уровня
                            levelUpSystem.RecordPlayerLevelUpFarm();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Необходимо достигнуть 2 уровня, профессий ");
                Console.WriteLine("имень в наличии минимум 1 енергии!");
            }
        }
    }

}