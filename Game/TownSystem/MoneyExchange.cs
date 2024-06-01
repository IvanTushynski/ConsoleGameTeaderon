using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.TownSystem
{
    internal class MoneyExchange
    {
        LoadSavePlayer loadSavePlayer = new LoadSavePlayer();

        //-------------------------------------------------------------Бронза в серебро-------------------------------------------------------
        public void BronzeToSilver()
        {
            LoadSavePlayer loadSavePlayer = new LoadSavePlayer();

            if (loadSavePlayer.GetPlayerBronze() >= 100)
            {
                //уменьшение денег
                string directoryPathMoneyMinus = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                string filePathMoneyMinus = Path.Combine(directoryPathMoneyMinus, "gameplayerdata.txt");
                int setPlayerMoneyMinus = loadSavePlayer.GetPlayerBronze() - 100;
                {
                    try
                    {
                        string[] linesMoneyMinus = File.ReadAllLines(filePathMoneyMinus);
                        linesMoneyMinus[10] = setPlayerMoneyMinus.ToString();
                        File.WriteAllLines(filePathMoneyMinus, linesMoneyMinus);

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                    }

                }

                //увеличение денег
                string directoryPathMoneyPlus = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                string filePathMoneyPlus = Path.Combine(directoryPathMoneyPlus, "gameplayerdata.txt");
                int setPlayerMoneyPlus = loadSavePlayer.GetPlayerSilver() + 1;
                {
                    try
                    {
                        string[] linesMoneyPlus = File.ReadAllLines(filePathMoneyPlus);
                        linesMoneyPlus[11] = setPlayerMoneyPlus.ToString();
                        File.WriteAllLines(filePathMoneyPlus, linesMoneyPlus);

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                    }
                }

            }
            else
            {
                Console.WriteLine("Не достаточно бронзовых монет!");
            }
        }

        //-------------------------------------------------------------Серебро в бронзу-------------------------------------------------------
        public void SilverToBronze()
        {
            LoadSavePlayer loadSavePlayer = new LoadSavePlayer();

            if (loadSavePlayer.GetPlayerSilver() >= 1)
            {
                //уменьшение денег
                string directoryPathMoneyMinus = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                string filePathMoneyMinus = Path.Combine(directoryPathMoneyMinus, "gameplayerdata.txt");
                int setPlayerMoneyMinus = loadSavePlayer.GetPlayerSilver() - 1;
                {
                    try
                    {
                        string[] linesMoneyMinus = File.ReadAllLines(filePathMoneyMinus);
                        linesMoneyMinus[11] = setPlayerMoneyMinus.ToString();
                        File.WriteAllLines(filePathMoneyMinus, linesMoneyMinus);

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                    }

                }

                //увеличение денег
                string directoryPathMoneyPlus = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                string filePathMoneyPlus = Path.Combine(directoryPathMoneyPlus, "gameplayerdata.txt");
                int setPlayerMoneyPlus = loadSavePlayer.GetPlayerBronze() + 100;
                {
                    try
                    {
                        string[] linesMoneyPlus = File.ReadAllLines(filePathMoneyPlus);
                        linesMoneyPlus[10] = setPlayerMoneyPlus.ToString();
                        File.WriteAllLines(filePathMoneyPlus, linesMoneyPlus);

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                    }
                }

            }
            else
            {
                Console.WriteLine("Не достаточно серебрянных монет!");
            }
        }

        //-------------------------------------------------------------Серебро в золото-------------------------------------------------------
        public void SilverToGold()
        {
            LoadSavePlayer loadSavePlayer = new LoadSavePlayer();

            if (loadSavePlayer.GetPlayerSilver() >= 100)
            {
                //уменьшение денег
                string directoryPathMoneyMinus = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                string filePathMoneyMinus = Path.Combine(directoryPathMoneyMinus, "gameplayerdata.txt");
                int setPlayerMoneyMinus = loadSavePlayer.GetPlayerSilver() - 100;
                {
                    try
                    {
                        string[] linesMoneyMinus = File.ReadAllLines(filePathMoneyMinus);
                        linesMoneyMinus[11] = setPlayerMoneyMinus.ToString();
                        File.WriteAllLines(filePathMoneyMinus, linesMoneyMinus);

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                    }

                }

                //увеличение денег
                string directoryPathMoneyPlus = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                string filePathMoneyPlus = Path.Combine(directoryPathMoneyPlus, "gameitgameplayerdataemdata.txt");
                int setPlayerMoneyPlus = loadSavePlayer.GetPlayerGold() + 1;
                {
                    try
                    {
                        string[] linesMoneyPlus = File.ReadAllLines(filePathMoneyPlus);
                        linesMoneyPlus[12] = setPlayerMoneyPlus.ToString();
                        File.WriteAllLines(filePathMoneyPlus, linesMoneyPlus);

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                    }
                }

            }
            else
            {
                Console.WriteLine("Не достаточно серебрянных монет!");
            }
        }

        //-------------------------------------------------------------Золото в серебро-------------------------------------------------------
        public void GoldToSilver()
        {
            LoadSavePlayer loadSavePlayer = new LoadSavePlayer();

            if (loadSavePlayer.GetPlayerGold() >= 1)
            {
                //уменьшение денег
                string directoryPathMoneyMinus = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                string filePathMoneyMinus = Path.Combine(directoryPathMoneyMinus, "gameplayerdata.txt");
                int setPlayerMoneyMinus = loadSavePlayer.GetPlayerGold() - 1;
                {
                    try
                    {
                        string[] linesMoneyMinus = File.ReadAllLines(filePathMoneyMinus);
                        linesMoneyMinus[12] = setPlayerMoneyMinus.ToString();
                        File.WriteAllLines(filePathMoneyMinus, linesMoneyMinus);

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                    }

                }

                //увеличение денег
                string directoryPathMoneyPlus = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                string filePathMoneyPlus = Path.Combine(directoryPathMoneyPlus, "gameplayerdata.txt");
                int setPlayerMoneyPlus = loadSavePlayer.GetPlayerSilver() + 100;
                {
                    try
                    {
                        string[] linesMoneyPlus = File.ReadAllLines(filePathMoneyPlus);
                        linesMoneyPlus[11] = setPlayerMoneyPlus.ToString();
                        File.WriteAllLines(filePathMoneyPlus, linesMoneyPlus);

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                    }
                }

            }
            else
            {
                Console.WriteLine("Не достаточно Золотых монет!");
            }
        }
    }
}
