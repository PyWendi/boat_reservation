-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Jun 10, 2023 at 05:06 AM
-- Server version: 8.0.31
-- PHP Version: 8.0.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `boatreservation`
--

-- --------------------------------------------------------

--
-- Table structure for table `bateaux`
--

DROP TABLE IF EXISTS `bateaux`;
CREATE TABLE IF NOT EXISTS `bateaux` (
  `code_bat` int NOT NULL AUTO_INCREMENT,
  `design` varchar(30) NOT NULL,
  `disponibilité` tinyint(1) NOT NULL DEFAULT '1',
  `class_a` int NOT NULL DEFAULT '0',
  `class_b` int NOT NULL DEFAULT '0',
  `class_c` int NOT NULL DEFAULT '0',
  PRIMARY KEY (`code_bat`),
  UNIQUE KEY `design` (`design`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `bateaux`
--

INSERT INTO `bateaux` (`code_bat`, `design`, `disponibilité`, `class_a`, `class_b`, `class_c`) VALUES
(1, 'BT-432', 1, 47, 75, 97),
(2, 'BT-123', 1, 49, 39, 29);

-- --------------------------------------------------------

--
-- Table structure for table `class`
--

DROP TABLE IF EXISTS `class`;
CREATE TABLE IF NOT EXISTS `class` (
  `code_bat` int NOT NULL,
  `classA` int NOT NULL DEFAULT '0',
  `classB` int NOT NULL DEFAULT '0',
  `classC` int NOT NULL DEFAULT '0',
  UNIQUE KEY `code_bat` (`code_bat`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `class`
--

INSERT INTO `class` (`code_bat`, `classA`, `classB`, `classC`) VALUES
(1, 50, 75, 100),
(2, 50, 40, 30);

-- --------------------------------------------------------

--
-- Table structure for table `passager`
--

DROP TABLE IF EXISTS `passager`;
CREATE TABLE IF NOT EXISTS `passager` (
  `id_pass` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(150) NOT NULL,
  `prenom` varchar(150) NOT NULL,
  `email` varchar(250) DEFAULT NULL,
  `tel` varchar(30) DEFAULT NULL,
  `cin` varchar(30) DEFAULT NULL,
  `class` varchar(10) NOT NULL,
  `id_voyage` int NOT NULL,
  PRIMARY KEY (`id_pass`),
  UNIQUE KEY `email` (`email`),
  UNIQUE KEY `tel` (`tel`),
  UNIQUE KEY `cin` (`cin`),
  KEY `PASSAGER_id_voyage_VOYAGE_code_voyage` (`id_voyage`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `passager`
--

INSERT INTO `passager` (`id_pass`, `nom`, `prenom`, `email`, `tel`, `cin`, `class`, `id_voyage`) VALUES
(1, 'Jean', 'Luc', 'jeanLuc@gmail.com', '098765421', '1234567890', 'C', 1),
(3, 'Thierry', 'Bruno', 'Thierry@gmail.com', '2345668', '234567292', 'A', 1);

-- --------------------------------------------------------

--
-- Table structure for table `passager_reservation`
--

DROP TABLE IF EXISTS `passager_reservation`;
CREATE TABLE IF NOT EXISTS `passager_reservation` (
  `id_pass` int NOT NULL,
  `id_res` int NOT NULL,
  PRIMARY KEY (`id_pass`,`id_res`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `passager_reservation`
--

INSERT INTO `passager_reservation` (`id_pass`, `id_res`) VALUES
(1, 1),
(2, 2);

-- --------------------------------------------------------

--
-- Table structure for table `receptionnist`
--

DROP TABLE IF EXISTS `receptionnist`;
CREATE TABLE IF NOT EXISTS `receptionnist` (
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  UNIQUE KEY `username` (`username`),
  UNIQUE KEY `password` (`password`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `receptionnist`
--

INSERT INTO `receptionnist` (`username`, `password`) VALUES
('Hello', 'World');

-- --------------------------------------------------------

--
-- Table structure for table `reservation`
--

DROP TABLE IF EXISTS `reservation`;
CREATE TABLE IF NOT EXISTS `reservation` (
  `id_res` int NOT NULL AUTO_INCREMENT,
  `id_voyage` int NOT NULL DEFAULT '0',
  `class_A` int NOT NULL DEFAULT '0',
  `class_b` int NOT NULL DEFAULT '0',
  `class_c` int NOT NULL DEFAULT '0',
  `prenom` varchar(50) NOT NULL,
  `numero` varchar(30) NOT NULL,
  `payement` varchar(10) NOT NULL,
  `somme_paye` int NOT NULL DEFAULT '0',
  `reste_paye` int NOT NULL DEFAULT '0',
  `fini` tinyint(1) DEFAULT '0',
  PRIMARY KEY (`id_res`),
  KEY `RESERVATION_id_voyage_VOYAGE_code_voyage` (`id_voyage`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `reservation`
--

INSERT INTO `reservation` (`id_res`, `id_voyage`, `class_A`, `class_b`, `class_c`, `prenom`, `numero`, `payement`, `somme_paye`, `reste_paye`, `fini`) VALUES
(1, 1, 0, 0, 1, 'Jean', 'Luc', 'TP', 35000, 0, 1),
(2, 1, 1, 0, 0, 'Thierry', 'Bruno', 'TP', 70000, 0, 1),
(3, 3, 0, 0, 4, 'See', 'Sharp', 'SA', 0, 160000, 0),
(7, 3, 1, 1, 1, 'Louis', 'Jean', 'SA', 0, 190000, 0),
(8, 2, 3, 0, 3, 'Jean', 'Louis', 'AA', 330000, 80000, 0);

-- --------------------------------------------------------

--
-- Table structure for table `voyage`
--

DROP TABLE IF EXISTS `voyage`;
CREATE TABLE IF NOT EXISTS `voyage` (
  `code_voyage` int NOT NULL AUTO_INCREMENT,
  `itinéraire` varchar(50) NOT NULL,
  `durée` varchar(30) NOT NULL,
  `date_depart` datetime NOT NULL,
  `frais` int NOT NULL,
  `finitude` tinyint(1) DEFAULT '0',
  `code_bat` int NOT NULL,
  PRIMARY KEY (`code_voyage`),
  KEY `VOYAGE_code_bat_BATEAUX_code_bat` (`code_bat`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `voyage`
--

INSERT INTO `voyage` (`code_voyage`, `itinéraire`, `durée`, `date_depart`, `frais`, `finitude`, `code_bat`) VALUES
(1, 'TANA-FIANARA', '3 heures ', '2023-06-05 18:47:58', 35000, 0, 1),
(2, 'FIANARA-TANA', '10 Heures', '2023-06-06 18:27:40', 30000, 0, 1),
(3, 'TANA-TULEAR', '15 heures', '2023-06-06 18:32:18', 40000, 0, 2);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `class`
--
ALTER TABLE `class`
  ADD CONSTRAINT `CLASS_code_bat_BATEAUX_code_bat` FOREIGN KEY (`code_bat`) REFERENCES `bateaux` (`code_bat`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `passager`
--
ALTER TABLE `passager`
  ADD CONSTRAINT `PASSAGER_id_voyage_VOYAGE_code_voyage` FOREIGN KEY (`id_voyage`) REFERENCES `voyage` (`code_voyage`);

--
-- Constraints for table `reservation`
--
ALTER TABLE `reservation`
  ADD CONSTRAINT `RESERVATION_id_voyage_VOYAGE_code_voyage` FOREIGN KEY (`id_voyage`) REFERENCES `voyage` (`code_voyage`);

--
-- Constraints for table `voyage`
--
ALTER TABLE `voyage`
  ADD CONSTRAINT `VOYAGE_code_bat_BATEAUX_code_bat` FOREIGN KEY (`code_bat`) REFERENCES `bateaux` (`code_bat`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
