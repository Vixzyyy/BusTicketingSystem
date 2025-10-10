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
-- Dumping events for database 'busdb'
--
/*!50106 SET @save_time_zone= @@TIME_ZONE */ ;
/*!50106 DROP EVENT IF EXISTS `UpdateBusAndDriverStatus` */;
DELIMITER ;;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;;
/*!50003 SET character_set_client  = utf8mb4 */ ;;
/*!50003 SET character_set_results = utf8mb4 */ ;;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;;
/*!50003 SET @saved_time_zone      = @@time_zone */ ;;
/*!50003 SET time_zone             = 'SYSTEM' */ ;;
/*!50106 CREATE*/ /*!50117 DEFINER=`root`@`localhost`*/ /*!50106 EVENT `UpdateBusAndDriverStatus` ON SCHEDULE EVERY 1 MINUTE STARTS '2025-09-11 08:00:11' ON COMPLETION NOT PRESERVE ENABLE DO BEGIN
    
    UPDATE trips t
    JOIN (SELECT trip_id, MAX(actual_arrival) AS last_arrival
          FROM trip_parts
          GROUP BY trip_id) tp ON t.trip_id = tp.trip_id
    JOIN buses b ON t.bus_id = b.bus_id
    JOIN drivers d ON t.driver_id = d.driver_id
    SET b.bus_status = 'ON TRIP',
        d.status = 'ON TRIP'
    WHERE NOW() BETWEEN t.trip_start_time AND tp.last_arrival;

   
    UPDATE trips t
    JOIN (
        SELECT trip_id, MAX(actual_arrival) AS last_arrival
        FROM trip_parts
        GROUP BY trip_id
    ) tp ON t.trip_id = tp.trip_id
    JOIN buses b ON t.bus_id = b.bus_id
    JOIN drivers d ON t.driver_id = d.driver_id
    SET b.bus_status = 'AVAILABLE',
        d.status = 'AVAILABLE'
    WHERE tp.last_arrival < NOW();
END */ ;;
/*!50003 SET time_zone             = @saved_time_zone */ ;;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;;
/*!50003 SET character_set_client  = @saved_cs_client */ ;;
/*!50003 SET character_set_results = @saved_cs_results */ ;;
/*!50003 SET collation_connection  = @saved_col_connection */ ;;
DELIMITER ;
/*!50106 SET TIME_ZONE= @save_time_zone */ ;

--
-- Dumping routines for database 'busdb'
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
			   tp.travel_time AS travel_mins
		FROM route_stops rs1
		JOIN route_stops rs2 
		  ON rs2.stop_sequence = rs1.stop_sequence + 1
		 AND rs2.route_id = rs1.route_id
		JOIN terminal_pairs tp
		  ON tp.from_terminal_id = rs1.terminal_id
		 AND tp.to_terminal_id   = rs2.terminal_id
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

-- Dump completed on 2025-09-26 23:34:13
