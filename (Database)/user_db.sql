-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Feb 07, 2024 at 06:09 AM
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
-- Database: `user_db`
--

-- --------------------------------------------------------

--
-- Table structure for table `illnesses`
--

CREATE TABLE `illnesses` (
  `first_name` varchar(30) DEFAULT NULL,
  `types` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `login`
--

CREATE TABLE `login` (
  `email` varchar(40) NOT NULL,
  `password` varchar(40) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `login`
--

INSERT INTO `login` (`email`, `password`) VALUES
('hutao@wangsheng.genshin.hoyo', 'b4fbbec904ba6d880edf7ad51bd91347'),
('jcsfrancisco@live.mcl.edu.ph', '5914362488e551ff1eb495581a60ab0e'),
('muratahimeko@hi3.hoyo', 'c5619ce2510d46e2e754b663198d4db7'),
('weltyang@starrail.hoyo', 'ab2d77dad98477145ed19086695ba277'),
('testname1@mcl.com', '9b6b249ca27284311db1df1aae014ea8');

-- --------------------------------------------------------

--
-- Table structure for table `user_data`
--

CREATE TABLE `user_data` (
  `email` varchar(40) DEFAULT NULL,
  `first_name` varchar(30) DEFAULT NULL,
  `last_name` varchar(20) DEFAULT NULL,
  `age` int(11) DEFAULT NULL,
  `height` decimal(10,2) DEFAULT NULL,
  `weight` decimal(10,2) DEFAULT NULL,
  `bmi` varchar(15) DEFAULT NULL,
  `daily_calorie_intake` decimal(10,0) DEFAULT NULL,
  `gender` varchar(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `user_data`
--

INSERT INTO `user_data` (`email`, `first_name`, `last_name`, `age`, `height`, `weight`, `bmi`, `daily_calorie_intake`, `gender`) VALUES
('jcsfrancisco@live.mcl.edu.ph', 'Jonard ', 'Francisco ', 23, '1.66', '70', '25.40', NULL, 'M'),
('weltyang@starrail.hoyo', 'Welt', 'Yang', 50, '1.74', '60', '26.67', NULL, 'M'),
('hutao@wangsheng.genshin.hoyo', 'Hu', 'Tao', 20, '1.56', '60', '24.97', NULL, 'F'),
('muratahimeko@hi3.hoyo', 'Himeko', 'Murata', 27, '1.67', '55', '19.72', NULL, 'F'),
('testname1@mcl.com', 'test', 'name', 23, '1.7', '90', '31.14', NULL, 'M');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `login`
--
ALTER TABLE `login`
  ADD PRIMARY KEY (`email`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
