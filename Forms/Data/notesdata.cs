using System;
using System.IO;
using System.Text.Json;

namespace StudyQuest
{
    public class NotesData
    {
        public string Content { get; set; } = "";
        public DateTime LastSaved { get; set; } = DateTime.Now;
    }

    public static class NotesDatabase
    {
        private static readonly string FilePath = Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory, "notes.json");

        public static NotesData Load()
        {
            try
            {
                if (File.Exists(FilePath))
                {
                    string json = File.ReadAllText(FilePath);
                    return JsonSerializer.Deserialize<NotesData>(json) ?? new NotesData();
                }
            }
            catch { }
            return new NotesData();
        }

        public static void Save(string content)
        {
            try
            {
                var data = new NotesData
                {
                    Content = content,
                    LastSaved = DateTime.Now
                };
                var options = new JsonSerializerOptions { WriteIndented = true };
                File.WriteAllText(FilePath, JsonSerializer.Serialize(data, options));
            }
            catch { }
        }
    }
}