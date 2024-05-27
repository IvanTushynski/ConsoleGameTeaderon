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
        //-------------------------------------------------------------------------------------------------------
        LoadSaveItems loadSaveItems = new LoadSaveItems();
        LoadSavePlayer loadSavePlayer = new LoadSavePlayer();
        EnemyFreavell enemyFreavell = new EnemyFreavell();

        public void BerserkSkillOne()
        {

            int berserkDmg = loadSavePlayer.GetPlayerAttack() * 2;
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory/*, "bin", "Debug", "net8.0-windows"*/);
            string filePath = Path.Combine(directoryPath, "gamehpenemy.txt");
            int hpEnemyRemaining = GetEnemyHp() - berserkDmg;
            {
                try
                {
                    string[] lines = File.ReadAllLines(filePath);
                    lines[0] = hpEnemyRemaining.ToString();
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
