﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NodeCalculator.Views
{
    /// <summary>
    /// ToolBox.xaml の相互作用ロジック
    /// </summary>
    public partial class ToolBox : UserControl
    {
        public ToolBox()
        {
            InitializeComponent();
        }

        private void TextBlock_DragEnter(object sender, DragEventArgs e)
        {
            e.Handled = true;
        }
    }
}
