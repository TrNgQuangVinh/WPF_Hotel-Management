   M S B A M L   `   `   `  ����  Assignment1!    Assignment1.GUI.AdminScreen   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	     � Title$  CustomerScreen��5   	   $
��auto��6    $
��auto��6.    � 
ResizeMode$ NoResize=�6;    � SizeToContent$ WidthAndHeight=�6Q    � WindowStartupLocation$ CenterScreen=�6p   .��5      � ���	#FFF0F0F0$
��1080��6"   $	��720��6/   .+�5	   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dgrRoomInfo��5	         SelectionMode$ Single=�6S   $��315,315,45,45q�6j   $��16(�6�      
IsReadOnly$
 True��6�   �� 5
   
   -   5         ��Name$ inpSearchType��5
       �� TextWrapping$
 Wrap=�6)   $��417,167,373,521q�6=   $��24(�6V   �� 5   
   $��Search for Room Type��6   $
��Left=�6/   $��158,159,0,0q�6J   $	��Top=�6_   $��40��6w   $	��254��6�   $��24(�6�   �� 5   
   -   5        	 ��Name$	 btnAdd��5      $��Add new Room��6!   $
��Left=�68   $��
65,315,0,0q�6S   $	��Top=�6g   $	��185��6   $��36��6�   $��24(�6�   6�   �� 5   
   -   5        $	 	btnUpdate��5      $��Update a Room��6$   $
��Left=�6<   $��
65,400,0,0q�6W   $	��Top=�6k   $	��185��6�   $��36��6�   $��24(�6�   6�   �� 5   
   -   5        $	 	btnDelete��5      $��Delete a Room��6$   $
��Left=�6<   $��
65,485,0,0q�6W   $	��Top=�6k   $	��185��6�   $��36��6�   $��24(�6�   6�   �� 5   
   -   5        $	 btnQuit��5      $
��Back��6"   $
��Left=�61   $��
65,639,0,0q�6L   $	��Top=�6`   $	��185��6x   $��36��6�   $��24(�6�   6�   �� 5   
   -   5        $	 	btnSearch��5      $��Search��6$   $
��Left=�65   $��757,209,0,0q�6P   $	��Top=�6e   $	��160��6}   $��36��6�   $��24(�6�   6�   �� 5   
   -   5        $ inpSearchPrice��5      $
 Wrap=�6*   $��417,214,483,474q�6>   $��24(�6W   6e   �� 5   
   $��Search for Room Price��6   $
��Left=�60   $��158,206,0,0q�6K   $	��Top=�6`   $��40��6x   $	��244��6�   $��24(�6�   �� 5   
   -	   5        
 ��Name$
 
ErrorLabel��5      $�� ��6$   $��Center=�6/   $��	0,269,0,0q�6L   $	��Top=�6_   $��16(�6w   
���  ��$
��Bold"�6�   �� 5   
   
���   �$��1q�6%   $
��Left=�69   $��98��6T   $��144,159,0,0q�6`   $	��Top=�6u   $	��816��6�   ._�5      �� -
   5        $	 btnTypeList��5      $��
Room Types��6*   $��613,9,42,56q�6?   $��20(�6T   6b   5      �� 5   
   
���   �$��1q�6%   $��Center=�69   $	��110��6V   $��0,24,0,0q�6c   $	��Top=�6u   $	��988��6�   
�������._�5      �� $��Hotel Manager��6   $��Center=�6,   $��83��6I   $��Center=�6U   $	��360��6p   $��48(�6|   $
��Bold"�6�   5      5      5      