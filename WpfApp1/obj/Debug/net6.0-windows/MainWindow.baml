   M S B A M L   `   `   `  ����  WpfApp1    WpfApp1.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   c _MaterialDesignThemes.MahApps, Version=0.3.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962a_ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962a<md1http://materialdesigninxaml.net/winfx/xaml/themes   5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ Authorization��5   	   $	��600��6   $	��800��6,   .��5      � 
�������.+�5	   
   �� $	��400��6   $��15q�6    ���#FFFF$��Center=�5
       �� Padding$ 40q�6,   $	��550��69    �� CornerRadius$ 20��5       J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 30Q�6#      Color$ 	LightGray��63      ShadowDepth$ 0Q�5   #   ._�5      �� $��1��6    �� Orientation$ Vertical=�6&   $��Center=�6=   $��Center=�6X   .+�5      �� -   5        	 ��Name$	 logintxt��5   C   .  (MaterialDesignThemes.Wpf.TextFieldAssist
   HasClearButton$

 True��6   $	��250��6U   $��40��6a    %  !MaterialDesignFloatingHintTextBox#��[  6m   .��6�   )  #MaterialDesignThemes.Wpf.HintAssist   Hint 5      �� 5      $ 
Horizontal=�6%   .+�5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 User=�6*   $��Center=�66   �� 5      $�� login��6(   5      .��5   *   5      G� 5      -   5         G�Name$ passwordtxt��5      $	��250��63   $��40��6?    / +MaterialDesignFloatingHintRevealPasswordBox#��[ 5      $

 True��5      0  *MaterialDesignThemes.Wpf.PasswordBoxAssist   Password$  ��5       5      �� 5      $ 
Horizontal=�6%   .+�5         $	 Key=�6*   $��Center=�65   �� 5!      $��	 password��6(   5"      5$      �� 5%      -   5         ��Name$ rememberCheckBox��5%      $��Remember me��65   $
��0 10q�6K   6Y   �� 5&      $ 
Horizontal=�6   $
��0 20q�66   .+�5'      �� -   5         ��Name$ loginButton��5'      $��Login��62   $	��100��6B   $��30��6N   $��0 0 20 0q�6Z   6l   �� 5(      -   5        $ registerButton��5(      $��Register��65   $	��100��6H   $��30��6T   6`   5)      5*      5+      5,      5-      