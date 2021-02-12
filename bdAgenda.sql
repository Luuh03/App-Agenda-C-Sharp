drop database bdagenda;
create database bdagenda;
use bdagenda;

create table tblpessoas(
	pesid int(11) not null primary key auto_increment,
	pesnome varchar(50) not null,
	pesemail varchar(300) not null,
	pestelefonefixo varchar(15) not null,
	pestelefonecelular varchar(15) not null
);

create table tblusuarios (
	pesid int(11) not null primary key,
	usrnome varchar(10) not null,
	usrsenha varchar(300) not null
);

create table tblcompromissos (
	comid int(11) not null primary key auto_increment,
	pesid int(11) not null,
	comdatahora datetime not null,
	comdescricao text null,
	tpoid int(11) not null,
	comstatus int(1) not null default 0
);

create table tbltipocomp (
	tpoid int(11) not null primary key auto_increment,
	tponome varchar(20) not null
);

insert into tblusuarios ( pesid, usrnome, usrsenha ) values ( 0, 'usuario', 'senha' );