create database appfofo;

use appfofo;

create table usuarios(
	id_usuario int not null primary key auto_increment,
    nome_usuario varchar(100) unique not null,
    senha_usuario varchar(100) not null
);

select * from usuarios;

select count(id_usuario) from usuarios where nome_usuario = '1234' and senha_usuario = '1234';
