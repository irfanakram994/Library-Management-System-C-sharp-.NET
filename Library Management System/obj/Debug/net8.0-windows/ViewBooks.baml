   M S B A M L   `   `   `  ����  Library Management System)    #Library_Management_System.ViewBooks   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	     � Title$  	ViewBooks��5   	   $	��450��5   	   $	��860��5	   	    � WindowStartupLocation$ CenterScreen=�5
   	   ���#F0F4F8.��5      � $��20q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��
View Books��6   $��Cambria)�5      $
��Bold"�5      $��28(�5      ���#4A4A8D$��Center=�5      $
��0,10q�5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ BooksDataGrid��5      $��1��5      $��10q�5          AutoGenerateColumns$
 True��5!         CanUserAddRows$ False��5"         
IsReadOnly$
 True��5#      $��Cambria)�5$      $��16(�5%         AlternatingRowBackground �#E8E8E8   RowBackground
 �����	   Columns	 5(      0  *System.Windows.Controls.DataGridTextColumn  5)      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Book ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6Q   1  +System.Windows.Controls.DataGridBoundColumn   Binding 66   �� *BookID+6Q     5*      $
 	Book Name��6%   $	 200 6U    68   �� *
BookName+6U     5+      $
 Author Name��6%   $	 200 6Y    6:   �� *
AuthorName+6Y     5,      $
 Publication��6%   $	 150 6Z    6:   �� *Publication+6Z     5-      $
 Purchase Date��6%   $	 150 6]    6<   �� *PurchaseDate+6]     5.      $
 Price��6%   $	 100 6R    64   �� *	BookPrice+6R     5/      $
 Quantity��6%   $	 100 6X    67   �� *BookQuantity+6X   51      52      53      