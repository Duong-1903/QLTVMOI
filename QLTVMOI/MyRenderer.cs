using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTVMOI
{
    internal class MyRenderer : ToolStripProfessionalRenderer
    {
        public MyRenderer() : base(new MyColors()) { }

        class MyColors : ProfessionalColorTable
        {
            public override Color MenuItemSelected => Color.DarkSlateBlue;
            public override Color MenuItemBorder => Color.Cyan;
            public override Color MenuItemSelectedGradientBegin => Color.DarkSlateBlue;
            public override Color MenuItemSelectedGradientEnd => Color.DarkSlateBlue;
            public override Color ToolStripDropDownBackground => Color.Black;

            public override Color ToolStripGradientBegin => Color.Black;
            public override Color ToolStripGradientMiddle => Color.Black;
            public override Color ToolStripGradientEnd => Color.Black;
        }

        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            // Áp dụng màu hover đồng bộ cho cả item cha và con
            if (e.Item.Selected && !e.Item.Pressed)
            {
                using (SolidBrush brush = new SolidBrush(Color.DarkSlateBlue))
                {
                    e.Graphics.FillRectangle(brush, new Rectangle(Point.Empty, e.Item.Size));
                }
            }
            else
            {
                using (SolidBrush brush = new SolidBrush(e.Item.BackColor))
                {
                    e.Graphics.FillRectangle(brush, new Rectangle(Point.Empty, e.Item.Size));
                }
            }
        }

        protected override void OnRenderArrow(ToolStripArrowRenderEventArgs e)
        {
            e.ArrowColor = Color.White;
            base.OnRenderArrow(e);
        }

        protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
        {
            e.TextColor = Color.White;
            base.OnRenderItemText(e);
        }

        protected override void OnRenderSeparator(ToolStripSeparatorRenderEventArgs e)
        {
            // Tùy chỉnh đường phân cách nếu có
            using (Pen pen = new Pen(Color.Gray))
            {
                e.Graphics.DrawLine(pen, 0, 3, e.Item.Width, 3);
            }
        }
    }
}
