-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               8.0.40 - MySQL Community Server - GPL
-- Server OS:                    Win64
-- HeidiSQL Version:             12.8.0.6908
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Dumping database structure for db_project
CREATE DATABASE IF NOT EXISTS `db_project` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `db_project`;

-- Dumping structure for table db_project.login_history
CREATE TABLE IF NOT EXISTS `login_history` (
  `id` int NOT NULL AUTO_INCREMENT,
  `username` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `login_time` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table db_project.login_history: ~0 rows (approximately)

-- Dumping structure for table db_project.userhistory
CREATE TABLE IF NOT EXISTS `userhistory` (
  `id` int NOT NULL AUTO_INCREMENT,
  `username` varchar(255) NOT NULL,
  `status` varchar(50) NOT NULL,
  `timestamp` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `entered_password` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table db_project.userhistory: ~8 rows (approximately)
INSERT INTO `userhistory` (`id`, `username`, `status`, `timestamp`, `entered_password`) VALUES
	(1, 'kenneth', 'Successful', '2025-02-09 08:08:58', NULL),
	(2, 'kenneth', 'Successful', '2025-02-09 15:14:27', NULL),
	(3, 'tester', 'Successful', '2025-02-09 15:22:59', NULL),
	(4, 'kenneth', 'Successful', '2025-02-09 15:44:11', NULL),
	(5, 'kenneth', 'Successful', '2025-02-09 15:48:36', NULL),
	(6, 'kenneth', 'Successful', '2025-02-09 15:52:53', NULL),
	(7, 'kenneth', 'Successful', '2025-02-09 16:00:58', NULL),
	(8, 'jean', 'Successful', '2025-02-09 16:02:22', NULL),
	(9, 'kenneth', 'Successful', '2025-02-09 17:47:53', NULL);

-- Dumping structure for table db_project.users
CREATE TABLE IF NOT EXISTS `users` (
  `id` int NOT NULL AUTO_INCREMENT,
  `username` varchar(50) NOT NULL,
  `password` varchar(255) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `username` (`username`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table db_project.users: ~2 rows (approximately)
INSERT INTO `users` (`id`, `username`, `password`) VALUES
	(1, 'admin', '$2a$11$K1aXxPEoZrjwKcFgYVxlN.Sz5v/93xuU6Og6A6c6jQ0VxrzkuB7nO'),
	(4, 'kenneth', '$2a$11$v5mUa53FmEE6TbfbeLdEFuCUBa0y4GCEQqoU7EQl4Scrf.jbdnSvC'),
	(5, 'paulsanoria', '$2a$11$mxPpT2NT4XI9FzGrfqnJnOtkwzNZ3ZTRi91KNpTrZL.FI5HZ2BaH6'),
	(6, 'jean', '$2a$11$SaWxwYMuKUtmqJTmScBz4uJWBG7lLpApxAPEyfNmRW/wfVXJQ.3zO'),
	(7, 'tester', '$2a$11$nUYESVITD259AI67lWf4EuedWNY6YsBqNVnp97JLx9fP.4g5CC3ZW');

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
