   M S B A M L   `   `   `  ����G  Cwpf_tarabaev, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:wpf_tarabaev.Commandswpf_tarabaev.Commands  5      7 clr-namespace:wpf_tarabaev.Modelwpf_tarabaev.Model  5      K*clr-namespace:wpf_tarabaev.ValidationRuleswpf_tarabaev.ValidationRules  5      +clr-namespace:wpf_tarabaevwpf_tarabaev  5	      "    wpf_tarabaev.PageTransaction   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7command#clr-namespace:wpf_tarabaev.Commands     5      1core clr-namespace:wpf_tarabaev.Model     5      ;rule*clr-namespace:wpf_tarabaev.ValidationRules     5      ,localclr-namespace:wpf_tarabaev     5	      -   5          N� Title$  PageTransaction��5       � 	Resources 5         
errorStyle �� 
TargetType �� Property �� Value �� Triggers P� Property P� Value �� RelativeSource	 �� Path(  "wpf_tarabaev.Model.ListTransaction  ListTransaction  DateTemplate
 �� StringFormat  EditingDateTemplate(  "System.Windows.Controls.DatePicker   SelectedDate �� Mode �� UpdateSourceTrigger��%t  &	        &	 <    &	 O    &	 �    �� 5   
   " ��6#   .�5      ��  � ��$ -2q�6(    5      P� 5       �@=�HasError . . �5      ��  � ��
 �  ��63   �� 5       � ��$ 1q�68   �� 5       �@�ToolTip 5      ��  �� *self+$)	 #(Validation.Errors)[0].ErrorContent�5      5        5   
   6   �� 5   
   .R�5      �� $��Center=�5      $��Center=�63   ��5      �� *	TransDate+$
 {0:dd.}{0:MM.}{0:yyyy}��5   3   5       �� 5!   
   .R�5"         6   �� *	TransDate+$ TwoWay=�$ PropertyChanged=�5#      5$      .��5&      �� $��3,3,0,3q�6     BackgroundWindowResource#��[ 6"   .+�5'   
   o� .@�5(      m� $��Действие��6   .@�5)      m� $��Отменить��6    m� Command$
 Undo��6-   6>   �� 5*      6   m� 5+      $��Создать��6   $	 New��6,   6<   m� 5,      $ ��Редактировать��6   $ command:DataCommands.Edit��62   6X   m� 5-      $��Сохранить��6   $
 Save��6.   6?   m� 5.      $��
Найти��6   $
 Find��6*   m� 5/      $��Обновить��6   $ Refresh��6-   �� 50      6   m� 51      $��Удалить��6   $! command:DataCommands.Delete��6,   52      53      m� 54      $��
Отчёт��6   6(   55      c� 56   
   -   5        $��ToolBar1��56      $��3q�6"   .@�57      �� -   5        $
��undo��57      $
��Undo��6!    � ToolTip$D >Отменить редактирование/создание��60   $��5,2,5,2q�6[   .��58      �� $��Images/undo.ico��6   $��22��61   $��38��6=   59      �� 5:      -   5        $	��add��5:      $	��New��6    $D >Отменить редактирование/создание��6.   $��5,2,5,2q�6Y   .��5;      �� $��Images/create.ico��6   $��22��63   $��38��6?   5<      �� 5=      -   5        $
��edit��5=      $��command:DataCommands.Edit��6!   $D >Отменить редактирование/создание��6E   $��5,2,5,2q�6p   .��5>      �� $��Images/edit.ico��6   $��22��61   $��38��6=   5?      �� 5@      -   5        $
��find��5@      $
��Find��6!   $D >Отменить редактирование/создание��60   $��5,2,5,2q�6[   .��5A      �� $��Images/find.ico��6   $��22��61   $��38��6=   5B      �� 5C      -   5        $
��save��5C      $
��Save��6!   $D >Отменить редактирование/создание��60   $��5,2,5,2q�6[   .��5D      �� $��Images/save.ico��6   $��22��61   $��38��6=   5E      �� 5F      -   5        $��edit_remove��5F      $!��command:DataCommands.Delete��6(   $D >Отменить редактирование/создание��6N   $��5,2,5,2q�6y   .��5G      �� $��Images/edit_remove.ico��6   $��22��68   $��38��6D   5H      �� 5I      -	   5        $��refresh��5I      $��Refresh��6$   $? 9Обновить данные по сотрудникам��66   $��5,2,5,2q�6_   .��5J      �� $��Images/refresh.png��6   $��22��64   $��38��6@   5K      5L      �� 5M   
   $��7q�6   Список сделок6.   &   System.Windows.Controls.DataGrid  5N   
   -
   5        $��DataGridTransaction��5N         AutoGenerateColumns .  $
��Left=�5Q      $
��1000��5R      $	��295��6#      RowBackground �	#FFE6D3EF   AlternatingRowBackground �	#FC96CFD4���	#FF1F33EB$��3q�5V         	RowHeight$ 25Q�5W       � Cursor$
 Hand��5X         CanUserAddRows .     CanUserDeleteRows .  $
��1000��5Z   -   ��5O      �� !   RowValidationErrorTemplate 5[      �� 5\      .R�5]      � $��	0,-2,0,-2q�6    5^      ��  ��  �� AncestorType)  #System.Windows.Controls.DataGridRow"  $)	 #(Validation.Errors)[0].ErrorContent�.+�5`      A� $��0��6"   
���  ��#��z��6A   #��z��5a      �� 5b      $��!��6$   #��z��6-   $
��Bold"�6S   
�������$��Center=�5c   3   5d      5e         Columns 5g      0  *System.Windows.Controls.DataGridTextColumn  5h      ,  &System.Windows.Controls.DataGridColumn   Header$+ %Наименование сделки��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6B   �� *	NameTrans+$ TwoWay=�$ PropertyChanged=�  5i      $ Статус сделки��6%    6<   �� *Status+$ TwoWay=�$ PropertyChanged=�4  .System.Windows.Controls.DataGridComboBoxColumn  5j      $ Клиент��6)      DisplayMemberPath$ Title2��5l   )      SelectedValuePath$ ID��5n   )      ItemsSource 5k   )   ��  �� Source# [     SelectedValueBinding  5m   )   �� $	 TitleID�$ TwoWay=�$ PropertyChanged=�5n   )   4	  .System.Windows.Controls.DataGridTemplateColumn	  5o      $ Дата сделки��6)   ! 	  CellTemplate#! [ 5p   %   " 	  CellEditingTemplate#" [ 5q   %     5r      $# Телефон клиента��6%    6>   �� *	Telephone+$ TwoWay=�$ PropertyChanged=�  5s      $ Email клиента��6%   #   EditingElementStyle## [  6<    5t      �� 5u      $	 Email�6"   $ TwoWay=�6/   $ PropertyChanged=�6=   $ �� ValidatesOnExceptions$ . % �� ValidationRules% 5v      ,
   &wpf_tarabaev.ValidationRules.EmailRule
  5w   "   5y      5{      5}      �� 5~   
   -   5        & ��Name$& BorderFind2��5~      #��[ 6&   $��422,-400,63,0q�6]   $��82��6t   $��Center=�6�   $	��312��6�   ._�5      � -   5        ' �Name$' GridFind��5      $��0,2,19,0q�6%   ( � ColumnDefinitions( 5�      �� 5�      $	��85* �6'   �� 5�      $
