-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 21, 2022 at 04:38 PM
-- Server version: 10.4.19-MariaDB
-- PHP Version: 7.4.20

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_projek_pcs`
--
CREATE DATABASE IF NOT EXISTS `db_projek_pcs` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `db_projek_pcs`;

-- --------------------------------------------------------

--
-- Table structure for table `format`
--

DROP TABLE IF EXISTS `format`;
CREATE TABLE `format` (
  `ID` varchar(10) NOT NULL,
  `NAME` varchar(150) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `format`
--

INSERT INTO `format` (`ID`, `NAME`) VALUES
('1', 'CD'),
('2', 'Vinyl'),
('3', 'Cassette'),
('4', 'Digital File');

--
-- Triggers `format`
--
DROP TRIGGER IF EXISTS `TR_Format_1`;
DELIMITER $$
CREATE TRIGGER `TR_Format_1` BEFORE DELETE ON `format` FOR EACH ROW BEGIN
	DECLARE EXIT HANDLER FOR SQLSTATE '45000'
		  BEGIN
		   RESIGNAL SET MESSAGE_TEXT = 'Terdapat produk dengan format ini !';
		  END;
		  
	IF (old.id IN (SELECT fp.`FORMAT_ID` FROM format_product fp WHERE fp.`FORMAT_ID` = old.id)) THEN
		SIGNAL SQLSTATE '45000';
	END IF;
    END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `format_product`
--

DROP TABLE IF EXISTS `format_product`;
CREATE TABLE `format_product` (
  `ID` varchar(10) NOT NULL,
  `PRODUCT_ID` varchar(10) NOT NULL,
  `FORMAT_ID` varchar(10) NOT NULL,
  `STOCK` int(11) NOT NULL,
  `PRICE` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `format_product`
--

INSERT INTO `format_product` (`ID`, `PRODUCT_ID`, `FORMAT_ID`, `STOCK`, `PRICE`) VALUES
('1', '2', '1', 50, 250000),
('2', '1', '4', 150, 25000);

-- --------------------------------------------------------

--
-- Table structure for table `genre`
--

DROP TABLE IF EXISTS `genre`;
CREATE TABLE `genre` (
  `ID` varchar(5) NOT NULL,
  `NAME` varchar(150) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `genre`
--

INSERT INTO `genre` (`ID`, `NAME`) VALUES
('1', 'Pop'),
('10', 'Lo-Fi'),
('11', 'Anime'),
('2', 'Rock & Roll'),
('3', 'Jazz'),
('4', 'J-Pop'),
('5', 'K-Pop'),
('6', 'Country'),
('7', 'Classic'),
('8', 'Electronic'),
('9', 'Techno');

--
-- Triggers `genre`
--
DROP TRIGGER IF EXISTS `TR_Genre_1`;
DELIMITER $$
CREATE TRIGGER `TR_Genre_1` BEFORE DELETE ON `genre` FOR EACH ROW BEGIN
	DECLARE EXIT HANDLER FOR SQLSTATE '45000'
		  BEGIN
		   RESIGNAL SET MESSAGE_TEXT = 'Terdapat lagu yang bergenre ini !';
		  END;
		  
	IF (old.id IN (SELECT s.`GENRE_ID` FROM songs s WHERE s.`GENRE_ID` = old.id)) THEN
		SIGNAL SQLSTATE '45000';
	END IF;
    END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `group_music`
--

DROP TABLE IF EXISTS `group_music`;
CREATE TABLE `group_music` (
  `id` varchar(10) NOT NULL,
  `name` varchar(150) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `group_music`
--

INSERT INTO `group_music` (`id`, `name`) VALUES
('1', 'Group_Moona_1'),
('2', 'Group_Towa_1'),
('3', 'Group_Towa_2'),
('4', 'Group_Towa_3'),
('5', 'Group_Towa_4'),
('6', 'Group_Towa_5'),
('7', 'Group_Fubuki_1');

--
-- Triggers `group_music`
--
DROP TRIGGER IF EXISTS `TR_Group_1`;
DELIMITER $$
CREATE TRIGGER `TR_Group_1` BEFORE DELETE ON `group_music` FOR EACH ROW BEGIN
	DECLARE EXIT HANDLER FOR SQLSTATE '45000'
		  BEGIN
		   RESIGNAL SET MESSAGE_TEXT = 'Group ini pernah membuat lagu sebelumnya !';
		  END;
		  
	IF (old.id IN (SELECT s.`GROUP_ID` FROM songs s  WHERE s.`GROUP_ID` = old.id)) THEN
		SIGNAL SQLSTATE '45000';
	END IF;
    END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `group_personel`
--

DROP TABLE IF EXISTS `group_personel`;
CREATE TABLE `group_personel` (
  `ID` varchar(10) NOT NULL,
  `GROUP_ID` varchar(10) NOT NULL,
  `PERSONEL_ID` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `group_personel`
--

INSERT INTO `group_personel` (`ID`, `GROUP_ID`, `PERSONEL_ID`) VALUES
('10', '4', '6'),
('11', '4', '9'),
('12', '5', '6'),
('13', '5', '10'),
('14', '6', '6'),
('15', '6', '11'),
('16', '7', '12'),
('6', '2', '6'),
('7', '2', '7'),
('8', '3', '6'),
('9', '3', '8');

-- --------------------------------------------------------

--
-- Table structure for table `member`
--

DROP TABLE IF EXISTS `member`;
CREATE TABLE `member` (
  `ID` varchar(10) NOT NULL,
  `NAME` varchar(150) NOT NULL,
  `USERNAME` varchar(150) NOT NULL,
  `PASSWORD` varchar(250) NOT NULL,
  `GENDER` varchar(1) NOT NULL,
  `ADDRESS` varchar(250) NOT NULL,
  `DATE_OF_BIRTH` date NOT NULL,
  `MEMBERSHIP_ID` varchar(10) DEFAULT NULL,
  `MEMBERSHIP_EXP` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `member`
--

INSERT INTO `member` (`ID`, `NAME`, `USERNAME`, `PASSWORD`, `GENDER`, `ADDRESS`, `DATE_OF_BIRTH`, `MEMBERSHIP_ID`, `MEMBERSHIP_EXP`) VALUES
('1', 'John Doe', 'John1', 'abc123', 'L', 'Jalan Mawar no. 10, Surabaya, Jawa Timur, Indonesia', '2000-05-12', '1', '2022-08-01');

-- --------------------------------------------------------

--
-- Table structure for table `membership`
--

DROP TABLE IF EXISTS `membership`;
CREATE TABLE `membership` (
  `ID` varchar(10) NOT NULL,
  `NAME` varchar(150) NOT NULL,
  `DISCOUNT` int(11) NOT NULL,
  `EXP_LENGTH` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `membership`
--

INSERT INTO `membership` (`ID`, `NAME`, `DISCOUNT`, `EXP_LENGTH`) VALUES
('1', 'Bronze', 2, 3),
('2', 'Silver', 5, 3),
('3', 'Gold', 10, 6),
('4', 'Platinum', 15, 6),
('5', 'Diamond', 25, 12);

--
-- Triggers `membership`
--
DROP TRIGGER IF EXISTS `TR_Membership_1`;
DELIMITER $$
CREATE TRIGGER `TR_Membership_1` BEFORE DELETE ON `membership` FOR EACH ROW BEGIN
	DECLARE EXIT HANDLER FOR SQLSTATE '45000'
		  BEGIN
		   RESIGNAL SET MESSAGE_TEXT = 'Terdapat member yang memunyai membership jenis ini !';
		  END;
		  
	IF (old.id IN (SELECT m.membership_id FROM member m WHERE m.membership_id = old.id)) THEN
		SIGNAL SQLSTATE '45000';
	END IF;
    END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `occupation`
--

DROP TABLE IF EXISTS `occupation`;
CREATE TABLE `occupation` (
  `ID` varchar(10) NOT NULL,
  `NAME` varchar(150) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `occupation`
--

INSERT INTO `occupation` (`ID`, `NAME`) VALUES
('1', 'Artist'),
('2', 'Songwriter'),
('3', 'Illustrator'),
('4', 'Animator'),
('5', 'Mixer'),
('6', 'Producer'),
('7', 'Arranger');

--
-- Triggers `occupation`
--
DROP TRIGGER IF EXISTS `TR_Occupation_1`;
DELIMITER $$
CREATE TRIGGER `TR_Occupation_1` BEFORE DELETE ON `occupation` FOR EACH ROW BEGIN
	DECLARE EXIT HANDLER FOR SQLSTATE '45000'
		  BEGIN
		   RESIGNAL SET MESSAGE_TEXT = 'Terdapat personel yang bekerja sebagai posisi ini !';
		  END;
		  
	IF (old.id IN (SELECT p.`OCCUPATION_ID` FROM personel p WHERE p.`OCCUPATION_ID` = old.id)) THEN
		SIGNAL SQLSTATE '45000';
	END IF;
    END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `orderdetails`
--

DROP TABLE IF EXISTS `orderdetails`;
CREATE TABLE `orderdetails` (
  `NOTE_NUMBER` varchar(15) NOT NULL,
  `PRODUCT_ID` varchar(10) NOT NULL,
  `QUANTITY` int(11) NOT NULL,
  `SUBTOTAL` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `orderdetails`
--

INSERT INTO `orderdetails` (`NOTE_NUMBER`, `PRODUCT_ID`, `QUANTITY`, `SUBTOTAL`) VALUES
('NOTE20211123', '1', 2, 100000);

-- --------------------------------------------------------

--
-- Table structure for table `orders`
--

DROP TABLE IF EXISTS `orders`;
CREATE TABLE `orders` (
  `NOTE_NUMBER` varchar(15) NOT NULL,
  `ORDER_DATE` date NOT NULL,
  `MEMBER_ID` varchar(10) NOT NULL,
  `STAFF_ID` varchar(10) DEFAULT NULL,
  `STATUS` varchar(50) NOT NULL,
  `PAYMENT_METHOD` varchar(50) NOT NULL,
  `TOTAL` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `orders`
--

INSERT INTO `orders` (`NOTE_NUMBER`, `ORDER_DATE`, `MEMBER_ID`, `STAFF_ID`, `STATUS`, `PAYMENT_METHOD`, `TOTAL`) VALUES
('NOTE20211123', '2021-11-23', '1', '1', 'DELIVERED', '1', 98000);

-- --------------------------------------------------------

--
-- Table structure for table `payment_method`
--

DROP TABLE IF EXISTS `payment_method`;
CREATE TABLE `payment_method` (
  `ID` varchar(10) NOT NULL,
  `NAME` varchar(150) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `personel`
--

DROP TABLE IF EXISTS `personel`;
CREATE TABLE `personel` (
  `ID` varchar(10) NOT NULL,
  `NAME` varchar(150) NOT NULL,
  `COUNTRY` varchar(150) NOT NULL,
  `GENDER` varchar(1) NOT NULL,
  `OCCUPATION_ID` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `personel`
--

INSERT INTO `personel` (`ID`, `NAME`, `COUNTRY`, `GENDER`, `OCCUPATION_ID`) VALUES
('1', 'Moona Hoshinova', 'Indonesia', 'P', '1'),
('10', 'ANCHOR', 'Japan', 'L', '7'),
('11', '鬱P', 'Japan', 'L', '7'),
('12', 'Shirakami Fubuki', 'Japan', 'P', '1'),
('2', 'ZSunder', 'Philippines', 'L', '2'),
('3', 'Furaisen', 'Malaysia', 'L', '3'),
('4', 'Rumskii', 'Indonesia', 'P', '4'),
('5', 'lemonade', 'Indonesia', 'L', '4'),
('6', 'Tokoyami Towa', 'Japan', 'P', '1'),
('7', 'すりぃ', 'JAPAN', 'L', '7'),
('8', 'R Sound Design', 'Japan', 'L', '2'),
('9', 'niki', 'Japan', 'L', '7');

--
-- Triggers `personel`
--
DROP TRIGGER IF EXISTS `TR_Personel_1`;
DELIMITER $$
CREATE TRIGGER `TR_Personel_1` BEFORE DELETE ON `personel` FOR EACH ROW BEGIN
	DECLARE EXIT HANDLER FOR SQLSTATE '45000'
		  BEGIN
		   RESIGNAL SET MESSAGE_TEXT = 'Personel ini masih aktif !';
		  END;
		  
	IF (old.id IN (SELECT gp.`PERSONEL_ID`  FROM group_personel gp WHERE gp.`PERSONEL_ID` = old.id)) THEN
		SIGNAL SQLSTATE '45000';
	END IF;
    END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `product`
--

DROP TABLE IF EXISTS `product`;
CREATE TABLE `product` (
  `ID` varchar(10) NOT NULL,
  `NAME` varchar(150) NOT NULL,
  `RELEASE_DATE` datetime NOT NULL,
  `RATING` double NOT NULL,
  `DESCRIPTION` varchar(250) NOT NULL,
  `TYPE_ID` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `product`
--

INSERT INTO `product` (`ID`, `NAME`, `RELEASE_DATE`, `RATING`, `DESCRIPTION`, `TYPE_ID`) VALUES
('1', 'High Tide Single', '2022-02-17 00:00:00', 4.8, 'A single composed of High Tide, the second original song of Moona Hoshinova', '1'),
('2', 'Scream', '2022-01-04 00:00:00', 0, 'Tokoyami Towa\'s first EP to be released.', '2'),
('3', 'KINGWORLD Single', '2022-06-21 00:00:00', 0, 'KINGWORLD is the second single released by Shirakami Fubuki', '1');

-- --------------------------------------------------------

--
-- Table structure for table `product_song`
--

DROP TABLE IF EXISTS `product_song`;
CREATE TABLE `product_song` (
  `ID` varchar(10) NOT NULL,
  `PRODUCT_ID` varchar(10) NOT NULL,
  `SONG_ID` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `product_song`
--

INSERT INTO `product_song` (`ID`, `PRODUCT_ID`, `SONG_ID`) VALUES
('1', '1', '1'),
('2', '2', '2'),
('3', '2', '3'),
('4', '2', '4'),
('5', '2', '5'),
('6', '2', '6'),
('7', '2', '7'),
('9', '3', '8');

-- --------------------------------------------------------

--
-- Table structure for table `review_product`
--

DROP TABLE IF EXISTS `review_product`;
CREATE TABLE `review_product` (
  `ID` varchar(10) NOT NULL,
  `PRODUCT_ID` varchar(10) NOT NULL,
  `MEMBER_ID` varchar(10) NOT NULL,
  `REVIEW_DATE` date NOT NULL,
  `RATING` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `review_product`
--

INSERT INTO `review_product` (`ID`, `PRODUCT_ID`, `MEMBER_ID`, `REVIEW_DATE`, `RATING`) VALUES
('1', '1', '1', '2022-04-29', 4.8);

-- --------------------------------------------------------

--
-- Table structure for table `review_song`
--

DROP TABLE IF EXISTS `review_song`;
CREATE TABLE `review_song` (
  `ID` varchar(10) NOT NULL,
  `SONG_ID` varchar(10) NOT NULL,
  `MEMBER_ID` varchar(10) NOT NULL,
  `REVIEW_DATE` date NOT NULL,
  `RATING` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `review_song`
--

INSERT INTO `review_song` (`ID`, `SONG_ID`, `MEMBER_ID`, `REVIEW_DATE`, `RATING`) VALUES
('1', '1', '1', '2022-04-20', 4.8);

-- --------------------------------------------------------

--
-- Table structure for table `shopping_cart`
--

DROP TABLE IF EXISTS `shopping_cart`;
CREATE TABLE `shopping_cart` (
  `ID` varchar(10) NOT NULL,
  `PRODUCT_ID` varchar(10) NOT NULL,
  `MEMBER_ID` varchar(10) NOT NULL,
  `QUANTITY` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `songs`
--

DROP TABLE IF EXISTS `songs`;
CREATE TABLE `songs` (
  `ID` varchar(10) NOT NULL,
  `NAME` varchar(150) NOT NULL,
  `RELEASE_DATE` datetime NOT NULL,
  `GROUP_ID` varchar(10) NOT NULL,
  `GENRE_ID` varchar(10) NOT NULL,
  `LENGTH` int(11) NOT NULL,
  `DESCRIPTION` varchar(250) NOT NULL,
  `RATING` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `songs`
--

INSERT INTO `songs` (`ID`, `NAME`, `RELEASE_DATE`, `GROUP_ID`, `GENRE_ID`, `LENGTH`, `DESCRIPTION`, `RATING`) VALUES
('1', 'High Tide', '2022-02-17 00:00:00', '1', '4', 202, 'Second original song from Moona Hoshinova, with heavy tone of a LoL song in it.', 4.8),
('2', 'Akuma', '2022-01-03 00:00:00', '2', '4', 209, 'The first track in Towa\'s first EP, Scream', 0),
('3', 'Midnight Runaway', '2022-01-03 00:00:00', '3', '4', 209, 'The second track in Towa\'s first EP, Scream.', 0),
('4', 'Pallete', '2021-02-17 00:00:00', '4', '4', 215, 'Tokoyami Towa\'s first original song.', 0),
('5', 'Fact', '2022-01-03 00:00:00', '4', '4', 195, 'Tokoyami Towa\'s second original song to be made MV.', 0),
('6', 'Born to be Real', '2022-01-03 00:00:00', '5', '4', 207, 'The fifth track in Towa\'s first EP, Scream', 0),
('7', 'My Roar', '2022-01-03 00:00:00', '6', '4', 218, 'The sixth track in Towa\'s first EP, Scream', 0),
('8', 'KINGWORLD', '2022-06-03 00:00:00', '7', '4', 216, 'Shirakami Fubuki\'s second original song. Released on June 3rd, 2022', 0);

--
-- Triggers `songs`
--
DROP TRIGGER IF EXISTS `TR_Song_1`;
DELIMITER $$
CREATE TRIGGER `TR_Song_1` BEFORE DELETE ON `songs` FOR EACH ROW BEGIN
	DECLARE EXIT HANDLER FOR SQLSTATE '45000'
		  BEGIN
		   RESIGNAL SET MESSAGE_TEXT = 'Lagu ini pernah menjadi bagian produk sebelumnya !';
		  END;
		  
	IF (old.id IN (SELECT ps.`SONG_ID` FROM product_song ps  WHERE ps.`SONG_ID` = old.id)) THEN
		SIGNAL SQLSTATE '45000';
	END IF;
    END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `staff`
--

DROP TABLE IF EXISTS `staff`;
CREATE TABLE `staff` (
  `ID` varchar(10) NOT NULL,
  `NAME` varchar(150) NOT NULL,
  `USERNAME` varchar(150) NOT NULL,
  `PASSWORD` varchar(250) NOT NULL,
  `ADDRESS` varchar(150) NOT NULL,
  `GENDER` varchar(1) NOT NULL,
  `DATE_OF_BIRTH` date NOT NULL,
  `STATUS` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `staff`
--

INSERT INTO `staff` (`ID`, `NAME`, `USERNAME`, `PASSWORD`, `ADDRESS`, `GENDER`, `DATE_OF_BIRTH`, `STATUS`) VALUES
('1', 'Eugene Bush', 'Staff#1', '123456', 'Jalan Lorem no 69, Surabaya, Jawa Timur, Indonesia', 'L', '1997-05-09', 1);

--
-- Triggers `staff`
--
DROP TRIGGER IF EXISTS `TR_Staff_1`;
DELIMITER $$
CREATE TRIGGER `TR_Staff_1` BEFORE DELETE ON `staff` FOR EACH ROW BEGIN
	DECLARE EXIT HANDLER FOR SQLSTATE '45000'
		  BEGIN
		   RESIGNAL SET MESSAGE_TEXT = 'Staff sudah pernah menangani order sehingga staff tidak bisa di-delete !';
		  END;
	
	if (old.id in (select staff_id from orders o where o.staff_id = old.id)) then
		SIGNAL SQLSTATE '45000';
	end if;
    END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `type_product`
--

DROP TABLE IF EXISTS `type_product`;
CREATE TABLE `type_product` (
  `ID` varchar(5) NOT NULL,
  `TYPE_NAME` varchar(150) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `type_product`
--

INSERT INTO `type_product` (`ID`, `TYPE_NAME`) VALUES
('1', 'Single'),
('2', 'EP'),
('3', 'Album');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `format`
--
ALTER TABLE `format`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `format_product`
--
ALTER TABLE `format_product`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `fk_format_product_1` (`PRODUCT_ID`),
  ADD KEY `fk_format_product_2` (`FORMAT_ID`);

--
-- Indexes for table `genre`
--
ALTER TABLE `genre`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `group_music`
--
ALTER TABLE `group_music`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `group_personel`
--
ALTER TABLE `group_personel`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `fkPersonel_Group` (`GROUP_ID`),
  ADD KEY `fkPersonel_Personel` (`PERSONEL_ID`);

--
-- Indexes for table `member`
--
ALTER TABLE `member`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `fk_member_membership` (`MEMBERSHIP_ID`);

--
-- Indexes for table `membership`
--
ALTER TABLE `membership`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `occupation`
--
ALTER TABLE `occupation`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `personel`
--
ALTER TABLE `personel`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `fkPersonel` (`OCCUPATION_ID`);

--
-- Indexes for table `product`
--
ALTER TABLE `product`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `fk_product_type` (`TYPE_ID`);

--
-- Indexes for table `product_song`
--
ALTER TABLE `product_song`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `fk_product_song_1` (`PRODUCT_ID`),
  ADD KEY `fk_product_song_2` (`SONG_ID`);

--
-- Indexes for table `review_product`
--
ALTER TABLE `review_product`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `fk_review_product` (`PRODUCT_ID`),
  ADD KEY `fk_review_member` (`MEMBER_ID`);

--
-- Indexes for table `review_song`
--
ALTER TABLE `review_song`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `fk_review_2_song` (`SONG_ID`),
  ADD KEY `fk_review_2_member` (`MEMBER_ID`);

--
-- Indexes for table `shopping_cart`
--
ALTER TABLE `shopping_cart`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `fk_cart_member` (`MEMBER_ID`),
  ADD KEY `fk_cart_product` (`PRODUCT_ID`);

--
-- Indexes for table `songs`
--
ALTER TABLE `songs`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `fk_song_group` (`GROUP_ID`),
  ADD KEY `fk_song_genre` (`GENRE_ID`);

--
-- Indexes for table `staff`
--
ALTER TABLE `staff`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `type_product`
--
ALTER TABLE `type_product`
  ADD PRIMARY KEY (`ID`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `format_product`
--
ALTER TABLE `format_product`
  ADD CONSTRAINT `fk_format_product_1` FOREIGN KEY (`PRODUCT_ID`) REFERENCES `product` (`ID`),
  ADD CONSTRAINT `fk_format_product_2` FOREIGN KEY (`FORMAT_ID`) REFERENCES `format` (`ID`);

--
-- Constraints for table `group_personel`
--
ALTER TABLE `group_personel`
  ADD CONSTRAINT `fkPersonel_Group` FOREIGN KEY (`GROUP_ID`) REFERENCES `group_music` (`id`),
  ADD CONSTRAINT `fkPersonel_Personel` FOREIGN KEY (`PERSONEL_ID`) REFERENCES `personel` (`ID`);

--
-- Constraints for table `member`
--
ALTER TABLE `member`
  ADD CONSTRAINT `fk_member_membership` FOREIGN KEY (`MEMBERSHIP_ID`) REFERENCES `membership` (`ID`);

--
-- Constraints for table `personel`
--
ALTER TABLE `personel`
  ADD CONSTRAINT `fkPersonel` FOREIGN KEY (`OCCUPATION_ID`) REFERENCES `occupation` (`id`);

--
-- Constraints for table `product`
--
ALTER TABLE `product`
  ADD CONSTRAINT `fk_product_type` FOREIGN KEY (`TYPE_ID`) REFERENCES `type_product` (`id`);

--
-- Constraints for table `product_song`
--
ALTER TABLE `product_song`
  ADD CONSTRAINT `fk_product_song_1` FOREIGN KEY (`PRODUCT_ID`) REFERENCES `product` (`ID`),
  ADD CONSTRAINT `fk_product_song_2` FOREIGN KEY (`SONG_ID`) REFERENCES `songs` (`ID`);

--
-- Constraints for table `review_product`
--
ALTER TABLE `review_product`
  ADD CONSTRAINT `fk_review_member` FOREIGN KEY (`MEMBER_ID`) REFERENCES `member` (`ID`),
  ADD CONSTRAINT `fk_review_product` FOREIGN KEY (`PRODUCT_ID`) REFERENCES `product` (`ID`);

--
-- Constraints for table `review_song`
--
ALTER TABLE `review_song`
  ADD CONSTRAINT `fk_review_2_member` FOREIGN KEY (`MEMBER_ID`) REFERENCES `member` (`ID`),
  ADD CONSTRAINT `fk_review_2_song` FOREIGN KEY (`SONG_ID`) REFERENCES `songs` (`ID`);

--
-- Constraints for table `shopping_cart`
--
ALTER TABLE `shopping_cart`
  ADD CONSTRAINT `fk_cart_member` FOREIGN KEY (`MEMBER_ID`) REFERENCES `member` (`ID`),
  ADD CONSTRAINT `fk_cart_product` FOREIGN KEY (`ID`) REFERENCES `format_product` (`ID`);

--
-- Constraints for table `songs`
--
ALTER TABLE `songs`
  ADD CONSTRAINT `fk_song_genre` FOREIGN KEY (`GENRE_ID`) REFERENCES `genre` (`ID`),
  ADD CONSTRAINT `fk_song_group` FOREIGN KEY (`GROUP_ID`) REFERENCES `group_music` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
