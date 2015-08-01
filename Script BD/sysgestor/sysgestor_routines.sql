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
-- Temporary view structure for view `vwempresa`
--

DROP TABLE IF EXISTS `vwempresa`;
/*!50001 DROP VIEW IF EXISTS `vwempresa`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `vwempresa` AS SELECT 
 1 AS `idempresa`,
 1 AS `idpessoa`,
 1 AS `nomefantasia`,
 1 AS `logo`,
 1 AS `nome`,
 1 AS `cpfcnpj`,
 1 AS `rgie`,
 1 AS `logradouro`,
 1 AS `numero`,
 1 AS `complemento`,
 1 AS `bairro`,
 1 AS `cep`,
 1 AS `idcidade`,
 1 AS `telfixo`,
 1 AS `telcel`,
 1 AS `telcomercial`,
 1 AS `email`,
 1 AS `cidade`,
 1 AS `uf`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `vwproduto`
--

DROP TABLE IF EXISTS `vwproduto`;
/*!50001 DROP VIEW IF EXISTS `vwproduto`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `vwproduto` AS SELECT 
 1 AS `idproduto`,
 1 AS `referencia`,
 1 AS `codigointerno`,
 1 AS `descricao`,
 1 AS `marca`,
 1 AS `estoque`,
 1 AS `estoqueminimo`,
 1 AS `localizacaofisica`,
 1 AS `observacao`,
 1 AS `idcategoria`,
 1 AS `idgrade`,
 1 AS `idunidmedida`,
 1 AS `idfornecedor`,
 1 AS `ativo`,
 1 AS `categoria`,
 1 AS `grade`,
 1 AS `unidademedida`,
 1 AS `fornecedor`*/;
SET character_set_client = @saved_cs_client;

--
-- Final view structure for view `vwempresa`
--

/*!50001 DROP VIEW IF EXISTS `vwempresa`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `vwempresa` AS select `a`.`idempresa` AS `idempresa`,`a`.`idpessoa` AS `idpessoa`,`a`.`nomefantasia` AS `nomefantasia`,`a`.`logo` AS `logo`,`b`.`nome` AS `nome`,`b`.`cpfcnpj` AS `cpfcnpj`,`b`.`rgie` AS `rgie`,`c`.`logradouro` AS `logradouro`,`c`.`numero` AS `numero`,`c`.`complemento` AS `complemento`,`c`.`bairro` AS `bairro`,`c`.`cep` AS `cep`,`c`.`idcidade` AS `idcidade`,`d`.`telfixo` AS `telfixo`,`d`.`telcel` AS `telcel`,`d`.`telcomercial` AS `telcomercial`,`d`.`email` AS `email`,`e`.`cidade` AS `cidade`,`e`.`uf` AS `uf` from ((((`empresa` `a` join `pessoa` `b` on((`a`.`idpessoa` = `b`.`idpessoa`))) join `endereco` `c` on((`c`.`idpessoa` = `a`.`idpessoa`))) join `contato` `d` on((`d`.`idpessoa` = `a`.`idpessoa`))) join `cidade` `e` on((`e`.`idcidade` = `c`.`idcidade`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `vwproduto`
--

/*!50001 DROP VIEW IF EXISTS `vwproduto`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `vwproduto` AS select `produto`.`idproduto` AS `idproduto`,`produto`.`referencia` AS `referencia`,`produto`.`codigointerno` AS `codigointerno`,`produto`.`descricao` AS `descricao`,`produto`.`marca` AS `marca`,`produto`.`estoque` AS `estoque`,`produto`.`estoqueminimo` AS `estoqueminimo`,`produto`.`localizacaofisica` AS `localizacaofisica`,`produto`.`observacao` AS `observacao`,`produto`.`idcategoria` AS `idcategoria`,`produto`.`idgrade` AS `idgrade`,`produto`.`idunidmedida` AS `idunidmedida`,`produto`.`idfornecedor` AS `idfornecedor`,`produto`.`ativo` AS `ativo`,`categoria`.`descricao` AS `categoria`,`grade`.`descricao` AS `grade`,`unidmedida`.`descricao` AS `unidademedida`,(select `pessoa`.`nome` from `pessoa` where (`pessoa`.`idpessoa` = (select `fornecedor`.`idpessoa` from `fornecedor` where (`fornecedor`.`idfornecedor` = `produto`.`idfornecedor`)))) AS `fornecedor` from ((((`produto` join `categoria` on((`produto`.`idcategoria` = `categoria`.`idcategoria`))) join `grade` on((`produto`.`idgrade` = `grade`.`idgrade`))) join `unidmedida` on((`produto`.`idunidmedida` = `unidmedida`.`idunidmedida`))) join `fornecedor` on((`produto`.`idfornecedor` = `fornecedor`.`idfornecedor`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2015-07-31 19:24:38
