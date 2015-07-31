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
-- Table structure for table `movestoque`
--

DROP TABLE IF EXISTS `movestoque`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `movestoque` (
  `idmovestoque` int(11) NOT NULL AUTO_INCREMENT,
  `idproduto` int(11) NOT NULL,
  `codigointerno` varchar(45) NOT NULL,
  `documento` varchar(45) DEFAULT NULL,
  `qtd` decimal(12,3) NOT NULL,
  `data` datetime NOT NULL,
  `operacao` char(1) NOT NULL COMMENT '''C'' = Crédito  ''D'' = Débi',
  `observacao` longtext,
  `idusuario` int(11) NOT NULL,
  `idunidmedida` int(11) NOT NULL,
  PRIMARY KEY (`idmovestoque`),
  KEY `fk_movestoque_usuario1_idx` (`idusuario`),
  KEY `fk_movestoque_unidmedida1_idx` (`idunidmedida`),
  KEY `fk_movestoque_produto1` (`idproduto`,`codigointerno`),
  CONSTRAINT `fk_movestoque_produto1` FOREIGN KEY (`idproduto`, `codigointerno`) REFERENCES `produto` (`idproduto`, `codigointerno`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_movestoque_unidmedida1` FOREIGN KEY (`idunidmedida`) REFERENCES `unidmedida` (`idunidmedida`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_movestoque_usuario1` FOREIGN KEY (`idusuario`) REFERENCES `usuario` (`idusuario`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `movestoque`
--

LOCK TABLES `movestoque` WRITE;
/*!40000 ALTER TABLE `movestoque` DISABLE KEYS */;
/*!40000 ALTER TABLE `movestoque` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2015-07-31 19:24:37
