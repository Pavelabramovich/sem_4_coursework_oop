   M S B A M L   `   `   `  ����K  GCourseProjectOpp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:CourseProjectOppCourseProjectOpp  5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5      &     CourseProjectOpp.ChangeUsersView   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:CourseProjectOpp     5      9System&clr-namespace:System;assembly=mscorlib     5      ] YXceed.Wpf.Toolkit.NET5, Version=4.5.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5        � 	Resources  5         
roleValues S� 
MethodName S� 
ObjectTypeU	 QSystem.Runtime, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a 	 System.Enum S� MethodParameters M� TypeName2  ,CourseProjectOpp.AvatarPathToSourceConverter  avatarToSource,  &CourseProjectOpp.LoginToColorConverter  loginToColor,   &CourseProjectOpp.LoginIsAdminConverter  loginIsAdmin��%�   &	        &	 o     &	 �     &	 �     S� 5   
   $ 	GetValues��5      "  6$    5      M� 5      $ local:UserRole��6   5        5   
   6,     5   
   6&     5   
   6&   5      .��5      �  � RowDefinitions 5   
   �� 5      $��2* �6   �� 5      $	��19* �6   �� 5       $��3* �6    � ColumnDefinitions 5#   
   �� 5$      $��1* �6   �� 5%      $��7* �6   �� 5&      $��1* �6   .+�5)   
   �� $��1��5*      $��2��5+      $��SAVE CHANGES��5,      $��0q�5-      
�������$��12(�5/      $��
Montserrat)�50       � Cursor$
 Hand��51      $��5q�52      ��53      �� *SaveChangesCommand+��55      �� 56       �� 
TargetType" ��6   .�57      �� 	 �� Property	 � ��
 �� Value

 �<��63    �� Triggers 58      P� 59       P� Property �@J�IsMouseOver P� Value$
 True��69   . �5:      �� 	 � ��

 �  ��6;   5;      5=      ��5?      �� 5@       �� 
TargetType" ��6"   .R�5A      �� $	��150��5B      $��40��6)    �� CornerRadius$ 20��5C      #��z��5D      ._�5F      �� $��Center=�5G   !   $��Center=�5H   !   5I      5J      5L      &   System.Windows.Controls.DataGrid  5N   
   -   5          Name$ 	userTable��5O      $��1��5P      $��1��5Q        dataGridStyle#��[ 5S         AutoGenerateColumns$ False��5T         CanUserAddRows$ False��5U         CanUserDeleteRows$ False��5V         ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5W         CanUserReorderColumns$ False��5X         CanUserResizeColumns$ False��5Y         CanUserResizeRows$ False��5Z         CanUserSortColumns$ False��5[         SelectionMode$ Single=�5\      $��False��5]      ��5R      �� *Users+ �� Mode$ TwoWay=�  5_        DiscountTemplate%  Xceed.Wpf.Toolkit.IntegerUpDown�  �Xceed.Wpf.Toolkit.Primitives.UpDownBase`1[[System.Nullable`1[[System.Int32, System.Runtime, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Runtime, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]]   Minimum   Maximum   Value  AvatarTemplate L� Drawing � Brush  �� 	Converter! � Geometry" �� Rect# �� Rect$ �� ImageSource��%�  &	       &	 �     7  7  �� 5`      .R�5a        -   5         05c       1005d      $��18(�5e      $��
Montserrat)�5f       5b      �� *
Discount+$ TwoWay=�5g      5i      �� 5k      .R�5l      �� .+�5m      �� -   5        .��5p      A� $	��100��5q   !   $	��100��5r   !   ��5t   "   L� 5u   &    5v   *   I� 5w   .   .��5x   2   �  6B   �� *Login+8    ! 5y   6   � 5z   :   .��5{   >   �� $" 0,0,100,100�6P   5}   ;   5   3   �� 5�   2   $# 0,0,100,100�5�   1   $ 5�   1   �� *
AvatarPath+8   5�   1   5�   /   5�   '   5�      5�      5�      5�      5�      %   Columns% 5�      0	  *System.Windows.Controls.DataGridTextColumn	  5�      & 	  FontSize$& 18Q�5�      ' 	  
FontFamily$' 
Montserrat)�5�      ,
  &System.Windows.Controls.DataGridColumn( 
  Header$
( Name��5�      1  +System.Windows.Controls.DataGridBoundColumn)   Binding) 5�      �� *Name+4  .System.Windows.Controls.DataGridTemplateColumn  5�      $( Avatar��5�      *   CellTemplate#* [ 5�      4  .System.Windows.Controls.DataGridComboBoxColumn  5�      $
( Role��5�      +   SelectedItemBinding+ 5�      �� *Role+,   ItemsSource, 5�      �� - �� Source#- [    5�      $( Discount��5�      #* [ 5�      5�      5�      5�      