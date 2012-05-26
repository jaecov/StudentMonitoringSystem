/*
SQLyog Ultimate v8.55 
MySQL - 5.5.19 : Database - sms
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`sms` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `sms`;

/*Table structure for table `employees` */

DROP TABLE IF EXISTS `employees`;

CREATE TABLE `employees` (
  `EmployeeID` int(11) NOT NULL AUTO_INCREMENT,
  `EmployeeNumber` varchar(100) NOT NULL,
  `Password` varchar(100) DEFAULT NULL,
  `FirstName` varchar(100) NOT NULL,
  `MiddleName` varchar(100) NOT NULL,
  `LastName` varchar(100) NOT NULL,
  `Birthday` date NOT NULL,
  `ImagePath` varchar(500) DEFAULT NULL,
  `EmailAddress` varchar(100) DEFAULT NULL,
  `RFID` varchar(100) DEFAULT NULL,
  `Note` varchar(500) DEFAULT NULL,
  `CreatedBy` int(11) DEFAULT NULL,
  `CreatedDate` datetime DEFAULT NULL,
  `ModifiedBy` int(11) DEFAULT NULL,
  `ModifiedDate` datetime DEFAULT NULL,
  PRIMARY KEY (`EmployeeID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

/*Data for the table `employees` */

insert  into `employees`(`EmployeeID`,`EmployeeNumber`,`Password`,`FirstName`,`MiddleName`,`LastName`,`Birthday`,`ImagePath`,`EmailAddress`,`RFID`,`Note`,`CreatedBy`,`CreatedDate`,`ModifiedBy`,`ModifiedDate`) values (1,'1','1','administrator','','','2012-01-01',NULL,NULL,NULL,NULL,1,'2012-01-01 00:00:00',NULL,NULL);

/*Table structure for table `employees_section` */

DROP TABLE IF EXISTS `employees_section`;

CREATE TABLE `employees_section` (
  `EmployeeID` int(11) NOT NULL,
  `SectionID` int(11) NOT NULL,
  `CreatedBy` int(11) NOT NULL,
  `CreatedDate` datetime NOT NULL,
  `ModifiedBy` int(11) DEFAULT NULL,
  `ModifiedDate` datetime DEFAULT NULL,
  KEY `FK_guardiansstudent` (`EmployeeID`),
  KEY `FK_guardiansstudents` (`SectionID`),
  KEY `FK_employees_sectiondf` (`CreatedBy`),
  KEY `FK_employees_sectiongfhfg` (`ModifiedBy`),
  CONSTRAINT `FK_employees_sectiongfhfg` FOREIGN KEY (`ModifiedBy`) REFERENCES `employees` (`EmployeeID`),
  CONSTRAINT `FK_employees_section` FOREIGN KEY (`SectionID`) REFERENCES `sections` (`SectionID`),
  CONSTRAINT `FK_employees_sectionb` FOREIGN KEY (`EmployeeID`) REFERENCES `employees` (`EmployeeID`),
  CONSTRAINT `FK_employees_sectiondf` FOREIGN KEY (`CreatedBy`) REFERENCES `employees` (`EmployeeID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `employees_section` */

/*Table structure for table `guardians` */

DROP TABLE IF EXISTS `guardians`;

CREATE TABLE `guardians` (
  `GuardianID` int(11) NOT NULL,
  `FirstName` varchar(100) NOT NULL,
  `MiddleName` varchar(100) NOT NULL,
  `LastName` varchar(100) NOT NULL,
  `Birthday` date DEFAULT NULL,
  `ImagePath` varchar(500) DEFAULT NULL,
  `EmailAddress` varchar(100) DEFAULT NULL,
  `RFID` varchar(100) DEFAULT NULL COMMENT 'RFID hex code',
  `Note` varchar(500) DEFAULT NULL,
  `AutomaticSMS` tinyint(1) NOT NULL COMMENT 'if True, system will include the number as recepient',
  `AutomaticEmail` tinyint(1) NOT NULL COMMENT 'if True, system will include the email as recepient',
  `Active` tinyint(1) NOT NULL COMMENT 'Flag as soft delete',
  `CreatedBy` int(11) NOT NULL,
  `CreatedDate` datetime NOT NULL,
  `ModifiedBy` int(11) DEFAULT NULL,
  `ModifiedDate` datetime DEFAULT NULL,
  PRIMARY KEY (`GuardianID`),
  KEY `FK_guardians` (`CreatedBy`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `guardians` */

/*Table structure for table `guardians_mobile` */

DROP TABLE IF EXISTS `guardians_mobile`;

CREATE TABLE `guardians_mobile` (
  `GuardianID` int(11) NOT NULL,
  `MobileNumber` varchar(20) NOT NULL,
  `CreatedBy` int(11) NOT NULL,
  `CreatedDate` datetime NOT NULL,
  `ModifiedBy` int(11) DEFAULT NULL,
  `ModifiedDate` datetime DEFAULT NULL,
  KEY `FK_guardiansmobile` (`GuardianID`),
  CONSTRAINT `FK_guardiansmobile` FOREIGN KEY (`GuardianID`) REFERENCES `guardians` (`GuardianID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `guardians_mobile` */

/*Table structure for table `guardians_student` */

DROP TABLE IF EXISTS `guardians_student`;

CREATE TABLE `guardians_student` (
  `GuardianID` int(11) NOT NULL,
  `StudentID` int(11) NOT NULL,
  `Relationship` varchar(100) DEFAULT NULL,
  `CreatedBy` int(11) NOT NULL,
  `CreatedDate` datetime NOT NULL,
  `ModifiedBy` int(11) DEFAULT NULL,
  `ModifiedDate` datetime DEFAULT NULL,
  KEY `FK_guardiansstudent` (`GuardianID`),
  KEY `FK_guardiansstudents` (`StudentID`),
  CONSTRAINT `FK_guardiansstudent` FOREIGN KEY (`GuardianID`) REFERENCES `guardians` (`GuardianID`),
  CONSTRAINT `FK_guardiansstudents` FOREIGN KEY (`StudentID`) REFERENCES `students` (`StudentID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `guardians_student` */

/*Table structure for table `sections` */

DROP TABLE IF EXISTS `sections`;

CREATE TABLE `sections` (
  `SectionID` int(11) NOT NULL AUTO_INCREMENT,
  `SectionName` varchar(100) NOT NULL,
  `CreatedBy` int(11) NOT NULL,
  `CreatedDate` datetime NOT NULL,
  `ModifiedBy` int(11) DEFAULT NULL,
  `ModifiedDate` datetime DEFAULT NULL,
  PRIMARY KEY (`SectionID`),
  KEY `FK_sections` (`CreatedBy`),
  KEY `FK_sectionsfg` (`ModifiedBy`),
  CONSTRAINT `FK_sectionsfg` FOREIGN KEY (`ModifiedBy`) REFERENCES `employees` (`EmployeeID`),
  CONSTRAINT `FK_sections` FOREIGN KEY (`CreatedBy`) REFERENCES `employees` (`EmployeeID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

/*Data for the table `sections` */

insert  into `sections`(`SectionID`,`SectionName`,`CreatedBy`,`CreatedDate`,`ModifiedBy`,`ModifiedDate`) values (1,'P1',1,'2012-01-01 00:00:00',NULL,NULL),(2,'P2',1,'2012-01-01 00:00:00',NULL,NULL),(3,'P3',1,'2012-01-01 00:00:00',NULL,NULL);

/*Table structure for table `sms_guardians` */

DROP TABLE IF EXISTS `sms_guardians`;

CREATE TABLE `sms_guardians` (
  `TextID` int(11) NOT NULL AUTO_INCREMENT,
  `GuardianID` int(11) NOT NULL,
  `Message` varchar(250) NOT NULL,
  `SentDate` datetime DEFAULT NULL,
  `CreatedBy` int(11) NOT NULL,
  `CreatedDate` datetime NOT NULL,
  PRIMARY KEY (`TextID`),
  KEY `FK_smspendingmessage` (`GuardianID`),
  CONSTRAINT `FK_sms_guardians` FOREIGN KEY (`GuardianID`) REFERENCES `guardians` (`GuardianID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `sms_guardians` */

/*Table structure for table `sms_inbox` */

DROP TABLE IF EXISTS `sms_inbox`;

CREATE TABLE `sms_inbox` (
  `InboxID` int(11) NOT NULL AUTO_INCREMENT,
  `MobileNumber` varchar(20) NOT NULL,
  `Message` varchar(500) DEFAULT NULL,
  `ReceivedDate` datetime NOT NULL,
  PRIMARY KEY (`InboxID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `sms_inbox` */

/*Table structure for table `sms_pending_guardians` */

DROP TABLE IF EXISTS `sms_pending_guardians`;

CREATE TABLE `sms_pending_guardians` (
  `TextID` int(11) NOT NULL AUTO_INCREMENT,
  `GuardianID` int(11) NOT NULL,
  `Message` varchar(250) DEFAULT NULL,
  `CreatedBy` int(11) NOT NULL,
  `CreatedDate` datetime NOT NULL,
  PRIMARY KEY (`TextID`),
  KEY `FK_sms_pending_guardians` (`GuardianID`),
  CONSTRAINT `FK_sms_pending_guardians` FOREIGN KEY (`GuardianID`) REFERENCES `guardians` (`GuardianID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `sms_pending_guardians` */

/*Table structure for table `sms_pending_students` */

DROP TABLE IF EXISTS `sms_pending_students`;

CREATE TABLE `sms_pending_students` (
  `TextID` int(11) NOT NULL AUTO_INCREMENT,
  `StudentID` int(11) NOT NULL,
  `Message` varchar(250) NOT NULL,
  `CreatedBy` int(11) NOT NULL,
  `CreatedDate` datetime NOT NULL,
  PRIMARY KEY (`TextID`),
  KEY `FK_smspendingmessage` (`StudentID`),
  CONSTRAINT `FK_smspendingmessage` FOREIGN KEY (`StudentID`) REFERENCES `students` (`StudentID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `sms_pending_students` */

/*Table structure for table `sms_students` */

DROP TABLE IF EXISTS `sms_students`;

CREATE TABLE `sms_students` (
  `TextID` int(11) NOT NULL AUTO_INCREMENT,
  `StudentID` int(11) NOT NULL,
  `Message` varchar(250) NOT NULL,
  `SentDate` datetime DEFAULT NULL,
  `CreatedBy` int(11) NOT NULL,
  `CreatedDate` datetime NOT NULL,
  PRIMARY KEY (`TextID`),
  KEY `FK_smspendingmessage` (`StudentID`),
  CONSTRAINT `FK_sms_students` FOREIGN KEY (`StudentID`) REFERENCES `students` (`StudentID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `sms_students` */

/*Table structure for table `students` */

DROP TABLE IF EXISTS `students`;

CREATE TABLE `students` (
  `StudentID` int(11) NOT NULL AUTO_INCREMENT,
  `StudentNumber` varchar(100) NOT NULL,
  `FirstName` varchar(100) NOT NULL,
  `MiddleName` varchar(100) NOT NULL,
  `LastName` varchar(100) NOT NULL,
  `Birthday` date NOT NULL,
  `ImagePath` varchar(500) DEFAULT NULL,
  `EmailAddress` varchar(100) DEFAULT NULL,
  `SectionID` int(11) DEFAULT NULL,
  `RFID` varchar(100) DEFAULT NULL COMMENT 'RFID hex code',
  `Note` varchar(500) DEFAULT NULL,
  `Active` tinyint(1) NOT NULL COMMENT 'flag as soft delete',
  `CreatedBy` int(11) NOT NULL,
  `CreatedDate` datetime NOT NULL,
  `ModifiedBy` int(11) DEFAULT NULL,
  `ModifiedDate` datetime DEFAULT NULL,
  PRIMARY KEY (`StudentID`),
  KEY `FK_students` (`SectionID`),
  KEY `FK_studentsw` (`CreatedBy`),
  KEY `FK_studentsggg` (`ModifiedBy`),
  CONSTRAINT `FK_studentsggg` FOREIGN KEY (`ModifiedBy`) REFERENCES `employees` (`EmployeeID`),
  CONSTRAINT `FK_students` FOREIGN KEY (`SectionID`) REFERENCES `sections` (`SectionID`),
  CONSTRAINT `FK_studentsw` FOREIGN KEY (`CreatedBy`) REFERENCES `employees` (`EmployeeID`)
) ENGINE=InnoDB AUTO_INCREMENT=30 DEFAULT CHARSET=latin1;

/*Data for the table `students` */

insert  into `students`(`StudentID`,`StudentNumber`,`FirstName`,`MiddleName`,`LastName`,`Birthday`,`ImagePath`,`EmailAddress`,`SectionID`,`RFID`,`Note`,`Active`,`CreatedBy`,`CreatedDate`,`ModifiedBy`,`ModifiedDate`) values (1,'087-2010-0020','Gladys','Cabuhat','Valeriano','1989-08-09',NULL,NULL,1,NULL,'Very Good',1,1,'2012-01-01 00:00:00',NULL,'2012-01-01 00:00:00'),(2,'087-2010-0022','Gemma Rica','Santiago','Chua','1990-11-16',NULL,NULL,1,NULL,':D Good :D',1,1,'2012-01-01 00:00:00',NULL,'2012-01-01 00:00:00'),(3,'087-2010-0009','Jaypee','Dela Cruz','Porciunculla','1988-10-01',NULL,NULL,1,NULL,'',1,1,'2012-01-01 00:00:00',NULL,'2012-01-01 00:00:00'),(4,'087-2010-0023','Jun','Garces','Gialogo','1987-06-17',NULL,NULL,1,NULL,'',1,1,'2012-01-01 00:00:00',NULL,'2012-01-01 00:00:00'),(5,'087-2010-0025','Roxanne','Obliosca','Banluta','1991-11-11',NULL,NULL,2,NULL,'',1,1,'2012-01-01 00:00:00',NULL,'2012-01-01 00:00:00'),(6,'087-2010-0008','Ryam','C','Fernando','1989-11-22',NULL,NULL,1,NULL,'Very Good',1,1,'2012-01-01 00:00:00',NULL,'2012-01-01 00:00:00'),(7,'087-2010-0011','Emilio','Parfahn','Villanueva','1988-09-05',NULL,NULL,2,NULL,'Good',1,1,'2012-01-01 00:00:00',NULL,'2012-01-01 00:00:00'),(8,'087-2010-0030','Aive','D','Kalos','2010-10-24',NULL,NULL,1,NULL,'',1,1,'2012-01-01 00:00:00',NULL,'2012-01-01 00:00:00'),(9,'087-2010-0042','Gorgonio','Jombo','Cruz','1987-02-04',NULL,NULL,2,NULL,'SAMPLE',1,1,'2012-01-01 00:00:00',NULL,'2012-01-01 00:00:00'),(10,'087-2010-0004','Jasmine','Dsa','Torno','1984-09-30',NULL,NULL,1,NULL,'',1,1,'2012-01-01 00:00:00',NULL,'2012-01-01 00:00:00'),(11,'087-2010-0007','John Carlo','Delos Reyes','Cruz','1987-04-14',NULL,NULL,1,NULL,'',1,1,'2012-01-01 00:00:00',NULL,'2012-01-01 00:00:00'),(12,'087-2010-0014','Marie Christine','Quinzon','Ventura','2010-09-24',NULL,NULL,1,NULL,'',1,1,'2012-01-01 00:00:00',NULL,'2012-01-01 00:00:00'),(13,'087-2010-0017','Ronald','Acuesta','Trinidad','1990-04-20',NULL,NULL,1,NULL,'Good',1,1,'2012-01-01 00:00:00',NULL,'2012-01-01 00:00:00'),(14,'087-2010-0026','Alan','L','Perjes','1988-04-28',NULL,NULL,1,NULL,'',1,1,'2012-01-01 00:00:00',NULL,'2012-01-01 00:00:00'),(15,'087-2010-0024','Arianne Giselle','Abaya','Soberano','1990-09-20',NULL,NULL,1,NULL,'',1,1,'2012-01-01 00:00:00',NULL,'2012-01-01 00:00:00'),(16,'087-2010-0027','Vince','S','Abosolo','1988-10-23',NULL,NULL,1,NULL,'',1,1,'2012-01-01 00:00:00',NULL,'2012-01-01 00:00:00'),(17,'087-2010-0029','Moniena','Moreno','Santiago','1993-12-14',NULL,NULL,1,NULL,'',1,1,'2012-01-01 00:00:00',NULL,'2012-01-01 00:00:00'),(18,'087-2010-0003','Maan','S.','Talabia','1983-09-30',NULL,NULL,1,NULL,'',1,1,'2012-01-01 00:00:00',NULL,'2012-01-01 00:00:00'),(19,'087-2010-0005','Jaja','Santiago','Vasquez','1988-10-29',NULL,NULL,1,NULL,'',1,1,'2012-01-01 00:00:00',NULL,'2012-01-01 00:00:00'),(20,'087-2010-0010','Iris Erika','Reynaldo','Reyes','1986-09-06',NULL,NULL,1,NULL,'very good',1,1,'2012-01-01 00:00:00',NULL,'2012-01-01 00:00:00'),(21,'087-2010-0012','Karla Chriselda','Avendaño','Castillio','1988-04-14',NULL,NULL,1,NULL,'',1,1,'2012-01-01 00:00:00',NULL,'2012-01-01 00:00:00'),(22,'087-2010-0018','Myra','Casidsid','Flores','1989-11-01',NULL,NULL,1,NULL,'Good',1,1,'2012-01-01 00:00:00',NULL,'2012-01-01 00:00:00'),(23,'087-2010-0019','Krisanto','Perceverancia','Rey','1990-03-18',NULL,NULL,1,NULL,'record of theft and jailed once',1,1,'2012-01-01 00:00:00',NULL,'2012-01-01 00:00:00'),(24,'087-2010-0002','Jaecov','Santiago','Vasquez','1987-05-04',NULL,NULL,1,NULL,'',1,1,'2012-01-01 00:00:00',NULL,'2012-01-01 00:00:00'),(25,'087-2010-0006','Ma. Lou-Anne','Yao','Dino','1988-09-21',NULL,NULL,1,NULL,'',1,1,'2012-01-01 00:00:00',NULL,'2012-01-01 00:00:00'),(26,'087-2010-0016','Mark William','T','Zafra','1987-05-31',NULL,NULL,1,NULL,'Good',1,1,'2012-01-01 00:00:00',NULL,'2012-01-01 00:00:00'),(27,'087-2010-0015','Nazer','Santiago','Miranda','1987-07-18',NULL,NULL,1,NULL,'',1,1,'2012-01-01 00:00:00',NULL,'2012-01-01 00:00:00'),(28,'087-2010-0013','Ruby','Palallos','Palma','1990-09-27',NULL,NULL,1,NULL,'very good',1,1,'2012-01-01 00:00:00',NULL,'2012-01-01 00:00:00'),(29,'087-2012-0044','King','Qwdqwdcqwrw','Wdqwdqw','1986-05-16',NULL,NULL,1,NULL,'',1,1,'2012-01-01 00:00:00',NULL,'2012-01-01 00:00:00');

/*Table structure for table `students_mobile` */

DROP TABLE IF EXISTS `students_mobile`;

CREATE TABLE `students_mobile` (
  `StudentID` int(11) NOT NULL,
  `MobileNumber` varchar(20) NOT NULL,
  `CreatedBy` int(11) NOT NULL,
  `CreatedDate` datetime NOT NULL,
  `ModifiedBy` int(11) DEFAULT NULL,
  `ModifiedDate` datetime DEFAULT NULL,
  KEY `FK_studentsmobile` (`StudentID`),
  CONSTRAINT `FK_studentsmobile` FOREIGN KEY (`StudentID`) REFERENCES `students` (`StudentID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `students_mobile` */

insert  into `students_mobile`(`StudentID`,`MobileNumber`,`CreatedBy`,`CreatedDate`,`ModifiedBy`,`ModifiedDate`) values (1,'222222',1,'2012-01-01 00:00:00',NULL,NULL),(1,'333333',1,'2012-01-01 00:00:00',NULL,NULL);

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
