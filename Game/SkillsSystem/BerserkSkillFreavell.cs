using Game.BattleSystem;
using Game.DropSystem;
using Game.Enemies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.SkillsSystem
{
    internal class BerserkSkillFreavell
    {
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

        LoadSavePlayer loadSavePlayer = new LoadSavePlayer();
        BattleMonsterFreavell battleFreavell = new BattleMonsterFreavell();
        DropFreavell dropFreavell = new DropFreavell();

        //----------------------------------------------Freavell--One-------------------------------------------------------
        public void BerserkSkillFreavellOne()
        {
            int setPlayerMpMinus = loadSavePlayer.GetPlayerLevel() * 2;

            // Заглушка, если у игрока отсутствуют HP или энергия или мана!!!!
            if (loadSavePlayer.GetPlayerHp() > 0 && loadSavePlayer.GetPlayerEnergy() >= 1 && loadSavePlayer.GetPlayerMp() >= setPlayerMpMinus)
            {
                        // Урон по монстру
                        int playerDamage = loadSavePlayer.GetPlayerAttack() * 2;
                        //Если в итоге защита выше чем сам урон монстра
                        if (playerDamage > 0)
                        {
                            int playerDamageDealt = GetEnemyHp() - playerDamage;
                            //Запись урона в HP монстра
                            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                            string filePath = Path.Combine(directoryPath, "gamehpenemy.txt");
                            UsePlayerMpOnSkill();
                    {
                                try
                                {
                                    string[] lines = File.ReadAllLines(filePath);
                                    lines[0] = playerDamageDealt.ToString();
                                    File.WriteAllLines(filePath, lines);
                                    // Если HP противника больше 0!   
                                    if (GetEnemyHp() > 0)
                                    {
                                        Console.WriteLine("Вы нанесли :" + playerDamage + " Урона" + " И оставили ему :" + battleFreavell.GetEnemyHp() + " HP");
                                    }
                                    // Если HP противника меньше или равно 0!
                                    else if (GetEnemyHp() <= 0)
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
                            string directoryPathTwo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                            string filePathTwo = Path.Combine(directoryPathTwo, "gamehpenemy.txt");
                            UsePlayerMpOnSkill();
                            {
                                try
                                {
                                    string[] linesTwo = File.ReadAllLines(filePathTwo);
                                    linesTwo[0] = playerDamageDealt.ToString();
                                    File.WriteAllLines(filePathTwo, linesTwo);
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
                else
                {
                    Console.WriteLine("Для продолжения боя необходимо восполнить HP игрока");
                    Console.WriteLine("либо пополнить запасы энергии и маны");
                }
            }
        //----------------------------------------------Freavell--Two-------------------------------------------------------
        public void BerserkSkillFreavellTwo()
        {
            int setPlayerMpMinus = loadSavePlayer.GetPlayerLevel() * 2;

            // Заглушка, если у игрока отсутствуют HP или энергия или мана!!!!
            if (loadSavePlayer.GetPlayerHp() > 0 && loadSavePlayer.GetPlayerEnergy() >= 1 && loadSavePlayer.GetPlayerMp() >= setPlayerMpMinus)
            {
                // Урон по монстру
                int playerDamage = loadSavePlayer.GetPlayerAttack() * 2;
                //Если в итоге защита выше чем сам урон монстра
                if (playerDamage > 0)
                {
                    int playerDamageDealt = GetEnemyHp() - playerDamage;
                    //Запись урона в HP монстра
                    string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePath = Path.Combine(directoryPath, "gamehpenemy.txt");
                    UsePlayerMpOnSkill();
                    {
                        try
                        {
                            string[] lines = File.ReadAllLines(filePath);
                            lines[0] = playerDamageDealt.ToString();
                            File.WriteAllLines(filePath, lines);
                            // Если HP противника больше 0!   
                            if (GetEnemyHp() > 0)
                            {
                                Console.WriteLine("Вы нанесли :" + playerDamage + " Урона" + " И оставили ему :" + battleFreavell.GetEnemyHp() + " HP");
                            }
                            // Если HP противника меньше или равно 0!
                            else if (GetEnemyHp() <= 0)
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
                    string directoryPathTwo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathTwo = Path.Combine(directoryPathTwo, "gamehpenemy.txt");
                    UsePlayerMpOnSkill();
                    {
                        try
                        {
                            string[] linesTwo = File.ReadAllLines(filePathTwo);
                            linesTwo[0] = playerDamageDealt.ToString();
                            File.WriteAllLines(filePathTwo, linesTwo);
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
            else
            {
                Console.WriteLine("Для продолжения боя необходимо восполнить HP игрока");
                Console.WriteLine("либо пополнить запасы энергии и маны");
            }
        }

        //----------------------------------------------Freavell--Three-------------------------------------------------------
        public void BerserkSkillFreavellThree()
        {
            int setPlayerMpMinus = loadSavePlayer.GetPlayerLevel() * 2;

            // Заглушка, если у игрока отсутствуют HP или энергия или мана!!!!
            if (loadSavePlayer.GetPlayerHp() > 0 && loadSavePlayer.GetPlayerEnergy() >= 1 && loadSavePlayer.GetPlayerMp() >= setPlayerMpMinus)
            {
                // Урон по монстру
                int playerDamage = loadSavePlayer.GetPlayerAttack() * 2;
                //Если в итоге защита выше чем сам урон монстра
                if (playerDamage > 0)
                {
                    int playerDamageDealt = GetEnemyHp() - playerDamage;
                    //Запись урона в HP монстра
                    string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePath = Path.Combine(directoryPath, "gamehpenemy.txt");
                    UsePlayerMpOnSkill();
                    {
                        try
                        {
                            string[] lines = File.ReadAllLines(filePath);
                            lines[0] = playerDamageDealt.ToString();
                            File.WriteAllLines(filePath, lines);
                            // Если HP противника больше 0!   
                            if (GetEnemyHp() > 0)
                            {
                                Console.WriteLine("Вы нанесли :" + playerDamage + " Урона" + " И оставили ему :" + battleFreavell.GetEnemyHp() + " HP");
                            }
                            // Если HP противника меньше или равно 0!
                            else if (GetEnemyHp() <= 0)
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
                    string directoryPathTwo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathTwo = Path.Combine(directoryPathTwo, "gamehpenemy.txt");
                    UsePlayerMpOnSkill();
                    {
                        try
                        {
                            string[] linesTwo = File.ReadAllLines(filePathTwo);
                            linesTwo[0] = playerDamageDealt.ToString();
                            File.WriteAllLines(filePathTwo, linesTwo);
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
            else
            {
                Console.WriteLine("Для продолжения боя необходимо восполнить HP игрока");
                Console.WriteLine("либо пополнить запасы энергии и маны");
            }
        }
        //----------------------------------------------Freavell--Four-------------------------------------------------------
        public void BerserkSkillFreavellFour()
        {
            int setPlayerMpMinus = loadSavePlayer.GetPlayerLevel() * 2;

            // Заглушка, если у игрока отсутствуют HP или энергия или мана!!!!
            if (loadSavePlayer.GetPlayerHp() > 0 && loadSavePlayer.GetPlayerEnergy() >= 1 && loadSavePlayer.GetPlayerMp() >= setPlayerMpMinus)
            {
                // Урон по монстру
                int playerDamage = loadSavePlayer.GetPlayerAttack() * 2;
                //Если в итоге защита выше чем сам урон монстра
                if (playerDamage > 0)
                {
                    int playerDamageDealt = GetEnemyHp() - playerDamage;
                    //Запись урона в HP монстра
                    string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePath = Path.Combine(directoryPath, "gamehpenemy.txt");
                    UsePlayerMpOnSkill();
                    {
                        try
                        {
                            string[] lines = File.ReadAllLines(filePath);
                            lines[0] = playerDamageDealt.ToString();
                            File.WriteAllLines(filePath, lines);
                            // Если HP противника больше 0!   
                            if (GetEnemyHp() > 0)
                            {
                                Console.WriteLine("Вы нанесли :" + playerDamage + " Урона" + " И оставили ему :" + battleFreavell.GetEnemyHp() + " HP");
                            }
                            // Если HP противника меньше или равно 0!
                            else if (GetEnemyHp() <= 0)
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
                    string directoryPathTwo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathTwo = Path.Combine(directoryPathTwo, "gamehpenemy.txt");
                    UsePlayerMpOnSkill();
                    {
                        try
                        {
                            string[] linesTwo = File.ReadAllLines(filePathTwo);
                            linesTwo[0] = playerDamageDealt.ToString();
                            File.WriteAllLines(filePathTwo, linesTwo);
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
            else
            {
                Console.WriteLine("Для продолжения боя необходимо восполнить HP игрока");
                Console.WriteLine("либо пополнить запасы энергии и маны");
            }
        }

        //----------------------------------------------Freavell--Five-------------------------------------------------------
        public void BerserkSkillFreavellFive()
        {
            int setPlayerMpMinus = loadSavePlayer.GetPlayerLevel() * 2;

            // Заглушка, если у игрока отсутствуют HP или энергия или мана!!!!
            if (loadSavePlayer.GetPlayerHp() > 0 && loadSavePlayer.GetPlayerEnergy() >= 1 && loadSavePlayer.GetPlayerMp() >= setPlayerMpMinus)
            {
                // Урон по монстру
                int playerDamage = loadSavePlayer.GetPlayerAttack() * 2;
                //Если в итоге защита выше чем сам урон монстра
                if (playerDamage > 0)
                {
                    int playerDamageDealt = GetEnemyHp() - playerDamage;
                    //Запись урона в HP монстра
                    string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePath = Path.Combine(directoryPath, "gamehpenemy.txt");
                    UsePlayerMpOnSkill();
                    {
                        try
                        {
                            string[] lines = File.ReadAllLines(filePath);
                            lines[0] = playerDamageDealt.ToString();
                            File.WriteAllLines(filePath, lines);
                            // Если HP противника больше 0!   
                            if (GetEnemyHp() > 0)
                            {
                                Console.WriteLine("Вы нанесли :" + playerDamage + " Урона" + " И оставили ему :" + battleFreavell.GetEnemyHp() + " HP");
                            }
                            // Если HP противника меньше или равно 0!
                            else if (GetEnemyHp() <= 0)
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
                    string directoryPathTwo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathTwo = Path.Combine(directoryPathTwo, "gamehpenemy.txt");
                    UsePlayerMpOnSkill();
                    {
                        try
                        {
                            string[] linesTwo = File.ReadAllLines(filePathTwo);
                            linesTwo[0] = playerDamageDealt.ToString();
                            File.WriteAllLines(filePathTwo, linesTwo);
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
            else
            {
                Console.WriteLine("Для продолжения боя необходимо восполнить HP игрока");
                Console.WriteLine("либо пополнить запасы энергии и маны");
            }
        }

        //----------------------------------------------Freavell--BossOne-------------------------------------------------------
        public void BerserkSkillFreavellBossOne()
        {
            int setPlayerMpMinus = loadSavePlayer.GetPlayerLevel() * 2;

            // Заглушка, если у игрока отсутствуют HP или энергия или мана!!!!
            if (loadSavePlayer.GetPlayerHp() > 0 && loadSavePlayer.GetPlayerEnergy() >= 1 && loadSavePlayer.GetPlayerMp() >= setPlayerMpMinus)
            {
                // Урон по монстру
                int playerDamage = loadSavePlayer.GetPlayerAttack() * 2;
                //Если в итоге защита выше чем сам урон монстра
                if (playerDamage > 0)
                {
                    int playerDamageDealt = GetEnemyHp() - playerDamage;
                    //Запись урона в HP монстра
                    string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePath = Path.Combine(directoryPath, "gamehpenemy.txt");
                    UsePlayerMpOnSkill();
                    {
                        try
                        {
                            string[] lines = File.ReadAllLines(filePath);
                            lines[0] = playerDamageDealt.ToString();
                            File.WriteAllLines(filePath, lines);
                            // Если HP противника больше 0!   
                            if (GetEnemyHp() > 0)
                            {
                                Console.WriteLine("Вы нанесли :" + playerDamage + " Урона" + " И оставили ему :" + battleFreavell.GetEnemyHp() + " HP");
                            }
                            // Если HP противника меньше или равно 0!
                            else if (GetEnemyHp() <= 0)
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
                    string directoryPathTwo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathTwo = Path.Combine(directoryPathTwo, "gamehpenemy.txt");
                    UsePlayerMpOnSkill();
                    {
                        try
                        {
                            string[] linesTwo = File.ReadAllLines(filePathTwo);
                            linesTwo[0] = playerDamageDealt.ToString();
                            File.WriteAllLines(filePathTwo, linesTwo);
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
            else
            {
                Console.WriteLine("Для продолжения боя необходимо восполнить HP игрока");
                Console.WriteLine("либо пополнить запасы энергии и маны");
            }
        }

        //----------------------------------------------Freavell--BossTwo-------------------------------------------------------
        public void BerserkSkillFreavellBossTwo()
        {
            int setPlayerMpMinus = loadSavePlayer.GetPlayerLevel() * 2;

            // Заглушка, если у игрока отсутствуют HP или энергия или мана!!!!
            if (loadSavePlayer.GetPlayerHp() > 0 && loadSavePlayer.GetPlayerEnergy() >= 1 && loadSavePlayer.GetPlayerMp() >= setPlayerMpMinus)
            {
                // Урон по монстру
                int playerDamage = loadSavePlayer.GetPlayerAttack() * 2;
                //Если в итоге защита выше чем сам урон монстра
                if (playerDamage > 0)
                {
                    int playerDamageDealt = GetEnemyHp() - playerDamage;
                    //Запись урона в HP монстра
                    string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePath = Path.Combine(directoryPath, "gamehpenemy.txt");
                    UsePlayerMpOnSkill();
                    {
                        try
                        {
                            string[] lines = File.ReadAllLines(filePath);
                            lines[0] = playerDamageDealt.ToString();
                            File.WriteAllLines(filePath, lines);
                            // Если HP противника больше 0!   
                            if (GetEnemyHp() > 0)
                            {
                                Console.WriteLine("Вы нанесли :" + playerDamage + " Урона" + " И оставили ему :" + battleFreavell.GetEnemyHp() + " HP");
                            }
                            // Если HP противника меньше или равно 0!
                            else if (GetEnemyHp() <= 0)
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
                    string directoryPathTwo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathTwo = Path.Combine(directoryPathTwo, "gamehpenemy.txt");
                    UsePlayerMpOnSkill();
                    {
                        try
                        {
                            string[] linesTwo = File.ReadAllLines(filePathTwo);
                            linesTwo[0] = playerDamageDealt.ToString();
                            File.WriteAllLines(filePathTwo, linesTwo);
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
            else
            {
                Console.WriteLine("Для продолжения боя необходимо восполнить HP игрока");
                Console.WriteLine("либо пополнить запасы энергии и маны");
            }
        }

        //----------------------------------------------Freavell--BossThree-------------------------------------------------------
        public void BerserkSkillFreavellBossThree()
        {
            int setPlayerMpMinus = loadSavePlayer.GetPlayerLevel() * 2;

            // Заглушка, если у игрока отсутствуют HP или энергия или мана!!!!
            if (loadSavePlayer.GetPlayerHp() > 0 && loadSavePlayer.GetPlayerEnergy() >= 1 && loadSavePlayer.GetPlayerMp() >= setPlayerMpMinus)
            {
                // Урон по монстру
                int playerDamage = loadSavePlayer.GetPlayerAttack() * 2;
                //Если в итоге защита выше чем сам урон монстра
                if (playerDamage > 0)
                {
                    int playerDamageDealt = GetEnemyHp() - playerDamage;
                    //Запись урона в HP монстра
                    string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePath = Path.Combine(directoryPath, "gamehpenemy.txt");
                    UsePlayerMpOnSkill();
                    {
                        try
                        {
                            string[] lines = File.ReadAllLines(filePath);
                            lines[0] = playerDamageDealt.ToString();
                            File.WriteAllLines(filePath, lines);
                            // Если HP противника больше 0!   
                            if (GetEnemyHp() > 0)
                            {
                                Console.WriteLine("Вы нанесли :" + playerDamage + " Урона" + " И оставили ему :" + battleFreavell.GetEnemyHp() + " HP");
                            }
                            // Если HP противника меньше или равно 0!
                            else if (GetEnemyHp() <= 0)
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
                    string directoryPathTwo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
                    string filePathTwo = Path.Combine(directoryPathTwo, "gamehpenemy.txt");
                    UsePlayerMpOnSkill();
                    {
                        try
                        {
                            string[] linesTwo = File.ReadAllLines(filePathTwo);
                            linesTwo[0] = playerDamageDealt.ToString();
                            File.WriteAllLines(filePathTwo, linesTwo);
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
            else
            {
                Console.WriteLine("Для продолжения боя необходимо восполнить HP игрока");
                Console.WriteLine("либо пополнить запасы энергии и маны");
            }
        }

        //################################################################################################################
        //-----------------------------Механика вычета маны---------------------------------------------
        public void UsePlayerMpOnSkill()
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gameplayerdata.txt");
            //Вычет маны лвл * 2
            int setPlayerMp = loadSavePlayer.GetPlayerMp() - (loadSavePlayer.GetPlayerLevel() * 2);
            {
                try
                {
                    string[] lines = File.ReadAllLines(filePath);
                    lines[8] = setPlayerMp.ToString();
                    File.WriteAllLines(filePath, lines);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при перезаписи строки в файле: {ex.Message}");
                }
            }

        }
    }

    }
