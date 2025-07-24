/*========================================================================*/

Use TestCode;

Go

/*========================================================================*/

Select a.id_banda, a.nm_banda
From t_banda a
Where a.nm_origem = 'Estados Unidos'
Order By a.id_banda Asc;

Go

/*========================================================================*/

Select c.nm_musica,
       b.nm_album
From t_banda a
Join t_album  b On a.id_banda = b.id_banda
Join t_musica c On b.id_album = c.id_album
Where nm_banda = 'Nirvana'
Order By a.id_banda Asc;

Go

/*========================================================================*/

Select a.nm_banda,
       b.nm_album, b.dt_lancamento
From t_banda a
Join t_album b On a.id_banda = b.id_banda
Where Year(b.dt_lancamento) >= 1990
  And Year(b.dt_lancamento) <= 2000
Order By a.id_banda Asc;

Go

/*========================================================================*/

Select a.nm_banda,
       b.vl_album
From t_banda a
Join t_album b On a.id_banda = b.id_banda
Order By b.vl_album Desc;

Go

/*========================================================================*/

Select a.nm_banda,
       b.nm_album,
	   Count(1) qtde_musicas
From t_banda a
Join t_album  b On a.id_banda = b.id_banda
Join t_musica c On b.id_album = c.id_album
Where c.nr_duracao > 6
Group By a.nm_banda,
         b.nm_album
Order By a.nm_banda Asc, b.nm_album Desc;

Go

/*========================================================================*/

Insert Into t_musica
(id_musica, id_album, nm_musica, nr_duracao)
Select iif((Select Top 1 1
            From t_musica) Is Null,
           1,
           (Select Max(id_musica) + 1
            From t_musica)) id_musica,
       b.id_album,
       'Razor' nm_musica, 6.49 nr_duracao
From t_banda a
Join t_album b On a.id_banda = b.id_banda
Where a.nm_banda = 'Foo Fighters'
  And b.nm_album = 'Skin and Bones';

Go

/*========================================================================*/

Select Top 2 a.nm_banda,
       Sum(b.vl_album) vl_album_sum
From t_banda a
Join t_album b On a.id_banda = b.id_banda
Group By a.nm_banda
Order By vl_album_sum Desc;

Go

/*========================================================================*/

Select a.nm_banda,
       a.nm_album,
       a.nr_duracao_avg
From (Select a.nm_banda,
             b.nm_album,
             Cast(Round(Avg(c.nr_duracao), 2) As Decimal(3, 2)) nr_duracao_avg,
             Count(1) qtde_album
      From t_banda a
      Join t_album  b On a.id_banda = b.id_banda
      Join t_musica c On b.id_album = c.id_album
      Group By a.nm_banda,
               b.nm_album) a
Where qtde_album > 1
Order By a.nm_banda Asc, a.nr_duracao_avg Asc;

Go

/*========================================================================*/

Select b.nm_banda,
       c.nm_album,
	   d.nm_musica, d.nr_duracao,
       a.nr_duracao_avg
From (Select a.id_banda,
             a.id_album,
             Cast(Round(Avg(b.nr_duracao), 2) As Decimal(3, 2)) nr_duracao_avg
      From t_album a
      Join t_musica b On a.id_album = b.id_album
      Group By a.id_banda,
               a.id_album) a
Join t_banda  b On a.id_banda = b.id_banda
Join t_album  c On a.id_banda = c.id_banda
               And a.id_album = c.id_album
Join t_musica d On c.id_album = d.id_album
Where d.nr_duracao > a.nr_duracao_avg
Order By b.nm_banda Asc, d.nr_duracao Asc;

Go

/*========================================================================*/

Select a.nm_banda,
       a.nm_album,
       a.nm_musica,
       (a.nr_duracao_segundos * a.vl_album_nr_duracao_divisao) valor_proporcional
From (Select b.nm_banda,
             c.nm_album,
             d.nm_musica,
             (Cast(d.nr_duracao As Integer) * 60) + (Cast(((d.nr_duracao - Cast(d.nr_duracao As Integer)) * 100) As Integer)) nr_duracao_segundos,
             Cast((c.vl_album / a.nr_duracao_segundos_soma) As Decimal(12, 2)) vl_album_nr_duracao_divisao
      From (Select a.id_album, a.id_banda,
             Sum((Cast(b.nr_duracao As Integer) * 60) + (Cast(((b.nr_duracao - Cast(b.nr_duracao As Integer)) * 100) As Integer))) nr_duracao_segundos_soma
            From t_album a
            Join t_musica b On a.id_album = b.id_album
            Group By a.id_album, a.id_banda) a
      Join t_banda  b On a.id_banda = b.id_banda
      Join t_album  c On a.id_album = c.id_album
                     And a.id_banda = c.id_banda
      Join t_musica d On c.id_album = d.id_album) a
Order By a.nm_banda Asc, a.nm_album Asc, valor_proporcional Desc;

Go

/*========================================================================*/
