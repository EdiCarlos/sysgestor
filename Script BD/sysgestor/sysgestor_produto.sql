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
-- Table structure for table `produto`
--

DROP TABLE IF EXISTS `produto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `produto` (
  `idproduto` int(11) NOT NULL AUTO_INCREMENT,
  `codigointerno` varchar(45) NOT NULL,
  `referencia` varchar(45) DEFAULT NULL,
  `descricao` varchar(100) NOT NULL,
  `marca` varchar(60) DEFAULT NULL,
  `estoque` decimal(12,3) DEFAULT NULL,
  `estoqueminimo` decimal(12,3) DEFAULT NULL,
  `localizacaofisica` varchar(20) DEFAULT NULL COMMENT 'Localização do produto na loja.',
  `observacao` longtext,
  `ativo` int(11) NOT NULL DEFAULT '0',
  `idcategoria` int(11) NOT NULL,
  `idgrade` int(11) DEFAULT NULL,
  `idfornecedor` int(11) DEFAULT NULL,
  `idunidmedida` int(11) NOT NULL,
  `idempresa` int(11) DEFAULT NULL,
  PRIMARY KEY (`idproduto`,`codigointerno`),
  KEY `fk_produto_categoria1_idx` (`idcategoria`),
  KEY `fk_produto_grade1_idx` (`idgrade`),
  KEY `fk_produto_fornecedor1_idx` (`idfornecedor`),
  KEY `fk_produto_unidmedida1_idx` (`idunidmedida`),
  CONSTRAINT `fk_produto_categoria1` FOREIGN KEY (`idcategoria`) REFERENCES `categoria` (`idcategoria`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_produto_fornecedor1` FOREIGN KEY (`idfornecedor`) REFERENCES `fornecedor` (`idfornecedor`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_produto_grade1` FOREIGN KEY (`idgrade`) REFERENCES `grade` (`idgrade`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_produto_unidmedida1` FOREIGN KEY (`idunidmedida`) REFERENCES `unidmedida` (`idunidmedida`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `produto`
--

LOCK TABLES `produto` WRITE;
/*!40000 ALTER TABLE `produto` DISABLE KEYS */;
INSERT INTO `produto` VALUES (2,'0000001111','1111','Produto 1','Marca 1',NULL,2.000,'Prateleira A','okokok',1,3,1,1,1,1),(3,'0000000222','222','Produto 2','Marca 1',NULL,2.000,'A1','okokokok',0,3,2,1,1,1),(4,'0000001234','1234','Vestido Xiz','Xiz',NULL,2.000,'Prateleira 1','ok',0,3,2,1,1,1);
/*!40000 ALTER TABLE `produto` ENABLE KEYS */;
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
