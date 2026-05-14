using System.Drawing;
using System.Windows.Forms;

namespace DeadLine_Maxing.Services
{
    internal class ThemeService
    {
        public static bool IsDarkMode = false;

        public static void ApplyTheme(Form form)
        {
            if (IsDarkMode)
            {
                ApplyDarkTheme(form);
            }
            else
            {
                ApplyLightTheme(form);
            }
        }

        private static void ApplyDarkTheme(Form form)
        {
            form.BackColor = Color.FromArgb(30, 30, 30);

            foreach (Control c in form.Controls)
            {
                c.ForeColor = Color.White;

                if (c is Label)
                {
                    c.BackColor = form.BackColor;
                }

                else
                {
                    c.BackColor =
                        Color.FromArgb(60, 60, 60);
                }

                if (c is MonthCalendar mc)  
                {
                    mc.BackColor =
                        Color.FromArgb(45, 45, 45);

                    mc.ForeColor =
                        Color.White;

                    mc.TitleBackColor =
                        Color.FromArgb(60, 60, 60);

                    mc.TitleForeColor =
                        Color.White;

                    mc.TrailingForeColor =
                        Color.Gray;
                }

                if (c is DateTimePicker dtp)
                {
                    dtp.CalendarMonthBackground =
                        Color.FromArgb(45, 45, 45);

                    dtp.CalendarForeColor =
                        Color.White;

                    dtp.CalendarTitleBackColor =
                        Color.FromArgb(60, 60, 60);

                    dtp.CalendarTitleForeColor =
                        Color.White;
                }

                if (c is DataGridView dgv)  
                {
                    dgv.BackgroundColor =
                        Color.FromArgb(30, 30, 30);

                    dgv.GridColor =
                        Color.Gray;

                    dgv.DefaultCellStyle.BackColor =
                        Color.FromArgb(45, 45, 45);

                    dgv.DefaultCellStyle.ForeColor =
                        Color.White;

                    dgv.ColumnHeadersDefaultCellStyle.BackColor =
                        Color.FromArgb(60, 60, 60);

                    dgv.ColumnHeadersDefaultCellStyle.ForeColor =
                        Color.White;

                    dgv.DefaultCellStyle.SelectionBackColor =
                    Color.FromArgb(80, 80, 80);

                    dgv.DefaultCellStyle.SelectionForeColor =
                        Color.White;

                    dgv.EnableHeadersVisualStyles = false;
                }
            }
        }

        private static void ApplyLightTheme(Form form)
        {
            form.BackColor = Color.White;

            foreach (Control c in form.Controls)
            {
                c.ForeColor = Color.Black;

                if (c is Label)
                {
                    c.BackColor = form.BackColor;
                }

                else
                {
                    c.BackColor = Color.Gainsboro;
                }

                if (c is MonthCalendar mc)
                {
                    mc.BackColor = Color.White;

                    mc.ForeColor = Color.Black;

                    mc.TitleBackColor =
                        Color.Gainsboro;

                    mc.TitleForeColor =
                        Color.Black;

                    mc.TrailingForeColor =
                        Color.Gray;
                }

                if (c is DateTimePicker dtp)
                {
                    dtp.CalendarMonthBackground =   
                        Color.White;

                    dtp.CalendarForeColor =
                        Color.Black;

                    dtp.CalendarTitleBackColor =
                        Color.Gainsboro;

                    dtp.CalendarTitleForeColor =
                        Color.Black;
                }

                if (c is DataGridView dgv)
                {
                    dgv.BackgroundColor =
                        Color.White;

                    dgv.GridColor =
                        Color.LightGray;

                    dgv.DefaultCellStyle.BackColor =
                        Color.White;

                    dgv.DefaultCellStyle.ForeColor =
                        Color.Black;

                    dgv.ColumnHeadersDefaultCellStyle.BackColor =
                        Color.Gainsboro;

                    dgv.ColumnHeadersDefaultCellStyle.ForeColor =
                        Color.Black;

                    dgv.EnableHeadersVisualStyles = false;  
                }
            }
        }

        public static void ToggleTheme(Form form)
        {
            IsDarkMode = !IsDarkMode;

            ApplyThemeToAllOpenForms();
        }
        public static void ApplyThemeToAllOpenForms()
        {
            foreach (Form form in Application.OpenForms)
            {
                ApplyTheme(form);
            }
        }
    }
}