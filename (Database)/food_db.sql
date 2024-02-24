-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Feb 24, 2024 at 03:24 PM
-- Server version: 10.4.27-MariaDB
-- PHP Version: 8.2.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `food_db`
--

-- --------------------------------------------------------

--
-- Table structure for table `food_data`
--

CREATE TABLE `food_data` (
  `food_id` varchar(6) NOT NULL,
  `food_name` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `food_data`
--

INSERT INTO `food_data` (`food_id`, `food_name`) VALUES
('000001', 'Chicken Breast Fillet'),
('000002', 'Chicken Thigh'),
('000003', 'Fried Tofu'),
('000004', 'Bangus (Milkfish)'),
('000005', 'Tilapia'),
('000006', 'Shrimp'),
('000007', 'Lean Beef'),
('000008', 'Pork Belly'),
('000009', 'Greek Yogurt (Non-Fat)'),
('000010', 'Crab');

-- --------------------------------------------------------

--
-- Table structure for table `nutrients`
--

CREATE TABLE `nutrients` (
  `food_id` varchar(6) DEFAULT NULL,
  `calorie_energy` float DEFAULT NULL,
  `protein` float DEFAULT NULL,
  `total_fat` float DEFAULT NULL,
  `carbohydrate` float DEFAULT NULL,
  `sugar` float DEFAULT NULL,
  `sodium` float DEFAULT NULL,
  `cholesterol` float DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `nutrients`
--

INSERT INTO `nutrients` (`food_id`, `calorie_energy`, `protein`, `total_fat`, `carbohydrate`, `sugar`, `sodium`, `cholesterol`) VALUES
('000001', 1.51, 0.223, 0.0581, 0.0236, 0, 4.5, 0.68),
('000002', 2.26, 0.225, 0.151, 0.0012, 0.0012, 3.35, 1.27),
('000003', 1.17, 0.0401, 0.16, 0.0449, 0.0163, 0.23, 0.57),
('000004', 2.45, 0.201, 0.143, 0.0779, 0.0014, 3.57, 0.71),
('000005', 1.42, 0.225, 0.0442, 0, 0, 2.74, 0.65),
('000006', 1.92, 0.154, 0.12, 0.0227, 0.001, 1.68, 1.54),
('000007', 2.89, 0.235, 0.216, 0, 0, 3.61, 0.79),
('000008', 4.04, 0.266, 0.322, 0, 0, 4.48, 1.04),
('000009', 1.6, 0.0888, 0.046, 0.211, 0.121, 0.64, 0.04),
('000010', 0.83, 0.179, 0.0074, 0, 0, 3.95, 0.97);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `food_data`
--
ALTER TABLE `food_data`
  ADD PRIMARY KEY (`food_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
