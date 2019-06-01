<?php
require_once ("conexao.php");


$login = $_GET['login'];
$tipo = $_GET['tipoChave'];


$query = "UPDATE usuarios SET ";

if ($tipo == 1) {
    $query+= "nivel1 = true";
} 

if ($tipo == 2) {
    $query+= "nivel2 = true";
}

if ($tipo == 3) {
    $query+= "nivel3 = true";
}

if ($tipo != 1 && $tipo!=2 && $tipo!=3){
    mysqli_close($conn);
    echo '-1';

}

$sql += " WHERE login='$login'");


$result = mysqli_query($conn,$sql);



if ($sql){
	mysqli_close($conn);
    echo '1';
} else {
    mysqli_close($conn);
	echo '2';
	
}



?>