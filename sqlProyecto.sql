CREATE TABLE users(
	user_id INT PRIMARY KEY,
	name varchar(20),
	surname varchar(20),
	phone varchar(15)
);
CREATE TABLE logins(
	email varchar(50) PRIMARY KEY,
	password varchar(70),
	user_id INT,
	
	CONSTRAINT fk_user_login FOREIGN KEY (user_id) REFERENCES users(user_id)
);
CREATE TABLE flights(
	flight_id SERIAL PRIMARY KEY,
	origin_city varchar(30),
	destiny_city varchar(30),
	flight_date date,
	departure_time time,
	arrival_time time,
	airline varchar(20),
	state varchar(20)
);

--Insertar usuarios y sus respectivas credenciales de autenticación
insert INTO users values (1027800265, 'Dylan', 'López', '3014335885');
insert INTO users values (1025422841, 'Brayan', 'González', '3154782591');
insert INTO logins values ('dylan@mail.com', 'COa556#.', 1027800265);
insert INTO logins values ('brayan@mail.com', '$epulveda45TYU.', 1025422841);

--Ingreso de vuelo de ejemplo
insert INTO flights values 
(DEFAULT, 'Maracaibo', 'Bogotá', '12-01-2001', '15:10:00', '18:12:00', 'Avianca', 'En vuelo');

