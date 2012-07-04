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

/*Table structure for table `audt_audittrail` */

DROP TABLE IF EXISTS `audt_audittrail`;

CREATE TABLE `audt_audittrail` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `message` longtext NOT NULL,
  `isexception` bit(1) NOT NULL,
  `datecreated` datetime NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `audt_audittrail` */

/*Table structure for table `audt_log` */

DROP TABLE IF EXISTS `audt_log`;

CREATE TABLE `audt_log` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `tablename` varchar(50) NOT NULL,
  `rowid` int(11) NOT NULL,
  `command` varchar(50) NOT NULL,
  `savedby` varchar(50) NOT NULL,
  `datecreated` datetime NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `audt_log` */

/*Table structure for table `core_barangay` */

DROP TABLE IF EXISTS `core_barangay`;

CREATE TABLE `core_barangay` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL,
  `city_id` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `core_barangay_city` (`city_id`),
  CONSTRAINT `core_barangay_city` FOREIGN KEY (`city_id`) REFERENCES `core_city` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

/*Data for the table `core_barangay` */

insert  into `core_barangay`(`id`,`name`,`city_id`) values (1,'Pinmilapil',1),(3,'Olympia',2);

/*Table structure for table `core_city` */

DROP TABLE IF EXISTS `core_city`;

CREATE TABLE `core_city` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL,
  `province_id` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `core_city_province` (`province_id`),
  CONSTRAINT `core_city_province` FOREIGN KEY (`province_id`) REFERENCES `core_province` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

/*Data for the table `core_city` */

insert  into `core_city`(`id`,`name`,`province_id`) values (1,'Sison',1),(2,'Makati',2),(3,'Manila',2),(4,'Caloocan City',2);

/*Table structure for table `core_civilstatus` */

DROP TABLE IF EXISTS `core_civilstatus`;

