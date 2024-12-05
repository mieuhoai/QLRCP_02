insert into users (username, password, role,status,date_reg) values	('hoai1','hoai123','Admin','active','2024-11-24')
insert into users (username, password, role,status,date_reg) values	('giakiet','kiet123','Staff','active','2024-11-24')
select * from users
select * from movies
select * from movies where status = 'Co san' and delete_date is null

create table customers
(
	id int primary key identity(1,1),
	movie_id varchar(MAX) null,
	seat_type varchar(MAX) null,
	seat_available int null,
	total_Price float null,
	foods nvarchar(MAX) null,
	drinks nvarchar(MAX) null,
	amount float null,
	change float null,
	status varchar(MAX) null,
	date_buy datetime null,
)
create table buy_tickets
(
	id int primary key identity(1,1),
	movie_id varchar(MAX) null,
	seat_number int null,
	status varchar(MAX) null,
	created_at datetime,
)
create table movies
(
	id int primary key identity(1,1),
	movie_id varchar(max) null,
	movie_name varchar(max) null,
	genre varchar(max) null,
	price float null,
	capacity int null,
	movie_image varchar(max) null,
	status varchar(max) null,
	created_at datetime null,
	update_date date null,
	delete_date date null,

)
drop table movies
select * from movies

s