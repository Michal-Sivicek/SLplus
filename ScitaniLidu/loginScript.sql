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
INSERT INTO `loginscitanilidu`.`users` (`id`, `username`, `password`, `role`) VALUES ('1', 'msiv', 'msiv1', 'admin');
INSERT INTO `loginscitanilidu`.`users` (`username`, `password`, `role`) VALUES ('uzivatel', 'uzivatel1', 'normal');
COMMIT;


SELECT COUNT(*) FROM users WHERE username = 'msiv' AND password = 'msiv1' AND role = 'admin';


