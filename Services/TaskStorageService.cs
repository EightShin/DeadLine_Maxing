using DeadLine_Maxing.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace DeadLine_Maxing.Services
{
    internal class TaskStorageService
    {
        private static string filePath =
    Path.Combine(
        Application.StartupPath,
        "tasks.json");

        public static void SaveTasks(List<TaskItem> tasks)
        {
            try
            {
                string json =
                    JsonConvert.SerializeObject(
                        tasks,
                        Formatting.Indented);

                File.WriteAllText(
                    filePath,
                    json);
            }
            catch
            {
                MessageBox.Show(
                    "Failed to save tasks.");
            }
        }

        public static List<TaskItem> LoadTasks()
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    return new List<TaskItem>();
                }

                string json =
                    File.ReadAllText(filePath);

                return JsonConvert.DeserializeObject
                    <List<TaskItem>>(json)
                    ?? new List<TaskItem>();
            }
            catch
            {
                MessageBox.Show(
                    "Failed to load tasks.");

                return new List<TaskItem>();
            }
        }
    }
}