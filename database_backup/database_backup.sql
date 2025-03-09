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

-- Dumping structure for table db_project.orders
CREATE TABLE IF NOT EXISTS `orders` (
  `id` int NOT NULL AUTO_INCREMENT,
  `food_name` varchar(255) NOT NULL,
  `price` decimal(10,2) NOT NULL,
  `quantity` int NOT NULL,
  `total_price` decimal(10,2) NOT NULL,
  `order_date` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table db_project.orders: ~0 rows (approximately)

-- Dumping structure for table db_project.transactions
CREATE TABLE IF NOT EXISTS `transactions` (
  `id` int NOT NULL AUTO_INCREMENT,
  `product_name` varchar(255) DEFAULT NULL,
  `price` decimal(10,2) DEFAULT NULL,
  `quantity` int DEFAULT NULL,
  `total_amount` decimal(10,2) DEFAULT NULL,
  `transaction_date` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `payment` decimal(10,2) DEFAULT NULL,
  `change_amount` decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table db_project.transactions: ~6 rows (approximately)
INSERT INTO `transactions` (`id`, `product_name`, `price`, `quantity`, `total_amount`, `transaction_date`, `payment`, `change_amount`) VALUES
	(1, 'Adeptus\' Temptation', 1000.00, 1, 1000.00, '2025-03-07 06:17:46', NULL, NULL),
	(2, 'Adeptus\' Temptation', 1000.00, 1, 1000.00, '2025-03-07 06:17:52', NULL, NULL),
	(3, 'Jade Parcels', 750.00, 1, 750.00, '2025-03-07 06:18:04', NULL, NULL),
	(4, 'Sweet Madame', 600.00, 1, 600.00, '2025-03-07 06:18:06', NULL, NULL),
	(5, 'Adeptus\' Temptation', 1000.00, 1, 1000.00, '2025-03-07 06:26:12', 3000.00, 2000.00),
	(6, 'Golden Crab', 900.00, 1, 900.00, '2025-03-07 06:26:23', 2999.00, 2099.00);

-- Dumping structure for table db_project.userhistory
CREATE TABLE IF NOT EXISTS `userhistory` (
  `id` int NOT NULL AUTO_INCREMENT,
  `username` varchar(255) NOT NULL,
  `status` varchar(50) NOT NULL,
  `timestamp` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `entered_password` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=66 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table db_project.userhistory: ~65 rows (approximately)
INSERT INTO `userhistory` (`id`, `username`, `status`, `timestamp`, `entered_password`) VALUES
	(1, 'kenneth', 'Successful', '2025-02-09 08:08:58', NULL),
	(2, 'kenneth', 'Successful', '2025-02-09 15:14:27', NULL),
	(3, 'tester', 'Successful', '2025-02-09 15:22:59', NULL),
	(4, 'kenneth', 'Successful', '2025-02-09 15:44:11', NULL),
	(5, 'kenneth', 'Successful', '2025-02-09 15:48:36', NULL),
	(6, 'kenneth', 'Successful', '2025-02-09 15:52:53', NULL),
	(7, 'kenneth', 'Successful', '2025-02-09 16:00:58', NULL),
	(8, 'jean', 'Successful', '2025-02-09 16:02:22', NULL),
	(9, 'kenneth', 'Successful', '2025-02-09 17:47:53', NULL),
	(10, 'kenneth', 'Successful', '2025-02-09 17:56:44', NULL),
	(11, 'kenneth', 'Successful', '2025-02-09 17:57:42', NULL),
	(12, 'kenneth', 'Successful', '2025-02-09 17:58:38', NULL),
	(13, 'jean', 'Successful', '2025-02-09 17:58:54', NULL),
	(14, 'kenneth', 'Failed', '2025-03-04 14:29:31', NULL),
	(15, 'kenneth', 'Failed', '2025-03-04 14:29:33', NULL),
	(16, 'kenneth', 'Failed', '2025-03-04 14:29:41', NULL),
	(17, 'kenneth', 'Failed', '2025-03-04 14:29:50', NULL),
	(18, 'kenneth', 'Failed', '2025-03-04 14:30:42', NULL),
	(19, 'kenneth', 'Failed', '2025-03-04 14:30:57', NULL),
	(20, 'kenneth', 'Failed', '2025-03-04 14:30:59', NULL),
	(21, 'paulsanoria', 'Successful', '2025-03-04 14:32:08', NULL),
	(22, 'paulsanoria', 'Successful', '2025-03-05 02:30:28', NULL),
	(23, 'paulsanoria', 'Successful', '2025-03-05 02:32:48', NULL),
	(24, 'paulsanoria', 'Successful', '2025-03-05 02:43:35', NULL),
	(25, 'paulsanoria', 'Successful', '2025-03-05 02:45:42', NULL),
	(26, 'paulsanoria', 'Successful', '2025-03-05 03:06:53', NULL),
	(27, 'paulsanoria', 'Successful', '2025-03-05 03:08:18', NULL),
	(28, 'paulsanoria', 'Successful', '2025-03-05 04:04:59', NULL),
	(29, 'paulsanoria', 'Successful', '2025-03-05 04:14:46', NULL),
	(30, 'paulsanoria', 'Successful', '2025-03-05 04:56:47', NULL),
	(31, 'paulsanoria', 'Successful', '2025-03-05 05:26:10', NULL),
	(32, 'paulsanoria', 'Successful', '2025-03-05 05:29:26', NULL),
	(33, 'paulsanoria', 'Successful', '2025-03-05 07:42:01', NULL),
	(34, 'paulsanoria', 'Successful', '2025-03-05 07:42:43', NULL),
	(35, 'paulsanoria', 'Successful', '2025-03-05 07:43:32', NULL),
	(36, 'paulsanoria', 'Successful', '2025-03-05 07:44:00', NULL),
	(37, 'paulsanoria', 'Successful', '2025-03-05 07:45:16', NULL),
	(38, 'paulsanoria', 'Successful', '2025-03-07 01:13:21', NULL),
	(39, 'paulsanoria', 'Successful', '2025-03-07 01:14:58', NULL),
	(40, 'paulsanoria', 'Successful', '2025-03-07 01:15:52', NULL),
	(41, 'paulsanoria', 'Successful', '2025-03-07 01:30:48', NULL),
	(42, 'paulsanoria', 'Successful', '2025-03-07 01:34:35', NULL),
	(43, 'paulsanoria', 'Successful', '2025-03-07 03:39:49', NULL),
	(44, 'paulsanoria', 'Successful', '2025-03-07 03:41:44', NULL),
	(45, 'paulsanoria', 'Successful', '2025-03-07 03:42:17', NULL),
	(46, 'paulsanoria', 'Successful', '2025-03-07 04:35:00', NULL),
	(47, 'paulsanoria', 'Successful', '2025-03-07 04:35:47', NULL),
	(48, 'paulsanoria', 'Successful', '2025-03-07 05:13:40', NULL),
	(49, 'paulsanoria', 'Successful', '2025-03-07 06:11:11', NULL),
	(50, 'paulsanoria', 'Successful', '2025-03-07 06:13:34', NULL),
	(51, 'paulsanoria', 'Successful', '2025-03-07 06:14:44', NULL),
	(52, 'paulsanoria', 'Successful', '2025-03-07 06:16:34', NULL),
	(53, 'paulsanoria', 'Successful', '2025-03-07 06:17:44', NULL),
	(54, 'paulsanoria', 'Successful', '2025-03-07 06:24:50', NULL),
	(55, 'paulsanoria', 'Successful', '2025-03-07 06:26:06', NULL),
	(56, 'paulsanoria', 'Successful', '2025-03-07 06:52:26', NULL),
	(57, 'paulsanoria', 'Successful', '2025-03-07 06:54:15', NULL),
	(58, 'paulsanoria', 'Successful', '2025-03-07 06:58:13', NULL),
	(59, 'paulsanoria', 'Successful', '2025-03-07 07:00:25', NULL),
	(60, 'paulsanoria', 'Successful', '2025-03-07 07:05:58', NULL),
	(61, 'paulsanoria', 'Successful', '2025-03-07 07:08:02', NULL),
	(62, 'paulsanoria', 'Successful', '2025-03-07 07:09:53', NULL),
	(63, 'paulsanoria', 'Successful', '2025-03-07 07:13:07', NULL),
	(64, 'paulsanoria', 'Failed', '2025-03-08 10:24:19', NULL),
	(65, 'paulsanoria', 'Successful', '2025-03-08 10:37:01', NULL);

-- Dumping structure for table db_project.users
CREATE TABLE IF NOT EXISTS `users` (
  `id` int NOT NULL AUTO_INCREMENT,
  `username` varchar(50) NOT NULL,
  `password` varchar(255) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `username` (`username`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table db_project.users: ~5 rows (approximately)
INSERT INTO `users` (`id`, `username`, `password`) VALUES
	(1, 'admin', '$2a$11$K1aXxPEoZrjwKcFgYVxlN.Sz5v/93xuU6Og6A6c6jQ0VxrzkuB7nO'),
	(4, 'kenneth', '$2a$11$v5mUa53FmEE6TbfbeLdEFuCUBa0y4GCEQqoU7EQl4Scrf.jbdnSvC'),
	(5, 'paulsanoria', '$2a$11$.LosrpsEE93hbXVhaU9BVeSoIqo1lJXoqVbnc3UoM3P3WKpULBq2K'),
	(6, 'jean', '$2a$11$SaWxwYMuKUtmqJTmScBz4uJWBG7lLpApxAPEyfNmRW/wfVXJQ.3zO'),
	(7, 'tester', '$2a$11$nUYESVITD259AI67lWf4EuedWNY6YsBqNVnp97JLx9fP.4g5CC3ZW');

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
