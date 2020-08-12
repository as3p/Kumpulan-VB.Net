<?php

$file = $_POST['lokasi'];
$newfile = $_POST['tujuan'];


//$file = 'D:\1.txt'; 
//$newfile = 'upload/siap.txt';


//file = 'D:\1.txt';    OK
//$newfile = 'D:\geeksforgeeks.txt';  OK


if (!copy($file, $newfile)) 
			{
				echo "failed to copy $file...\n";
			}
		else
			{ 
				echo "File has been copied! \n"; 
			}
?>
