using System.Drawing;
using System.Windows.Forms;

namespace BCC.DotNetUI.Components
{
    public class BCCExtendedComboBox : ComboBox
    {

        public BCCExtendedComboBox()
        {
            DrawMode = DrawMode.OwnerDrawFixed;
            DropDownStyle = ComboBoxStyle.DropDownList;
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.DrawFocusRectangle();
            if (e.Index >= 0 && e.Index < Items.Count)
            {
                DropDownItem item = (DropDownItem)Items[e.Index];
                if (item.AddImageContainer)
                {
                    if (item.ImageMode)
                    {
                        e.Graphics.DrawImage(item.Image, e.Bounds.X, e.Bounds.Y, ItemHeight, ItemHeight);
                    }
                    else
                    {
                        e.Graphics.DrawImage(item.Image, e.Bounds.Left, e.Bounds.Top);
                    }
                    e.Graphics.DrawString(item.DisplayText, e.Font, new SolidBrush(e.ForeColor), e.Bounds.Left + item.Image.Width + 5, e.Bounds.Top + 2);
                }
                else
                {
                    e.Graphics.DrawString(item.DisplayText, e.Font, new SolidBrush(e.ForeColor), e.Bounds.Left, e.Bounds.Top + 2);
                }
            }
            base.OnDrawItem(e);
        }

        public sealed class DropDownItem
        {
            public string Value { get; set; }
            public Image Image { get; set; }
            public string DisplayText { get; set; }
            public bool ImageMode { get; set; }
            public bool AddImageContainer { get; set; }

            public DropDownItem(string returnValue)
            {
                Value = returnValue;
                DisplayText = returnValue;
                ImageMode = false;
                AddImageContainer = false;
            }

            public DropDownItem(string displayText, string returnValue)
            {
                Value = returnValue;
                DisplayText = displayText;
                ImageMode = false;
                AddImageContainer = false;
            }

            public DropDownItem(string displayText, string returnValue, Color color)
            {
                Value = returnValue;
                DisplayText = displayText;
                Image = new Bitmap(16, 16);
                ImageMode = false;
                AddImageContainer = true;
                using (Graphics g = Graphics.FromImage(Image))
                {
                    using (Brush b = new SolidBrush(color))
                    {
                        g.DrawRectangle(Pens.White, 0, 0, Image.Width, Image.Height);
                        g.FillRectangle(b, 1, 1, Image.Width - 1, Image.Height - 1);
                    }
                }
            }

            public DropDownItem(string displayText, string returnValue, Image image)
            {
                Value = returnValue;
                DisplayText = displayText;
                Image = image;
                ImageMode = true;
                AddImageContainer = true;
            }

            public override string ToString()
            {
                return Value;
            }
        }

    }
}
