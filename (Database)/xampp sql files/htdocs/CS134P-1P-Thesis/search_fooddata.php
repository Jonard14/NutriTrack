<?php

include_once('connect_food_db.php');

$query = "SELECT food_data.food_id, food_data.food_name, nutrients.calorie_energy, nutrients.protein, nutrients.total_fat, nutrients.carbohydrate, nutrients.sugar, nutrients.sodium, nutrients.cholesterol
FROM food_data INNER JOIN nutrients ON food_data.food_id = nutrients.food_id ORDER BY food_data.food_name ASC;";
$check=mysqli_query($con,$query);
$row=mysqli_num_rows($check);
$myArray = array();

if($check == FALSE) { 
    echo ".".$row."."; // TODO: better error handling
}

  while($row=mysqli_fetch_array($check))
  	{
  	
	 $myArray[] = $row;
	
  	}
  echo json_encode($myArray);
?>