   M S B A M L   `   `   `  ����K  GCourseProjectOpp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:CourseProjectOppCourseProjectOpp  5      +    %CourseProjectOpp.SpecialAbilitiesView   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:CourseProjectOpp     5      X TFontAwesome.Sharp, Version=6.3.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  5      -   5          >�Name$
  root��5       � 	Resources 5         	boolToVis2  ,CourseProjectOpp.AvatarPathToSourceConverter  avatarToSource,  &CourseProjectOpp.LoginToColorConverter  loginToColor,   &CourseProjectOpp.LoginIsAdminConverter  loginIsAdmin2   ,CourseProjectOpp.DiscountToPrecentsConverter  
discToPrec��%�   &	        &	      &	 &     &	 9     &	 L     �� 5   
   6'     5   
   6,     5   
   6&     5   
   6&     5   
   6,   5      .��5      �  � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $	��350 �6   �� 5      $��5* �6    � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5       $	��350 �6   �� 5!      $��4* �6   �� 5"      $��4* �6   �� 5#      $��1* �6   .+�5&   
   A� $��1��5'      $��1��5(      ��5*      L� 5+       L� Drawing 5,      I� 5.      .��50      �  � Brush 6.   ��  �� Path$ DataContext.Color� �� ElementName$
 root�� � Geometry 52   "   � 53   &   .��54   *   �� 	 �� Rect$	 0,0,100,100�6<   55   '   57      �� 59      
 �� Rect$
 0,0,100,100�5;   !    �� ImageSource 5:   !   �� *
AvatarPath+ �� 	Converter# [ 5;   !   5=      5?      5A      �� 5D   
    �� Orientation$ Vertical=�5E      $��1��5F      $��2��5G      $��
150,58,0,0q�5H      .+�5J      �� 
�������$��18(�5L      $��Medium"�5M      $��
Montserrat)�5N      $��My discount��5O      �� 5Q      $��16(�5R      $��
Montserrat)�5S      
�������$��0,8,0,0q�5U      ��5V      �� *
Discount+# [ 5Y      �� 5[   
   $ Vertical=�5\      $��2��5]      $��1��5^      $��30q�5_      .+�5a      �� $��Login��5b      
�������$��18(�5d      $��Medium"�5e      $��
Montserrat)�5f      $��0,28,0,0q�5g      � 5i      .+�5j      !  FontAwesome.Sharp.IconImage  �  �FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=6.3.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]   Icon$
 User=�5k         
Foreground
 �����$��14��5m      $��14��5n      $
��Left=�5o      $��Center=�5p      �� 5r      -   5         ��Name$ loginTextBox��5s       �� Padding$ 20,0,0,0q�5t      $��16(�5u      $��
Montserrat)�5v      
�������
������ $��21��5y      $��Center=�5z      $��0,8,0,0q�5|      ��5{      �� *Login+5|      5}      �� 5      $
��Name��5�      
�������$��18(�5�      $��Medium"�5�      $��
Montserrat)�5�      $��0,26,0,0q�5�      � 5�      .+�5�        $ HatCowboySide=�5�      
 �����$��14��5�      $��14��5�      $
��Left=�5�      $��Center=�5�      �� 5�      $ 20,0,0,0q�5�      $��16(�5�      $��
Montserrat)�5�      
�������
������ $��21��5�      $��Center=�5�      $��0,8,0,0q�5�      ��5�      �� *Name+ �� UpdateSourceTrigger$ PropertyChanged=�5�      5�      �� 5�      $
��Role��5�      
�������$��18(�5�      $��Medium"�5�      $��
Montserrat)�5�      $��0,26,0,0q�5�      � 5�      .+�5�        $
 Star=�5�      
 �����$��14��5�      $��14��5�      $
��Left=�5�      $��Center=�5�      �� 5�      $ 20,0,0,0q�5�      $��16(�5�      $��
Montserrat)�5�      
�������
������ $��21��5�      $��Center=�5�      $��0,8,0,0q�5�      ��5�      �� *
UserRole+5�      5�      5�      �� 5�   
   $��2��5�      $��1��5�      $ Vertical=�5�      .+�5�      �� 
�������$��12(�5�      $��
Montserrat)�5�       � Cursor$
 Hand��5�      $��5q�5�      ��5�      �� *ChangeUserCommand+��5�      �� 5�       �� 
TargetType" ��6   .�5�      ��  �� Property � �� �� Value
 �<��67    �� Triggers 5�      �� 5�         CourseProjectOpp.UserRole   Admin �� Value# Z 5�   !    �� Binding 5�   !   �� $ DataContext.UserRole�$
 root��.a�5�   "   ��  � ��$ CHANGE USERS��5�   %   5�      �� 5�         Customer# Z 5�   !    5�   !   �� $ DataContext.UserRole�$
 root��.a�5�   "   ��  � ��$ CHANGE NAME��5�   %   5�      �� 5�         Provider# Z 5�   !    5�   !   �� $ DataContext.UserRole�$
 root��.a�5�   "   ��  � ��$ CHANGE NAME��5�   %   5�      P� 5�       P� Property �@J�IsMouseOver P� Value$
 True��6=   . �5�   "   ��  � ��
 �  ��6?   5�      5�      ��5�      �� 5�       �� 
TargetType" ��6&   .R�5�      �� $	��150��5�      $��40��6)     �� CornerRadius$  20��5�      #��z��5      ._�5     �� $��Center=�5  !   $��Center=�5  !   5     5     5     �� 5     $��CHANGE AVATAR��5     
�������$��12(�5     $��
Montserrat)�5     $��5q�5     $
 Hand��5     ��5     �� *ChangeAvatarCommand+��5     �� 5     " ��5     .�5     ��  � ��
 �<��67    5     �� 5     # Z 5  !    5  !   �� $ DataContext.UserRole�$
 root��.a�5   "   ��  � y�$ 	Collapsed=�5"  %   5$     P� 5&      �@J�IsMouseOver$
 True��6=   . �5'  "   ��  � ��
 �  ��6?   5(     5*     ��5-     �� 5.     " ��6&   .R�5/     �� $	��150��50     $��40��6)   $  20��51     #��z��52     ._�54     �� $��Center=�55  !   $��Center=�56  !   57     58     5:     �� 5<     $��CHANGE PRODUCTS��5=     
�������$��12(�5@     $��
Montserrat)�5A     $��5q�5B     $
 Hand��5C     ��5>     �� *ChangeProductsCommand+��5E     �� 5F     " ��6   .�5G     ��  � ��
 �<��67    5I     �� 5J     # Z 5N  !    5K  !   �� $ DataContext.UserRole�$
 root��.a�5P  "   ��  � y�$ 	Collapsed=�5R  !   5T     P� 5V      �@J�IsMouseOver$
 True��6=   . �5W  "   ��  � ��
 �  ��6?   5X     5[     ��5^     �� 5_     " ��6&   .R�5`     �� $	��150��5a     $��40��6)   $  20��5b     #��z��5c     ._�5e     �� $��Center=�5f  !   $��Center=�5g  !   5h     5i     5k     5l     5t     5v     