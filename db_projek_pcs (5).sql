-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 30, 2022 at 04:13 AM
-- Server version: 10.4.19-MariaDB
-- PHP Version: 7.4.20

SET FOREIGN_KEY_CHECKS=0;
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

DELIMITER $$
--
-- Functions
--
DROP FUNCTION IF EXISTS `Function_createNote`$$
CREATE DEFINER=`root`@`localhost` FUNCTION `Function_createNote` () RETURNS VARCHAR(150) CHARSET utf8mb4 BEGIN
	declare noteID varchar(150);
	declare countNote int (5);
	
	set noteID = concat("NOTE", year(now()), lpad(month(now()),2,'0'), lpad(day(now()),2,'0'));
	
	select count(*)+1 into countNote from orders where note_number like concat('%', noteID, '%');
	
	set noteID = concat(noteID, lpad(countNote,3,'0'));
	
	return noteID;
    END$$

DELIMITER ;

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
('1', '2', '1', 100, 250000),
('10', '4', '3', 1100, 50000),
('4', '1', '1', 109, 150000),
('5', '3', '1', 154, 150000),
('6', '3', '4', 1110, 25000),
('7', '1', '4', 134, 25000),
('8', '2', '4', 99, 75000),
('9', '1', '2', 99, 100000);

-- --------------------------------------------------------

--
-- Table structure for table `genre`
--

