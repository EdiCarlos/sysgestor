-- MySQL dump 10.13  Distrib 5.6.24, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: sysgestor
-- ------------------------------------------------------
-- Server version	5.6.25-log

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
-- Table structure for table `pessoa`
--

DROP TABLE IF EXISTS `pessoa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pessoa` (
  `idpessoa` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(100) NOT NULL,
  `tipopessoa` varchar(25) DEFAULT NULL,
  `cpfcnpj` varchar(20) DEFAULT NULL,
  `rgie` varchar(20) DEFAULT NULL,
  `datanascimento` date DEFAULT NULL,
  `datacadastro` date DEFAULT NULL,
  `ativo` int(11) NOT NULL DEFAULT '0',
  `observacao` longtext,
  PRIMARY KEY (`idpessoa`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pessoa`
--

LOCK TABLES `pessoa` WRITE;
/*!40000 ALTER TABLE `pessoa` DISABLE KEYS */;
INSERT INTO `pessoa` VALUES (1,'Analise','Jurídica','111.111.111-11','1111111','0001-01-01','2015-07-24',0,NULL),(2,'ddddddd','Jurídica','.   .   -','','0001-01-01','2015-07-27',0,NULL),(3,'ddddddd','Jurídica','.   .   -','','0001-01-01','2015-07-27',0,NULL),(4,'wwwwwwwwwww','Jurídica','111.111.111-11','1111111111','0001-01-01','2015-07-27',0,NULL),(5,'wwwwwwwwww','Jurídica','111.111.111-11','1111111','0001-01-01','2015-07-27',0,NULL),(6,'wwwwwwwwww','Jurídica','111.111.111-11','1111111','0001-01-01','2015-07-27',0,NULL),(7,'Edi Carlos Simões de Oliveira','Física','111.111.111-11','11111111','1900-09-10','2015-07-28',0,'ok'),(8,'Modelo 123','Física','111.111.111-11','11111111111','1900-12-12','2015-07-28',0,''),(9,'Da Esquerda ok','Jurídica','11.111.111/1111-11','11111111','1111-11-11','2015-07-28',0,''),(10,'Analise',NULL,'','','0001-01-01','0001-01-01',0,''),(11,'Admin',NULL,NULL,NULL,'0001-01-01','0001-01-01',0,NULL);
/*!40000 ALTER TABLE `pessoa` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2015-07-31 19:24:36
