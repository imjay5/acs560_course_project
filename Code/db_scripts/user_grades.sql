-- phpMyAdmin SQL Dump
-- version 4.0.10deb1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Dec 04, 2017 at 11:49 PM
-- Server version: 5.5.57-0ubuntu0.14.04.1
-- PHP Version: 5.5.9-1ubuntu4.22

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `exam_portal`
--

-- --------------------------------------------------------

--
-- Table structure for table `user_grades`
--

CREATE TABLE IF NOT EXISTS `user_grades` (
  `user_id` int(11) NOT NULL,
  `exam_id` int(11) NOT NULL,
  `grade` char(1) NOT NULL,
  PRIMARY KEY (`user_id`,`exam_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `user_grades`
--

INSERT INTO `user_grades` (`user_id`, `exam_id`, `grade`) VALUES
(37, 14, 'A'),
(37, 19, 'C'),
(37, 26, 'B'),
(40, 14, 'A'),
(40, 18, 'B'),
(40, 19, 'A'),
(40, 26, 'C'),
(41, 8, 'A'),
(41, 14, 'A'),
(41, 19, 'C'),
(43, 8, 'A'),
(43, 14, 'A'),
(44, 8, 'A'),
(44, 14, 'A'),
(44, 19, 'A'),
(47, 8, 'A'),
(47, 14, 'A'),
(47, 18, 'C'),
(47, 19, 'A'),
(47, 26, 'C'),
(48, 19, 'A'),
(48, 26, 'C'),
(49, 18, 'A');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
