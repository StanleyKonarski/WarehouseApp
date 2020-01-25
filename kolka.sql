-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Czas generowania: 25 Sty 2020, 12:53
-- Wersja serwera: 10.4.8-MariaDB
-- Wersja PHP: 7.3.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Baza danych: `kolka`
--

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `users`
--

CREATE TABLE `users` (
  `user_id` bigint(20) UNSIGNED NOT NULL,
  `login` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `name` varchar(40) COLLATE utf8_unicode_ci NOT NULL,
  `surname` varchar(40) COLLATE utf8_unicode_ci NOT NULL,
  `permission` int(1) NOT NULL,
  `password` varchar(64) COLLATE utf8_unicode_ci DEFAULT NULL,
  `salt` varchar(64) COLLATE utf8_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Zrzut danych tabeli `users`
--

INSERT INTO `users` (`user_id`, `login`, `name`, `surname`, `permission`, `password`, `salt`) VALUES
(8, 'magazynier', 'Bartłomiej', 'Huffmanek', 1, '271D0E17508D882D77D420E7D9E42696140FAD131C21AB8EB135584CCC97FA99', '8872DCA8C5F0F4BE944B01160401FCD33566365D18B583102C14B80840B018B8'),
(9, 'kierownik', 'Andrzej', 'Huffman', 2, '11E39D0F249117E0CDCCE99ABD907314E0579BFAAC6712C9B7C6DFFDF85F3FB6', 'ABCC231825D9D6A4B7D9643605B00A1AA66C926E66594713CA9186D33623DBA4'),
(10, 'nickcage', 'Nicholas', 'Cage', 1, 'CCF4115D1B8307EA88C39F6C663EBD0AE475DA68B3A70B0FA743D72D708C0889', 'AF34E4D9D32C4A22B5357E7FE261FD865A6562AF5CBEBD678D3BAFC1D58CA82A');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `wheels`
--

CREATE TABLE `wheels` (
  `ProductID` int(11) NOT NULL,
  `ProductName` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `ProductColor` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `WheelDiameter` float NOT NULL,
  `WheelWidth` float NOT NULL,
  `Quantity` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Zrzut danych tabeli `wheels`
--

INSERT INTO `wheels` (`ProductID`, `ProductName`, `ProductColor`, `WheelDiameter`, `WheelWidth`, `Quantity`) VALUES
(10, 'MalikWheels', 'MalikGold', 80, 30, 1700),
(12, 'Shadow', 'Turquoise', 20.3, 41.2, 5560),
(13, '9-3', 'Violet', 13.8, 3.4, 5417),
(14, 'RX-8', 'Khaki', 97, 35.2, 1180),
(15, 'Silverado Hybrid', 'Violet', 24.6, 25.1, 3210),
(16, 'RL', 'Crimson', 69, 41.4, 2044),
(17, 'Xterra', 'Purple', 86, 38.7, 2653),
(18, 'SRX', 'Puce', 96.7, 49.8, 3912),
(19, 'Mazda5', 'Orange', 71.5, 33.6, 214),
(20, 'Ranger', 'Teal', 42.8, 43.2, 1955),
(21, 'Versa', 'Purple', 25.2, 7.3, 8684),
(22, 'Bravada', 'Green', 35.8, 4.2, 3623),
(23, 'Integra', 'Pink', 31, 44.7, 675),
(24, 'S10', 'Fuscia', 33.6, 10, 7678),
(25, 'Concorde', 'Green', 99.3, 12.2, 1396),
(26, 'Sidekick', 'Mauv', 47.2, 36.4, 2274),
(27, 'Matrix', 'Purple', 17.2, 23.2, 4349),
(28, 'GTO', 'Maroon', 97.9, 49.4, 3977),
(29, 'GranTurismo', 'Red', 30.5, 40.7, 2137),
(30, 'Suburban', 'Puce', 97.8, 28.1, 7806),
(31, 'Ascender', 'Green', 72.9, 24.6, 7241),
(32, 'IS', 'Yellow', 45.2, 11.1, 7819),
(33, 'Camry', 'Red', 64.4, 10.7, 1480),
(34, 'Escalade', 'Green', 34.8, 9.6, 5859),
(35, 'Outlander', 'Red', 85, 43, 8012),
(36, 'Diablo', 'Maroon', 62.4, 17.2, 8709),
(37, 'Impreza', 'Indigo', 42.5, 26.7, 203),
(38, 'Monte Carlo', 'Violet', 36.3, 42.9, 4450),
(39, 'Explorer', 'Maroon', 29.5, 28.4, 7145),
(40, 'Legacy', 'Mauv', 60.2, 33.3, 3701),
(41, 'H3T', 'Purple', 48.2, 1.9, 4333),
(42, 'Cherokee', 'Crimson', 15, 30.4, 5838),
(43, 'Savana 1500', 'Teal', 32.4, 30.1, 6812),
(44, 'Beretta', 'Goldenrod', 2.5, 49.6, 361),
(45, 'MX-5', 'Fuscia', 53.5, 12, 2521),
(46, 'Q', 'Green', 39.6, 47.3, 5426),
(47, 'Acadia', 'Crimson', 7.8, 6.4, 4507),
(49, 'Ciera', 'Red', 65.3, 28.7, 2326),
(50, 'Malibu', 'Aquamarine', 60.4, 11.7, 3381),
(51, 'Mirage', 'Pink', 18.8, 4, 8083),
(52, 'RX-7', 'Teal', 29.7, 37.2, 5445),
(53, 'XC90', 'Fuscia', 4.5, 4.9, 668),
(54, 'Lucerne', 'Yellow', 25.3, 16.9, 2656),
(55, 'Verona', 'Teal', 97.1, 41.5, 832),
(56, 'V8 Vantage S', 'Pink', 71.9, 12.8, 7174),
(57, 'Pajero', 'Teal', 61.3, 2.5, 3850),
(58, 'IPL G', 'Yellow', 83, 24.8, 3192),
(59, 'Savana 2500', 'Teal', 42.2, 44.8, 5478),
(60, 'Journey', 'Indigo', 3.5, 31.9, 2674),
(61, 'HS', 'Puce', 5.3, 22, 2270),
(62, 'Cougar', 'Teal', 49.1, 39.1, 1756),
(65, 'MalikRed', 'Red', 12, 10, 500);

--
-- Indeksy dla zrzutów tabel
--

--
-- Indeksy dla tabeli `users`
--
ALTER TABLE `users`
  ADD UNIQUE KEY `user_id` (`user_id`);

--
-- Indeksy dla tabeli `wheels`
--
ALTER TABLE `wheels`
  ADD PRIMARY KEY (`ProductID`),
  ADD UNIQUE KEY `ProductName` (`ProductName`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT dla tabeli `users`
--
ALTER TABLE `users`
  MODIFY `user_id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT dla tabeli `wheels`
--
ALTER TABLE `wheels`
  MODIFY `ProductID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=66;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
