   M S B A M L   `   `   `  ����K  GCourseProjectOpp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:CourseProjectOppCourseProjectOpp  5      !    CourseProjectOpp.OrdersView   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:CourseProjectOpp     5      -   5          >�Name$  ma��5       � 	Resources 5         	boolToVis��%   &	        �� 5   
   6'   5      .��5      �  � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��6* �6   �� 5      $��1* �6    � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��9* �6   �� 5      $��1* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ ordersTable��5       $��False��5!      $��1��5"      $��1��5#         AutoGenerateColumns$ False��5%         CanUserAddRows$ False��5&         CanUserDeleteRows$ False��5'         ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5(      	   CanUserReorderColumns$	 False��5)      
   CanUserResizeColumns$
 False��5*         CanUserResizeRows$ False��5+         CanUserSortColumns$ False��5,         SelectionMode$ Single=�5-        dataGridStyle#��[ 5.      ��5$      �� *Orders+   Columns 50      0  *System.Windows.Controls.DataGridTextColumn  51      ,  &System.Windows.Controls.DataGridColumn   Header$ Product name��52         FontSize$ 18Q�53         
FontFamily$ 
Montserrat)�54         
IsReadOnly$
 True��55      1  +System.Windows.Controls.DataGridBoundColumn   Binding 56      �� *ProductName+  58      $ Customer login��59      $
 True��5:      $ 18Q�5;      $ 
Montserrat)�5<       5=      �� *CustomerLogin+5>        5@      $ Count��5A      $
 True��5B      $ 18Q�5C      $ 
Montserrat)�5E       5F      �� *Count+  5H      $ 
Order date��5I      $
 True��5J      $ 18Q�5K      $ 
Montserrat)�5M       5N      �� *
DateTime+  5P      $ Total price��5Q      $
 True��5R      $ 18Q�5S      $ 
Montserrat)�5U       5V      �� *
TotalPrice+  5X      $ Card number��5Y      $
 True��5Z      $ 18Q�5[      $ 
Montserrat)�5]       5^      �� *
CardNumber+5b      5c      5e      