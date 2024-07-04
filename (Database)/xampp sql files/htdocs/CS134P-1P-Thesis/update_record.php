<?php 

include_once('connect_user_db.php');

$name = $_GET['name'];
$status =  $_GET['status'];

$result = mysqli_query($con,"UPDATE foodcategory SET status='$status' WHERE name='$name';");
echo "Data Updated";
?>