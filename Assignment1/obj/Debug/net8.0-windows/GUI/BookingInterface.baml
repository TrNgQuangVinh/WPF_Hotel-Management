   M S B A M L   `   `   `  ����F  BAssignment1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Assignment1.GUIAssignment1.GUI  5   	   &     Assignment1.GUI.BookingInterface   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:Assignment1.GUI     5   	     � Title$  BookingInterface��5   	   $
��auto��6"   $
��auto��60    � 
ResizeMode$ NoResize=�6=    � SizeToContent$ WidthAndHeight=�6S    � WindowStartupLocation$ CenterScreen=�6r   .��5	      � $	��720��6   $
��Left=�6   $
��1080��63   ���	#FFF0F0F0.+�5
   
   �� $
��Left=�6   $	��451��6/   $��350,227,0,0q�6<   
���   �$	��Top=�6`   $	��678��6x   �� 5   
   $
��Left=�6   $	��226��6/   $��
52,346,0,0q�6<   
���   �$	��Top=�6_   $	��272��6w   �� 5   
   
���   �$��1q�6%   $��Center=�69   $	��150��6V   $��0,30,0,0q�6c   $	��Top=�6u   $	��976��6�   
�������._�5      �� $��Booking Manager��6   $��309,37,309,37q�6.   $��48(�6E   $��Impact)�6S   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgrRoomInfo��5      $
��Left=�6(   $	��181��6C   $��393,258,0,0q�6P   $	��Top=�6e   $	��600��6}      SelectionMode$ Single=�6�      
IsReadOnly$
 True��6�   6�   �� 5   
   $
��Left=�6   $	��165��6/   $��393,482,0,0q�6<   
���   �$	��Top=�6`   $	��600��6x   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ dateCheckin��5      $
��Left=�6*   $��562,502,0,0q�6E   $	��Top=�6Z   �� 5   
   $��Check-in date��6   $
��Left=�6(   $��428,498,0,0q�6C   $	��Top=�6X   $��16(�6p   �� 5   
   $��Check-out date��6   $
��Left=�6)   $��725,498,0,0q�6D   $	��Top=�6Y   $��16(�6q     5   
   -   5        $ dateCheckout��5      $
��Left=�6+   $��860,502,0,0q�6F   $	��Top=�6[   �� 5   
   -   5         ��Name$ txtPrice��5      $
��Left=�6&   $��637,531,0,0q�6A   $
��Wrap=�6V   $��Price:��6j   $	��Top=�6x   $��41��6�   $	��112��6�   	 �� TextAlignment$	 Center=�6�   
���  ��$
��Bold"�6�   $��16(�6�   
 J� RenderTransformOrigin$
 0.499,0.521&�6�   �� 5   
   -   5        $ txtTotal��5      $
��Left=�6&   $��132,508,0,0q�6A   $
��Wrap=�6V   $��Total price:��6j   $	��Top=�6~   $��56��6�   $	��112��6�   $	 Center=�6�   
���  ��$
��Bold"�6�   $��16(�6�   $
 0.737,1.101&�6�   �� 5   
   -   5         ��Name$ btnBook��5      $
��Book��6"   $
��Left=�61   $��562,593,0,0q�6L   $	��Top=�6a   $��38��6y   $	��102��6�   $��16(�6�   $
 0.161,0.585&�6�   6�   �� 5   
   -   5        $ btnReset��5      $��Reset��6#   $
��Left=�63   $��733,593,0,0q�6N   $	��Top=�6c   $��38��6{   $	��102��6�   $��16(�6�   $
 0.161,0.585&�6�   �� 5   
   -   5        $ btnBack��5      $
��Back��6"   $
��Left=�61   $��141,632,0,0q�6L   $	��Top=�6a   $��46��6y   $��94��6�   $��16(�6�   $
��Bold"�6�   6�   �� 5   
   -	   5        $ txtError��5      $
��Left=�6&   $��759,689,0,0q�6A   $
��Wrap=�6V   $��Error��6j   $	��Top=�6w   $��20��6�   $	��303��6�   
���  ��$��16(�6�   $	 Right=�6�   $
��Bold"�6�   �� 5   
   -
   5        $ hiddenContinue��5      $
��Left=�6,   $��	0,719,0,0q�6G   $
��Wrap=�6Z   $��	TextBlock��6n   $	��Top=�6   $��1��6�   $��2��6�   $
 0.5,0.5&�6�   z�5      V� 5      .~�5      ��  �� ScaleY$ 1Q�6%   �� 5      �� 5       T� 5!      5"      5$        5%   
   -   5        $ 
dgrBooking��5%      $
��Left=�6'   $	��143��6B   $��
65,360,0,0q�6O   $	��Top=�6c   $	��246��6{   6�   �� 5&   
   -   5         ��Name$ inpSearchRsv��5&      $
��Left=�6(   $��
52,258,0,0q�6C    �� TextWrapping$
 Wrap=�6W   $��TextBox��6k   $	��Top=�6z   $	��272��6�   $��25��6�   �� 5'   
   $'��!Find reservation by customer name��6   $
��Left=�6<   $��
74,224,0,0q�6W   $	��Top=�6k   $��14(�6�   �� 5(   
   -   5        $ btSearchName��5(      $��Search!��6'   $
��Left=�69   $��148,298,0,0q�6T   $	��Top=�6i   $��33��6�   $��80��6�   6�   5)      5*      