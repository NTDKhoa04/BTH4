   M S B A M L   `   `   `  ����@  <Bai05, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Bai05Bai05  5   	       Bai05.CreateWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Bai05     5   	   $��20(�5   	     � Title$  CreateWindow��5	   	   $	��450��6   $	��800��6+   .��5
      �  � RowDefinitions 5   
   �� 5      $��2* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��2* �6   �� 5      $��4* �6   .+�5   
   �� $��0��6   $��0��6%    �� Orientation$ Vertical=�62   $��50 0 0 0q�6I   $��Bottom=�6[   .+�5      �� $ 
Horizontal=�6   $��10q�62   .+�5      �� $��Mã số sinh viên��6   5      �� 5      $ 
Horizontal=�6   $��10q�62   .+�5      �� $��Tên sinh viên��6   5      �� 5      $ 
Horizontal=�6   $��10q�62   .+�5      �� $
��Khoa��6   5      �� 5      $ 
Horizontal=�6   $��10q�62   .+�5       �� $��Điểm trung bình��6   5!      5"      �� 5#   
   $
��auto��6   $��1��6"   $��0��62   $ Vertical=�6?   $
��Left=�6V   $��Bottom=�6q   .+�5$      �� $ 
Horizontal=�6   $��10q�62   .+�5%      �� -   5         ��Name$ MaSoSinhVien��5%      $	��300��60   $
��1.25q�6<   
���   �6S   5&      �� 5'      $ 
Horizontal=�6   $��10q�62   .+�5(      �� -   5        $ TenSinhVien��5(      $	��300��6/   $
��1.25q�6;   
���   �6R   5)      �� 5*      $ 
Horizontal=�6   $��10q�62   .+�5+      �� -   5         ��Name$
 Khoa��5+      $	��300��6*   $
��1.25q�66   
���   �.@�5,      �� $��Khoa học máy tính��6$   �� 5-      $��Công nghệ phần mềm��6#   �� 5.      $��Kỹ thuật máy tính��6#   �� 5/      $��An toàn thông tin��6#   �� 50      $*��$Mạng máy tính và tuyền thông��6#   52      53      �� 54      $ 
Horizontal=�6   $��10q�62   .+�55      �� -   5        $ DiemTb��55      $	��300��6*   $
��1.25q�66   
���   �6M   56      58      � 5:   
   $��1��6   $��1��6   .+�5;      �� $ 
Horizontal=�6   $��
135 10 0 0q�62   $	��Top=�6F   .+�5<      �� -   5        $��Thêm Mới��5<      $��5q�6,   
���/���6Q   �� 5=      -   5        $��Thoát��5=      $��10 0 0 0q�6)   $��5q�6;   
��� ���6[   5?      5@      5B      5C      