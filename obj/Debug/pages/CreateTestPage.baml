   M S B A M L   `   `   `  ????u  qСистема тестирования студентов, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Diplom_V4	Diplom_V4  5      -clr-namespace:Diplom_V4.srcDiplom_V4.src  5          Diplom_V4.CreateTestPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:Diplom_V4     5      1	viewModelclr-namespace:Diplom_V4.src     5        N? Title$  CreateTestPage??5
      .??5      ?  ? ColumnDefinitions 5   
   ?? 5      ?? 5      $
??auto ?6   ?? 5       ? RowDefinitions 5   
   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   .+?5   
   ?? $??0??6   $??1??6"   .+?5      ?? $0??*Введите название теста??6   $??0,10,0,0q?66   ?? 5      -   5         ??Name$ testName??5      $	??380??6(   $??40??64    ?? TextWrapping$
 Wrap=?6c   5      ?? 5   
   $??1??6   $??1??6"   .+?5      ?? $"??Вопросы в тесте??6   $??0q?6/   ?? 5      -   5         ??Name$ 	tasksTest??5      $	??450??6*   $	??500??67   $??14(?6C   ??6Q   ??  ?? Path$ Tasks? ?? View 5      ?? 5       .P?5!      ?? $??Вопрос??6)    ?? Width$
 auto??69   	 ?? DisplayMemberBinding	 6F   ?? $
 Name??? 5"      $
 auto??6)   $??Ответы??66   	 6F   ?? $ 
AnswersSrt??? 5#      $
 auto??6)   $4??.Номер правильного ответа??66   	 6X   ?? $ 
NumTrueAns?5$      5&      5'      ?? 5(   
   $??2??6   $??1??6"   .+?5)      ?? 
 ?? Orientation$
 
Horizontal=?6   .+?5*      ?? -   5        $!??Удалить вопрос??5*      $??40??62   $	??160??6>   $??7,23,7,0q?6J   6\   ?? 5+      -   5        $%??Добавить вопросы??5+      $??40??64   $	??190??6@   $??7,23,7,0q?6a   ?? 5,      -   5        $!??Сохранить тест??5,      $??40??62   $	??160??6>   $??7,23,7,0q?6J   6\   5-      ?? 5.      $
 
Horizontal=?6   $??Center=?62   $??Center=?6O   .+?5/      ?? -   5        $,??&Посмотреть все тесты??5/      $??40??68   $	??230??6D   $??7,23,7,0q?6P   6b   ?? 50      -   5        $??Вернуться??50      $??40??6-   $	??150??69   $??7,23,7,0q?6\   51      52      53      54      