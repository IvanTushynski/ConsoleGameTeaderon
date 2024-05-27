using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.SaveLoadSystem
{
    internal class Bottles
    {
        //###########################################################################################################################################
        //###########################################################################################################################################
        //##############################################################Small###########HP##################################################################
        //-------------------------------------------Покупка---Small--HP--Pitions----------------------------
        public void BuySmallHpPotionPlus()
        {
            LoadSavePlayer loadSavePlayer = new LoadSavePlayer();
            LoadSaveItems loadSaveItems = new LoadSaveItems();
            
            //проверка на наличие монет
            if (loadSavePlayer.GetPlayerBronze() >= 1) 
            {
                //Увеличение банок
                string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                string filePath = Path.Combine(directoryPath, "gameitemdata.txt");
                int setBootsPlayer = loadSaveItems.GetItemHpSmallPotion() + 1;
                {
                    try
                    {
                        string[] lines = File.ReadAllLines(filePath);
                        lines[5] = setBootsPlayer.ToString();
                        File.WriteAllLines(filePath, lines);

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                    }
                }

                //уменьшение денег
                string directoryPathMoney = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                string filePathMoney = Path.Combine(directoryPathMoney, "gameitemdata.txt");
                int setBootsPlayerMoney = loadSavePlayer.GetPlayerBronze() - 1;
                {
                    try
                    {
                        string[] lines = File.ReadAllLines(filePathMoney);
                        lines[10] = setBootsPlayerMoney.ToString();
                        File.WriteAllLines(filePathMoney, lines);

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                    }
                }
            }
            else
            {
                Console.WriteLine("Не достаточно монет!");
            }
        }
        //-------------------------------------------Уменьшение-количества--Small--HP--Pitions----------------------------
        public void RecordSmallHpPotionMinus()
        {
            LoadSaveItems loadSaveItems = new LoadSaveItems();
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameitemdata.txt");
            int setBootsPlayer = loadSaveItems.GetItemHpSmallPotion() - 1;
            {
                try
                {
                    string[] lines = File.ReadAllLines(filePath);
                    lines[5] = setBootsPlayer.ToString();
                    File.WriteAllLines(filePath, lines);

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                }
            }
        }

        //-----------------------Использование--SmallHpPotion----ИСПОЛЬЗОВАТЬ--ДАННЫЙ--МЕТОД---ПРЕДЫДУЩИЙ--ЗАПИСЫВАЕТ-------------------
        public void UseSmallHpPotion()
        {
            LoadSavePlayer loadSavePlayer = new LoadSavePlayer();
            LoadSaveItems loadSaveItems = new LoadSaveItems();
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");
            {
                try
                {
                    if (loadSavePlayer.GetPlayerHp() < loadSavePlayer.GetPlayerMaxHp())
                    {
                        int setHpPlayer = loadSavePlayer.GetPlayerHp() + 20;
                        if (setHpPlayer >= loadSavePlayer.GetPlayerMaxHp() && loadSaveItems.GetItemHpSmallPotion() >= 1) 
                        {
                           int setHpPlayerFinal = loadSavePlayer.GetPlayerMaxHp();
                           string[] lines = File.ReadAllLines(filePath);
                           lines[6] = setHpPlayerFinal.ToString();
                           File.WriteAllLines(filePath, lines);
                            Console.WriteLine("Максимальный Уровень Жизней");
                            RecordSmallHpPotionMinus();
                        }
                        else if(setHpPlayer < loadSavePlayer.GetPlayerMaxHp() && loadSaveItems.GetItemHpSmallPotion() >= 1)
                        {
                            int setHpPlayerFinal = setHpPlayer;
                            string[] lines = File.ReadAllLines(filePath);
                            lines[6] = setHpPlayerFinal.ToString();
                            File.WriteAllLines(filePath, lines);
                            Console.WriteLine("Вы восстановили 20 HP");
                            RecordSmallHpPotionMinus();
                        } else if (loadSaveItems.GetItemHpSmallPotion() == 0)
                        {
                            Console.WriteLine("Банки закончились");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Достигнут максимальный уровень Жизней!");
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                }
            }
        }
        //###################################################################Normal###########HP###############################################
        //-------------------------------------------Покупка---Normal--HP--Pitions----------------------------
        public void BuyNormalHpPotionPlus()
        {
            LoadSavePlayer loadSavePlayer = new LoadSavePlayer();
            LoadSaveItems loadSaveItems = new LoadSaveItems();

            //проверка на наличие монет
            if (loadSavePlayer.GetPlayerBronze() >= 20)
            {
                //Увеличение банок
                string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                string filePath = Path.Combine(directoryPath, "gameitemdata.txt");
                int setBootsPlayer = loadSaveItems.GetItemHpNormalPotion() + 1;
                {
                    try
                    {
                        string[] lines = File.ReadAllLines(filePath);
                        lines[6] = setBootsPlayer.ToString();
                        File.WriteAllLines(filePath, lines);

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                    }
                }

                //уменьшение денег
                string directoryPathMoney = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                string filePathMoney = Path.Combine(directoryPathMoney, "gameitemdata.txt");
                int setBootsPlayerMoney = loadSavePlayer.GetPlayerBronze() - 20;
                {
                    try
                    {
                        string[] lines = File.ReadAllLines(filePathMoney);
                        lines[10] = setBootsPlayerMoney.ToString();
                        File.WriteAllLines(filePathMoney, lines);

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                    }
                }
            }
            else
            {
                Console.WriteLine("Не достаточно монет!");
            }
        }
        //-------------------------------------------Уменьшение-количества--Normal--HP--Pitions----------------------------
        public void RecordNormalHpPotionMinus()
        {
            LoadSaveItems loadSaveItems = new LoadSaveItems();
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameitemdata.txt");
            int setPlayer = loadSaveItems.GetItemHpNormalPotion() - 1;
            {
                try
                {
                    string[] lines = File.ReadAllLines(filePath);
                    lines[6] = setPlayer.ToString();
                    File.WriteAllLines(filePath, lines);

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                }
            }
        }

        //-----------------------Использование--NormalHpPotion----ИСПОЛЬЗОВАТЬ--ДАННЫЙ--МЕТОД---ПРЕДИДУЩИЙ--ЗАПИСЫВАЕТ-------------------
        public void UseNormalHpPotion()
        {
            LoadSavePlayer loadSavePlayer = new LoadSavePlayer();
            LoadSaveItems loadSaveItems = new LoadSaveItems();
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");
            {
                try
                {
                    if (loadSavePlayer.GetPlayerHp() < loadSavePlayer.GetPlayerMaxHp())
                    {
                        int setHpPlayer = loadSavePlayer.GetPlayerHp() + 120;
                        if (setHpPlayer >= loadSavePlayer.GetPlayerMaxHp() && loadSaveItems.GetItemHpNormalPotion() >= 1)
                        {
                            int setHpPlayerFinal = loadSavePlayer.GetPlayerMaxHp();
                            string[] lines = File.ReadAllLines(filePath);
                            lines[6] = setHpPlayerFinal.ToString();
                            File.WriteAllLines(filePath, lines);
                            Console.WriteLine("Максимальный Уровень Жизней");
                            RecordNormalHpPotionMinus();
                        }
                        else if (setHpPlayer < loadSavePlayer.GetPlayerMaxHp() && loadSaveItems.GetItemHpNormalPotion() >= 1)
                        {
                            int setHpPlayerFinal = setHpPlayer;
                            string[] lines = File.ReadAllLines(filePath);
                            lines[6] = setHpPlayerFinal.ToString();
                            File.WriteAllLines(filePath, lines);
                            Console.WriteLine("Вы восстановили 120 HP");
                            RecordNormalHpPotionMinus();
                        }
                        else if (loadSaveItems.GetItemHpNormalPotion() == 0)
                        {
                            Console.WriteLine("Банки закончились");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Достигнут максимальный уровень Жизней!");
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                }
            }
        }
        //#############################################################LargeHP
        //-------------------------------------------Покупка---Large--HP--Potions----------------------------
        public void BuyLargeHpPotionPlus()
        {
            LoadSavePlayer loadSavePlayer = new LoadSavePlayer();
            LoadSaveItems loadSaveItems = new LoadSaveItems();

            //проверка на наличие монет
            if (loadSavePlayer.GetPlayerSilver() >= 1)
            {
                //Увеличение банок
                string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                string filePath = Path.Combine(directoryPath, "gameitemdata.txt");
                int setBootsPlayer = loadSaveItems.GetItemHpLargePotion() + 1;
                {
                    try
                    {
                        string[] lines = File.ReadAllLines(filePath);
                        lines[7] = setBootsPlayer.ToString();
                        File.WriteAllLines(filePath, lines);

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                    }
                }

                //уменьшение денег
                string directoryPathMoney = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                string filePathMoney = Path.Combine(directoryPathMoney, "gameitemdata.txt");
                int setBootsPlayerMoney = loadSavePlayer.GetPlayerSilver() - 1;
                {
                    try
                    {
                        string[] lines = File.ReadAllLines(filePathMoney);
                        lines[10] = setBootsPlayerMoney.ToString();
                        File.WriteAllLines(filePathMoney, lines);

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                    }
                }
            }
            else
            {
                Console.WriteLine("Не достаточно монет!");
            }
        }
        //-------------------------------------------Уменьшение-количества--Large--HP--Pitions----------------------------
        public void RecordLargeHpPotionMinus()
        {
            LoadSaveItems loadSaveItems = new LoadSaveItems();
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameitemdata.txt");
            int setPlayer = loadSaveItems.GetItemHpLargePotion() - 1;
            {
                try
                {
                    string[] lines = File.ReadAllLines(filePath);
                    lines[7] = setPlayer.ToString();
                    File.WriteAllLines(filePath, lines);

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                }
            }
        }

        //-----------------------Использование--LargeHpPotion----ИСПОЛЬЗОВАТЬ--ДАННЫЙ--МЕТОД---ПРЕДИДУЩИЙ--ЗАПИСЫВАЕТ-------------------
        public void UseLargeHpPotion()
        {
            LoadSavePlayer loadSavePlayer = new LoadSavePlayer();
            LoadSaveItems loadSaveItems = new LoadSaveItems();
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");
            {
                try
                {
                    if (loadSavePlayer.GetPlayerHp() < loadSavePlayer.GetPlayerMaxHp())
                    {
                        int setHpPlayer = loadSavePlayer.GetPlayerHp() + 480;
                        if (setHpPlayer >= loadSavePlayer.GetPlayerMaxHp() && loadSaveItems.GetItemHpLargePotion() >= 1)
                        {
                            int setHpPlayerFinal = loadSavePlayer.GetPlayerMaxHp();
                            string[] lines = File.ReadAllLines(filePath);
                            lines[6] = setHpPlayerFinal.ToString();
                            File.WriteAllLines(filePath, lines);
                            Console.WriteLine("Максимальный Уровень Жизней");
                            RecordLargeHpPotionMinus();
                        }
                        else if (setHpPlayer < loadSavePlayer.GetPlayerMaxHp() && loadSaveItems.GetItemHpLargePotion() >= 1)
                        {
                            int setHpPlayerFinal = setHpPlayer;
                            string[] lines = File.ReadAllLines(filePath);
                            lines[6] = setHpPlayerFinal.ToString();
                            File.WriteAllLines(filePath, lines);
                            Console.WriteLine("Вы восстановили 480 HP");
                            RecordLargeHpPotionMinus();
                        }
                        else if (loadSaveItems.GetItemHpLargePotion() == 0)
                        {
                            Console.WriteLine("Банки закончились");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Достигнут максимальный уровень Жизней!");
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                }
            }
        }
        //###############################################################Small######Mp######################################################################
        //-------------------------------------------Покупка---Small--Mp--Pitions----------------------------
        public void RecordSmallMpPotionPlus()
        {
            LoadSavePlayer loadSavePlayer = new LoadSavePlayer();
            LoadSaveItems loadSaveItems = new LoadSaveItems();

            //проверка на наличие монет
            if (loadSavePlayer.GetPlayerBronze() >= 1)
            {
                //Увеличение банок
                string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                string filePath = Path.Combine(directoryPath, "gameitemdata.txt");
                int setBootsPlayer = loadSaveItems.GetItemMpSmallPotion() + 1;
                {
                    try
                    {
                        string[] lines = File.ReadAllLines(filePath);
                        lines[5] = setBootsPlayer.ToString();
                        File.WriteAllLines(filePath, lines);

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                    }
                }

                //уменьшение денег
                string directoryPathMoney = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                string filePathMoney = Path.Combine(directoryPathMoney, "gameitemdata.txt");
                int setBootsPlayerMoney = loadSavePlayer.GetPlayerBronze() - 1;
                {
                    try
                    {
                        string[] lines = File.ReadAllLines(filePathMoney);
                        lines[10] = setBootsPlayerMoney.ToString();
                        File.WriteAllLines(filePathMoney, lines);

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                    }
                }
            }
            else
            {
                Console.WriteLine("Не достаточно монет!");
            }
        }
        //-------------------------------------------Уменьшение-количества--Small--Mp--Pitions----------------------------
        public void RecordSmallMpPotionMinus()
        {
            LoadSaveItems loadSaveItems = new LoadSaveItems();
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameitemdata.txt");
            int setBootsPlayer = loadSaveItems.GetItemMpSmallPotion() - 1;
            {
                try
                {
                    string[] lines = File.ReadAllLines(filePath);
                    lines[8] = setBootsPlayer.ToString();
                    File.WriteAllLines(filePath, lines);

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                }
            }
        }

        //-----------------------Использование--SmallMpPotion----ИСПОЛЬЗОВАТЬ--ДАННЫЙ--МЕТОД---ПРЕДЫДУЩИЙ--ЗАПИСЫВАЕТ-------------------
        public void UseSmallMpPotion()
        {
            LoadSavePlayer loadSavePlayer = new LoadSavePlayer();
            LoadSaveItems loadSaveItems = new LoadSaveItems();
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");
            {
                try
                {
                    if (loadSavePlayer.GetPlayerMp() < loadSavePlayer.GetPlayerMaxMp())
                    {
                        int setMpPlayer = loadSavePlayer.GetPlayerMp() + 10;
                        if (setMpPlayer >= loadSavePlayer.GetPlayerMaxMp() && loadSaveItems.GetItemMpSmallPotion() >= 1)
                        {
                            int setMpPlayerFinal = loadSavePlayer.GetPlayerMaxMp();
                            string[] lines = File.ReadAllLines(filePath);
                            lines[8] = setMpPlayerFinal.ToString();
                            File.WriteAllLines(filePath, lines);
                            Console.WriteLine("Максимальный Уровень Маны");
                            RecordSmallMpPotionMinus();
                        }
                        else if (setMpPlayer < loadSavePlayer.GetPlayerMaxMp() && loadSaveItems.GetItemMpSmallPotion() >= 1)
                        {
                            int setMpPlayerFinal = setMpPlayer;
                            string[] lines = File.ReadAllLines(filePath);
                            lines[8] = setMpPlayerFinal.ToString();
                            File.WriteAllLines(filePath, lines);
                            Console.WriteLine("Вы восстановили 10 MP");
                            RecordSmallMpPotionMinus();
                        }
                        else if (loadSaveItems.GetItemMpSmallPotion() == 0)
                        {
                            Console.WriteLine("Банки закончились");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Достигнут максимальный уровень Маны!");
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                }
            }
        }
        //##############################################################Normal#####Mp##########################################################
        //-------------------------------------------Покупка---Normal--Mp--Pitions----------------------------
        public void RecordNormalMpPotionPlus()
        {
            LoadSavePlayer loadSavePlayer = new LoadSavePlayer();
            LoadSaveItems loadSaveItems = new LoadSaveItems();

            //проверка на наличие монет
            if (loadSavePlayer.GetPlayerBronze() >= 20)
            {
                //Увеличение банок
                string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                string filePath = Path.Combine(directoryPath, "gameitemdata.txt");
                int setBootsPlayer = loadSaveItems.GetItemMpNormalPotion() + 1;
                {
                    try
                    {
                        string[] lines = File.ReadAllLines(filePath);
                        lines[9] = setBootsPlayer.ToString();
                        File.WriteAllLines(filePath, lines);

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                    }
                }

                //уменьшение денег
                string directoryPathMoney = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                string filePathMoney = Path.Combine(directoryPathMoney, "gameitemdata.txt");
                int setBootsPlayerMoney = loadSavePlayer.GetPlayerBronze() - 20;
                {
                    try
                    {
                        string[] lines = File.ReadAllLines(filePathMoney);
                        lines[10] = setBootsPlayerMoney.ToString();
                        File.WriteAllLines(filePathMoney, lines);

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                    }
                }
            }
            else
            {
                Console.WriteLine("Не достаточно монет!");
            }
        }
        //-------------------------------------------Уменьшение-количества--Normal--Mp--Pitions----------------------------
        public void RecordNormalMpPotionMinus()
        {
            LoadSaveItems loadSaveItems = new LoadSaveItems();
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameitemdata.txt");
            int setPlayer = loadSaveItems.GetItemMpNormalPotion() - 1;
            {
                try
                {
                    string[] lines = File.ReadAllLines(filePath);
                    lines[9] = setPlayer.ToString();
                    File.WriteAllLines(filePath, lines);

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                }
            }
        }

        //-----------------------Использование--NormalMpPotion----ИСПОЛЬЗОВАТЬ--ДАННЫЙ--МЕТОД---ПРЕДИДУЩИЙ--ЗАПИСЫВАЕТ-------------------
        public void UseNormalMpPotion()
        {
            LoadSavePlayer loadSavePlayer = new LoadSavePlayer();
            LoadSaveItems loadSaveItems = new LoadSaveItems();
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");
            {
                try
                {
                    if (loadSavePlayer.GetPlayerMp() < loadSavePlayer.GetPlayerMaxMp())
                    {
                        int setMpPlayer = loadSavePlayer.GetPlayerMp() + 20;
                        if (setMpPlayer >= loadSavePlayer.GetPlayerMaxMp() && loadSaveItems.GetItemMpNormalPotion() >= 1)
                        {
                            int setMpPlayerFinal = loadSavePlayer.GetPlayerMaxMp();
                            string[] lines = File.ReadAllLines(filePath);
                            lines[8] = setMpPlayerFinal.ToString();
                            File.WriteAllLines(filePath, lines);
                            Console.WriteLine("Максимальный Уровень Маны");
                            RecordNormalMpPotionMinus();
                        }
                        else if (setMpPlayer < loadSavePlayer.GetPlayerMaxMp() && loadSaveItems.GetItemMpNormalPotion() >= 1)
                        {
                            int setMpPlayerFinal = setMpPlayer;
                            string[] lines = File.ReadAllLines(filePath);
                            lines[8] = setMpPlayerFinal.ToString();
                            File.WriteAllLines(filePath, lines);
                            Console.WriteLine("Вы восстановили 20 MP");
                            RecordNormalMpPotionMinus();
                        }
                        else if (loadSaveItems.GetItemMpNormalPotion() == 0)
                        {
                            Console.WriteLine("Банки закончились");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Достигнут максимальный уровень Маны!");
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                }
            }
        }
        //############################################################Large######Mp###########################################################
        //-------------------------------------------Покупка---Large--Mp--Potions----------------------------
        public void RecordLargeMpPotionPlus()
        {
            LoadSavePlayer loadSavePlayer = new LoadSavePlayer();
            LoadSaveItems loadSaveItems = new LoadSaveItems();

            //проверка на наличие монет
            if (loadSavePlayer.GetPlayerSilver() >= 1)
            {
                //Увеличение банок
                string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                string filePath = Path.Combine(directoryPath, "gameitemdata.txt");
                int setBootsPlayer = loadSaveItems.GetItemMpLargePotion() + 1;
                {
                    try
                    {
                        string[] lines = File.ReadAllLines(filePath);
                        lines[10] = setBootsPlayer.ToString();
                        File.WriteAllLines(filePath, lines);

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                    }
                }

                //уменьшение денег
                string directoryPathMoney = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                string filePathMoney = Path.Combine(directoryPathMoney, "gameitemdata.txt");
                int setBootsPlayerMoney = loadSavePlayer.GetPlayerSilver() - 1;
                {
                    try
                    {
                        string[] lines = File.ReadAllLines(filePathMoney);
                        lines[10] = setBootsPlayerMoney.ToString();
                        File.WriteAllLines(filePathMoney, lines);

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                    }
                }
            }
            else
            {
                Console.WriteLine("Не достаточно монет!");
            }
        }
        //-------------------------------------------Уменьшение-количества--Large--Mp--Pitions----------------------------
        public void RecordLargeMpPotionMinus()
        {
            LoadSaveItems loadSaveItems = new LoadSaveItems();
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameitemdata.txt");
            int setPlayer = loadSaveItems.GetItemMpLargePotion() - 1;
            {
                try
                {
                    string[] lines = File.ReadAllLines(filePath);
                    lines[10] = setPlayer.ToString();
                    File.WriteAllLines(filePath, lines);

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                }
            }
        }

        //-----------------------Использование--LargeMpPotion----ИСПОЛЬЗОВАТЬ--ДАННЫЙ--МЕТОД---ПРЕДИДУЩИЙ--ЗАПИСЫВАЕТ-------------------
        public void UseLargeMpPotion()
        {
            LoadSavePlayer loadSavePlayer = new LoadSavePlayer();
            LoadSaveItems loadSaveItems = new LoadSaveItems();
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");
            {
                try
                {
                    if (loadSavePlayer.GetPlayerMp() < loadSavePlayer.GetPlayerMaxMp())
                    {
                        int setMpPlayer = loadSavePlayer.GetPlayerMp() + 60;
                        if (setMpPlayer >= loadSavePlayer.GetPlayerMaxMp() && loadSaveItems.GetItemMpLargePotion() >= 1)
                        {
                            int setMpPlayerFinal = loadSavePlayer.GetPlayerMaxMp();
                            string[] lines = File.ReadAllLines(filePath);
                            lines[8] = setMpPlayerFinal.ToString();
                            File.WriteAllLines(filePath, lines);
                            Console.WriteLine("Максимальный Уровень Маны");
                            RecordLargeMpPotionMinus();
                        }
                        else if (setMpPlayer < loadSavePlayer.GetPlayerMaxMp() && loadSaveItems.GetItemMpLargePotion() >= 1)
                        {
                            int setMpPlayerFinal = setMpPlayer;
                            string[] lines = File.ReadAllLines(filePath);
                            lines[8] = setMpPlayerFinal.ToString();
                            File.WriteAllLines(filePath, lines);
                            Console.WriteLine("Вы восстановили 60 Mp");
                            RecordLargeMpPotionMinus();
                        }
                        else if (loadSaveItems.GetItemMpLargePotion() == 0)
                        {
                            Console.WriteLine("Банки закончились");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Достигнут максимальный уровень Маны!");
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                }
            }
        }
    }
}
