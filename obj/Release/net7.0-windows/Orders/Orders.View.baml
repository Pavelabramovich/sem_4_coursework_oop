   M S B A M L   `   `   `  ���� K  GCourseProjectOpp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:CourseProjectOppCourseProjectOpp  !    CourseProjectOpp.OrdersView   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     0localclr-namespace:CourseProjectOpp     .���   � RowDefinitions  �� $	��94* ��� $
��301* ��� $	��55* � � ColumnDefinitions �� $
��102* ��� $
��635* ��� $	��63* �.+��� $��False��$��Disabled=�$��1��$��1������ *Orders+����  �� 
TargetType" �� �� Triggers ��  �� Binding �� *	IsAdmin+ �� Value True.a���  �� Property � �� �� Value ��  �� DataType$ local:Order��.R��� .+��� ���� *ProductName+�� ���� *Count+�� ���� *CustomerLogin+�� ���� *
CardNumber+��  �� *	IsAdmin+	 False.a���  � �� �� $ local:Order��.R��� .+��� ���� *ProductName+�� ���� *Count+�� ���� *
CardNumber+�� $
��Back��$
��Left=�$��2q�$��39��$��
27,21,0,47q����� *BackCommand+