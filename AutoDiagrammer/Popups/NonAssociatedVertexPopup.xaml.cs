﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Cinch;

namespace AutoDiagrammer
{

    [PopupNameToViewLookupKeyMetadata("NonAssociatedVertexPopup", typeof(NonAssociatedVertexPopup))]
    public partial class NonAssociatedVertexPopup : Window
    {
        public NonAssociatedVertexPopup()
        {
            InitializeComponent();
            this.Loaded += new RoutedEventHandler(NonAssociatedVertexPopup_Loaded);
        }

        void NonAssociatedVertexPopup_Loaded(object sender, RoutedEventArgs e)
        {
            PocVertex vertex = (PocVertex)this.DataContext;
        }


    }
}
