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
-- Table structure for table `questions`
--

CREATE TABLE IF NOT EXISTS `questions` (
  `question_id` int(11) NOT NULL AUTO_INCREMENT,
  `exam_id` int(11) NOT NULL,
  `question` varchar(200) NOT NULL,
  `option_a` varchar(100) NOT NULL,
  `option_b` varchar(100) NOT NULL,
  `option_c` varchar(100) NOT NULL,
  `option_d` varchar(100) NOT NULL,
  `answer` char(1) NOT NULL,
  `difficulty_level` enum('Average','Difficult') NOT NULL DEFAULT 'Average',
  PRIMARY KEY (`question_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=101 ;

--
-- Dumping data for table `questions`
--

INSERT INTO `questions` (`question_id`, `exam_id`, `question`, `option_a`, `option_b`, `option_c`, `option_d`, `answer`, `difficulty_level`) VALUES
(9, 8, 'What is the meaning of phony?', 'Irritating', 'Phone', 'Fake', 'Nervous', 'C', 'Average'),
(10, 8, 'What is the capital of United States?', 'Washington', 'Wasinhton D.C', 'Newyork', 'Caifornia', 'B', 'Difficult'),
(15, 14, 'Test 1 Avg', 'A', 'B', 'C', 'D', 'A', 'Average'),
(16, 14, 'Test 2 Avg', 'A', 'B', 'C', 'D', 'B', 'Difficult'),
(29, 18, 'What is cake?', 'Vanilla', 'Chocolate', 'Birthday', 'Marble', 'B', 'Difficult'),
(30, 18, 'Meaning of life?', '39', '4', '41', '42', 'D', 'Average'),
(31, 19, 'Avg Ques', 'a', 'b', 'c', 'd', 'A', 'Average'),
(32, 19, 'Avg QUestion', 'a', 'b', 'c', 'd', 'A', 'Average'),
(33, 19, 'Avg Question', 'a', 'b', 'c', 'd', 'A', 'Average'),
(34, 19, 'Avh Question', 'a', 'b', 'c', 'd', 'A', 'Average'),
(35, 19, 'Avg Quesion', 'a', 'b', 'c', 'd', 'A', 'Average'),
(36, 19, 'Diff question', 'a', 'b', 'c', 'd', 'B', 'Difficult'),
(37, 19, 'Diff Ques', 'a', 'b', 'c', 'd', 'B', 'Difficult'),
(38, 19, 'diff question', 'a', 'b', 'c', 'd', 'B', 'Difficult'),
(39, 19, 'diff question\ndiff question\n', 'a', 'b', 'c', 'd', 'B', 'Difficult'),
(40, 19, 'diff question\ndiff question\n', 'a', 'b', 'c', 'd', 'B', 'Difficult'),
(57, 20, 'Last Row', 'a', 'b', 'c', 'd', 'B', 'Average'),
(61, 20, 'Del', '45555', 'ss', 'd', '3', 'D', 'Difficult'),
(63, 20, 'final', 're', 'dsSDS', 'fg', 'df', 'A', 'Average'),
(64, 20, 'sdsfdsfs', 'sdf', 'wefwf', 'ff', 'ddd', 'B', 'Difficult'),
(65, 23, 'dddd', '2', '345', '', '5', 'A', 'Difficult'),
(66, 23, 'Which of the following is a color?', 'Apple', 'Blue', 'Sky', 'Road', 'B', 'Average'),
(67, 23, 'What is the currency of India?', 'INR', 'IND', 'INC', 'INS', 'A', 'Difficult'),
(70, 26, 'Which of the following is true about expression switch statement in Go?', 'The expression used in a switc', 'If expression is not passed th', 'If expression is passed th', 'All of the above.', 'D', 'Average'),
(72, 26, 'Which of the following is correct about nil pointer in Go?', 'Go compiler assign a Nil value', 'Nil value assignment is done a', 'A pointer that is assigned nil', 'All of the above.', 'D', 'Difficult'),
(73, 26, 'Which of the following is correct about slices in Go?', 'Go Slice uses array as an unde', 'len() function returns the last element ', 'cap() function returns the cap', 'All of the above.', 'D', 'Average'),
(74, 26, 'Which of the following is correct about interfaces in Go?', 'Go programming provides anothe', 'struct data type implements th', 'Both of the above.', 'None of the above.', 'C', 'Average'),
(77, 26, 'Who introduced Golang?', 'Google', 'Apple', 'Microsoft', 'HTC', 'A', 'Difficult'),
(78, 25, 'What is ?', 'Question Mark', 'Dot', 'Comma', 'Apostrophe', 'A', 'Average'),
(79, 26, 'Which of the following is true about Go programming language?', 'Programs are constructed using', 'Go programming implementations', 'Both of the above.', 'None of the above.', 'C', 'Difficult'),
(81, 26, '2+2', '4', '5', '6', '7', 'A', 'Difficult'),
(82, 26, '1+1', '2', '3', '4', '6', 'A', 'Average'),
(89, 18, 'If a code is not tested, it is?', 'Fine', 'Probable Fine', 'Good', 'Broken', 'D', 'Average'),
(92, 18, 'What does DRY stands for?', 'Do Repeat Yourself', 'I dont know', 'Dont Repeat Yourself', 'None', 'C', 'Difficult'),
(93, 25, '1', '11', '12', '13', '14', 'A', 'Average'),
(95, 25, '3', '31', '32', '33', '34', 'C', 'Difficult'),
(96, 25, '2', '21', '22', '23', '24', 'B', 'Difficult'),
(99, 18, 'Who intoduced go?', 'Google', 'Microsoft', 'Apple', 'HTC', 'A', 'Average'),
(100, 18, 'What is 1+1?', 'I dont know', '2', '1', '27', 'B', 'Difficult');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
