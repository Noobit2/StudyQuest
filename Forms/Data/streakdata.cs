using System;
using System.IO;
using System.Text.Json;

namespace StudyQuest
{
    public class StreakData
    {
        public int StreakDays { get; set; } = 0;
        public string LastStreakDate { get; set; } = "2000-01-01";
    }

    public static class StreakDatabase
    {
        private static readonly string FilePath = Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory, "streak.json"
        );

        public static StreakData Load()
        {
            try
            {
                if (!File.Exists(FilePath))
                    return new StreakData();

                string json = File.ReadAllText(FilePath);
                return JsonSerializer.Deserialize<StreakData>(json) ?? new StreakData();
            }
            catch
            {
                return new StreakData();
            }
        }

        public static void Save(StreakData data)
        {
            try
            {
                var options = new JsonSerializerOptions { WriteIndented = true };
                string json = JsonSerializer.Serialize(data, options);
                File.WriteAllText(FilePath, json);
            }
            catch { }
        }

        public static StreakData OnTaskCompleted()
        {
            StreakData streak = Load();

            DateTime today = DateTime.Today;
            DateTime lastStreak = DateTime.Parse(streak.LastStreakDate).Date;
            int daysSince = (today - lastStreak).Days;

            if (daysSince == 0)
            {
                return streak;
            }
            else if (daysSince == 1)
            {
                streak.StreakDays++;
            }
            else
            {
                streak.StreakDays = 1;
            }

            streak.LastStreakDate = today.ToString("yyyy-MM-dd");
            Save(streak);

            return streak;
        }

        public static StreakData GetCurrent()
        {
            return Load();
        }

        public static void Reset()
        {
            try
            {
                if (File.Exists(FilePath))
                    File.Delete(FilePath);
            }
            catch { }
        }
    }
}