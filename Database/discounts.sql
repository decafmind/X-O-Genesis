-- MySQL dump 10.13  Distrib 5.6.24, for Win32 (x86)
--
-- Host: 127.0.0.1    Database: pos_inventory_db
-- ------------------------------------------------------
-- Server version	5.7.8-rc-log

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
-- Table structure for table `discount_type_tbl`
--

DROP TABLE IF EXISTS `discount_type_tbl`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `discount_type_tbl` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `discount_type` varchar(45) NOT NULL,
  `flag` int(1) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `discount_type_tbl`
--

LOCK TABLES `discount_type_tbl` WRITE;
/*!40000 ALTER TABLE `discount_type_tbl` DISABLE KEYS */;
INSERT INTO `discount_type_tbl` VALUES (1,'Percentage',1),(2,'Fixed',1);
/*!40000 ALTER TABLE `discount_type_tbl` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `discounts_tbl`
--

DROP TABLE IF EXISTS `discounts_tbl`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `discounts_tbl` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `type` int(2) NOT NULL,
  `descrpt` text NOT NULL,
  `less` decimal(8,2) NOT NULL,
  `flag` int(1) NOT NULL,
  `title` varchar(45) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `title_UNIQUE` (`title`),
  KEY `type_idx` (`type`),
  CONSTRAINT `type` FOREIGN KEY (`type`) REFERENCES `discount_type_tbl` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `discounts_tbl`
--

LOCK TABLES `discounts_tbl` WRITE;
/*!40000 ALTER TABLE `discounts_tbl` DISABLE KEYS */;
INSERT INTO `discounts_tbl` VALUES (1,1,'Senior Citizens and Person with Disabilities',20.00,1,'SC/PWD'),(2,2,'Christmas Discount',100.00,1,'XMAS'),(3,1,'100pcs and above',5.00,1,'BULK'),(4,2,'Holyweek bulk order. Minimum of 500pcs to avail.',100.00,1,'HOLYWEEK'),(5,1,'10% discount on all merchandise. Until Feb, 29 2016',10.00,1,'OPENING'),(6,1,'5% discount on all items. From Dec. 20 - 31 2016 only.',5.00,1,'YEAREND'),(7,1,'3% Discount on all Made in China items. From Feb 5 - 20 2016 ',3.00,1,'CHINESE'),(8,2,'100 pesos less on all single purchase item worth 5000 pesos and above. From Oct. 20 - 25, 2016',100.00,1,'STO.NINO'),(11,2,'EXAMPLE',100.00,0,'SAMPLE');
/*!40000 ALTER TABLE `discounts_tbl` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-02-19 10:56:42
