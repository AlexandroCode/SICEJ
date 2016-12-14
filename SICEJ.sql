CREATE DATABASE  IF NOT EXISTS `sicej` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `sicej`;
-- MySQL dump 10.13  Distrib 5.7.12, for Win64 (x86_64)
--
-- Host: localhost    Database: sicej
-- ------------------------------------------------------
-- Server version	5.7.15-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `t_escolaridad`
--

DROP TABLE IF EXISTS `t_escolaridad`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_escolaridad` (
  `ID_escolaridad` int(11) NOT NULL,
  `descripcion` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`ID_escolaridad`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_escolaridad`
--

LOCK TABLES `t_escolaridad` WRITE;
/*!40000 ALTER TABLE `t_escolaridad` DISABLE KEYS */;
/*!40000 ALTER TABLE `t_escolaridad` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_expediente`
--

DROP TABLE IF EXISTS `t_expediente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_expediente` (
  `ID_expediente` int(11) NOT NULL,
  `Nombre` varchar(45) DEFAULT NULL,
  `App` varchar(45) DEFAULT NULL,
  `Apm` varchar(45) DEFAULT NULL,
  `Rfc` varchar(45) DEFAULT NULL,
  `Apodo` varchar(45) DEFAULT NULL,
  `Genero` varchar(45) DEFAULT NULL,
  `LugarNacimiento` varchar(45) DEFAULT NULL,
  `FechaNacimiento` varchar(20) DEFAULT NULL,
  `EstadoCivil` varchar(1) DEFAULT NULL,
  `ID_escolaridad` int(11) DEFAULT NULL,
  `Ocupacion` varchar(45) DEFAULT NULL,
  `GrupoEtnico` varchar(45) DEFAULT NULL,
  `Conyuge` varchar(100) DEFAULT NULL,
  `NomPat` varchar(20) DEFAULT NULL,
  `NomMat` varchar(20) DEFAULT NULL,
  `Telefono` varchar(14) DEFAULT NULL,
  `Parentezco` varchar(45) DEFAULT NULL,
  `ID_nacionalidad` int(11) DEFAULT NULL,
  PRIMARY KEY (`ID_expediente`),
  KEY `fk_nacionalidad_idx` (`ID_nacionalidad`),
  KEY `fk_escolaridad_idx` (`ID_escolaridad`),
  CONSTRAINT `fk_escolaridad` FOREIGN KEY (`ID_escolaridad`) REFERENCES `t_escolaridad` (`ID_escolaridad`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_nacionalidad` FOREIGN KEY (`ID_nacionalidad`) REFERENCES `t_nacionalidad` (`ID_nacionalidad`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_expediente`
--

LOCK TABLES `t_expediente` WRITE;
/*!40000 ALTER TABLE `t_expediente` DISABLE KEYS */;
/*!40000 ALTER TABLE `t_expediente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_nacionalidad`
--

DROP TABLE IF EXISTS `t_nacionalidad`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_nacionalidad` (
  `ID_nacionalidad` int(11) NOT NULL,
  `Descripcion` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`ID_nacionalidad`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_nacionalidad`
--

LOCK TABLES `t_nacionalidad` WRITE;
/*!40000 ALTER TABLE `t_nacionalidad` DISABLE KEYS */;
/*!40000 ALTER TABLE `t_nacionalidad` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_usuarios`
--

DROP TABLE IF EXISTS `t_usuarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_usuarios` (
  `Usuario` varchar(45) DEFAULT NULL,
  `Contraseña` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_usuarios`
--

LOCK TABLES `t_usuarios` WRITE;
/*!40000 ALTER TABLE `t_usuarios` DISABLE KEYS */;
/*!40000 ALTER TABLE `t_usuarios` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-12-12 15:49:07
