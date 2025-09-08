-- MySQL dump 10.13  Distrib 8.0.40, for Win64 (x86_64)
--
-- Host: localhost    Database: busdb
-- ------------------------------------------------------
-- Server version	8.0.40

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
-- Table structure for table `accounts`
--

DROP TABLE IF EXISTS `accounts`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `accounts` (
  `user_id` bigint NOT NULL AUTO_INCREMENT,
  `role_id` bigint NOT NULL,
  `user_name` varchar(50) NOT NULL,
  `password` varchar(100) NOT NULL,
  `is_active` tinyint DEFAULT '1',
  PRIMARY KEY (`user_id`),
  KEY `fk_role_id_idx` (`role_id`),
  CONSTRAINT `fk_role_id` FOREIGN KEY (`role_id`) REFERENCES `roles` (`role_id`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `accounts`
--

LOCK TABLES `accounts` WRITE;
/*!40000 ALTER TABLE `accounts` DISABLE KEYS */;
/*!40000 ALTER TABLE `accounts` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `bus_types`
--

DROP TABLE IF EXISTS `bus_types`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `bus_types` (
  `bus_type_id` bigint NOT NULL AUTO_INCREMENT,
  `class_id` bigint NOT NULL,
  `category_id` bigint NOT NULL,
  `name` varchar(100) NOT NULL,
  `description` text,
  `seat_capacity` int NOT NULL,
  PRIMARY KEY (`bus_type_id`),
  KEY `fk_class_id_idx` (`class_id`),
  KEY `fk_category_id_idx` (`category_id`),
  CONSTRAINT `fk_category_id` FOREIGN KEY (`category_id`) REFERENCES `categories` (`category_id`) ON UPDATE CASCADE,
  CONSTRAINT `fk_class_id` FOREIGN KEY (`class_id`) REFERENCES `classes` (`class_id`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bus_types`
--

LOCK TABLES `bus_types` WRITE;
/*!40000 ALTER TABLE `bus_types` DISABLE KEYS */;
INSERT INTO `bus_types` VALUES (1,1,1,'Regular Mini Bus',NULL,25),(2,2,2,'Deluxe Tour Bus',NULL,45),(3,2,3,'Deluxe Coach',NULL,33),(4,1,3,'Regular Coach',NULL,37),(5,1,2,'Regular Tour Bus',NULL,57);
/*!40000 ALTER TABLE `bus_types` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `buses`
--

DROP TABLE IF EXISTS `buses`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `buses` (
  `bus_id` bigint NOT NULL AUTO_INCREMENT,
  `bus_type_id` bigint NOT NULL,
  `plate_no` varchar(50) DEFAULT NULL,
  `bus_status` enum('AVAILABLE','SCHEDULED','MAINTENANCE') NOT NULL DEFAULT 'AVAILABLE',
  PRIMARY KEY (`bus_id`),
  KEY `fk_bus_type_id_idx` (`bus_type_id`),
  CONSTRAINT `fk_bus_type_id` FOREIGN KEY (`bus_type_id`) REFERENCES `bus_types` (`bus_type_id`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `buses`
--

LOCK TABLES `buses` WRITE;
/*!40000 ALTER TABLE `buses` DISABLE KEYS */;
INSERT INTO `buses` VALUES (1,1,'XYV-234','AVAILABLE'),(2,2,'ABC-456','AVAILABLE'),(3,3,'CDB-678','AVAILABLE'),(4,4,'AWS-890','AVAILABLE'),(5,5,'AWS-897','AVAILABLE');
/*!40000 ALTER TABLE `buses` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `categories`
--

DROP TABLE IF EXISTS `categories`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `categories` (
  `category_id` bigint NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL,
  `description` text,
  PRIMARY KEY (`category_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categories`
--

LOCK TABLES `categories` WRITE;
/*!40000 ALTER TABLE `categories` DISABLE KEYS */;
INSERT INTO `categories` VALUES (1,'Mini','Smaller bus with limited seating'),(2,'Tour','Large bus designed for long-distance or tourist travel'),(3,'Coach','Standard highway bus');
/*!40000 ALTER TABLE `categories` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `classes`
--

DROP TABLE IF EXISTS `classes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `classes` (
  `class_id` bigint NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL,
  `description` text,
  PRIMARY KEY (`class_id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `classes`
--

LOCK TABLES `classes` WRITE;
/*!40000 ALTER TABLE `classes` DISABLE KEYS */;
INSERT INTO `classes` VALUES (1,'Regular','Non-airconditioned with limited comfort.'),(2,'Deluxe','Air-conditioned seating with more comfort.');
/*!40000 ALTER TABLE `classes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `drivers`
--

DROP TABLE IF EXISTS `drivers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `drivers` (
  `driver_id` bigint NOT NULL AUTO_INCREMENT,
  `employee_id` bigint NOT NULL,
  `license_no` varchar(50) NOT NULL,
  `status` enum('AVAILABLE','SCHEDULED','ON BREAK') NOT NULL DEFAULT 'AVAILABLE',
  PRIMARY KEY (`driver_id`),
  UNIQUE KEY `license_no_UNIQUE` (`license_no`),
  KEY `fk_employee_id_idx` (`employee_id`),
  CONSTRAINT `fk_driver_employee_id` FOREIGN KEY (`employee_id`) REFERENCES `employees` (`employee_id`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `drivers`
--

LOCK TABLES `drivers` WRITE;
/*!40000 ALTER TABLE `drivers` DISABLE KEYS */;
INSERT INTO `drivers` VALUES (1,101,'1234','AVAILABLE'),(2,102,'2345','AVAILABLE'),(3,103,'2324','AVAILABLE'),(4,104,'2346','AVAILABLE'),(5,105,'4209','AVAILABLE');
/*!40000 ALTER TABLE `drivers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `employee_accounts`
--

DROP TABLE IF EXISTS `employee_accounts`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `employee_accounts` (
  `emp_account_id` bigint NOT NULL AUTO_INCREMENT,
  `user_id` bigint NOT NULL,
  `employee_id` bigint NOT NULL,
  PRIMARY KEY (`emp_account_id`),
  KEY `fk_user_id_idx` (`user_id`),
  KEY `fk_employee_id_idx` (`employee_id`),
  CONSTRAINT `fk_employee_id` FOREIGN KEY (`employee_id`) REFERENCES `employees` (`employee_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_user_id` FOREIGN KEY (`user_id`) REFERENCES `accounts` (`user_id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employee_accounts`
--

LOCK TABLES `employee_accounts` WRITE;
/*!40000 ALTER TABLE `employee_accounts` DISABLE KEYS */;
/*!40000 ALTER TABLE `employee_accounts` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `employees`
--

DROP TABLE IF EXISTS `employees`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `employees` (
  `employee_id` bigint NOT NULL AUTO_INCREMENT,
  `position` varchar(50) NOT NULL,
  `first_name` varchar(100) NOT NULL,
  `middle_name` varchar(100) DEFAULT NULL,
  `last_name` varchar(100) NOT NULL,
  `contact_no` varchar(20) NOT NULL,
  `email` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`employee_id`)
) ENGINE=InnoDB AUTO_INCREMENT=106 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employees`
--

LOCK TABLES `employees` WRITE;
/*!40000 ALTER TABLE `employees` DISABLE KEYS */;
INSERT INTO `employees` VALUES (101,'Driver','Driver1',NULL,'Driver1','0992372',NULL),(102,'Driver','Driver2',NULL,'Driver2','0957218',NULL),(103,'Driver','Driver3',NULL,'Driver2','0923423',NULL),(104,'Driver','Driver4',NULL,'Driver4','0927238',NULL),(105,'Driver','Driver5',NULL,'Driver5','097283',NULL);
/*!40000 ALTER TABLE `employees` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `fares`
--

DROP TABLE IF EXISTS `fares`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `fares` (
  `fare_id` bigint NOT NULL AUTO_INCREMENT,
  `from_terminal_id` bigint NOT NULL,
  `to_terminal_id` bigint NOT NULL,
  `bus_type_id` bigint NOT NULL,
  `price` decimal(10,2) NOT NULL,
  PRIMARY KEY (`fare_id`),
  UNIQUE KEY `Fares_index_3` (`from_terminal_id`,`to_terminal_id`,`bus_type_id`),
  KEY `fk_from_terminal_id_idx` (`from_terminal_id`),
  KEY `fk_to_terminal_id_idx` (`to_terminal_id`),
  KEY `fk_price_bus_type_id_idx` (`bus_type_id`),
  CONSTRAINT `fk_from_terminal_id` FOREIGN KEY (`from_terminal_id`) REFERENCES `terminals` (`terminal_id`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `fk_price_bus_type_id` FOREIGN KEY (`bus_type_id`) REFERENCES `bus_types` (`bus_type_id`) ON UPDATE CASCADE,
  CONSTRAINT `fk_to_terminal_id` FOREIGN KEY (`to_terminal_id`) REFERENCES `terminals` (`terminal_id`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `fares`
--

LOCK TABLES `fares` WRITE;
/*!40000 ALTER TABLE `fares` DISABLE KEYS */;
/*!40000 ALTER TABLE `fares` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `payments`
--

DROP TABLE IF EXISTS `payments`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `payments` (
  `payment_id` bigint NOT NULL AUTO_INCREMENT,
  `reservation_id` bigint NOT NULL,
  `payment_date` date NOT NULL,
  `amount` decimal(10,2) NOT NULL,
  PRIMARY KEY (`payment_id`),
  KEY `fk_payment_reservation_id_idx` (`reservation_id`),
  CONSTRAINT `fk_payment_reservation_id` FOREIGN KEY (`reservation_id`) REFERENCES `reservations` (`reservation_id`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `payments`
--

LOCK TABLES `payments` WRITE;
/*!40000 ALTER TABLE `payments` DISABLE KEYS */;
/*!40000 ALTER TABLE `payments` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `refunds`
--

DROP TABLE IF EXISTS `refunds`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `refunds` (
  `refund_id` bigint NOT NULL,
  `reservation_id` bigint NOT NULL,
  `remarks` varchar(250) DEFAULT NULL,
  `amount` decimal(10,2) NOT NULL,
  PRIMARY KEY (`refund_id`),
  KEY `fk_refund_reservation_id_idx` (`reservation_id`),
  CONSTRAINT `fk_refund_reservation_id` FOREIGN KEY (`reservation_id`) REFERENCES `reservations` (`reservation_id`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `refunds`
--

LOCK TABLES `refunds` WRITE;
/*!40000 ALTER TABLE `refunds` DISABLE KEYS */;
/*!40000 ALTER TABLE `refunds` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `reservation_passengers`
--

DROP TABLE IF EXISTS `reservation_passengers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `reservation_passengers` (
  `res_passenger_id` bigint NOT NULL AUTO_INCREMENT,
  `reservation_id` bigint NOT NULL,
  `trip_seat_id` bigint NOT NULL,
  `first_name` varchar(100) NOT NULL,
  `last_name` varchar(100) NOT NULL,
  PRIMARY KEY (`res_passenger_id`),
  KEY `fk_reservation_id_idx` (`reservation_id`),
  KEY `fk_trip_seat_id_idx` (`trip_seat_id`),
  CONSTRAINT `fk_reservation_id` FOREIGN KEY (`reservation_id`) REFERENCES `reservations` (`reservation_id`) ON UPDATE CASCADE,
  CONSTRAINT `fk_trip_seat_id` FOREIGN KEY (`trip_seat_id`) REFERENCES `trip_seats` (`trip_seat_id`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reservation_passengers`
--

LOCK TABLES `reservation_passengers` WRITE;
/*!40000 ALTER TABLE `reservation_passengers` DISABLE KEYS */;
/*!40000 ALTER TABLE `reservation_passengers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `reservations`
--

DROP TABLE IF EXISTS `reservations`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `reservations` (
  `reservation_id` bigint NOT NULL AUTO_INCREMENT,
  `contact_name` varchar(200) NOT NULL,
  `contact_email` varchar(150) DEFAULT NULL,
  `contact_phone` varchar(50) NOT NULL,
  `status` enum('PENDING','PAID','CANCELLED','RESCHEDULED') NOT NULL DEFAULT 'PENDING',
  `created_at` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `created_by` varchar(45) NOT NULL,
  `update_at` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`reservation_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reservations`
--

LOCK TABLES `reservations` WRITE;
/*!40000 ALTER TABLE `reservations` DISABLE KEYS */;
/*!40000 ALTER TABLE `reservations` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `roles`
--

DROP TABLE IF EXISTS `roles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `roles` (
  `role_id` bigint NOT NULL AUTO_INCREMENT,
  `role_name` varchar(100) NOT NULL,
  `description` varchar(250) DEFAULT NULL,
  PRIMARY KEY (`role_id`),
  UNIQUE KEY `ix_role_name` (`role_name`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `roles`
--

LOCK TABLES `roles` WRITE;
/*!40000 ALTER TABLE `roles` DISABLE KEYS */;
/*!40000 ALTER TABLE `roles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `route_stops`
--

DROP TABLE IF EXISTS `route_stops`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `route_stops` (
  `route_stop_id` bigint NOT NULL AUTO_INCREMENT,
  `route_id` bigint NOT NULL,
  `terminal_id` bigint NOT NULL,
  `stop_sequence` int NOT NULL,
  `travel_time` int NOT NULL,
  `created_at` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`route_stop_id`),
  UNIQUE KEY `Route_stops_index_1` (`route_id`,`stop_sequence`) /*!80000 INVISIBLE */,
  UNIQUE KEY `Route_stops_index_2` (`route_id`,`terminal_id`),
  KEY `fk_route_id_idx` (`route_id`),
  KEY `fk_terminal_id_idx` (`terminal_id`),
  CONSTRAINT `fk_route_id` FOREIGN KEY (`route_id`) REFERENCES `routes` (`route_id`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `fk_terminal_id` FOREIGN KEY (`terminal_id`) REFERENCES `terminals` (`terminal_id`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `route_stops`
--

LOCK TABLES `route_stops` WRITE;
/*!40000 ALTER TABLE `route_stops` DISABLE KEYS */;
INSERT INTO `route_stops` VALUES (1,101,1,0,0,'2025-09-06 09:07:33'),(2,101,2,1,20,'2025-09-06 09:07:33'),(3,101,3,2,30,'2025-09-06 09:07:33');
/*!40000 ALTER TABLE `route_stops` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `routes`
--

DROP TABLE IF EXISTS `routes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `routes` (
  `route_id` bigint NOT NULL AUTO_INCREMENT,
  `name` varchar(200) NOT NULL,
  `description` text,
  `is_active` tinyint(1) NOT NULL DEFAULT '1',
  `created_at` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `updated_at` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`route_id`)
) ENGINE=InnoDB AUTO_INCREMENT=102 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `routes`
--

LOCK TABLES `routes` WRITE;
/*!40000 ALTER TABLE `routes` DISABLE KEYS */;
INSERT INTO `routes` VALUES (101,'A-B-C','A to C via B',1,'2025-09-06 09:00:11','2025-09-06 09:00:11');
/*!40000 ALTER TABLE `routes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `seats`
--

DROP TABLE IF EXISTS `seats`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `seats` (
  `seat_id` bigint NOT NULL AUTO_INCREMENT,
  `bus_type_id` bigint NOT NULL,
  `seat_no` varchar(5) NOT NULL,
  PRIMARY KEY (`seat_id`),
  UNIQUE KEY `type_seat_uq` (`bus_type_id`,`seat_no`),
  KEY `fk_bus_id_idx` (`bus_type_id`),
  CONSTRAINT `fk_bus_id` FOREIGN KEY (`bus_type_id`) REFERENCES `bus_types` (`bus_type_id`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=198 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `seats`
--

LOCK TABLES `seats` WRITE;
/*!40000 ALTER TABLE `seats` DISABLE KEYS */;
INSERT INTO `seats` VALUES (1,1,'1A'),(5,1,'1B'),(9,1,'1C'),(13,1,'1D'),(17,1,'1E'),(21,1,'1F'),(2,1,'2A'),(6,1,'2B'),(10,1,'2C'),(14,1,'2D'),(18,1,'2E'),(22,1,'2F'),(3,1,'3A'),(7,1,'3B'),(11,1,'3C'),(15,1,'3D'),(19,1,'3E'),(23,1,'3F'),(4,1,'4A'),(8,1,'4B'),(12,1,'4C'),(16,1,'4D'),(20,1,'4E'),(24,1,'4F'),(25,1,'5F'),(26,2,'1A'),(30,2,'1B'),(34,2,'1C'),(38,2,'1D'),(42,2,'1E'),(46,2,'1F'),(50,2,'1G'),(54,2,'1H'),(58,2,'1I'),(62,2,'1J'),(66,2,'1K'),(27,2,'2A'),(31,2,'2B'),(35,2,'2C'),(39,2,'2D'),(43,2,'2E'),(47,2,'2F'),(51,2,'2G'),(55,2,'2H'),(59,2,'2I'),(63,2,'2J'),(67,2,'2K'),(28,2,'3A'),(32,2,'3B'),(36,2,'3C'),(40,2,'3D'),(44,2,'3E'),(48,2,'3F'),(52,2,'3G'),(56,2,'3H'),(60,2,'3I'),(64,2,'3J'),(68,2,'3K'),(29,2,'4A'),(33,2,'4B'),(37,2,'4C'),(41,2,'4D'),(45,2,'4E'),(49,2,'4F'),(53,2,'4G'),(57,2,'4H'),(61,2,'4I'),(65,2,'4J'),(69,2,'4K'),(70,2,'5K'),(71,3,'1A'),(75,3,'1B'),(79,3,'1C'),(83,3,'1D'),(87,3,'1E'),(91,3,'1F'),(95,3,'1G'),(99,3,'1H'),(72,3,'2A'),(76,3,'2B'),(80,3,'2C'),(84,3,'2D'),(88,3,'2E'),(92,3,'2F'),(96,3,'2G'),(100,3,'2H'),(73,3,'3A'),(77,3,'3B'),(81,3,'3C'),(85,3,'3D'),(89,3,'3E'),(93,3,'3F'),(97,3,'3G'),(101,3,'3H'),(74,3,'4A'),(78,3,'4B'),(82,3,'4C'),(86,3,'4D'),(90,3,'4E'),(94,3,'4F'),(98,3,'4G'),(102,3,'4H'),(103,3,'5H'),(104,4,'1A'),(108,4,'1B'),(112,4,'1C'),(116,4,'1D'),(120,4,'1E'),(124,4,'1F'),(128,4,'1G'),(132,4,'1H'),(136,4,'1I'),(105,4,'2A'),(109,4,'2B'),(113,4,'2C'),(117,4,'2D'),(121,4,'2E'),(125,4,'2F'),(129,4,'2G'),(133,4,'2H'),(137,4,'2I'),(106,4,'3A'),(110,4,'3B'),(114,4,'3C'),(118,4,'3D'),(122,4,'3E'),(126,4,'3F'),(130,4,'3G'),(134,4,'3H'),(138,4,'3I'),(107,4,'4A'),(111,4,'4B'),(115,4,'4C'),(119,4,'4D'),(123,4,'4E'),(127,4,'4F'),(131,4,'4G'),(135,4,'4H'),(139,4,'4I'),(140,4,'5I'),(141,5,'1A'),(145,5,'1B'),(149,5,'1C'),(153,5,'1D'),(157,5,'1E'),(161,5,'1F'),(165,5,'1G'),(169,5,'1H'),(173,5,'1I'),(177,5,'1J'),(181,5,'1K'),(185,5,'1L'),(189,5,'1M'),(193,5,'1N'),(142,5,'2A'),(146,5,'2B'),(150,5,'2C'),(154,5,'2D'),(158,5,'2E'),(162,5,'2F'),(166,5,'2G'),(170,5,'2H'),(174,5,'2I'),(178,5,'2J'),(182,5,'2K'),(186,5,'2L'),(190,5,'2M'),(194,5,'2N'),(143,5,'3A'),(147,5,'3B'),(151,5,'3C'),(155,5,'3D'),(159,5,'3E'),(163,5,'3F'),(167,5,'3G'),(171,5,'3H'),(175,5,'3I'),(179,5,'3J'),(183,5,'3K'),(187,5,'3L'),(191,5,'3M'),(195,5,'3N'),(144,5,'4A'),(148,5,'4B'),(152,5,'4C'),(156,5,'4D'),(160,5,'4E'),(164,5,'4F'),(168,5,'4G'),(172,5,'4H'),(176,5,'4I'),(180,5,'4J'),(184,5,'4K'),(188,5,'4L'),(192,5,'4M'),(196,5,'4N'),(197,5,'5N');
/*!40000 ALTER TABLE `seats` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `terminals`
--

DROP TABLE IF EXISTS `terminals`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `terminals` (
  `terminal_id` bigint NOT NULL AUTO_INCREMENT,
  `name` varchar(150) NOT NULL,
  `address` text,
  `city` varchar(100) NOT NULL,
  `province` varchar(100) DEFAULT NULL,
  `created_at` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `updated_at` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`terminal_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `terminals`
--

LOCK TABLES `terminals` WRITE;
/*!40000 ALTER TABLE `terminals` DISABLE KEYS */;
INSERT INTO `terminals` VALUES (1,'A','a,a,a','A','A','2025-09-06 09:01:45','2025-09-06 09:01:45'),(2,'B','b,b,b','B','B','2025-09-06 09:02:22','2025-09-06 09:02:22'),(3,'C','c,c,c','C','C','2025-09-06 09:02:46','2025-09-06 09:02:46');
/*!40000 ALTER TABLE `terminals` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tickets`
--

DROP TABLE IF EXISTS `tickets`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tickets` (
  `ticket_id` bigint NOT NULL,
  `res_passenger_id` bigint NOT NULL,
  `issue_at` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `fare_amount` decimal(10,2) NOT NULL,
  `status` enum('ISSUED','BOARDED','CANCELLED','RESCHEDULED') NOT NULL DEFAULT 'ISSUED',
  `fare_id` bigint DEFAULT NULL,
  PRIMARY KEY (`ticket_id`),
  KEY `fk_res_passenger_id_idx` (`res_passenger_id`),
  KEY `fk_fare_id_idx` (`fare_id`),
  CONSTRAINT `fk_fare_id` FOREIGN KEY (`fare_id`) REFERENCES `fares` (`fare_id`) ON UPDATE CASCADE,
  CONSTRAINT `fk_res_passenger_id` FOREIGN KEY (`res_passenger_id`) REFERENCES `reservation_passengers` (`res_passenger_id`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tickets`
--

LOCK TABLES `tickets` WRITE;
/*!40000 ALTER TABLE `tickets` DISABLE KEYS */;
/*!40000 ALTER TABLE `tickets` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `trip_parts`
--

DROP TABLE IF EXISTS `trip_parts`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `trip_parts` (
  `trip_part_id` bigint NOT NULL AUTO_INCREMENT,
  `trip_id` bigint NOT NULL,
  `from_terminal_id` bigint NOT NULL,
  `to_terminal_id` bigint NOT NULL,
  `sched_departure` time NOT NULL,
  `sched_arrival` time NOT NULL,
  `actual_departure` time DEFAULT NULL,
  `actual_arrival` time DEFAULT NULL,
  PRIMARY KEY (`trip_part_id`),
  UNIQUE KEY `trip_id_terminals_id_iq` (`trip_id`,`from_terminal_id`,`to_terminal_id`),
  KEY `fk_trip_id_idx` (`trip_id`),
  KEY `fk_trip_from_terminal_id_idx` (`from_terminal_id`),
  KEY `fk_trip_to_terminal_id_idx` (`to_terminal_id`),
  CONSTRAINT `fk_trip_from_terminal_id` FOREIGN KEY (`from_terminal_id`) REFERENCES `terminals` (`terminal_id`) ON UPDATE CASCADE,
  CONSTRAINT `fk_trip_id` FOREIGN KEY (`trip_id`) REFERENCES `trips` (`trip_id`) ON UPDATE CASCADE,
  CONSTRAINT `fk_trip_to_terminal_id` FOREIGN KEY (`to_terminal_id`) REFERENCES `terminals` (`terminal_id`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=87 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `trip_parts`
--

LOCK TABLES `trip_parts` WRITE;
/*!40000 ALTER TABLE `trip_parts` DISABLE KEYS */;
INSERT INTO `trip_parts` VALUES (83,1,1,2,'08:15:00','08:35:00',NULL,NULL),(84,1,2,3,'08:50:00','09:20:00',NULL,NULL),(85,2,1,2,'09:15:00','09:35:00',NULL,NULL),(86,2,2,3,'09:50:00','10:20:00',NULL,NULL);
/*!40000 ALTER TABLE `trip_parts` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `trip_seats`
--

DROP TABLE IF EXISTS `trip_seats`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `trip_seats` (
  `trip_seat_id` bigint NOT NULL AUTO_INCREMENT,
  `trip_part_id` bigint NOT NULL,
  `seat_id` bigint NOT NULL,
  `status` enum('AVAILABLE','RESRVED','OCCUPIED') NOT NULL DEFAULT 'AVAILABLE',
  PRIMARY KEY (`trip_seat_id`),
  KEY `fk_trip_part_id_idx` (`trip_part_id`),
  KEY `fk_seat_id_idx` (`seat_id`),
  CONSTRAINT `fk_seat_id` FOREIGN KEY (`seat_id`) REFERENCES `seats` (`seat_id`) ON UPDATE CASCADE,
  CONSTRAINT `fk_trip_part_id` FOREIGN KEY (`trip_part_id`) REFERENCES `trip_parts` (`trip_part_id`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=1232 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `trip_seats`
--

LOCK TABLES `trip_seats` WRITE;
/*!40000 ALTER TABLE `trip_seats` DISABLE KEYS */;
INSERT INTO `trip_seats` VALUES (1068,83,1,'AVAILABLE'),(1069,83,2,'AVAILABLE'),(1070,83,3,'AVAILABLE'),(1071,83,4,'AVAILABLE'),(1072,83,5,'AVAILABLE'),(1073,83,6,'AVAILABLE'),(1074,83,7,'AVAILABLE'),(1075,83,8,'AVAILABLE'),(1076,83,9,'AVAILABLE'),(1077,83,10,'AVAILABLE'),(1078,83,11,'AVAILABLE'),(1079,83,12,'AVAILABLE'),(1080,83,13,'AVAILABLE'),(1081,83,14,'AVAILABLE'),(1082,83,15,'AVAILABLE'),(1083,83,16,'AVAILABLE'),(1084,83,17,'AVAILABLE'),(1085,83,18,'AVAILABLE'),(1086,83,19,'AVAILABLE'),(1087,83,20,'AVAILABLE'),(1088,83,21,'AVAILABLE'),(1089,83,22,'AVAILABLE'),(1090,83,23,'AVAILABLE'),(1091,83,24,'AVAILABLE'),(1092,83,25,'AVAILABLE'),(1099,84,1,'AVAILABLE'),(1100,84,2,'AVAILABLE'),(1101,84,3,'AVAILABLE'),(1102,84,4,'AVAILABLE'),(1103,84,5,'AVAILABLE'),(1104,84,6,'AVAILABLE'),(1105,84,7,'AVAILABLE'),(1106,84,8,'AVAILABLE'),(1107,84,9,'AVAILABLE'),(1108,84,10,'AVAILABLE'),(1109,84,11,'AVAILABLE'),(1110,84,12,'AVAILABLE'),(1111,84,13,'AVAILABLE'),(1112,84,14,'AVAILABLE'),(1113,84,15,'AVAILABLE'),(1114,84,16,'AVAILABLE'),(1115,84,17,'AVAILABLE'),(1116,84,18,'AVAILABLE'),(1117,84,19,'AVAILABLE'),(1118,84,20,'AVAILABLE'),(1119,84,21,'AVAILABLE'),(1120,84,22,'AVAILABLE'),(1121,84,23,'AVAILABLE'),(1122,84,24,'AVAILABLE'),(1123,84,25,'AVAILABLE'),(1124,85,26,'AVAILABLE'),(1125,85,27,'AVAILABLE'),(1126,85,28,'AVAILABLE'),(1127,85,29,'AVAILABLE'),(1128,85,30,'AVAILABLE'),(1129,85,31,'AVAILABLE'),(1130,85,32,'AVAILABLE'),(1131,85,33,'AVAILABLE'),(1132,85,34,'AVAILABLE'),(1133,85,35,'AVAILABLE'),(1134,85,36,'AVAILABLE'),(1135,85,37,'AVAILABLE'),(1136,85,38,'AVAILABLE'),(1137,85,39,'AVAILABLE'),(1138,85,40,'AVAILABLE'),(1139,85,41,'AVAILABLE'),(1140,85,42,'AVAILABLE'),(1141,85,43,'AVAILABLE'),(1142,85,44,'AVAILABLE'),(1143,85,45,'AVAILABLE'),(1144,85,46,'AVAILABLE'),(1145,85,47,'AVAILABLE'),(1146,85,48,'AVAILABLE'),(1147,85,49,'AVAILABLE'),(1148,85,50,'AVAILABLE'),(1149,85,51,'AVAILABLE'),(1150,85,52,'AVAILABLE'),(1151,85,53,'AVAILABLE'),(1152,85,54,'AVAILABLE'),(1153,85,55,'AVAILABLE'),(1154,85,56,'AVAILABLE'),(1155,85,57,'AVAILABLE'),(1156,85,58,'AVAILABLE'),(1157,85,59,'AVAILABLE'),(1158,85,60,'AVAILABLE'),(1159,85,61,'AVAILABLE'),(1160,85,62,'AVAILABLE'),(1161,85,63,'AVAILABLE'),(1162,85,64,'AVAILABLE'),(1163,85,65,'AVAILABLE'),(1164,85,66,'AVAILABLE'),(1165,85,67,'AVAILABLE'),(1166,85,68,'AVAILABLE'),(1167,85,69,'AVAILABLE'),(1168,85,70,'AVAILABLE'),(1187,86,26,'AVAILABLE'),(1188,86,27,'AVAILABLE'),(1189,86,28,'AVAILABLE'),(1190,86,29,'AVAILABLE'),(1191,86,30,'AVAILABLE'),(1192,86,31,'AVAILABLE'),(1193,86,32,'AVAILABLE'),(1194,86,33,'AVAILABLE'),(1195,86,34,'AVAILABLE'),(1196,86,35,'AVAILABLE'),(1197,86,36,'AVAILABLE'),(1198,86,37,'AVAILABLE'),(1199,86,38,'AVAILABLE'),(1200,86,39,'AVAILABLE'),(1201,86,40,'AVAILABLE'),(1202,86,41,'AVAILABLE'),(1203,86,42,'AVAILABLE'),(1204,86,43,'AVAILABLE'),(1205,86,44,'AVAILABLE'),(1206,86,45,'AVAILABLE'),(1207,86,46,'AVAILABLE'),(1208,86,47,'AVAILABLE'),(1209,86,48,'AVAILABLE'),(1210,86,49,'AVAILABLE'),(1211,86,50,'AVAILABLE'),(1212,86,51,'AVAILABLE'),(1213,86,52,'AVAILABLE'),(1214,86,53,'AVAILABLE'),(1215,86,54,'AVAILABLE'),(1216,86,55,'AVAILABLE'),(1217,86,56,'AVAILABLE'),(1218,86,57,'AVAILABLE'),(1219,86,58,'AVAILABLE'),(1220,86,59,'AVAILABLE'),(1221,86,60,'AVAILABLE'),(1222,86,61,'AVAILABLE'),(1223,86,62,'AVAILABLE'),(1224,86,63,'AVAILABLE'),(1225,86,64,'AVAILABLE'),(1226,86,65,'AVAILABLE'),(1227,86,66,'AVAILABLE'),(1228,86,67,'AVAILABLE'),(1229,86,68,'AVAILABLE'),(1230,86,69,'AVAILABLE'),(1231,86,70,'AVAILABLE');
/*!40000 ALTER TABLE `trip_seats` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `trips`
--

DROP TABLE IF EXISTS `trips`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `trips` (
  `trip_id` bigint NOT NULL AUTO_INCREMENT,
  `route_id` bigint NOT NULL,
  `driver_id` bigint NOT NULL,
  `bus_id` bigint NOT NULL,
  `departure_date` date NOT NULL,
  `trip_start_time` time NOT NULL,
  `trip_status` enum('SCHEDULED','ON GOING','COMPLETED','CANCELLED','DELAYED') NOT NULL DEFAULT 'SCHEDULED',
  PRIMARY KEY (`trip_id`),
  KEY `fk_driver_id_idx` (`driver_id`),
  KEY `fk_bus_id_idx` (`bus_id`),
  KEY `fk_trip_route_id_idx` (`route_id`),
  CONSTRAINT `fk_driver_id` FOREIGN KEY (`driver_id`) REFERENCES `drivers` (`driver_id`) ON UPDATE CASCADE,
  CONSTRAINT `fk_trip_bus_id` FOREIGN KEY (`bus_id`) REFERENCES `buses` (`bus_id`) ON UPDATE CASCADE,
  CONSTRAINT `fk_trip_route_id` FOREIGN KEY (`route_id`) REFERENCES `routes` (`route_id`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `trips`
--

LOCK TABLES `trips` WRITE;
/*!40000 ALTER TABLE `trips` DISABLE KEYS */;
INSERT INTO `trips` VALUES (1,101,1,1,'2025-09-28','08:00:00','SCHEDULED'),(2,101,2,2,'2025-09-28','09:00:00','SCHEDULED');
/*!40000 ALTER TABLE `trips` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `trips_AFTER_INSERT` AFTER INSERT ON `trips` FOR EACH ROW BEGIN
	CALL GenerateTripData(NEW.trip_id);
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Dumping events for database 'busdb'
--

--
-- Dumping routines for database 'busdb'
--
/*!50003 DROP PROCEDURE IF EXISTS `GenerateTripData` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GenerateTripData`(IN p_trip_id INT)
BEGIN
    DECLARE v_route_id INT;
    DECLARE v_sched_dep DATETIME;
    DECLARE v_sched_arr DATETIME;
    DECLARE v_bus_type_id INT;

    DECLARE v_from_terminal INT;
    DECLARE v_to_terminal INT;
    DECLARE v_travel_mins INT;

    DECLARE v_trip_part_id INT;
    DECLARE done INT DEFAULT 0;

    DECLARE cur CURSOR FOR
        SELECT rs1.terminal_id AS from_terminal,
               rs2.terminal_id AS to_terminal,
               rs2.travel_time AS travel_mins
        FROM route_stops rs1
        JOIN route_stops rs2 
          ON rs2.stop_sequence = rs1.stop_sequence + 1
         AND rs2.route_id = rs1.route_id
        WHERE rs1.route_id = v_route_id
        ORDER BY rs1.stop_sequence;

    DECLARE CONTINUE HANDLER FOR NOT FOUND SET done = 1;

    SELECT t.route_id, t.trip_start_time, b.bus_type_id
      INTO v_route_id, v_sched_dep, v_bus_type_id
      FROM trips t
      JOIN buses b ON t.bus_id = b.bus_id
     WHERE t.trip_id = p_trip_id;

    SET v_sched_dep = v_sched_dep + INTERVAL 15 MINUTE;

    OPEN cur;
    
    read_loop: LOOP
        FETCH cur INTO v_from_terminal, v_to_terminal, v_travel_mins;
        IF done THEN
            LEAVE read_loop;
        END IF;

        SET v_sched_arr = v_sched_dep + INTERVAL v_travel_mins MINUTE;

        INSERT INTO trip_parts (trip_id, from_terminal_id, to_terminal_id, sched_departure, sched_arrival, actual_departure, actual_arrival)
        VALUES (p_trip_id, v_from_terminal, v_to_terminal, v_sched_dep, v_sched_arr, NULL, NULL);

        SET v_trip_part_id = LAST_INSERT_ID();

        INSERT INTO trip_seats (trip_part_id, seat_id, status)
        SELECT v_trip_part_id, s.seat_id, 'AVAILABLE'
        FROM seats s
        WHERE s.bus_type_id = v_bus_type_id;

        SET v_sched_dep = v_sched_arr + INTERVAL 15 MINUTE;
    END LOOP;

    CLOSE cur;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-09-09  7:19:34
