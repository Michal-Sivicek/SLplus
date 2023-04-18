use loginScitaniLidu;


drop table users;
drop table users_info;
delete from users_info;

SET @@SQL_SAFE_UPDATES = 0;
SELECT @@AUTOCOMMIT;
SET AUTOCOMMIT=0;

BEGIN;
CREATE TABLE users (
    id INT PRIMARY KEY AUTO_INCREMENT NOT NULL,
    username VARCHAR(50) NOT NULL,
    password VARCHAR(50) NOT NULL,
    role ENUM('normal', 'admin') NOT NULL DEFAULT 'normal'
);
COMMIT;

BEGIN;
CREATE TABLE users_info (
    id INT PRIMARY KEY AUTO_INCREMENT NOT NULL,
    jmeno VARCHAR(50) NOT NULL,
    prijmeni VARCHAR(50) NOT NULL,
    bydliste VARCHAR(100) NOT NULL,
    nabozenstvi varchar(50) NOT NULL,
    telefonni_cislo VARCHAR(20) NOT NULL,
    email VARCHAR(100) NOT NULL,
    narodnost VARCHAR(50) NOT NULL,
    statni_obcanstvi VARCHAR(50) NOT NULL,
    vzdelani varchar(50) NOT NULL,
    user_id INT,
    FOREIGN KEY (user_id) REFERENCES users(id)
);
COMMIT;

BEGIN;
CREATE TABLE users_info_houses (
	id INT PRIMARY KEY AUTO_INCREMENT NOT NULL,
	jmeno_prijmeni varchar(80) not null,
    obec varchar(50) not null,
    cislo_domu varchar(50) not null,
    ulice varchar(50) not null,
    psc varchar(50) not null,
    obydlenost_domu varchar(50) not null,
    rok_vystavby varchar(50) not null,
    material_zdi varchar(50) not null,
    pocet_podlazi varchar(50) not null,
    user_id INT,
    FOREIGN KEY (user_id) REFERENCES users(id)
);
COMMIT;

BEGIN;
CREATE TABLE users_info_flats (
	id INT PRIMARY KEY AUTO_INCREMENT NOT NULL,
    jmeno varchar(50) not null,
    obec varchar(50) not null,
    cislo_domu varchar(50) not null,
    ulice varchar(50) not null,
    psc varchar(50) not null,
    obydlenost_bytu varchar(50) not null,
    velikost_bytu varchar(50) not null,
    podlazi_bytu varchar(50) not null,
    pocet_lidi varchar(50) not null,
    user_id INT,
    FOREIGN KEY (user_id) REFERENCES users(id)
);
COMMIT;


BEGIN;
INSERT INTO `loginScitaniLidu`.`users` (`username`, `password`, `role`) VALUES ('admin', 'admin', 'admin');
INSERT INTO `loginScitaniLidu`.`users` (`username`, `password`, `role`) VALUES ('uzivatel', 'uzivatel', 'normal');
COMMIT;

