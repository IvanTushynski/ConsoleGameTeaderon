using Game.Enemies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.BattleSystem
{
    internal class BattleMonsterFreavell
    {
        EnemyFreavell enemyFreavell = new EnemyFreavell();
        LoadSavePlayer loadSavePlayer = new LoadSavePlayer();
        Random rand = new Random();
        //-------------------------------------------ЗАПИСЬ---HP--ПРОТИВНИКА---FREAVELL--ONE--------------------------------
        public void RecordEnemyHpFreavellOne()
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gamehpenemy.txt");
            int setEnemyHp = enemyFreavell.hpEnemyFreavellOne;
            {
                try
                {
                    string[] lines = File.ReadAllLines(filePath);
                    lines[0] = setEnemyHp.ToString();
                    File.WriteAllLines(filePath, lines);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                }
            }
        }
        //-------------------------------------------ЗАПИСЬ---HP--ПРОТИВНИКА---FREAVELL--TWO--------------------------------
        public void RecordEnemyHpFreavellTwo()
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gamehpenemy.txt");
            int setEnemyHp = enemyFreavell.hpEnemyFreavellTwo;
            {
                try
                {
                    string[] lines = File.ReadAllLines(filePath);
                    lines[0] = setEnemyHp.ToString();
                    File.WriteAllLines(filePath, lines);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                }
            }
        }
        //-------------------------------------------ЗАПИСЬ---HP--ПРОТИВНИКА---FREAVELL--THREE--------------------------------
        public void RecordEnemyHpFreavellThree()
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gamehpenemy.txt");
            int setEnemyHp = enemyFreavell.hpEnemyFreavellThree;
            {
                try
                {
                    string[] lines = File.ReadAllLines(filePath);
                    lines[0] = setEnemyHp.ToString();
                    File.WriteAllLines(filePath, lines);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                }
            }
        }
        //-------------------------------------------ЗАПИСЬ---HP--ПРОТИВНИКА---FREAVELL--FOUR--------------------------------
        public void RecordEnemyHpFreavellFour()
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gamehpenemy.txt");
            int setEnemyHp = enemyFreavell.hpEnemyFreavellFour;
            {
                try
                {
                    string[] lines = File.ReadAllLines(filePath);
                    lines[0] = setEnemyHp.ToString();
                    File.WriteAllLines(filePath, lines);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                }
            }
        }
        //-------------------------------------------ЗАПИСЬ---HP--ПРОТИВНИКА---FREAVELL--FIVE--------------------------------
        public void RecordEnemyHpFreavellFive()
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gamehpenemy.txt");
            int setEnemyHp = enemyFreavell.hpEnemyFreavellFive;
            {
                try
                {
                    string[] lines = File.ReadAllLines(filePath);
                    lines[0] = setEnemyHp.ToString();
                    File.WriteAllLines(filePath, lines);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                }
            }
        }
        //-------------------------------------------ЗАПИСЬ---HP--ПРОТИВНИКА---FREAVELL--BOSS--ONE------------------------------
        public void RecordEnemyHpFreavellBossOne()
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gamehpenemy.txt");
            int setEnemyHp = enemyFreavell.hpEnemyFreavellBossOne;
            {
                try
                {
                    string[] lines = File.ReadAllLines(filePath);
                    lines[0] = setEnemyHp.ToString();
                    File.WriteAllLines(filePath, lines);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                }
            }
        }
        //-------------------------------------------ЗАПИСЬ---HP--ПРОТИВНИКА---FREAVELL--BOSS--TWO------------------------------
        public void RecordEnemyHpFreavellBossTwo()
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gamehpenemy.txt");
            int setEnemyHp = enemyFreavell.hpEnemyFreavellBossTwo;
            {
                try
                {
                    string[] lines = File.ReadAllLines(filePath);
                    lines[0] = setEnemyHp.ToString();
                    File.WriteAllLines(filePath, lines);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                }
            }
        }
        //-------------------------------------------ЗАПИСЬ---HP--ПРОТИВНИКА---FREAVELL--BOSS--THREE------------------------------
        public void RecordEnemyHpFreavellBossThree()
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gamehpenemy.txt");
            int setEnemyHp = enemyFreavell.hpEnemyFreavellBossThree;
            {
                try
                {
                    string[] lines = File.ReadAllLines(filePath);
                    lines[0] = setEnemyHp.ToString();
                    File.WriteAllLines(filePath, lines);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                }
            }
        }
        //-------------------------------------------Чтение---HP--ПРОТИВНИКА-------------------------------------
        public int GetEnemyHp()
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gamehpenemy.txt");
            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
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
        //######################################################################################################################################
        //---------------------------------АКАТА------ENEMY-----------ONE----------------------------------------------------------------
        public void AttackEnemyFreavellOne()
        {
            // Заглушка, если у игрока отсутствуют HP!!!!
            if (loadSavePlayer.GetPlayerHp() > 0)
            {
                // Вероятность уворота
                int evasionChance = loadSavePlayer.GetPlayerDodge();
                // Генерация случайного числа от 1 до 100
                int randomNumberDodge = rand.Next(1, 101);
                //Если не сработал крит!!!
                if (randomNumberDodge > evasionChance)
                {
                    // Генерация случайного числа от 1 до 10
                    int randomNumberCrit = rand.Next(1, 11);
                    if (randomNumberCrit <= 8)
                    {
                        // Урон от монстра
                        int enemyDamage = enemyFreavell.attackEnemyFreavellOne - loadSavePlayer.GetPlayerDefense();
                        //Если в итоге защита выше чем сам урон монстра
                        if (enemyDamage > 0)
                        {
                            int enemyDamageDealt = loadSavePlayer.GetPlayerHp() - enemyDamage;
                            //Запись урона в HP игрока
                            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                            string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");
                            {
                                try
                                {
                                    string[] lines = File.ReadAllLines(filePath);
                                    lines[6] = enemyDamageDealt.ToString();
                                    File.WriteAllLines(filePath, lines);
                                    // Если HP игрока больше 0!   
                                    if (loadSavePlayer.GetPlayerHp() > 0)
                                    {
                                        Console.WriteLine("Вам нанесли :" + enemyDamage + " Урона" + " И оставили вам :" + loadSavePlayer.GetPlayerHp() + " HP");
                                    }
                                    // Если HP игрока меньше или равно 0!
                                    else if (loadSavePlayer.GetPlayerHp() <= 0)
                                    {
                                        int enemyDamageDealtNone = 0;
                                        string[] linesNone = File.ReadAllLines(filePath);
                                        lines[6] = enemyDamageDealtNone.ToString();
                                        File.WriteAllLines(filePath, lines);
                                        Console.WriteLine("Вам нанесли :" + enemyDamageDealtNone + " Урона" + " И оставили вам :" + "0" + " HP");
                                        Console.WriteLine("У вас не достаточно HP для продолжения боя!!!");
                                        RecordEnemyHpFreavellOne();
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                                }
                            }
                        }
                        else
                        {
                            int enemyDamageDealt = loadSavePlayer.GetPlayerHp() - 0;
                            //Запись урона в HP игрока
                            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                            string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");
                            {
                                try
                                {
                                    string[] lines = File.ReadAllLines(filePath);
                                    lines[6] = enemyDamageDealt.ToString();
                                    File.WriteAllLines(filePath, lines);
                                    // Если HP игрока больше 0!   
                                    if (loadSavePlayer.GetPlayerHp() > 0)
                                    {
                                        Console.WriteLine("Вам нанесли :" + "0" + " Урона" + " И оставили вам :" + loadSavePlayer.GetPlayerHp() + " HP");
                                    }
                                    // Если HP игрока меньше или равно 0!
                                    else if (loadSavePlayer.GetPlayerHp() <= 0)
                                    {
                                        int enemyDamageDealtNone = 0;
                                        string[] linesNone = File.ReadAllLines(filePath);
                                        lines[6] = enemyDamageDealtNone.ToString();
                                        File.WriteAllLines(filePath, lines);
                                        Console.WriteLine("Вам нанесли :" + enemyDamageDealtNone + " Урона" + " И оставили вам :" + "0" + " HP");
                                        Console.WriteLine("У вас не достаточно HP для продолжения боя!!!");
                                        RecordEnemyHpFreavellOne();
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                                }
                            }
                        }
                    }
                    //Если сработал крит!!!
                    else if (randomNumberCrit > 8)
                    {
                        // Урон от монстра
                        int enemyDamage = (enemyFreavell.attackEnemyFreavellOne + enemyFreavell.critEnemyFreavellOne) - loadSavePlayer.GetPlayerDefense();
                        //Если в итоге защита выше чем сам урон монстра
                        if (enemyDamage > 0)
                        {
                            int enemyDamageDealt = loadSavePlayer.GetPlayerHp() - enemyDamage;
                            //Запись урона в HP игрока
                            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                            string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");
                            {
                                try
                                {
                                    string[] lines = File.ReadAllLines(filePath);
                                    lines[6] = enemyDamageDealt.ToString();
                                    File.WriteAllLines(filePath, lines);
                                    // Если HP игрока больше 0!   
                                    if (loadSavePlayer.GetPlayerHp() > 0)
                                    {
                                        Console.WriteLine("Вам нанесли :" + enemyDamage + " Урона" + " И оставили вам :" + loadSavePlayer.GetPlayerHp() + " HP");
                                    }
                                    // Если HP игрока меньше или равно 0!
                                    else if (loadSavePlayer.GetPlayerHp() <= 0)
                                    {
                                        int enemyDamageDealtNone = 0;
                                        string[] linesNone = File.ReadAllLines(filePath);
                                        lines[6] = enemyDamageDealtNone.ToString();
                                        File.WriteAllLines(filePath, lines);
                                        Console.WriteLine("Вам нанесли :" + enemyDamageDealtNone + " Урона" + " И оставили вам :" + "0" + " HP");
                                        Console.WriteLine("У вас не достаточно HP для продолжения боя!!!");
                                        RecordEnemyHpFreavellOne();
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                                }
                            }
                        }
                        else
                        {
                            int enemyDamageDealt = loadSavePlayer.GetPlayerHp() - 0;
                            //Запись урона в HP игрока
                            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                            string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");
                            {
                                try
                                {
                                    string[] lines = File.ReadAllLines(filePath);
                                    lines[6] = enemyDamageDealt.ToString();
                                    File.WriteAllLines(filePath, lines);
                                    // Если HP игрока больше 0!   
                                    if (loadSavePlayer.GetPlayerHp() > 0)
                                    {
                                        Console.WriteLine("Вам нанесли :" + "0" + " Урона" + " И оставили вам :" + loadSavePlayer.GetPlayerHp() + " HP");
                                    }
                                    // Если HP игрока меньше или равно 0!
                                    else if (loadSavePlayer.GetPlayerHp() <= 0)
                                    {
                                        int enemyDamageDealtNone = 0;
                                        string[] linesNone = File.ReadAllLines(filePath);
                                        lines[6] = enemyDamageDealtNone.ToString();
                                        File.WriteAllLines(filePath, lines);
                                        Console.WriteLine("Вам нанесли :" + enemyDamageDealtNone + " Урона" + " И оставили вам :" + "0" + " HP");
                                        Console.WriteLine("У вас не достаточно HP для продолжения боя!!!");
                                        RecordEnemyHpFreavellOne();
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
                //Сработал Уворот
                else if (randomNumberDodge <= evasionChance)
                {
                    Console.WriteLine("Сработал уворот!");
                }
            }
            else
            {
                Console.WriteLine("Восстановить здоровье можно зельями HP");
            }
        }
        //######################################################################################################################################
        //---------------------------------АКАТА------ENEMY-----------TWO----------------------------------------------------------------
        public void AttackEnemyFreavellTwo()
        {
            // Заглушка, если у игрока отсутствуют HP!!!!
            if (loadSavePlayer.GetPlayerHp() > 0)
            {
                // Вероятность уворота
                int evasionChance = loadSavePlayer.GetPlayerDodge();
                // Генерация случайного числа от 1 до 100
                int randomNumberDodge = rand.Next(1, 101);
                //Если не сработал крит!!!
                if (randomNumberDodge > evasionChance)
                {
                    // Генерация случайного числа от 1 до 10
                    int randomNumberCrit = rand.Next(1, 11);
                    if (randomNumberCrit <= 8)
                    {
                        // Урон от монстра
                        int enemyDamage = enemyFreavell.attackEnemyFreavellTwo - loadSavePlayer.GetPlayerDefense();
                        //Если в итоге защита выше чем сам урон монстра
                        if (enemyDamage > 0)
                        {
                            int enemyDamageDealt = loadSavePlayer.GetPlayerHp() - enemyDamage;
                            //Запись урона в HP игрока
                            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                            string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");
                            {
                                try
                                {
                                    string[] lines = File.ReadAllLines(filePath);
                                    lines[6] = enemyDamageDealt.ToString();
                                    File.WriteAllLines(filePath, lines);
                                    // Если HP игрока больше 0!   
                                    if (loadSavePlayer.GetPlayerHp() > 0)
                                    {
                                        Console.WriteLine("Вам нанесли :" + enemyDamage + " Урона" + " И оставили вам :" + loadSavePlayer.GetPlayerHp() + " HP");
                                    }
                                    // Если HP игрока меньше или равно 0!
                                    else if (loadSavePlayer.GetPlayerHp() <= 0)
                                    {
                                        int enemyDamageDealtNone = 0;
                                        string[] linesNone = File.ReadAllLines(filePath);
                                        lines[6] = enemyDamageDealtNone.ToString();
                                        File.WriteAllLines(filePath, lines);
                                        Console.WriteLine("Вам нанесли :" + enemyDamageDealtNone + " Урона" + " И оставили вам :" + "0" + " HP");
                                        Console.WriteLine("У вас не достаточно HP для продолжения боя!!!");
                                        RecordEnemyHpFreavellTwo();
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                                }
                            }
                        }
                        else
                        {
                            int enemyDamageDealt = loadSavePlayer.GetPlayerHp() - 0;
                            //Запись урона в HP игрока
                            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                            string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");
                            {
                                try
                                {
                                    string[] lines = File.ReadAllLines(filePath);
                                    lines[6] = enemyDamageDealt.ToString();
                                    File.WriteAllLines(filePath, lines);
                                    // Если HP игрока больше 0!   
                                    if (loadSavePlayer.GetPlayerHp() > 0)
                                    {
                                        Console.WriteLine("Вам нанесли :" + "0" + " Урона" + " И оставили вам :" + loadSavePlayer.GetPlayerHp() + " HP");
                                    }
                                    // Если HP игрока меньше или равно 0!
                                    else if (loadSavePlayer.GetPlayerHp() <= 0)
                                    {
                                        int enemyDamageDealtNone = 0;
                                        string[] linesNone = File.ReadAllLines(filePath);
                                        lines[6] = enemyDamageDealtNone.ToString();
                                        File.WriteAllLines(filePath, lines);
                                        Console.WriteLine("Вам нанесли :" + enemyDamageDealtNone + " Урона" + " И оставили вам :" + "0" + " HP");
                                        Console.WriteLine("У вас не достаточно HP для продолжения боя!!!");
                                        RecordEnemyHpFreavellTwo();
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                                }
                            }
                        }
                    }
                    //Если сработал крит!!!
                    else if (randomNumberCrit > 8)
                    {
                        // Урон от монстра
                        int enemyDamage = (enemyFreavell.attackEnemyFreavellTwo + enemyFreavell.critEnemyFreavellTwo) - loadSavePlayer.GetPlayerDefense();
                        //Если в итоге защита выше чем сам урон монстра
                        if (enemyDamage > 0)
                        {
                            int enemyDamageDealt = loadSavePlayer.GetPlayerHp() - enemyDamage;
                            //Запись урона в HP игрока
                            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                            string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");
                            {
                                try
                                {
                                    string[] lines = File.ReadAllLines(filePath);
                                    lines[6] = enemyDamageDealt.ToString();
                                    File.WriteAllLines(filePath, lines);
                                    // Если HP игрока больше 0!   
                                    if (loadSavePlayer.GetPlayerHp() > 0)
                                    {
                                        Console.WriteLine("Вам нанесли :" + enemyDamage + " Урона" + " И оставили вам :" + loadSavePlayer.GetPlayerHp() + " HP");
                                    }
                                    // Если HP игрока меньше или равно 0!
                                    else if (loadSavePlayer.GetPlayerHp() <= 0)
                                    {
                                        int enemyDamageDealtNone = 0;
                                        string[] linesNone = File.ReadAllLines(filePath);
                                        lines[6] = enemyDamageDealtNone.ToString();
                                        File.WriteAllLines(filePath, lines);
                                        Console.WriteLine("Вам нанесли :" + enemyDamageDealtNone + " Урона" + " И оставили вам :" + "0" + " HP");
                                        Console.WriteLine("У вас не достаточно HP для продолжения боя!!!");
                                        RecordEnemyHpFreavellTwo();
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                                }
                            }
                        }
                        else
                        {
                            int enemyDamageDealt = loadSavePlayer.GetPlayerHp() - 0;
                            //Запись урона в HP игрока
                            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                            string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");
                            {
                                try
                                {
                                    string[] lines = File.ReadAllLines(filePath);
                                    lines[6] = enemyDamageDealt.ToString();
                                    File.WriteAllLines(filePath, lines);
                                    // Если HP игрока больше 0!   
                                    if (loadSavePlayer.GetPlayerHp() > 0)
                                    {
                                        Console.WriteLine("Вам нанесли :" + "0" + " Урона" + " И оставили вам :" + loadSavePlayer.GetPlayerHp() + " HP");
                                    }
                                    // Если HP игрока меньше или равно 0!
                                    else if (loadSavePlayer.GetPlayerHp() <= 0)
                                    {
                                        int enemyDamageDealtNone = 0;
                                        string[] linesNone = File.ReadAllLines(filePath);
                                        lines[6] = enemyDamageDealtNone.ToString();
                                        File.WriteAllLines(filePath, lines);
                                        Console.WriteLine("Вам нанесли :" + enemyDamageDealtNone + " Урона" + " И оставили вам :" + "0" + " HP");
                                        Console.WriteLine("У вас не достаточно HP для продолжения боя!!!");
                                        RecordEnemyHpFreavellTwo();
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
                //Сработал Уворот
                else if (randomNumberDodge <= evasionChance)
                {
                    Console.WriteLine("Сработал уворот!");
                }
            }
            else
            {
                Console.WriteLine("Восстановить здоровье можно зельями HP");
            }
        }
        //######################################################################################################################################
        //---------------------------------АКАТА------ENEMY-----------THREE----------------------------------------------------------------
        public void AttackEnemyFreavellThree()
        {
            // Заглушка, если у игрока отсутствуют HP!!!!
            if (loadSavePlayer.GetPlayerHp() > 0)
            {
                // Вероятность уворота
                int evasionChance = loadSavePlayer.GetPlayerDodge();
                // Генерация случайного числа от 1 до 100
                int randomNumberDodge = rand.Next(1, 101);
                //Если не сработал крит!!!
                if (randomNumberDodge > evasionChance)
                {
                    // Генерация случайного числа от 1 до 10
                    int randomNumberCrit = rand.Next(1, 11);
                    if (randomNumberCrit <= 8)
                    {
                        // Урон от монстра
                        int enemyDamage = enemyFreavell.attackEnemyFreavellThree - loadSavePlayer.GetPlayerDefense();
                        //Если в итоге защита выше чем сам урон монстра
                        if (enemyDamage > 0)
                        {
                            int enemyDamageDealt = loadSavePlayer.GetPlayerHp() - enemyDamage;
                            //Запись урона в HP игрока
                            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                            string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");
                            {
                                try
                                {
                                    string[] lines = File.ReadAllLines(filePath);
                                    lines[6] = enemyDamageDealt.ToString();
                                    File.WriteAllLines(filePath, lines);
                                    // Если HP игрока больше 0!   
                                    if (loadSavePlayer.GetPlayerHp() > 0)
                                    {
                                        Console.WriteLine("Вам нанесли :" + enemyDamage + " Урона" + " И оставили вам :" + loadSavePlayer.GetPlayerHp() + " HP");
                                    }
                                    // Если HP игрока меньше или равно 0!
                                    else if (loadSavePlayer.GetPlayerHp() <= 0)
                                    {
                                        int enemyDamageDealtNone = 0;
                                        string[] linesNone = File.ReadAllLines(filePath);
                                        lines[6] = enemyDamageDealtNone.ToString();
                                        File.WriteAllLines(filePath, lines);
                                        Console.WriteLine("Вам нанесли :" + enemyDamageDealtNone + " Урона" + " И оставили вам :" + "0" + " HP");
                                        Console.WriteLine("У вас не достаточно HP для продолжения боя!!!");
                                        RecordEnemyHpFreavellThree();
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                                }
                            }
                        }
                        else
                        {
                            int enemyDamageDealt = loadSavePlayer.GetPlayerHp() - 0;
                            //Запись урона в HP игрока
                            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                            string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");
                            {
                                try
                                {
                                    string[] lines = File.ReadAllLines(filePath);
                                    lines[6] = enemyDamageDealt.ToString();
                                    File.WriteAllLines(filePath, lines);
                                    // Если HP игрока больше 0!   
                                    if (loadSavePlayer.GetPlayerHp() > 0)
                                    {
                                        Console.WriteLine("Вам нанесли :" + "0" + " Урона" + " И оставили вам :" + loadSavePlayer.GetPlayerHp() + " HP");
                                    }
                                    // Если HP игрока меньше или равно 0!
                                    else if (loadSavePlayer.GetPlayerHp() <= 0)
                                    {
                                        int enemyDamageDealtNone = 0;
                                        string[] linesNone = File.ReadAllLines(filePath);
                                        lines[6] = enemyDamageDealtNone.ToString();
                                        File.WriteAllLines(filePath, lines);
                                        Console.WriteLine("Вам нанесли :" + enemyDamageDealtNone + " Урона" + " И оставили вам :" + "0" + " HP");
                                        Console.WriteLine("У вас не достаточно HP для продолжения боя!!!");
                                        RecordEnemyHpFreavellThree();
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                                }
                            }
                        }
                    }
                    //Если сработал крит!!!
                    else if (randomNumberCrit > 8)
                    {
                        // Урон от монстра
                        int enemyDamage = (enemyFreavell.attackEnemyFreavellThree + enemyFreavell.critEnemyFreavellThree) - loadSavePlayer.GetPlayerDefense();
                        //Если в итоге защита выше чем сам урон монстра
                        if (enemyDamage > 0)
                        {
                            int enemyDamageDealt = loadSavePlayer.GetPlayerHp() - enemyDamage;
                            //Запись урона в HP игрока
                            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                            string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");
                            {
                                try
                                {
                                    string[] lines = File.ReadAllLines(filePath);
                                    lines[6] = enemyDamageDealt.ToString();
                                    File.WriteAllLines(filePath, lines);
                                    // Если HP игрока больше 0!   
                                    if (loadSavePlayer.GetPlayerHp() > 0)
                                    {
                                        Console.WriteLine("Вам нанесли :" + enemyDamage + " Урона" + " И оставили вам :" + loadSavePlayer.GetPlayerHp() + " HP");
                                    }
                                    // Если HP игрока меньше или равно 0!
                                    else if (loadSavePlayer.GetPlayerHp() <= 0)
                                    {
                                        int enemyDamageDealtNone = 0;
                                        string[] linesNone = File.ReadAllLines(filePath);
                                        lines[6] = enemyDamageDealtNone.ToString();
                                        File.WriteAllLines(filePath, lines);
                                        Console.WriteLine("Вам нанесли :" + enemyDamageDealtNone + " Урона" + " И оставили вам :" + "0" + " HP");
                                        Console.WriteLine("У вас не достаточно HP для продолжения боя!!!");
                                        RecordEnemyHpFreavellThree();
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                                }
                            }
                        }
                        else
                        {
                            int enemyDamageDealt = loadSavePlayer.GetPlayerHp() - 0;
                            //Запись урона в HP игрока
                            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                            string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");
                            {
                                try
                                {
                                    string[] lines = File.ReadAllLines(filePath);
                                    lines[6] = enemyDamageDealt.ToString();
                                    File.WriteAllLines(filePath, lines);
                                    // Если HP игрока больше 0!   
                                    if (loadSavePlayer.GetPlayerHp() > 0)
                                    {
                                        Console.WriteLine("Вам нанесли :" + "0" + " Урона" + " И оставили вам :" + loadSavePlayer.GetPlayerHp() + " HP");
                                    }
                                    // Если HP игрока меньше или равно 0!
                                    else if (loadSavePlayer.GetPlayerHp() <= 0)
                                    {
                                        int enemyDamageDealtNone = 0;
                                        string[] linesNone = File.ReadAllLines(filePath);
                                        lines[6] = enemyDamageDealtNone.ToString();
                                        File.WriteAllLines(filePath, lines);
                                        Console.WriteLine("Вам нанесли :" + enemyDamageDealtNone + " Урона" + " И оставили вам :" + "0" + " HP");
                                        Console.WriteLine("У вас не достаточно HP для продолжения боя!!!");
                                        RecordEnemyHpFreavellThree();
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
                //Сработал Уворот
                else if (randomNumberDodge <= evasionChance)
                {
                    Console.WriteLine("Сработал уворот!");
                }
            }
            else
            {
                Console.WriteLine("Восстановить здоровье можно зельями HP");
            }
        }
        //######################################################################################################################################
        //---------------------------------АКАТА------ENEMY-----------FOUR----------------------------------------------------------------
        public void AttackEnemyFreavellFour()
        {
            // Заглушка, если у игрока отсутствуют HP!!!!
            if (loadSavePlayer.GetPlayerHp() > 0)
            {
                // Вероятность уворота
                int evasionChance = loadSavePlayer.GetPlayerDodge();
                // Генерация случайного числа от 1 до 100
                int randomNumberDodge = rand.Next(1, 101);
                //Если не сработал крит!!!
                if (randomNumberDodge > evasionChance)
                {
                    // Генерация случайного числа от 1 до 10
                    int randomNumberCrit = rand.Next(1, 11);
                    if (randomNumberCrit <= 8)
                    {
                        // Урон от монстра
                        int enemyDamage = enemyFreavell.attackEnemyFreavellFour - loadSavePlayer.GetPlayerDefense();
                        //Если в итоге защита выше чем сам урон монстра
                        if (enemyDamage > 0)
                        {
                            int enemyDamageDealt = loadSavePlayer.GetPlayerHp() - enemyDamage;
                            //Запись урона в HP игрока
                            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                            string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");
                            {
                                try
                                {
                                    string[] lines = File.ReadAllLines(filePath);
                                    lines[6] = enemyDamageDealt.ToString();
                                    File.WriteAllLines(filePath, lines);
                                    // Если HP игрока больше 0!   
                                    if (loadSavePlayer.GetPlayerHp() > 0)
                                    {
                                        Console.WriteLine("Вам нанесли :" + enemyDamage + " Урона" + " И оставили вам :" + loadSavePlayer.GetPlayerHp() + " HP");
                                    }
                                    // Если HP игрока меньше или равно 0!
                                    else if (loadSavePlayer.GetPlayerHp() <= 0)
                                    {
                                        int enemyDamageDealtNone = 0;
                                        string[] linesNone = File.ReadAllLines(filePath);
                                        lines[6] = enemyDamageDealtNone.ToString();
                                        File.WriteAllLines(filePath, lines);
                                        Console.WriteLine("Вам нанесли :" + enemyDamageDealtNone + " Урона" + " И оставили вам :" + "0" + " HP");
                                        Console.WriteLine("У вас не достаточно HP для продолжения боя!!!");
                                        RecordEnemyHpFreavellFour();
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                                }
                            }
                        }
                        else
                        {
                            int enemyDamageDealt = loadSavePlayer.GetPlayerHp() - 0;
                            //Запись урона в HP игрока
                            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                            string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");
                            {
                                try
                                {
                                    string[] lines = File.ReadAllLines(filePath);
                                    lines[6] = enemyDamageDealt.ToString();
                                    File.WriteAllLines(filePath, lines);
                                    // Если HP игрока больше 0!   
                                    if (loadSavePlayer.GetPlayerHp() > 0)
                                    {
                                        Console.WriteLine("Вам нанесли :" + "0" + " Урона" + " И оставили вам :" + loadSavePlayer.GetPlayerHp() + " HP");
                                    }
                                    // Если HP игрока меньше или равно 0!
                                    else if (loadSavePlayer.GetPlayerHp() <= 0)
                                    {
                                        int enemyDamageDealtNone = 0;
                                        string[] linesNone = File.ReadAllLines(filePath);
                                        lines[6] = enemyDamageDealtNone.ToString();
                                        File.WriteAllLines(filePath, lines);
                                        Console.WriteLine("Вам нанесли :" + enemyDamageDealtNone + " Урона" + " И оставили вам :" + "0" + " HP");
                                        Console.WriteLine("У вас не достаточно HP для продолжения боя!!!");
                                        RecordEnemyHpFreavellFour();
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                                }
                            }
                        }
                    }
                    //Если сработал крит!!!
                    else if (randomNumberCrit > 8)
                    {
                        // Урон от монстра
                        int enemyDamage = (enemyFreavell.attackEnemyFreavellFour + enemyFreavell.critEnemyFreavellFour) - loadSavePlayer.GetPlayerDefense();
                        //Если в итоге защита выше чем сам урон монстра
                        if (enemyDamage > 0)
                        {
                            int enemyDamageDealt = loadSavePlayer.GetPlayerHp() - enemyDamage;
                            //Запись урона в HP игрока
                            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                            string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");
                            {
                                try
                                {
                                    string[] lines = File.ReadAllLines(filePath);
                                    lines[6] = enemyDamageDealt.ToString();
                                    File.WriteAllLines(filePath, lines);
                                    // Если HP игрока больше 0!   
                                    if (loadSavePlayer.GetPlayerHp() > 0)
                                    {
                                        Console.WriteLine("Вам нанесли :" + enemyDamage + " Урона" + " И оставили вам :" + loadSavePlayer.GetPlayerHp() + " HP");
                                    }
                                    // Если HP игрока меньше или равно 0!
                                    else if (loadSavePlayer.GetPlayerHp() <= 0)
                                    {
                                        int enemyDamageDealtNone = 0;
                                        string[] linesNone = File.ReadAllLines(filePath);
                                        lines[6] = enemyDamageDealtNone.ToString();
                                        File.WriteAllLines(filePath, lines);
                                        Console.WriteLine("Вам нанесли :" + enemyDamageDealtNone + " Урона" + " И оставили вам :" + "0" + " HP");
                                        Console.WriteLine("У вас не достаточно HP для продолжения боя!!!");
                                        RecordEnemyHpFreavellFour();
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                                }
                            }
                        }
                        else
                        {
                            int enemyDamageDealt = loadSavePlayer.GetPlayerHp() - 0;
                            //Запись урона в HP игрока
                            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                            string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");
                            {
                                try
                                {
                                    string[] lines = File.ReadAllLines(filePath);
                                    lines[6] = enemyDamageDealt.ToString();
                                    File.WriteAllLines(filePath, lines);
                                    // Если HP игрока больше 0!   
                                    if (loadSavePlayer.GetPlayerHp() > 0)
                                    {
                                        Console.WriteLine("Вам нанесли :" + "0" + " Урона" + " И оставили вам :" + loadSavePlayer.GetPlayerHp() + " HP");
                                    }
                                    // Если HP игрока меньше или равно 0!
                                    else if (loadSavePlayer.GetPlayerHp() <= 0)
                                    {
                                        int enemyDamageDealtNone = 0;
                                        string[] linesNone = File.ReadAllLines(filePath);
                                        lines[6] = enemyDamageDealtNone.ToString();
                                        File.WriteAllLines(filePath, lines);
                                        Console.WriteLine("Вам нанесли :" + enemyDamageDealtNone + " Урона" + " И оставили вам :" + "0" + " HP");
                                        Console.WriteLine("У вас не достаточно HP для продолжения боя!!!");
                                        RecordEnemyHpFreavellFour();
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
                //Сработал Уворот
                else if (randomNumberDodge <= evasionChance)
                {
                    Console.WriteLine("Сработал уворот!");
                }
            }
            else
            {
                Console.WriteLine("Восстановить здоровье можно зельями HP");
            }
        }
        //######################################################################################################################################
        //---------------------------------АКАТА------ENEMY-----------FIVE----------------------------------------------------------------
        public void AttackEnemyFreavellFive()
        {
            // Заглушка, если у игрока отсутствуют HP!!!!
            if (loadSavePlayer.GetPlayerHp() > 0)
            {
                // Вероятность уворота
                int evasionChance = loadSavePlayer.GetPlayerDodge();
                // Генерация случайного числа от 1 до 100
                int randomNumberDodge = rand.Next(1, 101);
                //Если не сработал крит!!!
                if (randomNumberDodge > evasionChance)
                {
                    // Генерация случайного числа от 1 до 10
                    int randomNumberCrit = rand.Next(1, 11);
                    if (randomNumberCrit <= 8)
                    {
                        // Урон от монстра
                        int enemyDamage = enemyFreavell.attackEnemyFreavellFive - loadSavePlayer.GetPlayerDefense();
                        //Если в итоге защита выше чем сам урон монстра
                        if (enemyDamage > 0)
                        {
                            int enemyDamageDealt = loadSavePlayer.GetPlayerHp() - enemyDamage;
                            //Запись урона в HP игрока
                            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                            string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");
                            {
                                try
                                {
                                    string[] lines = File.ReadAllLines(filePath);
                                    lines[6] = enemyDamageDealt.ToString();
                                    File.WriteAllLines(filePath, lines);
                                    // Если HP игрока больше 0!   
                                    if (loadSavePlayer.GetPlayerHp() > 0)
                                    {
                                        Console.WriteLine("Вам нанесли :" + enemyDamage + " Урона" + " И оставили вам :" + loadSavePlayer.GetPlayerHp() + " HP");
                                    }
                                    // Если HP игрока меньше или равно 0!
                                    else if (loadSavePlayer.GetPlayerHp() <= 0)
                                    {
                                        int enemyDamageDealtNone = 0;
                                        string[] linesNone = File.ReadAllLines(filePath);
                                        lines[6] = enemyDamageDealtNone.ToString();
                                        File.WriteAllLines(filePath, lines);
                                        Console.WriteLine("Вам нанесли :" + enemyDamageDealtNone + " Урона" + " И оставили вам :" + "0" + " HP");
                                        Console.WriteLine("У вас не достаточно HP для продолжения боя!!!");
                                        RecordEnemyHpFreavellFive();
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                                }
                            }
                        }
                        else
                        {
                            int enemyDamageDealt = loadSavePlayer.GetPlayerHp() - 0;
                            //Запись урона в HP игрока
                            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                            string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");
                            {
                                try
                                {
                                    string[] lines = File.ReadAllLines(filePath);
                                    lines[6] = enemyDamageDealt.ToString();
                                    File.WriteAllLines(filePath, lines);
                                    // Если HP игрока больше 0!   
                                    if (loadSavePlayer.GetPlayerHp() > 0)
                                    {
                                        Console.WriteLine("Вам нанесли :" + "0" + " Урона" + " И оставили вам :" + loadSavePlayer.GetPlayerHp() + " HP");
                                    }
                                    // Если HP игрока меньше или равно 0!
                                    else if (loadSavePlayer.GetPlayerHp() <= 0)
                                    {
                                        int enemyDamageDealtNone = 0;
                                        string[] linesNone = File.ReadAllLines(filePath);
                                        lines[6] = enemyDamageDealtNone.ToString();
                                        File.WriteAllLines(filePath, lines);
                                        Console.WriteLine("Вам нанесли :" + enemyDamageDealtNone + " Урона" + " И оставили вам :" + "0" + " HP");
                                        Console.WriteLine("У вас не достаточно HP для продолжения боя!!!");
                                        RecordEnemyHpFreavellFive();
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                                }
                            }
                        }
                    }
                    //Если сработал крит!!!
                    else if (randomNumberCrit > 8)
                    {
                        // Урон от монстра
                        int enemyDamage = (enemyFreavell.attackEnemyFreavellFive + enemyFreavell.critEnemyFreavellFive) - loadSavePlayer.GetPlayerDefense();
                        //Если в итоге защита выше чем сам урон монстра
                        if (enemyDamage > 0)
                        {
                            int enemyDamageDealt = loadSavePlayer.GetPlayerHp() - enemyDamage;
                            //Запись урона в HP игрока
                            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                            string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");
                            {
                                try
                                {
                                    string[] lines = File.ReadAllLines(filePath);
                                    lines[6] = enemyDamageDealt.ToString();
                                    File.WriteAllLines(filePath, lines);
                                    // Если HP игрока больше 0!   
                                    if (loadSavePlayer.GetPlayerHp() > 0)
                                    {
                                        Console.WriteLine("Вам нанесли :" + enemyDamage + " Урона" + " И оставили вам :" + loadSavePlayer.GetPlayerHp() + " HP");
                                    }
                                    // Если HP игрока меньше или равно 0!
                                    else if (loadSavePlayer.GetPlayerHp() <= 0)
                                    {
                                        int enemyDamageDealtNone = 0;
                                        string[] linesNone = File.ReadAllLines(filePath);
                                        lines[6] = enemyDamageDealtNone.ToString();
                                        File.WriteAllLines(filePath, lines);
                                        Console.WriteLine("Вам нанесли :" + enemyDamageDealtNone + " Урона" + " И оставили вам :" + "0" + " HP");
                                        Console.WriteLine("У вас не достаточно HP для продолжения боя!!!");
                                        RecordEnemyHpFreavellFive();
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                                }
                            }
                        }
                        else
                        {
                            int enemyDamageDealt = loadSavePlayer.GetPlayerHp() - 0;
                            //Запись урона в HP игрока
                            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                            string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");
                            {
                                try
                                {
                                    string[] lines = File.ReadAllLines(filePath);
                                    lines[6] = enemyDamageDealt.ToString();
                                    File.WriteAllLines(filePath, lines);
                                    // Если HP игрока больше 0!   
                                    if (loadSavePlayer.GetPlayerHp() > 0)
                                    {
                                        Console.WriteLine("Вам нанесли :" + "0" + " Урона" + " И оставили вам :" + loadSavePlayer.GetPlayerHp() + " HP");
                                    }
                                    // Если HP игрока меньше или равно 0!
                                    else if (loadSavePlayer.GetPlayerHp() <= 0)
                                    {
                                        int enemyDamageDealtNone = 0;
                                        string[] linesNone = File.ReadAllLines(filePath);
                                        lines[6] = enemyDamageDealtNone.ToString();
                                        File.WriteAllLines(filePath, lines);
                                        Console.WriteLine("Вам нанесли :" + enemyDamageDealtNone + " Урона" + " И оставили вам :" + "0" + " HP");
                                        Console.WriteLine("У вас не достаточно HP для продолжения боя!!!");
                                        RecordEnemyHpFreavellFive();
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
                //Сработал Уворот
                else if (randomNumberDodge <= evasionChance)
                {
                    Console.WriteLine("Сработал уворот!");
                }
            }
            else
            {
                Console.WriteLine("Восстановить здоровье можно зельями HP");
            }
        }

        //######################################################################################################################################
        //---------------------------------АКАТА------ENEMY-----------BOSS---ONE-------------------------------------------------------------
        public void AttackEnemyFreavellBossOne()
        {
            // Заглушка, если у игрока отсутствуют HP!!!!
            if (loadSavePlayer.GetPlayerHp() > 0)
            {
                // Вероятность уворота
                int evasionChance = loadSavePlayer.GetPlayerDodge();
                // Генерация случайного числа от 1 до 100
                int randomNumberDodge = rand.Next(1, 101);
                //Если не сработал крит!!!
                if (randomNumberDodge > evasionChance)
                {
                    // Генерация случайного числа от 1 до 10
                    int randomNumberCrit = rand.Next(1, 11);
                    if (randomNumberCrit <= 8)
                    {
                        // Урон от монстра
                        int enemyDamage = enemyFreavell.attackEnemyFreavellBossOne - loadSavePlayer.GetPlayerDefense();
                        //Если в итоге защита выше чем сам урон монстра
                        if (enemyDamage > 0)
                        {
                            int enemyDamageDealt = loadSavePlayer.GetPlayerHp() - enemyDamage;
                            //Запись урона в HP игрока
                            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                            string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");
                            {
                                try
                                {
                                    string[] lines = File.ReadAllLines(filePath);
                                    lines[6] = enemyDamageDealt.ToString();
                                    File.WriteAllLines(filePath, lines);
                                    // Если HP игрока больше 0!   
                                    if (loadSavePlayer.GetPlayerHp() > 0)
                                    {
                                        Console.WriteLine("Вам нанесли :" + enemyDamage + " Урона" + " И оставили вам :" + loadSavePlayer.GetPlayerHp() + " HP");
                                    }
                                    // Если HP игрока меньше или равно 0!
                                    else if (loadSavePlayer.GetPlayerHp() <= 0)
                                    {
                                        int enemyDamageDealtNone = 0;
                                        string[] linesNone = File.ReadAllLines(filePath);
                                        lines[6] = enemyDamageDealtNone.ToString();
                                        File.WriteAllLines(filePath, lines);
                                        Console.WriteLine("Вам нанесли :" + enemyDamageDealtNone + " Урона" + " И оставили вам :" + "0" + " HP");
                                        Console.WriteLine("У вас не достаточно HP для продолжения боя!!!");
                                        RecordEnemyHpFreavellBossOne();
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                                }
                            }
                        }
                        else
                        {
                            int enemyDamageDealt = loadSavePlayer.GetPlayerHp() - 0;
                            //Запись урона в HP игрока
                            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                            string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");
                            {
                                try
                                {
                                    string[] lines = File.ReadAllLines(filePath);
                                    lines[6] = enemyDamageDealt.ToString();
                                    File.WriteAllLines(filePath, lines);
                                    // Если HP игрока больше 0!   
                                    if (loadSavePlayer.GetPlayerHp() > 0)
                                    {
                                        Console.WriteLine("Вам нанесли :" + "0" + " Урона" + " И оставили вам :" + loadSavePlayer.GetPlayerHp() + " HP");
                                    }
                                    // Если HP игрока меньше или равно 0!
                                    else if (loadSavePlayer.GetPlayerHp() <= 0)
                                    {
                                        int enemyDamageDealtNone = 0;
                                        string[] linesNone = File.ReadAllLines(filePath);
                                        lines[6] = enemyDamageDealtNone.ToString();
                                        File.WriteAllLines(filePath, lines);
                                        Console.WriteLine("Вам нанесли :" + enemyDamageDealtNone + " Урона" + " И оставили вам :" + "0" + " HP");
                                        Console.WriteLine("У вас не достаточно HP для продолжения боя!!!");
                                        RecordEnemyHpFreavellBossOne();
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                                }
                            }
                        }
                    }
                    //Если сработал крит!!!
                    else if (randomNumberCrit > 8)
                    {
                        // Урон от монстра
                        int enemyDamage = (enemyFreavell.attackEnemyFreavellBossOne + enemyFreavell.critEnemyFreavellBossOne) - loadSavePlayer.GetPlayerDefense();
                        //Если в итоге защита выше чем сам урон монстра
                        if (enemyDamage > 0)
                        {
                            int enemyDamageDealt = loadSavePlayer.GetPlayerHp() - enemyDamage;
                            //Запись урона в HP игрока
                            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                            string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");
                            {
                                try
                                {
                                    string[] lines = File.ReadAllLines(filePath);
                                    lines[6] = enemyDamageDealt.ToString();
                                    File.WriteAllLines(filePath, lines);
                                    // Если HP игрока больше 0!   
                                    if (loadSavePlayer.GetPlayerHp() > 0)
                                    {
                                        Console.WriteLine("Вам нанесли :" + enemyDamage + " Урона" + " И оставили вам :" + loadSavePlayer.GetPlayerHp() + " HP");

                                        //##############################################################################################################
                                        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!-----крит---хилл--босса----------------------!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                                        string directoryPathHeal = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                                        string filePathHeal = Path.Combine(directoryPath, "gamehpenemy.txt");
                                        int setEnemyHp = GetEnemyHp() + 40;
                                        if (setEnemyHp < enemyFreavell.hpEnemyFreavellBossOne)
                                        {
                                            {
                                                try
                                                {
                                                    string[] linesHeal = File.ReadAllLines(filePathHeal);
                                                    linesHeal[0] = setEnemyHp.ToString();
                                                    File.WriteAllLines(filePathHeal, linesHeal);
                                                    Console.WriteLine("Босс восстановил себе 40 HP");
                                                }
                                                catch (Exception ex)
                                                {
                                                    Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                                                }
                                            }
                                        }
                                        else if (setEnemyHp >= enemyFreavell.hpEnemyFreavellBossOne)
                                        {
                                            int standartHp = enemyFreavell.hpEnemyFreavellBossOne;
                                            {
                                                try
                                                {
                                                    string[] linesHeal = File.ReadAllLines(filePathHeal);
                                                    linesHeal[0] = standartHp.ToString();
                                                    File.WriteAllLines(filePathHeal, linesHeal);
                                                    Console.WriteLine("Босс полностью восстановил себе HP");
                                                }
                                                catch (Exception ex)
                                                {
                                                    Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                                                }
                                            }
                                        }
                                    }
                                    // Если HP игрока меньше или равно 0!
                                    else if (loadSavePlayer.GetPlayerHp() <= 0)
                                    {
                                        int enemyDamageDealtNone = 0;
                                        string[] linesNone = File.ReadAllLines(filePath);
                                        lines[6] = enemyDamageDealtNone.ToString();
                                        File.WriteAllLines(filePath, lines);
                                        Console.WriteLine("Вам нанесли :" + enemyDamageDealtNone + " Урона" + " И оставили вам :" + "0" + " HP");
                                        Console.WriteLine("У вас не достаточно HP для продолжения боя!!!");
                                        RecordEnemyHpFreavellBossOne();
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                                }
                            }
                        }
                        else
                        {
                            int enemyDamageDealt = loadSavePlayer.GetPlayerHp() - 0;
                            //Запись урона в HP игрока
                            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                            string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");
                            {
                                try
                                {
                                    string[] lines = File.ReadAllLines(filePath);
                                    lines[6] = enemyDamageDealt.ToString();
                                    File.WriteAllLines(filePath, lines);
                                    // Если HP игрока больше 0!   
                                    if (loadSavePlayer.GetPlayerHp() > 0)
                                    {
                                        Console.WriteLine("Вам нанесли :" + "0" + " Урона" + " И оставили вам :" + loadSavePlayer.GetPlayerHp() + " HP");
                                    }
                                    // Если HP игрока меньше или равно 0!
                                    else if (loadSavePlayer.GetPlayerHp() <= 0)
                                    {
                                        int enemyDamageDealtNone = 0;
                                        string[] linesNone = File.ReadAllLines(filePath);
                                        lines[6] = enemyDamageDealtNone.ToString();
                                        File.WriteAllLines(filePath, lines);
                                        Console.WriteLine("Вам нанесли :" + enemyDamageDealtNone + " Урона" + " И оставили вам :" + "0" + " HP");
                                        Console.WriteLine("У вас не достаточно HP для продолжения боя!!!");
                                        RecordEnemyHpFreavellBossOne();
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
                //Сработал Уворот
                else if (randomNumberDodge <= evasionChance)
                {
                    Console.WriteLine("Сработал уворот!");
                }
            }
            else
            {
                Console.WriteLine("Восстановить здоровье можно зельями HP");
            }
        }
        //######################################################################################################################################
        //---------------------------------АКАТА------ENEMY-----------BOSS---TWO-------------------------------------------------------------
        public void AttackEnemyFreavellBossTwo()
        {
            // Заглушка, если у игрока отсутствуют HP!!!!
            if (loadSavePlayer.GetPlayerHp() > 0)
            {
                // Вероятность уворота
                int evasionChance = loadSavePlayer.GetPlayerDodge();
                // Генерация случайного числа от 1 до 100
                int randomNumberDodge = rand.Next(1, 101);
                //Если не сработал крит!!!
                if (randomNumberDodge > evasionChance)
                {
                    // Генерация случайного числа от 1 до 10
                    int randomNumberCrit = rand.Next(1, 11);
                    if (randomNumberCrit <= 8)
                    {
                        // Урон от монстра
                        int enemyDamage = enemyFreavell.attackEnemyFreavellBossTwo - loadSavePlayer.GetPlayerDefense();
                        //Если в итоге защита выше чем сам урон монстра
                        if (enemyDamage > 0)
                        {
                            int enemyDamageDealt = loadSavePlayer.GetPlayerHp() - enemyDamage;
                            //Запись урона в HP игрока
                            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                            string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");
                            {
                                try
                                {
                                    string[] lines = File.ReadAllLines(filePath);
                                    lines[6] = enemyDamageDealt.ToString();
                                    File.WriteAllLines(filePath, lines);
                                    // Если HP игрока больше 0!   
                                    if (loadSavePlayer.GetPlayerHp() > 0)
                                    {
                                        Console.WriteLine("Вам нанесли :" + enemyDamage + " Урона" + " И оставили вам :" + loadSavePlayer.GetPlayerHp() + " HP");
                                    }
                                    // Если HP игрока меньше или равно 0!
                                    else if (loadSavePlayer.GetPlayerHp() <= 0)
                                    {
                                        int enemyDamageDealtNone = 0;
                                        string[] linesNone = File.ReadAllLines(filePath);
                                        lines[6] = enemyDamageDealtNone.ToString();
                                        File.WriteAllLines(filePath, lines);
                                        Console.WriteLine("Вам нанесли :" + enemyDamageDealtNone + " Урона" + " И оставили вам :" + "0" + " HP");
                                        Console.WriteLine("У вас не достаточно HP для продолжения боя!!!");
                                        RecordEnemyHpFreavellBossTwo();
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                                }
                            }
                        }
                        else
                        {
                            int enemyDamageDealt = loadSavePlayer.GetPlayerHp() - 0;
                            //Запись урона в HP игрока
                            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                            string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");
                            {
                                try
                                {
                                    string[] lines = File.ReadAllLines(filePath);
                                    lines[6] = enemyDamageDealt.ToString();
                                    File.WriteAllLines(filePath, lines);
                                    // Если HP игрока больше 0!   
                                    if (loadSavePlayer.GetPlayerHp() > 0)
                                    {
                                        Console.WriteLine("Вам нанесли :" + "0" + " Урона" + " И оставили вам :" + loadSavePlayer.GetPlayerHp() + " HP");
                                    }
                                    // Если HP игрока меньше или равно 0!
                                    else if (loadSavePlayer.GetPlayerHp() <= 0)
                                    {
                                        int enemyDamageDealtNone = 0;
                                        string[] linesNone = File.ReadAllLines(filePath);
                                        lines[6] = enemyDamageDealtNone.ToString();
                                        File.WriteAllLines(filePath, lines);
                                        Console.WriteLine("Вам нанесли :" + enemyDamageDealtNone + " Урона" + " И оставили вам :" + "0" + " HP");
                                        Console.WriteLine("У вас не достаточно HP для продолжения боя!!!");
                                        RecordEnemyHpFreavellBossTwo();
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                                }
                            }
                        }
                    }
                    //Если сработал крит!!!
                    else if (randomNumberCrit > 8)
                    {
                        // Урон от монстра
                        int enemyDamage = (enemyFreavell.attackEnemyFreavellBossTwo + enemyFreavell.critEnemyFreavellBossTwo) - loadSavePlayer.GetPlayerDefense();
                        //Если в итоге защита выше чем сам урон монстра
                        if (enemyDamage > 0)
                        {
                            int enemyDamageDealt = loadSavePlayer.GetPlayerHp() - enemyDamage;
                            //Запись урона в HP игрока
                            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                            string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");
                            {
                                try
                                {
                                    string[] lines = File.ReadAllLines(filePath);
                                    lines[6] = enemyDamageDealt.ToString();
                                    File.WriteAllLines(filePath, lines);
                                    // Если HP игрока больше 0!   
                                    if (loadSavePlayer.GetPlayerHp() > 0)
                                    {
                                        Console.WriteLine("Вам нанесли :" + enemyDamage + " Урона" + " И оставили вам :" + loadSavePlayer.GetPlayerHp() + " HP");

                                        //##############################################################################################################
                                        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!-----крит---хилл--босса----------------------!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                                        string directoryPathHeal = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                                        string filePathHeal = Path.Combine(directoryPath, "gamehpenemy.txt");
                                        int setEnemyHp = GetEnemyHp() + 40;
                                        if (setEnemyHp < enemyFreavell.hpEnemyFreavellBossTwo)
                                        {
                                            {
                                                try
                                                {
                                                    string[] linesHeal = File.ReadAllLines(filePathHeal);
                                                    linesHeal[0] = setEnemyHp.ToString();
                                                    File.WriteAllLines(filePathHeal, linesHeal);
                                                    Console.WriteLine("Босс восстановил себе 40 HP");
                                                }
                                                catch (Exception ex)
                                                {
                                                    Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                                                }
                                            }
                                        }
                                        else if (setEnemyHp >= enemyFreavell.hpEnemyFreavellBossTwo)
                                        {
                                            int standartHp = enemyFreavell.hpEnemyFreavellBossTwo;
                                            {
                                                try
                                                {
                                                    string[] linesHeal = File.ReadAllLines(filePathHeal);
                                                    linesHeal[0] = standartHp.ToString();
                                                    File.WriteAllLines(filePathHeal, linesHeal);
                                                    Console.WriteLine("Босс полностью восстановил себе HP");
                                                }
                                                catch (Exception ex)
                                                {
                                                    Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                                                }
                                            }
                                        }
                                    }
                                    // Если HP игрока меньше или равно 0!
                                    else if (loadSavePlayer.GetPlayerHp() <= 0)
                                    {
                                        int enemyDamageDealtNone = 0;
                                        string[] linesNone = File.ReadAllLines(filePath);
                                        lines[6] = enemyDamageDealtNone.ToString();
                                        File.WriteAllLines(filePath, lines);
                                        Console.WriteLine("Вам нанесли :" + enemyDamageDealtNone + " Урона" + " И оставили вам :" + "0" + " HP");
                                        Console.WriteLine("У вас не достаточно HP для продолжения боя!!!");
                                        RecordEnemyHpFreavellBossTwo();
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                                }
                            }
                        }
                        else
                        {
                            int enemyDamageDealt = loadSavePlayer.GetPlayerHp() - 0;
                            //Запись урона в HP игрока
                            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                            string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");
                            {
                                try
                                {
                                    string[] lines = File.ReadAllLines(filePath);
                                    lines[6] = enemyDamageDealt.ToString();
                                    File.WriteAllLines(filePath, lines);
                                    // Если HP игрока больше 0!   
                                    if (loadSavePlayer.GetPlayerHp() > 0)
                                    {
                                        Console.WriteLine("Вам нанесли :" + "0" + " Урона" + " И оставили вам :" + loadSavePlayer.GetPlayerHp() + " HP");
                                    }
                                    // Если HP игрока меньше или равно 0!
                                    else if (loadSavePlayer.GetPlayerHp() <= 0)
                                    {
                                        int enemyDamageDealtNone = 0;
                                        string[] linesNone = File.ReadAllLines(filePath);
                                        lines[6] = enemyDamageDealtNone.ToString();
                                        File.WriteAllLines(filePath, lines);
                                        Console.WriteLine("Вам нанесли :" + enemyDamageDealtNone + " Урона" + " И оставили вам :" + "0" + " HP");
                                        Console.WriteLine("У вас не достаточно HP для продолжения боя!!!");
                                        RecordEnemyHpFreavellBossTwo();
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
                //Сработал Уворот
                else if (randomNumberDodge <= evasionChance)
                {
                    Console.WriteLine("Сработал уворот!");
                }
            }
            else
            {
                Console.WriteLine("Восстановить здоровье можно зельями HP");
            }
        }
        //######################################################################################################################################
        //---------------------------------АКАТА------ENEMY-----------BOSS---THREE-------------------------------------------------------------
        public void AttackEnemyFreavellBossThree()
        {
            // Заглушка, если у игрока отсутствуют HP!!!!
            if (loadSavePlayer.GetPlayerHp() > 0)
            {
                // Вероятность уворота
                int evasionChance = loadSavePlayer.GetPlayerDodge();
                // Генерация случайного числа от 1 до 100
                int randomNumberDodge = rand.Next(1, 101);
                //Если не сработал крит!!!
                if (randomNumberDodge > evasionChance)
                {
                    // Генерация случайного числа от 1 до 10
                    int randomNumberCrit = rand.Next(1, 11);
                    if (randomNumberCrit <= 8)
                    {
                        // Урон от монстра
                        int enemyDamage = enemyFreavell.attackEnemyFreavellBossThree - loadSavePlayer.GetPlayerDefense();
                        //Если в итоге защита выше чем сам урон монстра
                        if (enemyDamage > 0)
                        {
                            int enemyDamageDealt = loadSavePlayer.GetPlayerHp() - enemyDamage;
                            //Запись урона в HP игрока
                            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                            string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");
                            {
                                try
                                {
                                    string[] lines = File.ReadAllLines(filePath);
                                    lines[6] = enemyDamageDealt.ToString();
                                    File.WriteAllLines(filePath, lines);
                                    // Если HP игрока больше 0!   
                                    if (loadSavePlayer.GetPlayerHp() > 0)
                                    {
                                        Console.WriteLine("Вам нанесли :" + enemyDamage + " Урона" + " И оставили вам :" + loadSavePlayer.GetPlayerHp() + " HP");
                                    }
                                    // Если HP игрока меньше или равно 0!
                                    else if (loadSavePlayer.GetPlayerHp() <= 0)
                                    {
                                        int enemyDamageDealtNone = 0;
                                        string[] linesNone = File.ReadAllLines(filePath);
                                        lines[6] = enemyDamageDealtNone.ToString();
                                        File.WriteAllLines(filePath, lines);
                                        Console.WriteLine("Вам нанесли :" + enemyDamageDealtNone + " Урона" + " И оставили вам :" + "0" + " HP");
                                        Console.WriteLine("У вас не достаточно HP для продолжения боя!!!");
                                        RecordEnemyHpFreavellBossThree();
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                                }
                            }
                        }
                        else
                        {
                            int enemyDamageDealt = loadSavePlayer.GetPlayerHp() - 0;
                            //Запись урона в HP игрока
                            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                            string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");
                            {
                                try
                                {
                                    string[] lines = File.ReadAllLines(filePath);
                                    lines[6] = enemyDamageDealt.ToString();
                                    File.WriteAllLines(filePath, lines);
                                    // Если HP игрока больше 0!   
                                    if (loadSavePlayer.GetPlayerHp() > 0)
                                    {
                                        Console.WriteLine("Вам нанесли :" + "0" + " Урона" + " И оставили вам :" + loadSavePlayer.GetPlayerHp() + " HP");
                                    }
                                    // Если HP игрока меньше или равно 0!
                                    else if (loadSavePlayer.GetPlayerHp() <= 0)
                                    {
                                        int enemyDamageDealtNone = 0;
                                        string[] linesNone = File.ReadAllLines(filePath);
                                        lines[6] = enemyDamageDealtNone.ToString();
                                        File.WriteAllLines(filePath, lines);
                                        Console.WriteLine("Вам нанесли :" + enemyDamageDealtNone + " Урона" + " И оставили вам :" + "0" + " HP");
                                        Console.WriteLine("У вас не достаточно HP для продолжения боя!!!");
                                        RecordEnemyHpFreavellBossThree();
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                                }
                            }
                        }
                    }
                    //Если сработал крит!!!
                    else if (randomNumberCrit > 8)
                    {
                        // Урон от монстра
                        int enemyDamage = (enemyFreavell.attackEnemyFreavellBossThree + enemyFreavell.critEnemyFreavellBossThree) - loadSavePlayer.GetPlayerDefense();
                        //Если в итоге защита выше чем сам урон монстра
                        if (enemyDamage > 0)
                        {
                            int enemyDamageDealt = loadSavePlayer.GetPlayerHp() - enemyDamage;
                            //Запись урона в HP игрока
                            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                            string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");
                            {
                                try
                                {
                                    string[] lines = File.ReadAllLines(filePath);
                                    lines[6] = enemyDamageDealt.ToString();
                                    File.WriteAllLines(filePath, lines);
                                    // Если HP игрока больше 0!   
                                    if (loadSavePlayer.GetPlayerHp() > 0)
                                    {
                                        Console.WriteLine("Вам нанесли :" + enemyDamage + " Урона" + " И оставили вам :" + loadSavePlayer.GetPlayerHp() + " HP");

                                        //##############################################################################################################
                                        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!-----крит---хилл--босса----------------------!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                                        string directoryPathHeal = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                                        string filePathHeal = Path.Combine(directoryPath, "gamehpenemy.txt");
                                        int setEnemyHp = GetEnemyHp() + 40;
                                        if (setEnemyHp < enemyFreavell.hpEnemyFreavellBossThree)
                                        {
                                            {
                                                try
                                                {
                                                    string[] linesHeal = File.ReadAllLines(filePathHeal);
                                                    linesHeal[0] = setEnemyHp.ToString();
                                                    File.WriteAllLines(filePathHeal, linesHeal);
                                                    Console.WriteLine("Босс восстановил себе 40 HP");
                                                }
                                                catch (Exception ex)
                                                {
                                                    Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                                                }
                                            }
                                        }
                                        else if (setEnemyHp >= enemyFreavell.hpEnemyFreavellBossThree)
                                        {
                                            int standartHp = enemyFreavell.hpEnemyFreavellBossThree;
                                            {
                                                try
                                                {
                                                    string[] linesHeal = File.ReadAllLines(filePathHeal);
                                                    linesHeal[0] = standartHp.ToString();
                                                    File.WriteAllLines(filePathHeal, linesHeal);
                                                    Console.WriteLine("Босс полностью восстановил себе HP");
                                                }
                                                catch (Exception ex)
                                                {
                                                    Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                                                }
                                            }
                                        }
                                    }
                                    // Если HP игрока меньше или равно 0!
                                    else if (loadSavePlayer.GetPlayerHp() <= 0)
                                    {
                                        int enemyDamageDealtNone = 0;
                                        string[] linesNone = File.ReadAllLines(filePath);
                                        lines[6] = enemyDamageDealtNone.ToString();
                                        File.WriteAllLines(filePath, lines);
                                        Console.WriteLine("Вам нанесли :" + enemyDamageDealtNone + " Урона" + " И оставили вам :" + "0" + " HP");
                                        Console.WriteLine("У вас не достаточно HP для продолжения боя!!!");
                                        RecordEnemyHpFreavellBossThree();
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                                }
                            }
                        }
                        else
                        {
                            int enemyDamageDealt = loadSavePlayer.GetPlayerHp() - 0;
                            //Запись урона в HP игрока
                            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                            string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");
                            {
                                try
                                {
                                    string[] lines = File.ReadAllLines(filePath);
                                    lines[6] = enemyDamageDealt.ToString();
                                    File.WriteAllLines(filePath, lines);
                                    // Если HP игрока больше 0!   
                                    if (loadSavePlayer.GetPlayerHp() > 0)
                                    {
                                        Console.WriteLine("Вам нанесли :" + "0" + " Урона" + " И оставили вам :" + loadSavePlayer.GetPlayerHp() + " HP");
                                    }
                                    // Если HP игрока меньше или равно 0!
                                    else if (loadSavePlayer.GetPlayerHp() <= 0)
                                    {
                                        int enemyDamageDealtNone = 0;
                                        string[] linesNone = File.ReadAllLines(filePath);
                                        lines[6] = enemyDamageDealtNone.ToString();
                                        File.WriteAllLines(filePath, lines);
                                        Console.WriteLine("Вам нанесли :" + enemyDamageDealtNone + " Урона" + " И оставили вам :" + "0" + " HP");
                                        Console.WriteLine("У вас не достаточно HP для продолжения боя!!!");
                                        RecordEnemyHpFreavellBossThree();
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
                //Сработал Уворот
                else if (randomNumberDodge <= evasionChance)
                {
                    Console.WriteLine("Сработал уворот!");
                }
            }
            else
            {
                Console.WriteLine("Восстановить здоровье можно зельями HP");
            }
        }
    }
}
