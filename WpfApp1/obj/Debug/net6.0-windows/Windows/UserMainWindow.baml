   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApp1.WindowsWpfApp1.Windows  5   	   $    WpfApp1.Windows.UserMainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:WpfApp1.Windows     5   	   c _MaterialDesignThemes.MahApps, Version=0.3.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962a_ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962a<md1http://materialdesigninxaml.net/winfx/xaml/themes   5   	     � WindowStartupLocation$  CenterScreen=�5	   	    � Title$ UserMainWindow��5
   	   $	��550��6    $	��800��6-    � 	Resources 5       �� 
TargetType �� Property �� Value��%x   '��       �� 5   
   " ��6   .�5      ��  � ��$ 50��6'   �� 5       � ��
 �����6+   5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��150 �6   �� 5      �� 5      $	��220 �6   .+�5   
   �� $��0��6   
�������.+�5      �� -   5         ��Name$ userName��5      $��User : ��6*   
��� � �$
��Bold"�6L   $��8q�6^   6k   �� 5      -   5        $��Markets��5      6'   �� 5      $��About��6   �� 5      $��Contact��6   5      �� 5   
   $��1��6   .+�5      �� $	��466��6   .��5       �� -   5         ��Name$ ControllerOfMarkets��5    #   $
��Auto��6@   ��5!      �� 5"      .R�5#   "   A� $	��Top=�6.   	 A� Columns$	 2��6F   5$      5&      5'      ]� 5(      .+�5)      �� -   5        
 ��Name$
 openMarketAddPageBtn��5*      $��80��5+      $��30��5,      $��5q�5-      
��� � �$��90 0 0 0q�5/      $��AddMeal��51      �� 52      -   5        $
 
RefreshBtn��53      $��80��54      $��30��55      
��� � �$��Bottom=�57      $��Refresh��59      5:      5;       � 5<      -   5          �Name$ marketPageFrame��5=      $��2��5>      5?      5@      