-- phpMyAdmin SQL Dump
-- version 4.0.10deb1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Dec 04, 2017 at 11:48 PM
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
-- Table structure for table `exams`
--

CREATE TABLE IF NOT EXISTS `exams` (
  `exam_id` int(11) NOT NULL AUTO_INCREMENT,
  `exam_title` varchar(30) NOT NULL,
  `no_of_questions` int(11) NOT NULL,
  `status` varchar(20) NOT NULL DEFAULT 'Inactive',
  `data_created` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `created_by` varchar(20) NOT NULL,
  `timer_enabled` tinyint(1) NOT NULL,
  `timer_duration` int(11) NOT NULL,
  PRIMARY KEY (`exam_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=27 ;

--
-- Dumping data for table `exams`
--

INSERT INTO `exams` (`exam_id`, `exam_title`, `no_of_questions`, `status`, `data_created`, `created_by`, `timer_enabled`, `timer_duration`) VALUES
(8, 'Exam 5', 1, 'Complete', '2017-11-12 18:16:08', 'admin', 0, 0),
(14, 'Exam 6', 1, 'Active', '2017-11-13 00:20:19', 'admin', 0, 0),
(18, 'Software Engg Exam', 3, 'Active', '2017-11-14 01:20:43', 'admin', 0, 0),
(19, 'Test Exam', 5, 'Active', '2017-11-19 14:36:03', 'admin', 0, 0),
(20, 'Exam to be Modified 2', 2, 'Complete', '2017-11-20 18:27:23', 'admin', 1, 10),
(25, 'Test 2', 2, 'Inactive', '2017-12-01 01:34:06', 'admin', 0, 0),
(26, 'Golang - Basics', 4, 'Active', '2017-12-03 16:15:54', 'admin', 0, 0);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
