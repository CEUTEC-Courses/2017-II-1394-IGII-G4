-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: localhost    Database: tcs_db
-- ------------------------------------------------------
-- Server version	5.7.18-log

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
-- Table structure for table `flota`
--

DROP TABLE IF EXISTS `flota`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `flota` (
  `FlotaID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Empresa` varchar(100) DEFAULT NULL,
  `Dueno` varchar(100) DEFAULT NULL,
  `Codigo` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`FlotaID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `flota`
--

LOCK TABLES `flota` WRITE;
/*!40000 ALTER TABLE `flota` DISABLE KEYS */;
/*!40000 ALTER TABLE `flota` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `flotaunidad`
--

DROP TABLE IF EXISTS `flotaunidad`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `flotaunidad` (
  `FlotaUnidadID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `FlotaID` int(10) unsigned DEFAULT NULL,
  `UnidadID` int(10) unsigned DEFAULT NULL,
  PRIMARY KEY (`FlotaUnidadID`),
  KEY `FKFlotaRol` (`FlotaID`),
  KEY `FKUnidadFlota` (`UnidadID`),
  CONSTRAINT `FKFlotaRol` FOREIGN KEY (`FlotaID`) REFERENCES `flota` (`FlotaID`),
  CONSTRAINT `FKUnidadFlota` FOREIGN KEY (`UnidadID`) REFERENCES `unidad` (`UnidadID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `flotaunidad`
--

LOCK TABLES `flotaunidad` WRITE;
/*!40000 ALTER TABLE `flotaunidad` DISABLE KEYS */;
/*!40000 ALTER TABLE `flotaunidad` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `persona`
--

DROP TABLE IF EXISTS `persona`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `persona` (
  `PersonaID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `NombrePersona` varchar(100) DEFAULT NULL,
  `Licencia` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`PersonaID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `persona`
--

LOCK TABLES `persona` WRITE;
/*!40000 ALTER TABLE `persona` DISABLE KEYS */;
/*!40000 ALTER TABLE `persona` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `personarol`
--

DROP TABLE IF EXISTS `personarol`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `personarol` (
  `PersonaRol` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `PersonaID` int(10) unsigned DEFAULT NULL,
  `RolID` int(10) unsigned DEFAULT NULL,
  PRIMARY KEY (`PersonaRol`),
  KEY `FKPersonaRol` (`PersonaID`),
  KEY `FKRolPersona` (`RolID`),
  CONSTRAINT `FKPersonaRol` FOREIGN KEY (`PersonaID`) REFERENCES `persona` (`PersonaID`),
  CONSTRAINT `FKRolPersona` FOREIGN KEY (`RolID`) REFERENCES `rol` (`RolId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `personarol`
--

LOCK TABLES `personarol` WRITE;
/*!40000 ALTER TABLE `personarol` DISABLE KEYS */;
/*!40000 ALTER TABLE `personarol` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `punto`
--

DROP TABLE IF EXISTS `punto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `punto` (
  `PuntoID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `NombrePunto` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`PuntoID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `punto`
--

LOCK TABLES `punto` WRITE;
/*!40000 ALTER TABLE `punto` DISABLE KEYS */;
/*!40000 ALTER TABLE `punto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `rol`
--

DROP TABLE IF EXISTS `rol`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `rol` (
  `RolId` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `NombreRol` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`RolId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rol`
--

LOCK TABLES `rol` WRITE;
/*!40000 ALTER TABLE `rol` DISABLE KEYS */;
/*!40000 ALTER TABLE `rol` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ruta`
--

DROP TABLE IF EXISTS `ruta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ruta` (
  `RutaID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `NombreRuta` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`RutaID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ruta`
--

LOCK TABLES `ruta` WRITE;
/*!40000 ALTER TABLE `ruta` DISABLE KEYS */;
/*!40000 ALTER TABLE `ruta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `rutapunto`
--

DROP TABLE IF EXISTS `rutapunto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `rutapunto` (
  `RutaPuntoID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `RutaID` int(10) unsigned DEFAULT NULL,
  `PuntoID` int(10) unsigned DEFAULT NULL,
  PRIMARY KEY (`RutaPuntoID`),
  KEY `FKRutaPunto` (`RutaID`),
  KEY `FKPuntoRuta` (`PuntoID`),
  CONSTRAINT `FKPuntoRuta` FOREIGN KEY (`PuntoID`) REFERENCES `punto` (`PuntoID`),
  CONSTRAINT `FKRutaPunto` FOREIGN KEY (`RutaID`) REFERENCES `ruta` (`RutaID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rutapunto`
--

LOCK TABLES `rutapunto` WRITE;
/*!40000 ALTER TABLE `rutapunto` DISABLE KEYS */;
/*!40000 ALTER TABLE `rutapunto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `unidad`
--

DROP TABLE IF EXISTS `unidad`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `unidad` (
  `UnidadID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Placa` varchar(20) DEFAULT NULL,
  `Marca` varchar(30) DEFAULT NULL,
  `Modelo` varchar(30) DEFAULT NULL,
  `Estado` varchar(30) DEFAULT NULL,
  `Anio` int(11) DEFAULT NULL,
  PRIMARY KEY (`UnidadID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `unidad`
--

LOCK TABLES `unidad` WRITE;
/*!40000 ALTER TABLE `unidad` DISABLE KEYS */;
/*!40000 ALTER TABLE `unidad` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `vflotaunidad`
--

DROP TABLE IF EXISTS `vflotaunidad`;
/*!50001 DROP VIEW IF EXISTS `vflotaunidad`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `vflotaunidad` AS SELECT 
 1 AS `Empresa`,
 1 AS `Dueno`,
 1 AS `Codigo`,
 1 AS `Placa`,
 1 AS `Marca`,
 1 AS `Modelo`,
 1 AS `Anio`,
 1 AS `Estado`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `viaje`
--

DROP TABLE IF EXISTS `viaje`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `viaje` (
  `VaijeID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `UnidadID` int(10) unsigned DEFAULT NULL,
  `RutaID` int(10) unsigned DEFAULT NULL,
  `PersonaID` int(10) unsigned DEFAULT NULL,
  `FechaPartida` date DEFAULT NULL,
  `FechaRegreso` date DEFAULT NULL,
  `Descripcion` varchar(100) DEFAULT NULL,
  `Orden` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`VaijeID`),
  KEY `FKVaijeUnidad` (`UnidadID`),
  KEY `FKVaijeRuta` (`RutaID`),
  KEY `FKVaijePersona` (`PersonaID`),
  CONSTRAINT `FKVaijePersona` FOREIGN KEY (`PersonaID`) REFERENCES `persona` (`PersonaID`),
  CONSTRAINT `FKVaijeRuta` FOREIGN KEY (`RutaID`) REFERENCES `ruta` (`RutaID`),
  CONSTRAINT `FKVaijeUnidad` FOREIGN KEY (`UnidadID`) REFERENCES `unidad` (`UnidadID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `viaje`
--

LOCK TABLES `viaje` WRITE;
/*!40000 ALTER TABLE `viaje` DISABLE KEYS */;
/*!40000 ALTER TABLE `viaje` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `vpersonarol`
--

DROP TABLE IF EXISTS `vpersonarol`;
/*!50001 DROP VIEW IF EXISTS `vpersonarol`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `vpersonarol` AS SELECT 
 1 AS `NombrePersona`,
 1 AS `Licencia`,
 1 AS `NombreRol`,
 1 AS `RolID`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `vrutapunto`
--

DROP TABLE IF EXISTS `vrutapunto`;
/*!50001 DROP VIEW IF EXISTS `vrutapunto`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `vrutapunto` AS SELECT 
 1 AS `NombreRuta`,
 1 AS `Punto`*/;
SET character_set_client = @saved_cs_client;

--
-- Final view structure for view `vflotaunidad`
--

/*!50001 DROP VIEW IF EXISTS `vflotaunidad`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `vflotaunidad` AS select `f`.`Empresa` AS `Empresa`,`f`.`Dueno` AS `Dueno`,`f`.`Codigo` AS `Codigo`,`u`.`Placa` AS `Placa`,`u`.`Marca` AS `Marca`,`u`.`Modelo` AS `Modelo`,`u`.`Anio` AS `Anio`,`u`.`Estado` AS `Estado` from ((`flota` `f` join `flotaunidad` `fu` on((`f`.`FlotaID` = `fu`.`FlotaID`))) join `unidad` `u` on((`fu`.`UnidadID` = `u`.`UnidadID`))) order by `f`.`Empresa` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `vpersonarol`
--

/*!50001 DROP VIEW IF EXISTS `vpersonarol`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `vpersonarol` AS select `p`.`NombrePersona` AS `NombrePersona`,`p`.`Licencia` AS `Licencia`,`r`.`NombreRol` AS `NombreRol`,`r`.`RolId` AS `RolID` from ((`persona` `p` join `personarol` `pr` on((`p`.`PersonaID` = `pr`.`PersonaID`))) join `rol` `r` on((`pr`.`RolID` = `r`.`RolId`))) order by `p`.`NombrePersona` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `vrutapunto`
--

/*!50001 DROP VIEW IF EXISTS `vrutapunto`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `vrutapunto` AS select `r`.`NombreRuta` AS `NombreRuta`,`p`.`NombrePunto` AS `Punto` from ((`ruta` `r` join `rutapunto` `rp` on((`r`.`RutaID` = `rp`.`RutaID`))) join `punto` `p` on((`rp`.`PuntoID` = `p`.`PuntoID`))) order by `r`.`NombreRuta` */;
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

-- Dump completed on 2017-05-23 23:16:13
