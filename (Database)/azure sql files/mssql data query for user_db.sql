TRUNCATE TABLE login;

INSERT INTO login (email, password) VALUES
('hutao@wangsheng.genshin.hoyo', HASHBYTES('SHA2_256','funeralparlor')),
('jcsfrancisco@live.mcl.edu.ph', HASHBYTES('SHA2_256','jonard14')),
('jonard14games@gmail.com', HASHBYTES('SHA2_256','j14games')),
('muratahimeko@hi3.hoyo', HASHBYTES('SHA2_256','finallesson')),
('testname1@mcl.com', HASHBYTES('SHA2_256','Testing1')),
('testname2@mcl.com', HASHBYTES('SHA2_256','Testing2')),
('weltyang@starrail.hoyo', HASHBYTES('SHA2_256','blackhole'));

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
('testname1@mcl.com', 'Heart Disease'),
('testname2@mcl.com', 'Heart Disease'),
('testname2@mcl.com', 'Diabetes'),
('jonard14games@gmail.com', 'Healthy');

SELECT * FROM illnesses;

TRUNCATE TABLE user_data;

INSERT INTO user_data (email, first_name, last_name, birthday, height, weight, bmi, daily_calorie_intake, total_calorie_intake, calorie_intake_days, gender) VALUES
('jcsfrancisco@live.mcl.edu.ph', 'Jonard ', 'Francisco ', '2001-02-26', '1.66', '70.00', '25.40', 347.402, 6948.05, 20, 'M'),
('weltyang@starrail.hoyo', 'Welt', 'Yang', '1955-01-01', '1.74', '60.00', '26.67', 2587, 1000, 1, 'M'),
('hutao@wangsheng.genshin.hoyo', 'Hu', 'Tao', '2002-07-15', '1.56', '60.00', '24.97', 2202, 1000, 1, 'F'),
('muratahimeko@hi3.hoyo', 'Himeko', 'Murata', '1996-06-11', '1.67', '55.00', '19.72', 2123, 1000, 1, 'F'),
('testname1@mcl.com', 'test', 'name', '1979-03-31', '1.70', '90.00', '31.14', 0, 0, 0, 'M'),
('testname2@mcl.com', 'Test2', 'Testing2', '1982-12-12', '1.69', '70.00', '24.51', 0, 0, 0, 'M'),
('jonard14games@gmail.com', 'Jon', 'Cyu', '1999-12-31', '1.70', '74.00', '25.61', 1126, 2252, 2, 'M');

SELECT * FROM user_data;