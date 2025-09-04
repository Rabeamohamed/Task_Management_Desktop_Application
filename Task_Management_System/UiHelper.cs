using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Management_System
{
    public class UiHelper
    {
        
            // Global theme colors
            public static Color PrimaryColor = Color.FromArgb(14, 165, 167);   // teal
            public static Color DarkBackground = Color.FromArgb(13, 17, 23);   // dark
            public static Color LightText = Color.White;

            // Apply theme to the whole form
            public static void ApplyFormStyle(Form form)
            {
                form.BackColor = DarkBackground;
                form.Font = new Font("Segoe UI", 10);

                foreach (Control ctrl in form.Controls)
                {
                    ApplyControlStyle(ctrl);
                }
            }

            // Apply style based on control type
            private static void ApplyControlStyle(Control ctrl)
            {
                if (ctrl is Panel panel)
                {
                    panel.BackColor = DarkBackground;
                    foreach (Control c in panel.Controls)
                        ApplyControlStyle(c);
                }
                else if (ctrl is Label lbl)
                {
                    lbl.ForeColor = LightText;
                    if (lbl.Font.Style != FontStyle.Bold)
                        lbl.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                }
                else if (ctrl is Button btn)
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.BackColor = PrimaryColor;
                    btn.ForeColor = LightText;
                    btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                    btn.Cursor = Cursors.Hand;
                }
                else if (ctrl is DataGridView grid)
                {
                    ApplyGridStyle(grid);
                }
                else if (ctrl.HasChildren)
                {
                    foreach (Control c in ctrl.Controls)
                        ApplyControlStyle(c);
                }
            }

            // Style for DataGridView
            public static void ApplyGridStyle(DataGridView grid)
            {
                grid.BackgroundColor = DarkBackground;
                grid.BorderStyle = BorderStyle.None;
                grid.EnableHeadersVisualStyles = false;

                grid.ColumnHeadersDefaultCellStyle.BackColor = PrimaryColor;
                grid.ColumnHeadersDefaultCellStyle.ForeColor = LightText;
                grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

                grid.DefaultCellStyle.BackColor = Color.White;
                grid.DefaultCellStyle.ForeColor = Color.Black;
                grid.DefaultCellStyle.SelectionBackColor = PrimaryColor;
                grid.DefaultCellStyle.SelectionForeColor = LightText;

                grid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
                grid.RowHeadersVisible = false;
            }
        }
    }

