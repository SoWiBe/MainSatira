   M S B A M L   `   `   `  ����H  DPractice 2022, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Practice_2022.PagesPractice_2022.Pages  5      '    !Practice_2022.Pages.EmployeesPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:Practice_2022.Pages     5        N� Title$  	Employees��5	      .��5      � 
������� � RowDefinitions 5   
   �� 5      $	��67* �6   �� 5      $	��67* �6   �� 5      $
��383* �6   �� 5      $	��67* �6   .+�5   
   �� $��Center=�5      $��Center=�5      $
��20px(�5      
����  �$
��Bold"�5      Исполнители6,   � 5   
   $��1��6    � ColumnDefinitions 5      �� 5      $
��181* �6#   �� 5      $
��140* �6#   �� 5      $	��79* �6#   .+�5      �� -   5         ��Name$ 	txtSearch��5      $
��6,11q�5   :   �� 5       -   5         ��Name$ 	cmbFilter��5        �� DisplayMemberPath$
 Name��5"      $��1��5#      $��37,11q�6'   �� 5$      $��2��5%      $��Center=�5&      $��Center=�5'      $��24��66   $
��0,14q�6B   $	��150��6P   .+�5(      �� -   5         ��Name$ btnClear��5(      $!��Убрать фильтры��5)      $	��150��5*      $��25��5+      
����  �
�������5.      5/      50      &   System.Windows.Controls.DataGrid  51   
   -   5          Name$ gridEmployees��52      $��2��53      
�������   AutoGenerateColumns .  	   
IsReadOnly	 . 
   Columns
 57      0  *System.Windows.Controls.DataGridTextColumn  58      ,  &System.Windows.Controls.DataGridColumn   Header$ ФИО��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 62   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6<   ��  �� Path$	 FIO�  59      $ Должность��6%   $ * 68    6B   �� $ Positions.Name�  5:      $ Телефон��6%   $ * 66    6@   �� $ Phone�  5;      $ 
Почта��6%   $ * 64    6>   �� $ Email�5=      � 5>   
   $��3��6    5?      �� 5@      �� 5A      �� 5B      �� 5C      .+�5E      �� -   5        $ 	btnDelete��5E      $��0��5F      $��Удалить��5G      $	��150��5H      $��25��5I      
����  �
�������5L      �� 5N      -   5        $ 	btnRedact��5N      $��1��5O      $ ��Редактировать��5P      $	��150��5Q      $��25��5R      
����  �
�������5U      �� 5W      -   5        $ btnAdd��5W      $��2��5X      $��Добавить��5Y      $	��150��5Z      $��25��5[      
����  �
�������5^      �� 5_      -   5        $ btnTasks��5_      $��3��5`      $��Задачи��5a      $	��150��5b      $��25��5c      
����  �
�������5f      5g      5h      5i      