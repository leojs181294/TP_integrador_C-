CREATE DATABASE  IF NOT EXISTS `datos.db` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `datos.db`;
-- MySQL dump 10.13  Distrib 8.0.34, for Win64 (x86_64)
--
-- Host: localhost    Database: datos.db
-- ------------------------------------------------------
-- Server version	8.2.0

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
-- Table structure for table `fact_notebook`
--

DROP TABLE IF EXISTS `fact_notebook`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `fact_notebook` (
  `id_fact_notebook` int NOT NULL AUTO_INCREMENT,
  `id_fact_prov` int NOT NULL,
  `id_notebook` int NOT NULL,
  `cantidad` int NOT NULL,
  `precio_costo` double NOT NULL,
  `precio_total` double NOT NULL,
  PRIMARY KEY (`id_fact_notebook`,`id_fact_prov`,`id_notebook`),
  UNIQUE KEY `id_fact_prov_UNIQUE` (`id_fact_notebook`),
  KEY `id_fact_prov_idx` (`id_fact_prov`),
  KEY `id_notebook_idx` (`id_notebook`),
  CONSTRAINT `id_fact_prov` FOREIGN KEY (`id_fact_prov`) REFERENCES `fact_prov` (`id_fact_prov`),
  CONSTRAINT `id_notebook_ref_fn` FOREIGN KEY (`id_notebook`) REFERENCES `notebook` (`id_notebook`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `fact_notebook`
--

LOCK TABLES `fact_notebook` WRITE;
/*!40000 ALTER TABLE `fact_notebook` DISABLE KEYS */;
/*!40000 ALTER TABLE `fact_notebook` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `fact_prov`
--

DROP TABLE IF EXISTS `fact_prov`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `fact_prov` (
  `id_fact_prov` int NOT NULL,
  `fecha_compra` datetime NOT NULL,
  `n_factura` varchar(45) NOT NULL,
  `precio_total_fact` double NOT NULL,
  `id_proveedor` int NOT NULL,
  PRIMARY KEY (`id_fact_prov`,`id_proveedor`),
  UNIQUE KEY `idfact_prov_UNIQUE` (`id_fact_prov`),
  UNIQUE KEY `n_factura_UNIQUE` (`n_factura`),
  KEY `id_proveedor_idx` (`id_proveedor`),
  CONSTRAINT `id_proveedor` FOREIGN KEY (`id_proveedor`) REFERENCES `proveedor` (`id_proveedor`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='aca se guardan las facturas que nos da el proveedor';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `fact_prov`
--

LOCK TABLES `fact_prov` WRITE;
/*!40000 ALTER TABLE `fact_prov` DISABLE KEYS */;
/*!40000 ALTER TABLE `fact_prov` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `notebook`
--

DROP TABLE IF EXISTS `notebook`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `notebook` (
  `id_notebook` int NOT NULL AUTO_INCREMENT,
  `marca` varchar(45) NOT NULL,
  `modelo` varchar(45) NOT NULL,
  `precio_unitario` double NOT NULL,
  `stock_valorizado` double NOT NULL,
  `stock` int NOT NULL,
  `procesador` varchar(45) NOT NULL,
  `veloc_cpu` int NOT NULL,
  `nucleos` int NOT NULL,
  `mem_video` int NOT NULL,
  `sis_operativo` varchar(45) NOT NULL,
  `hdd` int NOT NULL,
  `ssd` int NOT NULL,
  `puertos_usb` int NOT NULL,
  `red_rj45` tinyint NOT NULL,
  PRIMARY KEY (`id_notebook`),
  UNIQUE KEY `idnotebook_UNIQUE` (`id_notebook`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='Aqui se guardan las notebooks';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `notebook`
--

LOCK TABLES `notebook` WRITE;
/*!40000 ALTER TABLE `notebook` DISABLE KEYS */;
/*!40000 ALTER TABLE `notebook` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `notebook_venta`
--

DROP TABLE IF EXISTS `notebook_venta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `notebook_venta` (
  `id_notebook_venta` int NOT NULL AUTO_INCREMENT,
  `id_notebook` int NOT NULL,
  `id_venta` int NOT NULL,
  `cantidad` int NOT NULL,
  `precio_final` double NOT NULL,
  PRIMARY KEY (`id_notebook_venta`,`id_notebook`,`id_venta`),
  KEY `id_notebook_idx` (`id_notebook`),
  KEY `id_venta_idx` (`id_venta`),
  CONSTRAINT `id_notebook_ref_nv` FOREIGN KEY (`id_notebook`) REFERENCES `notebook` (`id_notebook`),
  CONSTRAINT `id_venta` FOREIGN KEY (`id_venta`) REFERENCES `venta` (`id_venta`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `notebook_venta`
--

LOCK TABLES `notebook_venta` WRITE;
/*!40000 ALTER TABLE `notebook_venta` DISABLE KEYS */;
/*!40000 ALTER TABLE `notebook_venta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `proveedor`
--

DROP TABLE IF EXISTS `proveedor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `proveedor` (
  `id_proveedor` int NOT NULL AUTO_INCREMENT,
  `nombre_proveedor` varchar(45) NOT NULL,
  `cel_prov` int NOT NULL,
  `nom_distribuidora` varchar(45) NOT NULL,
  `direccion_prov` varchar(45) NOT NULL,
  PRIMARY KEY (`id_proveedor`),
  UNIQUE KEY `idproveedor_UNIQUE` (`id_proveedor`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `proveedor`
--

LOCK TABLES `proveedor` WRITE;
/*!40000 ALTER TABLE `proveedor` DISABLE KEYS */;
/*!40000 ALTER TABLE `proveedor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `venta`
--

DROP TABLE IF EXISTS `venta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `venta` (
  `id_venta` int NOT NULL AUTO_INCREMENT,
  `fecha_hora` datetime NOT NULL,
  `garantia_compra` datetime NOT NULL,
  `dni_comprador` int NOT NULL,
  `nom_apellido_comprador` varchar(45) NOT NULL,
  `precio_final` double NOT NULL,
  PRIMARY KEY (`id_venta`),
  UNIQUE KEY `id_venta_UNIQUE` (`id_venta`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='Aqui guardaremos las ventas';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `venta`
--

LOCK TABLES `venta` WRITE;
/*!40000 ALTER TABLE `venta` DISABLE KEYS */;
/*!40000 ALTER TABLE `venta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'datos.db'
--

--
-- Dumping routines for database 'datos.db'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-11-12 17:26:04
