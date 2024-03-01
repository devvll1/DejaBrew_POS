-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 01, 2024 at 03:48 AM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dejabrewpos`
--

-- --------------------------------------------------------

--
-- Table structure for table `orders`
--

CREATE TABLE `orders` (
  `o_id` int(11) NOT NULL,
  `p_name` varchar(255) DEFAULT NULL,
  `p_price` int(11) DEFAULT NULL,
  `o_quantity` int(11) DEFAULT NULL,
  `o_total` int(11) DEFAULT NULL,
  `id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `orders`
--

INSERT INTO `orders` (`o_id`, `p_name`, `p_price`, `o_quantity`, `o_total`, `id`) VALUES
(1, 'WinterMelon', 70, 1, 70, 1),
(2, 'Matcha', 70, 2, 140, 1),
(3, 'Chocolate', 70, 3, 210, 1),
(4, 'Taro', 70, 1, 70, 1),
(5, 'WinterMelon', 70, 1, 70, 1),
(6, 'Matcha', 70, 1, 70, 1),
(7, 'Chocolate', 70, 1, 70, 1),
(8, 'Pepermint', 70, 1, 70, 1),
(9, 'Chocolate', 70, 1, 70, 1),
(10, 'Cofee White Cream', 70, 1, 70, 1),
(11, 'Black White Coffee', 70, 1, 70, 1),
(12, 'Cappuccino', 70, 1, 70, 1),
(13, 'WinterMelon', 70, 3, 210, 1),
(14, 'Black White Coffee', 70, 2, 140, 1),
(15, 'Cofee White Cream', 70, 1, 70, 1),
(16, 'WinterMelon', 70, 1, 70, 1),
(17, 'Cofee White Cream', 70, 1, 70, 1),
(18, 'Cappuccino', 70, 3, 210, 1),
(19, 'Caramel Macchiato', 70, 1, 70, 1),
(20, 'Matcha', 70, 1, 70, 1),
(21, 'Chocolate', 70, 1, 70, 1),
(22, 'Cappuccino', 70, 1, 70, 1),
(23, 'WinterMelon', 70, 1, 70, 1),
(24, 'Black White Coffee', 70, 1, 70, 1),
(25, 'Taro', 70, 1, 70, 1),
(26, 'Taro', 70, 1, 70, 1),
(27, 'Taro', 70, 1, 70, 1),
(28, 'WinterMelon', 70, 1, 70, 1),
(29, 'Matcha', 70, 1, 70, 1),
(30, 'Chocolate', 70, 1, 70, 1),
(31, 'Pepermint', 70, 1, 70, 1),
(32, 'Caramel Macchiato', 70, 1, 70, 1),
(33, 'Cofee White Cream', 70, 1, 70, 1),
(34, 'Coffee Cocoa', 70, 1, 70, 1),
(35, 'Cappuccino', 70, 1, 70, 1),
(36, 'Black White Coffee', 70, 1, 70, 1),
(37, 'Taro', 70, 1, 70, 1),
(38, 'Taro', 70, 1, 70, 1),
(39, 'Taro', 70, 1, 70, 1),
(40, 'WinterMelon', 70, 2, 140, 1),
(41, 'Taro', 70, 1, 70, 1),
(42, 'WinterMelon', 70, 2, 140, 1),
(43, 'WinterMelon', 70, 3, 210, 1),
(44, 'Matcha', 70, 2, 140, 1),
(45, 'Taro', 70, 1, 70, 1),
(46, 'WinterMelon', 70, 3, 210, 1),
(47, 'Matcha', 70, 1, 70, 1),
(48, 'Pepermint', 70, 2, 140, 1),
(49, 'Taro', 70, 1, 70, 1),
(50, 'WinterMelon', 70, 1, 70, 1),
(51, 'Matcha', 70, 1, 70, 1),
(52, 'Taro', 70, 1, 70, 1),
(53, 'WinterMelon', 70, 2, 140, 1),
(54, 'Matcha', 70, 1, 70, 1),
(55, 'Chocolate', 70, 3, 210, 1),
(56, 'Pepermint', 70, 1, 70, 1),
(57, 'Caramel Macchiato', 70, 1, 70, 1),
(58, 'Cofee White Cream', 70, 1, 70, 1),
(59, 'Coffee Cocoa', 70, 1, 70, 1),
(60, 'Cappuccino', 70, 1, 70, 1),
(61, 'Black White Coffee', 70, 1, 70, 1),
(62, 'Taro', 70, 3, 210, 1),
(63, 'Taro', 70, 1, 70, 1),
(64, 'WinterMelon', 70, 1, 70, 1),
(65, 'Matcha', 70, 1, 70, 1);

-- --------------------------------------------------------

--
-- Table structure for table `products`
--

CREATE TABLE `products` (
  `p_id` int(11) NOT NULL,
  `p_name` varchar(50) DEFAULT NULL,
  `p_price` int(11) DEFAULT NULL,
  `p_quantity` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `products`
--

INSERT INTO `products` (`p_id`, `p_name`, `p_price`, `p_quantity`) VALUES
(1, 'Taro', 70, 85),
(2, 'WinterMelon', 70, 73),
(3, 'Matcha', 70, 98),
(4, 'Chocolate', 70, 96),
(5, 'Pepermint', 70, 92),
(6, 'Caramel Macchiato', 70, 96),
(7, 'Cofee White Cream', 70, 95),
(8, 'Coffee Cocoa', 70, 97),
(9, 'Cappuccino', 70, 93),
(10, 'Black White Coffee', 70, 94);

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `id` int(11) NOT NULL,
  `fullname` varchar(255) DEFAULT NULL,
  `age` int(11) DEFAULT NULL,
  `email` varchar(50) DEFAULT NULL,
  `username` varchar(255) DEFAULT NULL,
  `password` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`id`, `fullname`, `age`, `email`, `username`, `password`) VALUES
(1, 'Dave Villa', 20, 'davevilla58@gmail.com\r\n', 'admin', 'admin123'),
(2, 'Juan Dela Cruz', 20, 'juandelacruz@gmail.com', 'user1', 'admin1234');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `orders`
--
ALTER TABLE `orders`
  ADD PRIMARY KEY (`o_id`),
  ADD KEY `FK_orders_id` (`id`);

--
-- Indexes for table `products`
--
ALTER TABLE `products`
  ADD PRIMARY KEY (`p_id`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `orders`
--
ALTER TABLE `orders`
  MODIFY `o_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=66;

--
-- AUTO_INCREMENT for table `products`
--
ALTER TABLE `products`
  MODIFY `p_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `orders`
--
ALTER TABLE `orders`
  ADD CONSTRAINT `FK_orders_id` FOREIGN KEY (`id`) REFERENCES `user` (`id`) ON DELETE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
