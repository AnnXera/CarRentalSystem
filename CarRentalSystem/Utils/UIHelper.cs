using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalSystem.Utils
{
    internal class UIHelper
    {
        // Draw border inside a control's client area
        public static void DrawBorderInside(Control control, PaintEventArgs e, int borderWidth = 1)
        {
            Rectangle rect = control.ClientRectangle;

            using (var brush = new SolidBrush(control.BackColor))
            using (var pen = new Pen(Color.FromArgb(210, 210, 210), borderWidth))
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;

                e.Graphics.FillRectangle(brush, rect);

                pen.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                e.Graphics.DrawRectangle(
                    pen,
                    borderWidth / 2,
                    borderWidth / 2,
                    rect.Width - borderWidth,
                    rect.Height - borderWidth
                );
            }
        }

        // Sidebar Button Management
        public class SidebarButtonConfig
        {
            public Button Button { get; set; }
            public Image ActiveIcon { get; set; }
            public Image InactiveIcon { get; set; }
        }

        public static void ResetSidebarButtons(List<SidebarButtonConfig> buttons)
        {
            foreach (var cfg in buttons)
            {
                if (cfg.Button == null || cfg.InactiveIcon == null) continue;

                cfg.Button.BackColor = Color.FromArgb(24, 24, 24);
                cfg.Button.Image = cfg.InactiveIcon;
            }
        }

        public static void SetActiveButton(Button activeButton, Image activeIcon)
        {
            if (activeButton == null) return;

            activeButton.BackColor = Color.FromArgb(0, 108, 245); 
            if (activeIcon != null)
                activeButton.Image = activeIcon;
        }

        public static void DrawRoundedControl(object sender, PaintEventArgs e, int cornerRadius, bool drawBorder = false, Color? borderColor = null)
        {
            var control = sender as Control;
            if (control == null) return; 

            int radius = cornerRadius;
            Rectangle bounds = new Rectangle(0, 0, control.Width, control.Height);

            using (GraphicsPath path = new GraphicsPath())
            {
                int diameter = radius * 2;
                path.AddArc(bounds.X, bounds.Y, diameter, diameter, 180, 90);
                path.AddArc(bounds.Right - diameter, bounds.Y, diameter, diameter, 270, 90);
                path.AddArc(bounds.Right - diameter, bounds.Bottom - diameter, diameter, diameter, 0, 90);
                path.AddArc(bounds.X, bounds.Bottom - diameter, diameter, diameter, 90, 90);
                path.CloseFigure();

                control.Region = new Region(path);

                if (drawBorder)
                {
                    using (Pen pen = new Pen(borderColor ?? Color.Gray, 2))
                    {
                        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                        e.Graphics.DrawPath(pen, path);
                    }
                }
            }
        }

        // Apply rounded corners to multiple panels at once
        public static void ApplyRoundedPanels(IEnumerable<Panel> panels, int cornerRadius = 40, bool drawBorder = false, Color? borderColor = null)
        {
            foreach (var pnl in panels)
            {
                pnl.Paint += (s, e) => DrawRoundedControl(s, e, cornerRadius, drawBorder, borderColor);
                pnl.Invalidate(); // forces repaint immediately
            }
        }

        // Apply DrawBorderInside to multiple panels
        public static void ApplyBorderInsideToPanels(IEnumerable<Panel> panels, int borderWidth = 1, Color? borderColor = null)
        {
            foreach (var pnl in panels)
            {
                pnl.Paint += (s, e) =>
                {
                    var ctrl = (Control)s;
                    Rectangle rect = ctrl.ClientRectangle;

                    using (var brush = new SolidBrush(ctrl.BackColor))
                    using (var pen = new Pen(borderColor ?? Color.FromArgb(210, 210, 210), borderWidth))
                    {
                        e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
                        e.Graphics.FillRectangle(brush, rect);

                        pen.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                        e.Graphics.DrawRectangle(
                            pen,
                            borderWidth / 2,
                            borderWidth / 2,
                            rect.Width - borderWidth,
                            rect.Height - borderWidth
                        );
                    }
                };

                pnl.Invalidate(); // force repaint immediately
            }
        }

        // Apply placeholder text behavior to TextBox
        public static void SetPlaceholder(TextBox textBox, string placeholder, Color placeholderColor, Font placeholderFont, Color typingColor, Font typingFont)
        {
            // Apply initial placeholder
            textBox.Text = placeholder;
            textBox.ForeColor = placeholderColor;
            textBox.Font = placeholderFont;

            // Enter event
            textBox.Enter += (s, e) =>
            {
                if (textBox.Text == placeholder)
                {
                    textBox.Text = "";
                    textBox.ForeColor = typingColor;
                    textBox.Font = typingFont;
                }
            };

            // Leave event
            textBox.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholder;
                    textBox.ForeColor = placeholderColor;
                    textBox.Font = placeholderFont;
                }
            };
        }
    }
}
