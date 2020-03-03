using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Homework6
{
    public partial class Page4 : ContentPage
    {
        public Page4()
        {
            InitializeComponent();
        }

        void ChangeTextColor(Object sender, EventArgs e)
        {
            ColoredLabel.TextColor = Color.Purple;
        }

        void UndoColorChange(Object sender, EventArgs e)
        {
            ColoredLabel.TextColor = Color.Black;
        }
    }
}
