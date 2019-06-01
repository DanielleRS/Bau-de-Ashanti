<?php
require_once ("conexao.php");


$login = $_GET['login'];
$senha = $_GET['senha'];
$senha = md5($senha);

$sql = mysqli_query($conn,"SELECT senha FROM usuarios WHERE login='$login'");

if ($sql){
	$row = mysqli_fetch_assoc($sql);
    $pass = $row['senha'];
    if ($pass == $senha) {
        mysqli_close($conn);
    	echo '1';
    	
    } else {
        mysqli_close($conn);
    	echo '2';
    	
    }
    
} else {
    mysqli_close($conn);
	echo '3';
	
}



?>