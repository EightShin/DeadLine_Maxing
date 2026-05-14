using System.IO;
using System.Windows.Forms;

namespace DeadLine_Maxing.Services
{
    internal class NoteService
    {
        private static string notePath =
    Path.Combine(
        Application.StartupPath,
        "notes.txt");

        public static void SaveNotes(string text)
        {
            try
            {
                File.WriteAllText(
                    notePath,
                    text);
            }
            catch
            {

            }
        }

        public static string LoadNotes()
        {
            try
            {
                if (!File.Exists(notePath))
                {
                    return "";
                }

                return File.ReadAllText(notePath);
            }
            catch
            {
                return "";
            }
        }
    }
}