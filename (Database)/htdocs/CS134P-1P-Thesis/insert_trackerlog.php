<?php 

include_once('connect_user_db.php');


$email = $_GET['email'];
$time_log =  $_GET['time_log'];
$calorie_count =  $_GET['calorie_count'];
$sugar_count =  $_GET['sugar_count'];

$result = mysqli_query($con,"INSERT INTO tracker_log VALUES ('$email', '$time_log', '$calorie_count', '$sugar_count')");

echo "Tracker Log Inserted";
?>
