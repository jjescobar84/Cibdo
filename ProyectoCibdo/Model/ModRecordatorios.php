<?php

class Recordatorios
{
//Atributos
public $idRecordatorio;
public $nombre;
public $fecha;
public $hora;
public $descripcion;
public $tipo;
public $_db;



  function __construct()
  {
    $this->_db = DataBase::getInstance();
  }


public function ListarRecordatorios(){
$sql = "SELECT * FROM tb_recordatorios";
$stm = $this->_db->prepare($sql);
$stm->execute();
return $stm->fetchAll(PDO::FETCH_ASSOC);
}


}




 ?>
