   M S B A M L   `   `   `  ����G  Cwpf_tarabaev, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:wpf_tarabaevwpf_tarabaev  5      =#clr-namespace:wpf_tarabaev.Commandswpf_tarabaev.Commands  5      7 clr-namespace:wpf_tarabaev.Modelwpf_tarabaev.Model  5      K*clr-namespace:wpf_tarabaev.ValidationRuleswpf_tarabaev.ValidationRules  5	          wpf_tarabaev.PageEmployee   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:wpf_tarabaev     5      7command#clr-namespace:wpf_tarabaev.Commands     5      1core clr-namespace:wpf_tarabaev.Model     5      ;rule*clr-namespace:wpf_tarabaev.ValidationRules     5	      -   5          N� Title$  PageEmployee��5       � 	Resources 5         
errorStyle �� 
TargetType �� Property �� Value �� Triggers P� Property P� Value �� RelativeSource	 �� Path"  wpf_tarabaev.Model.ListTitle  	ListTitle  DateTemplate
 �� StringFormat  EditingDateTemplate(  "System.Windows.Controls.DatePicker   SelectedDate �� Mode �� UpdateSourceTrigger��%t  &	        &	 <    &	 O    &	 �    �� 5   
   " ��6#   .�5      ��  � ��$ -2q�6(    5      P� 5       �@=�HasError . . �5      ��  � ��
 �  ��63   �� 5       � ��$ 1q�68   �� 5       �@�ToolTip 5      ��  �� *self+$)	 #(Validation.Errors)[0].ErrorContent�5      5        5   
   6   �� 5   
   .R�5      �� $��Center=�5      $��Center=�63   ��5      �� *	BirthDate+$
 {0:dd.}{0:MM.}{0:yyyy}��5   3   5       �� 5!   
   .R�5"         6   �� *	BirthDate+$ TwoWay=�$ PropertyChanged=�5#      5$      .��5&      �� $��3,3,0,3q�6     BackgroundWindowResource#��[ 6"   .+�5'   
   o� .@�5(      m� $��Действие��6   .@�5)      m� $��Отменить��6    m� Command$
 Undo��6-   6>   �� 5*      6   m� 5+      $��Создать��6   $	 New��6,   6<   m� 5,      $ ��Редактировать��6   $ command:DataCommands.Edit��62   6X   m� 5-      $��Сохранить��6   $
 Save��6.   6?   m� 5.      $��
Найти��6   $
 Find��6*   m� 5/      $��Обновить��6   $ Refresh��6-   �� 50      6   m� 51      $��Удалить��6   $! command:DataCommands.Delete��6,   52      54      m� 55      $��
Отчёт��6   6(   56      c� 57   
   -   5        $��ToolBar1��57      $��3q�6"   .@�58      �� -   5        $
��undo��58      $
��Undo��6!    � ToolTip$D >Отменить редактирование/создание��60   $��5,2,5,2q�6[   .��59      �� $��Images/undo.ico��6   $��22��61   $��38��6=   5:      �� 5;      -   5        $	��add��5;      $	��New��6    $D >Отменить редактирование/создание��6.   $��5,2,5,2q�6Y   .��5<      �� $��Images/create.ico��6   $��22��63   $��38��6?   5=      �� 5>      -   5        $
��edit��5>      $��command:DataCommands.Edit��6!   $D >Отменить редактирование/создание��6E   $��5,2,5,2q�6p   .��5?      �� $��Images/edit.ico��6   $��22��61   $��38��6=   5@      �� 5A      -   5        $
��find��5A      $
��Find��6!   $D >Отменить редактирование/создание��60   $��5,2,5,2q�6[   .��5B      �� $��Images/find.ico��6   $��22��61   $��38��6=   5C      �� 5D      -   5        $
��save��5D      $
��Save��6!   $D >Отменить редактирование/создание��60   $��5,2,5,2q�6[   .��5E      �� $��Images/save.ico��6   $��22��61   $��38��6=   5F      �� 5G      -   5        $��edit_remove��5G      $!��command:DataCommands.Delete��6(   $D >Отменить редактирование/создание��6N   $��5,2,5,2q�6y   .��5H      �� $��Images/edit_remove.ico��6   $��22��68   $��38��6D   5I      �� 5J      -	   5        $��refresh��5J      $��Refresh��6$   $? 9Обновить данные по сотрудникам��66   $��5,2,5,2q�6_   .��5K      �� $��Images/refresh.png��6   $��22��64   $��38��6@   5L      5M      �� 5N   
   $��7q�6   %#Список сотрудников63   &   System.Windows.Controls.DataGrid  5P   
   -
   5        $��DataGridEmployee��5P         AutoGenerateColumns .  $
��Left=�5S      $
��1000��5T      $	��295��6#      RowBackground �	#FFE6D3EF   AlternatingRowBackground �	#FC96CFD4���	#FF1F33EB$��3q�5X         	RowHeight$ 25Q�5Y       � Cursor$
 Hand��5Z         CanUserAddRows .     CanUserDeleteRows .  $
��1000��5\   -   ��5Q      �� !   RowValidationErrorTemplate 5]      �� 5^      .R�5_      � $��	0,-2,0,-2q�6    5`      ��  ��  �� AncestorType)  #System.Windows.Controls.DataGridRow"  $)	 #(Validation.Errors)[0].ErrorContent�.+�5b      A� $��0��6"   
���  ��#��z��6A   #��z��5c      �� 5d      $��!��6$   #��z��6-   $
��Bold"�6S   
�������$��Center=�5e   3   5f      5g         Columns 5i      0  *System.Windows.Controls.DataGridTextColumn  5j      ,  &System.Windows.Controls.DataGridColumn   Header$ Фамилия��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 66   �� *	Surname+$ TwoWay=�$ PropertyChanged=�  5k      $ Имя��6%    62   �� *Name+$ TwoWay=�$ PropertyChanged=�  5l      $ Отчесвто��6%    67   �� *
Patronymic+$ TwoWay=�$ PropertyChanged=�4  .System.Windows.Controls.DataGridComboBoxColumn  5m      $ Должность��6)      DisplayMemberPath$ Title1��5o   )      SelectedValuePath$ ID��5q   )      ItemsSource 5n   )   ��  �� Source# [     SelectedValueBinding  5p   )   �� $	 TitleID�$ TwoWay=�$ PropertyChanged=�5q   )   4	  .System.Windows.Controls.DataGridTemplateColumn	  5r      $ Дата рождения��6)   ! 	  CellTemplate#! [ 5s   %   " 	  CellEditingTemplate#" [ 5t   %     5u      $ Телефон��6%    66   �� *	Telephone+$ TwoWay=�$ PropertyChanged=�  5v      $' !Электронная почта��6%   #   EditingElementStyle## [  6@    5w      �� 5x      $	 Email�6"   $ TwoWay=�6/   $ PropertyChanged=�6=   $ �� ValidatesOnExceptions$ . % �� ValidationRules% 5y      ,
   &wpf_tarabaev.ValidationRules.EmailRule
  5z   "   5|      5~      5�      �� 5�   
   -   5        & ��Name$& 
