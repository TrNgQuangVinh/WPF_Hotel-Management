   M S B A M L   `   `   `  ����  Assignment1    Assignment1.GUI.Login   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	     � Title$  Login��5   	   $
��auto��6   $
��auto��6%    � 
ResizeMode$ NoResize=�62    � SizeToContent$ WidthAndHeight=�6H    � WindowStartupLocation$ CenterScreen=�6g   .��5	      � -   5         �Name$ grid_big��5	      $	��350��6   $	��450��6*    � RowDefinitions 5
   
   �� 5      �� 5      �� 5      �� 5      .+�5   
   �� -   5         ��Name$ inpEmail��5      $
��Left=�6$   $��91,0,0,0q�6?    �� TextWrapping$
 Wrap=�6Q   $��Center=�6e   $	��322��6�   $��28��6�   $��1��6�   G� 5   
   -   5         G�Name$ inpPassword��5      $
��Left=�6+   $��	118,0,0,0q�6F   $��2��6Y   $��Center=�6f   $	��295��6�   $��28��6�   �� 5   
   $��Email��6   $
��Left=�6    $��22,0,0,0q�6;   $��Center=�6M   $��16(�6h   $��1��6v   $��28��6�   �� 5   
   $%��FU Mini Hotel Management System��6   $��51,18,37,18q�6:   $��Impact)�6O   $��24(�6c   �� 5   
   $��Password��6   $
��Left=�6#   $��22,0,0,0q�6>   $��Center=�6P   $��16(�6k   $��2��6y   $��28��6�   � 5   
   -   5        $ 
grid_small��5      $��3��6#   	 � ColumnDefinitions	 5      �� 5      �� 5      �� 5      .+�5      �� -   5        
 ��Name$
 btnLogin��5      $��Login��6'   $��Center=�67   $��Center=�6T   $��36��6o   $��65��6{   6�   �� 5      -   5        $
 btnReset��5      $��Reset��6'   $��Center=�67   $��Center=�6T   $��36��6o   $��66��6{   $��2��6�   �� 5      -   5        $
 btnTestConn��5      $��Center=�6*   $��Center=�6G   $��36��6b   $��66��6n   $��1��6y   .��5      �� $��Test Connection��6   $��62��62   $��26��6=   5      5       5$      5%      