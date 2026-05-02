using System;
using System.IO;
using System.Text.Json;

namespace StudyQuest
{
    public class StreakData
    {
        public int StreakDays { get; set; } = 0;
        public DateTime LastLoginDate { get; set; } = DateTime.MinValue;
    }

    public static class StreakDatabase
    {
        private static readonly string FilePath =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "streak.json");

        // =====================================================================
        // UPDATE STREAK — call on app load
        // =====================================================================
        public static StreakData UpdateStreak()
        {
            StreakData data = Load();

            DateTime today = DateTime.Today;

            if (data.LastLoginDate == DateTime.MinValue)
            {
                // ── First time ever ───────────────────────────────────────────
                data.StreakDays = 1;
                data.LastLoginDate = today;
            }
            else
            {
                int daysSince = (today - data.LastLoginDate.Date).Days;

                if (daysSince == 0)
                {
                    // ── Same day login — no change ────────────────────────────
                }
                else if (daysSince == 1)
                {
                    // ── Consecutive day — increment streak ────────────────────
                    data.StreakDays++;
                    data.LastLoginDate = today;
                }
                else
                {
                    // ── Missed a day — reset streak ───────────────────────────
                    data.StreakDays = 1;
                    data.LastLoginDate = today;
                }
            }

            Save(data);
            return data;
        }

        // =====================================================================
        // GET CURRENT — just reads without updating
        // =====================================================================
        public static StreakData GetCurrent()
        {
            return Load();
        }

        // =====================================================================
        // ON TASK COMPLETED — call when a task is marked complete
        // =====================================================================
        public static void OnTaskCompleted()
        {
            StreakData data = Load();

            DateTime today = DateTime.Today;

            if (data.LastLoginDate.Date == today)
            {
                // Already updated today — no change needed
                return;
            }

            int daysSince = (today - data.LastLoginDate.Date).Days;

            if (data.LastLoginDate == DateTime.MinValue || daysSince > 1)
                data.StreakDays = 1;       // First time or streak broken
            else if (daysSince == 1)
                data.StreakDays++;         // Consecutive day

            data.LastLoginDate = today;
            Save(data);
        }

        // =====================================================================
        // LOAD from JSON
        // =====================================================================
        private static StreakData Load()
        {
            try
            {
                if (File.Exists(FilePath))
                {
                    string json = File.ReadAllText(FilePath);
                    return JsonSerializer.Deserialize<StreakData>(json) ?? new StreakData();
                }
            }
            catch { }

            return new StreakData();
        }

        // =====================================================================
        // SAVE to JSON
        // =====================================================================
        private static void Save(StreakData data)
        {
            try
            {
                string json = JsonSerializer.Serialize(data, new JsonSerializerOptions
                {
                    WriteIndented = true
                });
                File.WriteAllText(FilePath, json);
            }
            catch { }
        }
    }
}