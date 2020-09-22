create database teste_drive_bd;

use teste_drive_bd;

create table tb_login(
id_login 				int primary key auto_increment,
ds_email				varchar(255) not null unique,
ds_senha 				varchar(255) not null
);

create table tb_veiculo(
id_veiculo 				int primary key auto_increment,
ds_marca				varchar(100) not null,
ds_modelo				varchar(255) not null,
dt_ano_modelo			date not null,
ds_cor 					varchar(55) not null,
ds_placa 				varchar(50) not null unique,
vl_veiculo  	    	decimal(10,2) not  null,
bt_carro_disponivel_td	bool not null,
ds_combustivel 			varchar(100) not null,
ds_adaptacao			varchar(255),
ds_imagem 				varchar(255) not null
);

create table tb_notificacao(
id_notificacao			int primary key auto_increment,
id_login 				int not null,
ds_mensagem				varchar(300) not null,
ds_status 				varchar(255) not null,
dt_envio 				datetime not null,
FOREIGN KEY (id_login) REFERENCES tb_login(id_login)
);

create table tb_cliente (
id_cliente 			int primary key auto_increment,
id_login			int not null,
nm_cliente 			varchar(100) not null,
nr_cpf 				int not null,
nr_cnh				int not null,
dt_nascimento		date,
ds_endereco 		varchar(255) not null,
nr_celular  		int not null,
bt_deficiente		bool not null,
FOREIGN KEY (id_login) REFERENCES tb_login(id_login)
);

create table tb_agendamento (
id_agendamento 		int primary key auto_increment,
id_cliente 			int not null,
id_veiculo 			int not null,
dt_agendamento 		datetime not null,
ds_rota_inicial		varchar(255) not null,
ds_rota_final 		varchar(255) not null,
ds_status 			varchar(255) not null,
hr_final 			time not null,
nr_avaliacao		int,
ds_feedback			varchar(300),
FOREIGN KEY (id_cliente) REFERENCES tb_cliente (id_cliente),
FOREIGN KEY (id_veiculo) REFERENCES tb_veiculo (id_veiculo)
);

alter table tb_agendamento
	add ds_acompanhante varchar(255);
    
alter table tb_veiculo
		add bt_disponivel bool;
    
insert into tb_login(ds_senha,ds_email) 
			 values ("12345meu","ex@gmail.com");