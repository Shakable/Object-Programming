   M S B A M L   `   `   `  ����M  IHarjoitus17_WPF_KT, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Harjoitus17_WPF_KTHarjoitus17_WPF_KT  5   	   #    Harjoitus17_WPF_KT.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Harjoitus17_WPF_KT     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �� -   5         ��Name$ keittioValo��5
      $��Keittiön valot��6&   $
��Left=�6?   $��160,-75,0,0q�6Z   $��center=�6o   $��50��6�   $	��180��6�   $��29(�6�   6�   �� 5   
   -   5        $ olohuoneValo��5      $��Olohuoneen valot��6'   $
��Left=�6B   $��
160,50,0,0q�6]   $��Center=�6q   $��50��6�   $	��180��6�   $��20(�6�   6�   �� 5   
   -   5        $ oviLukko��5      $��
Oven lukko��6#   $
��Left=�68   $��160,175,0,0q�6S   $��Center=�6h   $��50��6�   $	��180��6�   $��34(�6�   6�   �� 5   
   -   5         ��Name$ text_keittioValo��5      $
��Left=�6,   $��370,-75,0,0q�6G    �� TextWrapping$
 Wrap=�6\   $��Pois päältä��6p   $��Center=�6�   $��50��6�   $	��180��6�   $��34(�6�   �� 5   
   -   5        $ text_olohuoneValo��5      $
��Left=�6-   $��
370,50,0,0q�6H   $
 Wrap=�6\   $��Pois päältä��6p   $��Center=�6�   $��50��6�   $	��180��6�   $��34(�6�   �� 5   
   -   5        $ text_oviLukko��5      $
��Left=�6)   $��370,175,0,0q�6D   $
 Wrap=�6Y   $��
Ei lukittu��6m   $��Center=�6   $��50��6�   $	��180��6�   $��34(�6�   �� 5   
   -   5        $ temperature_down��5      $��-1°C��6+   $
��Left=�6:   $��215,100,0,0q�6U   $	��Top=�6j   $��70��6�   $��30��6�   $��20(�6�   6�   �� 5   
   -   5        $ temperature_up��5      $��+1°C��6)   $
��Left=�68   $��425,100,0,0q�6S   $	��Top=�6h   $��70��6�   $��30��6�   $��20(�6�   6�   �� 5   
   -	   5        $ text_temperature��5      $
��Left=�6,   $
 Wrap=�6G   $��31 °C��6[   $	��Top=�6h   $	��100��6�   $��
310,90,0,0q�6�   $��50��6�   $��35(�6�   5      5      