   M S B A M L   `   `   `  ����D  @dbplayers, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:dbplayers	dbplayers  5          dbplayers.AdmTP   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:dbplayers     5        N� Title$  AdmTP��5	       N� 
Background �	#FF000632 � 	Resources 5
       �� 
TargetType �� 
ResourceId �� TypeInTargetAssembly&   System.Windows.Controls.DataGrid �� Property �� Value �� 
TargetType	 ��Name
 J� SnapsToDevicePixels �Name J� Opacity � Points �� Stretch �� Triggers P� Property P� Value �� 
TargetName   DataGridStyle1 �� Padding ��Name � ColumnDefinitions � RowDefinitions   SelectAllCommand7  1System.Windows.Controls.DataGridHeadersVisibility
   All �� ConverterParameter!   HeadersVisibilityConverter �� 	Converter �� RelativeSource �� AncestorTypeG  ASystem.Windows.Controls.Primitives.DataGridColumnHeadersPresenter  Name   Column  ��Name! �� CanContentScroll" ��Name# �� ScrollableHeight$ � Maximum% �� Orientation*& �� #ComputedVerticalScrollBarVisibility' �� ViewportHeight( �� ViewportSize) � Value* �� Mode+ �� ScrollableWidth,, �� %ComputedHorizontalScrollBarVisibility- �� ViewportWidth. �� Triggers/ ]� 
Conditions0 �� Property1 �� Value��%8  (��       5      $" DataGridSelectAllButtonStyle��"  )&	  �    �� 6
   " ��6   .�5      ��  � �� 5      �� 5      " ��6&   .R�5      � .+�5      �� $	 Border��6(   #��� ��68   
 . 6y   � 5      $ Arrow��6&   
���   �$��Right=�6B   $��8,8,3,3q�6^   $
 0.15Q�6o    �   ��� ��� ��� ��� $ Uniform=�6�   $��Bottom=�6�   5       5      P� 5       �@J�IsMouseOver . . �5   "   �� $ Border��6;   # � ��6O    � ��5      P� 5       � �� . . �5   "   �� $ Border��69   # � ��6M    � ��5      P� 5       � {� .  . �5   "   �� $ Arrow��6?    � y�$ 	Collapsed=�6R   5      5      5       5!      �� 5"   
   "  6'   .�5#      ��  � ��# � ��6+   �� 5$       � ��# � ��6+   �� 5%       � ��
 ��� �6,   �� 5&       � ��$ 0q�60   �� 5'        �@ RowDetailsVisibilityMode$ VisibleWhenSelected=�69   �� 5(       � �� . 6>   �� 5)       �@��PanningMode$
 Both=�69   �� 5*       �@��IsFlicksEnabled .  67   �� 5+       � �� 5,      �� 5-      "  6&   .R�5.      �� #��z��6!   #��z��6M   #��z��6�   # z��6�   
 . ._�5/      �� $ DG_ScrollViewer��6+   |�.  ��50   "   �� 51   &   " ��66   .R�52   *   �  53   .   �� 54   2   $
��Auto �6C   �� 55   2   $��* �6C   �� 56   2   $
��Auto �6C    58   .   �� 59   2   $
��Auto �6@   �� 5:   2   $��* �6@   �� 5;   2   $
��Auto �6@   .+�5=   .   �� #��Z 65   |�.  ��6v   C� *�� $" DataGridSelectAllButtonStyle��"  +y�6�   �� *HeadersVisibility+# Z # Z  �� "  ��6�  �� *CellsPanelHorizontalOffset+ �� "    5>   .   $! PART_ColumnHeadersPresenter��6M   $��1��6r   y�6�   �� *HeadersVisibility+# Z # Z  �� "  �� 5?   .   $!  PART_ScrollContentPresenter��6E   #! z��6j   $��2��6�   $��1��6�   �� 5@   .   $" PART_VerticalScrollBar��68   $��2��6X   #$ z# 6h   $% Vertical=�6�   $��1��6�   #y�z& 6�   #( z' 6[  ) 6�   �� *VerticalOffset+$* OneWay=� �� *TemplatedParent+6[  � 5A   .   $��1��63   $��2��6C    5B   2   �� 5C   6   ��6G   �� **(NonFrozenColumnsViewportHorizontalOffset+ �� "  �� 5D   6   $��* �6G   .+�5F   2   �� $" PART_HorizontalScrollBar��6<   $��1��6^   #$ z+ 6n   $% 
Horizontal=�6�   #y�z, 6�   #( z- 6Y  ) 6�   �� *HorizontalOffset+$* OneWay=� �� *TemplatedParent+6Y  5G   /   5H   +   5I   '   .��5K   "   �� #
 z
 61   5L      5M      5N      5P      . 5Q      ]� 5R      / 5S      �� 5T      0 �@��
IsGrouping1 . 6:   �� 5U      "0 �@%�IsVirtualizingWhenGrouping1 .  6\   ./�5W      ��  � �� .  6F   5X      5Z      5[      .��5\      � ���	#FF000632.+�5^   
   �� 2 �� CornerRadius$2 10��6   $
��Left=�6#   $	��114��6>   $��	20,20,0,0q�6K   $	��Top=�6^   $	��776��6v   ���	#FF0082C6._�5_      �� .+�5`      �� -   5        3 ��Name$3 parfoun��5`      4 �� Text$'4 !ВЫБЕРИТЕ ПАРАМЕТР��6,   5 �� 
IsEditable5 . 6 �� 
IsReadOnly6 . $
��Left=�6i   $��27��6�   $	��Top=�6�   $	��238��6�   $��Arial Rounded MT Bold)�6�   $��18(�6�   7 �� Left$	7 158��6�   
8 �� Top$8 18��6�   .@�5a      �� $��Имя��6#   �� 5b      $��Фамилия��6#   �� 5c      $��Отчество��6#   �� 5d      $��Раб. нога��6#   �� 5e      $��Позиция��6#   �� 5f      $��Клуб��6#   �� 5g      $��Гражданство��6#   5i      �� 5j      $��ИСКАТЬ ПО��6   
�������$
��Left=�6?   $��33��6Z   $	��Top=�6f   $	��139��6~   $��Arial Rounded MT Bold)�6�   $��22(�6�   $7 18��6�   $8 13��6�   �� 5k      -   5        9 ��Name$9 valapr��5k      $��27��6K   $	7 416��6W   : �� TextWrapping$
: Wrap=�6i   $)��#ЗНАЧЕНИЕ ПАРАМЕТРА��6}   $8 18��6�   $	��220��6�   $��Arial Rounded MT Bold)�6�   $��18(�6�   �� 5l      $!��СОРТИРОВАТЬ ПО��6   
�������$
��Left=�6D   $��33��6_   $	��Top=�6k   $	��212��6�   $��Arial Rounded MT Bold)�6�   $��22(�6�   $7 18��6�   $8 66��6�   �� 5m      -   5        $3 pargr��5m      $'4 !ВЫБЕРИТЕ ПАРАМЕТР��6*   5 . 6 . $
��Left=�6g   $��27��6�   $	��Top=�6�   $	��238��6�   $��Arial Rounded MT Bold)�6�   $��18(�6�   $	7 232��6�   $8 69��6�   .@�5n      �� $��Голы��6#   �� 5o      $��Ассисты��6#   �� 5p      $��Рост��6#   �� 5q      $��Вес��6#   �� 5r      $��Родился��6#   �� 5s      $��Цена��6#   �� 5t      $
��ЖК��6#   �� 5u      $
��КК��6#   5v      �� 5w      -   5        ; ��Name$; group��5w      $��СОРТИРОВАТЬ��6(   
�������$
��Left=�6Q   $��42��6l   $	��Top=�6x   $	��169��6�   ���	#FF000331$��Arial Rounded MT Bold)�6�   $��20(�6�   $	7 487��6�   $8 62��6�   6  5x      5y      �� 5z   
   $
��Left=�6   $	��141��6+   $��	810,3,0,0q�68   $	��Top=�6K   $	��152��6c   $��Images\rpl-logo.png��6o     5{   
   -   5        <  Name$< tablepl��5{      =   CanUserAddRows= .  >   CanUserReorderColumns> .  ?   CanUserResizeRows? .  @   CanUserResizeColumns@ .  A   CanUserDeleteRowsA .  B   VerticalGridLinesBrushB �#e9e9e9C   HorizontalGridLinesBrushC �#e9e9e9$
��Left=�6�   $	��375��6  $��
20,147,0,0q�6  $	��Top=�6,  $	��952��6D  $��Arial Rounded MT Bold)�6P  #���   6s  ��5|      �� 5}      )  #System.Windows.Controls.DataGridRow"  6   .�5~      -   5        5      5�      �� 5�   
   -   5        $
; exit��5�      $��
ВЫЙТИ��6   
�������$
��Left=�6B   $��27��6]   $	��Top=�6i   $	��100��6�   ���	#FF0082C6$��Arial Rounded MT Bold)�6�   $��20(�6�   $��
20,530,0,0q�6�   D J� RenderTransformOrigin$D 0.545,0.278&�6�   �� 5�   
   -   5        $; addpl��5�      $#��ДОБАВИТЬ ИГРОКА��6    
�������$
��Left=�6M   $��27��6h   $	��Top=�6t   $	��206��6�   ���	#FF0082C6$��Arial Rounded MT Bold)�6�   $��20(�6�   $��766,530,0,0q�6�   $D 0.545,0.278&�6�   6  5�      5�      