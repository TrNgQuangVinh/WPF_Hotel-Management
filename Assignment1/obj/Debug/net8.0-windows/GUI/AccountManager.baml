   M S B A M L   `   `   `  ����  Assignment1$    Assignment1.GUI.AccountManager   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	     � Title$  CustomerScreen��5   	   $
��auto��6    $
��auto��6.    � 
ResizeMode$ NoResize=�6;    � SizeToContent$ WidthAndHeight=�6Q    � WindowStartupLocation$ CenterScreen=�6p   .��5      � ���	#FFF0F0F0$
��1080��6"   $	��720��6/   .+�5	   
   �� 
���   �$��1q�6%   $
��Left=�69   $��98��6T   $��144,159,0,0q�6`   $	��Top=�6u   $	��816��6�   &   System.Windows.Controls.DataGrid  5
   
   -   5          Name$ dgrCustInfo��5
         SelectionMode$ Single=�6(   $��315,315,45,45q�6?   $��16(�6r      
IsReadOnly$
 True��6�      AutoGenerateColumns$ False��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 ID��6D   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6%   �� *
CustomerId+6D     5      $	 	Full Name��6J   
 6%   �� *CustomerFullName+6J     5      $	 	Telephone��6C   
 6%   �� *	Telephone+6C     5      $	 Email Address��6F   
 6%   �� *EmailAddress+6F     5      $	 Birthday��6J   
 6%   �� *CustomerBirthday+6J     5      $	 Status��6H   
 6%   �� *CustomerStatus+6H     5      $	 Password��6B   
 6%   �� *
Password+6B   5      �� 5   
   -   5         ��Name$ inpSearchName��5       �� TextWrapping$
 Wrap=�6)   $��427,167,335,521q�6=   $��24(�6V   �� 5   
   $��Search Customer Name��6   $
��Left=�6/   $��158,159,0,0q�6J   $	��Top=�6_   $��40��6w   $	��264��6�   $��24(�6�   �� 5   
   -   5         ��Name$ btnAdd��5      $��Create account��6!   $
��Left=�6:   $��
65,315,0,0q�6U   $	��Top=�6i   $	��185��6�   $��36��6�   $��24(�6�   6�   �� 5   
   -   5        $ 	btnUpdate��5      $��Update account��6$   $
��Left=�6=   $��
65,400,0,0q�6X   $	��Top=�6l   $	��185��6�   $��36��6�   $��24(�6�   6�   �� 5   
   -   5        $ 	btnDelete��5      $��Delete account��6$   $
��Left=�6=   $��
65,485,0,0q�6X   $	��Top=�6l   $	��185��6�   $��36��6�   $��24(�6�   6�   �� 5   
   -   5        $ btnQuit��5      $
��Back��6"   $
��Left=�61   $��
65,639,0,0q�6L   $	��Top=�6`   $	��185��6x   $��36��6�   $��24(�6�   6�   �� 5   
   -   5        $ 	btnSearch��5      $��Search��6$   $
��Left=�65   $��768,189,0,0q�6P   $	��Top=�6e   $	��160��6}   $��36��6�   $��24(�6�   6�   �� 5   
   -   5        $ inpSearchEmail��5      $
 Wrap=�6*   $��427,213,335,475q�6>   $��24(�6W    J� RenderTransformOrigin$ 0.507,0.511&�6e   �� 5   
   $��Search for Email��6   $
��Left=�6+   $��158,206,0,0q�6F   $	��Top=�6[   $��40��6s   $	��244��6   $��24(�6�   �� 5   
   -	   5         ��Name$ 
ErrorLabel��5      $�� ��6$   $��Center=�6/   $��	0,269,0,0q�6L   $	��Top=�6_   $��16(�6w   
���  ��$
��Bold"�6�   �� 5   
   
���   �$��1q�6%   $��Center=�69   $	��110��6V   $��0,24,0,0q�6c   $	��Top=�6u   $	��988��6�   
�������._�5       �� $��Account Manager��6   $��Center=�6.   $��82��6K   $��Center=�6W   $	��411��6r   $��48(�6~   $
��Bold"�6�   5!      5"      5#      