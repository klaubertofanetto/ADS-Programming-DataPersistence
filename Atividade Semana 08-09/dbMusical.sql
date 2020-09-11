-- MySQL dump 10.13  Distrib 8.0.21, for Win64 (x86_64)
--
-- Host: localhost    Database: musical
-- ------------------------------------------------------
-- Server version	8.0.21

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
-- Table structure for table `bandas`
--

DROP TABLE IF EXISTS `bandas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `bandas` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `nomeBanda` varchar(50) NOT NULL,
  `idMusico1` int NOT NULL,
  `idMusico2` int DEFAULT NULL,
  `idMusico3` int DEFAULT NULL,
  `idMusico4` int DEFAULT NULL,
  `idMusico5` int DEFAULT NULL,
  `idMusico6` int DEFAULT NULL,
  `idMusico7` int DEFAULT NULL,
  `idmusico8` int DEFAULT NULL,
  `anoFundacao` int NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bandas`
--

LOCK TABLES `bandas` WRITE;
/*!40000 ALTER TABLE `bandas` DISABLE KEYS */;
INSERT INTO `bandas` VALUES (1,'Rush',1,2,3,NULL,NULL,NULL,NULL,NULL,1968),(2,'Emerson, Lake & Palmer',4,5,6,NULL,NULL,NULL,NULL,NULL,1970),(3,'The Winery Dogs',7,8,9,NULL,NULL,NULL,NULL,NULL,2012),(4,'Sons of Apollo',8,9,10,11,12,NULL,NULL,NULL,2017);
/*!40000 ALTER TABLE `bandas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `discos`
--

DROP TABLE IF EXISTS `discos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `discos` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `nomeDisco` varchar(50) NOT NULL,
  `idBanda` int NOT NULL,
  `estilo` varchar(50) NOT NULL,
  `anoLancamento` int NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `discos`
--

LOCK TABLES `discos` WRITE;
/*!40000 ALTER TABLE `discos` DISABLE KEYS */;
INSERT INTO `discos` VALUES (1,'Rush',1,'Rock Progressivo',1974),(2,'Fly by Night',1,'Rock Progressivo',1975),(3,'Caress of Steel',1,'Rock Progressivo',1975),(4,'2112',1,'Rock Progressivo',1976),(5,'Emerson, Lake and Palmer',2,'Rock Progressivo',1970),(6,'Tarkus',2,'Rock Progressivo',1971),(7,'The Winery Dogs',3,'Hard Rock',2013),(8,'Hot Streak',3,'Hard Rock',2015),(9,'Psychotic Symphony',4,'Metal Progressivo',2017),(10,'MMXX',4,'Metal Progressivo',2020);
/*!40000 ALTER TABLE `discos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `musicos`
--

DROP TABLE IF EXISTS `musicos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `musicos` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `nome` varchar(50) NOT NULL,
  `nomeReal` varchar(50) DEFAULT NULL,
  `instrumento` varchar(30) NOT NULL,
  `ativo` bit(1) NOT NULL DEFAULT b'1',
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=23 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `musicos`
--

LOCK TABLES `musicos` WRITE;
/*!40000 ALTER TABLE `musicos` DISABLE KEYS */;
INSERT INTO `musicos` VALUES (1,'Geddy Lee','Gary Lee Weinrib','Baixo',_binary ''),(2,'Alex Lifeson','Aleksandar Živojinović','Guitarra',_binary ''),(3,'Neil Peart','Neil Ellwood Peart','Bateria',_binary ''),(4,'Keith Emerson','Keith Noel Emerson','Teclado',_binary ''),(5,'Greg Lake','Gregory Stuart Lake','Guitarra',_binary ''),(6,'Carl Parlmer','Carl Frederick Kendall Palmer','Bateria',_binary ''),(7,'Riche Kotzen','Richard Dale Kotzen Jr.','Guitarra',_binary ''),(8,'Billy Sheehan','William Sheehan','Baixo',_binary ''),(9,'Mike Portnoy','Michael Stephen Portnoy','Bateria',_binary ''),(10,'Jeff Scott Soto','Jeff Scott Soto','Vocal',_binary ''),(11,'Derek Sherinian','Derek Sherinian','Teclado',_binary ''),(12,'Ron \"Bumblefoot\" Thal','Ronald Jay Blumenthal','Guitarra',_binary ''),(13,'Chuck Schuldiner','Charles Michael Schuldiner','Guitarra',_binary ''),(14,'Steve DiGiorgio','Steven Di Giorgio','Baixo',_binary ''),(15,'Richard Christy','Thomas Richard Christy Jr.','Bateria',_binary ''),(16,'Shannon Hamm','Shannon Hamm','Guitarra',_binary ''),(17,'James Hetfield','James Alan Hetfield','Guitarra',_binary ''),(18,'Klauber Tofanetto','Klauber Pfiffer Tofanetto','Bateria',_binary '\0'),(22,'Klauber Tofanetto','Klauber Pfiffer Tofanetto','Bateria',_binary '');
/*!40000 ALTER TABLE `musicos` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-09-11  5:59:46
