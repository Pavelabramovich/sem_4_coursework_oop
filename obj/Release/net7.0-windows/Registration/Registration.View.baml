   M S B A M L   `   `   `  ���� K  GCourseProjectOpp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:CourseProjectOppCourseProjectOpp  '    !CourseProjectOpp.RegistrationView   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     0localclr-namespace:CourseProjectOpp     _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3i+http://schemas.microsoft.com/xaml/behaviors    � 	Resources     	boolToVis<   6CourseProjectOpp.SecureStringToCharEnumerableConverter  secureStrToChars6   0CourseProjectOpp.StringToCharEnumerableConverter  
strToChars��%-   &	        &	      &	 
     ��     .���  � RowDefinitions �� $	��93* ��� $
��254* ��� $
��103* � � ColumnDefinitions �� $
��241* ��� $
��311* ��� $
��248* �.+�� $��1��$��1��
�������.+��� $��10,10,10,10q�.+��� $��Login����  �� 	MaxLength$ 16������ *Login+ �� UpdateSourceTrigger$ PropertyChanged=��� $��10(�
���  ������ *InvalidLoginWarning+$ PropertyChanged=��� $
��Name���� $ 16������ *Name+$ PropertyChanged=��� $��10(�
���  ������ *InvalidNameWarning+$ PropertyChanged=��� $��Password��]� $
��True��.+��� -    ��Name$ hidePasswordCheckBox��$��Right=�� $
��Left=�.+�G�  G� 	MaxLength$ 30�� G� PasswordChar$	 •������  �� 
TargetType" G�	 �� Triggers	 �� 
 �� Binding
 �� *	IsChecked+ �� ElementName$ hidePasswordCheckBox�� �� Value	 False.a���  �� Property � y� �� Value$ Visible=�*  $Microsoft.Xaml.Behaviors.Interaction   	Behaviors '   !CourseProjectOpp.PasswordBehavior     SecurePassword �� *
Password+ �� Mode$ TwoWay=�$ PropertyChanged=� �� 	Converter# [ �� y��� *	IsChecked+$ hidePasswordCheckBox��# [  .������ " ��	 P�  P� Property � y� P� Value$ Visible=�. ���  � �� �� *
Password+$ PropertyChanged=�# [ .���� 
���  ��$��10(����� *InvalidPasswordWarning+$ PropertyChanged=��� $��Repeat password��]� $
��True��.+��� -   $  hideRepeatPasswordCheckBox��$��Right=�� $
��Left=�.+�G� $ 16��$	 •������ " G�	 �� 
 �� *	IsChecked+$  hideRepeatPasswordCheckBox��$ TwoWay=�	 False.a���  � y�$ Visible=�    �� *RepeatedPassword+$ PropertyChanged=�$ TwoWay=�# [ �� y��� *	IsChecked+$  hideRepeatPasswordCheckBox��# [  .������ " ��	 P�  � y�$ Visible=�. ���  � �� �� *RepeatedPassword+$ PropertyChanged=�# [ $ TwoWay=�.���� 
���  ��$��10(����� * InvalidRepeatedPasswordWarning+$ PropertyChanged=��� $��
Registrate��$��Center=�$��2q����� *RegistrationCommand+�� $
��Back��$
��Left=�$��86,0,0,0q�$��2��$��Center=�$��20��$��28������ *BackCommand+