��134* �6'   �� 5�      $	��36* �6'   ) � RowDefinitions) 5�      �� 5�      �� 5�      �� 5�      .+�5�      �� -   5        * ��Name$
* Find��5�      $
��Wrap=�6*   $��
Поиск��6>   $��0��6K   $��Center=�6X   $��Center=�6u   $��Verdana)�6�   $��20(�6�   $��1��6�   $��24��6�   $��	29,2,23,2q�6�   $��82��6�   �� 5�      -   5        $* TextBlockNameOfTrans��5�      $#��Название сделки��6:   $��1��6Q   $��0��6^   �� 5�      -   5        $* TextBlockTitle��5�      $��Клиент��64   $��2��6B   �� 5�      -   5        + ��Name$+ TextBoxNameTrans��5�      $��1��6_   $��1��6o   �� 5�      -   5        , ��Name$, ComboBoxTitle��5�      - �� DisplayMemberPath$- Title2��5�      $��1��6`   $��2��6p   ��5�   2   �� # [ 5�   p   �� 5�      -   5        . ��Name$. ButtonFindNameTrans��5�      $" Поиск по сделке��66   {�.  $��2��6�   $��1��6�   .��5�      �� $��Images/Find.ico��6   $��29��65   $��18��6A   5�      �� 5�      -   5        $. ButtonFindTitle��5�      $( "Поиск по должности��62   {�. / J� RenderTransformOrigin$/ -0.595,0.123&�5�   /   $��2��6T   $��2��6d   .��5�      �� $��Images/Find.ico��6   $/ -0.368,-0.263&�65   $��29��6[   $��18��6g   5�      5�      5�      5�      0 J� CommandBindings0 5�      )  #System.Windows.Input.CommandBinding  5�   
   -   5        (   "wpf_tarabaev.Commands.DataCommands1   Delete2   Command#2 Z1 5�      6s     5�   
   -   5        $
2 Undo��5�      6O     5�   
   -   5        $	2 New��5�      6M     5�   
   -   5        $
2 Save��5�      6O     5�   
   -   5        $
2 Find��5�      6O     5�   
   -   5        3   Edit#2 Z3 5�      6o     5�   
   -   5        $2 Refresh��5�      6+   5�      