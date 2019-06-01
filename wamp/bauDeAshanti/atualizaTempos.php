<?php
require_once ("conexao.php");


$login = $_GET['login'];
$tipo = $_GET['tipoChave'];
$tempo = $_GET['tempo'];

$query = "UPDATE usuarios SET ";

if ($tipo == 1) {
    $query+= "tempo1 = true ";
} 

if ($tipo == 2) {
    $query+= "tempo2 = true ";
}

if ($tipo == 2) {
    $query+= "tempo3 = true ";
}

if ($tipo != 1 && $tipo!=2 && $tipo!=3){
    mysqli_close($conn);
    echo '-1';

}

$sql += "WHERE login='$login'");


$result = mysqli_query($conn,$sql);



if ($sql){
	mysqli_close($conn);
    echo '1';
} else {
    mysqli_close($conn);
	echo '2';
	
}



?>