   M S B A M L   `   `   `  ����F  BAssignment1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Assignment1.GUIAssignment1.GUI  5   	   #    Assignment1.GUI.AccountDetail   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ] YXceed.Wpf.Toolkit.NET5, Version=4.6.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5   	   )localclr-namespace:Assignment1.GUI  5   	     � Title$  Window1��5	   	   $
��auto��6   $
��auto��6'    � 
ResizeMode$ NoResize=�64    � SizeToContent$ WidthAndHeight=�6J    � WindowStartupLocation$ CenterScreen=�6i   .��5
      � $	��401��6   $	��800��6   ���	#FFF0F0F0.+�5   
   �� $
��Left=�6   $	��269��6/   $��
40,100,0,0q�6<   
���   �$	��Top=�6_   $	��596��6w   �� 5   
   $��Account Info��6   $
��Left=�6'   $��	70,84,0,0q�6B   $	��Top=�6U   ���	#FFF0F0F0$��28��6�   $	��108��6�   $��16(�6�   $
��Bold"�6�   �� 5   
   $��Account Details��6   $
��Left=�6*   $��	40,21,0,0q�6E   $	��Top=�6X   ���	#FFF0F0F0$��36(�6�   $
��Bold"�6�   �� 5   
   -   5         ��Name$ inpCusID��5      $
��Left=�6$   $��159,133,0,0q�6?    �� TextWrapping$
 Wrap=�6T   $	��Top=�6h   $	��120��6�   $��28��6�    �� 
IsReadOnly$
 True��6�   �� 5   
   -   5        $ inpPhoneNum��5      $
��Left=�6'   $��451,133,0,0q�6B   $
 Wrap=�6W   $	��Top=�6k   $	��120��6�   $��28��6�   �� 5   
   -   5        $ inpEmail��5      $
��Left=�6$   $��159,179,0,0q�6?   $
 Wrap=�6T   $	��Top=�6h   $	��412��6�   $��26��6�   $��Disabled=�5      $
��Auto=�5      �� 5   
   -   5        $ inpFullName��5      $
��Left=�6'   $��159,225,0,0q�6B   $
 Wrap=�6W   $	��Top=�6k   $	��228��6�   $��28��6�   �� 5   
   $��Customer ID��6   $
��Left=�6&   $��
62,134,0,0q�6A   $	��Top=�6U   $
��Bold"�6m   �� 5   
   $�� Phone Number��6   $
��Left=�6(   $��338,134,0,0q�6C   $	��Top=�6X   $
��Bold"�6p   �� 5   
   $��Email Address��6   $
��Left=�6(   $��
61,179,0,0q�6C   $	��Top=�6W   $
��Bold"�6o   �� 5   
   $��	Full Name��6   $
��Left=�6$   $��
62,227,0,0q�6?   $	��Top=�6S   $
��Bold"�6k   �� 5   
   $��Birthday��6   $
��Left=�6#   $��
62,274,0,0q�6>   $	��Top=�6R   $
��Bold"�6j   �� 5   
   $��Password��6   $
��Left=�6#   $��
62,316,0,0q�6>   $	��Top=�6R   $
��Bold"�6j   �� 5   
   -   5         ��Name$ btnSave��5      $
��Save��6"   $
��Left=�61   $��681,114,0,0q�6L   $	��Top=�6a   $��85��6y   $��29��6�   6�   �� 5   
   -   5        $ btnClose��5      $��Close��6#   $
��Left=�63   $��681,170,0,0q�6N   $	��Top=�6c   $��85��6{   $��29��6�   6�   �� 5   
   -   5        $ hiddenAction��5      $
��Left=�6(   $��799,449,0,0q�6C   $
 Wrap=�6X   $��TextBox��6l   $	��Top=�6{   $��1��6�   $��1��6�   $
 True��6�   
�������6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ dateBirthday��5      $
��Left=�6+   $��159,274,0,0q�6F   $	��Top=�6[   $	��136��6s   G� 5   
   -	   5        	 G�Name$	 pwdBox��5      $
��Left=�6&   $��159,316,0,0q�6A   $	��Top=�6V   $	��228��6n   $��26��6z   �� 5   
   -
   5        $ 	btShowPwd��5      $
��Show��6$   $
��Left=�63   $��26��6N   $��400,316,0,0q�6Z   $	��Top=�6o   $��54��6�   6�   �� 5    
   -   5        $ inpPwdVisible��5       $
��Left=�6)   $��26��6D   $��159,316,0,0q�6P   $
 Wrap=�6e   $	��Top=�6y   $	��228��6�   6�   5!      5"      