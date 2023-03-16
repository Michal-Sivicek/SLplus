create database ScitaniLidu;
use ScitaniLidu;

SET @@SQL_SAFE_UPDATES = 0;
SELECT @@AUTOCOMMIT;
SET AUTOCOMMIT=0;


BEGIN;
CREATE TABLE infoUsers (
    id INT PRIMARY KEY AUTO_INCREMENT NOT NULL,
    username VARCHAR(50) NOT NULL,
    lastname VARCHAR(50) NOT NULL,
    phonenumber VARCHAR(50) NOT NULL
);
COMMIT;


