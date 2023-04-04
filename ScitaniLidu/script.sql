CREATE DATABASE loginScitaniLidu;
USE loginScitaniLidu;

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
    nabozenstvi BOOL NOT NULL,
    telefonni_cislo VARCHAR(20) NOT NULL,
    email VARCHAR(100) NOT NULL,
    narodnost VARCHAR(50) NOT NULL,
    statni_obcanstvi VARCHAR(50) NOT NULL,
    vzdelani ENUM('zakladni skola', 'stredni skola', 'vysoka skola') NOT NULL,
    user_id INT NOT NULL,
    FOREIGN KEY (user_id) REFERENCES users(id)
);
COMMIT;


BEGIN;
INSERT INTO `loginscitanilidu`.`users` (`id`, `username`, `password`, `role`) VALUES ('1', 'msiv', 'msiv1', 'admin');
INSERT INTO `loginscitanilidu`.`users` (`username`, `password`, `role`) VALUES ('uzivatel', 'uzivatel1', 'normal');
COMMIT;


SELECT COUNT(*) FROM users WHERE username = 'msiv' AND password = 'msiv1' AND role = 'admin';


