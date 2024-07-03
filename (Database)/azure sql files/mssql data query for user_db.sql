TRUNCATE TABLE login;

INSERT INTO login (email, password, acct_type) VALUES
('hutao@wangsheng.genshin.hoyo', HASHBYTES('SHA2_256','funeralparlor'), 'user'),
('jcsfrancisco@live.mcl.edu.ph', HASHBYTES('SHA2_256','jonard14'), 'user'),
('jonard14games@gmail.com', HASHBYTES('SHA2_256','j14games'), 'user'),
('muratahimeko@hi3.hoyo', HASHBYTES('SHA2_256','finallesson'), 'user'),
('testname1@mcl.com', HASHBYTES('SHA2_256','Testing1'), 'user'),
('testname2@mcl.com', HASHBYTES('SHA2_256','Testing2'), 'user'),
('weltyang@starrail.hoyo', HASHBYTES('SHA2_256','blackhole'), 'user'),

('jonard@admin.com', HASHBYTES('SHA2_256','jonard14'), 'admin');

SELECT * FROM login

TRUNCATE TABLE illnesses;

INSERT INTO illnesses VALUES
('jcsfrancisco@live.mcl.edu.ph', 'Healthy'),
('weltyang@starrail.hoyo', 'Cancer'),
('muratahimeko@hi3.hoyo', 'Heart Disease'),
('muratahimeko@hi3.hoyo', 'Diabetes'),
('muratahimeko@hi3.hoyo', 'Cancer'),
('hutao@wangsheng.genshin.hoyo', 'Heart Disease'),
('hutao@wangsheng.genshin.hoyo', 'Diabetes'),
('hutao@wangsheng.genshin.hoyo', 'Cancer'),
('jonard14games@gmail.com', 'Healthy');

SELECT * FROM illnesses;

TRUNCATE TABLE user_data;

INSERT INTO user_data (email, first_name, last_name, birthday, height, weight, bmi, daily_calorie_intake, total_calorie_intake, calorie_intake_days, gender) VALUES
('jcsfrancisco@live.mcl.edu.ph', 'Jonard ', 'Francisco ', '2001-02-26', '1.66', '70.00', '25.40', 347.402, 6948.05, 10, 'M'),
('weltyang@starrail.hoyo', 'Welt', 'Yang', '1955-01-01', '1.74', '60.00', '26.67', 0, 0, 0, 'M'),
('hutao@wangsheng.genshin.hoyo', 'Hu', 'Tao', '2002-07-15', '1.56', '60.00', '24.97', 0, 0, 0, 'F'),
('muratahimeko@hi3.hoyo', 'Himeko', 'Murata', '1996-06-11', '1.67', '55.00', '19.72', 0, 0, 0, 'F'),
('jonard14games@gmail.com', 'Jon', 'Cyu', '1999-12-31', '1.70', '74.00', '25.61', 0, 0, 0, 'M');

SELECT * FROM user_data;

TRUNCATE TABLE tracker_log;

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

SELECT * FROM tracker_log ORDER BY time_log DESC;