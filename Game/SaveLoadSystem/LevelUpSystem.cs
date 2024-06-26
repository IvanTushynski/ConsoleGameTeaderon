﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.SaveLoadSystem
{
    internal class LevelUpSystem
    {
        LoadSavePlayer loadSavePlayer = new LoadSavePlayer();

        //-------------------------------------------ЗАПИСЬ---ExpAmount--ИГРОКА------ТЕСТОВАЯ!!!!-----Можно будет удалить--------------------
        public void RecordPlayerExpAmount()
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");
            int setPlayerAmount = loadSavePlayer.GetPlayerExpAmount() + 1000;
            {
                try
                {
                    string[] lines = File.ReadAllLines(filePath);
                    lines[16] = setPlayerAmount.ToString();
                    File.WriteAllLines(filePath, lines);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                }
            }
        }
        //-------------------------------------------Сброс---ExpAmount--ИГРОКА------!!!!-------------------------
        public void ResetPlayerExpAmount()
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");
            int setPlayerAmount = 0;
            {
                try
                {
                    string[] lines = File.ReadAllLines(filePath);
                    lines[16] = setPlayerAmount.ToString();
                    File.WriteAllLines(filePath, lines);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                }
            }
        }
        //-------------------------------------------Сброс---ExpAmount--ИГРОКА--Farm----!!!!-------------------------
        public void ResetPlayerExpAmountFarm()
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");
            int setPlayerAmountFarm = 0;
            {
                try
                {
                    string[] lines = File.ReadAllLines(filePath);
                    lines[20] = setPlayerAmountFarm.ToString();
                    File.WriteAllLines(filePath, lines);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                }
            }
        }
        //-------------------------------------------ЗАПИСЬ---LEVELUP--ИГРОКА-------------------------------
        public void RecordPlayerLevelUp()
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");
            loadSavePlayer.RecordPlayerExpForNextLvl();
            loadSavePlayer.RecordPlayerAttack();
            loadSavePlayer.RecordPlayerDefense();
            //loadSavePlayer.RecordPlayerHp();
            loadSavePlayer.RecordPlayerMaxHp();
            //loadSavePlayer.RecordPlayerMp();
            loadSavePlayer.RecordPlayerMaxMp();
            {
                try
                {
                    if (loadSavePlayer.GetPlayerLevel() < 70) 
                    {
                        if (loadSavePlayer.GetPlayerExpAmount() >= loadSavePlayer.GetPlayerExpForNextLvl())
                        {
                            int setPlayerLevel = loadSavePlayer.GetPlayerLevel() + 1;
                            string[] lines = File.ReadAllLines(filePath);
                            lines[1] = setPlayerLevel.ToString();
                            File.WriteAllLines(filePath, lines);
                            ResetPlayerExpAmount();
                        }
                        else
                        {
                            Console.WriteLine(loadSavePlayer.GetPlayerExpAmount() + "/" + loadSavePlayer.GetPlayerExpForNextLvl() + ": Опыт");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Максимальный Уровень Персонажа!!!");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                }
            }
        }
        //-------------------------------------------ЗАПИСЬ---LEVELUP--ИГРОКА--Farm-----------------------------
        public void RecordPlayerLevelUpFarm()
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");
            loadSavePlayer.RecordPlayerExpForNextLvlFarm();
            {
                try
                {
                    if (loadSavePlayer.GetPlayerLevelFarm() < 70)
                    {
                        if (loadSavePlayer.GetPlayerExpAmountFarm() >= loadSavePlayer.GetPlayerExpForNextLvlFarm())
                        {
                            int setPlayerLevelFarm = loadSavePlayer.GetPlayerLevelFarm() + 1;
                            string[] lines = File.ReadAllLines(filePath);
                            lines[22] = setPlayerLevelFarm.ToString();
                            File.WriteAllLines(filePath, lines);
                            ResetPlayerExpAmountFarm();
                        }
                        else
                        {
                            Console.WriteLine(loadSavePlayer.GetPlayerExpAmountFarm() + "/" + loadSavePlayer.GetPlayerExpForNextLvlFarm() + ": Опыт");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Максимальный Уровень Профессий!!!");
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