CREATE TABLE `core_civilstatus` (
  `id` int(11) NOT NULL,
  `name` varchar(20) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `core_civilstatus` */

insert  into `core_civilstatus`(`id`,`name`) values (1,'Single'),(2,'Married'),(3,'');

/*Table structure for table `core_contact` */

DROP TABLE IF EXISTS `core_contact`;

CREATE TABLE `core_contact` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `number` varchar(15) DEFAULT NULL,
  `emailaddress` varchar(100) DEFAULT NULL,
  `note` varchar(100) DEFAULT NULL,
  `student_id` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `core_contact_student` (`student_id`),
  CONSTRAINT `core_contact_student` FOREIGN KEY (`student_id`) REFERENCES `core_student` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `core_contact` */

/*Table structure for table `core_gender` */

DROP TABLE IF EXISTS `core_gender`;

CREATE TABLE `core_gender` (
  `id` int(11) NOT NULL,
  `name` varchar(10) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `core_gender` */

insert  into `core_gender`(`id`,`name`) values (1,'Male'),(2,'Female');

/*Table structure for table `core_province` */

DROP TABLE IF EXISTS `core_province`;

CREATE TABLE `core_province` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

/*Data for the table `core_province` */

insert  into `core_province`(`id`,`name`) values (1,'Pangasinan'),(2,'NCR');

/*Table structure for table `core_student` */

DROP TABLE IF EXISTS `core_student`;

CREATE TABLE `core_student` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `number` varchar(50) NOT NULL,
  `rfid` varchar(100) DEFAULT NULL,
  `firstname` varchar(50) NOT NULL,
  `middlename` varchar(50) NOT NULL,
  `lastname` varchar(50) NOT NULL,
  `dateofbirth` date NOT NULL,
  `picture` longblob,
  `gender_id` int(11) NOT NULL,
  `civilstatus_id` int(11) NOT NULL,
  `citizenship` varchar(50) NOT NULL,
  `street` varchar(100) DEFAULT NULL,
  `barangay_id` int(11) NOT NULL,
  `mothername` varchar(100) DEFAULT NULL,
  `motheroccupation` varchar(100) DEFAULT NULL,
  `fathername` varchar(100) DEFAULT NULL,
  `fatheroccupation` varchar(100) DEFAULT NULL,
  `note` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `core_civilstatus_core_student` (`civilstatus_id`),
  KEY `core_gender_core_student` (`gender_id`),
  KEY `core_barangay_core_student` (`barangay_id`),
  CONSTRAINT `core_barangay_core_student` FOREIGN KEY (`barangay_id`) REFERENCES `core_barangay` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `core_civilstatus_core_student` FOREIGN KEY (`civilstatus_id`) REFERENCES `core_civilstatus` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `core_gender_core_student` FOREIGN KEY (`gender_id`) REFERENCES `core_gender` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;

/*Data for the table `core_student` */

insert  into `core_student`(`id`,`number`,`rfid`,`firstname`,`middlename`,`lastname`,`dateofbirth`,`picture`,`gender_id`,`civilstatus_id`,`citizenship`,`street`,`barangay_id`,`mothername`,`motheroccupation`,`fathername`,`fatheroccupation`,`note`) values (6,'201272-1352359',NULL,'firstname','middlename','lastname','2012-07-04',NULL,1,1,'filipino','05',1,NULL,NULL,NULL,NULL,NULL),(9,'asdfads',NULL,'asdfsadfff','sdfsdf','ssss','2012-07-04',NULL,2,2,'dddfd','asdfasdfasf',3,NULL,NULL,NULL,NULL,NULL);

/*Table structure for table `core_systemsettings` */

DROP TABLE IF EXISTS `core_systemsettings`;

CREATE TABLE `core_systemsettings` (
  `key` varchar(100) NOT NULL,
  `value` varchar(100) NOT NULL,
  PRIMARY KEY (`key`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `core_systemsettings` */

/*Table structure for table `core_user` */

DROP TABLE IF EXISTS `core_user`;

CREATE TABLE `core_user` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(20) NOT NULL,
  `password` varchar(100) NOT NULL,
  `name` varchar(100) NOT NULL,
  `isdeleted` bit(1) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `core_user` */

/*Table structure for table `emp_contact` */

DROP TABLE IF EXISTS `emp_contact`;

CREATE TABLE `emp_contact` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `number` varchar(15) DEFAULT NULL,
  `emailaddress` varchar(100) DEFAULT NULL,
  `note` varchar(100) DEFAULT NULL,
  `employee_id` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `emp_contact_employee` (`employee_id`),
  CONSTRAINT `emp_contact_employee` FOREIGN KEY (`employee_id`) REFERENCES `emp_employee` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `emp_contact` */

/*Table structure for table `emp_employee` */

DROP TABLE IF EXISTS `emp_employee`;

CREATE TABLE `emp_employee` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `number` varchar(50) NOT NULL,
  `rfid` varchar(100) DEFAULT NULL,
  `firstname` varchar(50) NOT NULL,
  `middlename` varchar(50) NOT NULL,
  `lastname` varchar(50) NOT NULL,
  `dateofbirth` datetime NOT NULL,
  `gender_id` int(11) NOT NULL,
  `civilstatus_id` int(11) NOT NULL,
  `citizenship` varchar(100) NOT NULL,
  `barangay_id` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `emp_employee` */

/*Table structure for table `enroll_course` */

DROP TABLE IF EXISTS `enroll_course`;

CREATE TABLE `enroll_course` (
  `id` int(11) NOT NULL,
  `name` varchar(100) NOT NULL,
  `code` varchar(100) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `enroll_course` */

insert  into `enroll_course`(`id`,`name`,`code`) values (1,'Bachelor of Science in Information Technology','BSIT'),(2,'Bachelor Of Science In Business Administration','BSBA'),(3,'Bachelor Of Science In Computer Engineering','BSCOE'),(4,'Bachelor of Science in Hotel Restaurant Management','BSHRM'),(6,'Diploma in Hotel Restaurant Management','DHRM'),(7,'Bachelor Of Science In Computer Science','BSCS'),(8,'Diploma In Information Technology','DIT'),(9,'BS EXAMPLE','BSSG');

/*Table structure for table `enroll_room` */

DROP TABLE IF EXISTS `enroll_room`;

CREATE TABLE `enroll_room` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;

/*Data for the table `enroll_room` */

insert  into `enroll_room`(`id`,`name`) values (1,'101'),(2,'102'),(3,'103'),(4,'104'),(5,'105'),(6,'Registrar Office');

/*Table structure for table `enroll_schedule` */

DROP TABLE IF EXISTS `enroll_schedule`;

CREATE TABLE `enroll_schedule` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `course_id` int(11) NOT NULL,
  `section_id` int(11) NOT NULL,
  `employee_id` int(11) NOT NULL,
  `subject_id` int(11) NOT NULL,
  `room_id` int(11) NOT NULL,
  `datestart` datetime NOT NULL,
  `dateend` datetime NOT NULL,
  PRIMARY KEY (`id`),
  KEY `enroll_subject_schedule` (`subject_id`),
  KEY `enroll_course_schedule` (`course_id`),
  KEY `enroll_section_schedule` (`section_id`),
  KEY `enroll_employee_schedule` (`employee_id`),
  KEY `enroll_room_schedule` (`room_id`),
  CONSTRAINT `enroll_course_schedule` FOREIGN KEY (`course_id`) REFERENCES `enroll_course` (`id`),
  CONSTRAINT `enroll_employee_schedule` FOREIGN KEY (`employee_id`) REFERENCES `emp_employee` (`id`),
  CONSTRAINT `enroll_room_schedule` FOREIGN KEY (`room_id`) REFERENCES `enroll_room` (`id`),
  CONSTRAINT `enroll_section_schedule` FOREIGN KEY (`section_id`) REFERENCES `enroll_section` (`id`),
  CONSTRAINT `enroll_subject_schedule` FOREIGN KEY (`subject_id`) REFERENCES `enroll_subject` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `enroll_schedule` */

/*Table structure for table `enroll_section` */

DROP TABLE IF EXISTS `enroll_section`;

CREATE TABLE `enroll_section` (
  `id` int(11) NOT NULL,
  `name` varchar(100) NOT NULL,
  `course_id` int(1) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `enroll_section_course` (`course_id`),
  CONSTRAINT `enroll_section_course` FOREIGN KEY (`course_id`) REFERENCES `enroll_course` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `enroll_section` */

insert  into `enroll_section`(`id`,`name`,`course_id`) values (2,'BSIT102P',1),(3,'BSIT103P',1),(5,'BSHRM102P',1),(8,'BSCOE101P',1),(9,'BSCOE102P',1),(11,'BSBA101P',1),(12,'BSBA102P',1),(13,'BSIT104P',1),(14,'BSSG101P',1);

/*Table structure for table `enroll_subject` */

DROP TABLE IF EXISTS `enroll_subject`;

CREATE TABLE `enroll_subject` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=latin1;

/*Data for the table `enroll_subject` */

insert  into `enroll_subject`(`id`,`name`) values (1,'PROGRAMMING1'),(2,'PROGRAMMING2'),(3,'PROGRAMMING3'),(4,'PROGRAMMING4'),(5,'COMART1'),(6,'COMART2'),(7,'COMART3'),(8,'COMART4'),(9,'MATHPLUS1'),(10,'MATHPLUS2'),(11,'PHYSICS1'),(12,'PHYSICS2'),(13,'INTROARTS1'),(14,'INTROARTS2'),(15,'PHILGOV1'),(16,'PHILGOV2');

/*Table structure for table `log_entrybook` */

DROP TABLE IF EXISTS `log_entrybook`;

CREATE TABLE `log_entrybook` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `rfid` varchar(100) NOT NULL,
  `timein` datetime NOT NULL,
  `timeout` datetime NOT NULL,
  `isoverride` bit(1) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `log_entrybook` */

/*Table structure for table `log_entrybook_archive` */

DROP TABLE IF EXISTS `log_entrybook_archive`;

CREATE TABLE `log_entrybook_archive` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `archiveddate` datetime NOT NULL,
  `entrybook_id` int(11) NOT NULL,
  `rfid` varchar(100) NOT NULL,
  `timein` datetime NOT NULL,
  `timeout` datetime NOT NULL,
  `isoverride` bit(1) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `log_entrybook_archive` */

/*Table structure for table `sms_inbox` */

DROP TABLE IF EXISTS `sms_inbox`;

CREATE TABLE `sms_inbox` (
  `id` int(11) NOT NULL,
  `number` varchar(15) NOT NULL,
  `message` longtext NOT NULL,
  `datecreated` datetime NOT NULL,
  `status_id` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `sms_inbox_status` (`status_id`),
  CONSTRAINT `sms_inbox_status` FOREIGN KEY (`status_id`) REFERENCES `sms_status` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `sms_inbox` */

/*Table structure for table `sms_inbox_archive` */

DROP TABLE IF EXISTS `sms_inbox_archive`;

CREATE TABLE `sms_inbox_archive` (
  `archivedid` int(11) NOT NULL AUTO_INCREMENT,
  `archiveddate` datetime NOT NULL,
  `id` int(11) NOT NULL,
  `number` varchar(15) NOT NULL,
  `message` longtext NOT NULL,
  `datecreated` datetime NOT NULL,
  `status_id` int(11) NOT NULL,
  KEY `archivedid` (`archivedid`),
  KEY `sms_inbox_archive_status` (`status_id`),
  CONSTRAINT `sms_inbox_archive_status` FOREIGN KEY (`status_id`) REFERENCES `sms_status` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `sms_inbox_archive` */

/*Table structure for table `sms_networkprovider` */

DROP TABLE IF EXISTS `sms_networkprovider`;

CREATE TABLE `sms_networkprovider` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `code` varchar(4) NOT NULL,
  `network` varchar(100) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=39 DEFAULT CHARSET=latin1;

/*Data for the table `sms_networkprovider` */

insert  into `sms_networkprovider`(`id`,`code`,`network`) values (1,'0973','Express Telecom'),(2,'0974','Express Telecom'),(3,'0905','Globe / Touch Mobile'),(4,'0906','Globe / Touch Mobile'),(5,'0915','Globe / Touch Mobile'),(6,'0916','Globe / Touch Mobile'),(7,'0917','Globe / Touch Mobile'),(8,'0925','Globe / Touch Mobile'),(9,'0926','Globe / Touch Mobile'),(10,'0927','Globe / Touch Mobile'),(11,'0935','Globe / Touch Mobile'),(12,'0936','Globe / Touch Mobile'),(13,'0937','Globe / Touch Mobile'),(14,'0977','Nextel'),(15,'0979','Nextel'),(16,'0938','Red Mobile'),(17,'0989','Red Mobile'),(18,'0907','Smart / Talk `N Text'),(19,'0908','Smart / Talk `N Text'),(20,'0909','Smart / Talk `N Text'),(21,'0910','Smart / Talk `N Text'),(22,'0912','Smart / Talk `N Text'),(23,'0918','Smart / Talk `N Text'),(24,'0919','Smart / Talk `N Text'),(25,'0920','Smart / Talk `N Text'),(26,'0921','Smart / Talk `N Text'),(27,'0928','Smart / Talk `N Text'),(28,'0929','Smart / Talk `N Text'),(29,'0930','Smart / Talk `N Text'),(30,'0938','Smart / Talk `N Text'),(31,'0939','Smart / Talk `N Text'),(32,'0989','Smart / Talk `N Text'),(33,'0999','Smart / Talk `N Text'),(34,'0922','Sun Cellular'),(35,'0923','Sun Cellular'),(36,'0932','Sun Cellular'),(37,'0933','Sun Cellular'),(38,'0999','Red Mobile');

/*Table structure for table `sms_notification` */

DROP TABLE IF EXISTS `sms_notification`;

CREATE TABLE `sms_notification` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `number` varchar(15) NOT NULL,
  `message` longtext NOT NULL,
  `remarks` varchar(100) DEFAULT NULL,
  `room_id` int(11) NOT NULL,
  `datecreated` datetime NOT NULL,
  PRIMARY KEY (`id`),
  KEY `sms_notification_room` (`room_id`),
  CONSTRAINT `sms_notification_room` FOREIGN KEY (`room_id`) REFERENCES `enroll_room` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `sms_notification` */

/*Table structure for table `sms_outbox` */

DROP TABLE IF EXISTS `sms_outbox`;

CREATE TABLE `sms_outbox` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `number` varchar(15) NOT NULL,
  `message` longtext NOT NULL,
  `status_id` int(11) NOT NULL,
  `notification_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `status_id` (`status_id`),
  CONSTRAINT `sms_outbox_ibfk_1` FOREIGN KEY (`status_id`) REFERENCES `sms_status` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `sms_outbox` */

/*Table structure for table `sms_outbox_archive` */

DROP TABLE IF EXISTS `sms_outbox_archive`;

CREATE TABLE `sms_outbox_archive` (
  `id` int(11) NOT NULL,
  `archiveddate` datetime NOT NULL,
  `outbox_id` int(11) NOT NULL,
  `number` varchar(15) NOT NULL,
  `message` longtext NOT NULL,
  `status_id` int(11) NOT NULL,
  `notification_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `sms_outbox_archive_status` (`status_id`),
  CONSTRAINT `sms_outbox_archive_status` FOREIGN KEY (`status_id`) REFERENCES `sms_status` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `sms_outbox_archive` */

/*Table structure for table `sms_sent` */

DROP TABLE IF EXISTS `sms_sent`;

CREATE TABLE `sms_sent` (
  `id` int(11) NOT NULL,
  `number` varchar(15) NOT NULL,
  `message` varchar(700) NOT NULL,
  `datecreated` datetime NOT NULL,
  `notification_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `sms_sent` */

/*Table structure for table `sms_sent_archive` */

DROP TABLE IF EXISTS `sms_sent_archive`;

CREATE TABLE `sms_sent_archive` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `archiveddate` datetime NOT NULL,
  `sent_id` int(11) NOT NULL,
  `number` varchar(15) NOT NULL,
  `datecreated` datetime NOT NULL,
  `notification_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `sms_sent_archive` */

/*Table structure for table `sms_status` */

DROP TABLE IF EXISTS `sms_status`;

CREATE TABLE `sms_status` (
  `id` int(11) NOT NULL,
  `name` varchar(100) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `sms_status` */

insert  into `sms_status`(`id`,`name`) values (1,'unread'),(2,'read');

/*Table structure for table `vstudentinfo` */

DROP TABLE IF EXISTS `vstudentinfo`;

/*!50001 DROP VIEW IF EXISTS `vstudentinfo` */;
/*!50001 DROP TABLE IF EXISTS `vstudentinfo` */;

/*!50001 CREATE TABLE  `vstudentinfo`(
 `id` int(11) ,
 `number` varchar(50) ,
 `rfid` varchar(100) ,
 `firstname` varchar(50) ,
 `middlename` varchar(50) ,
 `lastname` varchar(50) ,
 `dateofbirth` date ,
 `picture` longblob ,
 `gender_id` int(11) ,
 `civilstatus_id` int(11) ,
 `citizenship` varchar(50) ,
 `street` varchar(100) ,
 `barangay_id` int(11) ,
 `mothername` varchar(100) ,
 `motheroccupation` varchar(100) ,
 `fathername` varchar(100) ,
 `fatheroccupation` varchar(100) ,
 `note` varchar(100) ,
 `civilstatus` varchar(20) ,
 `gender` varchar(10) ,
 `barangay` varchar(100) ,
 `city_id` int(11) ,
 `city` varchar(100) ,
 `province_id` int(11) ,
 `province` varchar(100) 
)*/;

/*View structure for view vstudentinfo */

/*!50001 DROP TABLE IF EXISTS `vstudentinfo` */;
/*!50001 DROP VIEW IF EXISTS `vstudentinfo` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vstudentinfo` AS select `core_student`.`id` AS `id`,`core_student`.`number` AS `number`,`core_student`.`rfid` AS `rfid`,`core_student`.`firstname` AS `firstname`,`core_student`.`middlename` AS `middlename`,`core_student`.`lastname` AS `lastname`,`core_student`.`dateofbirth` AS `dateofbirth`,`core_student`.`picture` AS `picture`,`core_student`.`gender_id` AS `gender_id`,`core_student`.`civilstatus_id` AS `civilstatus_id`,`core_student`.`citizenship` AS `citizenship`,`core_student`.`street` AS `street`,`core_student`.`barangay_id` AS `barangay_id`,`core_student`.`mothername` AS `mothername`,`core_student`.`motheroccupation` AS `motheroccupation`,`core_student`.`fathername` AS `fathername`,`core_student`.`fatheroccupation` AS `fatheroccupation`,`core_student`.`note` AS `note`,`core_civilstatus`.`name` AS `civilstatus`,`core_gender`.`name` AS `gender`,`core_barangay`.`name` AS `barangay`,`core_barangay`.`city_id` AS `city_id`,`core_city`.`name` AS `city`,`core_city`.`province_id` AS `province_id`,`core_province`.`name` AS `province` from (((((`core_student` join `core_gender` on((`core_student`.`gender_id` = `core_gender`.`id`))) join `core_civilstatus` on((`core_student`.`civilstatus_id` = `core_civilstatus`.`id`))) join `core_barangay` on((`core_student`.`barangay_id` = `core_barangay`.`id`))) join `core_city` on((`core_barangay`.`city_id` = `core_city`.`id`))) join `core_province` on((`core_city`.`province_id` = `core_province`.`id`))) */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
