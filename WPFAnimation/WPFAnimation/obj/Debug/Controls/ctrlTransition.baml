   M S B A M L   `   `   `  ����G  CWPFAnimation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:WPFAnimation.ControlsWPFAnimation.Controls  5      *    $WPFAnimation.Controls.ctrlTransition   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:WPFAnimation.Controls     5      .��5
      �� -   5        $
��rect��5
      $	��100��5      $	��100��6   '  !System.Windows.VisualStateManager    VisualStateGroups  5   
   %  System.Windows.VisualStateGroup  5         Name$ MouseStates��6      States. 5         System.Windows.VisualState     Name$ 
MouseEnter��6      
Storyboard. 5      �� .��5      �� 	 �� To$ GreenX�6)    �� 
TargetName$ 	rectBrush��5       �� TargetProperty$ Color�5      5      5        5      $ 
MouseLeave��6      Transitions 5      %  System.Windows.VisualTransition  5      		   To$	 
MouseLeave��6'   
   GeneratedDuration$
 00:00:00D�67     5      $	 
MouseEnter��6'   $
 
00:00:00.5D�67      GeneratedEasingFunction 5      4  .System.Windows.Media.Animation.ExponentialEase  5      7  1System.Windows.Media.Animation.EasingFunctionBase   
EasingMode$ EaseOut=�6.      Exponent$ 10Q�6C   5      5"      ��5%   
   �� 5&      -   5        	rectBrush�� �� Color$	 Red��5&   1   5(      5)      