﻿using System.Windows;
using System.Windows.Controls;

namespace BrokHub_CSA.BaseControls.ControlMenu
{
    public class ccMenuItem : MenuItem
    {
        static ccMenuItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ccMenuItem), new FrameworkPropertyMetadata(typeof(ccMenuItem)));
        }
    }
}
