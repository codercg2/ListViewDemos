using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;


namespace System.Windows.Forms
{
    class RadioListBox : ListBox
    {
        private StringFormat Align;
        private bool IsTransparent = false;
        private Brush TransparentBrush = SystemBrushes.Control;

        [DefaultValue(false)]
        public bool Transparent
        {
            set
            {
                IsTransparent = value;

                if (IsTransparent)
                {
                    if (this.Parent != null)
                        this.BackColor = this.Parent.BackColor;
                    else
                        this.BackColor = SystemColors.Control;
                    this.TransparentBrush = new SolidBrush(this.BackColor);
                    this.BorderStyle = BorderStyle.None;
                }
                else
                {
                    this.BackColor = SystemColors.Window;
                    this.BorderStyle = BorderStyle.Fixed3D;
                }
            }
            get
            {
                return IsTransparent;
            }
        }

        public RadioListBox()
        {
            this.DrawMode = DrawMode.OwnerDrawFixed;

            this.Align = new StringFormat(StringFormat.GenericDefault);
            this.Align.LineAlignment = StringAlignment.Center;
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            if (e.Index < 0)
                return;
            if (e.Index > this.Items.Count-1)
                return;

            int size = e.Font.Height; // button size depends on font height, not on item height

            if (IsTransparent && e.State!= DrawItemState.Selected)
                e.Graphics.FillRectangle(TransparentBrush, e.Bounds);
            else
                e.DrawBackground();

            Brush textBrush;
            ButtonState state = ButtonState.Normal;

            if ((e.State & DrawItemState.Disabled)>0 || (e.State & DrawItemState.Grayed)>0)
            {
                textBrush = SystemBrushes.GrayText;
                state = ButtonState.Inactive;
            }
            else if ((e.State & DrawItemState.Selected)>0 && !Transparent)
            {
                textBrush = SystemBrushes.HighlightText;
            }
            else
            {
                textBrush = SystemBrushes.FromSystemColor(this.ForeColor);
            }
            if ((e.State & DrawItemState.Selected)>0)
                state |= ButtonState.Checked;

            // Draw radio button
            Rectangle bounds = e.Bounds;
            bounds.Width = size;
            ControlPaint.DrawRadioButton(e.Graphics, bounds, state);

            // Draw text
            bounds = new Rectangle(e.Bounds.X+size+2, e.Bounds.Y, e.Bounds.Width-size-2, e.Bounds.Height);
            e.Graphics.DrawString(this.Items[e.Index].ToString(), e.Font, textBrush, bounds, this.Align);

            // If the ListBox has focus, draw a focus rectangle around the selected item.
            e.DrawFocusRectangle();
        }
        protected override void OnParentChanged(EventArgs e)
        {
            // Force to change backcolor
            this.Transparent = this.IsTransparent;
        }
        protected override void OnParentBackColorChanged(EventArgs e)
        {
            // Force to change backcolor
            this.Transparent = this.IsTransparent;
        }
    }
}
