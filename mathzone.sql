-- phpMyAdmin SQL Dump
-- version 3.5.2
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Jun 07, 2016 at 11:38 PM
-- Server version: 5.5.25a
-- PHP Version: 5.4.4

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `mathzone`
--

-- --------------------------------------------------------

--
-- Table structure for table `biography`
--

CREATE TABLE IF NOT EXISTS `biography` (
  `name` varchar(100) NOT NULL,
  `dob` varchar(50) DEFAULT NULL,
  `dod` varchar(50) DEFAULT NULL,
  `nationality` varchar(100) NOT NULL,
  `details` longtext NOT NULL,
  `photo` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `biography`
--

INSERT INTO `biography` (`name`, `dob`, `dod`, `nationality`, `details`, `photo`) VALUES
('Sujoy Sen Jitu', '1992-12-12', NULL, 'Banglaseh', 'Very good mathematician, very good. df dfjd39834 erefj39r efhdjf9343 4fd fd.fdf afdfjdldd\n\nchotobela:\nonek koste katche, onek koste.\n\nborobela:\nonek koste katche, onek koste.\n\nbuirabela:\nonek arame katche, onek arame.\n\nuniversity:\nAIUB\n\nBaccha-kaccha:\nbaccha-kaccha beshi ekta nai, tobe 4ta chele 2 ta meye ache. chelegula onek dustu ar meye gula onek cute.\n\nwife: wife dekhte onek sundor. tobe husbandpor typer. husband chara kichui buje na.', 'sujoy.jpeg'),
('Mou Roy', '1993-04-14', NULL, 'Bangladesh', 'Very good mathematician, very good. df dfjd39834 erefj39r efhdjf9343 4fd fd.fdf afdfjdldd\r\n\r\nchotobela:\r\nonek anonde katche, onek.....\r\n\r\nborobela:\r\nonek koste katche, onek koste.\r\n\r\nbuirabela:\r\nonek arame katche, onek arame.\r\n\r\nuniversity:\r\nAIUB\r\n\r\nBaccha-kaccha:\r\nbaccha-kaccha beshi ekta nai, tobe 2ta chele 8 ta meye ache. chelegula onek dustu ar meye gula onek cute.\r\n\r\nbiye korar kotha chilo ekjonke, korche arekjonke.', 'mou.jpg'),
('Fahmida Haque Zeba', '1993-10-01', NULL, 'Banglaseh', 'Very bad mathematician, very bad. \n\nchotobela:\nonek moja kore katche, onek.....\n\nborobela:\nonek koste katche, onek koste.\n\nbuirabela:\nonek arame katche, onek arame.\n\nuniversity:\nAIUB\n\nBaccha-kaccha:\nonekgula. 10ta chele 15 ta meye ache. chele-meye sobgulai onek dustu, ekekta soytaner haddi. sobgula purai mar moto hoiche.\n\nhusband\nbiye korar por chele-meye gular baba bechara faisha geche.\n', 'zeba.jpg');

-- --------------------------------------------------------

--
-- Table structure for table `math_problems`
--

CREATE TABLE IF NOT EXISTS `math_problems` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `level` int(11) NOT NULL,
  `topic` varchar(100) NOT NULL,
  `problem` longtext NOT NULL,
  `num1_min` int(11) DEFAULT NULL,
  `num1_max` int(11) DEFAULT NULL,
  `num2_min` int(11) DEFAULT NULL,
  `num2_max` int(11) DEFAULT NULL,
  `num3_min` int(11) DEFAULT NULL,
  `num3_max` int(11) DEFAULT NULL,
  `num4_min` int(11) DEFAULT NULL,
  `num4_max` int(11) DEFAULT NULL,
  `sequence` varchar(4) DEFAULT NULL,
  `solution` varchar(20) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=4 ;

--
-- Dumping data for table `math_problems`
--

INSERT INTO `math_problems` (`id`, `level`, `topic`, `problem`, `num1_min`, `num1_max`, `num2_min`, `num2_max`, `num3_min`, `num3_max`, `num4_min`, `num4_max`, `sequence`, `solution`) VALUES
(1, 1, 'addition', 'There are num1 children playing at the park. After sometimes num2 more children has come. How many children are there?', 3, 6, 2, 4, 0, 0, 0, 0, NULL, 'aa'),
(2, 1, 'addition', 'There were playing num1 children in the field. After sometimes num2 children have come. After that num3 more children have come. Now how many children are playing in the field. ', 2, 4, 2, 5, 2, 6, 0, 0, NULL, 'aaa'),
(3, 1, 'addition ', 'Mitu had num1 biscuits. Her father gave her num2 biscuits and her mother gave her num2 more biscuits. Now How many biscuits she has?', 1, 5, 2, 7, 2, 4, 0, 0, NULL, 'aaa');

-- --------------------------------------------------------

--
-- Table structure for table `progress_report`
--

CREATE TABLE IF NOT EXISTS `progress_report` (
  `user` varchar(50) NOT NULL,
  `quiz_date` varchar(50) NOT NULL,
  `quiz_name` varchar(50) NOT NULL,
  `score` int(11) NOT NULL,
  `quiz_time` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `progress_report`
--

INSERT INTO `progress_report` (`user`, `quiz_date`, `quiz_name`, `score`, `quiz_time`) VALUES
('akash', '6/3/2016 1:09:19 AM', 'Class 1: Additon Quiz', 0, '00:03'),
('akash', '6/3/2016 1:16:10 AM', 'Class 1: additionProblems', 1, '00:11'),
('akash', '6/5/2016 9:47:28 AM', 'Class 1: Additon Quiz', 3, '00:37'),
('akash', '6/4/2016 9:47:28 AM', 'class 1- Addition', 20, '05.00'),
('akash', '6/3/2016 9:47:28 AM', 'class1 - addition', 50, '4.30'),
('zeba', '6/1/2016 9:47:28 AM', 'class 1- Addition', 40, '04.12'),
('zeba', '6/2/2016 9:47:28 AM', 'class1 - addition', 60, '5.30'),
('zeba', '6/9/2016 9:47:28 AM', 'class 1- Addition', 70, '6.00'),
('zeba', '6/8/2016 9:47:28 AM', 'class 1- Addition', 30, '6.00'),
('zeba', '4/18/2016 9:47:28 AM', 'class 1- Addition', 100, '10.34'),
('zeba', '6/5/2016 9:47:28 AM', 'class 1- Addition', 80, '06.00'),
('zeba', '6/20/2016 9:47:28 AM', 'class 1- Addition', 10, '06.00'),
('zeba', '6/21/2016 9:47:28 AM', 'class 1- Addition', 20, '06.00'),
('zeba', '6/6/2016 1:36:59 AM', 'Class 1: Subtraction', 2, '00:14'),
('akash', '6/6/2016 2:56:08 AM', 'Class 1: Additon Quiz', 0, '00:23'),
('zeba', '6/7/2016 12:52:50 AM', 'Class 1: Additon Quiz', 0, '00:22'),
('zeba', '6/7/2016 1:56:04 AM', 'Class 1: Subtraction', 0, '00:15');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
