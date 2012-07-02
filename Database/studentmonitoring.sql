/*
SQLyog Ultimate v9.50 
MySQL - 5.5.25 : Database - studentmonitoring
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`studentmonitoring` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `studentmonitoring`;

/*Table structure for table `core_civilstatus` */

DROP TABLE IF EXISTS `core_civilstatus`;

CREATE TABLE `core_civilstatus` (
  `id` int(11) NOT NULL,
  `name` varchar(20) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `core_civilstatus` */

insert  into `core_civilstatus`(`id`,`name`) values (1,'Single'),(2,'Married'),(3,'');

/*Table structure for table `core_gender` */

DROP TABLE IF EXISTS `core_gender`;

CREATE TABLE `core_gender` (
  `id` int(11) NOT NULL,
  `name` varchar(10) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `core_gender` */

insert  into `core_gender`(`id`,`name`) values (1,'Male'),(2,'Female');

/*Table structure for table `core_student` */

DROP TABLE IF EXISTS `core_student`;

CREATE TABLE `core_student` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `number` varchar(50) NOT NULL,
  `firstname` varchar(100) NOT NULL,
  `middlename` varchar(100) NOT NULL,
  `lastname` varchar(100) NOT NULL,
  `dateofbirth` date NOT NULL,
  `gender_id` int(11) NOT NULL,
  `civilstatus_id` int(11) NOT NULL,
  `citizenship` varchar(50) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `core_civilstatus_core_student` (`civilstatus_id`),
  KEY `core_gender_core_student` (`gender_id`),
  CONSTRAINT `core_civilstatus_core_student` FOREIGN KEY (`civilstatus_id`) REFERENCES `core_civilstatus` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `core_gender_core_student` FOREIGN KEY (`gender_id`) REFERENCES `core_gender` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;

/*Data for the table `core_student` */

insert  into `core_student`(`id`,`number`,`firstname`,`middlename`,`lastname`,`dateofbirth`,`gender_id`,`civilstatus_id`,`citizenship`) values (6,'201272-1352359','firstname','middlename','lastname','2012-07-02',1,1,'filipino');

/*Table structure for table `vstudentinfo` */

DROP TABLE IF EXISTS `vstudentinfo`;

/*!50001 DROP VIEW IF EXISTS `vstudentinfo` */;
/*!50001 DROP TABLE IF EXISTS `vstudentinfo` */;

/*!50001 CREATE TABLE  `vstudentinfo`(
 `id` int(11) ,
 `number` varchar(50) ,
 `firstname` varchar(100) ,
 `middlename` varchar(100) ,
 `lastname` varchar(100) ,
 `dateofbirth` date ,
 `citizenship` varchar(50) ,
 `gender_id` int(11) ,
 `gender` varchar(10) ,
 `civilstatus_id` int(11) ,
 `civilstatus` varchar(20) 
)*/;

/*View structure for view vstudentinfo */

/*!50001 DROP TABLE IF EXISTS `vstudentinfo` */;
/*!50001 DROP VIEW IF EXISTS `vstudentinfo` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vstudentinfo` AS select `s`.`id` AS `id`,`s`.`number` AS `number`,`s`.`firstname` AS `firstname`,`s`.`middlename` AS `middlename`,`s`.`lastname` AS `lastname`,`s`.`dateofbirth` AS `dateofbirth`,`s`.`citizenship` AS `citizenship`,`s`.`gender_id` AS `gender_id`,`g`.`name` AS `gender`,`s`.`civilstatus_id` AS `civilstatus_id`,`cs`.`name` AS `civilstatus` from ((`core_student` `s` join `core_gender` `g` on((`s`.`gender_id` = `g`.`id`))) join `core_civilstatus` `cs` on((`s`.`civilstatus_id` = `cs`.`id`))) */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
