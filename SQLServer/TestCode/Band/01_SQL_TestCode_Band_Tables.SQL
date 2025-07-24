/*========================================================================*/

Use TestCode;

Go

/*========================================================================*/

Create Table t_banda
(
id_banda Integer Not Null,
nm_banda Varchar(150) Not Null,
nm_origem Varchar(100) Not Null,
Constraint pk_t_banda Primary Key (id_banda)
)

Go

/*========================================================================*/

Create Table t_album
(
id_album Integer Not Null,
id_banda Integer Not Null,
nm_album Varchar(150) Not Null,
dt_lancamento Date Not Null,
vl_album Numeric(19, 2) Not Null,
Constraint pk_t_album Primary Key (id_album),
Constraint fk_t_album_x_t_banda Foreign Key (id_banda) 
References t_banda (id_banda)
)

Go

/*========================================================================*/

Create Table t_musica
(
id_musica Integer Not Null,
id_album Integer Not Null,
nm_musica Varchar(150) Not Null,
nr_duracao Numeric(5, 2) Not Null,
Constraint pk_t_musica Primary Key (id_musica),
Constraint fk_t_musica_x_t_album Foreign Key (id_album) 
References t_album (id_album)
)

Go

/*========================================================================*/
