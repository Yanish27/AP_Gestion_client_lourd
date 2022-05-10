-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : mar. 10 mai 2022 à 17:21
-- Version du serveur : 5.7.36
-- Version de PHP : 7.4.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `projet_ap`
--

-- --------------------------------------------------------

--
-- Structure de la table `ivariables`
--

DROP TABLE IF EXISTS `ivariables`;
CREATE TABLE IF NOT EXISTS `ivariables` (
  `CLE` varchar(255) NOT NULL,
  `VAL` varchar(255) NOT NULL,
  UNIQUE KEY `CLE` (`CLE`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `ivariables`
--

INSERT INTO `ivariables` (`CLE`, `VAL`) VALUES
('acronyme', 'EGC'),
('arg1', 'Nos salles favorisent l\'entente, le travail d\'équipe et la collaboration'),
('Desc1', 'Aucun objet n\'est requis. Juste de votre intelligence.<br>La salle sera remplis d\'objets. Parois utiles, parfois pas.'),
('Desc2', 'Arriverez-vous à trouver les indices et vous échapper de la pièce <b>en 60 minute </b>? '),
('Desc3', 'Les chambres sont conçues pour créer une expérience authentique avec une atmosphère amusante, une attention stricte aux détails.'),
('description', 'Description à faire....'),
('desc_glob', 'Situé sur Annecy, Thonon-les-Bains, Bonneville ainsi que Chamonix Mont-Blanc, EGC vous fait vivre une expérience inoubliable au plein coeur de la région Auvergne Rhône-Alpes.\r\nAlors, sauriez-vous relevez le défi ?'),
('include_path', '/var/www/'),
('nbsalles', '4'),
('nom', 'Escape Game Corporation'),
('tailletotale', '1500'),
('Titre1', 'Vous êtes enfermés'),
('Titre2', 'L\'horloge tourne…'),
('Titre3', 'Mettez-vous dans le thème.');

-- --------------------------------------------------------

--
-- Structure de la table `lieuxactivites`
--

DROP TABLE IF EXISTS `lieuxactivites`;
CREATE TABLE IF NOT EXISTS `lieuxactivites` (
  `idLieu` int(11) NOT NULL AUTO_INCREMENT,
  `Ville` varchar(255) NOT NULL,
  `CodePostal` mediumint(9) NOT NULL,
  PRIMARY KEY (`idLieu`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `lieuxactivites`
--

INSERT INTO `lieuxactivites` (`idLieu`, `Ville`, `CodePostal`) VALUES
(1, 'Annecy', 74000),
(2, 'Thonon-les-bains', 74200),
(3, 'Bonneville', 74130),
(4, 'Chamonix Mont Blanc', 74440);

-- --------------------------------------------------------

--
-- Structure de la table `parties`
--

DROP TABLE IF EXISTS `parties`;
CREATE TABLE IF NOT EXISTS `parties` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nom_partie` varchar(255) NOT NULL,
  `nb_joueurs` int(11) NOT NULL,
  `id_salle` int(11) DEFAULT NULL,
  `nb_obstacle` int(11) NOT NULL,
  `date_partie` datetime NOT NULL,
  `reussite` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=182 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `parties`
--

INSERT INTO `parties` (`id`, `nom_partie`, `nb_joueurs`, `id_salle`, `nb_obstacle`, `date_partie`, `reussite`) VALUES
(1, 'cuivre', 6, 4, 9, '2020-08-08 02:13:45', 0),
(2, 'nuisances', 5, 2, 3, '2020-02-14 15:52:54', 0),
(3, 'nase', 6, 2, 9, '2020-12-16 18:17:07', 1),
(4, 'concédé', 3, 4, 2, '2020-01-01 13:10:46', 1),
(5, 'Cézanne', 5, 3, 7, '2020-03-25 04:22:28', 1),
(6, 'lecteur', 6, 3, 6, '2021-09-19 05:17:29', 1),
(8, 'assumer', 7, 2, 9, '2021-09-26 06:53:07', 1),
(9, 'signalés', 6, 4, 4, '2020-08-03 23:48:34', 1),
(10, 'flemmard', 2, 3, 8, '2020-03-22 09:36:36', 1),
(11, 'armements', 6, 2, 9, '2020-12-15 13:50:10', 1),
(12, 'uni', 3, 2, 3, '2021-02-19 05:25:04', 1),
(13, 'incisives', 6, 2, 9, '2021-08-14 05:37:04', 1),
(14, 'rencontrer', 6, 4, 2, '2021-09-25 21:18:03', 0),
(15, 'injection', 6, 2, 8, '2021-05-18 08:16:59', 0),
(16, 'distances', 5, 4, 2, '2020-12-12 16:32:41', 0),
(19, 'dignes', 3, 3, 8, '2021-08-21 15:46:40', 1),
(20, 'continueront', 4, 2, 7, '2022-02-06 20:29:25', 0),
(21, 'confirmant', 4, 4, 8, '2020-05-10 16:54:59', 1),
(22, 'entrailles', 5, 3, 2, '2020-11-06 11:26:50', 0),
(23, 'indiquent', 4, 4, 0, '2022-01-09 01:43:22', 1),
(24, 'studios', 3, 4, 9, '2020-11-09 14:43:01', 1),
(25, 'invariable', 4, 2, 7, '2021-03-30 02:19:46', 0),
(26, 'patienter', 2, 3, 7, '2021-01-11 05:27:07', 0),
(27, 'Margarita', 4, 4, 5, '2021-02-05 06:00:56', 0),
(29, 'armements', 4, 2, 6, '2020-02-18 15:34:09', 0),
(30, 'lutteur', 3, 3, 6, '2020-05-21 03:16:17', 0),
(32, 'boucherons', 4, 3, 5, '2020-07-20 09:22:11', 1),
(33, 'alcoolisé', 6, 4, 3, '2020-10-20 05:17:24', 0),
(34, 'prends', 7, 2, 6, '2020-03-11 06:18:10', 1),
(35, 'fausse couche', 2, 4, 4, '2021-12-15 12:41:56', 1),
(37, 'baby', 2, 2, 4, '2021-09-15 09:24:07', 1),
(38, 'droites', 4, 2, 2, '2021-05-03 08:49:42', 1),
(40, 'entraver', 2, 4, 8, '2022-03-14 19:28:14', 0),
(41, 'Bakou', 5, 3, 8, '2020-10-19 13:20:28', 1),
(42, 'feuilles', 5, 2, 1, '2021-12-16 15:02:53', 0),
(43, 'gestionnaire', 3, 3, 0, '2020-05-26 22:25:38', 0),
(44, 'cuivre', 7, 2, 4, '2021-08-10 04:02:56', 1),
(45, 'rose', 6, 2, 5, '2021-11-03 22:08:32', 0),
(48, 'solennellement', 5, 2, 5, '2020-09-05 18:25:51', 1),
(49, 'étain', 3, 4, 2, '2022-01-02 02:47:52', 1),
(50, 'fers', 3, 2, 4, '2020-09-23 22:43:38', 1),
(51, 'schlass', 3, 4, 1, '2021-12-10 23:28:51', 1),
(53, 'end', 6, 2, 4, '2021-07-31 06:08:25', 1),
(54, 'cuivre', 5, 3, 2, '2021-09-12 01:49:16', 0),
(55, 'provisionner', 6, 4, 7, '2022-03-03 06:59:04', 1),
(57, 'provisionner', 6, 3, 6, '2020-02-26 05:26:43', 0),
(58, 'signalés', 5, 3, 1, '2020-09-09 05:52:28', 0),
(59, 'moléculaire', 3, 2, 8, '2020-03-19 12:10:39', 1),
(60, 'regarde', 5, 2, 0, '2021-04-18 08:33:42', 1),
(61, 'clown', 3, 4, 0, '2020-03-06 01:22:20', 0),
(62, 'allaiter', 3, 2, 2, '2021-08-11 15:04:09', 1),
(63, 'baron', 2, 4, 3, '2020-10-10 00:47:39', 1),
(65, 'falloir', 5, 3, 3, '2020-10-29 16:30:15', 0),
(66, 'provisionner', 2, 3, 4, '2020-01-17 11:29:59', 1),
(67, 'obligés', 7, 3, 1, '2020-12-27 05:00:37', 0),
(68, 'obligés', 2, 4, 2, '2022-01-24 22:27:23', 1),
(69, 'nuisances', 6, 2, 3, '2020-07-11 13:11:54', 1),
(71, 'nuisances', 3, 2, 8, '2021-10-19 20:11:14', 1),
(72, 'assumer', 6, 3, 6, '2020-11-11 15:43:30', 1),
(73, 'Bakou', 3, 4, 3, '2021-06-03 22:33:16', 1),
(74, 'intègre', 6, 4, 4, '2020-07-17 00:35:43', 1),
(75, 'repartie', 7, 2, 7, '2022-01-19 03:22:45', 1),
(76, 'ferrées', 4, 4, 7, '2021-01-22 18:23:27', 0),
(77, 'obsolète', 7, 4, 8, '2022-01-09 20:32:42', 1),
(78, 'ferrées', 7, 4, 3, '2021-05-12 04:07:06', 1),
(79, 'Margarita', 5, 3, 7, '2020-04-05 05:07:23', 0),
(80, 'hostiles', 4, 3, 5, '2021-10-11 19:34:02', 0),
(81, 'navigateur', 5, 3, 7, '2020-02-13 07:36:21', 1),
(83, 'aspirateur', 6, 3, 7, '2021-01-11 03:34:26', 1),
(85, 'Reed', 3, 3, 0, '2022-01-14 18:24:30', 0),
(86, 'préservé', 2, 4, 0, '2021-11-08 23:18:31', 0),
(87, 'Stern', 6, 2, 7, '2021-09-01 08:10:03', 1),
(88, 'continueront', 3, 2, 6, '2022-02-15 04:48:38', 0),
(89, 'confirmant', 2, 3, 7, '2021-10-26 22:08:02', 1),
(90, 'lourd', 3, 4, 5, '2020-09-13 03:58:53', 1),
(93, 'polémique', 6, 3, 9, '2021-02-01 13:12:46', 0),
(94, 'moderne', 6, 3, 2, '2020-07-31 13:26:20', 0),
(95, 'obligés', 6, 2, 5, '2021-10-04 05:41:47', 1),
(97, 'indiquent', 4, 4, 7, '2020-08-11 17:26:23', 0),
(98, 'vautour', 3, 4, 4, '2020-01-11 18:21:32', 0),
(99, 'audacieux', 2, 3, 9, '2020-07-08 16:17:02', 0),
(100, 'cuivre', 4, 4, 6, '2021-11-25 16:58:35', 0),
(101, 'orienté', 3, 2, 6, '2021-08-21 21:23:15', 1),
(102, 'Reed', 5, 3, 8, '2021-10-28 23:41:11', 1),
(103, 'canot', 2, 2, 6, '2020-04-23 02:43:00', 1),
(104, 'tisser', 5, 2, 3, '2021-05-24 20:26:55', 1),
(105, 'moderne', 4, 4, 0, '2021-12-09 07:32:39', 0),
(111, 'envoyer', 5, 2, 8, '2022-01-09 07:08:24', 1),
(112, 'gérés', 2, 2, 4, '2021-10-22 20:38:55', 1),
(115, 'Jésus-Christ', 2, 3, 9, '2021-07-09 14:54:00', 1),
(116, 'images', 5, 3, 2, '2022-01-08 10:38:50', 1),
(117, 'Eugène', 6, 3, 7, '2021-11-29 16:00:00', 1),
(118, 'Eugène', 4, 3, 5, '2020-11-24 01:10:52', 1),
(121, 'entrailles', 2, 2, 6, '2021-10-06 22:51:52', 1),
(125, 'congé', 4, 4, 0, '2020-10-11 12:05:56', 1),
(126, 'polémique', 4, 3, 3, '2020-04-28 18:57:01', 1),
(127, 'théâtres', 7, 2, 0, '2022-02-26 20:54:08', 1),
(128, 'cuisinière', 4, 2, 3, '2020-02-07 16:19:43', 1),
(129, 'bandes', 6, 1, 0, '2021-06-09 14:01:15', 1),
(130, 'Pologne', 3, 2, 7, '2021-11-06 08:11:56', 1),
(131, 'gouaille', 5, 4, 4, '2021-10-03 21:55:42', 1),
(132, 'gratouiller', 5, 3, 0, '2021-07-12 05:18:27', 1),
(134, 'indiquent', 3, 2, 0, '2020-06-03 07:50:09', 1),
(136, 'identités', 5, 3, 7, '2020-01-29 10:40:28', 1),
(137, 'end', 5, 4, 5, '2020-11-08 02:56:18', 1),
(138, 'pari', 7, 4, 4, '2021-05-26 18:18:55', 1),
(139, 'dignes', 3, 2, 0, '2020-05-26 06:20:39', 1),
(140, 'fers', 2, 4, 3, '2022-01-29 02:31:20', 1),
(141, 'punissable', 3, 3, 3, '2020-02-20 07:32:48', 1),
(142, 'moléculaire', 6, 3, 4, '2020-11-11 13:33:48', 1),
(143, 'fers', 3, 1, 3, '2020-01-27 19:14:28', 1),
(144, 'intègre', 7, 2, 9, '2020-09-07 10:46:01', 1),
(145, 'chantier naval', 4, 2, 8, '2020-08-14 03:53:52', 1),
(148, 'tranché', 6, 2, 9, '2021-10-31 05:50:09', 1),
(150, 'offert', 2, 2, 5, '2020-05-25 04:44:51', 1),
(151, 'solennellement', 7, 3, 4, '2020-06-13 12:01:56', 1),
(152, 'moléculaire', 7, 4, 4, '2022-02-13 18:35:37', 1),
(153, 'bandes', 4, 3, 0, '2022-03-05 22:42:48', 1),
(154, 'préservé', 7, 2, 6, '2022-02-13 14:56:59', 1),
(155, 'droites', 2, 2, 8, '2021-01-24 05:17:23', 1),
(157, 'lombard', 5, 2, 3, '2020-11-14 22:50:11', 1),
(159, 'morgue', 4, 3, 1, '2020-08-12 17:13:13', 1),
(160, 'rencontrer', 6, 3, 9, '2022-03-03 01:13:51', 1),
(161, 'Reed', 7, 1, 5, '2021-09-01 10:08:35', 1),
(162, 'increvable', 3, 2, 7, '2020-09-28 13:01:39', 1),
(163, 'polémique', 7, 2, 5, '2020-01-25 23:24:08', 1),
(165, 'désarroi', 5, 3, 7, '2020-07-21 06:47:24', 1),
(166, 'congé', 4, 4, 4, '2020-12-16 13:36:41', 1),
(167, 'nase', 6, 3, 5, '2020-11-25 08:15:04', 1),
(168, 'parvenir', 4, 2, 7, '2022-03-03 02:13:49', 1),
(169, 'rose', 7, 4, 9, '2022-03-08 07:12:48', 1),
(170, 'Margarita', 7, 2, 4, '2020-07-12 07:50:01', 1),
(171, 'droites', 7, 1, 8, '2020-02-07 11:24:33', 1),
(172, 'campagne', 6, 3, 7, '2021-09-21 03:40:36', 1),
(173, 'nuisances', 4, 2, 7, '2021-09-15 22:23:55', 1),
(174, 'Margarita', 7, 3, 4, '2020-07-20 11:02:02', 1),
(175, 'allaiter', 4, 3, 7, '2022-03-04 15:00:49', 1),
(178, 'Stern', 7, 4, 9, '2021-03-24 23:17:57', 1),
(179, 'théâtres', 3, 2, 3, '2021-01-29 21:25:41', 1),
(180, 'patienter', 7, 2, 8, '2021-10-27 12:34:45', 1),
(181, 'invariable', 2, 2, 7, '2020-11-11 05:25:53', 1);

-- --------------------------------------------------------

--
-- Structure de la table `salles`
--

DROP TABLE IF EXISTS `salles`;
CREATE TABLE IF NOT EXISTS `salles` (
  `idSalle` int(11) NOT NULL AUTO_INCREMENT,
  `NomSalle` varchar(255) NOT NULL,
  `Localisation` int(11) NOT NULL,
  `ImagePresentation` text NOT NULL,
  `DescriptionPresentation` text NOT NULL,
  `NbJoueurMax` int(11) NOT NULL,
  `nbostaclemax` int(11) NOT NULL,
  `difficulte` int(11) NOT NULL,
  UNIQUE KEY `idSalle` (`idSalle`),
  KEY `Localisation` (`Localisation`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `salles`
--

INSERT INTO `salles` (`idSalle`, `NomSalle`, `Localisation`, `ImagePresentation`, `DescriptionPresentation`, `NbJoueurMax`, `nbostaclemax`, `difficulte`) VALUES
(1, 'Thonon-Les-Bains1', 2, 'thonon1.png', 'La salle de Thonon les bains a pour thème le Moyen Âge, prisonnier au sein du château du sorcier,\n vous devez par tous les moyens essayer de sortir d\'ici et vous emparer de son grimoire.\n Faites attention aux différents pièges laisser par celui-ci, ce ne sera pas tâché aisée\n que de sortir de ce dédale magique, aurez-vous les compétences et les pouvoirs nécessaires pour accomplir votre tâche ?', 78, 55, 1),
(2, 'Thonon-Les-Bains2', 2, 'thonon2.png', 'Cette salle disponible sur Thonon les bains a pour thème l\'Egypte Antique et les pharaons, vous êtes un explorateur de renoms et\nvous vous retrouvez dans un tombeau à ce jour encore inexploré, il ne tient qu\'à vous de trouver un moyen de sortir d\'ici, \nd\'échapper aux pièges mortels que les pharaons ont laissés pour vous afin de vous empêcher de trouver leur trésor.\nAurez-vous suffisament de connaissance et surtout de temps avant que le\ntombeau ne s\'effondre ? ', 7, 25, 3),
(3, 'Bonneville', 3, 'bonneville.png', 'La salle de Bonneville à un thème horreur qui vous fera frissonner, un tueur fou vous a capturer dans son établissement délabré\nafin de vous torturer, et il n\'est pas prêt de laisser partir sa proie, et vous poursuivra jusqu\'à votre mort, ou jusqu\'à ce que vous arriviez\nà sortir d\'ici avant la fin du temps impartis, 60 minutes, un tueur fou cherchant par tous les moyens à vous empêcher de sortir, une\nseule sortie disponible, serez-vous capable de survivre ? ', 4, 7, 5),
(4, 'Chamonix', 4, 'cham1.png', 'Cette salle disponible sur Chamonix a pour thème la science-fiction, vous vous verrez transporter dans un vaisseau spatial en direction\nd\'une nouvelle planète habitable, malheureusement, un problème lié aux moteurs vous empêche d\'atteindre votre destination, vous devez rejoindre\nau plus vite les capsules de sauvetage afin de rejoindre la planète avant que le vaisseau n\'explose, saurez-vous les atteindre et déjouer\nles systèmes de sécurité ? C\'est à vous d\'en décider.', 2, 8, 2);

-- --------------------------------------------------------

--
-- Structure de la table `tarification`
--

DROP TABLE IF EXISTS `tarification`;
CREATE TABLE IF NOT EXISTS `tarification` (
  `IdTarif` int(11) NOT NULL AUTO_INCREMENT,
  `Prix_Heure` int(11) DEFAULT NULL,
  `Prix_Obstacle` int(11) DEFAULT NULL,
  `Prix_Joueur` int(11) DEFAULT NULL,
  `IdSalle` int(11) DEFAULT NULL,
  PRIMARY KEY (`IdTarif`),
  KEY `IdSalle` (`IdSalle`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `tarification`
--

INSERT INTO `tarification` (`IdTarif`, `Prix_Heure`, `Prix_Obstacle`, `Prix_Joueur`, `IdSalle`) VALUES
(1, 5, 7, 2, 1),
(2, 8, 4, 44, 2),
(3, 89, 3, 22, 3),
(4, 5, 7, 1, 4);

-- --------------------------------------------------------

--
-- Structure de la table `temoignages`
--

DROP TABLE IF EXISTS `temoignages`;
CREATE TABLE IF NOT EXISTS `temoignages` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `type` enum('Texte','Image') DEFAULT NULL,
  `value` text NOT NULL,
  `auteur` varchar(255) NOT NULL,
  `date` date NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `temoignages`
--

INSERT INTO `temoignages` (`id`, `type`, `value`, `auteur`, `date`) VALUES
(1, 'Texte', 'Premier escape depuis la réouverture des salles et quelle belle découverte ! Nous avons joué la salle de l\'étrange univers de Globule à deux (nous avons une grosse vingtaine de salle à notre actif) et nous avons passé un excellent moment. Cette salle vous fait oublier tout les mécanismes traditionnels de l\'escape game et vous emmène dans un monde à part. Les énigmes sont nombreuses et très fluides, on ne s\'ennuie jamais. Les décors sont top et pour couronner le tout l\'équipe est adorable. Quel que soit votre niveau ou le nombre de salles jouées foncez vous ne serez pas déçu !\r\nAu plaisir de venir jouer les autres salles !', 'Juliette Thomas', '2021-11-24'),
(2, 'Texte', 'Suite à une super expérience dans cet escape lors de nos dernières vacances à Annecy, nous en avons profité  lors de notre passage dans la région pour découvrir cette année les 2 autres salles.\r\nNous avons commencé par faire Globule en couple, et c était vraiment génial de partager ce moment dans cette salle qui change des escapes traditionnels et où on ne s ennuie pas une seconde. Expérience incroyable.\r\nPuis nous sommes revenus avec ma soeur pour Hannibal et je n\'oublierai jamais cette salle horreur. Je vous la conseille vivement.\r\nEt équipe au top du top.', 'Audrey NOYON', '2021-10-06'),
(3, 'Texte', 'L\'Antre d\'Hannibal ! Une de mes salles préférée ! Grrrrr je ne peux rien dire, mais dès les premiers secondes le ton est donné ! On se croit en danger en permanence ... Apparemment, on est les seuls à l\'avoir réussi à 2 ! Donc lâchez vos neurones et foncez ! Elle déchire (La peau) ! Lety & Gian, Les Metallicadenas.', 'Lety Howl', '2021-11-05'),
(4, 'Image', 'https://lvdneng.rosselcdn.net/sites/default/files/dpistyles_v2/ena_16_9_extra_big/2019/11/01/node_660087/42198643/public/2019/11/01/B9721439798Z.1_20191101145529_000%2BG3GEQDTSG.1-0.jpg?itok=SK_UaWTO1572616540', 'Louis ARMAND', '2021-12-23'),
(5, 'Image', 'https://publigeekaire.com/wp-content/uploads/2017/07/escape-game-google.jpg', 'Catherine Kinka', '2021-12-05'),
(6, 'Image', 'https://media.sudouest.fr/4560034/1000x500/sudouest-photo-1-25525271.jpg?v=1628695749', 'Issam Veokda', '2021-11-18'),
(7, 'Image', 'https://www.escapegame-in-time.com/images/sederoule-escapegame/sederoule-escapegame-img1.jpg', 'Lara Gentiel', '2021-09-10');

-- --------------------------------------------------------

--
-- Structure de la table `utilisateurs`
--

DROP TABLE IF EXISTS `utilisateurs`;
CREATE TABLE IF NOT EXISTS `utilisateurs` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `email` varchar(255) NOT NULL,
  `motdepasse` varchar(255) NOT NULL,
  `grade` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `utilisateurs`
--

INSERT INTO `utilisateurs` (`id`, `email`, `motdepasse`, `grade`) VALUES
(1, 'yanish', 'aa36dc6e81e2ac7ad03e12fedcb6a2c0', 2);

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `salles`
--
ALTER TABLE `salles`
  ADD CONSTRAINT `Salles_ibfk_1` FOREIGN KEY (`Localisation`) REFERENCES `lieuxactivites` (`idLieu`);

--
-- Contraintes pour la table `tarification`
--
ALTER TABLE `tarification`
  ADD CONSTRAINT `tarification_ibfk_1` FOREIGN KEY (`IdSalle`) REFERENCES `salles` (`idSalle`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
