   M S B A M L   `   `   `  ����T  PLibrary Management System, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:Library_Management_SystemLibrary_Management_System  5   	   )    #Library_Management_System.IssueBook   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:Library_Management_System     5   	     � Title$  
Issue Book��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6    �� Orientation$ 
Horizontal=�6"   $��10q�6;   .+�5      �� $��
Member ID:��6   $��Center=�6*   �� 5      -   5         ��Name$ memberIdTextBox��5      $	��100��6/   $��5,0,0,0q�6;   �� 5      -   5         ��Name$ searchMemberButton��5      $��Search��61   $��5,0,0,0q�6B   $��75��6S   6^   �� 5      $��Book ID:��6   $��Center=�6(   $��20,0,0,0q�6C   �� 5      -   5        $ bookIdTextBox��5      $	��100��6-   $��5,0,0,0q�69   �� 5      -   5        $ searchBookButton��5      $��Search��6/   $��5,0,0,0q�6@   $��75��6Q   6\   �� 5      $��Return Date:��6   $��Center=�6,   $��20,0,0,0q�6G   (  "System.Windows.Controls.DatePicker  5      -   5          Name$ returnDatePicker��5      $	��120��63   $��5,0,0,0q�6?   �� 5      -   5        $ issueBookButton��5      $��
Issue Book��6.   $��20,0,0,0q�6C   $	��100��6U   ${�False��6   5      � 5    
   $��1��6   $��10q�6    � ColumnDefinitions 5!      �� 5"      $��* �6#   �� 5#      $��* �6#   .+�5%      �� $��0��6   $��Member Details:��6(   $	��Top=�6?   �� 5&      $��1��6   $��Book Details:��6(   $	��Top=�6=   �� 5'      -   5        $ memberNameTextBox��5'      $��0��61    �� 
IsReadOnly$
 True��6A    �� TextWrapping$
 Wrap=�6S   $��5,10,0,0q�6g   "	 �� VerticalScrollBarVisibility$
	 Auto=�6y   $	��200��6�   �� 5(      -   5        $ bookTitleTextBox��5(      $��1��60   $
 True��6@   $
 Wrap=�6R   $��5,10,0,0q�6f   $
	 Auto=�6x   $	��200��6�   5)      5*      5+      