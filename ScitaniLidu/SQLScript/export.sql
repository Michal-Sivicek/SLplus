CREATE DATABASE  IF NOT EXISTS `loginScitaniLidu` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `loginScitaniLidu`;
-- MySQL dump 10.13  Distrib 8.0.28, for Win64 (x86_64)
--
-- Host: 37.120.169.246    Database: loginScitaniLidu
-- ------------------------------------------------------
-- Server version	8.0.32-0ubuntu0.22.04.2

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users` (
  `id` int NOT NULL AUTO_INCREMENT,
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `role` enum('normal','admin') NOT NULL DEFAULT 'normal',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=24 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (21,'admin','admin','admin'),(22,'uzivatel','uzivatel','normal'),(23,'Mirek','mirek1','normal');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users_info`
--

DROP TABLE IF EXISTS `users_info`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users_info` (
  `id` int NOT NULL AUTO_INCREMENT,
  `jmeno` varchar(50) NOT NULL,
  `prijmeni` varchar(50) NOT NULL,
  `bydliste` varchar(100) NOT NULL,
  `datum_narozeni` varchar(50) NOT NULL,
  `telefonni_cislo` varchar(20) NOT NULL,
  `email` varchar(100) NOT NULL,
  `narodnost` varchar(50) NOT NULL,
  `statni_obcanstvi` varchar(50) NOT NULL,
  `vzdelani` varchar(50) NOT NULL,
  `user_id` int DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `user_id` (`user_id`),
  CONSTRAINT `users_info_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `users` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users_info`
--

LOCK TABLES `users_info` WRITE;
/*!40000 ALTER TABLE `users_info` DISABLE KEYS */;
INSERT INTO `users_info` VALUES (9,'Lukáš','Novotný','Praha','07.03.2003','777 632 342','lukas.novotny@gmail.com','Česká','Česká','střední škola',NULL);
/*!40000 ALTER TABLE `users_info` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users_info_flats`
--

DROP TABLE IF EXISTS `users_info_flats`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users_info_flats` (
  `id` int NOT NULL AUTO_INCREMENT,
  `jmeno` varchar(50) NOT NULL,
  `obec` varchar(50) NOT NULL,
  `cislo_domu` varchar(50) NOT NULL,
  `ulice` varchar(50) NOT NULL,
  `psc` varchar(50) NOT NULL,
  `obydlenost_bytu` varchar(50) NOT NULL,
  `velikost_bytu` varchar(50) NOT NULL,
  `podlazi_bytu` varchar(50) NOT NULL,
  `pocet_lidi` varchar(50) NOT NULL,
  `user_id` int DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `user_id` (`user_id`),
  CONSTRAINT `users_info_flats_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `users` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users_info_flats`
--

LOCK TABLES `users_info_flats` WRITE;
/*!40000 ALTER TABLE `users_info_flats` DISABLE KEYS */;
/*!40000 ALTER TABLE `users_info_flats` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users_info_houses`
--

DROP TABLE IF EXISTS `users_info_houses`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users_info_houses` (
  `id` int NOT NULL AUTO_INCREMENT,
  `jmeno_prijmeni` varchar(80) NOT NULL,
  `obec` varchar(50) NOT NULL,
  `cislo_domu` varchar(50) NOT NULL,
  `ulice` varchar(50) NOT NULL,
  `psc` varchar(50) NOT NULL,
  `obydlenost_domu` varchar(50) NOT NULL,
  `rok_vystavby` varchar(50) NOT NULL,
  `material_zdi` varchar(50) NOT NULL,
  `pocet_podlazi` varchar(50) NOT NULL,
  `user_id` int DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `user_id` (`user_id`),
  CONSTRAINT `users_info_houses_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `users` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users_info_houses`
--

LOCK TABLES `users_info_houses` WRITE;
/*!40000 ALTER TABLE `users_info_houses` DISABLE KEYS */;
/*!40000 ALTER TABLE `users_info_houses` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'loginScitaniLidu'
--

--
-- Dumping routines for database 'loginScitaniLidu'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-04-18 16:01:03
