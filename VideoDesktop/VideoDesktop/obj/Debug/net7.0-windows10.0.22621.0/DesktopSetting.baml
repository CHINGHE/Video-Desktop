   M S B A M L   `   `   `  ����G  CVideoDesktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:VideoDesktopVideoDesktop  5   	   !    VideoDesktop.DesktopSetting   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:VideoDesktop     5   	   -   5          � Icon$/  )pack://application:,,,/Resources/logo.ico��5   	    � Title$ DesktopSetting��5	   	   $	��450��6    $	��800��6-   .��5
      � .+�5   
   ]� .+�5      o� -   5         o�Name$ SettingMenu��5   (   $	��Top=�6   .@�5      m� $��_File��6   .@�5      m� $
��_New��6   m� 5      -   5         m�Name$ m_play��5   -   $
��Play��6   6-   m� 5      $��_Open��6   m� 5      $��_Save��6   �� 5      m� 5      $��_Exit��6   5      5      5      �� 5   
   -   5         ��Name$ btnOpenFile��5      $��打开文件��6&   $
��Left=�65   $	��Top=�6R   $��36��6j   $	��112��6v   6�   �� 5   
   -   5        $ btnPlay��5      $��播放��6"   $
��Left=�6/   $	��Top=�6L   $��36��6d   $	��131��6p   $��	140,0,0,0q�6�   �� 5   
   -   5        $ btnClose��5      $��关闭��6#   $
��Left=�60   $	��Top=�6M   $��37��6e   $	��130��6q   $��	289,0,0,0q�6�   �� 5   
   -   5         ��Name$ 	checkMute��5      $��静音��6&   $��25,72,688,348q�63   �� 5    
   -   5        $ checkAutoPlay��5       $��启动后自动播放��6*   $��117,72,542,348q�6<   �� 5!   
   -	   5         ��Name$ label1��5!      $�� ��6    $��25,108,634,296q�6+   5"      5#      