BorderFind��5�      #��[ 6%   $��200,-400,-203,0q�6\   $��82��6u   $��Center=�6�   $	��268��6�   ._�5�      � -   5        ' �Name$' GridFind��5�      $��0,2,19,0q�6%   ( � ColumnDefinitions( 5�      �� 5�      $	��85* �6'   �� 5�      $
��134* �6'   �� 5�      $	��36* �6'   ) � RowDefinitions) 5�      �� 5�      �� 5�      �� 5�      .+�5�      �� -   5        * ��Name$
* Find��5�      $
��Wrap=�6*   $��
Поиск��6>   $��0��6K   $��Center=�6X   $��Center=�6u   $��Verdana)�6�   $��20(�6�   $��1��6�   $��24��6�   $��	29,2,23,2q�6�   $��82��6�   �� 5�      -   5        $* TextBlockSurname��5�      $��Фамилия��66   $��1��6E   $��0��6R   �� 5�      -   5        $* TextBlockTitle��5�      $��Должность��64   $��2��6E   �� 5�      -   5        + ��Name$+ TextBoxSurname��5�      $��1��6[   $��1��6k   �� 5�      -   5        , ��Name$, ComboBoxTitle��5�      - �� DisplayMemberPath$- Title1��5�      $��1��6`   $��2��6p   ��5�   2   �� # [ 5�   p   �� 5�      -   5        . ��Name$. ButtonFindSurname��5�      $$ Поиск по фамилии��64   {�.  $��2��6�   $��1��6�   .��5�      �� $��Images/Find.ico��6   $��29��65   $��18��6A   5�      �� 5�      -   5        $. ButtonFindTitle��5�      $( "Поиск по должности��62   {�. / J� RenderTransformOrigin$/ -0.595,0.123&�5�   /   $��2��6T   $��2��6d   .��5�      �� $��Images/Find.ico��6   $/ -0.368,-0.263&�65   $��29��6[   $��18��6g   5�      5�      5�      5�      0 J� CommandBindings0 5�      )  #System.Windows.Input.CommandBinding  5�   
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