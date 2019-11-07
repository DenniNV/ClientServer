<?php
include("ConnectDataBace.php");
$username = $_POST["username"];
$userpassword = $_POST["userpassword"];
$useremail =$_POST["useremail"];




$sql = "INSERT INTO `Users_Rigistration_Data` (`id`, `User_Name`, `User_Password`, `Email`) VALUES (NULL, $username, $userpassword, $useremail)";

$result = mysqli_query($connect , $sql);




?>