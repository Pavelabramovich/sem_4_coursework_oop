   M S B A M L   `   `   `  ����K  GCourseProjectOpp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:CourseProjectOppCourseProjectOpp  5      3    -CourseProjectOpp.ProviderProductsChangingView   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:CourseProjectOpp     5      .��5      �   � RowDefinitions  5   
   �� 5      $��2* �6   �� 5      $	��19* �6   �� 5      $��3* �6    � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��7* �6   �� 5      $��1* �6   .+�5   
   �� $��1��5      $��2��5      $��SAVE CHANGES��5      $��0q�5      
�������$��12(�5      $��
Montserrat)�5       � Cursor$
 Hand��5       $��5q�5!      ��5"      �� *SaveChangesCommand+��5$      �� 5%       �� 
TargetType" ��6   .�5&      ��  �� Property � �� �� Value
 �<��63    �� Triggers 5'      P� 5(       P� Property �@J�IsMouseOver P� Value$
 True��69   . �5)      ��  � ��
 �  ��6;   5*      5,      ��5.      �� 5/      	 �� 
TargetType"	 ��6"   .R�50      �� $	��150��51      $��40��6)   
 �� CornerRadius$
 20��52      #��z��53      ._�55      �� $��Center=�56   !   $��Center=�57   !   58      59      5;      &   System.Windows.Controls.DataGrid  5=   
      dataGridStyle#��[  5>      $��1��5?      $��1��5@         AutoGenerateColumns$ False��5B         CanUserAddRows$ False��5C         CanUserDeleteRows$ False��5D         ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5E         CanUserReorderColumns$ False��5F         CanUserResizeColumns$ False��5G         CanUserResizeRows$ False��5H         CanUserSortColumns$ False��5I         SelectionMode$ Single=�5J      $��False��5K      ��5A      �� *
Products+ �� Mode$ TwoWay=�   Columns 5M      0  *System.Windows.Controls.DataGridTextColumn  5N      ,  &System.Windows.Controls.DataGridColumn   Header$ Product��5O         FontSize$ 18Q�5P         
FontFamily$ 
Montserrat)�5Q      1  +System.Windows.Controls.DataGridBoundColumn   Binding 5R      �� *ProductName+4  .System.Windows.Controls.DataGridCheckBoxColumn  5T      $ Is providered��5U       5V      �� *IsProvidered+$ TwoWay=�5[      5]      5_      