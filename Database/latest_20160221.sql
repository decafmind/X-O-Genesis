-- MySQL dump 10.13  Distrib 5.6.17, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: pos_inventory_db
-- ------------------------------------------------------
-- Server version	5.7.6-m16-log

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
-- Table structure for table `audit_trail_tbl`
--

DROP TABLE IF EXISTS `audit_trail_tbl`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `audit_trail_tbl` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `employee_id` varchar(45) NOT NULL,
  `receipt_id` int(11) DEFAULT NULL,
  `activity` longtext,
  `date` date DEFAULT NULL,
  `time` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `audit_receipt_fk_idx` (`receipt_id`),
  CONSTRAINT `audit_receipt_fk` FOREIGN KEY (`receipt_id`) REFERENCES `receipt_tbl` (`invoice_id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=152 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `audit_trail_tbl`
--

LOCK TABLES `audit_trail_tbl` WRITE;
/*!40000 ALTER TABLE `audit_trail_tbl` DISABLE KEYS */;
INSERT INTO `audit_trail_tbl` VALUES (1,'Rabi',NULL,'added new User saito007','2016-01-17','12:4:26'),(2,'Randy',NULL,'completed a transaction: POS_00041','2016-01-17','18:8:8'),(3,'Randy',NULL,'completed a transaction: POS_00045','2016-01-18','14:48:15'),(4,'Randy',NULL,'completed a transaction: POS_00048','2016-01-18','14:51:51'),(5,'Randy',NULL,'completed a transaction: POS_00050','2016-01-18','14:55:0'),(6,'Karen',NULL,'completed a transaction: Payment: Php 300.00','2016-01-18','14:56:4'),(7,'Randy',NULL,'completed a transaction: POS_00054','2016-01-18','14:59:48'),(8,'Karen',NULL,'completed a transaction: Payment: Php 500.00','2016-01-18','15:1:43'),(9,'Karen',NULL,'completed a transaction: Payment: Php 400.00','2016-01-18','15:3:36'),(10,'Karen',NULL,'completed a transaction: Payment: Php 400.00','2016-01-18','15:6:48'),(11,'Karen',NULL,'completed a transaction: Payment: Php 400.00','2016-01-18','15:7:49'),(12,'Jerwin',NULL,'added a new stock of product','2016-01-19','21:23:26'),(13,'Jerwin',NULL,'has added a new product','2016-01-19','21:23:26'),(14,'Randy',NULL,'completed a transaction: POS_00072','2016-01-20','20:37:14'),(15,'Randy',NULL,'completed a transaction: POS_00075','2016-01-20','20:45:0'),(16,'Randy',NULL,'completed a transaction: POS_00080','2016-01-20','23:51:48'),(17,'Karen',NULL,'completed a transaction: Payment: Php 3,000.00','2016-01-21','0:2:15'),(18,'Karen',NULL,'completed a transaction: Payment: Php 0.00','2016-01-21','0:2:40'),(19,'Randy',NULL,'completed a transaction: POS_00086','2016-01-21','0:43:21'),(20,'Randy',NULL,'completed a transaction: POS_00087','2016-01-21','0:51:15'),(21,'Karen',NULL,'completed a transaction: Payment: Php 6,000.00','2016-01-21','0:54:14'),(22,'Randy',NULL,'completed a transaction: POS_00090','2016-01-21','1:42:3'),(23,'Randy',NULL,'completed a transaction: POS_00092','2016-01-21','1:45:0'),(24,'Karen',NULL,'completed a transaction: Payment: Php 400.00','2016-01-21','1:48:3'),(25,'Randy',NULL,'completed a transaction: POS_00095','2016-01-21','1:52:27'),(26,'Karen',NULL,'completed a transaction: Payment: Php 2,000.00','2016-01-21','1:53:46'),(27,'Jerwin',NULL,'added a new stock of product','2016-01-24','15:51:20'),(28,'Jerwin',NULL,'has added a new product','2016-01-24','15:51:21'),(29,'Jerwin',NULL,'added a new stock of product','2016-01-24','15:58:45'),(30,'Jerwin',NULL,'has added a new product','2016-01-24','15:58:45'),(31,'Jerwin',NULL,'added a new stock of product','2016-01-24','16:10:7'),(32,'Jerwin',NULL,'added a new stock of product','2016-01-24','16:12:30'),(33,'Jerwin',NULL,'added a new stock of product','2016-01-24','16:13:2'),(34,'Jerwin',NULL,'has updated the product A','2016-01-24','16:53:25'),(35,'Jerwin',NULL,'has updated the product A','2016-01-24','17:18:31'),(36,'Jerwin',NULL,'has updated the product A slim notebook','2016-01-24','17:23:47'),(37,'Randy',NULL,'completed a transaction: POS_00098','2016-01-24','17:30:24'),(38,'Karen',NULL,'completed a transaction: Payment: Php 300.00','2016-01-24','17:31:30'),(39,'Jerwin',NULL,'has updated the product A slim notebook','2016-01-24','17:34:15'),(40,'Jerwin',NULL,'has updated the product Cherry mobile','2016-01-24','17:36:31'),(41,'Jerwin',NULL,'added a new stock of product','2016-01-24','21:7:25'),(42,'Jerwin',NULL,'has added a new product','2016-01-24','21:7:25'),(43,'Jerwin',NULL,'has updated the product Mechanical Safety Edge','2016-01-24','21:8:22'),(44,'Jerwin',NULL,'added a new stock of product','2016-01-24','21:18:44'),(45,'Jerwin',NULL,'has added a new product','2016-01-24','21:18:44'),(46,'Jerwin',NULL,'added a new stock of product','2016-01-24','21:19:17'),(47,'Jerwin',NULL,'has added a new product','2016-01-24','21:19:17'),(48,'Jerwin',NULL,'has updated the product FLAP BARRIER GATE','2016-01-24','21:20:52'),(49,'Rabi',NULL,'updated User Rabi','2016-01-26','11:40:7'),(50,'Rabi',NULL,'updated User Randy','2016-01-26','11:44:11'),(51,'Rabi',NULL,'updated User Randy','2016-01-26','11:47:7'),(52,'Rabi',NULL,'updated User Jerwin','2016-01-26','11:49:1'),(53,'Rabi',NULL,'updated User Rabi','2016-01-26','11:52:41'),(54,'Rabi',NULL,'updated User Rabi','2016-01-26','11:55:0'),(55,'Rabi',NULL,'updated User Rabi','2016-01-26','12:0:46'),(56,'Rabi',NULL,'updated User Rabi','2016-01-26','12:2:38'),(57,'Rabi',NULL,'updated User Rabi','2016-01-26','12:12:31'),(58,'Rabi',NULL,'updated User Rabi','2016-02-09','4:59:2'),(59,'Rabi',NULL,'updated User Rabi','2016-02-09','5:3:41'),(60,'Rabi',NULL,'updated User Rabi','2016-02-09','5:3:59'),(61,'Rabi',NULL,'updated User Rabi','2016-02-10','14:5:4'),(62,'Jerwin',NULL,'added a new stock of product','2016-02-10','14:32:59'),(63,'Jerwin',NULL,'has added a new product','2016-02-10','14:32:59'),(64,'Jerwin',NULL,'added a new stock of product','2016-02-10','14:58:13'),(65,'Jerwin',NULL,'has added a new product','2016-02-10','14:58:13'),(66,'Jerwin',NULL,'added a new stock of product','2016-02-10','14:58:33'),(67,'Jerwin',NULL,'added a new stock of product','2016-02-10','15:0:46'),(68,'Jerwin',NULL,'has added a new product','2016-02-10','15:0:47'),(69,'Karen',NULL,'completed a transaction: POS_00110','2016-02-12','22:0:35'),(70,'Randy',NULL,'completed a transaction: POS_00112','2016-02-12','22:2:11'),(71,'Karen',NULL,'completed a transaction: Payment: Php 500.00','2016-02-12','22:3:7'),(72,'Jerwin',NULL,'added a new stock of product','2016-02-12','22:3:47'),(73,'Jerwin',NULL,'added a new stock of product','2016-02-12','22:10:34'),(74,'Rabi',NULL,'has updated the product Ultima','2016-02-12','22:11:1'),(75,'Karen',NULL,'completed a transaction: POS_00116','2016-02-12','22:13:31'),(76,'Randy',NULL,'completed a transaction: POS_00118','2016-02-12','22:14:5'),(77,'Karen',NULL,'completed a transaction: Payment: Php 300.00','2016-02-12','22:14:57'),(78,'Rabi',NULL,'updated User Rabi','2016-02-14','10:59:8'),(79,'Rabi',NULL,'updated User Rabi','2016-02-14','11:1:54'),(80,'Jerwin',NULL,'added a new stock of product','2016-02-14','13:31:54'),(81,'Rabi',NULL,'added a new stock of product','2016-02-14','14:45:56'),(82,'Rabi',NULL,'has added a new product','2016-02-14','14:45:57'),(83,'Randy',NULL,'completed a transaction: POS_00145','2016-02-14','14:49:41'),(84,'Karen',NULL,'completed a transaction: Payment: Php 160,000.00','2016-02-14','14:54:32'),(85,'Rabi',NULL,'added a new stock of product','2016-02-14','15:50:2'),(86,'Rabi',NULL,'has added a new product','2016-02-14','15:50:2'),(87,'Rabi',NULL,'updated User Karen','2016-02-14','16:7:16'),(88,'Rabi',NULL,'updated User Karen','2016-02-14','15:58:38'),(89,'Karen',NULL,'completed a transaction: Payment: Php 0.00','2016-02-14','16:1:52'),(90,'Karen',NULL,'completed a transaction: Payment: Php 0.00','2016-02-14','16:2:9'),(91,'Karen',NULL,'completed a transaction: Payment: Php 0.00','2016-02-14','16:2:18'),(92,'Karen',NULL,'completed a transaction: Payment: Php 0.00','2016-02-14','16:2:35'),(93,'Karen',NULL,'completed a transaction: Payment: Php 0.00','2016-02-14','16:2:41'),(94,'Randy',NULL,'completed a transaction: POS_00150','2016-02-14','16:5:0'),(95,'Randy',NULL,'completed a transaction: POS_00158','2016-02-14','16:6:1'),(96,'Karen',NULL,'completed a transaction: Payment: Php 800,000.00','2016-02-14','16:9:59'),(97,'Karen',NULL,'updated User Karen','2016-02-14','16:15:59'),(98,'Rabi',NULL,'added a new stock of product','2016-02-14','17:4:44'),(99,'Rabi',NULL,'has added a new product','2016-02-14','17:4:44'),(100,'Rabi',NULL,'added a new stock of product','2016-02-14','17:12:53'),(101,'Rabi',NULL,'has added a new product','2016-02-14','17:12:53'),(102,'Rabi',NULL,'added a new stock of product','2016-02-14','17:14:44'),(103,'Rabi',NULL,'has added a new product','2016-02-14','17:14:44'),(104,'Rabi',NULL,'added a new stock of product','2016-02-14','17:16:16'),(105,'Rabi',NULL,'has added a new product','2016-02-14','17:16:16'),(106,'Rabi',NULL,'added a new stock of product','2016-02-14','17:17:37'),(107,'Rabi',NULL,'has added a new product','2016-02-14','17:17:37'),(108,'Rabi',NULL,'added a new stock of product','2016-02-14','17:20:16'),(109,'Rabi',NULL,'has added a new product','2016-02-14','17:20:16'),(110,'Rabi',NULL,'added a new stock of product','2016-02-14','17:22:33'),(111,'Rabi',NULL,'has added a new product','2016-02-14','17:22:33'),(112,'Rabi',NULL,'added a new stock of product','2016-02-14','17:24:40'),(113,'Rabi',NULL,'has added a new product','2016-02-14','17:24:40'),(114,'Rabi',NULL,'added a new stock of product','2016-02-14','17:26:0'),(115,'Rabi',NULL,'has added a new product','2016-02-14','17:26:1'),(116,'Rabi',NULL,'added a new stock of product','2016-02-14','17:27:34'),(117,'Rabi',NULL,'has added a new product','2016-02-14','17:27:34'),(118,'Rabi',NULL,'added a new stock of product','2016-02-14','17:29:12'),(119,'Rabi',NULL,'has added a new product','2016-02-14','17:29:13'),(120,'Rabi',NULL,'added a new stock of product','2016-02-14','17:34:41'),(121,'Rabi',NULL,'has added a new product','2016-02-14','17:34:41'),(122,'Rabi',NULL,'added a new stock of product','2016-02-14','17:38:49'),(123,'Rabi',NULL,'has added a new product','2016-02-14','17:38:49'),(124,'Rabi',NULL,'added a new stock of product','2016-02-14','17:41:49'),(125,'Rabi',NULL,'has added a new product','2016-02-14','17:41:49'),(126,'Rabi',NULL,'added a new stock of product','2016-02-14','17:45:30'),(127,'Rabi',NULL,'has added a new product','2016-02-14','17:45:30'),(128,'Rabi',NULL,'added a new stock of product','2016-02-14','17:48:16'),(129,'Rabi',NULL,'has added a new product','2016-02-14','17:48:16'),(130,'Rabi',NULL,'added a new stock of product','2016-02-14','17:49:50'),(131,'Rabi',NULL,'has added a new product','2016-02-14','17:49:50'),(132,'Rabi',NULL,'added a new stock of product','2016-02-14','17:52:3'),(133,'Rabi',NULL,'has added a new product','2016-02-14','17:52:3'),(134,'Rabi',NULL,'added a new stock of product','2016-02-14','17:53:54'),(135,'Rabi',NULL,'has added a new product','2016-02-14','17:53:54'),(136,'Rabi',NULL,'added a new stock of product','2016-02-14','17:55:27'),(137,'Rabi',NULL,'has added a new product','2016-02-14','17:55:27'),(138,'Rabi',NULL,'added a new stock of product','2016-02-14','17:57:2'),(139,'Rabi',NULL,'has added a new product','2016-02-14','17:57:2'),(140,'Rabi',NULL,'added a new stock of product','2016-02-14','17:58:45'),(141,'Rabi',NULL,'has added a new product','2016-02-14','17:58:45'),(142,'Rabi',NULL,'added a new stock of product','2016-02-14','18:0:34'),(143,'Rabi',NULL,'has added a new product','2016-02-14','18:0:34'),(144,'Rabi',NULL,'added a new stock of product','2016-02-14','18:2:14'),(145,'Rabi',NULL,'has added a new product','2016-02-14','18:2:14'),(146,'Rabi',NULL,'added a new stock of product','2016-02-14','18:3:35'),(147,'Rabi',NULL,'has added a new product','2016-02-14','18:3:36'),(148,'Rabi',NULL,'added a new stock of product','2016-02-14','18:5:14'),(149,'Rabi',NULL,'has added a new product','2016-02-14','18:5:14'),(150,'Rabi',NULL,'added a new stock of product','2016-02-21','13:49:39'),(151,'Rabi',NULL,'added a new stock of product','2016-02-21','13:50:53');
/*!40000 ALTER TABLE `audit_trail_tbl` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary table structure for view `audit_trail_view`
--

DROP TABLE IF EXISTS `audit_trail_view`;
/*!50001 DROP VIEW IF EXISTS `audit_trail_view`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `audit_trail_view` (
  `date` tinyint NOT NULL,
  `time` tinyint NOT NULL,
  `activity` tinyint NOT NULL,
  `user_id` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Temporary table structure for view `bestsellers`
--

DROP TABLE IF EXISTS `bestsellers`;
/*!50001 DROP VIEW IF EXISTS `bestsellers`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `bestsellers` (
  `Name` tinyint NOT NULL,
  `Item_Sold` tinyint NOT NULL,
  `Percent_Share` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `category_tbl`
--

DROP TABLE IF EXISTS `category_tbl`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `category_tbl` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `category_tbl`
--

LOCK TABLES `category_tbl` WRITE;
/*!40000 ALTER TABLE `category_tbl` DISABLE KEYS */;
INSERT INTO `category_tbl` VALUES (1,'Camera'),(2,'Proximity Card'),(3,'Card'),(4,'Card Readers'),(5,'Door Locks'),(6,'Access Control'),(7,'Panic Button'),(8,'Siren');
/*!40000 ALTER TABLE `category_tbl` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `company_profile_tbl`
--

DROP TABLE IF EXISTS `company_profile_tbl`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `company_profile_tbl` (
  `compname` varchar(70) NOT NULL,
  `address` text,
  `contactno` varchar(13) DEFAULT NULL,
  `email` varchar(45) DEFAULT NULL,
  `logo_path` text,
  `vat_reg_tin` varchar(45) DEFAULT NULL,
  `tax` decimal(5,2) DEFAULT NULL,
  PRIMARY KEY (`compname`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `company_profile_tbl`
--

LOCK TABLES `company_profile_tbl` WRITE;
/*!40000 ALTER TABLE `company_profile_tbl` DISABLE KEYS */;
INSERT INTO `company_profile_tbl` VALUES ('Akira','25 Santiago St,. Quezon City','09195558899','email','H:\\\\\\\\decaf\\Pictures\\Onodera\\Kosaki Onodera.jpg','008-069-074-007',0.12);
/*!40000 ALTER TABLE `company_profile_tbl` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `customer_tbl`
--

DROP TABLE IF EXISTS `customer_tbl`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `customer_tbl` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `firstname` varchar(45) NOT NULL,
  `middlename` varchar(45) NOT NULL,
  `lastname` varchar(45) NOT NULL,
  `mobile_number` varchar(45) DEFAULT NULL,
  `telephone_number` varchar(45) DEFAULT NULL,
  `email_address` varchar(45) DEFAULT NULL,
  `address` varchar(100) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customer_tbl`
--

LOCK TABLES `customer_tbl` WRITE;
/*!40000 ALTER TABLE `customer_tbl` DISABLE KEYS */;
INSERT INTO `customer_tbl` VALUES (1,'jdklfjskl','jfdlkf;','jfdklj','fdjklfjf','fdjklfjf','jfdlskfjsld','dlkfjlds ljflafldj'),(2,'','','','','','',' '),(3,'Raineir Rabi','Ramirez','Abordo','AshleyLoves','09192223456','ashleybabes@gmail.com','Sa puso ni Ashley Sa puso ni Ashley'),(4,'Christopher John','Amper','Ponce','09194441782','09194441782','amorphyst@gmail.com','83 Magsaysay St. Doña Faustina Subd. San Bartolome Novaliches, Quezon City'),(5,'Christopher John','Amper','Ponce','09194441782','09194441782','amorphyst@gmail.com','83 Magsaysay St. Doña Faustina Subd. San Bartolome Novaliches Quezon City'),(6,'Carla Jean','Aragon','Acta','09233005665','09233005665','carlajeanacta@gmail.com','17 Israel Street, Jordan Heights Subd. Novaliches, Q.C. Metro Manila'),(7,'Randy','Cinco','Panol','09264142434','09264142434','decafmind@gmail.com','G44 Abbey Road Bagbag Novaliches Quezon City');
/*!40000 ALTER TABLE `customer_tbl` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary table structure for view `daily_sales_report`
--

DROP TABLE IF EXISTS `daily_sales_report`;
/*!50001 DROP VIEW IF EXISTS `daily_sales_report`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `daily_sales_report` (
  `Date` tinyint NOT NULL,
  `Sales` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

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

--
-- Table structure for table `employee_tbl`
--

DROP TABLE IF EXISTS `employee_tbl`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `employee_tbl` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `user_id` varchar(45) NOT NULL,
  `firstname` varchar(45) NOT NULL,
  `middlename` varchar(45) DEFAULT NULL,
  `lastname` varchar(45) NOT NULL,
  `mobile_no` varchar(45) DEFAULT NULL,
  `telephone_no` varchar(45) DEFAULT NULL,
  `email_address` varchar(45) DEFAULT NULL,
  `address` varchar(45) DEFAULT NULL,
  `image_path` mediumtext,
  PRIMARY KEY (`id`),
  KEY `employee_user_fk_idx` (`user_id`),
  CONSTRAINT `employee_user_id` FOREIGN KEY (`user_id`) REFERENCES `user_tbl` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employee_tbl`
--

LOCK TABLES `employee_tbl` WRITE;
/*!40000 ALTER TABLE `employee_tbl` DISABLE KEYS */;
INSERT INTO `employee_tbl` VALUES (1,'Randy','Randy','C','Panol','09264142434','09264142434','decafmind@gmail.com','G44 Abbey Road Bagbag Novaliches Quezon City','C:\\\\Petvet\\Images\\754282.jpg'),(2,'Francis','Francis','X','Caceres','0933764751','t','akira@google.com','jdlfkj','C:\\\\Petvet\\Images\\233469.jpg'),(3,'Jerwin','Jerwin','V','Alog','093276278','t','jessea@google.com','fjlskdfjl','C:\\\\Petvet\\Images\\334903.jpg'),(4,'Rabi','Rainier','A','Abordo','8490384038403','232-434-23','decafmind@gmail.com','Ewan ko sayo ulet','C:\\\\Users\\Randy\\AppData\\Local\\Exogenesis\\Images\\825958.jpg'),(5,'Karen','Karen','F','Paje','0923263746232','3287328372897','kp@gmail.com','jflskj','C:\\\\Users\\Randy\\AppData\\Local\\Exogenesis\\Images\\139355.jpg'),(6,'jessea','Jessea','R','Malanao','09356080445','232-434-23','jessea@m.com','Dito','C:\\\\Petvet\\Images\\937495.jpg'),(7,'saito007','Francis','R','Caceres','09264142434','123-4456','francissaito@gmail.com','ramirez st.','');
/*!40000 ALTER TABLE `employee_tbl` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `fallback_tbl`
--

DROP TABLE IF EXISTS `fallback_tbl`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `fallback_tbl` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `squery` text,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `fallback_tbl`
--

LOCK TABLES `fallback_tbl` WRITE;
/*!40000 ALTER TABLE `fallback_tbl` DISABLE KEYS */;
INSERT INTO `fallback_tbl` VALUES (1,'Sample question 1.'),(2,'Sample question 2.'),(3,'Sample question 3.'),(4,'Sample question 4.'),(5,'Sample question 5.');
/*!40000 ALTER TABLE `fallback_tbl` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `inventory_tbl`
--

DROP TABLE IF EXISTS `inventory_tbl`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `inventory_tbl` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `product_id` varchar(20) DEFAULT NULL,
  `stockin_datetime` datetime DEFAULT NULL,
  `qty_received` int(11) DEFAULT NULL,
  `qty_onhand` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `inventory_product_tbl_idx` (`product_id`),
  CONSTRAINT `inventory_product_tbl` FOREIGN KEY (`product_id`) REFERENCES `product_tbl` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=29 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `inventory_tbl`
--

LOCK TABLES `inventory_tbl` WRITE;
/*!40000 ALTER TABLE `inventory_tbl` DISABLE KEYS */;
INSERT INTO `inventory_tbl` VALUES (1,'A000001','2016-02-14 17:04:44',20,20),(2,'ABC000025','2016-02-14 17:12:53',20,20),(3,'ABC000013','2016-02-14 17:14:44',100,100),(4,'ABC000005','2016-02-14 17:16:15',100,100),(5,'ABC000020','2016-02-14 17:17:37',100,100),(6,'ABC000022','2016-02-14 17:20:16',100,100),(7,'ABC000009','2016-02-14 17:22:32',100,100),(8,'ABC000026','2016-02-14 17:24:39',100,100),(9,'ABC000015','2016-02-14 17:26:00',100,100),(10,'ABC000014','2016-02-14 17:27:33',100,100),(11,'AB000001','2016-02-14 17:29:12',100,100),(12,'ABC000030','2016-02-14 17:34:41',20,20),(13,'ABC000003','2016-02-14 17:38:48',65,65),(14,'ABC000002','2016-02-14 17:41:48',100,100),(15,'ABC000023','2016-02-14 17:45:30',75,75),(16,'ABC000012','2016-02-14 17:48:15',65,65),(17,'ABC000028','2016-02-14 17:49:50',45,45),(18,'ABC000021','2016-02-14 17:52:02',95,95),(19,'ABC000017','2016-02-14 17:53:53',56,56),(20,'ABC000019','2016-02-14 17:55:27',65,65),(21,'ABC000010','2016-02-14 17:57:01',75,75),(22,'ABC000029','2016-02-14 17:58:45',95,95),(23,'ABC000024','2016-02-14 18:00:33',100,100),(24,'ABC000027','2016-02-14 18:02:14',100,100),(25,'ABC000016','2016-02-14 18:03:34',100,100),(26,'ABC000011','2016-02-14 18:05:13',100,100),(27,'A000001','2016-02-21 13:49:38',40,40),(28,'A000001','2016-02-21 13:50:51',10,10);
/*!40000 ALTER TABLE `inventory_tbl` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary table structure for view `inventory_view`
--

DROP TABLE IF EXISTS `inventory_view`;
/*!50001 DROP VIEW IF EXISTS `inventory_view`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `inventory_view` (
  `Name` tinyint NOT NULL,
  `Description` tinyint NOT NULL,
  `Barcode` tinyint NOT NULL,
  `UnitCost` tinyint NOT NULL,
  `Unit_price` tinyint NOT NULL,
  `Category` tinyint NOT NULL,
  `Stock_since` tinyint NOT NULL,
  `Supplier` tinyint NOT NULL,
  `Qty_Received` tinyint NOT NULL,
  `Qty_On_Hand` tinyint NOT NULL,
  `Warranty` tinyint NOT NULL,
  `Replacement` tinyint NOT NULL,
  `SerialCode` tinyint NOT NULL,
  `Unit` tinyint NOT NULL,
  `MaintainingStocks` tinyint NOT NULL,
  `Archive` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `invoice_tbl`
--

DROP TABLE IF EXISTS `invoice_tbl`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `invoice_tbl` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `date` date DEFAULT NULL,
  `time` time DEFAULT NULL,
  `employee_id` varchar(45) DEFAULT NULL,
  `customer_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `invoice_employee_fk_idx` (`employee_id`),
  KEY `invoice_customer_fk_idx` (`customer_id`),
  CONSTRAINT `invoice_customer_fk` FOREIGN KEY (`customer_id`) REFERENCES `customer_tbl` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `invoice_tbl`
--

LOCK TABLES `invoice_tbl` WRITE;
/*!40000 ALTER TABLE `invoice_tbl` DISABLE KEYS */;
/*!40000 ALTER TABLE `invoice_tbl` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `login_trail_tbl`
--

DROP TABLE IF EXISTS `login_trail_tbl`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `login_trail_tbl` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `user_id` varchar(45) NOT NULL,
  `datetime_in` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `datetime_out` datetime DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`),
  KEY `login_employee_fk_idx` (`user_id`)
) ENGINE=InnoDB AUTO_INCREMENT=1059 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `login_trail_tbl`
--

LOCK TABLES `login_trail_tbl` WRITE;
/*!40000 ALTER TABLE `login_trail_tbl` DISABLE KEYS */;
INSERT INTO `login_trail_tbl` VALUES (1,'Jerwin','2015-10-09 01:34:54','2015-10-09 01:35:11'),(2,'Randy','2015-10-09 01:35:42','2015-10-09 01:35:42'),(3,'Randy','2015-10-09 01:36:53','2015-10-09 01:36:53'),(4,'Jerwin','2015-10-09 01:37:45','2015-10-09 01:37:49'),(5,'','2015-10-09 01:37:55','2015-10-09 01:40:37'),(6,'Randy','2015-10-09 01:42:51','2015-10-09 01:42:51'),(7,'','2015-10-09 01:43:24','2015-10-09 01:43:24'),(8,'Randy','2015-10-09 01:45:09','2015-10-09 01:45:09'),(9,'Randy','2015-10-09 01:46:23','2015-10-09 01:46:23'),(10,'Randy','2015-10-09 01:50:08','2015-10-09 01:50:08'),(11,'Randy','2015-10-09 01:52:10','2015-10-09 01:52:10'),(12,'Jerwin','2015-10-09 01:58:36','2015-10-09 01:58:39'),(13,'','2015-10-09 01:58:42','2015-10-09 01:58:42'),(14,'Randy','2015-10-09 01:58:43','2015-10-09 01:58:43'),(15,'','2015-10-09 01:59:38','2015-10-09 01:59:38'),(16,'','2015-10-09 02:02:09','2015-10-09 02:02:09'),(17,'Randy','2015-10-09 02:04:43','2015-10-09 02:04:43'),(18,'','2015-10-09 02:04:49','2015-10-09 02:04:50'),(19,'Jerwin','2015-10-09 02:04:57','2015-10-09 02:05:00'),(20,'','2015-10-09 02:05:08','2015-10-09 02:06:37'),(21,'Jerwin','2015-10-09 02:07:31','2015-10-09 02:07:39'),(22,'','2015-10-09 02:07:47','2015-10-09 02:08:09'),(23,'Karen','2015-10-09 02:08:57','2015-10-09 02:09:39'),(24,'Jerwin','2015-10-09 02:09:45','2015-10-09 02:09:45'),(25,'Randy','2015-10-09 02:11:30','2015-10-09 02:11:30'),(26,'Randy','2015-10-09 02:12:03','2015-10-09 02:12:03'),(27,'Randy','2015-10-09 02:12:33','2015-10-09 02:12:33'),(28,'Randy','2015-10-09 02:14:33','2015-10-09 02:14:33'),(29,'Randy','2015-10-09 02:15:01','2015-10-09 02:15:01'),(30,'Jerwin','2015-10-09 02:15:46','2015-10-09 02:15:46'),(31,'Randy','2015-10-09 02:17:28','2015-10-09 02:17:28'),(32,'Jerwin','2015-10-09 02:19:27','2015-10-09 02:19:27'),(33,'Jerwin','2015-10-09 02:27:35','2015-10-09 02:27:35'),(34,'Jerwin','2015-10-09 02:28:50','2015-10-09 02:28:50'),(35,'Jerwin','2015-10-09 02:34:06','2015-10-09 02:34:06'),(36,'Jerwin','2015-10-09 02:36:25','2015-10-09 02:36:25'),(37,'Jerwin','2015-10-09 02:40:31','2015-10-09 02:41:19'),(38,'Jerwin','2015-10-09 02:41:45','2015-10-09 02:42:41'),(39,'Jerwin','2015-10-09 02:44:28','2015-10-09 02:44:28'),(40,'Jerwin','2015-10-09 02:45:12','2015-10-09 02:45:52'),(41,'Jerwin','2015-10-09 02:46:58','2015-10-09 02:50:44'),(42,'Randy','2015-10-09 08:48:15','2015-10-09 08:48:16'),(43,'Randy','2015-10-09 19:04:02','2015-10-09 19:05:28'),(44,'Randy','2015-10-09 19:19:55','2015-10-09 19:20:06'),(45,'Randy','2015-10-09 19:20:41','2015-10-09 19:21:49'),(46,'Randy','2015-10-09 19:44:21','2015-10-09 19:45:31'),(47,'Randy','2015-10-09 19:53:16','2015-10-09 19:53:29'),(48,'Randy','2015-10-10 20:43:34','2015-10-10 20:47:12'),(49,'Randy','2015-10-10 20:48:27','2015-10-10 20:48:40'),(50,'Randy','2015-10-10 20:49:51','2015-10-10 20:50:54'),(51,'Randy','2015-10-10 20:51:40','2015-10-10 20:51:40'),(52,'Randy','2015-10-10 20:55:58','2015-10-10 20:55:58'),(53,'Karen','2015-10-10 21:01:24','2015-10-10 21:02:39'),(54,'Karen','2015-10-10 21:03:03','2015-10-10 21:03:56'),(55,'Randy','2015-10-10 21:16:29','2015-10-10 21:16:35'),(56,'Karen','2015-10-10 21:16:41','2015-10-10 21:17:14'),(57,'Randy','2015-10-10 21:17:26','2015-10-10 21:17:52'),(58,'Randy','2015-10-10 21:18:27','2015-10-10 21:19:44'),(59,'Randy','2015-10-10 21:24:20','2015-10-10 21:25:12'),(60,'Randy','2015-10-10 21:32:36','2015-10-10 21:33:12'),(61,'Randy','2015-10-10 21:34:40','2015-10-10 21:35:03'),(62,'Randy','2015-10-10 21:36:12','2015-10-10 21:37:23'),(63,'Randy','2015-10-10 21:43:16','2015-10-10 21:44:11'),(64,'Randy','2015-10-10 21:44:38','2015-10-10 21:44:49'),(65,'Randy','2015-10-11 09:46:30','2015-10-11 09:46:33'),(66,'Randy','2015-10-11 09:55:17','2015-10-11 09:56:22'),(67,'Randy','2015-10-11 10:01:02','2015-10-11 10:03:42'),(68,'Randy','2015-10-11 10:04:41','2015-10-11 10:06:11'),(69,'Randy','2015-10-11 10:09:57','2015-10-11 10:10:12'),(70,'Randy','2015-10-13 22:12:27','2015-10-13 22:12:37'),(71,'Randy','2015-10-13 22:16:15','2015-10-13 22:16:23'),(72,'Randy','2015-10-13 22:20:45','2015-10-13 22:20:52'),(73,'Randy','2015-10-13 22:22:38','2015-10-13 22:22:44'),(74,'Randy','2015-10-13 22:24:02','2015-10-13 22:24:02'),(75,'Randy','2015-10-13 22:24:45','2015-10-13 22:25:09'),(76,'Randy','2015-10-13 22:26:05','2015-10-13 22:26:10'),(77,'Randy','2015-10-13 22:27:15','2015-10-13 22:27:32'),(78,'Randy','2015-10-13 22:28:02','2015-10-13 22:28:07'),(79,'','2015-10-13 22:32:41','2015-10-13 22:32:48'),(80,'Randy','2015-10-13 22:42:05','2015-10-13 22:42:12'),(81,'Randy','2015-10-13 22:49:03','2015-10-13 22:50:53'),(82,'Randy','2015-10-13 22:56:24','2015-10-13 22:57:47'),(83,'Randy','2015-10-13 23:04:45','2015-10-13 23:05:04'),(84,'Randy','2015-10-13 23:06:25','2015-10-13 23:06:34'),(85,'Randy','2015-10-13 23:08:09','2015-10-13 23:08:16'),(86,'Randy','2015-10-13 23:09:05','2015-10-13 23:09:19'),(87,'Randy','2015-10-13 23:13:03','2015-10-13 23:13:22'),(88,'Randy','2015-10-13 23:13:59','2015-10-13 23:15:18'),(89,'Randy','2015-10-13 23:59:45','2015-10-13 23:59:55'),(90,'Randy','2015-10-14 00:00:09','2015-10-14 00:00:22'),(91,'Randy','2015-10-14 00:18:58','2015-10-14 00:19:25'),(92,'Randy','2015-10-14 00:36:37','2015-10-14 00:36:37'),(93,'Randy','2015-10-14 00:49:12','2015-10-14 00:49:12'),(94,'Randy','2015-10-14 00:51:12','2015-10-14 00:51:12'),(95,'Randy','2015-10-14 00:56:55','2015-10-14 00:56:55'),(96,'Randy','2015-10-14 01:01:35','2015-10-14 01:01:54'),(97,'Randy','2015-10-14 01:11:40','2015-10-14 01:11:51'),(98,'Jerwin','2015-10-14 01:12:01','2015-10-14 01:13:10'),(99,'Randy','2015-10-14 01:14:08','2015-10-14 01:15:10'),(100,'Randy','2015-10-14 01:16:27','2015-10-14 01:16:27'),(101,'Randy','2015-10-14 01:17:45','2015-10-14 01:17:45'),(102,'Randy','2015-10-14 01:30:07','2015-10-14 01:30:07'),(103,'Randy','2015-10-14 01:34:16','2015-10-14 01:35:44'),(104,'Jerwin','2015-10-14 01:37:19','2015-10-14 01:38:11'),(105,'Randy','2015-10-14 16:48:06','2015-10-14 16:48:45'),(106,'Randy','2015-10-14 17:06:25','2015-10-14 17:06:27'),(107,'Randy','2015-10-14 18:11:15','2015-10-14 18:11:27'),(108,'Randy','2015-10-15 07:49:14','2015-10-15 07:49:14'),(109,'Randy','2015-10-15 07:50:45','2015-10-15 07:51:15'),(110,'Karen','2015-10-15 08:05:14','2015-10-15 08:05:17'),(111,'Karen','2015-10-15 08:07:49','2015-10-15 08:07:53'),(112,'Jerwin','2015-10-15 08:08:30','2015-10-15 08:08:39'),(113,'Jerwin','2015-10-15 08:10:55','2015-10-15 08:10:59'),(114,'Randy','2015-10-15 08:11:45','2015-10-15 08:11:45'),(115,'Randy','2015-10-15 08:25:23','2015-10-15 08:25:28'),(116,'Randy','2015-10-15 08:27:21','2015-10-15 08:27:26'),(117,'Randy','2015-10-15 08:28:21','2015-10-15 08:28:24'),(118,'Randy','2015-10-15 08:46:16','2015-10-15 08:47:25'),(119,'Randy','2015-10-15 08:47:36','2015-10-15 08:47:44'),(120,'Karen','2015-10-15 08:47:49','2015-10-15 08:49:22'),(121,'Jerwin','2015-10-15 08:50:04','2015-10-15 08:50:29'),(122,'Jerwin','2015-10-15 09:01:47','2015-10-15 09:01:47'),(123,'Karen','2015-10-15 09:05:53','2015-10-15 09:05:58'),(124,'Jerwin','2015-10-15 09:06:38','2015-10-15 09:06:38'),(125,'Jerwin','2015-10-15 09:09:55','2015-10-15 09:09:55'),(126,'Jerwin','2015-10-15 09:13:02','2015-10-15 09:13:02'),(127,'Jerwin','2015-10-15 09:15:59','2015-10-15 09:15:59'),(128,'Jerwin','2015-10-15 09:17:16','2015-10-15 09:17:16'),(129,'Jerwin','2015-10-15 09:21:14','2015-10-15 09:21:38'),(130,'Jerwin','2015-10-15 09:22:26','2015-10-15 09:24:21'),(131,'Jerwin','2015-10-15 09:26:28','2015-10-15 09:26:28'),(132,'Jerwin','2015-10-15 09:28:22','2015-10-15 09:28:55'),(133,'Jerwin','2015-10-15 09:30:27','2015-10-15 09:31:35'),(134,'Jerwin','2015-10-15 09:32:15','2015-10-15 09:32:15'),(135,'Jerwin','2015-10-15 09:34:11','2015-10-15 09:34:37'),(136,'Jerwin','2015-10-15 09:35:46','2015-10-15 09:36:06'),(137,'Jerwin','2015-10-15 09:37:06','2015-10-15 09:37:28'),(138,'Jerwin','2015-10-15 09:41:42','2015-10-15 09:41:53'),(139,'Jerwin','2015-10-15 09:42:30','2015-10-15 09:43:54'),(140,'Jerwin','2015-10-15 09:45:29','2015-10-15 09:45:50'),(141,'Jerwin','2015-10-15 09:46:24','2015-10-15 09:46:59'),(142,'Jerwin','2015-10-15 09:48:27','2015-10-15 09:48:27'),(143,'','2015-10-15 09:51:20','2015-10-15 09:51:21'),(144,'Jerwin','2015-10-15 09:51:45','2015-10-15 09:52:17'),(145,'Jerwin','2015-10-15 09:53:00','2015-10-15 09:53:27'),(146,'Jerwin','2015-10-15 09:54:49','2015-10-15 09:56:15'),(147,'Karen','2015-10-15 09:56:19','2015-10-15 09:56:30'),(148,'Jerwin','2015-10-15 09:56:37','2015-10-15 09:56:47'),(149,'Jerwin','2015-10-15 09:58:24','2015-10-15 09:58:45'),(150,'Jerwin','2015-10-15 09:59:54','2015-10-15 10:00:11'),(151,'Karen','2015-10-15 10:46:56','2015-10-15 10:48:23'),(152,'Jerwin','2015-10-15 10:48:29','2015-10-15 10:48:35'),(153,'Jerwin','2015-10-15 10:49:47','2015-10-15 10:50:04'),(154,'Karen','2015-10-15 10:50:09','2015-10-15 10:51:20'),(155,'Jerwin','2015-10-15 10:52:19','2015-10-15 10:53:48'),(156,'Randy','2015-10-15 10:53:52','2015-10-15 10:55:11'),(157,'Karen','2015-10-15 10:55:18','2015-10-15 10:55:18'),(158,'Karen','2015-10-15 10:59:48','2015-10-15 10:59:48'),(159,'Karen','2015-10-15 11:00:57','2015-10-15 11:00:57'),(160,'Karen','2015-10-15 11:03:33','2015-10-15 11:03:33'),(161,'Karen','2015-10-15 11:05:37','2015-10-15 11:05:37'),(162,'Karen','2015-10-15 11:07:04','2015-10-15 11:07:04'),(163,'Karen','2015-10-15 11:09:31','2015-10-15 11:09:31'),(164,'Karen','2015-10-15 11:12:24','2015-10-15 11:12:24'),(165,'Karen','2015-10-15 11:14:58','2015-10-15 11:14:58'),(166,'Karen','2015-10-15 11:17:45','2015-10-15 11:18:34'),(167,'Karen','2015-10-15 11:18:53','2015-10-15 11:19:13'),(168,'Karen','2015-10-15 11:21:04','2015-10-15 11:21:19'),(169,'Randy','2015-10-15 11:21:44','2015-10-15 11:22:24'),(170,'Karen','2015-10-15 11:35:16','2015-10-15 11:35:21'),(171,'Jerwin','2015-10-15 11:35:24','2015-10-15 11:37:49'),(172,'Jerwin','2015-10-15 11:40:03','2015-10-15 11:40:26'),(173,'Jerwin','2015-10-15 11:41:27','2015-10-15 11:42:59'),(174,'Randy','2015-10-15 11:43:09','2015-10-15 11:43:44'),(175,'Karen','2015-10-15 11:43:54','2015-10-15 11:46:02'),(176,'Karen','2015-10-15 11:46:07','2015-10-15 11:46:19'),(177,'Randy','2015-10-15 11:46:26','2015-10-15 11:47:47'),(178,'Karen','2015-10-15 11:47:55','2015-10-15 11:49:05'),(179,'Jerwin','2015-10-15 11:49:16','2015-10-15 11:49:27'),(180,'Jerwin','2015-10-15 11:50:25','2015-10-15 11:50:32'),(181,'Jerwin','2015-10-15 12:00:05','2015-10-15 12:00:05'),(182,'','2015-10-15 12:00:21','2015-10-15 12:00:52'),(183,'Randy','2015-10-15 12:01:07','2015-10-15 12:01:07'),(184,'Jerwin','2015-10-15 12:06:35','2015-10-15 12:06:38'),(185,'Karen','2015-10-15 12:06:48','2015-10-15 12:06:49'),(186,'Francis','2015-10-15 12:07:07','2015-10-15 12:11:24'),(187,'Karen','2015-10-15 12:12:20','2015-10-15 12:12:21'),(188,'Francis','2015-10-15 12:12:26','2015-10-15 12:12:26'),(189,'','2015-10-15 12:17:39','2015-10-15 12:17:41'),(190,'Karen','2015-10-15 12:17:57','2015-10-15 12:17:57'),(191,'Jerwin','2015-10-15 12:22:51','2015-10-15 12:22:51'),(192,'Jerwin','2015-10-15 12:23:04','2015-10-15 12:23:05'),(193,'Randy','2015-10-15 12:23:16','2015-10-15 12:23:16'),(194,'Francis','2015-10-15 12:24:56','2015-10-15 12:25:27'),(195,'Randy','2015-10-15 12:30:26','2015-10-15 12:31:20'),(196,'Randy','2015-10-15 12:31:26','2015-10-15 12:31:59'),(197,'Randy','2015-10-15 12:33:44','2015-10-15 12:33:44'),(198,'Karen','2015-10-15 12:35:18','2015-10-15 12:35:18'),(199,'Randy','2015-10-15 12:35:48','2015-10-15 12:35:48'),(200,'Francis','2015-10-15 12:35:48','2015-10-15 12:35:48'),(201,'Jerwin','2015-10-15 12:36:17','2015-10-15 12:36:17'),(202,'','2015-10-15 12:37:53','2015-10-15 12:37:54'),(203,'Randy','2015-10-15 12:37:58','2015-10-15 12:37:58'),(204,'Randy','2015-10-15 12:47:41','2015-10-15 12:47:41'),(205,'Jerwin','2015-10-15 12:48:27','2015-10-15 12:48:27'),(206,'Karen','2015-10-15 12:49:28','2015-10-15 13:00:12'),(207,'Rabi','2015-10-15 13:00:32','2015-10-15 13:06:53'),(208,'','2015-10-15 13:10:43','2015-10-15 13:10:54'),(209,'Karen','2015-10-15 13:11:01','2015-10-15 13:11:01'),(210,'','2015-10-15 13:14:33','2015-10-15 13:22:46'),(211,'','2015-10-15 13:30:54','2015-10-15 13:30:54'),(212,'Karen','2015-10-15 13:34:53','2015-10-15 13:34:53'),(213,'','2015-10-15 13:35:18','2015-10-15 13:40:56'),(214,'Jerwin','2015-10-15 13:51:03','2015-10-15 13:51:03'),(215,'','2015-10-15 14:00:20','2015-10-15 14:00:22'),(216,'Karen','2015-10-15 14:01:32','2015-10-15 14:01:32'),(217,'Karen','2015-10-15 14:08:54','2015-10-15 14:11:31'),(218,'Karen','2015-10-15 14:12:08','2015-10-15 14:12:18'),(219,'Randy','2015-10-15 14:12:44','2015-10-15 14:14:39'),(220,'Jerwin','2015-10-15 14:14:43','2015-10-15 14:16:37'),(221,'Randy','2015-10-15 14:16:41','2015-10-15 14:22:53'),(222,'Randy','2015-10-15 14:29:12','2015-10-15 14:33:31'),(223,'Karen','2015-10-15 14:33:40','2015-10-15 14:34:15'),(224,'Randy','2015-10-15 14:34:22','2015-10-15 14:35:47'),(225,'Jerwin','2015-10-15 14:36:27','2015-10-15 14:36:27'),(226,'Randy','2015-10-15 14:44:33','2015-10-15 14:46:02'),(227,'Randy','2015-10-15 14:47:52','2015-10-15 14:48:26'),(228,'Randy','2015-10-15 14:52:35','2015-10-15 14:53:26'),(229,'Randy','2015-10-15 14:55:26','2015-10-15 14:55:26'),(230,'Karen','2015-10-15 15:00:02','2015-10-15 15:00:06'),(231,'Randy','2015-10-15 15:01:45','2015-10-15 15:03:06'),(232,'Randy','2015-10-15 15:04:59','2015-10-15 15:06:01'),(233,'Jerwin','2015-10-15 15:14:32','2015-10-15 15:16:06'),(234,'Randy','2015-10-15 15:16:09','2015-10-15 15:17:04'),(235,'Jerwin','2015-10-15 15:18:25','2015-10-15 15:18:52'),(236,'Jerwin','2015-10-15 15:18:57','2015-10-15 15:18:57'),(237,'Jerwin','2015-10-15 15:22:59','2015-10-15 15:24:07'),(238,'Rabi','2015-10-15 15:24:36','2015-10-15 15:25:06'),(239,'Jerwin','2015-10-15 15:25:47','2015-10-15 15:26:09'),(240,'Jerwin','2015-10-15 15:26:36','2015-10-15 15:26:46'),(241,'Randy','2015-10-15 15:26:53','2015-10-15 15:27:06'),(242,'Randy','2015-10-15 15:28:58','2015-10-15 15:29:15'),(243,'Jerwin','2015-10-15 15:29:35','2015-10-15 15:30:29'),(244,'Jerwin','2015-10-15 15:30:38','2015-10-15 15:31:58'),(245,'Randy','2015-10-15 15:32:02','2015-10-15 15:33:12'),(246,'Karen','2015-10-15 15:33:16','2015-10-15 15:33:38'),(247,'Jerwin','2015-10-15 15:33:47','2015-10-15 15:34:05'),(248,'Jerwin','2015-10-15 15:40:25','2015-10-15 15:40:25'),(249,'Jerwin','2015-10-15 15:42:52','2015-10-15 15:43:20'),(250,'Karen','2015-10-15 15:44:39','2015-10-15 15:44:42'),(251,'Jerwin','2015-10-15 15:44:52','2015-10-15 15:45:20'),(252,'Jerwin','2015-10-15 15:45:23','2015-10-15 15:45:47'),(253,'Jerwin','2015-10-15 15:47:54','2015-10-15 15:48:49'),(254,'Karen','2015-10-15 15:48:54','2015-10-15 15:48:59'),(255,'Randy','2015-10-15 15:53:51','2015-10-15 15:53:51'),(256,'Randy','2015-10-15 16:00:07','2015-10-15 16:00:37'),(257,'Karen','2015-10-15 16:01:05','2015-10-15 16:01:36'),(258,'Randy','2015-10-15 16:10:41','2015-10-15 16:10:44'),(259,'Karen','2015-10-15 16:10:49','2015-10-15 16:10:57'),(260,'Karen','2015-10-15 16:11:23','2015-10-15 16:11:23'),(261,'Randy','2015-10-15 16:12:05','2015-10-15 16:12:15'),(262,'Randy','2015-10-15 16:12:51','2015-10-15 16:13:04'),(263,'Karen','2015-10-15 16:13:42','2015-10-15 16:13:42'),(264,'Randy','2015-10-15 16:14:16','2015-10-15 16:14:20'),(265,'Karen','2015-10-15 16:16:23','2015-10-15 16:17:34'),(266,'Jerwin','2015-10-15 16:18:22','2015-10-15 16:18:32'),(267,'Jerwin','2015-10-15 16:18:39','2015-10-15 16:18:44'),(268,'Randy','2015-10-15 16:18:39','2015-10-15 16:18:39'),(269,'Randy','2015-10-15 16:19:14','2015-10-15 16:19:34'),(270,'Randy','2015-10-15 16:19:40','2015-10-15 16:19:43'),(271,'Karen','2015-10-15 16:19:46','2015-10-15 16:20:07'),(272,'Randy','2015-10-15 16:21:17','2015-10-15 16:21:58'),(273,'Randy','2015-10-15 16:22:20','2015-10-15 16:22:57'),(274,'Randy','2015-10-15 16:23:01','2015-10-15 16:24:28'),(275,'Jerwin','2015-10-15 16:25:39','2015-10-15 16:25:49'),(276,'Karen','2015-10-15 16:25:53','2015-10-15 16:25:58'),(277,'Randy','2015-10-15 16:26:01','2015-10-15 16:26:10'),(278,'Jerwin','2015-10-15 16:27:18','2015-10-15 16:27:25'),(279,'Randy','2015-10-15 16:27:35','2015-10-15 16:27:35'),(280,'','2015-10-15 16:32:28','2015-10-15 16:32:28'),(281,'Randy','2015-10-15 16:32:46','2015-10-15 16:34:35'),(282,'Jerwin','2015-10-15 16:35:00','2015-10-15 16:35:02'),(283,'Karen','2015-10-15 16:35:05','2015-10-15 16:35:08'),(284,'Randy','2015-10-15 16:35:11','2015-10-15 16:35:29'),(285,'Randy','2015-10-15 16:36:19','2015-10-15 16:37:21'),(286,'','2015-10-15 16:37:24','2015-10-15 16:38:22'),(287,'Jerwin','2015-10-15 16:38:30','2015-10-15 16:38:34'),(288,'Randy','2015-10-15 16:43:04','2015-10-15 16:43:16'),(289,'Jerwin','2015-10-15 16:44:53','2015-10-15 16:45:01'),(290,'Randy','2015-10-15 16:45:15','2015-10-15 16:45:31'),(291,'Jerwin','2015-10-15 17:57:12','2015-10-15 17:57:12'),(292,'Rabi','2015-10-15 17:57:32','2015-10-15 17:57:32'),(293,'Randy','2015-10-15 17:57:48','2015-10-15 17:57:48'),(294,'Karen','2015-10-15 17:57:53','2015-10-15 17:58:13'),(295,'Rabi','2015-10-15 18:05:42','2015-10-15 18:06:01'),(296,'Rabi','2015-10-15 18:26:18','2015-10-15 18:37:31'),(297,'Rabi','2015-10-15 18:37:37','2015-10-15 18:37:37'),(298,'Jerwin','2015-10-15 18:40:53','2015-10-15 18:41:34'),(299,'','2015-10-15 18:42:55','2015-10-15 18:42:59'),(300,'Jerwin','2015-10-15 18:43:04','2015-10-15 18:51:51'),(301,'Jerwin','2015-10-15 18:51:57','2015-10-15 18:52:57'),(302,'Randy','2015-10-15 18:53:15','2015-10-15 18:53:15'),(303,'Karen','2015-10-15 19:16:40','2015-10-15 19:16:40'),(304,'Jerwin','2015-10-15 19:21:13','2015-10-15 19:25:57'),(305,'Rabi','2015-10-15 19:26:21','2015-10-15 19:26:21'),(306,'Jerwin','2015-10-15 19:31:32','2015-10-15 19:31:33'),(307,'','2015-10-15 19:31:51','2015-10-15 19:32:36'),(308,'','2015-10-29 09:45:25','2015-10-29 09:48:23'),(309,'Francis','2015-10-29 09:48:40','2015-10-29 09:49:00'),(310,'Jerwin','2015-10-29 09:49:04','2015-10-29 09:50:25'),(311,'Francis','2015-10-29 09:50:30','2015-10-29 09:51:28'),(312,'','2015-10-29 09:53:02','2015-10-29 09:53:03'),(313,'Karen','2015-10-29 09:53:07','2015-10-29 09:55:35'),(314,'Jerwin','2015-10-29 09:55:43','2015-10-29 09:55:54'),(315,'Rabi','2016-01-12 12:50:12','2016-01-12 12:50:12'),(316,'Rabi','2016-01-12 12:50:53','2016-01-12 12:52:15'),(317,'Jerwin','2016-01-12 12:57:24','2016-01-12 12:58:26'),(318,'Jerwin','2016-01-12 13:07:49','2016-01-12 13:07:57'),(319,'Jerwin','2016-01-12 13:15:39','2016-01-12 13:15:44'),(320,'Jerwin','2016-01-12 13:16:10','2016-01-12 13:16:19'),(321,'Jerwin','2016-01-12 13:25:08','2016-01-12 13:25:21'),(322,'Jerwin','2016-01-12 13:29:33','2016-01-12 13:30:19'),(323,'Jerwin','2016-01-12 13:31:58','2016-01-12 13:33:19'),(324,'Jerwin','2016-01-12 13:33:23','2016-01-12 13:33:57'),(325,'Jerwin','2016-01-12 13:36:02','2016-01-12 13:36:41'),(326,'Jerwin','2016-01-12 13:38:01','2016-01-12 13:38:18'),(327,'Jerwin','2016-01-12 13:45:06','2016-01-12 13:45:08'),(328,'Jerwin','2016-01-12 13:46:55','2016-01-12 13:47:07'),(329,'Jerwin','2016-01-12 13:47:20','2016-01-12 13:47:25'),(330,'Jerwin','2016-01-12 13:48:18','2016-01-12 13:48:28'),(331,'Jerwin','2016-01-12 13:49:59','2016-01-12 13:51:58'),(332,'Jerwin','2016-01-12 13:52:22','2016-01-12 13:53:54'),(333,'Jerwin','2016-01-12 13:56:13','2016-01-12 13:56:47'),(334,'Jerwin','2016-01-12 13:57:17','2016-01-12 13:58:44'),(335,'Jerwin','2016-01-12 13:58:51','2016-01-12 13:59:33'),(336,'Jerwin','2016-01-12 13:59:51','2016-01-12 13:59:55'),(337,'Jerwin','2016-01-12 13:59:59','2016-01-12 14:00:04'),(338,'Jerwin','2016-01-12 14:00:16','2016-01-12 14:00:29'),(339,'Jerwin','2016-01-12 14:01:49','2016-01-12 14:01:52'),(340,'Jerwin','2016-01-12 14:02:24','2016-01-12 14:02:29'),(341,'Jerwin','2016-01-12 14:04:09','2016-01-12 14:04:12'),(342,'Jerwin','2016-01-12 14:06:31','2016-01-12 14:06:31'),(343,'Jerwin','2016-01-12 14:12:12','2016-01-12 14:12:19'),(344,'Jerwin','2016-01-12 14:12:46','2016-01-12 14:12:50'),(345,'Jerwin','2016-01-12 14:13:40','2016-01-12 14:13:40'),(346,'Jerwin','2016-01-12 14:16:50','2016-01-12 14:16:50'),(347,'Jerwin','2016-01-12 14:18:22','2016-01-12 14:18:22'),(348,'Jerwin','2016-01-12 14:19:15','2016-01-12 14:19:18'),(349,'Jerwin','2016-01-12 14:19:54','2016-01-12 14:20:47'),(350,'Jerwin','2016-01-12 14:22:34','2016-01-12 14:22:46'),(351,'Jerwin','2016-01-12 14:24:13','2016-01-12 14:26:47'),(352,'Jerwin','2016-01-12 14:33:18','2016-01-12 14:35:15'),(353,'Jerwin','2016-01-12 14:35:22','2016-01-12 14:35:30'),(354,'Jerwin','2016-01-12 14:37:49','2016-01-12 14:38:06'),(355,'Jerwin','2016-01-12 14:38:27','2016-01-12 14:38:30'),(356,'Jerwin','2016-01-12 14:38:54','2016-01-12 14:39:24'),(357,'Jerwin','2016-01-12 14:40:20','2016-01-12 14:41:01'),(358,'Jerwin','2016-01-12 14:41:23','2016-01-12 14:41:43'),(359,'Jerwin','2016-01-12 14:42:12','2016-01-12 14:42:29'),(360,'Jerwin','2016-01-12 14:51:48','2016-01-12 14:51:55'),(361,'Jerwin','2016-01-12 14:52:15','2016-01-12 14:52:23'),(362,'Jerwin','2016-01-12 14:53:33','2016-01-12 14:54:07'),(363,'Jerwin','2016-01-12 14:58:45','2016-01-12 14:59:17'),(364,'Jerwin','2016-01-12 15:00:06','2016-01-12 15:00:54'),(365,'Jerwin','2016-01-12 15:02:19','2016-01-12 15:03:47'),(366,'Jerwin','2016-01-12 15:04:01','2016-01-12 15:06:34'),(367,'Jerwin','2016-01-12 15:06:53','2016-01-12 15:07:15'),(368,'Jerwin','2016-01-12 15:07:56','2016-01-12 15:07:59'),(369,'Jerwin','2016-01-12 15:08:53','2016-01-12 15:09:26'),(370,'Jerwin','2016-01-12 15:10:12','2016-01-12 15:12:01'),(371,'Jerwin','2016-01-12 15:23:17','2016-01-12 15:23:34'),(372,'Jerwin','2016-01-12 15:24:51','2016-01-12 15:25:07'),(373,'Jerwin','2016-01-12 15:25:25','2016-01-12 15:25:25'),(374,'Jerwin','2016-01-12 15:26:15','2016-01-12 15:26:15'),(375,'Jerwin','2016-01-12 15:28:13','2016-01-12 15:28:13'),(376,'Jerwin','2016-01-12 15:29:24','2016-01-12 15:30:31'),(377,'Jerwin','2016-01-12 15:31:40','2016-01-12 15:32:13'),(378,'Jerwin','2016-01-12 15:33:13','2016-01-12 15:34:05'),(379,'Jerwin','2016-01-12 15:34:27','2016-01-12 15:34:33'),(380,'Jerwin','2016-01-12 15:35:03','2016-01-12 15:35:33'),(381,'Jerwin','2016-01-12 15:39:30','2016-01-12 15:41:41'),(382,'Jerwin','2016-01-12 15:43:13','2016-01-12 15:44:47'),(383,'Jerwin','2016-01-12 15:45:00','2016-01-12 15:45:17'),(384,'Jerwin','2016-01-12 15:46:01','2016-01-12 15:46:17'),(385,'Jerwin','2016-01-12 15:46:35','2016-01-12 15:47:13'),(386,'Jerwin','2016-01-12 15:47:25','2016-01-12 15:48:13'),(387,'Jerwin','2016-01-12 15:48:18','2016-01-12 15:49:05'),(388,'Jerwin','2016-01-12 15:49:23','2016-01-12 15:49:55'),(389,'Jerwin','2016-01-12 15:50:11','2016-01-12 15:52:28'),(390,'Jerwin','2016-01-12 16:01:39','2016-01-12 16:02:29'),(391,'Jerwin','2016-01-12 16:03:59','2016-01-12 16:05:21'),(392,'Jerwin','2016-01-12 16:14:27','2016-01-12 16:15:13'),(393,'Jerwin','2016-01-12 16:15:53','2016-01-12 16:16:24'),(394,'Jerwin','2016-01-12 16:17:50','2016-01-12 16:17:57'),(395,'Jerwin','2016-01-12 16:19:20','2016-01-12 16:26:02'),(396,'Jerwin','2016-01-12 16:27:27','2016-01-12 16:27:52'),(397,'Jerwin','2016-01-12 16:28:50','2016-01-12 16:28:57'),(398,'Jerwin','2016-01-12 16:29:27','2016-01-12 16:29:32'),(399,'Jerwin','2016-01-12 16:30:27','2016-01-12 16:30:35'),(400,'Jerwin','2016-01-12 16:32:11','2016-01-12 16:32:15'),(401,'Jerwin','2016-01-12 16:35:57','2016-01-12 16:36:10'),(402,'Jerwin','2016-01-12 16:36:14','2016-01-12 16:39:12'),(403,'Jerwin','2016-01-12 16:39:24','2016-01-12 16:39:33'),(404,'Jerwin','2016-01-12 16:40:13','2016-01-12 16:40:37'),(405,'Jerwin','2016-01-12 16:41:26','2016-01-12 16:41:31'),(406,'Jerwin','2016-01-12 16:44:00','2016-01-12 16:44:03'),(407,'Jerwin','2016-01-12 16:45:01','2016-01-12 16:45:07'),(408,'Jerwin','2016-01-12 16:45:24','2016-01-12 16:45:29'),(409,'Jerwin','2016-01-12 16:45:51','2016-01-12 16:45:52'),(410,'Jerwin','2016-01-12 16:46:20','2016-01-12 16:46:22'),(411,'Jerwin','2016-01-12 16:46:42','2016-01-12 16:46:47'),(412,'Jerwin','2016-01-12 16:47:44','2016-01-12 16:47:49'),(413,'Jerwin','2016-01-12 16:48:15','2016-01-12 16:48:20'),(414,'Jerwin','2016-01-12 16:48:42','2016-01-12 16:48:55'),(415,'Jerwin','2016-01-12 16:50:19','2016-01-12 16:50:21'),(416,'Jerwin','2016-01-12 16:50:44','2016-01-12 16:50:49'),(417,'Jerwin','2016-01-12 16:51:09','2016-01-12 16:51:13'),(418,'Jerwin','2016-01-12 16:51:31','2016-01-12 16:51:37'),(419,'Jerwin','2016-01-12 16:52:02','2016-01-12 16:52:05'),(420,'Jerwin','2016-01-12 16:52:38','2016-01-12 16:52:43'),(421,'Jerwin','2016-01-12 16:53:45','2016-01-12 16:53:50'),(422,'Jerwin','2016-01-12 16:54:16','2016-01-12 16:54:23'),(423,'Jerwin','2016-01-12 16:55:03','2016-01-12 16:55:12'),(424,'Jerwin','2016-01-12 16:55:44','2016-01-12 16:55:48'),(425,'Jerwin','2016-01-12 16:56:17','2016-01-12 16:56:22'),(426,'Jerwin','2016-01-12 16:56:54','2016-01-12 16:56:57'),(427,'Jerwin','2016-01-12 16:57:19','2016-01-12 16:57:24'),(428,'Jerwin','2016-01-12 16:59:52','2016-01-12 17:00:02'),(429,'Jerwin','2016-01-12 17:01:00','2016-01-12 17:01:09'),(430,'Jerwin','2016-01-12 17:02:16','2016-01-12 17:02:21'),(431,'Jerwin','2016-01-12 17:02:42','2016-01-12 17:02:52'),(432,'Jerwin','2016-01-12 17:03:55','2016-01-12 17:04:06'),(433,'Jerwin','2016-01-12 17:11:15','2016-01-12 17:11:19'),(434,'Jerwin','2016-01-12 17:11:55','2016-01-12 17:12:00'),(435,'Jerwin','2016-01-12 17:13:47','2016-01-12 17:13:54'),(436,'Jerwin','2016-01-12 17:14:10','2016-01-12 17:14:12'),(437,'Jerwin','2016-01-12 17:15:39','2016-01-12 17:15:43'),(438,'Jerwin','2016-01-12 17:16:26','2016-01-12 17:16:30'),(439,'Jerwin','2016-01-12 17:16:56','2016-01-12 17:17:00'),(440,'Jerwin','2016-01-12 17:17:17','2016-01-12 17:17:38'),(441,'Jerwin','2016-01-12 17:17:43','2016-01-12 17:17:45'),(442,'Rabi','2016-01-12 17:17:54','2016-01-12 17:18:13'),(443,'Jerwin','2016-01-12 17:18:36','2016-01-12 17:21:05'),(444,'Jerwin','2016-01-12 17:21:36','2016-01-12 17:21:53'),(445,'Jerwin','2016-01-12 17:22:04','2016-01-12 17:22:11'),(446,'Jerwin','2016-01-12 17:23:29','2016-01-12 17:23:39'),(447,'Jerwin','2016-01-12 17:24:34','2016-01-12 17:24:42'),(448,'Jerwin','2016-01-12 17:28:26','2016-01-12 17:28:32'),(449,'Jerwin','2016-01-12 17:29:08','2016-01-12 17:29:25'),(450,'Jerwin','2016-01-12 17:30:11','2016-01-12 17:30:30'),(451,'Jerwin','2016-01-12 17:31:03','2016-01-12 17:31:12'),(452,'Jerwin','2016-01-12 17:32:47','2016-01-12 17:32:49'),(453,'Jerwin','2016-01-12 17:34:04','2016-01-12 17:34:06'),(454,'Jerwin','2016-01-12 17:39:19','2016-01-12 17:39:24'),(455,'Jerwin','2016-01-12 17:41:49','2016-01-12 17:41:51'),(456,'Jerwin','2016-01-12 17:56:06','2016-01-12 17:56:09'),(457,'Jerwin','2016-01-12 17:57:02','2016-01-12 17:57:04'),(458,'Jerwin','2016-01-12 17:58:14','2016-01-12 17:58:29'),(459,'Jerwin','2016-01-12 18:05:22','2016-01-12 18:05:54'),(460,'Jerwin','2016-01-12 18:07:52','2016-01-12 18:07:56'),(461,'Jerwin','2016-01-12 18:08:16','2016-01-12 18:08:20'),(462,'Jerwin','2016-01-12 18:10:01','2016-01-12 18:10:12'),(463,'Jerwin','2016-01-12 18:20:28','2016-01-12 18:20:49'),(464,'Jerwin','2016-01-12 18:21:15','2016-01-12 18:21:15'),(465,'Jerwin','2016-01-12 18:24:41','2016-01-12 18:24:44'),(466,'Jerwin','2016-01-12 18:25:01','2016-01-12 18:25:15'),(467,'Jerwin','2016-01-13 09:08:59','2016-01-13 09:10:14'),(468,'Jerwin','2016-01-13 09:10:20','2016-01-13 09:10:25'),(469,'Jerwin','2016-01-13 09:10:39','2016-01-13 09:11:53'),(470,'Jerwin','2016-01-13 09:18:19','2016-01-13 09:19:34'),(471,'Jerwin','2016-01-13 09:19:55','2016-01-13 09:19:55'),(472,'Jerwin','2016-01-13 09:25:48','2016-01-13 09:25:48'),(473,'Jerwin','2016-01-13 09:30:15','2016-01-13 09:30:15'),(474,'Jerwin','2016-01-13 09:36:14','2016-01-13 09:39:13'),(475,'Jerwin','2016-01-13 09:46:20','2016-01-13 09:46:27'),(476,'Jerwin','2016-01-13 09:47:56','2016-01-13 09:48:03'),(477,'Jerwin','2016-01-13 09:49:38','2016-01-13 09:50:06'),(478,'Jerwin','2016-01-13 10:33:48','2016-01-13 10:34:07'),(479,'Jerwin','2016-01-13 12:13:56','2016-01-13 12:13:56'),(480,'Jerwin','2016-01-13 12:15:57','2016-01-13 12:15:57'),(481,'Jerwin','2016-01-13 12:17:27','2016-01-13 12:17:27'),(482,'Jerwin','2016-01-13 12:20:31','2016-01-13 12:20:31'),(483,'Jerwin','2016-01-13 12:32:43','2016-01-13 12:32:43'),(484,'Jerwin','2016-01-13 12:34:24','2016-01-13 12:34:24'),(485,'Jerwin','2016-01-13 12:37:54','2016-01-13 12:37:54'),(486,'Jerwin','2016-01-13 12:41:11','2016-01-13 12:41:11'),(487,'Jerwin','2016-01-13 12:42:35','2016-01-13 12:42:35'),(488,'Jerwin','2016-01-13 12:47:40','2016-01-13 12:47:40'),(489,'Jerwin','2016-01-13 12:48:15','2016-01-13 12:48:15'),(490,'Jerwin','2016-01-13 12:49:40','2016-01-13 12:49:40'),(491,'Jerwin','2016-01-13 12:53:24','2016-01-13 12:53:31'),(492,'Jerwin','2016-01-13 12:59:30','2016-01-13 12:59:30'),(493,'Jerwin','2016-01-13 13:00:48','2016-01-13 13:00:48'),(494,'Jerwin','2016-01-13 13:05:24','2016-01-13 13:05:33'),(495,'Jerwin','2016-01-13 13:05:43','2016-01-13 13:05:43'),(496,'Jerwin','2016-01-13 13:14:04','2016-01-13 13:14:16'),(497,'Jerwin','2016-01-13 13:15:18','2016-01-13 13:15:18'),(498,'Jerwin','2016-01-13 13:16:08','2016-01-13 13:16:17'),(499,'Jerwin','2016-01-13 13:18:51','2016-01-13 13:19:56'),(500,'Jerwin','2016-01-13 13:20:14','2016-01-13 13:22:11'),(501,'Jerwin','2016-01-13 13:22:52','2016-01-13 13:22:52'),(502,'Jerwin','2016-01-13 13:24:41','2016-01-13 13:25:24'),(503,'Jerwin','2016-01-13 13:29:00','2016-01-13 13:29:28'),(504,'Jerwin','2016-01-13 13:38:44','2016-01-13 13:38:44'),(505,'Jerwin','2016-01-13 13:41:51','2016-01-13 13:42:56'),(506,'Jerwin','2016-01-13 13:43:11','2016-01-13 13:44:19'),(507,'Jerwin','2016-01-13 13:45:32','2016-01-13 13:45:32'),(508,'Jerwin','2016-01-13 13:49:15','2016-01-13 13:49:15'),(509,'Jerwin','2016-01-13 13:51:26','2016-01-13 13:51:26'),(510,'Jerwin','2016-01-13 13:53:30','2016-01-13 13:53:30'),(511,'Jerwin','2016-01-13 14:02:38','2016-01-13 14:05:29'),(512,'Jerwin','2016-01-13 14:09:14','2016-01-13 14:09:14'),(513,'Jerwin','2016-01-13 14:10:18','2016-01-13 14:10:52'),(514,'Jerwin','2016-01-13 14:11:03','2016-01-13 14:11:29'),(515,'Jerwin','2016-01-13 14:14:12','2016-01-13 14:14:57'),(516,'Jerwin','2016-01-13 14:15:10','2016-01-13 14:15:38'),(517,'Jerwin','2016-01-13 14:17:00','2016-01-13 14:17:26'),(518,'Jerwin','2016-01-13 14:22:06','2016-01-13 14:22:25'),(519,'Jerwin','2016-01-13 14:23:46','2016-01-13 14:23:47'),(520,'Rabi','2016-01-13 14:23:51','2016-01-13 14:23:54'),(521,'Jerwin','2016-01-13 14:31:30','2016-01-13 14:31:39'),(522,'Jerwin','2016-01-13 14:39:20','2016-01-13 14:39:27'),(523,'Jerwin','2016-01-13 14:43:37','2016-01-13 14:43:44'),(524,'Jerwin','2016-01-13 14:45:26','2016-01-13 14:45:34'),(525,'Jerwin','2016-01-13 14:46:47','2016-01-13 14:47:17'),(526,'Jerwin','2016-01-13 14:47:28','2016-01-13 14:48:12'),(527,'Jerwin','2016-01-13 14:48:23','2016-01-13 14:48:33'),(528,'Jerwin','2016-01-17 10:11:58','2016-01-17 10:12:49'),(529,'Rabi','2016-01-17 10:13:14','2016-01-17 10:15:35'),(530,'Rabi','2016-01-17 11:15:35','2016-01-17 11:15:46'),(531,'Karen','2016-01-17 11:16:13','2016-01-17 11:16:34'),(532,'Rabi','2016-01-17 11:55:35','2016-01-17 11:55:35'),(533,'Rabi','2016-01-17 13:13:45','2016-01-17 13:57:48'),(534,'Rabi','2016-01-17 15:45:35','2016-01-17 15:59:15'),(535,'Randy','2016-01-17 16:28:56','2016-01-17 16:35:56'),(536,'Karen','2016-01-17 16:36:00','2016-01-17 16:49:20'),(537,'Karen','2016-01-17 16:49:58','2016-01-17 16:50:39'),(538,'Randy','2016-01-17 17:05:49','2016-01-17 17:06:31'),(539,'Randy','2016-01-17 17:16:12','2016-01-17 17:16:20'),(540,'Rabi','2016-01-17 17:19:22','2016-01-17 17:19:32'),(541,'Rabi','2016-01-17 17:28:46','2016-01-17 17:29:37'),(542,'Rabi','2016-01-17 17:41:55','2016-01-17 17:43:19'),(543,'Rabi','2016-01-17 17:44:45','2016-01-17 17:44:44'),(544,'Karen','2016-01-17 17:52:01','2016-01-17 17:52:08'),(545,'Karen','2016-01-17 17:53:34','2016-01-17 17:53:45'),(546,'Karen','2016-01-17 17:55:38','2016-01-17 17:55:54'),(547,'Karen','2016-01-17 17:56:14','2016-01-17 17:56:41'),(548,'Randy','2016-01-17 18:06:24','2016-01-17 18:08:30'),(549,'Karen','2016-01-17 18:08:47','2016-01-17 18:13:41'),(550,'Randy','2016-01-17 18:15:23','2016-01-17 18:15:23'),(551,'Karen','2016-01-17 18:24:48','2016-01-17 18:24:51'),(552,'Rabi','2016-01-17 18:25:19','2016-01-17 18:25:21'),(553,'Rabi','2016-01-17 18:25:49','2016-01-17 18:25:52'),(554,'Rabi','2016-01-17 18:26:17','2016-01-17 18:27:36'),(555,'Rabi','2016-01-17 18:49:55','2016-01-17 18:49:58'),(556,'Rabi','2016-01-17 18:50:43','2016-01-17 18:51:17'),(557,'Rabi','2016-01-17 18:53:49','2016-01-17 18:53:56'),(558,'Rabi','2016-01-17 18:57:57','2016-01-17 18:58:12'),(559,'Rabi','2016-01-17 19:00:37','2016-01-17 19:01:02'),(560,'Rabi','2016-01-17 19:01:11','2016-01-17 19:01:21'),(561,'Rabi','2016-01-17 19:01:25','2016-01-17 19:01:49'),(562,'Rabi','2016-01-17 19:01:57','2016-01-17 19:05:04'),(563,'Randy','2016-01-17 19:51:32','2016-01-17 19:51:44'),(564,'Karen','2016-01-17 19:52:06','2016-01-17 19:52:13'),(565,'Rabi','2016-01-17 20:34:02','2016-01-17 20:35:11'),(566,'Jerwin','2016-01-18 13:56:18','2016-01-18 13:56:28'),(567,'Jerwin','2016-01-18 13:57:20','2016-01-18 13:57:20'),(568,'Jerwin','2016-01-18 14:01:10','2016-01-18 14:01:10'),(569,'Jerwin','2016-01-18 14:05:45','2016-01-18 14:06:14'),(570,'Rabi','2016-01-18 14:11:07','2016-01-18 14:11:10'),(571,'Jerwin','2016-01-18 14:11:15','2016-01-18 14:11:30'),(572,'Jerwin','2016-01-18 14:11:56','2016-01-18 14:13:27'),(573,'Jerwin','2016-01-18 14:16:14','2016-01-18 14:16:23'),(574,'Rabi','2016-01-18 14:16:45','2016-01-18 14:17:43'),(575,'Jerwin','2016-01-18 14:21:36','2016-01-18 14:22:23'),(576,'Rabi','2016-01-18 14:23:18','2016-01-18 14:28:44'),(577,'Jerwin','2016-01-18 14:33:01','2016-01-18 14:33:22'),(578,'Jerwin','2016-01-18 14:41:48','2016-01-18 14:42:38'),(579,'Jerwin','2016-01-18 14:45:08','2016-01-18 14:45:59'),(580,'Randy','2016-01-18 14:46:03','2016-01-18 14:48:37'),(581,'Karen','2016-01-18 14:48:40','2016-01-18 14:49:09'),(582,'Rabi','2016-01-18 14:49:13','2016-01-18 14:49:14'),(583,'Randy','2016-01-18 14:49:18','2016-01-18 14:51:58'),(584,'Jerwin','2016-01-18 14:54:30','2016-01-18 14:54:39'),(585,'Randy','2016-01-18 14:54:46','2016-01-18 14:55:34'),(586,'Karen','2016-01-18 14:55:40','2016-01-18 14:56:39'),(587,'Jerwin','2016-01-18 14:56:44','2016-01-18 14:56:51'),(588,'Karen','2016-01-18 14:58:33','2016-01-18 14:58:36'),(589,'Randy','2016-01-18 14:58:41','2016-01-18 14:59:56'),(590,'Karen','2016-01-18 15:00:08','2016-01-18 15:02:20'),(591,'Karen','2016-01-18 15:03:26','2016-01-18 15:06:59'),(592,'Karen','2016-01-18 15:07:36','2016-01-18 15:08:22'),(593,'Jerwin','2016-01-18 15:09:23','2016-01-18 15:10:27'),(594,'Jerwin','2016-01-18 15:25:53','2016-01-18 15:25:59'),(595,'Jerwin','2016-01-18 15:26:58','2016-01-18 15:30:59'),(596,'Jerwin','2016-01-18 15:32:14','2016-01-18 15:38:45'),(597,'Jerwin','2016-01-18 15:41:38','2016-01-18 15:42:48'),(598,'Jerwin','2016-01-18 15:43:20','2016-01-18 15:43:41'),(599,'Jerwin','2016-01-18 15:44:37','2016-01-18 15:44:48'),(600,'Jerwin','2016-01-18 16:37:08','2016-01-18 16:37:18'),(601,'Jerwin','2016-01-18 16:38:20','2016-01-18 16:38:33'),(602,'Jerwin','2016-01-18 16:39:48','2016-01-18 16:39:57'),(603,'Jerwin','2016-01-18 16:40:43','2016-01-18 16:41:07'),(604,'Jerwin','2016-01-18 16:41:41','2016-01-18 16:42:35'),(605,'Jerwin','2016-01-18 16:43:31','2016-01-18 16:44:23'),(606,'Jerwin','2016-01-18 17:33:02','2016-01-18 17:34:11'),(607,'Jerwin','2016-01-18 17:35:01','2016-01-18 17:35:01'),(608,'Rabi','2016-01-18 17:38:35','2016-01-18 17:41:55'),(609,'Rabi','2016-01-18 17:42:23','2016-01-18 17:43:17'),(610,'Jerwin','2016-01-18 17:43:37','2016-01-18 17:43:37'),(611,'Randy','2016-01-18 20:00:10','2016-01-18 20:00:17'),(612,'Randy','2016-01-18 20:24:43','2016-01-18 20:24:49'),(613,'Rabi','2016-01-18 20:24:56','2016-01-18 20:25:13'),(614,'Rabi','2016-01-18 21:20:33','2016-01-18 21:22:48'),(615,'Jerwin','2016-01-18 22:10:58','2016-01-18 22:11:25'),(616,'Jerwin','2016-01-18 22:13:05','2016-01-18 22:19:57'),(617,'Rabi','2016-01-18 22:24:15','2016-01-18 22:25:43'),(618,'Jerwin','2016-01-18 22:28:38','2016-01-18 22:29:16'),(619,'Jerwin','2016-01-18 22:32:36','2016-01-18 22:34:19'),(620,'Jerwin','2016-01-18 22:35:16','2016-01-18 22:35:35'),(621,'Jerwin','2016-01-18 22:37:01','2016-01-18 22:37:16'),(622,'Jerwin','2016-01-18 22:40:55','2016-01-18 22:41:08'),(623,'Jerwin','2016-01-18 22:44:09','2016-01-18 22:44:28'),(624,'Jerwin','2016-01-18 23:06:06','2016-01-18 23:06:36'),(625,'Jerwin','2016-01-18 23:14:55','2016-01-18 23:16:16'),(626,'Randy','2016-01-19 07:09:53','2016-01-19 07:10:01'),(627,'Karen','2016-01-19 07:31:07','2016-01-19 07:31:13'),(628,'Jerwin','2016-01-19 07:40:44','2016-01-19 07:41:11'),(629,'Jerwin','2016-01-19 07:53:21','2016-01-19 07:53:51'),(630,'Jerwin','2016-01-19 08:10:02','2016-01-19 08:10:02'),(631,'Jerwin','2016-01-19 08:22:25','2016-01-19 08:22:33'),(632,'Jerwin','2016-01-19 08:25:45','2016-01-19 08:26:15'),(633,'Jerwin','2016-01-19 08:26:54','2016-01-19 08:27:02'),(634,'Jerwin','2016-01-19 08:37:58','2016-01-19 08:39:05'),(635,'Jerwin','2016-01-19 08:40:16','2016-01-19 08:40:36'),(636,'Rabi','2016-01-19 08:42:35','2016-01-19 08:42:35'),(637,'Jerwin','2016-01-19 08:46:20','2016-01-19 08:46:31'),(638,'Jerwin','2016-01-19 08:54:58','2016-01-19 08:55:21'),(639,'Jerwin','2016-01-19 09:42:26','2016-01-19 09:43:08'),(640,'Jerwin','2016-01-19 19:26:32','2016-01-19 19:26:32'),(641,'Jerwin','2016-01-19 19:28:35','2016-01-19 19:28:35'),(642,'Randy','2016-01-19 19:29:42','2016-01-19 19:29:48'),(643,'Jerwin','2016-01-19 19:30:06','2016-01-19 19:30:27'),(644,'Jerwin','2016-01-19 19:33:55','2016-01-19 19:35:21'),(645,'Jerwin','2016-01-19 19:40:10','2016-01-19 19:44:46'),(646,'Jerwin','2016-01-19 20:27:52','2016-01-19 20:29:40'),(647,'Jerwin','2016-01-19 20:30:58','2016-01-19 20:32:06'),(648,'Jerwin','2016-01-19 20:42:17','2016-01-19 20:44:03'),(649,'Jerwin','2016-01-19 20:51:29','2016-01-19 20:53:33'),(650,'Jerwin','2016-01-19 20:55:15','2016-01-19 20:55:15'),(651,'Jerwin','2016-01-19 21:15:36','2016-01-19 21:16:58'),(652,'Jerwin','2016-01-19 21:18:04','2016-01-19 21:21:42'),(653,'Jerwin','2016-01-19 21:22:28','2016-01-19 21:24:42'),(654,'Jerwin','2016-01-20 18:53:57','2016-01-20 18:54:06'),(655,'Jerwin','2016-01-20 18:54:14','2016-01-20 18:54:28'),(656,'Karen','2016-01-20 18:54:35','2016-01-20 18:54:41'),(657,'Randy','2016-01-20 18:54:48','2016-01-20 18:55:25'),(658,'Jerwin','2016-01-20 18:55:33','2016-01-20 18:55:52'),(659,'Randy','2016-01-20 18:55:58','2016-01-20 18:56:13'),(660,'Jerwin','2016-01-20 18:57:02','2016-01-20 18:57:06'),(661,'Randy','2016-01-20 18:57:15','2016-01-20 18:58:50'),(662,'Randy','2016-01-20 19:07:33','2016-01-20 19:10:48'),(663,'Randy','2016-01-20 19:19:02','2016-01-20 19:57:06'),(664,'Randy','2016-01-20 19:57:36','2016-01-20 20:02:31'),(665,'Randy','2016-01-20 20:25:58','2016-01-20 20:30:46'),(666,'Karen','2016-01-20 20:30:55','2016-01-20 20:31:08'),(667,'Randy','2016-01-20 20:32:51','2016-01-20 20:37:28'),(668,'Randy','2016-01-20 20:37:59','2016-01-20 20:39:11'),(669,'Randy','2016-01-20 20:43:50','2016-01-20 20:45:18'),(670,'Karen','2016-01-20 20:45:21','2016-01-20 20:46:11'),(671,'Jerwin','2016-01-20 20:52:34','2016-01-20 20:56:51'),(672,'Jerwin','2016-01-20 23:06:32','2016-01-20 23:07:01'),(673,'Randy','2016-01-20 23:07:38','2016-01-20 23:08:05'),(674,'Rabi','2016-01-20 23:16:02','2016-01-20 23:17:01'),(675,'Karen','2016-01-20 23:16:41','2016-01-20 23:17:08'),(676,'Randy','2016-01-20 23:20:33','2016-01-20 23:20:32'),(677,'Rabi','2016-01-20 23:21:03','2016-01-20 23:21:22'),(678,'Rabi','2016-01-20 23:27:31','2016-01-20 23:27:31'),(679,'Randy','2016-01-20 23:33:49','2016-01-20 23:34:16'),(680,'Karen','2016-01-20 23:43:52','2016-01-20 23:43:51'),(681,'Randy','2016-01-20 23:44:15','2016-01-20 23:44:42'),(682,'Karen','2016-01-20 23:46:04','2016-01-20 23:47:38'),(683,'Randy','2016-01-20 23:50:26','2016-01-20 23:50:25'),(684,'Karen','2016-01-20 23:52:54','2016-01-20 23:53:21'),(685,'Randy','2016-01-21 00:09:28','2016-01-21 00:09:27'),(686,'Karen','2016-01-21 01:24:58','2016-01-21 01:40:52'),(687,'Karen','2016-01-21 01:42:38','2016-01-21 02:06:21'),(688,'Jerwin','2016-01-24 00:38:19','2016-01-24 00:39:01'),(689,'Jerwin','2016-01-24 15:23:44','2016-01-24 15:26:48'),(690,'Jerwin','2016-01-24 15:30:26','2016-01-24 15:30:26'),(691,'Jerwin','2016-01-24 15:50:28','2016-01-24 15:52:41'),(692,'Jerwin','2016-01-24 15:55:49','2016-01-24 15:58:58'),(693,'Jerwin','2016-01-24 16:04:41','2016-01-24 16:04:57'),(694,'Jerwin','2016-01-24 16:09:15','2016-01-24 16:09:26'),(695,'Jerwin','2016-01-24 16:09:55','2016-01-24 16:10:42'),(696,'Jerwin','2016-01-24 16:12:25','2016-01-24 16:13:17'),(697,'Jerwin','2016-01-24 16:29:38','2016-01-24 16:29:38'),(698,'Jerwin','2016-01-24 16:37:35','2016-01-24 16:38:27'),(699,'Jerwin','2016-01-24 16:38:49','2016-01-24 16:40:21'),(700,'Jerwin','2016-01-24 16:45:07','2016-01-24 16:45:28'),(701,'Jerwin','2016-01-24 16:47:03','2016-01-24 16:47:50'),(702,'Jerwin','2016-01-24 16:48:25','2016-01-24 16:49:25'),(703,'Jerwin','2016-01-24 16:50:06','2016-01-24 16:51:01'),(704,'Jerwin','2016-01-24 16:51:37','2016-01-24 16:52:16'),(705,'Jerwin','2016-01-24 16:53:04','2016-01-24 16:53:35'),(706,'Jerwin','2016-01-24 17:00:09','2016-01-24 17:00:28'),(707,'Jerwin','2016-01-24 17:06:11','2016-01-24 17:06:16'),(708,'Jerwin','2016-01-24 17:09:26','2016-01-24 17:10:08'),(709,'Jerwin','2016-01-24 17:11:22','2016-01-24 17:12:18'),(710,'Jerwin','2016-01-24 17:13:17','2016-01-24 17:13:37'),(711,'Jerwin','2016-01-24 17:15:48','2016-01-24 17:16:46'),(712,'Jerwin','2016-01-24 17:18:10','2016-01-24 17:19:06'),(713,'Jerwin','2016-01-24 17:20:09','2016-01-24 17:21:46'),(714,'Jerwin','2016-01-24 17:22:53','2016-01-24 17:24:08'),(715,'Jerwin','2016-01-24 17:29:39','2016-01-24 17:29:56'),(716,'Randy','2016-01-24 17:30:00','2016-01-24 17:30:30'),(717,'Karen','2016-01-24 17:30:37','2016-01-24 17:31:35'),(718,'Jerwin','2016-01-24 17:33:42','2016-01-24 17:34:22'),(719,'Jerwin','2016-01-24 17:36:17','2016-01-24 17:37:23'),(720,'Jerwin','2016-01-24 18:01:52','2016-01-24 18:02:25'),(721,'Randy','2016-01-24 18:02:30','2016-01-24 18:02:57'),(722,'Karen','2016-01-24 18:05:04','2016-01-24 18:05:04'),(723,'Randy','2016-01-24 18:05:11','2016-01-24 18:08:46'),(724,'Karen','2016-01-24 18:10:27','2016-01-24 18:10:30'),(725,'Randy','2016-01-24 18:10:39','2016-01-24 18:11:05'),(726,'Randy','2016-01-24 18:11:44','2016-01-24 18:11:57'),(727,'Jerwin','2016-01-24 18:14:40','2016-01-24 18:14:46'),(728,'Randy','2016-01-24 18:14:51','2016-01-24 18:15:43'),(729,'Karen','2016-01-24 18:17:06','2016-01-24 18:17:11'),(730,'Randy','2016-01-24 18:17:24','2016-01-24 18:17:43'),(731,'Rabi','2016-01-24 18:29:37','2016-01-24 18:29:37'),(732,'Rabi','2016-01-24 18:32:04','2016-01-24 18:33:17'),(733,'Jerwin','2016-01-24 18:34:52','2016-01-24 18:35:05'),(734,'Jerwin','2016-01-24 18:35:52','2016-01-24 18:37:48'),(735,'Jerwin','2016-01-24 18:39:18','2016-01-24 18:39:33'),(736,'Jerwin','2016-01-24 18:40:04','2016-01-24 18:40:07'),(737,'Jerwin','2016-01-24 18:40:39','2016-01-24 18:41:17'),(738,'Jerwin','2016-01-24 18:59:16','2016-01-24 18:59:49'),(739,'Jerwin','2016-01-24 19:00:45','2016-01-24 19:01:08'),(740,'Jerwin','2016-01-24 19:03:01','2016-01-24 19:03:20'),(741,'Jerwin','2016-01-24 19:04:45','2016-01-24 19:06:39'),(742,'Jerwin','2016-01-24 19:25:37','2016-01-24 19:25:53'),(743,'Jerwin','2016-01-24 19:26:50','2016-01-24 19:26:59'),(744,'Jerwin','2016-01-24 19:27:34','2016-01-24 19:27:34'),(745,'Jerwin','2016-01-24 19:28:28','2016-01-24 19:31:51'),(746,'Jerwin','2016-01-24 19:32:25','2016-01-24 19:33:52'),(747,'Jerwin','2016-01-24 19:34:19','2016-01-24 19:34:58'),(748,'Jerwin','2016-01-24 19:35:57','2016-01-24 19:36:34'),(749,'Jerwin','2016-01-24 19:40:08','2016-01-24 19:40:16'),(750,'Jerwin','2016-01-24 19:45:51','2016-01-24 19:46:01'),(751,'Jerwin','2016-01-24 19:46:58','2016-01-24 19:47:23'),(752,'Jerwin','2016-01-24 21:05:08','2016-01-24 21:09:13'),(753,'Jerwin','2016-01-24 21:17:29','2016-01-24 21:25:23'),(754,'Randy','2016-01-24 21:47:13','2016-01-24 21:47:18'),(755,'Jerwin','2016-01-24 21:47:30','2016-01-24 21:47:34'),(756,'Jerwin','2016-01-26 11:39:38','2016-01-26 11:39:40'),(757,'Rabi','2016-01-26 11:39:49','2016-01-26 11:40:59'),(758,'Rabi','2016-01-26 11:43:35','2016-01-26 11:49:37'),(759,'Jerwin','2016-01-26 11:52:17','2016-01-26 11:52:20'),(760,'Rabi','2016-01-26 11:52:31','2016-01-26 11:53:07'),(761,'Jerwin','2016-01-26 11:53:50','2016-01-26 11:53:55'),(762,'Rabi','2016-01-26 11:54:03','2016-01-26 11:55:13'),(763,'Rabi','2016-01-26 11:59:56','2016-01-26 12:03:44'),(764,'Rabi','2016-01-26 12:12:02','2016-01-26 12:12:38'),(765,'Jerwin','2016-01-26 12:27:26','2016-01-26 12:27:36'),(766,'Rabi','2016-02-07 21:52:03','2016-02-07 21:52:28'),(767,'Rabi','2016-02-09 04:53:35','2016-02-09 04:53:35'),(768,'Rabi','2016-02-09 04:55:49','2016-02-09 04:55:49'),(769,'Rabi','2016-02-09 04:58:41','2016-02-09 05:00:12'),(770,'Rabi','2016-02-09 05:01:08','2016-02-09 05:04:18'),(771,'Rabi','2016-02-09 18:57:52','2016-02-09 18:58:00'),(772,'Rabi','2016-02-09 19:01:33','2016-02-09 19:01:39'),(773,'Rabi','2016-02-09 19:02:02','2016-02-09 19:02:09'),(774,'Rabi','2016-02-09 19:02:34','2016-02-09 19:02:52'),(775,'Jerwin','2016-02-09 19:03:27','2016-02-09 19:03:31'),(776,'Jerwin','2016-02-09 19:03:50','2016-02-09 19:04:00'),(777,'Jerwin','2016-02-09 19:04:46','2016-02-09 19:04:50'),(778,'Rabi','2016-02-09 19:05:36','2016-02-09 19:05:39'),(779,'Rabi','2016-02-09 19:06:01','2016-02-09 19:06:06'),(780,'Rabi','2016-02-09 19:06:48','2016-02-09 19:06:51'),(781,'Rabi','2016-02-09 19:07:57','2016-02-09 19:08:11'),(782,'Rabi','2016-02-09 19:08:38','2016-02-09 19:08:45'),(783,'Rabi','2016-02-09 19:09:11','2016-02-09 19:10:19'),(784,'Rabi','2016-02-09 19:10:37','2016-02-09 19:11:02'),(785,'Rabi','2016-02-09 19:14:42','2016-02-09 19:15:59'),(786,'Rabi','2016-02-09 19:18:16','2016-02-09 19:31:32'),(787,'Rabi','2016-02-09 19:48:14','2016-02-09 19:49:10'),(788,'Rabi','2016-02-09 20:00:04','2016-02-09 20:01:01'),(789,'Rabi','2016-02-09 20:01:40','2016-02-09 20:02:10'),(790,'Rabi','2016-02-09 20:04:50','2016-02-09 20:06:49'),(791,'Rabi','2016-02-09 20:13:36','2016-02-09 20:14:13'),(792,'Rabi','2016-02-09 20:20:53','2016-02-09 20:20:59'),(793,'Rabi','2016-02-09 20:21:14','2016-02-09 20:21:27'),(794,'Jerwin','2016-02-09 20:22:50','2016-02-09 20:22:52'),(795,'Rabi','2016-02-09 20:22:56','2016-02-09 20:23:04'),(796,'Rabi','2016-02-09 20:23:50','2016-02-09 20:24:14'),(797,'Jerwin','2016-02-10 09:08:29','2016-02-10 09:08:52'),(798,'Jerwin','2016-02-10 09:20:52','2016-02-10 09:20:52'),(799,'Jerwin','2016-02-10 09:22:53','2016-02-10 09:22:53'),(800,'Jerwin','2016-02-10 09:23:47','2016-02-10 09:28:56'),(801,'Jerwin','2016-02-10 09:32:46','2016-02-10 09:32:46'),(802,'Jerwin','2016-02-10 09:34:37','2016-02-10 09:37:53'),(803,'Jerwin','2016-02-10 09:41:05','2016-02-10 09:41:20'),(804,'Jerwin','2016-02-10 09:45:32','2016-02-10 09:45:32'),(805,'Randy','2016-02-10 09:46:00','2016-02-10 09:46:07'),(806,'Randy','2016-02-10 09:46:59','2016-02-10 09:46:59'),(807,'Rabi','2016-02-10 09:49:38','2016-02-10 09:50:21'),(808,'Rabi','2016-02-10 09:51:29','2016-02-10 09:51:35'),(809,'Rabi','2016-02-10 09:52:13','2016-02-10 09:52:16'),(810,'Jerwin','2016-02-10 09:59:25','2016-02-10 09:59:32'),(811,'Jerwin','2016-02-10 10:01:24','2016-02-10 10:01:51'),(812,'Rabi','2016-02-10 10:01:56','2016-02-10 10:02:12'),(813,'Jerwin','2016-02-10 10:15:45','2016-02-10 10:15:55'),(814,'Jerwin','2016-02-10 10:17:35','2016-02-10 10:19:09'),(815,'Jerwin','2016-02-10 10:22:44','2016-02-10 10:23:21'),(816,'Jerwin','2016-02-10 10:26:22','2016-02-10 10:26:42'),(817,'Jerwin','2016-02-10 10:29:46','2016-02-10 10:30:07'),(818,'Jerwin','2016-02-10 10:44:38','2016-02-10 10:44:38'),(819,'Jerwin','2016-02-10 10:47:28','2016-02-10 10:48:11'),(820,'Jerwin','2016-02-10 10:48:56','2016-02-10 10:51:36'),(821,'Rabi','2016-02-10 10:53:32','2016-02-10 10:54:24'),(822,'Rabi','2016-02-10 10:57:07','2016-02-10 10:57:07'),(823,'Jerwin','2016-02-10 11:02:32','2016-02-10 11:02:38'),(824,'Rabi','2016-02-10 11:03:03','2016-02-10 11:03:42'),(825,'Rabi','2016-02-10 11:04:49','2016-02-10 11:21:17'),(826,'Rabi','2016-02-10 11:37:48','2016-02-10 11:38:30'),(827,'Rabi','2016-02-10 11:41:55','2016-02-10 11:42:48'),(828,'Rabi','2016-02-10 11:45:29','2016-02-10 11:46:03'),(829,'Rabi','2016-02-10 11:46:54','2016-02-10 11:47:16'),(830,'Rabi','2016-02-10 11:47:43','2016-02-10 11:48:05'),(831,'Rabi','2016-02-10 11:50:36','2016-02-10 11:52:02'),(832,'Rabi','2016-02-10 11:53:09','2016-02-10 11:53:25'),(833,'Rabi','2016-02-10 11:53:57','2016-02-10 11:55:39'),(834,'Rabi','2016-02-10 11:58:44','2016-02-10 11:59:22'),(835,'Jerwin','2016-02-10 12:05:43','2016-02-10 12:06:45'),(836,'Rabi','2016-02-10 12:06:50','2016-02-10 12:14:00'),(837,'Jerwin','2016-02-10 12:14:06','2016-02-10 12:15:42'),(838,'Jerwin','2016-02-10 12:17:01','2016-02-10 12:18:03'),(839,'Rabi','2016-02-10 12:26:03','2016-02-10 12:26:18'),(840,'Rabi','2016-02-10 12:26:39','2016-02-10 12:27:53'),(841,'Rabi','2016-02-10 12:28:11','2016-02-10 12:29:20'),(842,'Rabi','2016-02-10 12:30:02','2016-02-10 12:31:30'),(843,'Rabi','2016-02-10 12:34:34','2016-02-10 12:34:41'),(844,'Rabi','2016-02-10 12:35:51','2016-02-10 12:35:59'),(845,'Rabi','2016-02-10 12:36:41','2016-02-10 12:36:47'),(846,'Rabi','2016-02-10 12:38:06','2016-02-10 12:38:26'),(847,'Rabi','2016-02-10 12:39:16','2016-02-10 12:39:40'),(848,'Rabi','2016-02-10 12:40:19','2016-02-10 12:43:59'),(849,'Rabi','2016-02-10 12:44:49','2016-02-10 12:46:50'),(850,'Rabi','2016-02-10 12:48:40','2016-02-10 12:49:14'),(851,'Rabi','2016-02-10 13:09:04','2016-02-10 13:09:09'),(852,'Karen','2016-02-10 13:09:13','2016-02-10 13:09:36'),(853,'Rabi','2016-02-10 13:09:40','2016-02-10 13:09:59'),(854,'Karen','2016-02-10 13:10:07','2016-02-10 13:10:18'),(855,'Rabi','2016-02-10 13:10:25','2016-02-10 13:10:37'),(856,'Karen','2016-02-10 13:10:40','2016-02-10 13:10:46'),(857,'Rabi','2016-02-10 13:18:43','2016-02-10 13:18:54'),(858,'Randy','2016-02-10 13:18:58','2016-02-10 13:19:03'),(859,'Rabi','2016-02-10 13:19:12','2016-02-10 13:19:23'),(860,'Rabi','2016-02-10 13:19:33','2016-02-10 13:19:46'),(861,'Randy','2016-02-10 13:19:50','2016-02-10 13:19:52'),(862,'Rabi','2016-02-10 13:38:56','2016-02-10 13:39:19'),(863,'Rabi','2016-02-10 13:43:35','2016-02-10 13:44:02'),(864,'Rabi','2016-02-10 13:52:58','2016-02-10 13:58:34'),(865,'Randy','2016-02-10 13:59:11','2016-02-10 13:59:15'),(866,'Rabi','2016-02-10 13:59:19','2016-02-10 13:59:44'),(867,'Rabi','2016-02-10 14:00:26','2016-02-10 14:00:43'),(868,'Rabi','2016-02-10 14:02:57','2016-02-10 14:07:32'),(869,'Randy','2016-02-10 14:09:01','2016-02-10 14:09:04'),(870,'Jerwin','2016-02-10 14:09:07','2016-02-10 14:09:25'),(871,'Jerwin','2016-02-10 14:12:00','2016-02-10 14:12:29'),(872,'Jerwin','2016-02-10 14:13:01','2016-02-10 14:14:32'),(873,'Jerwin','2016-02-10 14:16:29','2016-02-10 14:16:29'),(874,'Rabi','2016-02-10 14:17:05','2016-02-10 14:17:05'),(875,'Rabi','2016-02-10 14:18:39','2016-02-10 14:18:47'),(876,'Jerwin','2016-02-10 14:18:51','2016-02-10 14:19:54'),(877,'Jerwin','2016-02-10 14:21:56','2016-02-10 14:21:56'),(878,'Jerwin','2016-02-10 14:28:28','2016-02-10 14:28:33'),(879,'Jerwin','2016-02-10 14:28:37','2016-02-10 14:28:38'),(880,'Rabi','2016-02-10 14:28:42','2016-02-10 14:28:43'),(881,'Randy','2016-02-10 14:28:47','2016-02-10 14:28:49'),(882,'Jerwin','2016-02-10 14:31:57','2016-02-10 14:31:58'),(883,'Jerwin','2016-02-10 14:36:18','2016-02-10 14:37:11'),(884,'Jerwin','2016-02-10 14:38:30','2016-02-10 14:38:44'),(885,'Jerwin','2016-02-10 14:43:16','2016-02-10 14:43:47'),(886,'Jerwin','2016-02-10 14:49:11','2016-02-10 14:49:34'),(887,'Jerwin','2016-02-10 14:50:24','2016-02-10 14:50:24'),(888,'Jerwin','2016-02-10 14:56:19','2016-02-10 14:56:19'),(889,'Jerwin','2016-02-10 14:57:38','2016-02-10 14:59:03'),(890,'Jerwin','2016-02-10 14:59:56','2016-02-10 15:01:52'),(891,'Jerwin','2016-02-10 15:03:18','2016-02-10 15:05:07'),(892,'Jerwin','2016-02-10 15:06:56','2016-02-10 15:09:12'),(893,'Jerwin','2016-02-10 15:10:28','2016-02-10 15:13:06'),(894,'Jerwin','2016-02-10 15:13:26','2016-02-10 15:14:08'),(895,'Jerwin','2016-02-10 15:16:24','2016-02-10 15:17:02'),(896,'Jerwin','2016-02-10 15:20:17','2016-02-10 15:20:40'),(897,'Jerwin','2016-02-10 15:22:05','2016-02-10 15:22:14'),(898,'Rabi','2016-02-10 15:22:46','2016-02-10 15:25:53'),(899,'Rabi','2016-02-10 15:33:46','2016-02-10 15:34:45'),(900,'Rabi','2016-02-10 15:36:39','2016-02-10 15:37:28'),(901,'Jerwin','2016-02-10 15:38:16','2016-02-10 15:39:00'),(902,'Rabi','2016-02-10 15:40:56','2016-02-10 15:41:39'),(903,'Randy','2016-02-12 21:22:55','2016-02-12 21:23:19'),(904,'Rabi','2016-02-12 21:23:25','2016-02-12 21:24:15'),(905,'Rabi','2016-02-12 21:25:35','2016-02-12 21:25:58'),(906,'Rabi','2016-02-12 21:26:49','2016-02-12 21:27:18'),(907,'Rabi','2016-02-12 21:27:56','2016-02-12 21:27:56'),(908,'Rabi','2016-02-12 21:38:11','2016-02-12 21:40:19'),(909,'Rabi','2016-02-12 21:46:08','2016-02-12 21:46:37'),(910,'Rabi','2016-02-12 21:47:58','2016-02-12 21:48:25'),(911,'Rabi','2016-02-12 21:48:41','2016-02-12 21:50:39'),(912,'Karen','2016-02-12 21:50:58','2016-02-12 21:51:09'),(913,'Rabi','2016-02-12 21:51:17','2016-02-12 21:51:38'),(914,'Karen','2016-02-12 21:51:42','2016-02-12 21:51:42'),(915,'Rabi','2016-02-12 21:56:51','2016-02-12 21:57:05'),(916,'Jerwin','2016-02-12 21:57:14','2016-02-12 21:57:38'),(917,'Rabi','2016-02-12 21:59:15','2016-02-12 22:00:05'),(918,'Karen','2016-02-12 22:00:09','2016-02-12 22:00:46'),(919,'Rabi','2016-02-12 22:00:53','2016-02-12 22:01:36'),(920,'Karen','2016-02-12 22:01:40','2016-02-12 22:01:46'),(921,'Randy','2016-02-12 22:01:50','2016-02-12 22:02:23'),(922,'Karen','2016-02-12 22:02:27','2016-02-12 22:03:26'),(923,'Jerwin','2016-02-12 22:03:33','2016-02-12 22:03:51'),(924,'Rabi','2016-02-12 22:03:56','2016-02-12 22:03:56'),(925,'Rabi','2016-02-12 22:08:28','2016-02-12 22:09:36'),(926,'Jerwin','2016-02-12 22:10:12','2016-02-12 22:10:40'),(927,'Rabi','2016-02-12 22:10:46','2016-02-12 22:11:23'),(928,'Rabi','2016-02-12 22:12:46','2016-02-12 22:12:58'),(929,'Karen','2016-02-12 22:13:12','2016-02-12 22:13:37'),(930,'Rabi','2016-02-12 22:13:42','2016-02-12 22:13:53'),(931,'Randy','2016-02-12 22:13:57','2016-02-12 22:14:11'),(932,'Karen','2016-02-12 22:14:15','2016-02-12 22:15:10'),(933,'Rabi','2016-02-12 22:16:32','2016-02-12 22:17:38'),(934,'Rabi','2016-02-12 22:18:31','2016-02-12 22:19:04'),(935,'Randy','2016-02-14 10:48:45','2016-02-14 10:48:45'),(936,'Karen','2016-02-14 10:50:02','2016-02-14 10:50:30'),(937,'Rabi','2016-02-14 10:52:31','2016-02-14 10:52:35'),(938,'Randy','2016-02-14 11:06:43','2016-02-14 10:55:02'),(939,'Randy','2016-02-14 11:08:23','2016-02-14 11:04:12'),(940,'Rabi','2016-02-14 10:57:41','2016-02-14 10:57:41'),(941,'Rabi','2016-02-14 11:16:38','2016-02-14 11:06:38'),(942,'Randy','2016-02-14 11:26:01','2016-02-14 11:15:52'),(943,'Randy','2016-02-14 11:28:59','2016-02-14 11:31:53'),(944,'Rabi','2016-02-14 11:28:03','2016-02-14 11:28:02'),(945,'Randy','2016-02-14 11:43:59','2016-02-14 11:35:19'),(946,'Jerwin','2016-02-14 11:37:35','2016-02-14 11:37:35'),(947,'Jerwin','2016-02-14 11:40:22','2016-02-14 11:40:22'),(948,'Randy','2016-02-14 11:52:33','2016-02-14 11:41:01'),(949,'Randy','2016-02-14 11:56:45','2016-02-14 11:45:32'),(950,'Randy','2016-02-14 11:58:56','2016-02-14 11:47:13'),(951,'Jerwin','2016-02-14 11:47:51','2016-02-14 11:47:51'),(952,'Randy','2016-02-14 12:01:24','2016-02-14 11:49:46'),(953,'Randy','2016-02-14 12:02:27','2016-02-14 11:50:46'),(954,'Randy','2016-02-14 12:04:52','2016-02-14 11:52:52'),(955,'Randy','2016-02-14 12:06:27','2016-02-14 11:54:27'),(956,'Jerwin','2016-02-14 11:54:30','2016-02-14 11:54:30'),(957,'Randy','2016-02-14 12:08:44','2016-02-14 11:56:44'),(958,'Randy','2016-02-14 12:09:33','2016-02-14 11:57:32'),(959,'Randy','2016-02-14 12:11:00','2016-02-14 11:59:33'),(960,'Randy','2016-02-14 12:11:46','2016-02-14 12:00:43'),(961,'Randy','2016-02-14 12:13:25','2016-02-14 12:01:30'),(962,'Randy','2016-02-14 12:13:50','2016-02-14 12:01:50'),(963,'Randy','2016-02-14 12:16:06','2016-02-14 12:04:31'),(964,'Randy','2016-02-14 12:16:54','2016-02-14 12:07:52'),(965,'Jerwin','2016-02-14 12:08:56','2016-02-14 12:08:56'),(966,'Jerwin','2016-02-14 12:10:17','2016-02-14 12:10:17'),(967,'Jerwin','2016-02-14 12:11:01','2016-02-14 12:11:01'),(968,'Randy','2016-02-14 12:25:02','2016-02-14 12:15:17'),(969,'Jerwin','2016-02-14 12:14:09','2016-02-14 12:14:09'),(970,'Randy','2016-02-14 12:28:55','2016-02-14 12:17:23'),(971,'Jerwin','2016-02-14 12:17:09','2016-02-14 12:17:09'),(972,'Randy','2016-02-14 12:30:31','2016-02-14 12:18:50'),(973,'Rabi','2016-02-14 12:34:36','2016-02-14 12:34:11'),(974,'Jerwin','2016-02-14 12:23:25','2016-02-14 12:23:25'),(975,'Rabi','2016-02-14 12:46:55','2016-02-14 12:34:55'),(976,'Rabi','2016-02-14 12:50:55','2016-02-14 12:41:57'),(977,'Jerwin','2016-02-14 12:39:00','2016-02-14 12:39:00'),(978,'Rabi','2016-02-14 12:39:57','2016-02-14 12:39:57'),(979,'Rabi','2016-02-14 12:41:36','2016-02-14 12:41:36'),(980,'Rabi','2016-02-14 12:54:28','2016-02-14 12:45:19'),(981,'Rabi','2016-02-14 12:43:06','2016-02-14 12:43:06'),(982,'Rabi','2016-02-14 13:01:28','2016-02-14 13:03:25'),(983,'Jerwin','2016-02-14 12:53:39','2016-02-14 12:53:39'),(984,'Rabi','2016-02-14 13:03:36','2016-02-14 13:04:37'),(985,'Rabi','2016-02-14 13:09:01','2016-02-14 13:09:01'),(986,'Karen','2016-02-14 13:21:27','2016-02-14 13:12:17'),(987,'Rabi','2016-02-14 13:11:10','2016-02-14 13:11:10'),(988,'Rabi','2016-02-14 13:12:13','2016-02-14 13:12:13'),(989,'Randy','2016-02-14 13:24:26','2016-02-14 13:16:22'),(990,'Rabi','2016-02-14 13:13:01','2016-02-14 13:13:01'),(991,'Rabi','2016-02-14 13:14:15','2016-02-14 13:14:15'),(992,'Rabi','2016-02-14 13:15:06','2016-02-14 13:15:06'),(993,'Jerwin','2016-02-14 13:28:33','2016-02-14 13:16:33'),(994,'Rabi','2016-02-14 13:17:14','2016-02-14 13:17:14'),(995,'Jerwin','2016-02-14 13:28:49','2016-02-14 13:28:55'),(996,'Jerwin','2016-02-14 13:30:15','2016-02-14 13:30:19'),(997,'Jerwin','2016-02-14 13:30:41','2016-02-14 13:31:48'),(998,'Jerwin','2016-02-14 13:32:25','2016-02-14 13:32:31'),(999,'Jerwin','2016-02-14 13:32:53','2016-02-14 13:32:57'),(1000,'Jerwin','2016-02-14 13:33:45','2016-02-14 13:36:14'),(1001,'Rabi','2016-02-14 13:56:34','2016-02-14 13:58:33'),(1002,'Jerwin','2016-02-14 13:49:45','2016-02-14 13:49:45'),(1003,'Jerwin','2016-02-14 13:50:19','2016-02-14 13:50:19'),(1004,'Jerwin','2016-02-14 13:54:10','2016-02-14 13:54:10'),(1005,'Jerwin','2016-02-14 13:56:21','2016-02-14 13:56:21'),(1006,'Karen','2016-02-14 14:10:53','2016-02-14 14:00:33'),(1007,'Rabi','2016-02-14 13:59:28','2016-02-14 13:59:28'),(1008,'Rabi','2016-02-14 14:00:34','2016-02-14 14:00:34'),(1009,'Rabi','2016-02-14 14:01:25','2016-02-14 14:01:53'),(1010,'Rabi','2016-02-14 14:15:17','2016-02-14 14:12:55'),(1011,'Jerwin','2016-02-14 14:03:35','2016-02-14 14:03:35'),(1012,'Rabi','2016-02-14 14:04:17','2016-02-14 14:04:17'),(1013,'Karen','2016-02-14 14:06:06','2016-02-14 14:06:08'),(1014,'Rabi','2016-02-14 14:12:49','2016-02-14 14:12:52'),(1015,'Rabi','2016-02-14 14:17:11','2016-02-14 14:17:11'),(1016,'Jerwin','2016-02-14 14:29:41','2016-02-14 14:17:40'),(1017,'Randy','2016-02-14 14:17:50','2016-02-14 14:17:52'),(1018,'Karen','2016-02-14 14:19:33','2016-02-14 14:20:01'),(1019,'Karen','2016-02-14 14:35:54','2016-02-14 14:36:22'),(1020,'Randy','2016-02-14 14:36:42','2016-02-14 15:47:29'),(1021,'Rabi','2016-02-14 16:03:19','2016-02-14 15:59:05'),(1022,'Karen','2016-02-14 15:53:03','2016-02-14 15:53:32'),(1023,'Rabi','2016-02-14 15:55:23','2016-02-14 15:55:26'),(1024,'Rabi','2016-02-14 15:55:53','2016-02-14 15:56:22'),(1025,'Rabi','2016-02-14 15:56:48','2016-02-14 15:56:48'),(1026,'Jerwin','2016-02-14 15:56:59','2016-02-14 15:57:28'),(1027,'Rabi','2016-02-14 15:58:50','2016-02-14 15:58:52'),(1028,'Randy','2016-02-14 15:59:06','2016-02-14 15:59:09'),(1029,'Karen','2016-02-14 15:59:55','2016-02-14 15:59:55'),(1030,'Rabi','2016-02-14 16:07:11','2016-02-14 16:07:14'),(1031,'Karen','2016-02-14 16:08:21','2016-02-14 16:17:29'),(1032,'Karen','2016-02-14 16:17:34','2016-02-14 16:17:54'),(1033,'Karen','2016-02-14 16:18:01','2016-02-14 16:18:06'),(1034,'Rabi','2016-02-14 16:22:15','2016-02-14 16:24:08'),(1035,'Karen','2016-02-14 16:24:15','2016-02-14 16:25:09'),(1036,'Rabi','2016-02-14 16:25:15','2016-02-14 16:33:16'),(1037,'Rabi','2016-02-14 16:51:41','2016-02-14 16:49:13'),(1038,'Rabi','2016-02-14 16:42:15','2016-02-14 16:42:15'),(1039,'Rabi','2016-02-14 16:44:31','2016-02-14 16:44:31'),(1040,'Randy','2016-02-14 16:46:08','2016-02-14 16:46:08'),(1041,'Rabi','2016-02-14 16:46:19','2016-02-14 16:46:19'),(1042,'Rabi','2016-02-14 16:47:51','2016-02-14 16:47:51'),(1043,'Rabi','2016-02-14 16:49:05','2016-02-14 16:49:05'),(1044,'Rabi','2016-02-14 16:53:00','2016-02-14 16:53:20'),(1045,'Rabi','2016-02-14 16:53:24','2016-02-14 16:59:27'),(1046,'Rabi','2016-02-14 16:59:39','2016-02-14 18:05:18'),(1047,'Rabi','2016-02-21 13:39:17','2016-02-21 13:41:26'),(1048,'Jerwin','2016-02-21 13:46:07','2016-02-21 13:48:24'),(1049,'Rabi','2016-02-21 13:48:28','2016-02-21 13:51:19'),(1050,'Rabi','2016-02-21 13:54:02','2016-02-21 13:54:19'),(1051,'Jerwin','2016-02-21 13:54:26','2016-02-21 13:54:55'),(1052,'Jerwin','2016-02-21 13:56:06','2016-02-21 13:56:12'),(1053,'Randy','2016-02-21 13:56:17','2016-02-21 13:57:41'),(1054,'Jerwin','2016-02-21 13:57:47','2016-02-21 13:58:01'),(1055,'Jerwin','2016-02-21 14:01:18','2016-02-21 14:01:24'),(1056,'Jerwin','2016-02-21 14:01:28','2016-02-21 14:01:47'),(1057,'Jerwin','2016-02-21 14:03:22','2016-02-21 14:03:23'),(1058,'Jerwin','2016-02-21 14:03:31','2016-02-21 14:03:41');
/*!40000 ALTER TABLE `login_trail_tbl` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary table structure for view `login_trail_view`
--

DROP TABLE IF EXISTS `login_trail_view`;
/*!50001 DROP VIEW IF EXISTS `login_trail_view`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `login_trail_view` (
  `employee_name` tinyint NOT NULL,
  `datetime_in` tinyint NOT NULL,
  `datetime_out` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Temporary table structure for view `monthly_sales_report`
--

DROP TABLE IF EXISTS `monthly_sales_report`;
/*!50001 DROP VIEW IF EXISTS `monthly_sales_report`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `monthly_sales_report` (
  `Month_index` tinyint NOT NULL,
  `Month` tinyint NOT NULL,
  `Sales` tinyint NOT NULL,
  `Year` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Temporary table structure for view `product_inspection_view`
--

DROP TABLE IF EXISTS `product_inspection_view`;
/*!50001 DROP VIEW IF EXISTS `product_inspection_view`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `product_inspection_view` (
  `Item_Code` tinyint NOT NULL,
  `Description` tinyint NOT NULL,
  `Category` tinyint NOT NULL,
  `Unit_Price` tinyint NOT NULL,
  `Specification` tinyint NOT NULL,
  `Warranty` tinyint NOT NULL,
  `Replacement_Period` tinyint NOT NULL,
  `Quantity_On_Hand` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `product_invoice_tbl`
--

DROP TABLE IF EXISTS `product_invoice_tbl`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `product_invoice_tbl` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `invoice_id` int(11) DEFAULT NULL,
  `product_id` varchar(20) DEFAULT NULL,
  `quantity` int(11) DEFAULT NULL,
  `subtotal` decimal(10,2) DEFAULT NULL,
  `consumed` bit(1) DEFAULT b'0',
  `discount_percent` decimal(8,2) DEFAULT '0.00',
  `discount_fixed` decimal(8,2) DEFAULT '0.00',
  PRIMARY KEY (`id`),
  KEY `invoice_fk_idx` (`invoice_id`),
  KEY `product_fk_idx` (`product_id`),
  CONSTRAINT `invoice_fk` FOREIGN KEY (`invoice_id`) REFERENCES `invoice_tbl` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `product_fk` FOREIGN KEY (`product_id`) REFERENCES `product_tbl` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=28 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `product_invoice_tbl`
--

LOCK TABLES `product_invoice_tbl` WRITE;
/*!40000 ALTER TABLE `product_invoice_tbl` DISABLE KEYS */;
INSERT INTO `product_invoice_tbl` VALUES (1,1,'CTVB1D1015M00',50,15000.00,'',0.00,0.00),(2,5,'CTVB1D1015M00',1,300.00,'',0.00,0.00),(3,15,'CTVB1D1015M00',1,300.00,'',0.00,0.00),(4,28,'ACCB1D1015M30',100,20000.00,'\0',0.00,0.00),(5,28,'SWGB1D1015M09',7,1400.00,'\0',0.00,0.00),(6,28,'CTVB1D1015M00',2,600.00,'\0',0.00,0.00),(7,50,'ACCB1D1015M30',1,200.00,'',0.00,0.00),(8,54,'CTVB1D1015M00',1,400.00,'',0.00,0.00),(9,72,'SWGB1D1015M09',1,200.00,'\0',0.00,0.00),(10,75,'SWGB1D1015M09',3,600.00,'\0',0.00,0.00),(11,80,'CTVB1D1015M00',1,400.00,'',0.00,0.00),(12,80,'SWGB1D1015M09',12,2400.00,'',0.00,0.00),(13,86,'CTVB1D1015M00',8,3200.00,'\0',0.00,0.00),(14,87,'CTVB1D1015M00',14,5600.00,'',0.00,0.00),(15,90,'ACCB1D1015M30',5,1000.00,'\0',0.00,0.00),(16,92,'ACCB1D1015M30',1,200.00,'',0.00,0.00),(17,95,'ACCB1D1015M30',5,1000.00,'',0.00,0.00),(18,95,'SWGB1D1015M09',1,200.00,'',0.00,0.00),(19,95,'CTVB1D1015M00',1,400.00,'',0.00,0.00),(20,98,'SWGB1D1015M09',1,200.00,'',0.00,0.00),(21,98,'SWGB1D1015M09',-1,-200.00,'\0',0.00,0.00),(22,95,'ACCB1D1015M30',-2,-400.00,'\0',0.00,0.00),(23,95,'ACCB1D1015M30',-2,-400.00,'\0',0.00,0.00),(24,110,'ACCB1D1015M30',5,1000.00,'',0.00,0.00),(25,112,'ACCB1D1015M30',2,400.00,'',0.00,0.00),(26,116,'ACCB1D1015M30',2,400.00,'',0.00,0.00),(27,118,'ACCB1D1015M30',1,200.00,'',0.00,0.00);
/*!40000 ALTER TABLE `product_invoice_tbl` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `product_return_tbl`
--

DROP TABLE IF EXISTS `product_return_tbl`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `product_return_tbl` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `product_invoice_id` int(11) DEFAULT NULL,
  `qty_returned` varchar(45) DEFAULT NULL,
  `date_returned` date DEFAULT NULL,
  `reason` mediumtext,
  `product_id` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `return_invoice_id_idx` (`product_invoice_id`),
  CONSTRAINT `return_invoice_id` FOREIGN KEY (`product_invoice_id`) REFERENCES `product_invoice_tbl` (`invoice_id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `product_return_tbl`
--

LOCK TABLES `product_return_tbl` WRITE;
/*!40000 ALTER TABLE `product_return_tbl` DISABLE KEYS */;
/*!40000 ALTER TABLE `product_return_tbl` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary table structure for view `product_return_view`
--

DROP TABLE IF EXISTS `product_return_view`;
/*!50001 DROP VIEW IF EXISTS `product_return_view`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `product_return_view` (
  `transaction_no` tinyint NOT NULL,
  `product` tinyint NOT NULL,
  `qty_returned` tinyint NOT NULL,
  `date_returned` tinyint NOT NULL,
  `supplier` tinyint NOT NULL,
  `reason` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `product_tbl`
--

DROP TABLE IF EXISTS `product_tbl`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `product_tbl` (
  `id` varchar(20) NOT NULL,
  `name` varchar(45) DEFAULT NULL,
  `description` text,
  `unit` varchar(45) DEFAULT NULL,
  `unit_cost` decimal(10,2) DEFAULT NULL,
  `unit_price` decimal(10,2) DEFAULT NULL,
  `maintaining_stocks` int(11) DEFAULT NULL,
  `category_id` int(11) DEFAULT NULL,
  `warranty` varchar(45) DEFAULT NULL,
  `replacement` varchar(45) DEFAULT NULL,
  `supplier_id` int(11) DEFAULT NULL,
  `serial_code` varchar(45) DEFAULT NULL,
  `archive` enum('1','0') DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id_UNIQUE` (`id`),
  KEY `product_category_fk_idx` (`category_id`),
  KEY `product_supplier_fk_idx` (`supplier_id`),
  CONSTRAINT `product_category_fk` FOREIGN KEY (`category_id`) REFERENCES `category_tbl` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `product_supplier_fk` FOREIGN KEY (`supplier_id`) REFERENCES `supplier_tbl` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `product_tbl`
--

LOCK TABLES `product_tbl` WRITE;
/*!40000 ALTER TABLE `product_tbl` DISABLE KEYS */;
INSERT INTO `product_tbl` VALUES ('A000001','Varifocal IR Camera','1/3\" sony Color CCD/600TVL','pcs',11978.40,12000.00,100,1,'1 year','1 year',1,'00001','0'),('AB000001','Varifocal IR Camera','1/3\" Sharp Color CCD/600TVL/OSD Control ','pcs',12397.00,13000.00,100,1,'1 year','1 year',1,'000011','0'),('ABC000002','Varifocal IR Camera','1/3\" Sony Color 480TVL','200',14264.00,156890.00,90,1,'1 week','1 month',3,'000014','0'),('ABC000003','Varifocal IR Camera','1/3\" Sony COLOR/600TVL','55',12171.00,122722.00,65,1,'1 week','1 month',3,'000013','0'),('ABC000005','Varifocal IR Camera','1/4\" sharp Color CCD/420TVL Sharp','pcs',1577.40,1600.00,100,1,'1 year','1 year',1,'00004','0'),('ABC000009','Access Control Terminals','FingerPrint Professional Access Control Terminal','pcs',39600.00,40000.00,100,6,'1 year','1 year',1,'00007','0'),('ABC000010','FingerPrint Access Control Terminals','Access Control Terminals','65',31350.00,31555.00,75,6,'1 week','3 months',2,'SS-7080','0'),('ABC000011','Access Control Terminals','FingerPrint Professional Access Control  Terminal-SS-7020','pcs',39600.00,40000.00,100,6,'1 year','1 year',1,'000030','0'),('ABC000012','Access Control Terminals','Fingerprint Pro','25',31350.00,355560.00,25,6,'1 WEEK','3 months',2,'SS-7020S','0'),('ABC000013','Card Reader','RFID Professional Wiegand/ Card Readers-SS10E','pcs',1320.00,1400.00,100,4,'1 year','1 year',1,'00003','0'),('ABC000014','Card Readers','RFID Professional Wiegand/ Card Readers-SS-30E','pcs',2475.00,2475.00,100,4,'1 year','1 year',1,'000010','0'),('ABC000015','Card Reader','RFID Professional Wiegand / Card Readers-SS-20M','pcs',1320.00,1400.00,100,4,'1 year','1 year',1,'00009','0'),('ABC000016','Card Readers','RFID Professional Wiegand/ Card Readers-SS-10E','pcs',1650.00,1700.00,100,4,'1 year','1 year',1,'000027','0'),('ABC000017','FingerPrint DoorLocks','Hi-Tech','75',19800.00,2899876.00,75,5,'1 week','3 months',2,'L1000','0'),('ABC000019','FingerPrint Door Locks','Door Lock','45',13200.00,133969.00,55,5,'1 week','3 months',2,'L100','0'),('ABC000020','Door Locks','Finger Print Door Locks','pcs',8250.00,9000.00,100,5,'1 year','1 year',1,'00005','0'),('ABC000021','Proximity Card  and Time Attendane Terminals','Pro Prox Card Time and Attendance','35',12375.00,155566.00,55,2,'1 week','3 months',2,'SS-200','0'),('ABC000022','Proximity Card Time Attendance Terminals','Professional Proximity Card Time&Attendance Terminals Smart-SS-300 ','pcs',14025.00,15000.00,100,2,'1 year','1 year',1,'00006','0'),('ABC000023','TProximity Card and Time Attendance','Professional Proximity Card Time and Attendance','85',25575.00,265765.00,89,2,'1 week','3 months',2,'SS-400','0'),('ABC000024','Proximity Card Time and Attendance','Pro Prox Card Time and Attendance','65',330000.00,3333000.00,75,2,'1 week ','3 months',2,'SS-680','0'),('ABC000025','Proximity Card Time Attendace','Professional Proximity Card Time & Attendace TerminalsSmart-SS-2000 Smart','pcs',47850.00,48000.00,100,2,'1 year','1 year',1,'00002','0'),('ABC000026','Proximity Card Time Attendance Terminals','Professional Proximity Card Time&Attendance Terminals Smart-SS-880','pcs',36300.00,37000.00,100,2,'1 year','1 year',1,'00008','0'),('ABC000027','Siren Series','Siren without light','pcs',363.00,400.00,100,8,'1 year','1 year',1,'000028','0'),('ABC000028','Siren Series','Strobe Light','55',643.00,743.00,85,8,'1 week','3 months',2,'0000015','0'),('ABC000029','Panic Button','Big Panic Button','85',128.70,130.70,95,7,'1 week','3 months',2,'000019','0'),('ABC000030','Panic Button','Panic Button Small','25',13846.00,168000.00,26,7,'1 week','1 month',2,'000012','0');
/*!40000 ALTER TABLE `product_tbl` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary table structure for view `product_transaction_view`
--

DROP TABLE IF EXISTS `product_transaction_view`;
/*!50001 DROP VIEW IF EXISTS `product_transaction_view`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `product_transaction_view` (
  `transaction_id` tinyint NOT NULL,
  `description` tinyint NOT NULL,
  `unit_price` tinyint NOT NULL,
  `qty_sold` tinyint NOT NULL,
  `grp_price` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `product_variants_tbl`
--

DROP TABLE IF EXISTS `product_variants_tbl`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `product_variants_tbl` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `variant` varchar(30) DEFAULT NULL,
  `quantity` int(11) DEFAULT NULL,
  `unit_price` decimal(10,2) DEFAULT NULL,
  `var_level` int(11) DEFAULT NULL,
  `product_id` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `product_id` (`product_id`),
  CONSTRAINT `product_variants_tbl_ibfk_1` FOREIGN KEY (`product_id`) REFERENCES `product_tbl` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `product_variants_tbl`
--

LOCK TABLES `product_variants_tbl` WRITE;
/*!40000 ALTER TABLE `product_variants_tbl` DISABLE KEYS */;
/*!40000 ALTER TABLE `product_variants_tbl` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary table structure for view `purchased_product_view`
--

DROP TABLE IF EXISTS `purchased_product_view`;
/*!50001 DROP VIEW IF EXISTS `purchased_product_view`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `purchased_product_view` (
  `Name` tinyint NOT NULL,
  `Barcode` tinyint NOT NULL,
  `quantity` tinyint NOT NULL,
  `unit_price` tinyint NOT NULL,
  `Sales` tinyint NOT NULL,
  `category` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `receipt_tbl`
--

DROP TABLE IF EXISTS `receipt_tbl`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `receipt_tbl` (
  `invoice_id` int(11) NOT NULL,
  `net_price` decimal(10,2) NOT NULL,
  `cash_tender` decimal(10,2) NOT NULL,
  `changed` decimal(10,2) NOT NULL,
  `cname` varchar(45) DEFAULT NULL,
  `address` longtext,
  PRIMARY KEY (`invoice_id`),
  CONSTRAINT `receipt_invoice_fk` FOREIGN KEY (`invoice_id`) REFERENCES `invoice_tbl` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `receipt_tbl`
--

LOCK TABLES `receipt_tbl` WRITE;
/*!40000 ALTER TABLE `receipt_tbl` DISABLE KEYS */;
/*!40000 ALTER TABLE `receipt_tbl` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary table structure for view `sales_today_view`
--

DROP TABLE IF EXISTS `sales_today_view`;
/*!50001 DROP VIEW IF EXISTS `sales_today_view`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `sales_today_view` (
  `Date` tinyint NOT NULL,
  `Total_Sales` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Temporary table structure for view `stock_movement_view`
--

DROP TABLE IF EXISTS `stock_movement_view`;
/*!50001 DROP VIEW IF EXISTS `stock_movement_view`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `stock_movement_view` (
  `sold_items` tinyint NOT NULL,
  `product_id` tinyint NOT NULL,
  `monthly` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `supplier_tbl`
--

DROP TABLE IF EXISTS `supplier_tbl`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `supplier_tbl` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(45) DEFAULT NULL,
  `address` mediumtext,
  `contact_number` varchar(45) DEFAULT NULL,
  `contact_person` varchar(45) DEFAULT NULL,
  `archive` bit(1) DEFAULT b'0',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `supplier_tbl`
--

LOCK TABLES `supplier_tbl` WRITE;
/*!40000 ALTER TABLE `supplier_tbl` DISABLE KEYS */;
INSERT INTO `supplier_tbl` VALUES (1,'GuardTech','Brgy. Sta. Lucia Quezon City','09165934321','Jermiah Flores','\0'),(2,'SMART','Caloocan City','09394217631','Paolo Villamor','\0'),(3,'SONY','Manila, Philippines','09394217631','Paolo Villamor','\0');
/*!40000 ALTER TABLE `supplier_tbl` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `system_settings_tbl`
--

DROP TABLE IF EXISTS `system_settings_tbl`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `system_settings_tbl` (
  `name` varchar(45) NOT NULL,
  `value` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`name`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `system_settings_tbl`
--

LOCK TABLES `system_settings_tbl` WRITE;
/*!40000 ALTER TABLE `system_settings_tbl` DISABLE KEYS */;
INSERT INTO `system_settings_tbl` VALUES ('mode','advance');
/*!40000 ALTER TABLE `system_settings_tbl` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user_tbl`
--

DROP TABLE IF EXISTS `user_tbl`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `user_tbl` (
  `id` varchar(45) NOT NULL,
  `password` longtext,
  `access_level` enum('ADMIN','CASHIER','INVENTORY_PERSONNEL','STAFF') DEFAULT NULL,
  `create_time` datetime DEFAULT NULL,
  `active` bit(1) DEFAULT NULL,
  `session_status` bit(1) DEFAULT b'0',
  `fallbackid` int(11) DEFAULT NULL,
  `fallbackans` text,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user_tbl`
--

LOCK TABLES `user_tbl` WRITE;
/*!40000 ALTER TABLE `user_tbl` DISABLE KEYS */;
INSERT INTO `user_tbl` VALUES ('CJ','1000:0kvsVNGnZ7YHYCyvXMrJClQKCyM3h828:E6n/fB2//+RrY6GzaPn1PxEyMXyKRXfa','ADMIN','2015-09-06 01:36:36','\0','\0',1,'Dog'),('Francis','1000:cXsSfDJE5IpkCpPgsqZLjTAUbSUrwP3z:VdDAcu3dy/POkaLO9lo5S4HK5nvNpdJ7','STAFF','2015-09-13 11:02:09','\0','\0',1,'Dog'),('Jerwin','1000:gBMaS7CPoPuWssMx7Mp62asrgwOA92sS:upbW17soJuVdyFv6uhZC+s9Uif7nE+Gt','INVENTORY_PERSONNEL','2015-09-13 11:24:38','','\0',1,'Dog'),('jessea','1000:IV6vfxHd3+oZOpzhuvQqaWqKFWgnlxF7:QwX+pD/fdR9ceKrThIYMHoeiA3iBTlML','STAFF','2015-10-04 18:05:49','\0','\0',1,'Dog'),('Karen','1000:MC2hqaVscON7bSPVsrdlPXJk1L6crrFD:0WgLdA1IbCGI2Ky0qmfO+8MyYoLDi+PA','CASHIER','2015-09-17 09:40:51','','\0',1,'Dog'),('Rabi','1000:JQ7Krc6eL01CNWzahmeGl3cnE8UgfSDo:IVh/sn6SQvxcwn/qNRbxDMNcVAPobCib','ADMIN','2015-09-13 13:35:25','','\0',2,'Cat'),('Randy','1000:f4SEmab2lco1yQqFfOqN+w4oSy0shM2d:HaURFbRfMKDTUUseYyzvlRdPnuR9gaAa','STAFF','2015-09-13 10:52:08','','\0',1,'Dog'),('saito007','1000:Cnh0F5RmDA94Q05inmY2eW9shFvm64oT:kTntHSf4lWEDHy1zotxffHCh9E9VKgpA','STAFF','2016-01-17 12:04:26','','\0',4,'1000:l4tzx4DJjzVXPv28Sr4TK0Pz9nUjJhjW:ayv0aVBjxoadGKADotDxDHlntDW23Re9');
/*!40000 ALTER TABLE `user_tbl` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary table structure for view `weekly_sales_report`
--

DROP TABLE IF EXISTS `weekly_sales_report`;
/*!50001 DROP VIEW IF EXISTS `weekly_sales_report`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `weekly_sales_report` (
  `Date` tinyint NOT NULL,
  `Week` tinyint NOT NULL,
  `Begin` tinyint NOT NULL,
  `End` tinyint NOT NULL,
  `Sales` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Final view structure for view `audit_trail_view`
--

/*!50001 DROP TABLE IF EXISTS `audit_trail_view`*/;
/*!50001 DROP VIEW IF EXISTS `audit_trail_view`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `audit_trail_view` AS select `audit_trail_tbl`.`date` AS `date`,`audit_trail_tbl`.`time` AS `time`,concat(`employee_tbl`.`firstname`,' ',`employee_tbl`.`middlename`,' ',`employee_tbl`.`lastname`,' ',convert(`audit_trail_tbl`.`activity` using utf8)) AS `activity`,`audit_trail_tbl`.`employee_id` AS `user_id` from ((`audit_trail_tbl` left join `user_tbl` on((convert(`audit_trail_tbl`.`employee_id` using utf8) = `user_tbl`.`id`))) left join `employee_tbl` on((`user_tbl`.`id` = `employee_tbl`.`user_id`))) order by `audit_trail_tbl`.`date`,`audit_trail_tbl`.`date` desc */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `bestsellers`
--

/*!50001 DROP TABLE IF EXISTS `bestsellers`*/;
/*!50001 DROP VIEW IF EXISTS `bestsellers`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`pos_user`@`%` SQL SECURITY DEFINER */
/*!50001 VIEW `bestsellers` AS select `purchased_product_view`.`Name` AS `Name`,`purchased_product_view`.`quantity` AS `Item_Sold`,cast((`purchased_product_view`.`quantity` / (select sum(`purchased_product_view`.`quantity`) from `purchased_product_view`)) as decimal(3,2)) AS `Percent_Share` from `purchased_product_view` order by `purchased_product_view`.`quantity` limit 10 */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `daily_sales_report`
--

/*!50001 DROP TABLE IF EXISTS `daily_sales_report`*/;
/*!50001 DROP VIEW IF EXISTS `daily_sales_report`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`pos_user`@`%` SQL SECURITY DEFINER */
/*!50001 VIEW `daily_sales_report` AS select `invoice_tbl`.`date` AS `Date`,sum(`receipt_tbl`.`net_price`) AS `Sales` from (`receipt_tbl` join `invoice_tbl` on((`receipt_tbl`.`invoice_id` = `invoice_tbl`.`id`))) group by `invoice_tbl`.`date` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `inventory_view`
--

/*!50001 DROP TABLE IF EXISTS `inventory_view`*/;
/*!50001 DROP VIEW IF EXISTS `inventory_view`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`pos_user`@`%` SQL SECURITY DEFINER */
/*!50001 VIEW `inventory_view` AS select `product_tbl`.`name` AS `Name`,`product_tbl`.`description` AS `Description`,`product_tbl`.`id` AS `Barcode`,`product_tbl`.`unit_cost` AS `UnitCost`,`product_tbl`.`unit_price` AS `Unit_price`,`category_tbl`.`name` AS `Category`,`inventory_tbl`.`stockin_datetime` AS `Stock_since`,`supplier_tbl`.`name` AS `Supplier`,sum(`inventory_tbl`.`qty_received`) AS `Qty_Received`,sum(`inventory_tbl`.`qty_onhand`) AS `Qty_On_Hand`,`product_tbl`.`warranty` AS `Warranty`,`product_tbl`.`replacement` AS `Replacement`,`product_tbl`.`serial_code` AS `SerialCode`,`product_tbl`.`unit` AS `Unit`,`product_tbl`.`maintaining_stocks` AS `MaintainingStocks`,`product_tbl`.`archive` AS `Archive` from (((`inventory_tbl` join `product_tbl` on((`inventory_tbl`.`product_id` = `product_tbl`.`id`))) join `category_tbl` on((`product_tbl`.`category_id` = `category_tbl`.`id`))) join `supplier_tbl` on((`product_tbl`.`supplier_id` = `supplier_tbl`.`id`))) group by `inventory_tbl`.`product_id` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `login_trail_view`
--

/*!50001 DROP TABLE IF EXISTS `login_trail_view`*/;
/*!50001 DROP VIEW IF EXISTS `login_trail_view`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`pos_user`@`%` SQL SECURITY DEFINER */
/*!50001 VIEW `login_trail_view` AS select concat(`employee_tbl`.`firstname`,' ',`employee_tbl`.`lastname`) AS `employee_name`,`login_trail_tbl`.`datetime_in` AS `datetime_in`,`login_trail_tbl`.`datetime_out` AS `datetime_out` from ((`login_trail_tbl` left join `user_tbl` on((convert(`login_trail_tbl`.`user_id` using utf8) = `user_tbl`.`id`))) left join `employee_tbl` on((`user_tbl`.`id` = `employee_tbl`.`user_id`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `monthly_sales_report`
--

/*!50001 DROP TABLE IF EXISTS `monthly_sales_report`*/;
/*!50001 DROP VIEW IF EXISTS `monthly_sales_report`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`pos_user`@`%` SQL SECURITY DEFINER */
/*!50001 VIEW `monthly_sales_report` AS select month(`invoice_tbl`.`date`) AS `Month_index`,monthname(`invoice_tbl`.`date`) AS `Month`,sum(`receipt_tbl`.`net_price`) AS `Sales`,year(`invoice_tbl`.`date`) AS `Year` from (`receipt_tbl` join `invoice_tbl` on((`receipt_tbl`.`invoice_id` = `invoice_tbl`.`id`))) group by `Month` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `product_inspection_view`
--

/*!50001 DROP TABLE IF EXISTS `product_inspection_view`*/;
/*!50001 DROP VIEW IF EXISTS `product_inspection_view`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`pos_user`@`%` SQL SECURITY DEFINER */
/*!50001 VIEW `product_inspection_view` AS select `inventory_view`.`Barcode` AS `Item_Code`,`inventory_view`.`Name` AS `Description`,`inventory_view`.`Category` AS `Category`,`inventory_view`.`Unit_price` AS `Unit_Price`,`product_tbl`.`description` AS `Specification`,`product_tbl`.`warranty` AS `Warranty`,`product_tbl`.`replacement` AS `Replacement_Period`,`inventory_view`.`Qty_On_Hand` AS `Quantity_On_Hand` from (`product_tbl` join `inventory_view` on((`product_tbl`.`id` = `inventory_view`.`Barcode`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `product_return_view`
--

/*!50001 DROP TABLE IF EXISTS `product_return_view`*/;
/*!50001 DROP VIEW IF EXISTS `product_return_view`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `product_return_view` AS select `product_return_tbl`.`product_invoice_id` AS `transaction_no`,`product_tbl`.`name` AS `product`,`product_return_tbl`.`qty_returned` AS `qty_returned`,`product_return_tbl`.`date_returned` AS `date_returned`,`supplier_tbl`.`name` AS `supplier`,`product_return_tbl`.`reason` AS `reason` from ((`product_return_tbl` left join `product_tbl` on((`product_return_tbl`.`product_id` = `product_tbl`.`id`))) left join `supplier_tbl` on((`product_tbl`.`supplier_id` = `supplier_tbl`.`id`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `product_transaction_view`
--

/*!50001 DROP TABLE IF EXISTS `product_transaction_view`*/;
/*!50001 DROP VIEW IF EXISTS `product_transaction_view`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `product_transaction_view` AS select `product_invoice_tbl`.`invoice_id` AS `transaction_id`,`product_tbl`.`name` AS `description`,`product_tbl`.`unit_price` AS `unit_price`,`product_invoice_tbl`.`quantity` AS `qty_sold`,`product_invoice_tbl`.`subtotal` AS `grp_price` from (`product_invoice_tbl` join `product_tbl` on((`product_tbl`.`id` = `product_invoice_tbl`.`product_id`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `purchased_product_view`
--

/*!50001 DROP TABLE IF EXISTS `purchased_product_view`*/;
/*!50001 DROP VIEW IF EXISTS `purchased_product_view`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`pos_user`@`%` SQL SECURITY DEFINER */
/*!50001 VIEW `purchased_product_view` AS select `ps`.`name` AS `Name`,`ps`.`id` AS `Barcode`,sum(`pt`.`quantity`) AS `quantity`,`ps`.`unit_price` AS `unit_price`,(sum(`pt`.`quantity`) * `ps`.`unit_price`) AS `Sales`,`ps`.`category_id` AS `category` from (`product_tbl` `ps` join `product_invoice_tbl` `pt` on((`pt`.`product_id` = `ps`.`id`))) group by `ps`.`id` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `sales_today_view`
--

/*!50001 DROP TABLE IF EXISTS `sales_today_view`*/;
/*!50001 DROP VIEW IF EXISTS `sales_today_view`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`pos_user`@`%` SQL SECURITY DEFINER */
/*!50001 VIEW `sales_today_view` AS select `invoice_tbl`.`date` AS `Date`,sum(`receipt_tbl`.`net_price`) AS `Total_Sales` from (`receipt_tbl` join `invoice_tbl` on((`invoice_tbl`.`id` = `receipt_tbl`.`invoice_id`))) where (`invoice_tbl`.`date` = curdate()) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `stock_movement_view`
--

/*!50001 DROP TABLE IF EXISTS `stock_movement_view`*/;
/*!50001 DROP VIEW IF EXISTS `stock_movement_view`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`pos_user`@`%` SQL SECURITY DEFINER */
/*!50001 VIEW `stock_movement_view` AS select sum(`product_invoice_tbl`.`quantity`) AS `sold_items`,`product_invoice_tbl`.`product_id` AS `product_id`,month(`invoice_tbl`.`date`) AS `monthly` from (`product_invoice_tbl` join `invoice_tbl` on((`product_invoice_tbl`.`invoice_id` = `invoice_tbl`.`id`))) where (`product_invoice_tbl`.`consumed` = 1) group by month(`invoice_tbl`.`date`) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `weekly_sales_report`
--

/*!50001 DROP TABLE IF EXISTS `weekly_sales_report`*/;
/*!50001 DROP VIEW IF EXISTS `weekly_sales_report`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`pos_user`@`%` SQL SECURITY DEFINER */
/*!50001 VIEW `weekly_sales_report` AS select `invoice_tbl`.`date` AS `Date`,week(`invoice_tbl`.`date`,0) AS `Week`,min(`invoice_tbl`.`date`) AS `Begin`,max(`invoice_tbl`.`date`) AS `End`,sum(`receipt_tbl`.`net_price`) AS `Sales` from (`receipt_tbl` join `invoice_tbl` on((`receipt_tbl`.`invoice_id` = `invoice_tbl`.`id`))) group by `Week` */;
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

-- Dump completed on 2016-02-21 14:28:10
