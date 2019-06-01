-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: 27-Mar-2018 às 15:45
-- Versão do servidor: 5.7.19
-- PHP Version: 5.6.31

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `baudeashanti`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
CREATE TABLE IF NOT EXISTS `usuarios` (
  `codigo` int(11) NOT NULL AUTO_INCREMENT,
  `login` varchar(50) NOT NULL,
  `senha` varchar(100) NOT NULL,
  `isOpen` tinyint(1) NOT NULL DEFAULT '0',
  `nivel1` tinyint(1) NOT NULL DEFAULT '0',
  `nivel2` tinyint(1) NOT NULL DEFAULT '0',
  `nivel3` tinyint(1) NOT NULL DEFAULT '0',
  `tempo1` varchar(20) DEFAULT NULL,
  `tempo2` varchar(20) DEFAULT NULL,
  `tempo3` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`codigo`)
) ENGINE=MyISAM AUTO_INCREMENT=17 DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `usuarios`
--

INSERT INTO `usuarios` (`codigo`, `login`, `senha`, `isOpen`, `nivel1`, `nivel2`, `nivel3`, `tempo1`, `tempo2`, `tempo3`) VALUES
(1, 'aril', '698dc19d489c4e4db73e28a713eab07b', 0, 1, 0, 0, NULL, NULL, NULL),
(2, 'teste', '698dc19d489c4e4db73e28a713eab07b', 0, 0, 0, 0, NULL, NULL, NULL),
(3, 'teste1', 'c787ef1210bd3c7da7d817923817d7d3', 0, 0, 0, 0, NULL, NULL, NULL),
(10, 'arilton', 'cfcd208495d565ef66e7dff9f98764da', 0, 0, 0, 0, NULL, NULL, NULL),
(9, 'teste3', '698dc19d489c4e4db73e28a713eab07b', 0, 0, 0, 0, NULL, NULL, NULL),
(11, 'penny', '0cc175b9c0f1b6a831c399e269772661', 0, 1, 1, 1, NULL, NULL, NULL),
(12, 'tewstestets', 'b84208517cc5543427eaefe5e1e1859c', 0, 0, 0, 0, NULL, NULL, NULL),
(13, 'aksdgkasd', '831cd4261771841b8216f926a3e1f3c1', 0, 0, 0, 0, NULL, NULL, NULL),
(14, 'asdgsadg', '462b570e097a36671d7e57c820704416', 0, 0, 0, 0, NULL, NULL, NULL),
(15, 'sdgasdg', 'c787ef1210bd3c7da7d817923817d7d3', 0, 0, 0, 0, NULL, NULL, NULL),
(16, 'ghfgh', '9d20e65be94a040f3627bba41774e392', 0, 0, 0, 0, NULL, NULL, NULL);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
