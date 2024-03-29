﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CourseProjectOpp;

public partial class OrdersView : UserControl
{
    public OrdersView()
    {
        InitializeComponent();

        DataContextChanged += UpdateTable;
    }

    public void UpdateTable(object sender, DependencyPropertyChangedEventArgs e)
    {
        if (DataContext is OrdersViewModel viewModel && !viewModel.IsAdmin)
        {
            ordersTable.Columns[1].Visibility = Visibility.Collapsed;
        }
    }
}
