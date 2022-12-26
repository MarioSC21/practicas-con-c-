using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace Controls
{
    internal class MyCheck
    {
        internal class CtlMyCheck : CheckBox
        {
            private Color onbackColor = Color.Azure;
            private Color onForeColor = Color.WhiteSmoke;
            private Color offBackColor = Color.Gray;
            private Color offForeColor = Color.GreenYellow;

            public Color OnbackColor { get => onbackColor; set => onbackColor = value; }
            public Color OnForeColor { get => onForeColor; set => onForeColor = value; }
            public Color OffBackColor { get => offBackColor; set => offBackColor = value; }
            public Color OffForeColor { get => offForeColor; set => offForeColor = value; }

            public CtlMyCheck()
            {
                this.MinimumSize = new Size(50, 20);
            }

            private GraphicsPath GetFigurepath()
            {
                GraphicsPath path = new GraphicsPath();
                int arcSize = this.Height - 1;
                Rectangle leftArc = new Rectangle(0, 0, arcSize, arcSize);
                Rectangle rigthArc = new Rectangle(this.Width - arcSize - arcSize, 0, arcSize, arcSize);

                path.StartFigure();
                path.AddArc(leftArc,90,180);
                path.AddArc(rigthArc, 270, 180);
                path.CloseAllFigures();
                return path;
            }
            protected override void OnPaint(PaintEventArgs prevent)
            {
                int Size = this.Height - 5;
                prevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                prevent.Graphics.Clear(this.Parent.BackColor);
                if (this.Checked)
                {
                    prevent.Graphics.FillPath(new SolidBrush(onbackColor), GetFigurepath());
                    prevent.Graphics.FillEllipse(new SolidBrush(onForeColor), new Rectangle(this.Width - this.Height+1, 2, Size, Size));
                }
                else
                {
                    prevent.Graphics.FillPath(new SolidBrush(this.offBackColor), GetFigurepath());
                    prevent.Graphics.FillEllipse(new SolidBrush(offForeColor), new Rectangle(2, 2, Size, Size));
                }
            }
        }
    }
}
