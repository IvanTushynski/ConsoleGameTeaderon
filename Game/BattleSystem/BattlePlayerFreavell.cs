using Game.DropSystem;
using Game.Enemies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.BattleSystem
{
    internal class BattlePlayerFreavell
    {
        EnemyFreavell enemyFreavell = new EnemyFreavell();
        LoadSavePlayer loadSavePlayer = new LoadSavePlayer();
        BattleMonsterFreavell battleFreavell = new BattleMonsterFreavell();
        DropFreavell dropFreavell = new DropFreavell();
        Random rand = new Random();

        //######################################################################################################################################
        //---------------------------------АКАТА------ENEMY-----------ONE----------------------------------------------------------------
        public void AttackEnemyFreavellOne()
        {
            // Заглушка, если у игрока отсутствуют HP или энергия!!!!
            if (loadSavePlayer.GetPlayerHp() > 0 && loadSavePlayer.GetPlayerEnergy() >= 1)
            {
                // Вероятность уворота
                int evasionChance = enemyFreavell.dodgeEnemyFreavellOne;
                // Генерация случайного числа от 1 до 100
                int randomNumberDodge = rand.Next(1, 101);
                //Если не сработал крит!!!
                if (randomNumberDodge > evasionChance)
                {
                    // Генерация случайного числа от 1 до 10
                    int randomNumberCrit = rand.Next(1, 11);
                    if (randomNumberCrit <= 8)
                    {
                        // Урон по монстру
                        int playerDamage = loadSavePlayer.GetPlayerAttack() - enemyFreavell.defenseEnemyFreavellOne;
                        //Если в итоге защита выше чем сам урон монстра
                        if (playerDamage > 0)
                        {
                            int playerDamageDealt = battleFreavell.GetEnemyHp() - playerDamage;
                            //Запись урона в HP монстра
                            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                            string filePath = Path.Combine(directoryPath, "gamehpenemy.txt");
                            {
                                try
                                {
                                    string[] lines = File.ReadAllLines(filePath);
                                    lines[0] = playerDamageDealt.ToString();
                                    File.WriteAllLines(filePath, lines);
                                    // Если HP противника больше 0!   
                                    if (battleFreavell.GetEnemyHp() > 0)
                                    {
                                        Console.WriteLine("Вы нанесли :" + playerDamage + " Урона" + " И оставили ему :" + battleFreavell.GetEnemyHp() + " HP");
                                    }
                                    // Если HP противника меньше или равно 0!
                                    else if (battleFreavell.GetEnemyHp() <= 0)
                                    {
                                        Console.WriteLine("Вы нанесли :" + playerDamage + " Урона" + " И оставили ему :" + "0" + " HP");
                                        Console.WriteLine("Противник убит!!!");
                                        battleFreavell.RecordEnemyHpFreavellOne();
                                        dropFreavell.DropFreavellOne();
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
                            int playerDamageDealt = battleFreavell.GetEnemyHp() - 0;
                            //Запись урона в HP монстра
                            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                            string filePath = Path.Combine(directoryPath, "gamehpenemy.txt");
                            {
                                try
                                {
                                    string[] lines = File.ReadAllLines(filePath);
                                    lines[0] = playerDamageDealt.ToString();
                                    File.WriteAllLines(filePath, lines);
                                    // Если HP противника больше 0!   
                                    if (battleFreavell.GetEnemyHp() > 0)
                                    {
                                        Console.WriteLine("Вы нанесли :" + playerDamage + " Урона" + " И оставили ему :" + battleFreavell.GetEnemyHp() + " HP");
                                    }
                                    // Если HP противника меньше или равно 0!
                                    else if (battleFreavell.GetEnemyHp() <= 0)
                                    {
                                        Console.WriteLine("Вы нанесли :" + playerDamage + " Урона" + " И оставили ему :" + "0" + " HP");
                                        Console.WriteLine("Противник убит!!!");
                                        battleFreavell.RecordEnemyHpFreavellOne();
                                        dropFreavell.DropFreavellOne();
                                    };
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
                        // Урон по монстру
                        int playerDamage = (loadSavePlayer.GetPlayerAttack() + loadSavePlayer.GetPlayerCrit()) - enemyFreavell.defenseEnemyFreavellOne;
                        //Если в итоге защита выше чем сам урон игрока
                        if (playerDamage > 0)
                        {
                            int playerDamageDealt = battleFreavell.GetEnemyHp() - playerDamage;
                            //Запись урона в HP монстра
                            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                            string filePath = Path.Combine(directoryPath, "gamehpenemy.txt");
                            {
                                try
                                {
                                    string[] lines = File.ReadAllLines(filePath);
                                    lines[0] = playerDamageDealt.ToString();
                                    File.WriteAllLines(filePath, lines);
                                    // Если HP противника больше 0!   
                                    if (battleFreavell.GetEnemyHp() > 0)
                                    {
                                        Console.WriteLine("Вы нанесли :" + playerDamage + " Урона" + " И оставили ему :" + battleFreavell.GetEnemyHp() + " HP");
                                    }
                                    // Если HP противника меньше или равно 0!
                                    else if (battleFreavell.GetEnemyHp() <= 0)
                                    {
                                        Console.WriteLine("Вы нанесли :" + playerDamage + " Урона" + " И оставили ему :" + "0" + " HP");
                                        Console.WriteLine("Противник убит!!!");
                                        battleFreavell.RecordEnemyHpFreavellOne();
                                        dropFreavell.DropFreavellOne();
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
                            int playerDamageDealt = battleFreavell.GetEnemyHp() - 0;
                            //Запись урона в HP монстра
                            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                            string filePath = Path.Combine(directoryPath, "gamehpenemy.txt");
                            {
                                try
                                {
                                    string[] lines = File.ReadAllLines(filePath);
                                    lines[0] = playerDamageDealt.ToString();
                                    File.WriteAllLines(filePath, lines);
                                    // Если HP противника больше 0!   
                                    if (battleFreavell.GetEnemyHp() > 0)
                                    {
                                        Console.WriteLine("Вы нанесли :" + playerDamage + " Урона" + " И оставили ему :" + battleFreavell.GetEnemyHp() + " HP");
                                    }
                                    // Если HP противника меньше или равно 0!
                                    else if (battleFreavell.GetEnemyHp() <= 0)
                                    {
                                        Console.WriteLine("Вы нанесли :" + playerDamage + " Урона" + " И оставили ему :" + "0" + " HP");
                                        Console.WriteLine("Противник убит!!!");
                                        battleFreavell.RecordEnemyHpFreavellOne();
                                        dropFreavell.DropFreavellOne();
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
                Console.WriteLine("Для продолжения боя необходимо восполнить HP игрока");
                Console.WriteLine("либо пополнить запасы энергии");
            }
        }
        //######################################################################################################################################
        //---------------------------------АКАТА------ENEMY-----------TWO---------------------------------------------------------------
        public void AttackEnemyFreavellTwo()
        {
            // Заглушка, если у игрока отсутствуют HP!!!!
            if (loadSavePlayer.GetPlayerHp() > 0 && loadSavePlayer.GetPlayerEnergy() >= 1)
            {
                // Вероятность уворота
                int evasionChance = enemyFreavell.dodgeEnemyFreavellTwo;
                // Генерация случайного числа от 1 до 100
                int randomNumberDodge = rand.Next(1, 101);
                //Если не сработал крит!!!
                if (randomNumberDodge > evasionChance)
                {
                    // Генерация случайного числа от 1 до 10
                    int randomNumberCrit = rand.Next(1, 11);
                    if (randomNumberCrit <= 8)
                    {
                        // Урон по монстру
                        int playerDamage = loadSavePlayer.GetPlayerAttack() - enemyFreavell.defenseEnemyFreavellTwo;
                        //Если в итоге защита выше чем сам урон монстра
                        if (playerDamage > 0)
                        {
                            int playerDamageDealt = battleFreavell.GetEnemyHp() - playerDamage;
                            //Запись урона в HP монстра
                            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                            string filePath = Path.Combine(directoryPath, "gamehpenemy.txt");
                            {
                                try
                                {
                                    string[] lines = File.ReadAllLines(filePath);
                                    lines[0] = playerDamageDealt.ToString();
                                    File.WriteAllLines(filePath, lines);
                                    // Если HP противника больше 0!   
                                    if (battleFreavell.GetEnemyHp() > 0)
                                    {
                                        Console.WriteLine("Вы нанесли :" + playerDamage + " Урона" + " И оставили ему :" + battleFreavell.GetEnemyHp() + " HP");
                                    }
                                    // Если HP противника меньше или равно 0!
                                    else if (battleFreavell.GetEnemyHp() <= 0)
                                    {
                                        Console.WriteLine("Вы нанесли :" + playerDamage + " Урона" + " И оставили ему :" + "0" + " HP");
                                        Console.WriteLine("Противник убит!!!");
                                        battleFreavell.RecordEnemyHpFreavellTwo();
                                        dropFreavell.DropFreavellTwo();
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
                            int playerDamageDealt = battleFreavell.GetEnemyHp() - 0;
                            //Запись урона в HP монстра
                            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                            string filePath = Path.Combine(directoryPath, "gamehpenemy.txt");
                            {
                                try
                                {
                                    string[] lines = File.ReadAllLines(filePath);
                                    lines[0] = playerDamageDealt.ToString();
                                    File.WriteAllLines(filePath, lines);
                                    // Если HP противника больше 0!   
                                    if (battleFreavell.GetEnemyHp() > 0)
                                    {
                                        Console.WriteLine("Вы нанесли :" + playerDamage + " Урона" + " И оставили ему :" + battleFreavell.GetEnemyHp() + " HP");
                                    }
                                    // Если HP противника меньше или равно 0!
                                    else if (battleFreavell.GetEnemyHp() <= 0)
                                    {
                                        Console.WriteLine("Вы нанесли :" + playerDamage + " Урона" + " И оставили ему :" + "0" + " HP");
                                        Console.WriteLine("Противник убит!!!");
                                        battleFreavell.RecordEnemyHpFreavellTwo();
                                        dropFreavell.DropFreavellTwo();
                                    };
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
                        // Урон по монстру
                        int playerDamage = (loadSavePlayer.GetPlayerAttack() + loadSavePlayer.GetPlayerCrit()) - enemyFreavell.defenseEnemyFreavellTwo;
                        //Если в итоге защита выше чем сам урон игрока
                        if (playerDamage > 0)
                        {
                            int playerDamageDealt = battleFreavell.GetEnemyHp() - playerDamage;
                            //Запись урона в HP монстра
                            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                            string filePath = Path.Combine(directoryPath, "gamehpenemy.txt");
                            {
                                try
                                {
                                    string[] lines = File.ReadAllLines(filePath);
                                    lines[0] = playerDamageDealt.ToString();
                                    File.WriteAllLines(filePath, lines);
                                    // Если HP противника больше 0!   
                                    if (battleFreavell.GetEnemyHp() > 0)
                                    {
                                        Console.WriteLine("Вы нанесли :" + playerDamage + " Урона" + " И оставили ему :" + battleFreavell.GetEnemyHp() + " HP");
                                    }
                                    // Если HP противника меньше или равно 0!
                                    else if (battleFreavell.GetEnemyHp() <= 0)
                                    {
                                        Console.WriteLine("Вы нанесли :" + playerDamage + " Урона" + " И оставили ему :" + "0" + " HP");
                                        Console.WriteLine("Противник убит!!!");
                                        battleFreavell.RecordEnemyHpFreavellTwo();
                                        dropFreavell.DropFreavellTwo();
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
                            int playerDamageDealt = battleFreavell.GetEnemyHp() - 0;
                            //Запись урона в HP монстра
                            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                            string filePath = Path.Combine(directoryPath, "gamehpenemy.txt");
                            {
                                try
                                {
                                    string[] lines = File.ReadAllLines(filePath);
                                    lines[0] = playerDamageDealt.ToString();
                                    File.WriteAllLines(filePath, lines);
                                    // Если HP противника больше 0!   
                                    if (battleFreavell.GetEnemyHp() > 0)
                                    {
                                        Console.WriteLine("Вы нанесли :" + playerDamage + " Урона" + " И оставили ему :" + battleFreavell.GetEnemyHp() + " HP");
                                    }
                                    // Если HP противника меньше или равно 0!
                                    else if (battleFreavell.GetEnemyHp() <= 0)
                                    {
                                        Console.WriteLine("Вы нанесли :" + playerDamage + " Урона" + " И оставили ему :" + "0" + " HP");
                                        Console.WriteLine("Противник убит!!!");
                                        battleFreavell.RecordEnemyHpFreavellTwo();
                                        dropFreavell.DropFreavellTwo();
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
                Console.WriteLine("Для продолжения боя необходимо восполнить HP игрока");
                Console.WriteLine("либо пополнить запасы энергии");
            }
        }
        //######################################################################################################################################
        //---------------------------------АКАТА------ENEMY-----------THREE---------------------------------------------------------------
        public void AttackEnemyFreavellThree()
        {
            // Заглушка, если у игрока отсутствуют HP!!!!
            if (loadSavePlayer.GetPlayerHp() > 0 && loadSavePlayer.GetPlayerEnergy() >= 1)
            {
                // Вероятность уворота
                int evasionChance = enemyFreavell.dodgeEnemyFreavellThree;
                // Генерация случайного числа от 1 до 100
                int randomNumberDodge = rand.Next(1, 101);
                //Если не сработал крит!!!
                if (randomNumberDodge > evasionChance)
                {
                    // Генерация случайного числа от 1 до 10
                    int randomNumberCrit = rand.Next(1, 11);
                    if (randomNumberCrit <= 8)
                    {
                        // Урон по монстру
                        int playerDamage = loadSavePlayer.GetPlayerAttack() - enemyFreavell.defenseEnemyFreavellThree;
                        //Если в итоге защита выше чем сам урон монстра
                        if (playerDamage > 0)
                        {
                            int playerDamageDealt = battleFreavell.GetEnemyHp() - playerDamage;
                            //Запись урона в HP монстра
                            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                            string filePath = Path.Combine(directoryPath, "gamehpenemy.txt");
                            {
                                try
                                {
                                    string[] lines = File.ReadAllLines(filePath);
                                    lines[0] = playerDamageDealt.ToString();
                                    File.WriteAllLines(filePath, lines);
                                    // Если HP противника больше 0!   
                                    if (battleFreavell.GetEnemyHp() > 0)
                                    {
                                        Console.WriteLine("Вы нанесли :" + playerDamage + " Урона" + " И оставили ему :" + battleFreavell.GetEnemyHp() + " HP");
                                    }
                                    // Если HP противника меньше или равно 0!
                                    else if (battleFreavell.GetEnemyHp() <= 0)
                                    {
                                        Console.WriteLine("Вы нанесли :" + playerDamage + " Урона" + " И оставили ему :" + "0" + " HP");
                                        Console.WriteLine("Противник убит!!!");
                                        battleFreavell.RecordEnemyHpFreavellThree();
                                        dropFreavell.DropFreavellThree();
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
                            int playerDamageDealt = battleFreavell.GetEnemyHp() - 0;
                            //Запись урона в HP монстра
                            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                            string filePath = Path.Combine(directoryPath, "gamehpenemy.txt");
                            {
                                try
                                {
                                    string[] lines = File.ReadAllLines(filePath);
                                    lines[0] = playerDamageDealt.ToString();
                                    File.WriteAllLines(filePath, lines);
                                    // Если HP противника больше 0!   
                                    if (battleFreavell.GetEnemyHp() > 0)
                                    {
                                        Console.WriteLine("Вы нанесли :" + playerDamage + " Урона" + " И оставили ему :" + battleFreavell.GetEnemyHp() + " HP");
                                    }
                                    // Если HP противника меньше или равно 0!
                                    else if (battleFreavell.GetEnemyHp() <= 0)
                                    {
                                        Console.WriteLine("Вы нанесли :" + playerDamage + " Урона" + " И оставили ему :" + "0" + " HP");
                                        Console.WriteLine("Противник убит!!!");
                                        battleFreavell.RecordEnemyHpFreavellThree();
                                        dropFreavell.DropFreavellThree();
                                    };
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
                        // Урон по монстру
                        int playerDamage = (loadSavePlayer.GetPlayerAttack() + loadSavePlayer.GetPlayerCrit()) - enemyFreavell.defenseEnemyFreavellThree;
                        //Если в итоге защита выше чем сам урон игрока
                        if (playerDamage > 0)
                        {
                            int playerDamageDealt = battleFreavell.GetEnemyHp() - playerDamage;
                            //Запись урона в HP монстра
                            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                            string filePath = Path.Combine(directoryPath, "gamehpenemy.txt");
                            {
                                try
                                {
                                    string[] lines = File.ReadAllLines(filePath);
                                    lines[0] = playerDamageDealt.ToString();
                                    File.WriteAllLines(filePath, lines);
                                    // Если HP противника больше 0!   
                                    if (battleFreavell.GetEnemyHp() > 0)
                                    {
                                        Console.WriteLine("Вы нанесли :" + playerDamage + " Урона" + " И оставили ему :" + battleFreavell.GetEnemyHp() + " HP");
                                    }
                                    // Если HP противника меньше или равно 0!
                                    else if (battleFreavell.GetEnemyHp() <= 0)
                                    {
                                        Console.WriteLine("Вы нанесли :" + playerDamage + " Урона" + " И оставили ему :" + "0" + " HP");
                                        Console.WriteLine("Противник убит!!!");
                                        battleFreavell.RecordEnemyHpFreavellThree();
                                        dropFreavell.DropFreavellThree();
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
                            int playerDamageDealt = battleFreavell.GetEnemyHp() - 0;
                            //Запись урона в HP монстра
                            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                            string filePath = Path.Combine(directoryPath, "gamehpenemy.txt");
                            {
                                try
                                {
                                    string[] lines = File.ReadAllLines(filePath);
                                    lines[0] = playerDamageDealt.ToString();
                                    File.WriteAllLines(filePath, lines);
                                    // Если HP противника больше 0!   
                                    if (battleFreavell.GetEnemyHp() > 0)
                                    {
                                        Console.WriteLine("Вы нанесли :" + playerDamage + " Урона" + " И оставили ему :" + battleFreavell.GetEnemyHp() + " HP");
                                    }
                                    // Если HP противника меньше или равно 0!
                                    else if (battleFreavell.GetEnemyHp() <= 0)
                                    {
                                        Console.WriteLine("Вы нанесли :" + playerDamage + " Урона" + " И оставили ему :" + "0" + " HP");
                                        Console.WriteLine("Противник убит!!!");
                                        battleFreavell.RecordEnemyHpFreavellThree();
                                        dropFreavell.DropFreavellThree();
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
                Console.WriteLine("Для продолжения боя необходимо восполнить HP игрока");
                Console.WriteLine("либо пополнить запасы энергии");
            }
        }
        //######################################################################################################################################
        //---------------------------------АКАТА------ENEMY-----------FOUR---------------------------------------------------------------
        public void AttackEnemyFreavellFour()
        {
            // Заглушка, если у игрока отсутствуют HP!!!!
            if (loadSavePlayer.GetPlayerHp() > 0 && loadSavePlayer.GetPlayerEnergy() >= 1)
            {
                // Вероятность уворота
                int evasionChance = enemyFreavell.dodgeEnemyFreavellFour;
                // Генерация случайного числа от 1 до 100
                int randomNumberDodge = rand.Next(1, 101);
                //Если не сработал крит!!!
                if (randomNumberDodge > evasionChance)
                {
                    // Генерация случайного числа от 1 до 10
                    int randomNumberCrit = rand.Next(1, 11);
                    if (randomNumberCrit <= 8)
                    {
                        // Урон по монстру
                        int playerDamage = loadSavePlayer.GetPlayerAttack() - enemyFreavell.defenseEnemyFreavellFour;
                        //Если в итоге защита выше чем сам урон монстра
                        if (playerDamage > 0)
                        {
                            int playerDamageDealt = battleFreavell.GetEnemyHp() - playerDamage;
                            //Запись урона в HP монстра
                            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                            string filePath = Path.Combine(directoryPath, "gamehpenemy.txt");
                            {
                                try
                                {
                                    string[] lines = File.ReadAllLines(filePath);
                                    lines[0] = playerDamageDealt.ToString();
                                    File.WriteAllLines(filePath, lines);
                                    // Если HP противника больше 0!   
                                    if (battleFreavell.GetEnemyHp() > 0)
                                    {
                                        Console.WriteLine("Вы нанесли :" + playerDamage + " Урона" + " И оставили ему :" + battleFreavell.GetEnemyHp() + " HP");
                                    }
                                    // Если HP противника меньше или равно 0!
                                    else if (battleFreavell.GetEnemyHp() <= 0)
                                    {
                                        Console.WriteLine("Вы нанесли :" + playerDamage + " Урона" + " И оставили ему :" + "0" + " HP");
                                        Console.WriteLine("Противник убит!!!");
                                        battleFreavell.RecordEnemyHpFreavellFour();
                                        dropFreavell.DropFreavellFour();
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
                            int playerDamageDealt = battleFreavell.GetEnemyHp() - 0;
                            //Запись урона в HP монстра
                            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                            string filePath = Path.Combine(directoryPath, "gamehpenemy.txt");
                            {
                                try
                                {
                                    string[] lines = File.ReadAllLines(filePath);
                                    lines[0] = playerDamageDealt.ToString();
                                    File.WriteAllLines(filePath, lines);
                                    // Если HP противника больше 0!   
                                    if (battleFreavell.GetEnemyHp() > 0)
                                    {
                                        Console.WriteLine("Вы нанесли :" + playerDamage + " Урона" + " И оставили ему :" + battleFreavell.GetEnemyHp() + " HP");
                                    }
                                    // Если HP противника меньше или равно 0!
                                    else if (battleFreavell.GetEnemyHp() <= 0)
                                    {
                                        Console.WriteLine("Вы нанесли :" + playerDamage + " Урона" + " И оставили ему :" + "0" + " HP");
                                        Console.WriteLine("Противник убит!!!");
                                        battleFreavell.RecordEnemyHpFreavellFour();
                                        dropFreavell.DropFreavellFour();
                                    };
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
                        // Урон по монстру
                        int playerDamage = (loadSavePlayer.GetPlayerAttack() + loadSavePlayer.GetPlayerCrit()) - enemyFreavell.defenseEnemyFreavellFour;
                        //Если в итоге защита выше чем сам урон игрока
                        if (playerDamage > 0)
                        {
                            int playerDamageDealt = battleFreavell.GetEnemyHp() - playerDamage;
                            //Запись урона в HP монстра
                            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                            string filePath = Path.Combine(directoryPath, "gamehpenemy.txt");
                            {
                                try
                                {
                                    string[] lines = File.ReadAllLines(filePath);
                                    lines[0] = playerDamageDealt.ToString();
                                    File.WriteAllLines(filePath, lines);
                                    // Если HP противника больше 0!   
                                    if (battleFreavell.GetEnemyHp() > 0)
                                    {
                                        Console.WriteLine("Вы нанесли :" + playerDamage + " Урона" + " И оставили ему :" + battleFreavell.GetEnemyHp() + " HP");
                                    }
                                    // Если HP противника меньше или равно 0!
                                    else if (battleFreavell.GetEnemyHp() <= 0)
                                    {
                                        Console.WriteLine("Вы нанесли :" + playerDamage + " Урона" + " И оставили ему :" + "0" + " HP");
                                        Console.WriteLine("Противник убит!!!");
                                        battleFreavell.RecordEnemyHpFreavellFour();
                                        dropFreavell.DropFreavellFour();
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
                            int playerDamageDealt = battleFreavell.GetEnemyHp() - 0;
                            //Запись урона в HP монстра
                            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                            string filePath = Path.Combine(directoryPath, "gamehpenemy.txt");
                            {
                                try
                                {
                                    string[] lines = File.ReadAllLines(filePath);
                                    lines[0] = playerDamageDealt.ToString();
                                    File.WriteAllLines(filePath, lines);
                                    // Если HP противника больше 0!   
                                    if (battleFreavell.GetEnemyHp() > 0)
                                    {
                                        Console.WriteLine("Вы нанесли :" + playerDamage + " Урона" + " И оставили ему :" + battleFreavell.GetEnemyHp() + " HP");
                                    }
                                    // Если HP противника меньше или равно 0!
                                    else if (battleFreavell.GetEnemyHp() <= 0)
                                    {
                                        Console.WriteLine("Вы нанесли :" + playerDamage + " Урона" + " И оставили ему :" + "0" + " HP");
                                        Console.WriteLine("Противник убит!!!");
                                        battleFreavell.RecordEnemyHpFreavellFour();
                                        dropFreavell.DropFreavellFour();
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
                Console.WriteLine("Для продолжения боя необходимо восполнить HP игрока");
                Console.WriteLine("либо пополнить запасы энергии");
            }
        }
        //######################################################################################################################################
        //---------------------------------АКАТА------ENEMY-----------FIVE---------------------------------------------------------------
        public void AttackEnemyFreavellFive()
        {
            // Заглушка, если у игрока отсутствуют HP!!!!
            if (loadSavePlayer.GetPlayerHp() > 0 && loadSavePlayer.GetPlayerEnergy() >= 1)
            {
                // Вероятность уворота
                int evasionChance = enemyFreavell.dodgeEnemyFreavellFive;
                // Генерация случайного числа от 1 до 100
                int randomNumberDodge = rand.Next(1, 101);
                //Если не сработал крит!!!
                if (randomNumberDodge > evasionChance)
                {
                    // Генерация случайного числа от 1 до 10
                    int randomNumberCrit = rand.Next(1, 11);
                    if (randomNumberCrit <= 8)
                    {
                        // Урон по монстру
                        int playerDamage = loadSavePlayer.GetPlayerAttack() - enemyFreavell.defenseEnemyFreavellFive;
                        //Если в итоге защита выше чем сам урон монстра
                        if (playerDamage > 0)
                        {
                            int playerDamageDealt = battleFreavell.GetEnemyHp() - playerDamage;
                            //Запись урона в HP монстра
                            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                            string filePath = Path.Combine(directoryPath, "gamehpenemy.txt");
                            {
                                try
                                {
                                    string[] lines = File.ReadAllLines(filePath);
                                    lines[0] = playerDamageDealt.ToString();
                                    File.WriteAllLines(filePath, lines);
                                    // Если HP противника больше 0!   
                                    if (battleFreavell.GetEnemyHp() > 0)
                                    {
                                        Console.WriteLine("Вы нанесли :" + playerDamage + " Урона" + " И оставили ему :" + battleFreavell.GetEnemyHp() + " HP");
                                    }
                                    // Если HP противника меньше или равно 0!
                                    else if (battleFreavell.GetEnemyHp() <= 0)
                                    {
                                        Console.WriteLine("Вы нанесли :" + playerDamage + " Урона" + " И оставили ему :" + "0" + " HP");
                                        Console.WriteLine("Противник убит!!!");
                                        battleFreavell.RecordEnemyHpFreavellFive();
                                        dropFreavell.DropFreavellFive();
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
                            int playerDamageDealt = battleFreavell.GetEnemyHp() - 0;
                            //Запись урона в HP монстра
                            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                            string filePath = Path.Combine(directoryPath, "gamehpenemy.txt");
                            {
                                try
                                {
                                    string[] lines = File.ReadAllLines(filePath);
                                    lines[0] = playerDamageDealt.ToString();
                                    File.WriteAllLines(filePath, lines);
                                    // Если HP противника больше 0!   
                                    if (battleFreavell.GetEnemyHp() > 0)
                                    {
                                        Console.WriteLine("Вы нанесли :" + playerDamage + " Урона" + " И оставили ему :" + battleFreavell.GetEnemyHp() + " HP");
                                    }
                                    // Если HP противника меньше или равно 0!
                                    else if (battleFreavell.GetEnemyHp() <= 0)
                                    {
                                        Console.WriteLine("Вы нанесли :" + playerDamage + " Урона" + " И оставили ему :" + "0" + " HP");
                                        Console.WriteLine("Противник убит!!!");
                                        battleFreavell.RecordEnemyHpFreavellFive();
                                        dropFreavell.DropFreavellFive();
                                    };
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
                        // Урон по монстру
                        int playerDamage = (loadSavePlayer.GetPlayerAttack() + loadSavePlayer.GetPlayerCrit()) - enemyFreavell.defenseEnemyFreavellFive;
                        //Если в итоге защита выше чем сам урон игрока
                        if (playerDamage > 0)
                        {
                            int playerDamageDealt = battleFreavell.GetEnemyHp() - playerDamage;
                            //Запись урона в HP монстра
                            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                            string filePath = Path.Combine(directoryPath, "gamehpenemy.txt");
                            {
                                try
                                {
                                    string[] lines = File.ReadAllLines(filePath);
                                    lines[0] = playerDamageDealt.ToString();
                                    File.WriteAllLines(filePath, lines);
                                    // Если HP противника больше 0!   
                                    if (battleFreavell.GetEnemyHp() > 0)
                                    {
                                        Console.WriteLine("Вы нанесли :" + playerDamage + " Урона" + " И оставили ему :" + battleFreavell.GetEnemyHp() + " HP");
                                    }
                                    // Если HP противника меньше или равно 0!
                                    else if (battleFreavell.GetEnemyHp() <= 0)
                                    {
                                        Console.WriteLine("Вы нанесли :" + playerDamage + " Урона" + " И оставили ему :" + "0" + " HP");
                                        Console.WriteLine("Противник убит!!!");
                                        battleFreavell.RecordEnemyHpFreavellFive();
                                        dropFreavell.DropFreavellFive();
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
                            int playerDamageDealt = battleFreavell.GetEnemyHp() - 0;
                            //Запись урона в HP монстра
                            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                            string filePath = Path.Combine(directoryPath, "gamehpenemy.txt");
                            {
                                try
                                {
                                    string[] lines = File.ReadAllLines(filePath);
                                    lines[0] = playerDamageDealt.ToString();
                                    File.WriteAllLines(filePath, lines);
                                    // Если HP противника больше 0!   
                                    if (battleFreavell.GetEnemyHp() > 0)
                                    {
                                        Console.WriteLine("Вы нанесли :" + playerDamage + " Урона" + " И оставили ему :" + battleFreavell.GetEnemyHp() + " HP");
                                    }
                                    // Если HP противника меньше или равно 0!
                                    else if (battleFreavell.GetEnemyHp() <= 0)
                                    {
                                        Console.WriteLine("Вы нанесли :" + playerDamage + " Урона" + " И оставили ему :" + "0" + " HP");
                                        Console.WriteLine("Противник убит!!!");
                                        battleFreavell.RecordEnemyHpFreavellFive();
                                        dropFreavell.DropFreavellFive();
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
                Console.WriteLine("Для продолжения боя необходимо восполнить HP игрока");
                Console.WriteLine("либо пополнить запасы энергии");
            }
        }
        //######################################################################################################################################
        //---------------------------------АКАТА------ENEMY-----------BOSS---ONE------------------------------------------------------------
        public void AttackEnemyFreavellBossOne()
        {
            // Заглушка, если у игрока отсутствуют HP!!!!
            if (loadSavePlayer.GetPlayerHp() > 0 && loadSavePlayer.GetPlayerDungeonEnergy() >= 1)
            {
                // Вероятность уворота
                int evasionChance = enemyFreavell.dodgeEnemyFreavellBossOne;
                // Генерация случайного числа от 1 до 100
                int randomNumberDodge = rand.Next(1, 101);
                //Если не сработал крит!!!
                if (randomNumberDodge > evasionChance)
                {
                    // Генерация случайного числа от 1 до 10
                    int randomNumberCrit = rand.Next(1, 11);
                    if (randomNumberCrit <= 8)
                    {
                        // Урон по монстру
                        int playerDamage = loadSavePlayer.GetPlayerAttack() - enemyFreavell.defenseEnemyFreavellBossOne;
                        //Если в итоге защита выше чем сам урон монстра
                        if (playerDamage > 0)
                        {
                            int playerDamageDealt = battleFreavell.GetEnemyHp() - playerDamage;
                            //Запись урона в HP монстра
                            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                            string filePath = Path.Combine(directoryPath, "gamehpenemy.txt");
                            {
                                try
                                {
                                    string[] lines = File.ReadAllLines(filePath);
                                    lines[0] = playerDamageDealt.ToString();
                                    File.WriteAllLines(filePath, lines);
                                    // Если HP противника больше 0!   
                                    if (battleFreavell.GetEnemyHp() > 0)
                                    {
                                        Console.WriteLine("Вы нанесли :" + playerDamage + " Урона" + " И оставили ему :" + battleFreavell.GetEnemyHp() + " HP");
                                    }
                                    // Если HP противника меньше или равно 0!
                                    else if (battleFreavell.GetEnemyHp() <= 0)
                                    {
                                        Console.WriteLine("Вы нанесли :" + playerDamage + " Урона" + " И оставили ему :" + "0" + " HP");
                                        Console.WriteLine("Противник убит!!!");
                                        battleFreavell.RecordEnemyHpFreavellBossOne();
                                        dropFreavell.DropFreavellBossOne();
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
                            int playerDamageDealt = battleFreavell.GetEnemyHp() - 0;
                            //Запись урона в HP монстра
                            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                            string filePath = Path.Combine(directoryPath, "gamehpenemy.txt");
                            {
                                try
                                {
                                    string[] lines = File.ReadAllLines(filePath);
                                    lines[0] = playerDamageDealt.ToString();
                                    File.WriteAllLines(filePath, lines);
                                    // Если HP противника больше 0!   
                                    if (battleFreavell.GetEnemyHp() > 0)
                                    {
                                        Console.WriteLine("Вы нанесли :" + playerDamage + " Урона" + " И оставили ему :" + battleFreavell.GetEnemyHp() + " HP");
                                    }
                                    // Если HP противника меньше или равно 0!
                                    else if (battleFreavell.GetEnemyHp() <= 0)
                                    {
                                        Console.WriteLine("Вы нанесли :" + playerDamage + " Урона" + " И оставили ему :" + "0" + " HP");
                                        Console.WriteLine("Противник убит!!!");
                                        battleFreavell.RecordEnemyHpFreavellBossOne();
                                        dropFreavell.DropFreavellBossOne();
                                    };
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
                        // Урон по монстру
                        int playerDamage = (loadSavePlayer.GetPlayerAttack() + loadSavePlayer.GetPlayerCrit()) - enemyFreavell.defenseEnemyFreavellBossOne;
                        //Если в итоге защита выше чем сам урон игрока
                        if (playerDamage > 0)
                        {
                            int playerDamageDealt = battleFreavell.GetEnemyHp() - playerDamage;
                            //Запись урона в HP монстра
                            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                            string filePath = Path.Combine(directoryPath, "gamehpenemy.txt");
                            {
                                try
                                {
                                    string[] lines = File.ReadAllLines(filePath);
                                    lines[0] = playerDamageDealt.ToString();
                                    File.WriteAllLines(filePath, lines);
                                    // Если HP противника больше 0!   
                                    if (battleFreavell.GetEnemyHp() > 0)
                                    {
                                        Console.WriteLine("Вы нанесли :" + playerDamage + " Урона" + " И оставили ему :" + battleFreavell.GetEnemyHp() + " HP");
                                    }
                                    // Если HP противника меньше или равно 0!
                                    else if (battleFreavell.GetEnemyHp() <= 0)
                                    {
                                        Console.WriteLine("Вы нанесли :" + playerDamage + " Урона" + " И оставили ему :" + "0" + " HP");
                                        Console.WriteLine("Противник убит!!!");
                                        battleFreavell.RecordEnemyHpFreavellBossOne();
                                        dropFreavell.DropFreavellBossOne();
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
                            int playerDamageDealt = battleFreavell.GetEnemyHp() - 0;
                            //Запись урона в HP монстра
                            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                            string filePath = Path.Combine(directoryPath, "gamehpenemy.txt");
                            {
                                try
                                {
                                    string[] lines = File.ReadAllLines(filePath);
                                    lines[0] = playerDamageDealt.ToString();
                                    File.WriteAllLines(filePath, lines);
                                    // Если HP противника больше 0!   
                                    if (battleFreavell.GetEnemyHp() > 0)
                                    {
                                        Console.WriteLine("Вы нанесли :" + playerDamage + " Урона" + " И оставили ему :" + battleFreavell.GetEnemyHp() + " HP");
                                    }
                                    // Если HP противника меньше или равно 0!
                                    else if (battleFreavell.GetEnemyHp() <= 0)
                                    {
                                        Console.WriteLine("Вы нанесли :" + playerDamage + " Урона" + " И оставили ему :" + "0" + " HP");
                                        Console.WriteLine("Противник убит!!!");
                                        battleFreavell.RecordEnemyHpFreavellBossOne();
                                        dropFreavell.DropFreavellBossOne();
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
                Console.WriteLine("Для продолжения боя необходимо восполнить HP игрока");
                Console.WriteLine("либо пополнить запасы энергии подземелий");
            }
        }
        //######################################################################################################################################
        //---------------------------------АКАТА------ENEMY-----------BOSS---TWO------------------------------------------------------------
        public void AttackEnemyFreavellBossTwo()
        {
            // Заглушка, если у игрока отсутствуют HP!!!!
            if (loadSavePlayer.GetPlayerHp() > 0 && loadSavePlayer.GetPlayerDungeonEnergy() >= 1)
            {
                // Вероятность уворота
                int evasionChance = enemyFreavell.dodgeEnemyFreavellBossTwo;
                // Генерация случайного числа от 1 до 100
                int randomNumberDodge = rand.Next(1, 101);
                //Если не сработал крит!!!
                if (randomNumberDodge > evasionChance)
                {
                    // Генерация случайного числа от 1 до 10
                    int randomNumberCrit = rand.Next(1, 11);
                    if (randomNumberCrit <= 8)
                    {
                        // Урон по монстру
                        int playerDamage = loadSavePlayer.GetPlayerAttack() - enemyFreavell.defenseEnemyFreavellBossTwo;
                        //Если в итоге защита выше чем сам урон монстра
                        if (playerDamage > 0)
                        {
                            int playerDamageDealt = battleFreavell.GetEnemyHp() - playerDamage;
                            //Запись урона в HP монстра
                            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                            string filePath = Path.Combine(directoryPath, "gamehpenemy.txt");
                            {
                                try
                                {
                                    string[] lines = File.ReadAllLines(filePath);
                                    lines[0] = playerDamageDealt.ToString();
                                    File.WriteAllLines(filePath, lines);
                                    // Если HP противника больше 0!   
                                    if (battleFreavell.GetEnemyHp() > 0)
                                    {
                                        Console.WriteLine("Вы нанесли :" + playerDamage + " Урона" + " И оставили ему :" + battleFreavell.GetEnemyHp() + " HP");
                                    }
                                    // Если HP противника меньше или равно 0!
                                    else if (battleFreavell.GetEnemyHp() <= 0)
                                    {
                                        Console.WriteLine("Вы нанесли :" + playerDamage + " Урона" + " И оставили ему :" + "0" + " HP");
                                        Console.WriteLine("Противник убит!!!");
                                        battleFreavell.RecordEnemyHpFreavellBossTwo();
                                        dropFreavell.DropFreavellBossTwo();
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
                            int playerDamageDealt = battleFreavell.GetEnemyHp() - 0;
                            //Запись урона в HP монстра
                            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                            string filePath = Path.Combine(directoryPath, "gamehpenemy.txt");
                            {
                                try
                                {
                                    string[] lines = File.ReadAllLines(filePath);
                                    lines[0] = playerDamageDealt.ToString();
                                    File.WriteAllLines(filePath, lines);
                                    // Если HP противника больше 0!   
                                    if (battleFreavell.GetEnemyHp() > 0)
                                    {
                                        Console.WriteLine("Вы нанесли :" + playerDamage + " Урона" + " И оставили ему :" + battleFreavell.GetEnemyHp() + " HP");
                                    }
                                    // Если HP противника меньше или равно 0!
                                    else if (battleFreavell.GetEnemyHp() <= 0)
                                    {
                                        Console.WriteLine("Вы нанесли :" + playerDamage + " Урона" + " И оставили ему :" + "0" + " HP");
                                        Console.WriteLine("Противник убит!!!");
                                        battleFreavell.RecordEnemyHpFreavellBossTwo();
                                        dropFreavell.DropFreavellBossTwo();
                                    };
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
                        // Урон по монстру
                        int playerDamage = (loadSavePlayer.GetPlayerAttack() + loadSavePlayer.GetPlayerCrit()) - enemyFreavell.defenseEnemyFreavellBossTwo;
                        //Если в итоге защита выше чем сам урон игрока
                        if (playerDamage > 0)
                        {
                            int playerDamageDealt = battleFreavell.GetEnemyHp() - playerDamage;
                            //Запись урона в HP монстра
                            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                            string filePath = Path.Combine(directoryPath, "gamehpenemy.txt");
                            {
                                try
                                {
                                    string[] lines = File.ReadAllLines(filePath);
                                    lines[0] = playerDamageDealt.ToString();
                                    File.WriteAllLines(filePath, lines);
                                    // Если HP противника больше 0!   
                                    if (battleFreavell.GetEnemyHp() > 0)
                                    {
                                        Console.WriteLine("Вы нанесли :" + playerDamage + " Урона" + " И оставили ему :" + battleFreavell.GetEnemyHp() + " HP");
                                    }
                                    // Если HP противника меньше или равно 0!
                                    else if (battleFreavell.GetEnemyHp() <= 0)
                                    {
                                        Console.WriteLine("Вы нанесли :" + playerDamage + " Урона" + " И оставили ему :" + "0" + " HP");
                                        Console.WriteLine("Противник убит!!!");
                                        battleFreavell.RecordEnemyHpFreavellBossTwo();
                                        dropFreavell.DropFreavellBossTwo();
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
                            int playerDamageDealt = battleFreavell.GetEnemyHp() - 0;
                            //Запись урона в HP монстра
                            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                            string filePath = Path.Combine(directoryPath, "gamehpenemy.txt");
                            {
                                try
                                {
                                    string[] lines = File.ReadAllLines(filePath);
                                    lines[0] = playerDamageDealt.ToString();
                                    File.WriteAllLines(filePath, lines);
                                    // Если HP противника больше 0!   
                                    if (battleFreavell.GetEnemyHp() > 0)
                                    {
                                        Console.WriteLine("Вы нанесли :" + playerDamage + " Урона" + " И оставили ему :" + battleFreavell.GetEnemyHp() + " HP");
                                    }
                                    // Если HP противника меньше или равно 0!
                                    else if (battleFreavell.GetEnemyHp() <= 0)
                                    {
                                        Console.WriteLine("Вы нанесли :" + playerDamage + " Урона" + " И оставили ему :" + "0" + " HP");
                                        Console.WriteLine("Противник убит!!!");
                                        battleFreavell.RecordEnemyHpFreavellBossTwo();
                                        dropFreavell.DropFreavellBossTwo();
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
                Console.WriteLine("Для продолжения боя необходимо восполнить HP игрока");
                Console.WriteLine("либо пополнить запасы энергии подземелий");
            }
        }
        //######################################################################################################################################
        //---------------------------------АКАТА------ENEMY-----------BOSS---THREE------------------------------------------------------------
        public void AttackEnemyFreavellBossThree()
        {
            // Заглушка, если у игрока отсутствуют HP или энергия!!!!
            if (loadSavePlayer.GetPlayerHp() > 0 && loadSavePlayer.GetPlayerDungeonEnergy() >= 1)
            {
                // Вероятность уворота
                int evasionChance = enemyFreavell.dodgeEnemyFreavellBossThree;
                // Генерация случайного числа от 1 до 100
                int randomNumberDodge = rand.Next(1, 101);
                //Если не сработал крит!!!
                if (randomNumberDodge > evasionChance)
                {
                    // Генерация случайного числа от 1 до 10
                    int randomNumberCrit = rand.Next(1, 11);
                    if (randomNumberCrit <= 8)
                    {
                        // Урон по монстру
                        int playerDamage = loadSavePlayer.GetPlayerAttack() - enemyFreavell.defenseEnemyFreavellBossThree;
                        //Если в итоге защита выше чем сам урон монстра
                        if (playerDamage > 0)
                        {
                            int playerDamageDealt = battleFreavell.GetEnemyHp() - playerDamage;
                            //Запись урона в HP монстра
                            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                            string filePath = Path.Combine(directoryPath, "gamehpenemy.txt");
                            {
                                try
                                {
                                    string[] lines = File.ReadAllLines(filePath);
                                    lines[0] = playerDamageDealt.ToString();
                                    File.WriteAllLines(filePath, lines);
                                    // Если HP противника больше 0!   
                                    if (battleFreavell.GetEnemyHp() > 0)
                                    {
                                        Console.WriteLine("Вы нанесли :" + playerDamage + " Урона" + " И оставили ему :" + battleFreavell.GetEnemyHp() + " HP");
                                    }
                                    // Если HP противника меньше или равно 0!
                                    else if (battleFreavell.GetEnemyHp() <= 0)
                                    {
                                        Console.WriteLine("Вы нанесли :" + playerDamage + " Урона" + " И оставили ему :" + "0" + " HP");
                                        Console.WriteLine("Противник убит!!!");
                                        battleFreavell.RecordEnemyHpFreavellBossThree();
                                        dropFreavell.DropFreavellBossThree();
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
                            int playerDamageDealt = battleFreavell.GetEnemyHp() - 0;
                            //Запись урона в HP монстра
                            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                            string filePath = Path.Combine(directoryPath, "gamehpenemy.txt");
                            {
                                try
                                {
                                    string[] lines = File.ReadAllLines(filePath);
                                    lines[0] = playerDamageDealt.ToString();
                                    File.WriteAllLines(filePath, lines);
                                    // Если HP противника больше 0!   
                                    if (battleFreavell.GetEnemyHp() > 0)
                                    {
                                        Console.WriteLine("Вы нанесли :" + playerDamage + " Урона" + " И оставили ему :" + battleFreavell.GetEnemyHp() + " HP");
                                    }
                                    // Если HP противника меньше или равно 0!
                                    else if (battleFreavell.GetEnemyHp() <= 0)
                                    {
                                        Console.WriteLine("Вы нанесли :" + playerDamage + " Урона" + " И оставили ему :" + "0" + " HP");
                                        Console.WriteLine("Противник убит!!!");
                                        battleFreavell.RecordEnemyHpFreavellBossThree();
                                        dropFreavell.DropFreavellBossThree();
                                    };
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
                        // Урон по монстру
                        int playerDamage = (loadSavePlayer.GetPlayerAttack() + loadSavePlayer.GetPlayerCrit()) - enemyFreavell.defenseEnemyFreavellBossThree;
                        //Если в итоге защита выше чем сам урон игрока
                        if (playerDamage > 0)
                        {
                            int playerDamageDealt = battleFreavell.GetEnemyHp() - playerDamage;
                            //Запись урона в HP монстра
                            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                            string filePath = Path.Combine(directoryPath, "gamehpenemy.txt");
                            {
                                try
                                {
                                    string[] lines = File.ReadAllLines(filePath);
                                    lines[0] = playerDamageDealt.ToString();
                                    File.WriteAllLines(filePath, lines);
                                    // Если HP противника больше 0!   
                                    if (battleFreavell.GetEnemyHp() > 0)
                                    {
                                        Console.WriteLine("Вы нанесли :" + playerDamage + " Урона" + " И оставили ему :" + battleFreavell.GetEnemyHp() + " HP");
                                    }
                                    // Если HP противника меньше или равно 0!
                                    else if (battleFreavell.GetEnemyHp() <= 0)
                                    {
                                        Console.WriteLine("Вы нанесли :" + playerDamage + " Урона" + " И оставили ему :" + "0" + " HP");
                                        Console.WriteLine("Противник убит!!!");
                                        battleFreavell.RecordEnemyHpFreavellBossThree();
                                        dropFreavell.DropFreavellBossThree();
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
                            int playerDamageDealt = battleFreavell.GetEnemyHp() - 0;
                            //Запись урона в HP монстра
                            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                            string filePath = Path.Combine(directoryPath, "gamehpenemy.txt");
                            {
                                try
                                {
                                    string[] lines = File.ReadAllLines(filePath);
                                    lines[0] = playerDamageDealt.ToString();
                                    File.WriteAllLines(filePath, lines);
                                    // Если HP противника больше 0!   
                                    if (battleFreavell.GetEnemyHp() > 0)
                                    {
                                        Console.WriteLine("Вы нанесли :" + playerDamage + " Урона" + " И оставили ему :" + battleFreavell.GetEnemyHp() + " HP");
                                    }
                                    // Если HP противника меньше или равно 0!
                                    else if (battleFreavell.GetEnemyHp() <= 0)
                                    {
                                        Console.WriteLine("Вы нанесли :" + playerDamage + " Урона" + " И оставили ему :" + "0" + " HP");
                                        Console.WriteLine("Противник убит!!!");
                                        battleFreavell.RecordEnemyHpFreavellFive();
                                        dropFreavell.DropFreavellFive();
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
                Console.WriteLine("Для продолжения боя необходимо восполнить HP игрока");
                Console.WriteLine("либо пополнить запасы энергии подземелий");
            }
        }
    }
}
