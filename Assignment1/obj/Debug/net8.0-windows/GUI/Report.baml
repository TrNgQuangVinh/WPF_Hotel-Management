   M S B A M L   `   `   `  ����F  BAssignment1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Assignment1.GUIAssignment1.GUI  5   	       Assignment1.GUI.Report   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:Assignment1.GUI     5   	     � Title$  Window1��5   	   $
��auto��6   $
��auto��6'    � 
ResizeMode$ NoResize=�64    � SizeToContent$ WidthAndHeight=�6J    � WindowStartupLocation$ CenterScreen=�6i   .��5	      � $	��420��6   $��Center=�6   $	��600��65   ���	#FFF0F0F0.+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 	dgrReport��5
      $��0,-18,0,120q�6Q   6f   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ dpFrom��5      $
��Left=�6%   $��152,335,0,0q�6@   $	��Top=�6U     5   
   -   5        $
 dpTo��5      $
��Left=�6#   $��347,335,0,0q�6>   $	��Top=�6S   �� 5   
   -   5         ��Name$ 	btnReport��5      $��
Get Report��6$   $��Center=�69   $��	0,376,0,0q�6V   $	��Top=�6i   $��88��6�   $��28��6�   �� 5   
   $��From...��6   $
��Left=�6"   $��180,309,0,0q�6=   $	��Top=�6R    J� RenderTransformOrigin$ 0.19,-0.068&�6j   �� 5   
   $��...to��6   $
��Left=�6    $��375,309,0,0q�6;   $	��Top=�6P   $ 0.19,-0.068&�6h   5      5      