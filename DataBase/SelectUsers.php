<?php

include("ConnectDataBace.php");
$sql = 'SELECT * FROM `Users_Rigistration_Data`';
if ($_POST['W']=='S'){
$result = mysqli_query($connect , $sql);

if(mysqli_num_rows($result)>0){
    
    while($row = mysqli_fetch_assoc($result)){
        echo "User Name: " .$row['User_Name']."Password: " .$row["User_Password"].":" ;
    }
    
    
}
}

?>