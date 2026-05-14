using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DeadLine_Maxing.Services
{
    internal class FileAttachmentService
    {
        public static List<string> PickFiles()
        {
            List<string> files = new List<string>();

            OpenFileDialog ofd = new OpenFileDialog
            {
                Multiselect = true
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                files.AddRange(ofd.FileNames);
            }

            return files;
        }
    }
}