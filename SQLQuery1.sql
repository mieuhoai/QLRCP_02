create table users
(
	id int primary key identity(1,1),
	username varchar(max) null,
	password varchar(max) null,
	role varchar(max) null,
	status varchar(max) null,
	date_reg date null
)


create table movies
(
	id int primary key identity(1,1),
	movie_id varchar(max) null,
	movie_name varchar(max) null,
	genre varchar(max) null,
	price float null,
	movie_image varchar(max) null,
	status varchar(max) null,
	created_at datetime null,
	update_date date null,
	delete_date date null,

)
drop table movies

insert into users (username, password, role,status,date_reg) values	('hoai','hoai123','admin','active','2024-11-24')

select * from movies