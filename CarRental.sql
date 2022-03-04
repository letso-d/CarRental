-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2022. Már 04. 15:59
-- Kiszolgáló verziója: 10.4.19-MariaDB
-- PHP verzió: 7.3.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `kolcsonzo`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `brands`
--

CREATE TABLE `brands` (
  `brand_id` int(2) NOT NULL,
  `brand_name` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- A tábla adatainak kiíratása `brands`
--

INSERT INTO `brands` (`brand_id`, `brand_name`) VALUES
(1, 'Audi'),
(2, 'BMW'),
(3, 'Buick'),
(4, 'Cadillac'),
(5, 'Chevrolet'),
(6, 'Chrysler'),
(7, 'Dodge'),
(8, 'Ferrari'),
(9, 'Ford'),
(10, 'Honda'),
(11, 'Hummer'),
(12, 'Hyundai'),
(13, 'Infiniti'),
(14, 'Isuzu'),
(15, 'Jaguar'),
(16, 'Kia'),
(17, 'Lamborghini'),
(18, 'Land Rover'),
(19, 'Lexus'),
(20, 'Lincoln'),
(21, 'Lotus'),
(22, 'Mazda'),
(23, 'Mercedes-Benz'),
(24, 'Mitsubishi'),
(25, 'Nissan'),
(26, 'Oldsmobile'),
(27, 'Peugeot'),
(28, 'Pontiac'),
(29, 'Porsche'),
(30, 'Saab'),
(31, 'Subaru'),
(32, 'Suzuki'),
(33, 'Toyota'),
(34, 'Volkswagen'),
(35, 'Volvo'),
(36, 'Fiat');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `cars`
--

CREATE TABLE `cars` (
  `car_id` int(2) NOT NULL,
  `brand` int(2) NOT NULL,
  `car_type` int(2) NOT NULL,
  `lic_pl_num` char(6) NOT NULL,
  `year` year(4) NOT NULL,
  `km` int(8) NOT NULL,
  `priceperkm` int(10) NOT NULL,
  `is_rented` int(1) NOT NULL DEFAULT 0,
  `renter` int(2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- A tábla adatainak kiíratása `cars`
--

INSERT INTO `cars` (`car_id`, `brand`, `car_type`, `lic_pl_num`, `year`, `km`, `priceperkm`, `is_rented`, `renter`) VALUES
(1, 35, 1, 'ABC123', 2016, 59000, 5599, 0, NULL),
(2, 23, 1, 'ABC234', 2019, 85000, 6000, 0, NULL),
(3, 34, 2, 'ABC345', 2021, 15000, 6999, 1, 2),
(4, 36, 3, 'ABC456', 2016, 53000, 3999, 0, NULL),
(5, 2, 4, 'ABC567', 2013, 117000, 4500, 1, 2),
(6, 27, 5, 'ABC678', 2010, 236000, 2500, 0, NULL),
(7, 9, 6, 'ABC789', 2012, 174000, 2000, 1, 1),
(8, 5, 7, 'ABC890', 1975, 57500, 3500, 0, NULL),
(9, 1, 8, 'ABC901', 2018, 64000, 2000, 1, 2),
(12, 9, 2, 'YXC123', 2021, 1001, 1231, 0, NULL),
(14, 8, 7, 'XCV989', 2019, 1111, 1111, 1, 1),
(16, 36, 3, 'NNN839', 2013, 131001, 341, 0, NULL),
(19, 7, 4, 'ASD123', 2019, 1, 1, 1, 1);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `car_types`
--

CREATE TABLE `car_types` (
  `type_id` int(2) NOT NULL,
  `type_name` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- A tábla adatainak kiíratása `car_types`
--

INSERT INTO `car_types` (`type_id`, `type_name`) VALUES
(1, 'Sedan'),
(2, 'Kombi'),
(3, 'Ferdehátú'),
(4, 'Cabrio'),
(5, 'Coupe'),
(6, 'Egyterű'),
(7, 'Sport'),
(8, 'Crossover');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `users`
--

CREATE TABLE `users` (
  `user_id` int(2) NOT NULL,
  `username` varchar(30) DEFAULT NULL,
  `pass` varchar(200) NOT NULL,
  `user_type` int(1) DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- A tábla adatainak kiíratása `users`
--

INSERT INTO `users` (`user_id`, `username`, `pass`, `user_type`) VALUES
(1, 'teszt1', '12345', 1),
(2, 'teszt2', '98765', 1),
(3, 'admin', 'admin', 2);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `user_types`
--

CREATE TABLE `user_types` (
  `type_id` int(1) NOT NULL,
  `type_name` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- A tábla adatainak kiíratása `user_types`
--

INSERT INTO `user_types` (`type_id`, `type_name`) VALUES
(1, 'user'),
(2, 'admin');

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `brands`
--
ALTER TABLE `brands`
  ADD PRIMARY KEY (`brand_id`);

--
-- A tábla indexei `cars`
--
ALTER TABLE `cars`
  ADD PRIMARY KEY (`car_id`),
  ADD KEY `car_type` (`car_type`),
  ADD KEY `renter` (`renter`),
  ADD KEY `brand` (`brand`);

--
-- A tábla indexei `car_types`
--
ALTER TABLE `car_types`
  ADD PRIMARY KEY (`type_id`);

--
-- A tábla indexei `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`user_id`),
  ADD UNIQUE KEY `username` (`username`),
  ADD KEY `user_type` (`user_type`);

--
-- A tábla indexei `user_types`
--
ALTER TABLE `user_types`
  ADD PRIMARY KEY (`type_id`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `brands`
--
ALTER TABLE `brands`
  MODIFY `brand_id` int(2) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=37;

--
-- AUTO_INCREMENT a táblához `cars`
--
ALTER TABLE `cars`
  MODIFY `car_id` int(2) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;

--
-- AUTO_INCREMENT a táblához `car_types`
--
ALTER TABLE `car_types`
  MODIFY `type_id` int(2) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT a táblához `users`
--
ALTER TABLE `users`
  MODIFY `user_id` int(2) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Megkötések a kiírt táblákhoz
--

--
-- Megkötések a táblához `cars`
--
ALTER TABLE `cars`
  ADD CONSTRAINT `cars_ibfk_1` FOREIGN KEY (`car_type`) REFERENCES `car_types` (`type_id`),
  ADD CONSTRAINT `cars_ibfk_2` FOREIGN KEY (`renter`) REFERENCES `users` (`user_id`),
  ADD CONSTRAINT `cars_ibfk_3` FOREIGN KEY (`brand`) REFERENCES `brands` (`brand_id`);

--
-- Megkötések a táblához `users`
--
ALTER TABLE `users`
  ADD CONSTRAINT `users_ibfk_1` FOREIGN KEY (`user_type`) REFERENCES `user_types` (`type_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
