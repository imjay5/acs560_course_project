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
-- Table structure for table `user_details`
--

CREATE TABLE IF NOT EXISTS `user_details` (
  `user_id` int(5) NOT NULL AUTO_INCREMENT,
  `name` varchar(30) NOT NULL,
  `email` varchar(30) NOT NULL,
  `password` varchar(30) NOT NULL,
  `exam_id` int(5) NOT NULL,
  `grade` varchar(2) DEFAULT NULL,
  `admin_key` tinyint(1) NOT NULL DEFAULT '0',
  PRIMARY KEY (`user_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=50 ;

--
-- Dumping data for table `user_details`
--

INSERT INTO `user_details` (`user_id`, `name`, `email`, `password`, `exam_id`, `grade`, `admin_key`) VALUES
(1, 'admin', 'admin', 'QWRtaW4xMjMq', 1, 'A', 1),
(37, 'user21', 'user21@mail.com', 'VXNlcjEyMyo=', 0, NULL, 0),
(38, 'user23', 'user23@mail.com', 'VXNlcjQ1Nio=', 0, NULL, 0),
(39, 'User24', 'user24@mail.com', 'MjRVc2VyKjE=', 0, NULL, 0),
(40, 'user25', 'user25@mail.com', 'VXNlcjEyMyo=', 0, NULL, 0),
(42, 'User28', 'user28@mail.com', 'QWRtaW4xMjMq', 0, NULL, 0),
(47, 'user32', 'User32@mail.com', 'VXNlcjEyMyo=', 0, NULL, 0),
(48, 'Jay', 'harifrndz05@gmail.com', 'SVBGVzEyMyo=', 0, NULL, 0),
(49, 'George', 'washington@virginia.us', 'VXNlcjEyMyo=', 0, NULL, 0);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
