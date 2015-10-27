-- phpMyAdmin SQL Dump
-- version 4.2.11
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Apr 10, 2015 at 07:34 PM
-- Server version: 5.6.21
-- PHP Version: 5.6.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `tabletennisranking`
--

-- --------------------------------------------------------

--
-- Table structure for table `calculations`
--

CREATE TABLE IF NOT EXISTS `calculations` (
`Id` int(11) NOT NULL,
  `type` text NOT NULL,
  `weight` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `championships`
--

CREATE TABLE IF NOT EXISTS `championships` (
`Id` int(11) NOT NULL,
  `Name` text NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `championships`
--

INSERT INTO `championships` (`Id`, `Name`) VALUES
(1, 'Campeonato Regional Madeira 1ª Divisão');

-- --------------------------------------------------------

--
-- Table structure for table `clubs`
--

CREATE TABLE IF NOT EXISTS `clubs` (
`Id` int(11) NOT NULL,
  `Name` text NOT NULL,
  `Photo` text NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `clubs`
--

INSERT INTO `clubs` (`Id`, `Name`, `Photo`) VALUES
(1, 'Clube Desportivo Santa Rita', ''),
(2, 'Clube Desportivo São Roque', ''),
(3, 'Grupo Desportivo Estreito', ''),
(4, 'Desportivo Machico', ''),
(5, 'ACM Madeira', ''),
(6, 'ADC Ponta do Pargo', ''),
(7, 'AD Galomar', ''),
(8, 'CD 1º Maio', ''),
(9, 'Sporting C. Madeira', ''),
(10, 'CTM Funchal', ''),
(11, 'AD Caramanchao', '');

-- --------------------------------------------------------

--
-- Table structure for table `games`
--

CREATE TABLE IF NOT EXISTS `games` (
`id` int(11) NOT NULL,
  `IdPlayerA` int(11) NOT NULL,
  `IdPlayerB` int(11) NOT NULL,
  `SetsA` int(11) NOT NULL,
  `SetsB` int(11) NOT NULL,
  `IdPlayerWinner` int(11) NOT NULL,
  `Date` date NOT NULL,
  `IdChamp` int(11) NOT NULL,
  `IdCalculation` int(11) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `games`
--

INSERT INTO `games` (`id`, `IdPlayerA`, `IdPlayerB`, `SetsA`, `SetsB`, `IdPlayerWinner`, `Date`, `IdChamp`, `IdCalculation`) VALUES
(4, 5, 7, 1, 3, 7, '2014-10-25', 1, 0),
(5, 3, 9, 3, 0, 3, '2014-10-25', 1, 0),
(6, 6, 8, 2, 3, 8, '2014-10-25', 1, 0),
(7, 5, 9, 3, 0, 5, '2014-10-25', 1, 0),
(8, 5, 9, 3, 0, 5, '2014-10-25', 1, 0),
(9, 5, 9, 3, 0, 5, '2014-10-25', 1, 0);

-- --------------------------------------------------------

--
-- Table structure for table `player`
--

CREATE TABLE IF NOT EXISTS `player` (
`Id` int(11) NOT NULL,
  `Name` text NOT NULL,
  `BirthDate` date NOT NULL,
  `IdClub` int(11) NOT NULL,
  `Gender` text NOT NULL,
  `Photo` text NOT NULL,
  `currentPoints` int(11) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `player`
--

INSERT INTO `player` (`Id`, `Name`, `BirthDate`, `IdClub`, `Gender`, `Photo`, `currentPoints`) VALUES
(1, 'Joao Santos', '1987-01-01', 1, 'Male', '', 1000),
(3, 'Clife Abreu', '1900-01-01', 3, 'Male', '', 1008),
(4, 'João Freitas', '1900-01-01', 3, 'Male', '', 1000),
(5, 'José Ferreira', '1900-01-01', 3, 'Male', '', 1014),
(6, 'Fabio Almada', '1900-01-01', 3, 'Male', '', 992),
(7, 'Paulo Fernandes', '1900-01-01', 4, 'Male', '', 1008),
(8, 'João Martins', '1900-01-01', 4, 'Male', '', 1008),
(9, 'Flavio Ferreira', '1900-01-01', 4, 'Male', '', 970);

-- --------------------------------------------------------

--
-- Table structure for table `playerchamps`
--

CREATE TABLE IF NOT EXISTS `playerchamps` (
`Id` int(11) NOT NULL,
  `Date` date NOT NULL,
  `IdPlayer` int(11) NOT NULL,
  `IdChamp` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `playerclubs`
--

CREATE TABLE IF NOT EXISTS `playerclubs` (
  `Id` int(11) NOT NULL,
  `Date` date NOT NULL,
  `IdPlayer` int(11) NOT NULL,
  `IdClub` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `pointsbreakdown`
--

CREATE TABLE IF NOT EXISTS `pointsbreakdown` (
`Id` int(11) NOT NULL,
  `Date` date NOT NULL,
  `IdPlayer` int(11) NOT NULL,
  `Points` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `ratingchart`
--

CREATE TABLE IF NOT EXISTS `ratingchart` (
`Id` int(11) NOT NULL,
  `PointDifBelow` int(11) NOT NULL,
  `PointDifHigh` int(11) NOT NULL,
  `ExpectedResultPoints` int(11) NOT NULL,
  `UnexpectedResultPoints` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `calculations`
--
ALTER TABLE `calculations`
 ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `championships`
--
ALTER TABLE `championships`
 ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `clubs`
--
ALTER TABLE `clubs`
 ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `games`
--
ALTER TABLE `games`
 ADD PRIMARY KEY (`id`);

--
-- Indexes for table `player`
--
ALTER TABLE `player`
 ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `playerchamps`
--
ALTER TABLE `playerchamps`
 ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `pointsbreakdown`
--
ALTER TABLE `pointsbreakdown`
 ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `ratingchart`
--
ALTER TABLE `ratingchart`
 ADD PRIMARY KEY (`Id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `calculations`
--
ALTER TABLE `calculations`
MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `championships`
--
ALTER TABLE `championships`
MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `clubs`
--
ALTER TABLE `clubs`
MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=12;
--
-- AUTO_INCREMENT for table `games`
--
ALTER TABLE `games`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=10;
--
-- AUTO_INCREMENT for table `player`
--
ALTER TABLE `player`
MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=10;
--
-- AUTO_INCREMENT for table `playerchamps`
--
ALTER TABLE `playerchamps`
MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `pointsbreakdown`
--
ALTER TABLE `pointsbreakdown`
MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `ratingchart`
--
ALTER TABLE `ratingchart`
MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
