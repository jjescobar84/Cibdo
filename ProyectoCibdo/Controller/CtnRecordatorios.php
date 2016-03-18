<?php
require '../Config/DB.php';
require '../Library/DataBase.php';
require '../Model/ModRecordatorios.php';

$r = new Recordatorios();

$l = $r->ListarRecordatorios();
foreach ($l as $key => $value) {
  $tabla.="<tr>";
  $tabla.="<td>".$value["idRecordatorio"]."</td>";
  $tabla.="<td>".$value["nombre"]."</td>";
  $tabla.="<td>".$value["fecha"]."</td>";
  $tabla.="<td>".$value["hora"]."</td>";
  $tabla.="<td>".$value["descripcion"]."</td>";
  $tabla.="<td>".$value["tipo"]."</td>";
  $tabla.="<td><a href='".$value["cedula"]."'>Eliminar</a></td>";
  $tabla.="</tr>";
}
include '../View/Recordatorios/VwRegistrarRes.php';
 ?>
