CREATE DATABASE  IF NOT EXISTS `busticketing` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `busticketing`;
-- MySQL dump 10.13  Distrib 8.0.40, for Win64 (x86_64)
--
-- Host: localhost    Database: busticketing
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
  PRIMARY KEY (`user_id`),
  KEY `fk_role_id_idx` (`role_id`),
  CONSTRAINT `fk_role_id` FOREIGN KEY (`role_id`) REFERENCES `roles` (`role_id`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `accounts`
--

LOCK TABLES `accounts` WRITE;
/*!40000 ALTER TABLE `accounts` DISABLE KEYS */;
INSERT INTO `accounts` VALUES (1,1,'cashier'),(2,2,'admin'),(3,3,'dispatcher');
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
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bus_types`
--

LOCK TABLES `bus_types` WRITE;
/*!40000 ALTER TABLE `bus_types` DISABLE KEYS */;
INSERT INTO `bus_types` VALUES (1,1,1,'Regular Mini Bus',NULL,25),(2,2,2,'Deluxe Tour Bus',NULL,45),(3,2,3,'Deluxe Coach',NULL,33),(4,1,3,'Regular Coach',NULL,37),(5,1,2,'Regular Tour Bus',NULL,57),(6,2,1,'Deluxe Mini Bus',NULL,21);
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
  `bus_status` enum('AVAILABLE','ON TRIP','SCHEDULED','MAINTENANCE') NOT NULL DEFAULT 'AVAILABLE',
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
INSERT INTO `buses` VALUES (1,1,'XYV-234','AVAILABLE'),(2,2,'ABC-456','SCHEDULED'),(3,3,'CDB-678','AVAILABLE'),(4,4,'AWS-890','AVAILABLE'),(5,5,'AWS-897','SCHEDULED');
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
INSERT INTO `drivers` VALUES (1,101,'1234'),(2,102,'2345'),(3,103,'2324'),(4,104,'2346'),(5,105,'4209');
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
  `password` varchar(45) NOT NULL DEFAULT '12345',
  `is_active` tinyint NOT NULL DEFAULT '1',
  PRIMARY KEY (`emp_account_id`),
  KEY `fk_user_id_idx` (`user_id`),
  KEY `fk_employee_id_idx` (`employee_id`),
  CONSTRAINT `fk_employee_id` FOREIGN KEY (`employee_id`) REFERENCES `employees` (`employee_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_user_id` FOREIGN KEY (`user_id`) REFERENCES `accounts` (`user_id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employee_accounts`
--

LOCK TABLES `employee_accounts` WRITE;
/*!40000 ALTER TABLE `employee_accounts` DISABLE KEYS */;
INSERT INTO `employee_accounts` VALUES (1,1,106,'12345',1),(2,2,107,'12345',1),(3,3,108,'12132',1);
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
) ENGINE=InnoDB AUTO_INCREMENT=109 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employees`
--

LOCK TABLES `employees` WRITE;
/*!40000 ALTER TABLE `employees` DISABLE KEYS */;
INSERT INTO `employees` VALUES (101,'Driver','Driver1',NULL,'Driver1','0992372',NULL),(102,'Driver','Driver2',NULL,'Driver2','0957218',NULL),(103,'Driver','Driver3',NULL,'Driver2','0923423',NULL),(104,'Driver','Driver4',NULL,'Driver4','0927238',NULL),(105,'Driver','Driver5',NULL,'Driver5','097283',NULL),(106,'cashier','ertb',NULL,'ergeg','098',NULL),(107,'admin','admin',NULL,'asda','876865',NULL),(108,'dispatcher','sqf',NULL,'qwf','09787',NULL);
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
  `route_id` bigint NOT NULL,
  `class_id` bigint NOT NULL,
  `from_sequence` int NOT NULL,
  `to_sequence` int NOT NULL,
  `amount` decimal(10,2) NOT NULL,
  PRIMARY KEY (`fare_id`),
  KEY `fk_fare_route_id_idx` (`route_id`),
  KEY `fk_fare_class_id_idx` (`class_id`),
  CONSTRAINT `fk_fare_class_id` FOREIGN KEY (`class_id`) REFERENCES `classes` (`class_id`) ON UPDATE CASCADE,
  CONSTRAINT `fk_fare_route_id` FOREIGN KEY (`route_id`) REFERENCES `routes` (`route_id`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `fares`
--

LOCK TABLES `fares` WRITE;
/*!40000 ALTER TABLE `fares` DISABLE KEYS */;
INSERT INTO `fares` VALUES (1,101,1,1,2,57.75),(2,101,2,1,2,98.25),(3,101,1,2,3,65.50),(4,101,2,2,3,105.00),(5,101,1,0,1,49.09),(6,101,2,0,1,88.90);
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
  `full_name` varchar(100) NOT NULL,
  PRIMARY KEY (`res_passenger_id`),
  KEY `fk_reservation_id_idx` (`reservation_id`),
  KEY `fk_trip_seat_id_idx` (`trip_seat_id`),
  CONSTRAINT `fk_reservation_id` FOREIGN KEY (`reservation_id`) REFERENCES `reservations` (`reservation_id`) ON UPDATE CASCADE,
  CONSTRAINT `fk_trip_seat_id` FOREIGN KEY (`trip_seat_id`) REFERENCES `trip_seats` (`trip_seat_id`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=30 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reservation_passengers`
--

LOCK TABLES `reservation_passengers` WRITE;
/*!40000 ALTER TABLE `reservation_passengers` DISABLE KEYS */;
INSERT INTO `reservation_passengers` VALUES (1,3,373,'shdiuafivnj'),(2,3,377,'rhgye'),(3,4,467,'ergerg'),(4,4,468,'wetfgweg'),(5,5,124,'asfcasf'),(6,5,128,'asfasf'),(7,5,132,'aaswffv'),(8,6,384,'savfadsv'),(9,7,182,'dwqd'),(10,7,178,'qwsdqwf'),(11,8,380,'jhbhjb'),(12,8,384,'hbhjb'),(13,9,128,'Rafael'),(14,9,132,'qwfqf'),(15,10,60,'ababa'),(16,10,64,'baba'),(17,11,120,'sdnfjhbasfhijawj'),(18,12,115,'dadsS'),(19,12,116,'UhuhXAS'),(20,13,241,'sakjnfas'),(21,13,242,'ndkjwn'),(22,13,246,'njaknsf'),(23,13,245,'dkjnds'),(24,13,250,'wdjnw'),(25,13,249,'asfowfn'),(26,13,253,'dwfqw'),(27,13,254,'fwqsf'),(28,13,257,'safaf'),(29,13,258,'wasfqw');
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
  `created_by` enum('KIOSK','STAFF') NOT NULL DEFAULT 'KIOSK',
  `update_at` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`reservation_id`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reservations`
--

LOCK TABLES `reservations` WRITE;
/*!40000 ALTER TABLE `reservations` DISABLE KEYS */;
INSERT INTO `reservations` VALUES (1,'raea',NULL,'09353','PENDING','2025-09-13 13:00:03','KIOSK','2025-09-13 13:00:03'),(3,'Kim Jennie','jennierubyjane@gmail.com','09310442399','PENDING','2025-10-25 07:18:17','KIOSK','2025-10-25 07:18:17'),(4,'Kim Jennie','jennierubyjane@gmail.com','09310442399','PENDING','2025-10-25 10:49:18','KIOSK','2025-10-25 10:49:18'),(5,'Kim Jennie','jennierubyjane@gmail.com','09310442399','PENDING','2025-10-25 12:47:07','KIOSK','2025-10-25 12:47:07'),(6,'Kim Jennie','jennierubyjane@gmail.com','09310442399','PENDING','2025-10-25 13:07:46','KIOSK','2025-10-25 13:07:46'),(7,'Kim Jennie','jennierubyjane@gmail.com','09310442399','PENDING','2025-10-25 15:16:01','KIOSK','2025-10-25 15:16:01'),(8,'Kim Jennie','jennierubyjane@gmail.com','09310442399','PENDING','2025-10-25 15:23:16','KIOSK','2025-10-25 15:23:16'),(9,'Kim Jennie','jennierubyjane@gmail.com','09310442399','PENDING','2025-10-25 15:41:58','KIOSK','2025-10-25 15:41:58'),(10,'Kim Jennie','jennierubyjane@gmail.com','09310442399','PENDING','2025-10-26 03:45:00','KIOSK','2025-10-26 03:45:00'),(11,'Kim Jennie','jennierubyjane@gmail.com','09310442399','PENDING','2025-10-27 05:16:19','KIOSK','2025-10-27 05:16:19'),(12,'Kim Jennie','jennierubyjane@gmail.com','09310442399','PENDING','2025-10-27 05:35:52','KIOSK','2025-10-27 05:35:52'),(13,'Kim Jennie','jennierubyjane@gmail.com','09310442399','PENDING','2025-10-27 08:41:09','KIOSK','2025-10-27 08:41:09');
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
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `roles`
--

LOCK TABLES `roles` WRITE;
/*!40000 ALTER TABLE `roles` DISABLE KEYS */;
INSERT INTO `roles` VALUES (1,'cashier','wdwdc'),(2,'admin','asf'),(3,'Dispatcher','dgeg');
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
  `created_at` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`route_stop_id`),
  UNIQUE KEY `Route_stops_index_1` (`route_id`,`stop_sequence`) /*!80000 INVISIBLE */,
  UNIQUE KEY `Route_stops_index_2` (`route_id`,`terminal_id`),
  KEY `fk_route_id_idx` (`route_id`),
  KEY `fk_terminal_id_idx` (`terminal_id`),
  CONSTRAINT `fk_route_id` FOREIGN KEY (`route_id`) REFERENCES `routes` (`route_id`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `fk_terminal_id` FOREIGN KEY (`terminal_id`) REFERENCES `terminals` (`terminal_id`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `route_stops`
--

LOCK TABLES `route_stops` WRITE;
/*!40000 ALTER TABLE `route_stops` DISABLE KEYS */;
INSERT INTO `route_stops` VALUES (1,101,1,0,'2025-09-06 09:07:33'),(2,101,2,1,'2025-09-06 09:07:33'),(3,101,3,2,'2025-09-06 09:07:33'),(4,102,3,0,'2025-09-13 10:18:19'),(5,102,2,1,'2025-09-13 10:18:19'),(6,102,1,2,'2025-09-13 10:18:19');
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
) ENGINE=InnoDB AUTO_INCREMENT=103 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `routes`
--

LOCK TABLES `routes` WRITE;
/*!40000 ALTER TABLE `routes` DISABLE KEYS */;
INSERT INTO `routes` VALUES (101,'A-B-C','A to C via B',1,'2025-09-06 09:00:11','2025-09-06 09:00:11'),(102,'C-B-A','C to A via B',1,'2025-09-11 13:10:24','2025-09-11 13:10:24');
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
  KEY `fk_bus_id_idx` (`bus_type_id`),
  CONSTRAINT `fk_bus_id` FOREIGN KEY (`bus_type_id`) REFERENCES `bus_types` (`bus_type_id`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=198 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `seats`
--

LOCK TABLES `seats` WRITE;
/*!40000 ALTER TABLE `seats` DISABLE KEYS */;
INSERT INTO `seats` VALUES (1,1,'1A'),(2,1,'1B'),(3,1,'1C'),(4,1,'1D'),(5,1,'2A'),(6,1,'2B'),(7,1,'2C'),(8,1,'2D'),(9,1,'3A'),(10,1,'3B'),(11,1,'3C'),(12,1,'3D'),(13,1,'4A'),(14,1,'4B'),(15,1,'4C'),(16,1,'4D'),(17,1,'5A'),(18,1,'5B'),(19,1,'5C'),(20,1,'5D'),(21,1,'6A'),(22,1,'6B'),(23,1,'6C'),(24,1,'6D'),(25,1,'6M'),(26,2,'1A'),(27,2,'1B'),(28,2,'1C'),(29,2,'1D'),(30,2,'2A'),(31,2,'2B'),(32,2,'2C'),(33,2,'2D'),(34,2,'3A'),(35,2,'3B'),(36,2,'3C'),(37,2,'3D'),(38,2,'4A'),(39,2,'4B'),(40,2,'4C'),(41,2,'4D'),(42,2,'5A'),(43,2,'5B'),(44,2,'5C'),(45,2,'5D'),(46,2,'6A'),(47,2,'6B'),(48,2,'6C'),(49,2,'6D'),(50,2,'7A'),(51,2,'7B'),(52,2,'7C'),(53,2,'7D'),(54,2,'8A'),(55,2,'8B'),(56,2,'8C'),(57,2,'8D'),(58,2,'9A'),(59,2,'9B'),(60,2,'9C'),(61,2,'9D'),(62,2,'10A'),(63,2,'10B'),(64,2,'10C'),(65,2,'10D'),(66,2,'11A'),(67,2,'11B'),(68,2,'11C'),(69,2,'11D'),(70,2,'11M'),(71,3,'1A'),(72,3,'1B'),(73,3,'1C'),(74,3,'1D'),(75,3,'2A'),(76,3,'2B'),(77,3,'2C'),(78,3,'2D'),(79,3,'3A'),(80,3,'3B'),(81,3,'3C'),(82,3,'3D'),(83,3,'4A'),(84,3,'4B'),(85,3,'4C'),(86,3,'4D'),(87,3,'5A'),(88,3,'5B'),(89,3,'5C'),(90,3,'5D'),(91,3,'6A'),(92,3,'6B'),(93,3,'6C'),(94,3,'6D'),(95,3,'7A'),(96,3,'7B'),(97,3,'7C'),(98,3,'7D'),(99,3,'8A'),(100,3,'8B'),(101,3,'8C'),(102,3,'8D'),(103,3,'8M'),(104,4,'1A'),(105,4,'1B'),(106,4,'1C'),(107,4,'1D'),(108,4,'2A'),(109,4,'2B'),(110,4,'2C'),(111,4,'2D'),(112,4,'3A'),(113,4,'3B'),(114,4,'3C'),(115,4,'3D'),(116,4,'4A'),(117,4,'4B'),(118,4,'4'),(119,4,'4D'),(120,4,'5A'),(121,4,'5B'),(122,4,'5C'),(123,4,'5D'),(124,4,'6A'),(125,4,'6B'),(126,4,'6C'),(127,4,'6D'),(128,4,'7A'),(129,4,'7B'),(130,4,'7C'),(131,4,'7D'),(132,4,'8A'),(133,4,'8B'),(134,4,'8C'),(135,4,'8D'),(136,4,'9A'),(137,4,'9B'),(138,4,'9C'),(139,4,'9D'),(140,4,'9M'),(141,5,'1A'),(142,5,'1B'),(143,5,'1C'),(144,5,'1D'),(145,5,'2A'),(146,5,'2B'),(147,5,'2C'),(148,5,'2D'),(149,5,'3A'),(150,5,'3B'),(151,5,'3C'),(152,5,'3D'),(153,5,'4A'),(154,5,'4B'),(155,5,'4C'),(156,5,'4D'),(157,5,'5A'),(158,5,'5B'),(159,5,'5C'),(160,5,'5D'),(161,5,'6A'),(162,5,'6B'),(163,5,'6C'),(164,5,'6D'),(165,5,'7A'),(166,5,'7B'),(167,5,'7C'),(168,5,'7D'),(169,5,'8A'),(170,5,'8B'),(171,5,'8C'),(172,5,'8D'),(173,5,'9A'),(174,5,'9B'),(175,5,'9C'),(176,5,'9D'),(177,5,'10A'),(178,5,'10B'),(179,5,'10C'),(180,5,'10D'),(181,5,'11A'),(182,5,'11B'),(183,5,'11C'),(184,5,'11D'),(185,5,'12A'),(186,5,'12B'),(187,5,'12C'),(188,5,'12D'),(189,5,'13A'),(190,5,'13B'),(191,5,'13C'),(192,5,'13D'),(193,5,'14A'),(194,5,'14B'),(195,5,'14C'),(196,5,'14D'),(197,5,'14M');
/*!40000 ALTER TABLE `seats` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `terminal_pairs`
--

DROP TABLE IF EXISTS `terminal_pairs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `terminal_pairs` (
  `from_terminal_id` bigint NOT NULL,
  `to_terminal_id` bigint NOT NULL,
  `travel_time` bigint DEFAULT NULL,
  PRIMARY KEY (`from_terminal_id`,`to_terminal_id`),
  KEY `to_terminal_id` (`to_terminal_id`),
  CONSTRAINT `terminal_pairs_ibfk_1` FOREIGN KEY (`from_terminal_id`) REFERENCES `terminals` (`terminal_id`),
  CONSTRAINT `terminal_pairs_ibfk_2` FOREIGN KEY (`to_terminal_id`) REFERENCES `terminals` (`terminal_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `terminal_pairs`
--

LOCK TABLES `terminal_pairs` WRITE;
/*!40000 ALTER TABLE `terminal_pairs` DISABLE KEYS */;
INSERT INTO `terminal_pairs` VALUES (1,2,20),(1,3,30),(1,4,NULL),(2,1,25),(2,3,30),(2,4,NULL),(3,1,32),(3,2,28),(3,4,NULL),(4,1,NULL),(4,2,NULL),(4,3,NULL);
/*!40000 ALTER TABLE `terminal_pairs` ENABLE KEYS */;
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
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `terminals`
--

LOCK TABLES `terminals` WRITE;
/*!40000 ALTER TABLE `terminals` DISABLE KEYS */;
INSERT INTO `terminals` VALUES (1,'Davao','a,a,a','A','A','2025-09-06 09:01:45','2025-10-08 16:34:07'),(2,'Digos','b,b,b','B','B','2025-09-06 09:02:22','2025-10-08 16:34:07'),(3,'Panabo','c,c,c','C','C','2025-09-06 09:02:46','2025-10-08 16:34:07'),(4,'Tagum','d,d,d','D','D','2025-09-13 05:39:18','2025-10-08 16:34:07');
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
  PRIMARY KEY (`ticket_id`),
  KEY `fk_res_passenger_id_idx` (`res_passenger_id`),
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
) ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `trip_parts`
--

LOCK TABLES `trip_parts` WRITE;
/*!40000 ALTER TABLE `trip_parts` DISABLE KEYS */;
INSERT INTO `trip_parts` VALUES (1,1,1,2,'07:15:00','07:35:00',NULL,NULL),(2,1,2,3,'07:50:00','08:20:00',NULL,NULL),(3,2,1,2,'08:15:00','08:35:00',NULL,NULL),(4,2,2,3,'08:50:00','09:20:00',NULL,NULL),(5,3,1,2,'08:15:00','08:35:00',NULL,NULL),(6,3,2,3,'08:50:00','09:20:00',NULL,NULL),(7,4,1,2,'08:15:00','08:35:00',NULL,NULL),(8,4,2,3,'08:50:00','09:20:00',NULL,NULL),(9,5,1,2,'08:15:00','08:35:00',NULL,NULL),(10,5,2,3,'08:50:00','09:20:00',NULL,NULL),(11,6,1,2,'10:15:00','10:35:00',NULL,NULL),(12,6,1,3,'10:50:00','11:20:00',NULL,NULL),(13,6,2,3,'11:35:00','12:05:00',NULL,NULL),(17,12,1,2,'07:15:00','07:35:00',NULL,NULL),(18,12,1,3,'07:15:00','08:20:00',NULL,NULL),(19,12,2,3,'08:35:00','09:05:00',NULL,NULL),(20,14,1,2,'07:15:00','07:35:00',NULL,NULL),(21,14,1,3,'07:15:00','08:05:00',NULL,NULL),(22,14,2,3,'08:20:00','08:50:00',NULL,NULL),(23,15,1,2,'07:15:00','07:35:00',NULL,NULL),(24,15,1,3,'07:15:00','08:20:00',NULL,NULL),(25,15,2,3,'07:50:00','08:20:00',NULL,NULL);
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
) ENGINE=InnoDB AUTO_INCREMENT=1125 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `trip_seats`
--

LOCK TABLES `trip_seats` WRITE;
/*!40000 ALTER TABLE `trip_seats` DISABLE KEYS */;
INSERT INTO `trip_seats` VALUES (1,1,1,'AVAILABLE'),(2,1,2,'AVAILABLE'),(3,1,3,'AVAILABLE'),(4,1,4,'AVAILABLE'),(5,1,5,'AVAILABLE'),(6,1,6,'AVAILABLE'),(7,1,7,'AVAILABLE'),(8,1,8,'AVAILABLE'),(9,1,9,'AVAILABLE'),(10,1,10,'AVAILABLE'),(11,1,11,'AVAILABLE'),(12,1,12,'AVAILABLE'),(13,1,13,'AVAILABLE'),(14,1,14,'AVAILABLE'),(15,1,15,'AVAILABLE'),(16,1,16,'AVAILABLE'),(17,1,17,'AVAILABLE'),(18,1,18,'AVAILABLE'),(19,1,19,'AVAILABLE'),(20,1,20,'AVAILABLE'),(21,1,21,'AVAILABLE'),(22,1,22,'AVAILABLE'),(23,1,23,'AVAILABLE'),(24,1,24,'AVAILABLE'),(25,1,25,'AVAILABLE'),(32,2,1,'AVAILABLE'),(33,2,2,'AVAILABLE'),(34,2,3,'AVAILABLE'),(35,2,4,'AVAILABLE'),(36,2,5,'AVAILABLE'),(37,2,6,'AVAILABLE'),(38,2,7,'AVAILABLE'),(39,2,8,'AVAILABLE'),(40,2,9,'AVAILABLE'),(41,2,10,'AVAILABLE'),(42,2,11,'AVAILABLE'),(43,2,12,'AVAILABLE'),(44,2,13,'AVAILABLE'),(45,2,14,'AVAILABLE'),(46,2,15,'AVAILABLE'),(47,2,16,'AVAILABLE'),(48,2,17,'AVAILABLE'),(49,2,18,'AVAILABLE'),(50,2,19,'AVAILABLE'),(51,2,20,'AVAILABLE'),(52,2,21,'AVAILABLE'),(53,2,22,'AVAILABLE'),(54,2,23,'AVAILABLE'),(55,2,24,'AVAILABLE'),(56,2,25,'AVAILABLE'),(57,3,1,'AVAILABLE'),(58,3,2,'AVAILABLE'),(59,3,3,'AVAILABLE'),(60,3,4,'AVAILABLE'),(61,3,5,'AVAILABLE'),(62,3,6,'AVAILABLE'),(63,3,7,'AVAILABLE'),(64,3,8,'AVAILABLE'),(65,3,9,'AVAILABLE'),(66,3,10,'AVAILABLE'),(67,3,11,'AVAILABLE'),(68,3,12,'AVAILABLE'),(69,3,13,'AVAILABLE'),(70,3,14,'AVAILABLE'),(71,3,15,'AVAILABLE'),(72,3,16,'AVAILABLE'),(73,3,17,'AVAILABLE'),(74,3,18,'AVAILABLE'),(75,3,19,'AVAILABLE'),(76,3,20,'AVAILABLE'),(77,3,21,'AVAILABLE'),(78,3,22,'AVAILABLE'),(79,3,23,'AVAILABLE'),(80,3,24,'AVAILABLE'),(81,3,25,'AVAILABLE'),(88,4,1,'AVAILABLE'),(89,4,2,'AVAILABLE'),(90,4,3,'AVAILABLE'),(91,4,4,'AVAILABLE'),(92,4,5,'AVAILABLE'),(93,4,6,'AVAILABLE'),(94,4,7,'AVAILABLE'),(95,4,8,'AVAILABLE'),(96,4,9,'AVAILABLE'),(97,4,10,'AVAILABLE'),(98,4,11,'AVAILABLE'),(99,4,12,'AVAILABLE'),(100,4,13,'AVAILABLE'),(101,4,14,'AVAILABLE'),(102,4,15,'AVAILABLE'),(103,4,16,'AVAILABLE'),(104,4,17,'AVAILABLE'),(105,4,18,'AVAILABLE'),(106,4,19,'AVAILABLE'),(107,4,20,'AVAILABLE'),(108,4,21,'AVAILABLE'),(109,4,22,'AVAILABLE'),(110,4,23,'AVAILABLE'),(111,4,24,'AVAILABLE'),(112,4,25,'AVAILABLE'),(113,5,26,'AVAILABLE'),(114,5,27,'AVAILABLE'),(115,5,28,'AVAILABLE'),(116,5,29,'AVAILABLE'),(117,5,30,'AVAILABLE'),(118,5,31,'AVAILABLE'),(119,5,32,'AVAILABLE'),(120,5,33,'AVAILABLE'),(121,5,34,'AVAILABLE'),(122,5,35,'AVAILABLE'),(123,5,36,'AVAILABLE'),(124,5,37,'AVAILABLE'),(125,5,38,'AVAILABLE'),(126,5,39,'AVAILABLE'),(127,5,40,'AVAILABLE'),(128,5,41,'AVAILABLE'),(129,5,42,'AVAILABLE'),(130,5,43,'AVAILABLE'),(131,5,44,'AVAILABLE'),(132,5,45,'AVAILABLE'),(133,5,46,'AVAILABLE'),(134,5,47,'AVAILABLE'),(135,5,48,'AVAILABLE'),(136,5,49,'AVAILABLE'),(137,5,50,'AVAILABLE'),(138,5,51,'AVAILABLE'),(139,5,52,'AVAILABLE'),(140,5,53,'AVAILABLE'),(141,5,54,'AVAILABLE'),(142,5,55,'AVAILABLE'),(143,5,56,'AVAILABLE'),(144,5,57,'AVAILABLE'),(145,5,58,'AVAILABLE'),(146,5,59,'AVAILABLE'),(147,5,60,'AVAILABLE'),(148,5,61,'AVAILABLE'),(149,5,62,'AVAILABLE'),(150,5,63,'AVAILABLE'),(151,5,64,'AVAILABLE'),(152,5,65,'AVAILABLE'),(153,5,66,'AVAILABLE'),(154,5,67,'AVAILABLE'),(155,5,68,'AVAILABLE'),(156,5,69,'AVAILABLE'),(157,5,70,'AVAILABLE'),(176,6,26,'AVAILABLE'),(177,6,27,'AVAILABLE'),(178,6,28,'AVAILABLE'),(179,6,29,'AVAILABLE'),(180,6,30,'AVAILABLE'),(181,6,31,'AVAILABLE'),(182,6,32,'AVAILABLE'),(183,6,33,'AVAILABLE'),(184,6,34,'AVAILABLE'),(185,6,35,'AVAILABLE'),(186,6,36,'AVAILABLE'),(187,6,37,'AVAILABLE'),(188,6,38,'AVAILABLE'),(189,6,39,'AVAILABLE'),(190,6,40,'AVAILABLE'),(191,6,41,'AVAILABLE'),(192,6,42,'AVAILABLE'),(193,6,43,'AVAILABLE'),(194,6,44,'AVAILABLE'),(195,6,45,'AVAILABLE'),(196,6,46,'AVAILABLE'),(197,6,47,'AVAILABLE'),(198,6,48,'AVAILABLE'),(199,6,49,'AVAILABLE'),(200,6,50,'AVAILABLE'),(201,6,51,'AVAILABLE'),(202,6,52,'AVAILABLE'),(203,6,53,'AVAILABLE'),(204,6,54,'AVAILABLE'),(205,6,55,'AVAILABLE'),(206,6,56,'AVAILABLE'),(207,6,57,'AVAILABLE'),(208,6,58,'AVAILABLE'),(209,6,59,'AVAILABLE'),(210,6,60,'AVAILABLE'),(211,6,61,'AVAILABLE'),(212,6,62,'AVAILABLE'),(213,6,63,'AVAILABLE'),(214,6,64,'AVAILABLE'),(215,6,65,'AVAILABLE'),(216,6,66,'AVAILABLE'),(217,6,67,'AVAILABLE'),(218,6,68,'AVAILABLE'),(219,6,69,'AVAILABLE'),(220,6,70,'AVAILABLE'),(239,7,71,'AVAILABLE'),(240,7,72,'AVAILABLE'),(241,7,73,'AVAILABLE'),(242,7,74,'AVAILABLE'),(243,7,75,'AVAILABLE'),(244,7,76,'AVAILABLE'),(245,7,77,'AVAILABLE'),(246,7,78,'AVAILABLE'),(247,7,79,'AVAILABLE'),(248,7,80,'AVAILABLE'),(249,7,81,'AVAILABLE'),(250,7,82,'AVAILABLE'),(251,7,83,'AVAILABLE'),(252,7,84,'AVAILABLE'),(253,7,85,'AVAILABLE'),(254,7,86,'AVAILABLE'),(255,7,87,'AVAILABLE'),(256,7,88,'AVAILABLE'),(257,7,89,'AVAILABLE'),(258,7,90,'AVAILABLE'),(259,7,91,'AVAILABLE'),(260,7,92,'AVAILABLE'),(261,7,93,'AVAILABLE'),(262,7,94,'AVAILABLE'),(263,7,95,'AVAILABLE'),(264,7,96,'AVAILABLE'),(265,7,97,'AVAILABLE'),(266,7,98,'AVAILABLE'),(267,7,99,'AVAILABLE'),(268,7,100,'AVAILABLE'),(269,7,101,'AVAILABLE'),(270,7,102,'AVAILABLE'),(271,7,103,'AVAILABLE'),(302,8,71,'AVAILABLE'),(303,8,72,'AVAILABLE'),(304,8,73,'AVAILABLE'),(305,8,74,'AVAILABLE'),(306,8,75,'AVAILABLE'),(307,8,76,'AVAILABLE'),(308,8,77,'AVAILABLE'),(309,8,78,'AVAILABLE'),(310,8,79,'AVAILABLE'),(311,8,80,'AVAILABLE'),(312,8,81,'AVAILABLE'),(313,8,82,'AVAILABLE'),(314,8,83,'AVAILABLE'),(315,8,84,'AVAILABLE'),(316,8,85,'AVAILABLE'),(317,8,86,'AVAILABLE'),(318,8,87,'AVAILABLE'),(319,8,88,'AVAILABLE'),(320,8,89,'AVAILABLE'),(321,8,90,'AVAILABLE'),(322,8,91,'AVAILABLE'),(323,8,92,'AVAILABLE'),(324,8,93,'AVAILABLE'),(325,8,94,'AVAILABLE'),(326,8,95,'AVAILABLE'),(327,8,96,'AVAILABLE'),(328,8,97,'AVAILABLE'),(329,8,98,'AVAILABLE'),(330,8,99,'AVAILABLE'),(331,8,100,'AVAILABLE'),(332,8,101,'AVAILABLE'),(333,8,102,'AVAILABLE'),(334,8,103,'AVAILABLE'),(365,9,104,'AVAILABLE'),(366,9,105,'AVAILABLE'),(367,9,106,'AVAILABLE'),(368,9,107,'AVAILABLE'),(369,9,108,'AVAILABLE'),(370,9,109,'AVAILABLE'),(371,9,110,'AVAILABLE'),(372,9,111,'AVAILABLE'),(373,9,112,'AVAILABLE'),(374,9,113,'AVAILABLE'),(375,9,114,'AVAILABLE'),(376,9,115,'AVAILABLE'),(377,9,116,'AVAILABLE'),(378,9,117,'AVAILABLE'),(379,9,118,'AVAILABLE'),(380,9,119,'AVAILABLE'),(381,9,120,'AVAILABLE'),(382,9,121,'AVAILABLE'),(383,9,122,'AVAILABLE'),(384,9,123,'AVAILABLE'),(385,9,124,'AVAILABLE'),(386,9,125,'AVAILABLE'),(387,9,126,'AVAILABLE'),(388,9,127,'AVAILABLE'),(389,9,128,'AVAILABLE'),(390,9,129,'AVAILABLE'),(391,9,130,'AVAILABLE'),(392,9,131,'AVAILABLE'),(393,9,132,'AVAILABLE'),(394,9,133,'AVAILABLE'),(395,9,134,'AVAILABLE'),(396,9,135,'AVAILABLE'),(397,9,136,'AVAILABLE'),(398,9,137,'AVAILABLE'),(399,9,138,'AVAILABLE'),(400,9,139,'AVAILABLE'),(401,9,140,'AVAILABLE'),(428,10,104,'AVAILABLE'),(429,10,105,'AVAILABLE'),(430,10,106,'AVAILABLE'),(431,10,107,'AVAILABLE'),(432,10,108,'AVAILABLE'),(433,10,109,'AVAILABLE'),(434,10,110,'AVAILABLE'),(435,10,111,'AVAILABLE'),(436,10,112,'AVAILABLE'),(437,10,113,'AVAILABLE'),(438,10,114,'AVAILABLE'),(439,10,115,'AVAILABLE'),(440,10,116,'AVAILABLE'),(441,10,117,'AVAILABLE'),(442,10,118,'AVAILABLE'),(443,10,119,'AVAILABLE'),(444,10,120,'AVAILABLE'),(445,10,121,'AVAILABLE'),(446,10,122,'AVAILABLE'),(447,10,123,'AVAILABLE'),(448,10,124,'AVAILABLE'),(449,10,125,'AVAILABLE'),(450,10,126,'AVAILABLE'),(451,10,127,'AVAILABLE'),(452,10,128,'AVAILABLE'),(453,10,129,'AVAILABLE'),(454,10,130,'AVAILABLE'),(455,10,131,'AVAILABLE'),(456,10,132,'AVAILABLE'),(457,10,133,'AVAILABLE'),(458,10,134,'AVAILABLE'),(459,10,135,'AVAILABLE'),(460,10,136,'AVAILABLE'),(461,10,137,'AVAILABLE'),(462,10,138,'AVAILABLE'),(463,10,139,'AVAILABLE'),(464,10,140,'AVAILABLE'),(465,11,1,'AVAILABLE'),(466,11,2,'AVAILABLE'),(467,11,3,'AVAILABLE'),(468,11,4,'AVAILABLE'),(469,11,5,'AVAILABLE'),(470,11,6,'AVAILABLE'),(471,11,7,'AVAILABLE'),(472,11,8,'AVAILABLE'),(473,11,9,'AVAILABLE'),(474,11,10,'AVAILABLE'),(475,11,11,'AVAILABLE'),(476,11,12,'AVAILABLE'),(477,11,13,'AVAILABLE'),(478,11,14,'AVAILABLE'),(479,11,15,'AVAILABLE'),(480,11,16,'AVAILABLE'),(481,11,17,'AVAILABLE'),(482,11,18,'AVAILABLE'),(483,11,19,'AVAILABLE'),(484,11,20,'AVAILABLE'),(485,11,21,'AVAILABLE'),(486,11,22,'AVAILABLE'),(487,11,23,'AVAILABLE'),(488,11,24,'AVAILABLE'),(489,11,25,'AVAILABLE'),(496,12,1,'AVAILABLE'),(497,12,2,'AVAILABLE'),(498,12,3,'AVAILABLE'),(499,12,4,'AVAILABLE'),(500,12,5,'AVAILABLE'),(501,12,6,'AVAILABLE'),(502,12,7,'AVAILABLE'),(503,12,8,'AVAILABLE'),(504,12,9,'AVAILABLE'),(505,12,10,'AVAILABLE'),(506,12,11,'AVAILABLE'),(507,12,12,'AVAILABLE'),(508,12,13,'AVAILABLE'),(509,12,14,'AVAILABLE'),(510,12,15,'AVAILABLE'),(511,12,16,'AVAILABLE'),(512,12,17,'AVAILABLE'),(513,12,18,'AVAILABLE'),(514,12,19,'AVAILABLE'),(515,12,20,'AVAILABLE'),(516,12,21,'AVAILABLE'),(517,12,22,'AVAILABLE'),(518,12,23,'AVAILABLE'),(519,12,24,'AVAILABLE'),(520,12,25,'AVAILABLE'),(527,13,1,'AVAILABLE'),(528,13,2,'AVAILABLE'),(529,13,3,'AVAILABLE'),(530,13,4,'AVAILABLE'),(531,13,5,'AVAILABLE'),(532,13,6,'AVAILABLE'),(533,13,7,'AVAILABLE'),(534,13,8,'AVAILABLE'),(535,13,9,'AVAILABLE'),(536,13,10,'AVAILABLE'),(537,13,11,'AVAILABLE'),(538,13,12,'AVAILABLE'),(539,13,13,'AVAILABLE'),(540,13,14,'AVAILABLE'),(541,13,15,'AVAILABLE'),(542,13,16,'AVAILABLE'),(543,13,17,'AVAILABLE'),(544,13,18,'AVAILABLE'),(545,13,19,'AVAILABLE'),(546,13,20,'AVAILABLE'),(547,13,21,'AVAILABLE'),(548,13,22,'AVAILABLE'),(549,13,23,'AVAILABLE'),(550,13,24,'AVAILABLE'),(551,13,25,'AVAILABLE'),(558,17,26,'AVAILABLE'),(559,17,27,'AVAILABLE'),(560,17,28,'AVAILABLE'),(561,17,29,'AVAILABLE'),(562,17,30,'AVAILABLE'),(563,17,31,'AVAILABLE'),(564,17,32,'AVAILABLE'),(565,17,33,'AVAILABLE'),(566,17,34,'AVAILABLE'),(567,17,35,'AVAILABLE'),(568,17,36,'AVAILABLE'),(569,17,37,'AVAILABLE'),(570,17,38,'AVAILABLE'),(571,17,39,'AVAILABLE'),(572,17,40,'AVAILABLE'),(573,17,41,'AVAILABLE'),(574,17,42,'AVAILABLE'),(575,17,43,'AVAILABLE'),(576,17,44,'AVAILABLE'),(577,17,45,'AVAILABLE'),(578,17,46,'AVAILABLE'),(579,17,47,'AVAILABLE'),(580,17,48,'AVAILABLE'),(581,17,49,'AVAILABLE'),(582,17,50,'AVAILABLE'),(583,17,51,'AVAILABLE'),(584,17,52,'AVAILABLE'),(585,17,53,'AVAILABLE'),(586,17,54,'AVAILABLE'),(587,17,55,'AVAILABLE'),(588,17,56,'AVAILABLE'),(589,17,57,'AVAILABLE'),(590,17,58,'AVAILABLE'),(591,17,59,'AVAILABLE'),(592,17,60,'AVAILABLE'),(593,17,61,'AVAILABLE'),(594,17,62,'AVAILABLE'),(595,17,63,'AVAILABLE'),(596,17,64,'AVAILABLE'),(597,17,65,'AVAILABLE'),(598,17,66,'AVAILABLE'),(599,17,67,'AVAILABLE'),(600,17,68,'AVAILABLE'),(601,17,69,'AVAILABLE'),(602,17,70,'AVAILABLE'),(621,18,26,'AVAILABLE'),(622,18,27,'AVAILABLE'),(623,18,28,'AVAILABLE'),(624,18,29,'AVAILABLE'),(625,18,30,'AVAILABLE'),(626,18,31,'AVAILABLE'),(627,18,32,'AVAILABLE'),(628,18,33,'AVAILABLE'),(629,18,34,'AVAILABLE'),(630,18,35,'AVAILABLE'),(631,18,36,'AVAILABLE'),(632,18,37,'AVAILABLE'),(633,18,38,'AVAILABLE'),(634,18,39,'AVAILABLE'),(635,18,40,'AVAILABLE'),(636,18,41,'AVAILABLE'),(637,18,42,'AVAILABLE'),(638,18,43,'AVAILABLE'),(639,18,44,'AVAILABLE'),(640,18,45,'AVAILABLE'),(641,18,46,'AVAILABLE'),(642,18,47,'AVAILABLE'),(643,18,48,'AVAILABLE'),(644,18,49,'AVAILABLE'),(645,18,50,'AVAILABLE'),(646,18,51,'AVAILABLE'),(647,18,52,'AVAILABLE'),(648,18,53,'AVAILABLE'),(649,18,54,'AVAILABLE'),(650,18,55,'AVAILABLE'),(651,18,56,'AVAILABLE'),(652,18,57,'AVAILABLE'),(653,18,58,'AVAILABLE'),(654,18,59,'AVAILABLE'),(655,18,60,'AVAILABLE'),(656,18,61,'AVAILABLE'),(657,18,62,'AVAILABLE'),(658,18,63,'AVAILABLE'),(659,18,64,'AVAILABLE'),(660,18,65,'AVAILABLE'),(661,18,66,'AVAILABLE'),(662,18,67,'AVAILABLE'),(663,18,68,'AVAILABLE'),(664,18,69,'AVAILABLE'),(665,18,70,'AVAILABLE'),(684,19,26,'AVAILABLE'),(685,19,27,'AVAILABLE'),(686,19,28,'AVAILABLE'),(687,19,29,'AVAILABLE'),(688,19,30,'AVAILABLE'),(689,19,31,'AVAILABLE'),(690,19,32,'AVAILABLE'),(691,19,33,'AVAILABLE'),(692,19,34,'AVAILABLE'),(693,19,35,'AVAILABLE'),(694,19,36,'AVAILABLE'),(695,19,37,'AVAILABLE'),(696,19,38,'AVAILABLE'),(697,19,39,'AVAILABLE'),(698,19,40,'AVAILABLE'),(699,19,41,'AVAILABLE'),(700,19,42,'AVAILABLE'),(701,19,43,'AVAILABLE'),(702,19,44,'AVAILABLE'),(703,19,45,'AVAILABLE'),(704,19,46,'AVAILABLE'),(705,19,47,'AVAILABLE'),(706,19,48,'AVAILABLE'),(707,19,49,'AVAILABLE'),(708,19,50,'AVAILABLE'),(709,19,51,'AVAILABLE'),(710,19,52,'AVAILABLE'),(711,19,53,'AVAILABLE'),(712,19,54,'AVAILABLE'),(713,19,55,'AVAILABLE'),(714,19,56,'AVAILABLE'),(715,19,57,'AVAILABLE'),(716,19,58,'AVAILABLE'),(717,19,59,'AVAILABLE'),(718,19,60,'AVAILABLE'),(719,19,61,'AVAILABLE'),(720,19,62,'AVAILABLE'),(721,19,63,'AVAILABLE'),(722,19,64,'AVAILABLE'),(723,19,65,'AVAILABLE'),(724,19,66,'AVAILABLE'),(725,19,67,'AVAILABLE'),(726,19,68,'AVAILABLE'),(727,19,69,'AVAILABLE'),(728,19,70,'AVAILABLE'),(747,20,26,'AVAILABLE'),(748,20,27,'AVAILABLE'),(749,20,28,'AVAILABLE'),(750,20,29,'AVAILABLE'),(751,20,30,'AVAILABLE'),(752,20,31,'AVAILABLE'),(753,20,32,'AVAILABLE'),(754,20,33,'AVAILABLE'),(755,20,34,'AVAILABLE'),(756,20,35,'AVAILABLE'),(757,20,36,'AVAILABLE'),(758,20,37,'AVAILABLE'),(759,20,38,'AVAILABLE'),(760,20,39,'AVAILABLE'),(761,20,40,'AVAILABLE'),(762,20,41,'AVAILABLE'),(763,20,42,'AVAILABLE'),(764,20,43,'AVAILABLE'),(765,20,44,'AVAILABLE'),(766,20,45,'AVAILABLE'),(767,20,46,'AVAILABLE'),(768,20,47,'AVAILABLE'),(769,20,48,'AVAILABLE'),(770,20,49,'AVAILABLE'),(771,20,50,'AVAILABLE'),(772,20,51,'AVAILABLE'),(773,20,52,'AVAILABLE'),(774,20,53,'AVAILABLE'),(775,20,54,'AVAILABLE'),(776,20,55,'AVAILABLE'),(777,20,56,'AVAILABLE'),(778,20,57,'AVAILABLE'),(779,20,58,'AVAILABLE'),(780,20,59,'AVAILABLE'),(781,20,60,'AVAILABLE'),(782,20,61,'AVAILABLE'),(783,20,62,'AVAILABLE'),(784,20,63,'AVAILABLE'),(785,20,64,'AVAILABLE'),(786,20,65,'AVAILABLE'),(787,20,66,'AVAILABLE'),(788,20,67,'AVAILABLE'),(789,20,68,'AVAILABLE'),(790,20,69,'AVAILABLE'),(791,20,70,'AVAILABLE'),(810,21,26,'AVAILABLE'),(811,21,27,'AVAILABLE'),(812,21,28,'AVAILABLE'),(813,21,29,'AVAILABLE'),(814,21,30,'AVAILABLE'),(815,21,31,'AVAILABLE'),(816,21,32,'AVAILABLE'),(817,21,33,'AVAILABLE'),(818,21,34,'AVAILABLE'),(819,21,35,'AVAILABLE'),(820,21,36,'AVAILABLE'),(821,21,37,'AVAILABLE'),(822,21,38,'AVAILABLE'),(823,21,39,'AVAILABLE'),(824,21,40,'AVAILABLE'),(825,21,41,'AVAILABLE'),(826,21,42,'AVAILABLE'),(827,21,43,'AVAILABLE'),(828,21,44,'AVAILABLE'),(829,21,45,'AVAILABLE'),(830,21,46,'AVAILABLE'),(831,21,47,'AVAILABLE'),(832,21,48,'AVAILABLE'),(833,21,49,'AVAILABLE'),(834,21,50,'AVAILABLE'),(835,21,51,'AVAILABLE'),(836,21,52,'AVAILABLE'),(837,21,53,'AVAILABLE'),(838,21,54,'AVAILABLE'),(839,21,55,'AVAILABLE'),(840,21,56,'AVAILABLE'),(841,21,57,'AVAILABLE'),(842,21,58,'AVAILABLE'),(843,21,59,'AVAILABLE'),(844,21,60,'AVAILABLE'),(845,21,61,'AVAILABLE'),(846,21,62,'AVAILABLE'),(847,21,63,'AVAILABLE'),(848,21,64,'AVAILABLE'),(849,21,65,'AVAILABLE'),(850,21,66,'AVAILABLE'),(851,21,67,'AVAILABLE'),(852,21,68,'AVAILABLE'),(853,21,69,'AVAILABLE'),(854,21,70,'AVAILABLE'),(873,22,26,'AVAILABLE'),(874,22,27,'AVAILABLE'),(875,22,28,'AVAILABLE'),(876,22,29,'AVAILABLE'),(877,22,30,'AVAILABLE'),(878,22,31,'AVAILABLE'),(879,22,32,'AVAILABLE'),(880,22,33,'AVAILABLE'),(881,22,34,'AVAILABLE'),(882,22,35,'AVAILABLE'),(883,22,36,'AVAILABLE'),(884,22,37,'AVAILABLE'),(885,22,38,'AVAILABLE'),(886,22,39,'AVAILABLE'),(887,22,40,'AVAILABLE'),(888,22,41,'AVAILABLE'),(889,22,42,'AVAILABLE'),(890,22,43,'AVAILABLE'),(891,22,44,'AVAILABLE'),(892,22,45,'AVAILABLE'),(893,22,46,'AVAILABLE'),(894,22,47,'AVAILABLE'),(895,22,48,'AVAILABLE'),(896,22,49,'AVAILABLE'),(897,22,50,'AVAILABLE'),(898,22,51,'AVAILABLE'),(899,22,52,'AVAILABLE'),(900,22,53,'AVAILABLE'),(901,22,54,'AVAILABLE'),(902,22,55,'AVAILABLE'),(903,22,56,'AVAILABLE'),(904,22,57,'AVAILABLE'),(905,22,58,'AVAILABLE'),(906,22,59,'AVAILABLE'),(907,22,60,'AVAILABLE'),(908,22,61,'AVAILABLE'),(909,22,62,'AVAILABLE'),(910,22,63,'AVAILABLE'),(911,22,64,'AVAILABLE'),(912,22,65,'AVAILABLE'),(913,22,66,'AVAILABLE'),(914,22,67,'AVAILABLE'),(915,22,68,'AVAILABLE'),(916,22,69,'AVAILABLE'),(917,22,70,'AVAILABLE'),(936,23,26,'AVAILABLE'),(937,23,27,'AVAILABLE'),(938,23,28,'AVAILABLE'),(939,23,29,'AVAILABLE'),(940,23,30,'AVAILABLE'),(941,23,31,'AVAILABLE'),(942,23,32,'AVAILABLE'),(943,23,33,'AVAILABLE'),(944,23,34,'AVAILABLE'),(945,23,35,'AVAILABLE'),(946,23,36,'AVAILABLE'),(947,23,37,'AVAILABLE'),(948,23,38,'AVAILABLE'),(949,23,39,'AVAILABLE'),(950,23,40,'AVAILABLE'),(951,23,41,'AVAILABLE'),(952,23,42,'AVAILABLE'),(953,23,43,'AVAILABLE'),(954,23,44,'AVAILABLE'),(955,23,45,'AVAILABLE'),(956,23,46,'AVAILABLE'),(957,23,47,'AVAILABLE'),(958,23,48,'AVAILABLE'),(959,23,49,'AVAILABLE'),(960,23,50,'AVAILABLE'),(961,23,51,'AVAILABLE'),(962,23,52,'AVAILABLE'),(963,23,53,'AVAILABLE'),(964,23,54,'AVAILABLE'),(965,23,55,'AVAILABLE'),(966,23,56,'AVAILABLE'),(967,23,57,'AVAILABLE'),(968,23,58,'AVAILABLE'),(969,23,59,'AVAILABLE'),(970,23,60,'AVAILABLE'),(971,23,61,'AVAILABLE'),(972,23,62,'AVAILABLE'),(973,23,63,'AVAILABLE'),(974,23,64,'AVAILABLE'),(975,23,65,'AVAILABLE'),(976,23,66,'AVAILABLE'),(977,23,67,'AVAILABLE'),(978,23,68,'AVAILABLE'),(979,23,69,'AVAILABLE'),(980,23,70,'AVAILABLE'),(999,24,26,'AVAILABLE'),(1000,24,27,'AVAILABLE'),(1001,24,28,'AVAILABLE'),(1002,24,29,'AVAILABLE'),(1003,24,30,'AVAILABLE'),(1004,24,31,'AVAILABLE'),(1005,24,32,'AVAILABLE'),(1006,24,33,'AVAILABLE'),(1007,24,34,'AVAILABLE'),(1008,24,35,'AVAILABLE'),(1009,24,36,'AVAILABLE'),(1010,24,37,'AVAILABLE'),(1011,24,38,'AVAILABLE'),(1012,24,39,'AVAILABLE'),(1013,24,40,'AVAILABLE'),(1014,24,41,'AVAILABLE'),(1015,24,42,'AVAILABLE'),(1016,24,43,'AVAILABLE'),(1017,24,44,'AVAILABLE'),(1018,24,45,'AVAILABLE'),(1019,24,46,'AVAILABLE'),(1020,24,47,'AVAILABLE'),(1021,24,48,'AVAILABLE'),(1022,24,49,'AVAILABLE'),(1023,24,50,'AVAILABLE'),(1024,24,51,'AVAILABLE'),(1025,24,52,'AVAILABLE'),(1026,24,53,'AVAILABLE'),(1027,24,54,'AVAILABLE'),(1028,24,55,'AVAILABLE'),(1029,24,56,'AVAILABLE'),(1030,24,57,'AVAILABLE'),(1031,24,58,'AVAILABLE'),(1032,24,59,'AVAILABLE'),(1033,24,60,'AVAILABLE'),(1034,24,61,'AVAILABLE'),(1035,24,62,'AVAILABLE'),(1036,24,63,'AVAILABLE'),(1037,24,64,'AVAILABLE'),(1038,24,65,'AVAILABLE'),(1039,24,66,'AVAILABLE'),(1040,24,67,'AVAILABLE'),(1041,24,68,'AVAILABLE'),(1042,24,69,'AVAILABLE'),(1043,24,70,'AVAILABLE'),(1062,25,26,'AVAILABLE'),(1063,25,27,'AVAILABLE'),(1064,25,28,'AVAILABLE'),(1065,25,29,'AVAILABLE'),(1066,25,30,'AVAILABLE'),(1067,25,31,'AVAILABLE'),(1068,25,32,'AVAILABLE'),(1069,25,33,'AVAILABLE'),(1070,25,34,'AVAILABLE'),(1071,25,35,'AVAILABLE'),(1072,25,36,'AVAILABLE'),(1073,25,37,'AVAILABLE'),(1074,25,38,'AVAILABLE'),(1075,25,39,'AVAILABLE'),(1076,25,40,'AVAILABLE'),(1077,25,41,'AVAILABLE'),(1078,25,42,'AVAILABLE'),(1079,25,43,'AVAILABLE'),(1080,25,44,'AVAILABLE'),(1081,25,45,'AVAILABLE'),(1082,25,46,'AVAILABLE'),(1083,25,47,'AVAILABLE'),(1084,25,48,'AVAILABLE'),(1085,25,49,'AVAILABLE'),(1086,25,50,'AVAILABLE'),(1087,25,51,'AVAILABLE'),(1088,25,52,'AVAILABLE'),(1089,25,53,'AVAILABLE'),(1090,25,54,'AVAILABLE'),(1091,25,55,'AVAILABLE'),(1092,25,56,'AVAILABLE'),(1093,25,57,'AVAILABLE'),(1094,25,58,'AVAILABLE'),(1095,25,59,'AVAILABLE'),(1096,25,60,'AVAILABLE'),(1097,25,61,'AVAILABLE'),(1098,25,62,'AVAILABLE'),(1099,25,63,'AVAILABLE'),(1100,25,64,'AVAILABLE'),(1101,25,65,'AVAILABLE'),(1102,25,66,'AVAILABLE'),(1103,25,67,'AVAILABLE'),(1104,25,68,'AVAILABLE'),(1105,25,69,'AVAILABLE'),(1106,25,70,'AVAILABLE');
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
  `trip_date` date NOT NULL,
  `trip_start_time` time NOT NULL,
  `trip_status` enum('SCHEDULED','ON GOING','COMPLETED','CANCELLED','DELAYED') NOT NULL DEFAULT 'SCHEDULED',
  PRIMARY KEY (`trip_id`),
  KEY `fk_driver_id_idx` (`driver_id`),
  KEY `fk_bus_id_idx` (`bus_id`),
  KEY `fk_trip_route_id_idx` (`route_id`),
  CONSTRAINT `fk_driver_id` FOREIGN KEY (`driver_id`) REFERENCES `drivers` (`driver_id`) ON UPDATE CASCADE,
  CONSTRAINT `fk_trip_bus_id` FOREIGN KEY (`bus_id`) REFERENCES `buses` (`bus_id`) ON UPDATE CASCADE,
  CONSTRAINT `fk_trip_route_id` FOREIGN KEY (`route_id`) REFERENCES `routes` (`route_id`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `trips`
--

LOCK TABLES `trips` WRITE;
/*!40000 ALTER TABLE `trips` DISABLE KEYS */;
INSERT INTO `trips` VALUES (1,101,1,1,'2025-09-08','07:00:00','SCHEDULED'),(2,101,1,1,'2025-09-28','08:00:00','SCHEDULED'),(3,101,1,2,'2025-10-21','08:00:00','SCHEDULED'),(4,101,2,3,'2025-10-21','08:00:00','SCHEDULED'),(5,101,3,4,'2025-10-21','08:00:00','SCHEDULED'),(6,101,1,1,'2025-10-30','10:00:00','SCHEDULED'),(7,101,2,2,'2025-11-02','07:00:00','SCHEDULED'),(8,101,2,2,'2025-11-02','07:00:00','SCHEDULED'),(9,101,2,2,'2025-11-02','07:00:00','SCHEDULED'),(10,101,2,2,'2025-11-02','07:00:00','SCHEDULED'),(11,101,2,2,'2025-11-02','07:00:00','SCHEDULED'),(12,101,2,2,'2025-11-02','07:00:00','SCHEDULED'),(13,101,2,2,'2025-12-02','07:00:00','SCHEDULED'),(14,101,2,2,'2025-12-02','07:00:00','SCHEDULED'),(15,101,2,2,'2025-11-30','07:00:00','SCHEDULED');
/*!40000 ALTER TABLE `trips` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'busticketing'
--
/*!50003 DROP PROCEDURE IF EXISTS `CreateTrip` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `CreateTrip`(
    IN p_route_id BIGINT,
    IN p_driver_id BIGINT,
    IN p_bus_id BIGINT,
    IN p_trip_date DATE,
    IN p_start_time TIME
)
BEGIN
    DECLARE v_bus_status VARCHAR(20);
    DECLARE v_driver_conflict_schedules INT;
    DECLARE v_bus_conflict_schedules INT;
    DECLARE v_trip_id BIGINT;
    DECLARE v_new_end TIME;

    SELECT ADDTIME(p_start_time, SEC_TO_TIME(SUM(tp.travel_time) * 60))
		INTO v_new_end
		FROM route_stops rs1
		JOIN route_stops rs2
		  ON rs2.stop_sequence = rs1.stop_sequence + 1
		 AND rs2.route_id = rs1.route_id
		JOIN terminal_pairs tp
		  ON tp.from_terminal_id = rs1.terminal_id
		 AND tp.to_terminal_id   = rs2.terminal_id
	   WHERE rs1.route_id = p_route_id;




    SELECT COUNT(*) 
      INTO v_driver_conflict_schedules
      FROM trips t
      JOIN (
            SELECT trip_id, MIN(sched_departure) AS trip_start, MAX(sched_arrival) AS trip_end
            FROM trip_parts
            GROUP BY trip_id
      ) x ON x.trip_id = t.trip_id
     WHERE t.driver_id = p_driver_id
       AND t.trip_date = p_trip_date
       AND p_start_time < x.trip_end
       AND v_new_end > x.trip_start;

    SELECT COUNT(*) 
      INTO v_bus_conflict_schedules
      FROM trips t
      JOIN (
            SELECT trip_id, MIN(sched_departure) AS trip_start, MAX(sched_arrival) AS trip_end
            FROM trip_parts
            GROUP BY trip_id
      ) x ON x.trip_id = t.trip_id
     WHERE t.bus_id = p_bus_id
       AND t.trip_date = p_trip_date
       AND p_start_time < x.trip_end
       AND v_new_end > x.trip_start;

    SELECT b.bus_status 
      INTO v_bus_status
      FROM buses b
     WHERE bus_id = p_bus_id;

    IF v_bus_status = 'MAINTENANCE' THEN
        SIGNAL SQLSTATE '45000'
            SET MESSAGE_TEXT = 'Error: Bus is under maintenance';
    END IF;

    IF v_driver_conflict_schedules > 0 THEN
        SIGNAL SQLSTATE '45000'
            SET MESSAGE_TEXT = 'Error: Driver has another trip at this time';
    END IF;

    IF v_bus_conflict_schedules > 0 THEN
        SIGNAL SQLSTATE '45000'
            SET MESSAGE_TEXT = 'Error: Bus has another trip at this time';
    END IF;

    INSERT INTO trips (route_id, driver_id, bus_id, trip_date, trip_start_time)
    VALUES (p_route_id, p_driver_id, p_bus_id, p_trip_date, p_start_time);

    SET v_trip_id = LAST_INSERT_ID();

    CALL GenerateTripData(v_trip_id);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GenerateTerminalPairs` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GenerateTerminalPairs`()
BEGIN
    INSERT INTO terminal_pairs (from_terminal_id, to_terminal_id, travel_time)
    SELECT t1.terminal_id, t2.terminal_id, NULL
    FROM terminals t1
    CROSS JOIN terminals t2
    WHERE t1.terminal_id <> t2.terminal_id
      AND NOT EXISTS (
          SELECT 1
          FROM terminal_pairs tp
          WHERE tp.from_terminal_id = t1.terminal_id
            AND tp.to_terminal_id   = t2.terminal_id
      );
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
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
    -- =================== DECLARES (must all be here, before any executable statements) ===================
    DECLARE v_route_id INT;
    DECLARE v_trip_start DATETIME;
    DECLARE v_bus_type_id INT;

    DECLARE v_terminal INT;
    DECLARE v_seq INT;
    DECLARE v_prev_terminal INT;
    DECLARE v_prev_dep DATETIME;
    DECLARE v_prev_arr DATETIME;
    DECLARE v_travel_mins INT;

    DECLARE v_from_terminal INT;
    DECLARE v_to_terminal INT;
    DECLARE v_pair_travel_mins INT;
    DECLARE v_from_seq INT;
    DECLARE v_to_seq INT;
    DECLARE v_sched_dep DATETIME;
    DECLARE v_sched_arr DATETIME;
    DECLARE v_trip_part_id BIGINT;

    DECLARE done INT DEFAULT 0;
    DECLARE v_errmsg VARCHAR(255);

    -- Cursors (declared before handlers)
    -- cursor to walk stops in sequence and compute per-stop times
    DECLARE cur_stops CURSOR FOR
      SELECT rs.terminal_id, rs.stop_sequence
      FROM route_stops rs
      WHERE rs.route_id = (SELECT t.route_id FROM trips t WHERE t.trip_id = p_trip_id)
      ORDER BY rs.stop_sequence;

    -- cursor to iterate all pairs (from->to where to_seq > from_seq) and compute total travel mins via SUM
    DECLARE cur_pairs CURSOR FOR
      SELECT rs1.terminal_id AS from_terminal,
             rs2.terminal_id AS to_terminal,
             (
               SELECT SUM(tp.travel_time)
               FROM route_stops x1
               JOIN route_stops x2
                 ON x2.stop_sequence = x1.stop_sequence + 1
                AND x2.route_id = x1.route_id
               JOIN terminal_pairs tp
                 ON tp.from_terminal_id = x1.terminal_id
                AND tp.to_terminal_id   = x2.terminal_id
               WHERE x1.route_id = rs1.route_id
                 AND x1.stop_sequence >= rs1.stop_sequence
                 AND x2.stop_sequence <= rs2.stop_sequence
             ) AS total_travel_mins
      FROM route_stops rs1
      JOIN route_stops rs2
        ON rs2.stop_sequence > rs1.stop_sequence
       AND rs2.route_id = rs1.route_id
     WHERE rs1.route_id = (SELECT t.route_id FROM trips t WHERE t.trip_id = p_trip_id)
     ORDER BY rs1.stop_sequence, rs2.stop_sequence;

    -- Handlers (after cursors)
    DECLARE CONTINUE HANDLER FOR NOT FOUND SET done = 1;
    DECLARE EXIT HANDLER FOR SQLEXCEPTION
    BEGIN
        ROLLBACK;
        RESIGNAL;
    END;
    -- ========================================================================================================

    START TRANSACTION;

    -- get trip info
    SELECT t.route_id, t.trip_start_time, b.bus_type_id
      INTO v_route_id, v_trip_start, v_bus_type_id
      FROM trips t
      JOIN buses b ON t.bus_id = b.bus_id
     WHERE t.trip_id = p_trip_id;

    IF v_route_id IS NULL THEN
        SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'Trip not found';
    END IF;

    -- prepare temp table to store per-stop computed times
    DROP TEMPORARY TABLE IF EXISTS temp_stop_times;
    CREATE TEMPORARY TABLE temp_stop_times (
      terminal_id INT,
      stop_sequence INT,
      sched_departure DATETIME,
      sched_arrival DATETIME,
      PRIMARY KEY (stop_sequence)
    ) ENGINE=MEMORY;

    -- Compute per-stop departure/arrival by walking the route in order
    SET done = 0;
    OPEN cur_stops;

    -- fetch first stop
    FETCH cur_stops INTO v_terminal, v_seq;
    IF done = 1 THEN
        CLOSE cur_stops;
        ROLLBACK;
        SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'No stops found for route';
    END IF;

    -- first stop: departure = trip_start + 15 minutes
    SET v_prev_dep = v_trip_start + INTERVAL 15 MINUTE;
    SET v_prev_arr = NULL;

    INSERT INTO temp_stop_times (terminal_id, stop_sequence, sched_departure, sched_arrival)
    VALUES (v_terminal, v_seq, v_prev_dep, NULL);

    SET v_prev_terminal = v_terminal;

    SET done = 0;
    read_stops: LOOP
        FETCH cur_stops INTO v_terminal, v_seq;
        IF done THEN
            LEAVE read_stops;
        END IF;

        -- travel time from previous terminal -> current terminal (consecutive)
        SELECT tp.travel_time
          INTO v_travel_mins
          FROM terminal_pairs tp
         WHERE tp.from_terminal_id = v_prev_terminal
           AND tp.to_terminal_id   = v_terminal
         LIMIT 1;

        IF v_travel_mins IS NULL THEN
            CLOSE cur_stops;
            ROLLBACK;
            SET v_errmsg = CONCAT('Missing travel_time for consecutive pair ', v_prev_terminal, ' -> ', v_terminal);
            SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = v_errmsg;
        END IF;

        -- arrival at current terminal = previous departure + travel_mins
        SET v_prev_arr = v_prev_dep + INTERVAL v_travel_mins MINUTE;
        -- departure from current terminal = arrival + 15 minutes (layover)
        SET v_prev_dep = v_prev_arr + INTERVAL 15 MINUTE;

        INSERT INTO temp_stop_times (terminal_id, stop_sequence, sched_departure, sched_arrival)
        VALUES (v_terminal, v_seq, v_prev_dep, v_prev_arr);

        SET v_prev_terminal = v_terminal;
    END LOOP;

    CLOSE cur_stops;

    -- ---------- Insert ALL pairs (non-consecutive & consecutive) by iterating cur_pairs and using temp_stop_times ----------

    SET done = 0;
    OPEN cur_pairs;

    pair_loop: LOOP
        FETCH cur_pairs INTO v_from_terminal, v_to_terminal, v_pair_travel_mins;
        IF done THEN
            LEAVE pair_loop;
        END IF;

        IF v_pair_travel_mins IS NULL THEN
            CLOSE cur_pairs;
            ROLLBACK;
            SET v_errmsg = CONCAT('Missing cumulative travel_time for pair ', v_from_terminal, ' -> ', v_to_terminal);
            SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = v_errmsg;
        END IF;

        -- get stop_sequence for from and to (we will lookup computed times)
        SELECT stop_sequence INTO v_from_seq FROM route_stops
         WHERE route_id = v_route_id AND terminal_id = v_from_terminal LIMIT 1;

        SELECT stop_sequence INTO v_to_seq FROM route_stops
         WHERE route_id = v_route_id AND terminal_id = v_to_terminal LIMIT 1;

        -- fetch stored departure of from-stop and arrival of to-stop from temp_stop_times
        SELECT sched_departure INTO v_sched_dep FROM temp_stop_times WHERE stop_sequence = v_from_seq;
        SELECT sched_arrival   INTO v_sched_arr FROM temp_stop_times WHERE stop_sequence = v_to_seq;

        -- As a safety: if sched_departure/arrival are NULL, fail early
        IF v_sched_dep IS NULL OR v_sched_arr IS NULL THEN
            CLOSE cur_pairs;
            ROLLBACK;
            SET v_errmsg = CONCAT('Missing computed times for stops seq ', v_from_seq, ' or ', v_to_seq);
            SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = v_errmsg;
        END IF;

        -- Insert this pair as a trip_part (departure = from-stop departure, arrival = to-stop arrival)
        INSERT INTO trip_parts (trip_id, from_terminal_id, to_terminal_id, sched_departure, sched_arrival, actual_departure, actual_arrival)
        VALUES (p_trip_id, v_from_terminal, v_to_terminal, v_sched_dep, v_sched_arr, NULL, NULL);

        SET v_trip_part_id = LAST_INSERT_ID();

        -- Insert seats for this trip_part immediately (avoids reopening trip_parts)
        INSERT INTO trip_seats (trip_part_id, seat_id, status)
        SELECT v_trip_part_id, s.seat_id, 'AVAILABLE'
        FROM seats s
        WHERE s.bus_type_id = v_bus_type_id;
    END LOOP;

    CLOSE cur_pairs;

    COMMIT;

    DROP TEMPORARY TABLE IF EXISTS temp_stop_times;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GeneratetripPartsByDateAndOriginDestination` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GeneratetripPartsByDateAndOriginDestination`(
    IN p_date DATE,
    IN p_origin VARCHAR(255),
    IN p_destination VARCHAR(255)
)
BEGIN
    SELECT  
        tp.trip_part_id AS TripPartId, 
        tp.trip_id AS TripId, 
        bt.name AS BusType, 
        r.route_id AS RouteId, 
        t1.name AS Origin,
        t2.name AS Destination,
        tp.sched_departure AS DepartureTime,
        COALESCE((
            SELECT SUM(f2.amount)
            FROM fares f2
            WHERE f2.route_id = r.route_id
              AND f2.class_id = bt.class_id
              AND f2.from_sequence >= rs1.stop_sequence
              AND f2.to_sequence <= rs2.stop_sequence
        ), 0) AS FareAmount,
        t.trip_date AS TripDate,
        tp.sched_arrival AS ArrivalTime,
        COALESCE(tps.travel_time,
            (SELECT SUM(tp2.travel_time)
             FROM route_stops x1
             JOIN route_stops x2
               ON x2.stop_sequence = x1.stop_sequence + 1
              AND x2.route_id = r.route_id
             JOIN terminal_pairs tp2
               ON tp2.from_terminal_id = x1.terminal_id
              AND tp2.to_terminal_id   = x2.terminal_id
             WHERE x1.route_id = r.route_id
               AND x1.stop_sequence >= rs1.stop_sequence
               AND x2.stop_sequence <= rs2.stop_sequence)
        ) AS TravelTime,
        b.plate_no AS PlateNo,
        (
            SELECT COUNT(*) 
            FROM trip_seats tss 	
            WHERE tss.trip_part_id = tp.trip_part_id 
              AND tss.status = 'AVAILABLE'
        ) AS AvailableSeats
    FROM trip_parts tp
    INNER JOIN trips t ON tp.trip_id = t.trip_id
    INNER JOIN routes r ON t.route_id = r.route_id
    INNER JOIN buses b ON t.bus_id = b.bus_id
    INNER JOIN bus_types bt ON b.bus_type_id = bt.bus_type_id
    INNER JOIN terminals t1 ON t1.terminal_id = tp.from_terminal_id
    INNER JOIN terminals t2 ON t2.terminal_id = tp.to_terminal_id
    INNER JOIN route_stops rs1 ON rs1.route_id = r.route_id AND rs1.terminal_id = tp.from_terminal_id
    INNER JOIN route_stops rs2 ON rs2.route_id = r.route_id AND rs2.terminal_id = tp.to_terminal_id
    LEFT JOIN terminal_pairs tps ON tps.from_terminal_id = rs1.terminal_id AND tps.to_terminal_id = rs2.terminal_id
    LEFT JOIN classes c ON bt.class_id = c.class_id 
    WHERE DATE(t.trip_date) = p_date
      AND LOWER(TRIM(t1.name)) = LOWER(TRIM(p_origin))
      AND LOWER(TRIM(t2.name)) = LOWER(TRIM(p_destination));
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetTripPartsByDate` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetTripPartsByDate`(
    IN p_date DATE
)
BEGIN
    SELECT 
        tp.trip_part_id AS TripPartId, 
        tp.trip_id AS TripId, 
        bt.name AS BusType, 
        r.route_id AS RouteId, 
        t1.name AS Origin,
        t2.name AS Destination,
        tp.sched_departure AS DepartureTime,
        f.amount AS FareAmount,
        t.trip_date AS TripDate,
        tp.sched_arrival AS ArrivalTime,
        tps.travel_time AS TravelTime,
        b.plate_no AS PlateNo,
        (
            SELECT COUNT(*) 
            FROM trip_seats tss 
            WHERE tss.trip_part_id = tp.trip_part_id AND tss.status = 'AVAILABLE'
        ) AS AvailableSeats
    FROM trip_parts tp
    INNER JOIN trips t ON tp.trip_id = t.trip_id
    INNER JOIN routes r ON t.route_id = r.route_id
    INNER JOIN buses b ON t.bus_id = b.bus_id
    INNER JOIN bus_types bt ON b.bus_type_id = bt.bus_type_id
    INNER JOIN terminals t1 ON t1.terminal_id = tp.from_terminal_id
    INNER JOIN terminals t2 ON t2.terminal_id = tp.to_terminal_id
    INNER JOIN route_stops rs1 ON rs1.route_id = r.route_id AND rs1.terminal_id = tp.from_terminal_id
    INNER JOIN route_stops rs2 ON rs2.route_id = r.route_id AND rs2.terminal_id = tp.to_terminal_id
    INNER JOIN terminal_pairs tps ON tps.from_terminal_id = rs1.terminal_id AND tps.to_terminal_id = rs2.terminal_id
    LEFT JOIN fares f ON f.route_id = r.route_id AND f.from_sequence = rs1.stop_sequence AND f.to_sequence = rs2.stop_sequence
    INNER JOIN classes c ON f.class_id = c.class_id AND bt.class_id = f.class_id 
    WHERE DATE(t.trip_date) = p_date;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetTripPartsByDateAndOriginDestination` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetTripPartsByDateAndOriginDestination`(
	IN p_date DATE,
    IN p_origin VARCHAR(255),
    IN p_destination VARCHAR(255)
)
BEGIN
	 SELECT 
        tp.trip_part_id AS TripPartId, 
        tp.trip_id AS TripId, 
        bt.name AS BusType, 
        r.route_id AS RouteId, 
        t1.name AS Origin,
        t2.name AS Destination,
        tp.sched_departure AS DepartureTime,
        f.amount AS FareAmount,
        t.trip_date AS TripDate,
        tp.sched_arrival AS ArrivalTime,
        tps.travel_time AS TravelTime,
        b.plate_no AS PlateNo,
        (
            SELECT COUNT(*) 
            FROM trip_seats tss 
            WHERE tss.trip_part_id = tp.trip_part_id AND tss.status = 'AVAILABLE'
        ) AS AvailableSeats
    FROM trip_parts tp
    INNER JOIN trips t ON tp.trip_id = t.trip_id
    INNER JOIN routes r ON t.route_id = r.route_id
    INNER JOIN buses b ON t.bus_id = b.bus_id
    INNER JOIN bus_types bt ON b.bus_type_id = bt.bus_type_id
    INNER JOIN terminals t1 ON t1.terminal_id = tp.from_terminal_id
    INNER JOIN terminals t2 ON t2.terminal_id = tp.to_terminal_id
    INNER JOIN route_stops rs1 ON rs1.route_id = r.route_id AND rs1.terminal_id = tp.from_terminal_id
    INNER JOIN route_stops rs2 ON rs2.route_id = r.route_id AND rs2.terminal_id = tp.to_terminal_id
    INNER JOIN terminal_pairs tps ON tps.from_terminal_id = rs1.terminal_id AND tps.to_terminal_id = rs2.terminal_id
    LEFT JOIN fares f ON f.route_id = r.route_id AND f.from_sequence = rs1.stop_sequence AND f.to_sequence = rs2.stop_sequence
    INNER JOIN classes c ON f.class_id = c.class_id AND bt.class_id = f.class_id 
    WHERE DATE(t.trip_date) = p_date
    AND LOWER(TRIM(t1.name)) = LOWER(TRIM(p_origin))
    AND LOWER(TRIM(t2.name)) = LOWER(TRIM(p_destination));
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetTripPartsByDateOnly` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetTripPartsByDateOnly`(
    IN p_date DATE
)
BEGIN
    SELECT 
        tp.trip_part_id AS TripPartId, 
        tp.trip_id AS TripId, 
        bt.name AS BusType, 
        r.route_id AS RouteId, 
        t1.name AS Origin,
        t2.name AS Destination,
        tp.sched_departure AS DepartureTime,
        f.amount AS FareAmount,
        t.trip_date AS TripDate,
        tp.sched_arrival AS ArrivalTime,
        tps.travel_time AS TravelTime,
        b.plate_no AS PlateNo,
        (
            SELECT COUNT(*) 
            FROM trip_seats tss 
            WHERE tss.trip_part_id = tp.trip_part_id AND tss.status = 'AVAILABLE'
        ) AS AvailableSeats
    FROM trip_parts tp
    INNER JOIN trips t ON tp.trip_id = t.trip_id
    INNER JOIN routes r ON t.route_id = r.route_id
    INNER JOIN buses b ON t.bus_id = b.bus_id
    INNER JOIN bus_types bt ON b.bus_type_id = bt.bus_type_id
    INNER JOIN terminals t1 ON t1.terminal_id = tp.from_terminal_id
    INNER JOIN terminals t2 ON t2.terminal_id = tp.to_terminal_id
    INNER JOIN route_stops rs1 ON rs1.route_id = r.route_id AND rs1.terminal_id = tp.from_terminal_id
    INNER JOIN route_stops rs2 ON rs2.route_id = r.route_id AND rs2.terminal_id = tp.to_terminal_id
    INNER JOIN terminal_pairs tps ON tps.from_terminal_id = rs1.terminal_id AND tps.to_terminal_id = rs2.terminal_id
    LEFT JOIN fares f ON f.route_id = r.route_id AND f.from_sequence = rs1.stop_sequence AND f.to_sequence = rs2.stop_sequence
    INNER JOIN classes c ON f.class_id = c.class_id AND bt.class_id = f.class_id 
    WHERE DATE(t.trip_date) = p_date;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `new_procedure` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `new_procedure`(
	IN p_date DATE,
    IN p_origin VARCHAR(255),
    IN p_destination VARCHAR(255)
)
BEGIN
	 SELECT 
        tp.trip_part_id AS TripPartId, 
        tp.trip_id AS TripId, 
        bt.name AS BusType, 
        r.route_id AS RouteId, 
        t1.name AS Origin,
        t2.name AS Destination,
        tp.sched_departure AS DepartureTime,
        f.amount AS FareAmount,
        t.trip_date AS TripDate,
        tp.sched_arrival AS ArrivalTime,
        tps.travel_time AS TravelTime,
        b.plate_no AS PlateNo,
        (
            SELECT COUNT(*) 
            FROM trip_seats tss 
            WHERE tss.trip_part_id = tp.trip_part_id AND tss.status = 'AVAILABLE'
        ) AS AvailableSeats
    FROM trip_parts tp
    INNER JOIN trips t ON tp.trip_id = t.trip_id
    INNER JOIN routes r ON t.route_id = r.route_id
    INNER JOIN buses b ON t.bus_id = b.bus_id
    INNER JOIN bus_types bt ON b.bus_type_id = bt.bus_type_id
    INNER JOIN terminals t1 ON t1.terminal_id = tp.from_terminal_id
    INNER JOIN terminals t2 ON t2.terminal_id = tp.to_terminal_id
    INNER JOIN route_stops rs1 ON rs1.route_id = r.route_id AND rs1.terminal_id = tp.from_terminal_id
    INNER JOIN route_stops rs2 ON rs2.route_id = r.route_id AND rs2.terminal_id = tp.to_terminal_id
    INNER JOIN terminal_pairs tps ON tps.from_terminal_id = rs1.terminal_id AND tps.to_terminal_id = rs2.terminal_id
    LEFT JOIN fares f ON f.route_id = r.route_id AND f.from_sequence = rs1.stop_sequence AND f.to_sequence = rs2.stop_sequence
    INNER JOIN classes c ON f.class_id = c.class_id AND bt.class_id = f.class_id 
    WHERE DATE(t.trip_date) = p_date
    AND LOWER(TRIM(t1.name)) = LOWER(TRIM(p_origin))
    AND LOWER(TRIM(t2.name)) = LOWER(TRIM(p_destination));
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `ReservationDetails` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `ReservationDetails`(
	OUT p_reservation_id BIGINT,
	IN p_contact_name VARCHAR(200),
    IN p_contact_email VARCHAR(150),
    IN p_contact_phone VARCHAR(50)
)
BEGIN
    
	INSERT INTO Reservations(contact_name, contact_email, contact_phone) 
    VALUES(p_contact_name, p_contact_email, p_contact_phone);
    
    SET p_reservation_id = LAST_INSERT_ID();
    
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `ReservationPassengerDetails` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `ReservationPassengerDetails`(
	IN p_reservation_id BIGINT,
    IN p_trip_seat_id BIGINT,
    IN p_full_name  VARCHAR(100)
)
BEGIN
	INSERT INTO reservation_passengers(reservation_id, trip_seat_id, full_name) 
    VALUES (p_reservation_id, p_trip_seat_id, p_full_name);
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

-- Dump completed on 2025-10-28 23:20:34
