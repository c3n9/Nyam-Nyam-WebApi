   M S B A M L   `   `   `  ����D  @Nyam-Nyam, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Nyam_Nyam.PagesNyam_Nyam.Pages  5      !    Nyam_Nyam.Pages.PAddNewDish   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:Nyam_Nyam.Pages     5        N� Title$  PAddNewDish��5
      .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      $
��Auto �6   .+�5   
   � .+�5      �� $��Disabled=�6   $
��Auto=�5      .��5      �� $��10q�6   .+�5      �� $
��Dish��6    $��20(�5       $��	Underline{�5       �� 5      $
��Name��6    $��16(�5       �� 5      $��16(�5        �� 	MaxLength$ 50��5!      ��5      �� *Name+5!      �� 5"      $��Description��6    $��16(�5#       �� 5$      $��16(�5%      ��5$      �� *Description+5%      �� 5&      $��Source recipe link��6    $��16(�5'       �� 5(      $��16(�5)      ��5(      �� *SourceRecipeLink+5)      �� 5*      $��Base servings��6    $��16(�5+       �� 5,      -   5        $��16(�5-      $ 2��5.      ��5,      �� *BaseServings+5/      �� 50      $��Final price��6    $��16(�51       �� 52      -   5        $��16(�53      ��52      �� *
FinalPrice+54      �� 55      $��Category��6    $��16(�56       �� 57      -   5         ��Name$ 
CBCategory��57       �� DisplayMemberPath$
 Name��58      $��16(�5:       �� SelectedItem 59      �� *
Category+5:      �� 5;      $	��250��5<      $	��400��5=       �� BitmapScalingMode$
 Fant=�5>      $
��Fill=�5?      ��5;      �� *Photo+5?      �� 5@      -   5         ��Name$ BPhoto��5@      $��	Add photo��5B      5C      5D      5E      � 5G   
   $��1��6    5H      �� 5I      $
��auto �6    �� 5J      .+�5L      �� $��10q�6   .+�5M      �� $��Steps recipe��6   $��20(�5N      $��	Underline{�5O      �� 5P      $��Process description��6   $��16(�5Q      �� 5R      -   5        	 ��Name$	 TBStep��5R      $��16(�5S      �� 5T      $��Time in minutes��6   $��16(�5U      �� 5V      -   5        $	 TBTime��5V      $��16(�5W      �� 5X      -   5        $ BAddStep��5X      $��Add step��5Y      5Z      5[      &   System.Windows.Controls.DataGrid  5\      -   5        
  Name$
 DGSteps��5`         ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5\         
IsReadOnly .    AutoGenerateColumns .     CanUserAddRows .  $��1��5a      $   HorizontalScrollBarVisibility$ Disabled=�5c      "   VerticalScrollBarVisibility$
 Auto=�5d         Columns 5e      0  *System.Windows.Controls.DataGridTextColumn  5f      ,  &System.Windows.Controls.DataGridColumn   Header$ Process description��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5g   )   �� *ProcessDescription+   ElementStyle 5h      �� 5i      .�5j   "   ��  �� Property � �� �� Value$
 Wrap=�5k   )   �� 5l   "    �@��TextAlignment$ Justify=�5m   )   5n      5p        5q      $
 Time��6)    5r   )   �� *Time+5t      5u      � 5v   
   $��2��6    5w      �� 5x      $
��auto �6    �� 5y      .+�5{      �� $��10q�6   .+�5|      �� $��Ingredients��6   $��20(�5}      $��	Underline{�5~      �� 5      $$��Selected ingredients for steps��6   $��16(�5�      �� 5�      -	   5        $ CBIngredient��5�      $
 Name��5�      $��16(�5�      �� 5�      $��Quantity��6   $��16(�5�      �� 5�      -
   5        $	 
TBQuantity��5�      $��16(�5�      �� 5�      -   5        $ BAddIngredient��5�      $��Add ingredient��5�      5�      5�        5�      -   5        $
 DGIngredients��5�      $ * 5�       . $��1��5�       .   .   5�        5�      $
 Name��6)    5�   )   �� *Ingredient.Name+  5�      $ Price per unit��6)    5�   )   �� *Ingredient.PricePerUnit+5�      5�      �� 5�   
   $��1��6   $��3��5�      $��Center=�5�      $��10q�5�      $��Center=�5�      .+�5�      �� -   5        $ BSave��5�      $
��Save��5�      $��2q�5�      $	��300��5�      $��25��5�      �� 5�      -   5        $ BDelete��5�      $��Delete��5�      $��2q�5�      $��25��5�      �� 5�      -   5        $ BCancel��5�      $��Cancel��5�      $��2q�5�      $��25��5�      5�      5�      5�      