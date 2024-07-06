CREATE DATABASE user_db;

CREATE TABLE illnesses (
  email varchar(40) DEFAULT NULL,
  types text DEFAULT NULL
);

-- Dumping data for table `illnesses`

INSERT INTO illnesses (email, types) VALUES
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
('jonard14games@gmail.com', 'Healthy');

-- --------------------------------------------------------

-- Table structure for table `login`

CREATE TABLE login (
  email varchar(40) NOT NULL,
  password varchar(100) DEFAULT NULL,
  acct_type varchar(5) NOT NULL
) ;

INSERT INTO login (email, password, acct_type) VALUES
('hutao@wangsheng.genshin.hoyo', HASHBYTES('SHA2_256','funeralparlor'), 'user'),
('jcsfrancisco@live.mcl.edu.ph', HASHBYTES('SHA2_256','jonard14'), 'user'),
('jonard14games@gmail.com', HASHBYTES('SHA2_256','j14games'), 'user'),
('muratahimeko@hi3.hoyo', HASHBYTES('SHA2_256','finallesson'), 'user'),
('testname1@mcl.com', HASHBYTES('SHA2_256','Testing1'), 'user'),
('testname2@mcl.com', HASHBYTES('SHA2_256','Testing2'), 'user'),
('weltyang@starrail.hoyo', HASHBYTES('SHA2_256','blackhole'), 'user'),

('jonard@admin.com', HASHBYTES('SHA2_256','jonard14'), 'admin'),
('nutritrack@mcl.edu.ph', HASHBYTES('SHA2_256','nutritrack'), 'admin');

-- --------------------------------------------------------

-- Table structure for table `tracker_log`

CREATE TABLE tracker_log (
  email varchar(40) NOT NULL,
  time_log varchar(30) NOT NULL,
  calorie_count float NOT NULL,
  sugar_count float NOT NULL,
  protein_count float NOT NULL,
  fats_count float NOT NULL,
  cholesterol_count float NOT NULL,
  carbohydrates_count float NOT NULL,
  sodium_count float NOT NULL
) ;


INSERT INTO tracker_log (email, time_log, calorie_count, sugar_count, protein_count, fats_count, cholesterol_count, carbohydrates_count, sodium_count) VALUES
('jcsfrancisco@live.mcl.edu.ph', '06/18/2024 4:34:45 PM', 296, 15.9, 2.7, 15.3, 7, 37.6, 217),
('jcsfrancisco@live.mcl.edu.ph', '06/20/2024 1:23:37 AM', 592, 31.8, 5.4, 30.6, 14, 75.2, 434),
('jcsfrancisco@live.mcl.edu.ph', '06/23/2024 12:21:39 AM', 592, 31.8, 5.4, 30.6, 14, 75.2, 434),
('jcsfrancisco@live.mcl.edu.ph', '06/23/2024 12:28:02 AM', 1810, 0.3, 177, 79.4, 750, 88.6, 5220),
('jcsfrancisco@live.mcl.edu.ph', '06/23/2024 12:29:23 AM', 296, 15.9, 2.7, 15.3, 7, 37.6, 217),
('jcsfrancisco@live.mcl.edu.ph', '06/23/2024 1:08:48 AM', 1510, 0, 223, 58.1, 680, 23.6, 4500),
('jcsfrancisco@live.mcl.edu.ph', '07/01/2024 11:14:36 PM', 29.6, 1.59, 0.27, 1.53, 0.7, 3.76, 21.7),
('jcsfrancisco@live.mcl.edu.ph', '07/02/2024 12:27:58 PM', 245, 0.14, 20.1, 14.3, 71, 7.79, 357),
('jcsfrancisco@live.mcl.edu.ph', '07/02/2024 12:59:59 PM', 492.45, 0.2814, 40.401, 28.743, 142.71, 15.6579, 717.57),
('jcsfrancisco@live.mcl.edu.ph', '07/02/2024 7:08:30 PM', 244, 48.4, 0.68, 0.6, 0, 59.2, 0);

-- --------------------------------------------------------

--
-- Table structure for table `user_data`
--

CREATE TABLE user_data (
  email varchar(40) DEFAULT NULL,
  first_name varchar(30) DEFAULT NULL,
  last_name varchar(20) DEFAULT NULL,
  birthday varchar(10) DEFAULT NULL,
  height decimal(10,2) DEFAULT NULL,
  weight decimal(10,2) DEFAULT NULL,
  bmi varchar(15) DEFAULT NULL,
  daily_calorie_intake float DEFAULT NULL,
  total_calorie_intake float DEFAULT NULL,
  calorie_intake_days float DEFAULT NULL,
  gender varchar(1) DEFAULT NULL
);

--
-- Dumping data for table `user_data`
--

INSERT INTO user_data (email, first_name, last_name, birthday, height, weight, bmi, daily_calorie_intake, total_calorie_intake, calorie_intake_days, gender) VALUES
('jcsfrancisco@live.mcl.edu.ph', 'Jonard ', 'Francisco ', '2001-02-26', '1.66', '70.00', '25.40', 347.402, 6948.05, 20, 'M'),
('weltyang@starrail.hoyo', 'Welt', 'Yang', '1955-01-01', '1.74', '60.00', '26.67', 2587, 1000, 1, 'M'),
('hutao@wangsheng.genshin.hoyo', 'Hu', 'Tao', '2002-07-15', '1.56', '60.00', '24.97', 2202, 1000, 1, 'F'),
('muratahimeko@hi3.hoyo', 'Himeko', 'Murata', '1996-06-11', '1.67', '55.00', '19.72', 2123, 1000, 1, 'F'),
('testname1@mcl.com', 'test', 'name', '1979-03-31', '1.70', '90.00', '31.14', 0, 0, 0, 'M'),
('testname2@mcl.com', 'Test2', 'Testing2', '1982-12-12', '1.69', '70.00', '24.51', 0, 0, 0, 'M'),
('jonard14games@gmail.com', 'Jon', 'Cyu', '1999-12-31', '1.70', '74.00', '25.61', 1126, 2252, 2, 'M');


-- Indexes for dumped tables

-- Indexes for table `login`
ALTER TABLE login
  ADD PRIMARY KEY (email);
COMMIT;
