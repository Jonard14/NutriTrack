-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 20, 2024 at 02:20 PM
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
  `email` varchar(40) DEFAULT NULL,
  `types` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `illnesses`
--

INSERT INTO `illnesses` (`email`, `types`) VALUES
('jcsfrancisco@live.mcl.edu.ph', 'Healthy'),
('weltyang@starrail.hoyo', 'Cancer'),
('muratahimeko@hi3.hoyo', 'Heart Disease'),
('muratahimeko@hi3.hoyo', 'Diabetes'),
('muratahimeko@hi3.hoyo', 'Cancer'),
('hutao@wangsheng.genshin.hoyo', 'Heart Disease'),
('hutao@wangsheng.genshin.hoyo', 'Diabetes'),
('hutao@wangsheng.genshin.hoyo', 'Cancer'),
('testname1@mcl.com', 'Heart Disease'),
('testname2@mcl.com', 'Heart Disease'),
('testname2@mcl.com', 'Diabetes'),
('jonard14games@gmail.com', 'Healthy'),
('j14@gmail.com', 'Healthy');

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
('j14@gmail.com', '045d043233edf3a17a5ec1abdbafd62c'),
('jcsfrancisco@live.mcl.edu.ph', '5914362488e551ff1eb495581a60ab0e'),
('jonard14games@gmail.com', '045d043233edf3a17a5ec1abdbafd62c'),
('muratahimeko@hi3.hoyo', 'c5619ce2510d46e2e754b663198d4db7'),
('testname1@mcl.com', '9b6b249ca27284311db1df1aae014ea8'),
('testname2@mcl.com', 'd64c2df2c18061e78b51a9f6d3e542aa'),
('weltyang@starrail.hoyo', 'ab2d77dad98477145ed19086695ba277');

-- --------------------------------------------------------

--
-- Table structure for table `tracker_log`
--

CREATE TABLE `tracker_log` (
  `email` varchar(40) NOT NULL,
  `time_log` varchar(30) NOT NULL,
  `calorie_count` float NOT NULL,
  `sugar_count` float NOT NULL
  `protein_count` float NOT NULL
  `fats_count` float NOT NULL
  `cholesterol_count` float NOT NULL
  `carbohydrates_count` float NOT NULL
  `sodiumn_count` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tracker_log`
--

INSERT INTO `tracker_log` (`email`, `time_log`, `calorie_count`, `sugar_count`,`protein_count`,`fats_count`,`cholesterol_count`,`carbohydrates_count`,`sodiumn_count`) VALUES
('jcsfrancisco@live.mcl.edu.ph', '05/20/2024 8:10:34 PM', 404, 0,1,1,1,1,1),
('jcsfrancisco@live.mcl.edu.ph', '05/20/2024 8:12:07 PM', 245, 0.14,1,1,1,1,1),
('jcsfrancisco@live.mcl.edu.ph', '05/20/2024 8:17:36 PM', 192, 0.1,1,1,1,1,1);

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
  `daily_calorie_intake` float DEFAULT NULL,
  `total_calorie_intake` float DEFAULT NULL,
  `calorie_intake_days` float DEFAULT NULL,
  `gender` varchar(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `user_data`
--

INSERT INTO `user_data` (`email`, `first_name`, `last_name`, `age`, `height`, `weight`, `bmi`, `daily_calorie_intake`, `total_calorie_intake`, `calorie_intake_days`, `gender`) VALUES
('jcsfrancisco@live.mcl.edu.ph', 'Jonard ', 'Francisco ', 23, '1.66', '70.00', '25.40', 280.333, 841, 3, 'M'),
('weltyang@starrail.hoyo', 'Welt', 'Yang', 50, '1.74', '60.00', '26.67', 2587, 1000, 1, 'M'),
('hutao@wangsheng.genshin.hoyo', 'Hu', 'Tao', 20, '1.56', '60.00', '24.97', 2202, 1000, 1, 'F'),
('muratahimeko@hi3.hoyo', 'Himeko', 'Murata', 27, '1.67', '55.00', '19.72', 2123, 1000, 1, 'F'),
('testname1@mcl.com', 'test', 'name', 23, '1.70', '90.00', '31.14', 0, 0, 0, 'M'),
('testname2@mcl.com', 'Test2', 'Testing2', 22, '1.69', '70.00', '24.51', 0, 0, 0, 'M'),
('jonard14games@gmail.com', 'Jon', 'Cyu', 21, '1.70', '74.00', '25.61', 1126, 2252, 2, 'M'),
('j14@gmail.com', 'Jonard', 'Francisco', 21, '1.70', '60.00', '20.76', 404, 404, 1, 'M');

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
