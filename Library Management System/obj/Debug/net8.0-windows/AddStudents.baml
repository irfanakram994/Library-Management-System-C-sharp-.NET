   M S B A M L   `   `   `  ����  Library Management System+    %Library_Management_System.AddStudents   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	     � Title$  Add Students��5   	   $	��550��5   	   $	��800��5	   	    � WindowStartupLocation$ CenterScreen=�5
   	   ���#F0F4F8.��5      � $��20q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��Add Student��6   $��Cambria)�5      $
��Bold"�5      $��28(�5      ���#4A4A8D$��Center=�5      $
��0,10q�5      �� 5   
   $��1��6   $��20,10q�6"   .+�5      ��  �� Orientation$ 
Horizontal=�6   $
��0,10q�62   .+�5      �� $��Student Name:��6   $	��150��61   $��Center=�6=   $��Cambria)�6X   $��16(�6m   �� 5      -   5         ��Name$ txtStudentName��5      $	��400��62   $��Cambria)�6>   $��16(�6S   5       �� 5"      $ 
Horizontal=�6   $
��0,10q�62   .+�5#      �� $��Enrollment No:��6   $	��150��62   $��Center=�6>   $��Cambria)�6Y   $��16(�6n   �� 5$      -   5        $ txtEnrollmentNo��5$      $	��400��63   $��Cambria)�6?   $��16(�6T   5%      �� 5'      $ 
Horizontal=�6   $
��0,10q�62   .+�5(      �� $��Email:��6   $	��150��6*   $��Center=�66   $��Cambria)�6Q   $��16(�6f   �� 5)      -   5        $ txtEmail��5)      $	��400��6,   $��Cambria)�68   $��16(�6M   5*      �� 5,      $ 
Horizontal=�6   $
��0,10q�62   .+�5-      �� $��Phone Number:��6   $	��150��61   $��Center=�6=   $��Cambria)�6X   $��16(�6m   �� 5.      -   5        $ txtPhoneNumber��5.      $	��400��62   $��Cambria)�6>   $��16(�6S   5/      �� 51      $ 
Horizontal=�6   $
��0,10q�62   .+�52      �� $��Department:��6   $	��150��6/   $��Center=�6;   $��Cambria)�6V   $��16(�6k   �� 53      -   5        $ txtDepartment��53      $	��400��61   $��Cambria)�6=   $��16(�6R   54      �� 56      $ 
Horizontal=�6   $
��0,10q�62   .+�57      �� $��Address:��6   $	��150��6,   $��Center=�68   $��Cambria)�6S   $��16(�6h   �� 58      -   5        $ 
txtAddress��58      $	��400��6.   $��Cambria)�6:   $��16(�6O   59      �� 5;      -   5         ��Name$ btnAddStudent��5<      $��Add Student��5;      $	��150��5=      $��40��5>      $
��Left=�5?      ���#4A90E2
�������$��Cambria)�5B      $��16(�5C      $
��0,20q�5D      5E      5F      5G      5H      