   M S B A M L   `   `   `  ����I  EDesktopProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:DesktopProjectDesktopProject  5          DesktopProject.AdminPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:DesktopProject     5        N� Title$  	AdminPage��5	       N� 
Background
 �����.��5      �  � RowDefinitions 5   
   �� 5      $��60 �6   �� 5      �� 5      .+�5   
   �� $��0��6   ���	#FFC5C5C55      �� 5   
   -   5        $��	txtSearch��5      $��Center=�6#    �� TextWrapping$
 Wrap=�6@   $��Center=�6T   $	��158��6o   $��30��6{   �� 5   
   -   5        $��SEARCH��5      $
��Left=�6%   $��Center=�6@   $��86��6[   $��32��6f   $
��Bold"�6r   $��17(�6�   
�������
���   �$��	380,0,0,0q�6�   6�   �� 5   
   $
��Left=�6   $��	10,28,0,0q�6.   $	��Top=�6A   $	��120��6Y   �� 5   
   $��Student ID : ��6   $��1��6(   $��10,18,371,86q�65   $��15(�6K   $
��Bold"�6Y   �� 5   
   -   5        $��txtStudentID��5      $
��Left=�6&   $��
120,20,0,0q�6A   $��1��6U   $
 Wrap=�6b   $	��Top=�6w   $	��158��6�   $��30��6�   �� 5   
   $��Department : ��6   $��1��6(   $��10,72,371,31q�65   $��15(�6K   $
��Bold"�6Y   �� 5   
   -   5        $��txtDepartment��5      $
��Left=�6'   $��
120,75,0,0q�6B   $��1��6V   $
 Wrap=�6c   $	��Top=�6x   $	��158��6�   $��30��6�   �� 5   
   -   5        $��DELETE��5      $
��Left=�6"   $��1��6>   $	��Top=�6K   $��86��6c   $��32��6n   $
��Bold"�6z   $��17(�6�   
�������
���   �$��
384,18,0,0q�6�   6�   �� 5   
   $
��EDIT��6   $
��Left=�6    $��1��6<   $	��Top=�6I   $��86��6a   $��32��6l   $
��Bold"�6x   $��17(�6�   
�������
���   �$��
384,70,0,0q�6�   &   System.Windows.Controls.DataGrid  5   
   -   5        $��StudentDataGrid��5      $��1��6*   $��
23,129,0,0q�67   $��2��6K   5      5       5!      