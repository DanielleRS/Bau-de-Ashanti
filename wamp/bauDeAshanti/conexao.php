<?php
$conn = mysqli_connect('localhost','root','') or die ('Erro ao conectar');
$banco = mysqli_select_db($conn,"bauDeAshanti") or die ('Banco não encontrado');
?>