   M S B A M L   `   `   `  ����K  GCourseProjectOpp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:CourseProjectOppCourseProjectOpp  5      '    !CourseProjectOpp.CustomMessageBox   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      0localclr-namespace:CourseProjectOpp     5      _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      -   5          � Title$  
MessageBox��5	      $	��150��6   $	��250��6%    � WindowStyle$
 None=�5
       � AllowsTransparency$
 True��5       � Topmost$
 True��5       � WindowStartupLocation$ CenterScreen=�5      
������ .��5      ��  �� CornerRadius$ 5��5   	   
�������
�������$��4q�5   	   ._�5   
   �  � RowDefinitions 5      �� 5      $	��30* �6    �� 5      $	��60* �6    �� 5      $	��30* �6    .+�5      � $��0��6    � ColumnDefinitions 5       �� 5!      $��7* �6'   �� 5"      $	��80* �6'   .+�5%      �� -   5        $��txtTitle��5&      $��Error��5'      $��1��5(      
���iii�$��Center=�5*      $��20(�5+      $
��Bold"�5,      5-      � 5/      $��1��6    50      �� 51      $	��30* �6'   �� 52      $	��70* �6'   .+�55      '  !MaterialDesignThemes.Wpf.PackIcon  -   5        $��msgLogo��56         Kind$ Error=�57      $��0��58      $��Center=�59      $��Center=�5:      $��50��5;      $��50��5<      
���  ��5=      �� 5@      -   5        $��
txtMessage��5A      $��1��5B      $)��#An Error Occured in the Application��5C      
���iii�$��14(�5E      $��Center=�5F      $
��Left=�5G      $
��Wrap=�5H      5I      � 5K      $��2��6    5L      �� 5M      $	��20* �6'   �� 5N      $	��40* �6'   �� 5O      $	��40* �6'   �� 5P      $	��20* �6'   .+�5S      �� -   5        $��btnOk��5T      $��1��5U      $��OK��5V      $��Center=�5W      $��Center=�5X      $��10(�5Y      $��80��5Z      ���	#FF698EF1
�������$��20��5_      ��5]      Z� ��5a      �� 5b      	 �� 
TargetType"	 ��6       baseButtonStyle
 �� BasedOn#
 [  64    �� Triggers 5c      P� 5d   "    P� Property �@J�IsMouseOver P� Value$
 True��6A   . �5e   &   ��  �� Property � �� �� Value �	#FF698EF16C   �� 5f   &    � ��
 �����6C   �� 5g   &    �@�Cursor$
 Hand��6?   5h   #   5j      5m      �� 5o      -   5        $��	btnCancel��5p      $��2��5q      $��Close��5r      $��10(�5s      $��20��5t      $��Center=�5u      $��Center=�5v      $��80��5w      ���	#FFE60000
���������5z      Z� ��5}      �� 5~      "	 ��6    #
 [  64    5      P� 5�   "    �@J�IsMouseOver$
 True��6A   . �5�   &   ��  � �� �	#FF698EF16C   �� 5�   &    � ��
 �����6C   �� 5�   &    �@�Cursor$
 Hand��6?   5�   #   5�      5�      5�      5�      5�      5�      