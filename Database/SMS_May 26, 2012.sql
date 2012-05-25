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
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `employees` */

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
  CONSTRAINT `FK_employeessections` FOREIGN KEY (`SectionID`) REFERENCES `sections` (`SectionID`),
  CONSTRAINT `FK_employeessection` FOREIGN KEY (`EmployeeID`) REFERENCES `employees` (`EmployeeID`)
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
  `RFID` varchar(100) DEFAULT NULL,
  `Note` varchar(500) DEFAULT NULL,
  `CreatedBy` int(11) NOT NULL,
  `CreatedDate` datetime NOT NULL,
  `ModifiedBy` int(11) DEFAULT NULL,
  `ModifiedDate` datetime DEFAULT NULL,
  PRIMARY KEY (`GuardianID`)
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
  CONSTRAINT `FK_guardiansstudents` FOREIGN KEY (`StudentID`) REFERENCES `students` (`StudentID`),
  CONSTRAINT `FK_guardiansstudent` FOREIGN KEY (`GuardianID`) REFERENCES `guardians` (`GuardianID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `guardians_student` */

/*Table structure for table `sections` */

DROP TABLE IF EXISTS `sections`;

CREATE TABLE `sections` (
  `SectionID` int(11) NOT NULL AUTO_INCREMENT,
  `SectionName` varchar(100) DEFAULT NULL,
  `CreatedBy` int(11) DEFAULT NULL,
  `CreatedDate` datetime DEFAULT NULL,
  `ModifiedBy` int(11) DEFAULT NULL,
  `ModifiedDate` datetime DEFAULT NULL,
  PRIMARY KEY (`SectionID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `sections` */

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
  `RFID` varchar(100) DEFAULT NULL,
  `Note` varchar(500) DEFAULT NULL,
  `Active` tinyint(1) NOT NULL,
  `CreatedBy` int(11) DEFAULT NULL,
  `CreatedDate` datetime DEFAULT NULL,
  `ModifiedBy` int(11) DEFAULT NULL,
  `ModifiedDate` datetime DEFAULT NULL,
  PRIMARY KEY (`StudentID`),
  KEY `FK_students` (`SectionID`),
  CONSTRAINT `FK_students` FOREIGN KEY (`SectionID`) REFERENCES `sections` (`SectionID`)
) ENGINE=InnoDB AUTO_INCREMENT=30 DEFAULT CHARSET=latin1;

/*Data for the table `students` */

