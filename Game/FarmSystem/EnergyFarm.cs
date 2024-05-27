using Game.Enemies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.FarmSystem
{
    internal class EnergyFarm
    {
        public void EnergyFarmOne()
        {
                LoadSavePlayer loadSavePlayer = new LoadSavePlayer();

                if (loadSavePlayer.GetPlayerLevel() >= 2 && loadSavePlayer.GetPlayerBronze() >= 1)
                {
                    //оплата крафта энергии
                    int BronzeEnergySell = loadSavePlayer.GetPlayerBronze() - 1;
                    string directoryPathEnergySell = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathEnergySell = Path.Combine(directoryPathEnergySell, "gameplayerdata.txt");
                    string[] linesEnergySell = File.ReadAllLines(filePathEnergySell);
                    linesEnergySell[10] = BronzeEnergySell.ToString();
                    File.WriteAllLines(filePathEnergySell, linesEnergySell);
                    Console.WriteLine("Оплачено: " + BronzeEnergySell + " Бронзы");

                    Console.WriteLine("1: Создание потусторонеей Энергии начато! Ждите!");

                    Random random = new Random();
                    string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");
                    int randomEnergyDrop = random.Next(1, 16);

                    if (randomEnergyDrop == 1)
                    {
                        int setPlayerEnergy = loadSavePlayer.GetPlayerEnergy() + 3;
                        {
                            try
                            {
                                string[] lines = File.ReadAllLines(filePath);
                                lines[18] = setPlayerEnergy.ToString();
                                File.WriteAllLines(filePath, lines);
                                Thread.Sleep(2000);
                                Console.WriteLine("Получено Три очка Энергии, теперь у вас: " + loadSavePlayer.GetPlayerEnergy() + " Энергии");
                        }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                            }
                        }
                    }
                    else if (randomEnergyDrop == 2 && randomEnergyDrop <= 4)
                    {
                        int setPlayerEnergy = loadSavePlayer.GetPlayerEnergy() + 2;
                        {
                            try
                            {
                                string[] lines = File.ReadAllLines(filePath);
                                lines[18] = setPlayerEnergy.ToString();
                                File.WriteAllLines(filePath, lines);
                                Thread.Sleep(2000);
                                Console.WriteLine("Получено Два очка Энергии, теперь у вас: " + loadSavePlayer.GetPlayerEnergy() + " Энергии");
                        }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                            }
                        }
                    }
                    else
                    {
                        int setPlayerEnergy = loadSavePlayer.GetPlayerEnergy() + 1;
                        {
                            try
                            {
                                string[] lines = File.ReadAllLines(filePath);
                                lines[18] = setPlayerEnergy.ToString();
                                File.WriteAllLines(filePath, lines);
                                Thread.Sleep(2000);
                                Console.WriteLine("Получено Одно очко Энергии, теперь у вас: " + loadSavePlayer.GetPlayerEnergy() + " Энергии");
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
                    Console.WriteLine("Необходимо достигнуть второго уровня, либо");
                    Console.WriteLine("имень в наличии минимум 1 бронзовую монету!");
                }
            }
        }
    }
