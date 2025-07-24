/*========================================================================*/

Use TestCode;

Go

/*========================================================================*/

Insert Into t_banda
(id_banda, nm_banda, nm_origem)
Values
(1, 'Iron Maiden', 'Reino Unido'),
(2, 'Metallica', 'Estados Unidos'),
(3, 'System of a Down', 'Estados Unidos'),
(4, 'AC/CD', 'Australia'),
(5, 'Nirvana', 'Estados Unidos'),
(6, 'Foo Fighters', 'Estados Unidos');

/*========================================================================*/

Insert Into t_album
(id_album, id_banda, nm_album, dt_lancamento, vl_album)
Values
(1, 1, 'Fear of the Dark', '1992-5-11', 100.50),
(2, 1, 'Senjutsu', '2021-09-03', 166.32),
(3, 2, 'Load', '1996-06-01', 97.09),
(4, 2, 'And Justice for All', '1988-09-07', 108.00),
(5, 3, 'Hypnotize', '2005-11-22', 60.45),
(6, 3, 'Toxicity', '2001-09-04', 99.99),
(7, 4, 'Highway to Hell', '1979-07-27', 88.90),
(8, 4, 'Back in Black', '1980-07-25', 85.78),
(9, 5, 'Nevermind', '1991-09-24', 115.25),
(10, 5, 'In Utero', '1993-09-21', 99.99),
(11, 6, 'Skin and Bones', '2006-11-07', 89.90);

/*========================================================================*/

Insert Into t_musica
(id_musica, id_album, nm_musica, nr_duracao)
Values
--Fear of the Dark
(1, 1, 'Be Quick of Be Dead', 3.40),
(2, 1, 'Fear of the Dark', 7.30),
(3, 1, 'Affraid to Shoot Strangers', 6.40),
--Senjutsu
(4, 2, 'Senjutsu', 8.30),
(5, 2, 'Days of Future Past', 4.10),
(6, 2, 'Darkest Houer', 7.30),
--Load
(7, 3, 'King Nothing', 5.45),
(8, 3, 'Bleeding Me', 8.30),
(9, 3, 'Cure', 4.45),
--And Justice for All
(10, 4, '...And justice for all', 9.55),
(11, 4, 'One', 7.26),
(12, 4, 'To Live is to Die', 8.40),
--Hypnotize
(13, 5, 'Attack', 3.10),
(14, 5, 'U-Fig', 2.59),
(15, 5, 'Vicinity of Obscenity', 2.59),
--Toxicity
(16, 6, 'Bounce', 1.45),
(17, 6, 'Toxicity', 3.53),
(18, 6, 'Aerials', 6.25),
--Highway to Hell
(19, 7, 'Highway to Hell', 3.43),
(20, 7, 'Get it hot', 2.52),
(21, 7, 'Girls Got Rhythm', 3.52),
--Back in Black
(22, 8, 'Hells Bells', 5.20),
(23, 8, 'Back in Black', 4.40),
(24, 8, 'You Shook Me All Night Long', 3.50),
--Nevermind
(25, 9, 'Smells Like Teen Spirit', 5.01),
(26, 9, 'Come As You Are', 3.59),
(27, 9, 'Polly', 2.59),
--In Utero
(28, 10, 'Pennyroyal Tea', 3.53),
(29, 10, 'Dumb', 2.41),
(30, 10, 'All Apologies', 3.35);

/*========================================================================*/
