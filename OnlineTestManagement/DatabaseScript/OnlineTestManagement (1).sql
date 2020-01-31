CREATE DATABASE  IF NOT EXISTS `onlinetestmanagement` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `onlinetestmanagement`;
-- MySQL dump 10.13  Distrib 8.0.16, for Win64 (x86_64)
--
-- Host: localhost    Database: onlinetestmanagement
-- ------------------------------------------------------
-- Server version	8.0.16

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
 SET NAMES utf8 ;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `applicationuser`
--

DROP TABLE IF EXISTS `applicationuser`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `applicationuser` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  `EmailId` varchar(500) DEFAULT NULL,
  `MobileNumber` varchar(20) DEFAULT NULL,
  `PasswordHash` longblob,
  `PasswordSalt` longblob,
  `RoleId` int(11) DEFAULT NULL,
  `Password` varchar(500) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `RoleId` (`RoleId`),
  CONSTRAINT `applicationuser_ibfk_1` FOREIGN KEY (`RoleId`) REFERENCES `role` (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `applicationuser`
--

LOCK TABLES `applicationuser` WRITE;
/*!40000 ALTER TABLE `applicationuser` DISABLE KEYS */;
INSERT INTO `applicationuser` VALUES (2,'Admin','test@gmail.com','9423237999',_binary 'Û∏h\◊∆ÄM¸¸ò\Ízà1ﬂçJ•.3∂ÑJ\„4´\÷ﬂã(É\’¸\Ít)√°]Ω)6™nò{A™°®°u∆¶ëæ',_binary '(7èf\Ó:v\"Lº∆Ñr\ﬁƒ§\Ë≠ØV$øx˘\–M\∆\'ˇ∏≥_•\√*|∫ŸÇ<1d_]Ä\÷\ﬁ~{\“S§â\–\rµ*!6\–3\√[<íˆõ\÷\‚ï:πJv7ç\ÿòD¥uòj›¥QöC~}è\√@c.¸^\r¿˙∫\“x‹ã1¢CO\ﬁ',1,'Reset1234');
/*!40000 ALTER TABLE `applicationuser` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `candidate`
--

DROP TABLE IF EXISTS `candidate`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `candidate` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  `EmailId` varchar(255) DEFAULT NULL,
  `MobileNumber` varchar(255) DEFAULT NULL,
  `Password` varchar(255) DEFAULT NULL,
  `AppliedFor` varchar(255) DEFAULT NULL,
  `CreatedOn` datetime DEFAULT NULL,
  `ModifiedOn` datetime DEFAULT NULL,
  `TestId` int(11) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `TestId` (`TestId`),
  CONSTRAINT `candidate_ibfk_1` FOREIGN KEY (`TestId`) REFERENCES `test` (`Id`) ON DELETE SET NULL
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `candidate`
--

LOCK TABLES `candidate` WRITE;
/*!40000 ALTER TABLE `candidate` DISABLE KEYS */;
INSERT INTO `candidate` VALUES (1,'Sample2 ','Sample2 ','5555555555','Sample2 ','Sample2','2020-01-22 19:22:44','2020-01-22 19:28:44',9),(2,'s','s','s','s','s','2020-01-22 19:29:03','2020-01-22 19:29:03',9),(3,'Sagar','sagar@plug-able.com','7777777777','7777777777','.Net','2020-01-24 14:24:34','2020-01-24 14:24:34',9);
/*!40000 ALTER TABLE `candidate` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `candidateexam`
--

DROP TABLE IF EXISTS `candidateexam`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `candidateexam` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `StartedTime` datetime DEFAULT NULL,
  `SubmittedTime` datetime DEFAULT NULL,
  `IsTestEnded` tinyint(1) DEFAULT NULL,
  `TestId` int(11) DEFAULT NULL,
  `CandidateId` int(11) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `TestId` (`TestId`),
  KEY `CandidateId` (`CandidateId`),
  CONSTRAINT `candidateexam_ibfk_2` FOREIGN KEY (`TestId`) REFERENCES `test` (`Id`) ON DELETE SET NULL,
  CONSTRAINT `candidateexam_ibfk_3` FOREIGN KEY (`CandidateId`) REFERENCES `candidate` (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=37 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `candidateexam`
--

LOCK TABLES `candidateexam` WRITE;
/*!40000 ALTER TABLE `candidateexam` DISABLE KEYS */;
INSERT INTO `candidateexam` VALUES (1,'2020-01-24 18:52:48','0001-01-01 00:00:00',0,NULL,3),(2,'2020-01-24 18:54:09','0001-01-01 00:00:00',0,NULL,3),(3,'2020-01-24 19:20:40','0001-01-01 00:00:00',0,NULL,3),(4,'2020-01-26 23:57:39','0001-01-01 00:00:00',0,NULL,3),(5,'2020-01-27 00:00:25','0001-01-01 00:00:00',0,NULL,3),(6,'2020-01-27 00:01:34','0001-01-01 00:00:00',0,NULL,3),(7,'2020-01-27 00:03:00','0001-01-01 00:00:00',0,NULL,3),(8,'2020-01-27 00:07:00','0001-01-01 00:00:00',0,NULL,3),(9,'2020-01-27 00:15:45','0001-01-01 00:00:00',0,NULL,3),(10,'2020-01-27 00:16:57','0001-01-01 00:00:00',0,NULL,3),(11,'2020-01-27 00:18:08','0001-01-01 00:00:00',0,NULL,3),(12,'2020-01-27 00:20:14','0001-01-01 00:00:00',0,NULL,3),(13,'2020-01-27 00:20:20','0001-01-01 00:00:00',0,NULL,3),(14,'2020-01-27 00:21:02','0001-01-01 00:00:00',0,NULL,3),(15,'2020-01-27 00:21:36','0001-01-01 00:00:00',0,NULL,3),(16,'2020-01-27 00:21:40','0001-01-01 00:00:00',0,NULL,3),(17,'2020-01-27 00:21:41','0001-01-01 00:00:00',0,NULL,3),(18,'2020-01-27 00:21:45','0001-01-01 00:00:00',0,NULL,3),(19,'2020-01-27 00:25:33','0001-01-01 00:00:00',0,NULL,3),(20,'2020-01-30 12:41:06','0001-01-01 00:00:00',0,NULL,3),(21,'2020-01-30 12:44:30','0001-01-01 00:00:00',0,NULL,3),(22,'2020-01-30 12:48:58','0001-01-01 00:00:00',0,NULL,3),(23,'2020-01-30 12:52:18','0001-01-01 00:00:00',0,NULL,3),(24,'2020-01-30 13:08:40','0001-01-01 00:00:00',0,NULL,3),(25,'2020-01-30 13:11:21','0001-01-01 00:00:00',0,NULL,3),(26,'2020-01-30 14:31:48','0001-01-01 00:00:00',0,NULL,3),(27,'2020-01-30 14:33:52','0001-01-01 00:00:00',0,NULL,3),(28,'2020-01-30 14:35:41','0001-01-01 00:00:00',0,NULL,3),(29,'2020-01-30 15:12:50','0001-01-01 00:00:00',0,NULL,3),(30,'2020-01-30 15:15:22','0001-01-01 00:00:00',0,NULL,3),(31,'2020-01-30 15:16:59','0001-01-01 00:00:00',0,NULL,3),(32,'2020-01-30 15:27:59','0001-01-01 00:00:00',0,9,3),(33,'2020-01-30 15:28:08','0001-01-01 00:00:00',0,9,3),(34,'2020-01-30 16:16:14','0001-01-01 00:00:00',0,9,3),(35,'2020-01-30 16:19:16','0001-01-01 00:00:00',0,9,3),(36,'2020-01-30 16:21:02','2020-01-30 16:21:30',1,9,3);
/*!40000 ALTER TABLE `candidateexam` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `candidateexamquestionslog`
--

DROP TABLE IF EXISTS `candidateexamquestionslog`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `candidateexamquestionslog` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Question` varchar(500) DEFAULT NULL,
  `SelectedAnswer` varchar(500) DEFAULT NULL,
  `IsAnswerCorrect` tinyint(1) DEFAULT NULL,
  `CandidateExamId` int(11) DEFAULT NULL,
  `QuestionId` int(11) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `CandidateExamId` (`CandidateExamId`),
  KEY `QuestionId` (`QuestionId`),
  CONSTRAINT `candidateexamquestionslog_ibfk_1` FOREIGN KEY (`CandidateExamId`) REFERENCES `candidateexam` (`Id`) ON DELETE SET NULL,
  CONSTRAINT `candidateexamquestionslog_ibfk_2` FOREIGN KEY (`QuestionId`) REFERENCES `question` (`Id`) ON DELETE SET NULL
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `candidateexamquestionslog`
--

LOCK TABLES `candidateexamquestionslog` WRITE;
/*!40000 ALTER TABLE `candidateexamquestionslog` DISABLE KEYS */;
INSERT INTO `candidateexamquestionslog` VALUES (1,'d','d',1,33,13),(2,'c','c',1,33,12),(3,'b','b',1,33,11),(4,'a','a',1,34,10),(5,'b','b',1,34,11),(6,'c','d',0,34,12),(7,'d','d',1,34,13),(8,'a','d',0,35,10),(9,'b','d',0,35,11),(10,'c','d',0,35,12),(11,'d','d',1,35,13),(12,'a','d',0,36,10),(13,'b','d',0,36,11),(14,'c','d',0,36,12),(15,'d','d',1,36,13);
/*!40000 ALTER TABLE `candidateexamquestionslog` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `candidateuniqueid`
--

DROP TABLE IF EXISTS `candidateuniqueid`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `candidateuniqueid` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `CandidateId` int(11) DEFAULT NULL,
  `UniqueId` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `CandidateId` (`CandidateId`),
  CONSTRAINT `candidateuniqueid_ibfk_1` FOREIGN KEY (`CandidateId`) REFERENCES `candidate` (`Id`) ON DELETE SET NULL
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `candidateuniqueid`
--

LOCK TABLES `candidateuniqueid` WRITE;
/*!40000 ALTER TABLE `candidateuniqueid` DISABLE KEYS */;
INSERT INTO `candidateuniqueid` VALUES (1,3,'c768640558d1444c957a5fea18d16f06'),(2,3,'b10cd836a66a443d8f09a3ed11e186aa');
/*!40000 ALTER TABLE `candidateuniqueid` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `jobrole`
--

DROP TABLE IF EXISTS `jobrole`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `jobrole` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Value` varchar(255) DEFAULT NULL,
  `Description` varchar(500) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `jobrole`
--

LOCK TABLES `jobrole` WRITE;
/*!40000 ALTER TABLE `jobrole` DISABLE KEYS */;
INSERT INTO `jobrole` VALUES (1,'JobRole1','JobRole1'),(2,'JobRole2','JobRole2'),(3,'JobRole3','JobRole3');
/*!40000 ALTER TABLE `jobrole` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `level`
--

DROP TABLE IF EXISTS `level`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `level` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Value` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `level`
--

LOCK TABLES `level` WRITE;
/*!40000 ALTER TABLE `level` DISABLE KEYS */;
INSERT INTO `level` VALUES (1,'First'),(2,'Second');
/*!40000 ALTER TABLE `level` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `question`
--

DROP TABLE IF EXISTS `question`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `question` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Question` varchar(255) DEFAULT NULL,
  `Option1` varchar(255) DEFAULT NULL,
  `Option2` varchar(255) DEFAULT NULL,
  `Option3` varchar(255) DEFAULT NULL,
  `Option4` varchar(255) DEFAULT NULL,
  `CorrectAnswer` varchar(255) DEFAULT NULL,
  `CreatedOn` datetime DEFAULT NULL,
  `ModifiedOn` datetime DEFAULT NULL,
  `CreatedBy` varchar(255) DEFAULT NULL,
  `LevelId` int(11) DEFAULT NULL,
  `SubjectId` int(11) DEFAULT NULL,
  `IsDeleted` bit(1) DEFAULT b'0',
  PRIMARY KEY (`Id`),
  KEY `LevelId` (`LevelId`),
  KEY `SubjectId` (`SubjectId`),
  CONSTRAINT `question_ibfk_1` FOREIGN KEY (`LevelId`) REFERENCES `level` (`Id`) ON DELETE SET NULL,
  CONSTRAINT `question_ibfk_2` FOREIGN KEY (`SubjectId`) REFERENCES `subject` (`Id`) ON DELETE SET NULL
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `question`
--

LOCK TABLES `question` WRITE;
/*!40000 ALTER TABLE `question` DISABLE KEYS */;
INSERT INTO `question` VALUES (10,'a','a','a','a','a','a','2020-01-30 15:22:25','2020-01-30 15:22:25','a',1,1,_binary '\0'),(11,'b','b','b','b','b','b','2020-01-30 15:22:44','2020-01-30 15:22:44','b',2,2,_binary '\0'),(12,'c','c','c','c','c','c','2020-01-30 15:22:55','2020-01-30 15:22:55','c',2,2,_binary '\0'),(13,'d','d','d','d','d','d','2020-01-30 15:23:11','2020-01-30 15:23:11','d',2,2,_binary '\0'),(14,'e','e','e','e','e','a','2020-01-30 16:45:05','2020-01-30 16:45:05','e',1,2,_binary '');
/*!40000 ALTER TABLE `question` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `role`
--

DROP TABLE IF EXISTS `role`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `role` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Value` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `role`
--

LOCK TABLES `role` WRITE;
/*!40000 ALTER TABLE `role` DISABLE KEYS */;
INSERT INTO `role` VALUES (1,'Admin'),(2,'Customer');
/*!40000 ALTER TABLE `role` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `smtpmail`
--

DROP TABLE IF EXISTS `smtpmail`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `smtpmail` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `FromMail` varchar(255) DEFAULT NULL,
  `SmtpPassword` varchar(255) DEFAULT NULL,
  `Host` varchar(255) DEFAULT NULL,
  `Port` varchar(255) DEFAULT NULL,
  `DisplayName` varchar(255) DEFAULT NULL,
  `Description` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `smtpmail`
--

LOCK TABLES `smtpmail` WRITE;
/*!40000 ALTER TABLE `smtpmail` DISABLE KEYS */;
INSERT INTO `smtpmail` VALUES (1,'keralamartuser@gmail.com','Kerala1234@','smtp.gmail.com','587','Online Test','Online Test');
/*!40000 ALTER TABLE `smtpmail` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `subject`
--

DROP TABLE IF EXISTS `subject`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `subject` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Value` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `subject`
--

LOCK TABLES `subject` WRITE;
/*!40000 ALTER TABLE `subject` DISABLE KEYS */;
INSERT INTO `subject` VALUES (1,'Subject1'),(2,'Subject2');
/*!40000 ALTER TABLE `subject` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `test`
--

DROP TABLE IF EXISTS `test`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `test` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  `CreatedOn` datetime DEFAULT NULL,
  `ModifiedOn` datetime DEFAULT NULL,
  `CreatedBy` varchar(255) DEFAULT NULL,
  `JobRoleId` int(11) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `JobRoleId` (`JobRoleId`),
  CONSTRAINT `test_ibfk_1` FOREIGN KEY (`JobRoleId`) REFERENCES `jobrole` (`Id`) ON DELETE SET NULL
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `test`
--

LOCK TABLES `test` WRITE;
/*!40000 ALTER TABLE `test` DISABLE KEYS */;
INSERT INTO `test` VALUES (9,'Test 1','2020-01-30 15:23:38','2020-01-30 15:23:38','Sagar',1),(10,'Test 2','2020-01-30 15:23:56','2020-01-30 15:23:56','Sagar',3);
/*!40000 ALTER TABLE `test` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `testquestion`
--

DROP TABLE IF EXISTS `testquestion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `testquestion` (
  `TestId` int(11) DEFAULT NULL,
  `QuestionId` int(11) DEFAULT NULL,
  KEY `TestId` (`TestId`),
  KEY `QuestionId` (`QuestionId`),
  CONSTRAINT `testquestion_ibfk_1` FOREIGN KEY (`TestId`) REFERENCES `test` (`Id`) ON DELETE SET NULL,
  CONSTRAINT `testquestion_ibfk_2` FOREIGN KEY (`QuestionId`) REFERENCES `question` (`Id`) ON DELETE SET NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `testquestion`
--

LOCK TABLES `testquestion` WRITE;
/*!40000 ALTER TABLE `testquestion` DISABLE KEYS */;
INSERT INTO `testquestion` VALUES (NULL,NULL),(9,10),(9,11),(9,12),(9,13),(10,12),(10,13);
/*!40000 ALTER TABLE `testquestion` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-01-31 12:48:19
