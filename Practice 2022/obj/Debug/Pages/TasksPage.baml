   M S B A M L   `   `   `  ����H  DPractice 2022, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Practice_2022.PagesPractice_2022.Pages  5      #    Practice_2022.Pages.TasksPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:Practice_2022.Pages     5        N� Title$  	TasksPage��5	      .��5      � 
������� � RowDefinitions 5   
   �� 5      $	��67* �6   �� 5      $
��383* �6   �� 5      $	��67* �6   .+�5   
   �� -   5         ��Name$ btnBack��5      $	��100��5      $��30��5      $��
Назад��5      $
��Left=�5      
����  �
�������5      �� 5   
   $��Center=�5      $��Center=�5      $
��20px(�5      
����  �$
��Bold"�5      %#Задачи исполнителя63   &   System.Windows.Controls.DataGrid  5    
   -   5          Name$ 	geidTasks��5!      $��1��5"      
�������   AutoGenerateColumns .     
IsReadOnly .    Columns 5&      0  *System.Windows.Controls.DataGridTextColumn  5'      ,  &System.Windows.Controls.DataGridColumn   Header$ Название��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 67   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6A   �� 
 �� Path$
 Title�  5(      $ Описание��6%   $ * 67   	 6A   �� $
 Description�  5)      $ Статус��6%   $ * 65   	 6?   �� $
 Status�  5*      $ Дедлайн��6%   $ * 66   	 6@   �� $
 DeadLine�5,      5-      5.      