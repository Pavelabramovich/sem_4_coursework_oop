   M S B A M L   `   `   `  ����K  GCourseProjectOpp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:CourseProjectOppCourseProjectOpp  5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5
      0    *CourseProjectOpp.AdminProductsChangingView   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:CourseProjectOpp     5      9System&clr-namespace:System;assembly=mscorlib     5
      ] YXceed.Wpf.Toolkit.NET5, Version=4.5.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5        � 	Resources  5         productTypeValues S� 
MethodName S� 
ObjectTypeU	 QSystem.Runtime, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a 	 System.Enum S� MethodParameters M� TypeName��%|   &	        S� 5   
   $ 	GetValues��5      "  6$    5      M� 5      $ local:ProductType��6   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��3* �6   �� 5      $��1* �6   �� 5      $��7* �6   �� 5      $��1* �6    � ColumnDefinitions 5!   
   �� 5"      $��1* �6   �� 5#      $��7* �6   �� 5$      $��1* �6   .+�5(   
   �� $��1��5)      $��4��5*       �� Orientation$ 
Horizontal=�5+      $��Center=�5,      .+�5.      �� $��5q�5/      
�������$��12(�51      $��
Montserrat)�52      $��ADD PRODUCT��53      ��54      �� *AddProductCommand+��56      �� 57       �� 
TargetType" ��6   .�58      �� 	 �� Property	 � ��
 �� Value

 �<��67    �� Triggers 59      P� 5:       P� Property �@J�IsMouseOver P� Value$
 True��6=   . �5;   "   �� 	 � ��

 �  ��6?   5<      5>      ��5@      �� 5A       �� 
TargetType" ��6&   .R�5B      �� $	��150��5C      $��40��6)    �� CornerRadius$ 20��5D      #��z��5E      ._�5G      �� $��Center=�5H   !   $��Center=�5I   !   5J      5K      5M      �� 5O      $��5q�5P      
�������$��12(�5R      $��
Montserrat)�5S      $��SAVE CHANGES��5U      ��5T      �� *SaveChangesCommand+��5W      �� 5X      " ��6   .�5Y      �� 	 � ��

 �<��67    5Z      P� 5[       �@J�IsMouseOver$
 True��6=   . �5\   "   �� 	 � ��

 �  ��6?   5]      5_      ��5a      �� 5b      " ��6&   .R�5c      �� $	��150��5d      $��40��6)   $ 20��5e      #��z��5f      ._�5h      �� $��Center=�5i   !   $��Center=�5j   !   5k      5l      5n      5p      &   System.Windows.Controls.DataGrid  5t   
     dataGridStyle#��[ 5u      $��1��5v      $��1��5w      $��False��5x         AutoGenerateColumns$ False��5z         CanUserAddRows$ False��5{         ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5|         CanUserDeleteRows$ False��5}         CanUserReorderColumns$ False��5~         CanUserResizeColumns$ False��5         CanUserResizeRows$ False��5�         CanUserSortColumns$ False��5�         SelectionMode$ Single=�5�      ��5y      �� *Types+ �� Mode$ TwoWay=�  5�        DiscountTemplate%  Xceed.Wpf.Toolkit.IntegerUpDown�  �Xceed.Wpf.Toolkit.Primitives.UpDownBase`1[[System.Nullable`1[[System.Int32, System.Runtime, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Runtime, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]]   Minimum   Maximum   Value��%�   &	       �� 5�      .R�5�        -   5         05�       1005�      $��18(�5�      $��
Montserrat)�5�       5�      �� *
Discount+$ TwoWay=�5�      5�      5�         Columns 5�      0  *System.Windows.Controls.DataGridTextColumn  5�         FontSize$ 18Q�5�         
FontFamily$ 
Montserrat)�5�      ,  &System.Windows.Controls.DataGridColumn    
IsReadOnly$
  True��5�      !   Header$
! Name��5�      1  +System.Windows.Controls.DataGridBoundColumn"   Binding" 5�      �� *Name+4	  .System.Windows.Controls.DataGridTemplateColumn	  5�      $! Discount��5�      # 	  CellTemplate## [ 5�      5�        5�   
   #��[ 5�      $��False��5�      $��3��5�      $ * 5�      $��1��5�      $ False��5�      $ False��5�      $ False��5�      $ False��5�      $ False��5�      $ False��5�      $ False��5�      $ Single=�5�      ��5�      �� *
Products+$ TwoWay=�  5�        ImageTemplate  PriceTemplate  DescriptionTemplate$ �� TextWrapping% �� AcceptsReturn& �� 
AcceptsTab$' �� HorizontalScrollBarVisibility( �� MaxLines��%�  &	       &	 �     &	 w    �� 5�      .R�5�      �� .+�5�      �� -   5        $	��180��5�      .��5�      �� $	��160��5�   !   $	��160��5�   !   ��5�   !   �� *	ImagePath+5�      5�      5�      �� 5�      .R�5�        -   5         05�      $��18(�5�      $��
Montserrat)�5�       1005�       5�      �� *Price+$ TwoWay=�5�      5�      �� 5�      .R�5�      �� -   5        $��False��5�      $
$ Wrap=�5�      $
% True��5�      $
& True��5�      $' Disabled=�5�      $( 10��5�      $	��180��5�      $	��220��5�      ��5�      �� *Description+$ TwoWay=�.��5�   %   5�      5�      5�       5�        5�      $
! Name��5�      $ 18Q�5�      $ 
Montserrat)�5�      $
  True��5�      " 5�      �� *Name+	  5�      $! Image��5�      ## [ 5�      	  5�      $! Description��5�      ## [ 5�      	  5�      $! Price��5�      ## [ 5�      4
  .System.Windows.Controls.DataGridComboBoxColumn
  5�      $
! Type��5�      ) 
  SelectedItemBinding) 5�      �� *Type+* 
  ItemsSource* 5�      �� + �� Source#+ [  5�      5     5     