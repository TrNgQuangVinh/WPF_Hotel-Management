   M S B A M L   `   `   `  ����F  BAssignment1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Assignment1.GUIAssignment1.GUI  5   	   !    Assignment1.GUI.HotelDetail   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ] YXceed.Wpf.Toolkit.NET5, Version=4.6.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5   	   )localclr-namespace:Assignment1.GUI  5   	     � Title$  Window1��5	   	   $
��auto��6   $
��auto��6'    � 
ResizeMode$ NoResize=�64    � SizeToContent$ WidthAndHeight=�6J    � WindowStartupLocation$ CenterScreen=�6i   .��5
      � $	��450��6   $	��800��6   ���	#FFF0F0F0.+�5   
   �� $
��Left=�6   $	��320��6/   $��
40,100,0,0q�6<   
���   �$	��Top=�6_   $	��596��6w   �� 5   
   $��	Room Info��6   $
��Left=�6$   $��	70,84,0,0q�6?   $	��Top=�6R   ���	#FFF0F0F0$��28��6�   $��91��6�   $��16(�6�   $
��Bold"�6�   �� 5   
   $��Add/Update a Room��6   $
��Left=�6,   $��	40,21,0,0q�6G   $	��Top=�6Z   ���	#FFF0F0F0$��36(�6�   $
��Bold"�6�   �� 5   
   -   5         ��Name$ 	inpRoomID��5      $
��Left=�6%   $��159,133,0,0q�6@    �� TextWrapping$
 Wrap=�6U   $	��Top=�6i   $	��120��6�   $��28��6�    �� 
IsReadOnly$
 True��6�   �� 5   
   -   5        $ 
inpRoomNum��5      $
��Left=�6&   $��451,133,0,0q�6A   $
 Wrap=�6V   $	��Top=�6j   $	��120��6�   $��28��6�   �� 5   
   -   5        $ inpRoomDesc��5      $
��Left=�6'   $��159,176,0,0q�6B   $
 Wrap=�6W   $	��Top=�6k   $	��412��6�   $��84��6�   $��Disabled=�5      $
��Auto=�5      �� 5   
   -   5        $ 
inpRoomCap��5      $
��Left=�6&   $��159,278,0,0q�6A   $
 Wrap=�6V   $	��Top=�6j   $	��120��6�   $��28��6�   �� 5   
   -   5        $ inpRoomPrice��5      $
��Left=�6(   $��451,278,0,0q�6C   $
 Wrap=�6X   $	��Top=�6l   $	��120��6�   $��28��6�   	� 5   
   -   5         	�Name$ 
rdbtVacant��5       	� 	GroupName$ Status��6*   $��Vacant��6=   $
��Left=�6N   $	��Top=�6i   $��159,363,0,0q�6�   	� 5   
   -   5        $ rdbtOccupied��5      $ Status��6,   $��Occupied��6?   $
��Left=�6R   $��280,363,0,0q�6m   $	��Top=�6�   �� 5   
   $��Room ID��6   $
��Left=�6"   $��
62,134,0,0q�6=   $	��Top=�6Q   $
��Bold"�6i   �� 5   
   $��Room Number��6   $
��Left=�6&   $��338,134,0,0q�6A   $	��Top=�6V   $
��Bold"�6n   �� 5   
   $��Description��6   $
��Left=�6&   $��
61,176,0,0q�6A   $	��Top=�6U   $
��Bold"�6m   �� 5   
   $��Max Capacity��6   $
��Left=�6'   $��
62,279,0,0q�6B   $	��Top=�6V   $
��Bold"�6n   �� 5   
   $��Price��6   $
��Left=�6    $��393,279,0,0q�6;   $	��Top=�6P   $
��Bold"�6h   �� 5   
   $��	Room Type��6   $
��Left=�6$   $��
62,316,0,0q�6?   $	��Top=�6S   $
��Bold"�6k   �� 5   
   $��Room Status��6   $
��Left=�6&   $��
62,358,0,0q�6A   $	��Top=�6U   $
��Bold"�6m   �� 5   
   -   5        	 ��Name$	 cboRoomType��5      $
��Left=�6(   $��159,318,0,0q�6C   $	��Top=�6X   $	��190��6p   $��28��6|   6�   �� 5   
   -	   5        
 ��Name$
 btnSave��5      $
��Save��6"   $
��Left=�61   $��681,114,0,0q�6L   $	��Top=�6a   $��85��6y   $��29��6�   6�   �� 5    
   -
   5        $
 btnClose��5       $��Close��6#   $
��Left=�63   $��681,170,0,0q�6N   $	��Top=�6c   $��85��6{   $��29��6�   6�   �� 5!   
   -   5        $ hiddenAction��5!      $
��Left=�6(   $��799,449,0,0q�6C   $
 Wrap=�6X   $��TextBox��6l   $	��Top=�6{   $��1��6�   $��1��6�   $
 True��6�   
�������6�   5"      5#      