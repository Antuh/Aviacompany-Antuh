   M S B A M L   `   `   `  ????L  HAviacompany.Antuh, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:Aviacompany.Antuh.ViewAviacompany.Antuh.View  5   	   *    $Aviacompany.Antuh.View.TicketsClient   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:Aviacompany.Antuh.View     5   	   -   5          ? Title$  Ticket??5   	   $??519.664??6   $??1200.476??6)   .??5
      ?  ? ColumnDefinitions 5   
   ?? 5      .+?5   
   ?? $??ID билета??6   $
??Left=?6&   $??71??6A   $??250,389,0,0q?6M   $	??Top=?6b   $??77??6z   ?? 5   
   $$??Данные тип места??6   $	??289??6-   $??
940,95,0,0q?6:   $	??Top=?6N   $??16(?6f   $
??Left=?6t   $	??225??6?   ?? 5   
   $#??Данные клиентов??6   $
??Left=?6,   $	??289??6G   $??
468,95,0,0q?6T   $	??Top=?6h   $	??227??6?   $??16(?6?   ?? 5   
   $??Данные рейсов??6   $	??289??6*   $??
700,95,0,0q?67   $	??Top=?6K   $??16(?6c   $
??Left=?6q   $	??235??6?   ?? 5   
   $!??Данные билетов??6   $
??Left=?6+   $	??289??6F   $??	21,95,0,0q?6S   $	??Top=?6f   $	??442??6~   $??16(?6?   ? 5   
   $
??Left=?6   $??62??6*   $	??Top=?66   $
??1221??6N   ???	#FF79B6E0.+?5      ?? $??Авиакомпания??6   $
??Left=?6+   $??38??6F   $??	22,10,0,0q?6R   $	??Top=?6e   $	??170??6}   
???????$??20(?6?   $
??Bold"?6?   ?? 5      $
??Left=?6   $??20??6/   $??
181,22,0,0q?6;   $	??Top=?6O   $??33??6g   $H??B/Aviacompany.Antuh;component/Resource/free-icon-planes-1170857.png??6r   ?? 5      -   5         ??Name$ btn_exit??5      $??
Выход??6'   $
??Left=?67   $??1089,17,0,0q?6R   $	??Top=?6g   $??84??6   $??30??6?   
??????? J? RenderTransformOrigin$ 0.155,0.467&?6?   &   System.Windows.Controls.DataGrid  5      -   5          Name$ dataGridticket??5      $??37,126,774,-309q?6/   $ 0.429,0.525&?6H     5      -   5        $ dataGridclient??5      $??481,126,538,-309q?6/     5      -   5        $ dataGridflight??5      $??712,126,298,-309q?6/     5      -   5        $ dataGridtypeplace??5      $??955,126,70,-309q?62   5       ?? 5!   
   -   5        $ btn_addticket??5!      $!??Добавить билет??6(   $
??Left=?6A   $??
50,400,0,0q?6\   $	??Top=?6p   $	??146??6?   $??60??6?   ???	#FF79B6E0
???????$??14(?6?   ?? 5"   
   -   5         ??Name$ tb_deletetoidtick??5"      $
??Left=?6-   $??33??6H   $??271,414,0,0q?6T    ?? TextWrapping$
 Wrap=?6i   $	??Top=?6}   $??35??6?   $ 0.476,0.618&?6?   $??16(?6?   ?? 5#   
   -	   5        $ btn_deleteticket??5#      $??Удалить по id??6+   $
??Left=?6C   $??342,400,0,0q?6^   $	??Top=?6s   $	??146??6?   $??60??6?   ???	#FF79B6E0
???????$??14(?6?   ?? 5$   
   -
   5        $ btn_redactcticket??5$      $#??Изменить данные??6,   $
??Left=?6F   $??540,400,0,0q?6a   $	??Top=?6v   $	??146??6?   $??60??6?   ???	#FF79B6E0
???????$??14(?6?   ?? 5%   
   -   5        $ btn_obnovit??5%      $#??Обновить данные??6&   $
??Left=?6@   $??742,400,0,0q?6[   $	??Top=?6p   $	??146??6?   $??60??6?   ???	#FF79B6E0
???????$??14(?6?   5'      5(      