DROP TABLE IF EXISTS `genre`;
CREATE TABLE `genre` (
  `ID` varchar(10) NOT NULL,
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
('7', 'Group_Fubuki_1'),
('8', 'Group Music');

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
('17', '8', '1'),
('18', '8', '6'),
('21', '1', '1'),
('22', '1', '2'),
('23', '1', '3'),
('24', '1', '4'),
('25', '1', '5'),
('30', '8', '11'),
('31', '8', '2'),
('32', '8', '3'),
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
('1', 'John Doe', 'John1', 'abc123', 'L', 'Jalan Mawar no. 10, Surabaya, Jawa Timur, Indonesia', '2000-05-12', '1', '2022-09-23'),
('2', 'Jane Doe', 'Jan1', '123', 'P', 'Jln Melati no 5', '1995-08-19', NULL, NULL),
('3', 'Lorem', 'Lipsum', 'abc', 'L', 'Jalan Unknown no 69', '1991-02-28', NULL, NULL),
('4', 'Adam', 'Adam#1', 'qwerty', 'L', 'Jalan Something Surabaya', '1996-02-29', NULL, NULL),
('5', 'Ervin', 'ervin123', 'abc654321', 'L', 'Jalan Nusantara 5', '2000-03-02', NULL, NULL);

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
  `DETAIL_ID` varchar(10) NOT NULL,
  `NOTE_NUMBER` varchar(15) NOT NULL,
  `PRODUCT_ID` varchar(10) NOT NULL,
  `QUANTITY` int(11) NOT NULL,
  `SUBTOTAL` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `orderdetails`
--

INSERT INTO `orderdetails` (`DETAIL_ID`, `NOTE_NUMBER`, `PRODUCT_ID`, `QUANTITY`, `SUBTOTAL`) VALUES
('1', 'NOTE20211123001', '1', 2, 500000),
('2', 'NOTE20220623001', '6', 1, 25000),
('3', 'NOTE20220623001', '8', 1, 75000),
('4', 'NOTE20220623002', '1', 2, 500000),
('5', 'NOTE20220623002', '4', 1, 150000),
('6', 'NOTE20220623003', '5', 2, 300000),
('7', 'NOTE20220623003', '9', 1, 100000),
('8', 'NOTE20220623004', '10', 100, 5000000),
('9', 'NOTE20220630001', '6', 5, 125000);

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
('NOTE20211123001', '2021-11-23', '1', '1', 'DELIVERED', '1', 490000),
('NOTE20220623001', '2022-06-23', '1', '1', 'DELIVERED', '2', 98000),
('NOTE20220623002', '2022-06-23', '2', '1', 'DELIVERED', '1', 637000),
('NOTE20220623003', '2022-06-23', '1', '1', 'DELIVERED', '2', 392000),
('NOTE20220623004', '2022-06-23', '5', '1', 'DELIVERED', '1', 5000000),
('NOTE20220630001', '2022-06-30', '2', NULL, 'PENDING', '1', 125000);

--
-- Triggers `orders`
--
DROP TRIGGER IF EXISTS `TR_Orders_1`;
DELIMITER $$
CREATE TRIGGER `TR_Orders_1` BEFORE INSERT ON `orders` FOR EACH ROW BEGIN
	declare varNull int (1);
	declare cut int (11) default 0;
	
	SELECT ISNULL((SELECT membership_id FROM member WHERE id = new.member_id)) into varNull;
	
	if (varNull = 0) then
		SELECT mb.discount into cut from membership mb, member m where m.membership_id = mb.id and m.id = new.member_id;
		
		set cut = 100 - cut;
		
		set new.total = cut*new.total/100;
	end if;
    END
$$
DELIMITER ;
DROP TRIGGER IF EXISTS `TR_Orders_2`;
DELIMITER $$
CREATE TRIGGER `TR_Orders_2` BEFORE UPDATE ON `orders` FOR EACH ROW BEGIN
	declare num int (2) default 0;
	
	declare idProduct varchar (10) default '';
	declare quantity int (11) default 0;
	
	declare idPUpdate varchar (10) default '';
	declare uQuantity int (11) default 0;
	
	declare numStock int (11) default 0;
	
	DECLARE fin INT (10) DEFAULT 0;
	
	declare cond int (1) default 0;
	
	DECLARE curOrder CURSOR
	FOR SELECT od.`PRODUCT_ID`, od.`QUANTITY`
	FROM orderdetails od where od.`NOTE_NUMBER` = old.`NOTE_NUMBER`;
	
	declare curUpdate cursor
	FOR SELECT od.`PRODUCT_ID`, od.`QUANTITY`
	FROM orderdetails od WHERE od.`NOTE_NUMBER` = old.`NOTE_NUMBER`;
	
	DECLARE CONTINUE HANDLER FOR NOT FOUND SET fin = 1;
	
	DECLARE EXIT HANDLER FOR SQLSTATE '45000'
		  BEGIN
		   RESIGNAL SET MESSAGE_TEXT = 'Stok tidak mencukupi !';
		  END;
	
	if (old.`STATUS` <> new.`STATUS`) then
		open curOrder;
		getOrder : Loop
			fetch curOrder into idProduct, quantity;
			IF (fin = 1) THEN
				LEAVE getOrder;
			END IF;
			
			select fp.`STOCK` into numStock from format_product fp
			where fp.`ID` = idProduct;
			
			if numStock>=quantity then 
				set cond = 1;
			else
				set cond = 0;
			end if;
		end loop;
		close curOrder;
		
		set fin = 0;
		
		if cond = 1 then
			open curUpdate;
			getUpdate : Loop
				fetch curUpdate into idPUpdate, uQuantity;
				if (fin=1) then
					leave getUpdate;
				end if;
				
				update format_product set stock = stock - uQuantity
				where id = idPUpdate;
			end loop;
		else
			SIGNAL SQLSTATE '45000';
		end if;
	end if;
    END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `payment_method`
--

DROP TABLE IF EXISTS `payment_method`;
CREATE TABLE `payment_method` (
  `ID` varchar(10) NOT NULL,
  `NAME` varchar(150) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `payment_method`
--

INSERT INTO `payment_method` (`ID`, `NAME`) VALUES
('1', 'Go-Pay'),
('2', 'OVO');

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
('11', '???P', 'Japan', 'L', '7'),
('12', 'Shirakami Fubuki', 'Japan', 'P', '1'),
('2', 'ZSunder', 'Philippines', 'L', '2'),
('3', 'Furaisen', 'Malaysia', 'L', '3'),
('4', 'Rumskii', 'Indonesia', 'P', '4'),
('5', 'lemonade', 'Indonesia', 'L', '4'),
('6', 'Tokoyami Towa', 'Japan', 'P', '1'),
('7', '?????????', 'JAPAN', 'L', '7'),
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
('1', 'High Tide Single', '2022-02-17 00:00:00', 4.85, 'A single composed of High Tide, the second original song of Moona Hoshinova', '1'),
('2', 'Scream', '2022-01-04 00:00:00', 0, 'Tokoyami Towa\'s first EP to be released.', '2'),
('3', 'KINGWORLD Single', '2022-06-21 00:00:00', 4.75, 'KINGWORLD is the second single released by Shirakami Fubuki', '1'),
('4', 'Produk', '2022-06-23 00:00:00', 0, 'This is a test product created during first presentation.', '2');

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
('10', '4', '6'),
('11', '4', '9'),
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
('1', '1', '1', '2022-04-29', 4.8),
('2', '1', '2', '2022-06-23', 4.9),
('3', '3', '2', '2022-06-23', 4.8),
('4', '3', '1', '2022-06-23', 4.7);

--
-- Triggers `review_product`
--
DROP TRIGGER IF EXISTS `TR_reviewProduct_1`;
DELIMITER $$
CREATE TRIGGER `TR_reviewProduct_1` AFTER INSERT ON `review_product` FOR EACH ROW BEGIN
	UPDATE product
	SET `RATING` = (SELECT AVG(r.`RATING`) FROM review_product r, product p WHERE r.`PRODUCT_ID` = p.id AND r.`PRODUCT_ID` = new.`PRODUCT_ID`)
	WHERE product.`ID` = new.`PRODUCT_ID`;
    END
$$
DELIMITER ;

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
('1', '1', '1', '2022-04-20', 4.8),
('2', '2', '1', '2022-06-23', 4.8);

--
-- Triggers `review_song`
--
DROP TRIGGER IF EXISTS `TR_reviewSong_1`;
DELIMITER $$
CREATE TRIGGER `TR_reviewSong_1` AFTER INSERT ON `review_song` FOR EACH ROW BEGIN
	UPDATE songs
	SET `RATING` = (SELECT AVG(r.`RATING`) FROM review_song r, songs s WHERE r.`SONG_ID` = s.id AND r.`SONG_ID` = new.`SONG_ID`)
	WHERE songs.`ID` = new.`SONG_ID`;
    END
$$
DELIMITER ;

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
('2', 'Akuma', '2022-01-03 00:00:00', '2', '4', 209, 'The first track in Towa\'s first EP, Scream', 4.8),
('3', 'Midnight Runaway', '2022-01-03 00:00:00', '3', '4', 209, 'The second track in Towa\'s first EP, Scream.', 0),
('4', 'Pallete', '2021-02-17 00:00:00', '4', '4', 215, 'Tokoyami Towa\'s first original song.', 0),
('5', 'Fact', '2022-01-03 00:00:00', '4', '4', 195, 'Tokoyami Towa\'s second original song to be made MV.', 0),
('6', 'Born to be Real', '2022-01-03 00:00:00', '5', '4', 207, 'The fifth track in Towa\'s first EP, Scream', 0),
('7', 'My Roar', '2022-01-03 00:00:00', '6', '4', 218, 'The sixth track in Towa\'s first EP, Scream', 0),
('8', 'KINGWORLD', '2022-06-03 00:00:00', '7', '4', 216, 'Shirakami Fubuki\'s second original song. Released on June 3rd, 2022', 0),
('9', 'Something', '2022-06-09 00:00:00', '8', '7', 210, 'aaa', 0);

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
  `DATE_OF_BIRTH` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `staff`
--

INSERT INTO `staff` (`ID`, `NAME`, `USERNAME`, `PASSWORD`, `ADDRESS`, `GENDER`, `DATE_OF_BIRTH`) VALUES
('1', 'Eugene Bush', 'Staff#1', '123456', 'Jalan Lorem no 69, Surabaya, Jawa Timur, Indonesia', 'L', '1997-05-09'),
('2', 'Adam', 'Adam', '123456', 'Jalan Something', 'L', '1999-01-13');

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
-- Indexes for table `orderdetails`
--
ALTER TABLE `orderdetails`
  ADD PRIMARY KEY (`DETAIL_ID`),
  ADD KEY `fk_detail_product` (`PRODUCT_ID`),
  ADD KEY `fk_detail_order` (`NOTE_NUMBER`);

--
-- Indexes for table `orders`
--
ALTER TABLE `orders`
  ADD PRIMARY KEY (`NOTE_NUMBER`),
  ADD KEY `fk_order_member` (`MEMBER_ID`),
  ADD KEY `fk_order_staff` (`STAFF_ID`),
  ADD KEY `fk_order_payment` (`PAYMENT_METHOD`);

--
-- Indexes for table `payment_method`
--
ALTER TABLE `payment_method`
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
  ADD CONSTRAINT `fk_format_product_1` FOREIGN KEY (`FORMAT_ID`) REFERENCES `format` (`ID`),
  ADD CONSTRAINT `fk_format_product_2` FOREIGN KEY (`PRODUCT_ID`) REFERENCES `product` (`ID`);

--
-- Constraints for table `group_personel`
--
ALTER TABLE `group_personel`
  ADD CONSTRAINT `fk_group_group` FOREIGN KEY (`GROUP_ID`) REFERENCES `group_music` (`id`),
  ADD CONSTRAINT `fk_group_personel` FOREIGN KEY (`PERSONEL_ID`) REFERENCES `personel` (`ID`);

--
-- Constraints for table `member`
--
ALTER TABLE `member`
  ADD CONSTRAINT `fk_member_membership` FOREIGN KEY (`MEMBERSHIP_ID`) REFERENCES `membership` (`ID`);

--
-- Constraints for table `orderdetails`
--
ALTER TABLE `orderdetails`
  ADD CONSTRAINT `fk_detail_order` FOREIGN KEY (`NOTE_NUMBER`) REFERENCES `orders` (`NOTE_NUMBER`),
  ADD CONSTRAINT `fk_detail_product` FOREIGN KEY (`PRODUCT_ID`) REFERENCES `format_product` (`ID`);

--
-- Constraints for table `orders`
--
ALTER TABLE `orders`
  ADD CONSTRAINT `fk_order_member` FOREIGN KEY (`MEMBER_ID`) REFERENCES `member` (`ID`),
  ADD CONSTRAINT `fk_order_payment` FOREIGN KEY (`PAYMENT_METHOD`) REFERENCES `payment_method` (`ID`),
  ADD CONSTRAINT `fk_order_staff` FOREIGN KEY (`STAFF_ID`) REFERENCES `staff` (`ID`);

--
-- Constraints for table `personel`
--
ALTER TABLE `personel`
  ADD CONSTRAINT `fk_personel_occupation` FOREIGN KEY (`OCCUPATION_ID`) REFERENCES `occupation` (`ID`);

--
-- Constraints for table `product`
--
ALTER TABLE `product`
  ADD CONSTRAINT `fk_product_type` FOREIGN KEY (`TYPE_ID`) REFERENCES `type_product` (`ID`);

--
-- Constraints for table `product_song`
--
ALTER TABLE `product_song`
  ADD CONSTRAINT `fk_product_song_1` FOREIGN KEY (`SONG_ID`) REFERENCES `songs` (`ID`),
  ADD CONSTRAINT `fk_product_song_2` FOREIGN KEY (`PRODUCT_ID`) REFERENCES `product` (`ID`);

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
  ADD CONSTRAINT `fk_cart_product` FOREIGN KEY (`PRODUCT_ID`) REFERENCES `format_product` (`ID`);

--
-- Constraints for table `songs`
--
ALTER TABLE `songs`
  ADD CONSTRAINT `fk_song_genre` FOREIGN KEY (`GENRE_ID`) REFERENCES `genre` (`ID`),
  ADD CONSTRAINT `fk_song_group` FOREIGN KEY (`GROUP_ID`) REFERENCES `group_music` (`id`);
SET FOREIGN_KEY_CHECKS=1;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
