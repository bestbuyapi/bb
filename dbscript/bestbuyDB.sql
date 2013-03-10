CREATE DATABASE  IF NOT EXISTS `bestbuy` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `bestbuy`;
-- MySQL dump 10.13  Distrib 5.5.16, for Win32 (x86)
--
-- Host: localhost    Database: bestbuy
-- ------------------------------------------------------
-- Server version	5.5.8

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
-- Table structure for table `sa_category`
--

DROP TABLE IF EXISTS `sa_category`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `sa_category` (
  `categoryId` int(11) NOT NULL AUTO_INCREMENT,
  `categoryCode` varchar(25) DEFAULT NULL,
  `categoryName` varchar(50) DEFAULT NULL,
  `categoryStatus` char(1) DEFAULT NULL,
  PRIMARY KEY (`categoryId`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sa_category`
--

LOCK TABLES `sa_category` WRITE;
/*!40000 ALTER TABLE `sa_category` DISABLE KEYS */;
INSERT INTO `sa_category` VALUES (1,'FRUIT','Fruits','Y'),(2,'BAKE','Baking','Y'),(3,'SNACK','Snacks','Y'),(4,'SEAS','Seasoning','Y'),(5,'VEGE','Vegetables','Y'),(6,'BKRY','Bakery','Y'),(7,'PNR','Pasta & Rice','Y'),(8,'MEAT','Meat','Y'),(9,'BFAST','Breakfast','Y'),(10,'CNJ','Cans & Jars','Y'),(11,'DAIR','Dairy','Y'),(12,'SEAF','Seafood','Y'),(13,'FZEN','Frozen','Y'),(14,'DRINK','Drinks','Y'),(15,'BABY','Baby','Y'),(16,'PET','Pets','Y'),(17,'CLEAN','Cleaning','Y'),(18,'PAPER','Paper','Y'),(19,'PCARE','Personal Care','Y'),(20,'SAUCE','Sauces, etc.','Y');
/*!40000 ALTER TABLE `sa_category` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sa_item`
--

DROP TABLE IF EXISTS `sa_item`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `sa_item` (
  `itemId` int(11) NOT NULL AUTO_INCREMENT,
  `itemName` varchar(255) DEFAULT NULL,
  `itemDesc` varchar(500) DEFAULT NULL,
  `itemStatus` char(1) DEFAULT NULL,
  `itemImagePath` varchar(500) DEFAULT NULL,
  `categoryCode` varchar(25) DEFAULT NULL,
  `companyCode` varchar(10) DEFAULT NULL,
  `normalPrice` decimal(7,2) DEFAULT NULL,
  `promotionPrice` decimal(7,2) DEFAULT NULL,
  `promotionSeq` int(11) DEFAULT NULL,
  `itemUnit` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`itemId`)
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sa_item`
--

LOCK TABLES `sa_item` WRITE;
/*!40000 ALTER TABLE `sa_item` DISABLE KEYS */;
INSERT INTO `sa_item` VALUES (1,'Fresh Chicken Keel',NULL,'Y',NULL,'MEAT','GIANT',12.99,9.89,1,'kg'),(2,'INDIAN Buffalo','Forequarter Sliced Meat','Y',NULL,'MEAT','NSK',9.99,8.45,1,'pack'),(3,'Bawal Emas (Golden Pomfret)','','Y',NULL,'SEAF','GIANT',18.90,12.90,2,'kg'),(4,'Bawal Hitam (Black Pomfret)','Size: Medium , 200g-300g each','Y',NULL,'SEAF','GIANT',5.20,4.29,3,'each'),(5,'Kembong/Pelaling','','Y',NULL,'SEAF','NSK',6.99,4.85,2,'kg'),(6,'Red Seedless Grapes','','Y',NULL,'FRUIT','GIANT',12.99,9.69,4,'kg'),(7,'Imported Carrot','','Y',NULL,'FRUIT','GIANT',2.28,1.67,5,'kg'),(8,'Honey Murcott Mandarin',NULL,'Y',NULL,'FRUIT','GIANT',7.29,5.45,6,'kg'),(9,'South African Pear',NULL,'Y',NULL,'FRUIT','NSK',8.29,6.85,3,'pack'),(10,'China Sawi Bunga/ Choy Sum/ Zhong Cheng','200gm','Y',NULL,'VEGE','TESCO',2.49,0.99,1,'pack'),(11,'Chicken Thigh',NULL,'Y',NULL,'MEAT','TESCO',7.29,6.29,2,'kg'),(12,'Chicken Boneless Breast With Skin',NULL,'Y',NULL,'MEAT','TESCO',12.99,10.90,3,'kg'),(13,'Mas Banana',NULL,'Y',NULL,'FRUIT','TESCO',4.69,3.49,4,'kg'),(14,'Italy Kiwi','1kg','Y',NULL,'FRUIT','TESCO',10.99,7.99,5,'pack'),(15,'Paperone Copier Paper A4','70gms 500s','Y',NULL,'PAPER','AEON',12.50,6.99,1,'pack'),(16,'Pet Pet Mega Pack','S84/ M80/ L68/ XL56','Y',NULL,'BABY','AEON',41.99,31.90,2,'pack'),(17,'Glo 900ml Assorted',NULL,'Y',NULL,'CLEAN','AEON',5.15,3.69,3,'pack'),(18,'Pet Pet Mega Pack','S84/ M80/ L68/ XL56','Y',NULL,'BABY','TESCO',5.15,3.69,6,'pack');
/*!40000 ALTER TABLE `sa_item` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sa_company`
--

DROP TABLE IF EXISTS `sa_company`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `sa_company` (
  `companyId` int(11) NOT NULL AUTO_INCREMENT,
  `companyCode` varchar(10) DEFAULT NULL,
  `companyName` varchar(50) DEFAULT NULL,
  `companyDesc` varchar(1000) DEFAULT NULL,
  `companyLogoPath` varchar(500) DEFAULT NULL,
  `companyStatus` char(1) DEFAULT NULL,
  PRIMARY KEY (`companyId`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sa_company`
--

LOCK TABLES `sa_company` WRITE;
/*!40000 ALTER TABLE `sa_company` DISABLE KEYS */;
INSERT INTO `sa_company` VALUES (1,'TESCO','Tesco','','images\\logo_tesco.png','Y'),(2,'GIANT','Giant',NULL,'images\\logo_giant.png','Y'),(3,'AEONB','AEON Big',NULL,'images\\logo_aeonbig.png','Y'),(4,'JUSCO','Jusco',NULL,'images\\logo_jusco.png','Y'),(5,'NSK','NSK',NULL,'images\\logo_nsk.png','Y'),(6,'ESAVE','EconSave',NULL,'images\\logo_econsave.png','Y'),(7,'COLD','Cold Storage',NULL,'images\\logo_coldstorage.png','Y');
/*!40000 ALTER TABLE `sa_company` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2013-03-09 20:13:01