insert  into `students`(`StudentID`,`StudentNumber`,`FirstName`,`MiddleName`,`LastName`,`Birthday`,`ImagePath`,`EmailAddress`,`SectionID`,`RFID`,`Note`,`Active`,`CreatedBy`,`CreatedDate`,`ModifiedBy`,`ModifiedDate`) values (1,'087-2010-0020','Gladys','Cabuhat','Valeriano','1989-08-09',NULL,NULL,NULL,NULL,'Very Good',0,NULL,NULL,NULL,NULL),(2,'087-2010-0022','Gemma Rica','Santiago','Chua','1990-11-16',NULL,NULL,NULL,NULL,':D Good :D',0,NULL,NULL,NULL,NULL),(3,'087-2010-0009','Jaypee','Dela Cruz','Porciunculla','1988-10-01',NULL,NULL,NULL,NULL,'',0,NULL,NULL,NULL,NULL),(4,'087-2010-0023','Jun','Garces','Gialogo','1987-06-17',NULL,NULL,NULL,NULL,'',0,NULL,NULL,NULL,NULL),(5,'087-2010-0025','Roxanne','Obliosca','Banluta','1991-11-11',NULL,NULL,NULL,NULL,'',0,NULL,NULL,NULL,NULL),(6,'087-2010-0008','Ryam','C','Fernando','1989-11-22',NULL,NULL,NULL,NULL,'Very Good',0,NULL,NULL,NULL,NULL),(7,'087-2010-0011','Emilio','Parfahn','Villanueva','1988-09-05',NULL,NULL,NULL,NULL,'Good',0,NULL,NULL,NULL,NULL),(8,'087-2010-0030','Aive','D','Kalos','2010-10-24',NULL,NULL,NULL,NULL,'',0,NULL,NULL,NULL,NULL),(9,'087-2010-0042','Gorgonio','Jombo','Cruz','1987-02-04',NULL,NULL,NULL,NULL,'SAMPLE',0,NULL,NULL,NULL,NULL),(10,'087-2010-0004','Jasmine','Dsa','Torno','1984-09-30',NULL,NULL,NULL,NULL,'',0,NULL,NULL,NULL,NULL),(11,'087-2010-0007','John Carlo','Delos Reyes','Cruz','1987-04-14',NULL,NULL,NULL,NULL,'',0,NULL,NULL,NULL,NULL),(12,'087-2010-0014','Marie Christine','Quinzon','Ventura','2010-09-24',NULL,NULL,NULL,NULL,'',0,NULL,NULL,NULL,NULL),(13,'087-2010-0017','Ronald','Acuesta','Trinidad','1990-04-20',NULL,NULL,NULL,NULL,'Good',0,NULL,NULL,NULL,NULL),(14,'087-2010-0026','Alan','L','Perjes','1988-04-28',NULL,NULL,NULL,NULL,'',0,NULL,NULL,NULL,NULL),(15,'087-2010-0024','Arianne Giselle','Abaya','Soberano','1990-09-20',NULL,NULL,NULL,NULL,'',0,NULL,NULL,NULL,NULL),(16,'087-2010-0027','Vince','S','Abosolo','1988-10-23',NULL,NULL,NULL,NULL,'',0,NULL,NULL,NULL,NULL),(17,'087-2010-0029','Moniena','Moreno','Santiago','1993-12-14',NULL,NULL,NULL,NULL,'',0,NULL,NULL,NULL,NULL),(18,'087-2010-0003','Maan','S.','Talabia','1983-09-30',NULL,NULL,NULL,NULL,'',0,NULL,NULL,NULL,NULL),(19,'087-2010-0005','Jaja','Santiago','Vasquez','1988-10-29',NULL,NULL,NULL,NULL,'',0,NULL,NULL,NULL,NULL),(20,'087-2010-0010','Iris Erika','Reynaldo','Reyes','1986-09-06',NULL,NULL,NULL,NULL,'very good',0,NULL,NULL,NULL,NULL),(21,'087-2010-0012','Karla Chriselda','Avendaño','Castillio','1988-04-14',NULL,NULL,NULL,NULL,'',0,NULL,NULL,NULL,NULL),(22,'087-2010-0018','Myra','Casidsid','Flores','1989-11-01',NULL,NULL,NULL,NULL,'Good',0,NULL,NULL,NULL,NULL),(23,'087-2010-0019','Krisanto','Perceverancia','Rey','1990-03-18',NULL,NULL,NULL,NULL,'record of theft and jailed once',0,NULL,NULL,NULL,NULL),(24,'087-2010-0002','Jaecov','Santiago','Vasquez','1987-05-04',NULL,NULL,NULL,NULL,'',0,NULL,NULL,NULL,NULL),(25,'087-2010-0006','Ma. Lou-Anne','Yao','Dino','1988-09-21',NULL,NULL,NULL,NULL,'',0,NULL,NULL,NULL,NULL),(26,'087-2010-0016','Mark William','T','Zafra','1987-05-31',NULL,NULL,NULL,NULL,'Good',0,NULL,NULL,NULL,NULL),(27,'087-2010-0015','Nazer','Santiago','Miranda','1987-07-18',NULL,NULL,NULL,NULL,'',0,NULL,NULL,NULL,NULL),(28,'087-2010-0013','Ruby','Palallos','Palma','1990-09-27',NULL,NULL,NULL,NULL,'very good',0,NULL,NULL,NULL,NULL),(29,'087-2012-0044','King','Qwdqwdcqwrw','Wdqwdqw','1986-05-16',NULL,NULL,NULL,NULL,'',0,NULL,NULL,NULL,NULL);

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

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
