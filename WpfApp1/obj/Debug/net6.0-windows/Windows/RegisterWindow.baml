   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApp1.WindowsWpfApp1.Windows  5   	   $    WpfApp1.Windows.RegisterWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   c _MaterialDesignThemes.MahApps, Version=0.3.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962a_ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962a<md1http://materialdesigninxaml.net/winfx/xaml/themes   5   	   +localclr-namespace:WpfApp1.Windows   5   	     � WindowStartupLocation$  CenterScreen=�5	   	    � Title$ RegisterWindow��5
   	   $	��450��6    $	��800��6-   .��5      � 
�������.+�5   
   �� $	��400��6   $��15q�6    ���#FFFF$��Center=�5       �� Padding$ 40q�6,   $	��550��69    �� CornerRadius$ 20��5       J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 30Q�6#      Color$ 	LightGray��63      ShadowDepth$ 0Q�5   #   ._�5      �� $��1��6    �� Orientation$ Vertical=�6&   $��Center=�6=   $��Center=�6X   .+�5      �� -   5        	 ��Name$	 loginBox��5   C   .  (MaterialDesignThemes.Wpf.TextFieldAssist
   HasClearButton$

 True��6   $	��250��6U   $��40��6a    %  !MaterialDesignFloatingHintTextBox#��[  6m   .��6�   )  #MaterialDesignThemes.Wpf.HintAssist   Hint 5      �� 5      $ 
Horizontal=�6%   .+�5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 User=�6*   $��Center=�66   �� 5      $�� login��6(   5      .��5   *   5      G� 5      -   5         G�Name$ regPassword��5      $	��250��63   $��40��6?    / +MaterialDesignFloatingHintRevealPasswordBox#��[ 5      $

 True��5      0  *MaterialDesignThemes.Wpf.PasswordBoxAssist   Password$  ��5        5!      �� 5"      $ 
Horizontal=�6%   .+�5#        $	 Key=�6*   $��Center=�65   �� 5$      $��	 password��6(   5%      5'      G� 5(      -   5        $ regRepeatPassword��5(      $	��250��69   $��40��6E   #��[ 5)      $

 True��5*      $  ��5+       5,      �� 5-      $ 
Horizontal=�6%   .+�5.        $	 Key=�6*   $��Center=�65   �� 5/      $�� repeat password��6(   50      52      �� 53      $ 
Horizontal=�6   $
��0 20q�66   .+�54      �� -   5         ��Name$ registerButton��54      $��Register��65   $	��250��6H   $��30��6T   6`   55      ]� 56      .+�57      �� $"��I have already registered : ��6   $��	35 3 35 0q�6@   $��10(�6S   6c   �� 58      -   5        $ registerLoginButton��58      $��Login��6:   $��10(�6J   $��60��6X   
�������
���   �$��20��6�   $��	-75 0 0 0q�6�   $	��-15q�6�   6�   59      5:      5;      5<      5=      