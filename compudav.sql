/*
Navicat MySQL Data Transfer

Source Server         : localhost_3306
Source Server Version : 80020
Source Host           : localhost:3306
Source Database       : compudav

Target Server Type    : MYSQL
Target Server Version : 80020
File Encoding         : 65001

Date: 2020-08-25 08:19:59
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for address
-- ----------------------------
DROP TABLE IF EXISTS `address`;
CREATE TABLE `address` (
  `id` varchar(36) NOT NULL,
  `street` varchar(255) NOT NULL,
  `landline` varchar(20) NOT NULL,
  `mobile_phone` varchar(20) NOT NULL,
  `status` tinyint NOT NULL DEFAULT '1',
  `created_at` datetime(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
  `modified_at` datetime(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
  `revision` int DEFAULT NULL,
  `cityId` varchar(36) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `FK_3624b3085165071df70276a4000` (`cityId`),
  CONSTRAINT `FK_3624b3085165071df70276a4000` FOREIGN KEY (`cityId`) REFERENCES `city` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of address
-- ----------------------------

-- ----------------------------
-- Table structure for address_contacts_contact
-- ----------------------------
DROP TABLE IF EXISTS `address_contacts_contact`;
CREATE TABLE `address_contacts_contact` (
  `addressId` varchar(36) NOT NULL,
  `contactId` varchar(36) NOT NULL,
  PRIMARY KEY (`addressId`,`contactId`),
  KEY `IDX_9306fc684fea994553f0003de1` (`addressId`),
  KEY `IDX_ae7c8d7dfd6a742de6541c7452` (`contactId`),
  CONSTRAINT `FK_9306fc684fea994553f0003de16` FOREIGN KEY (`addressId`) REFERENCES `address` (`id`) ON DELETE CASCADE,
  CONSTRAINT `FK_ae7c8d7dfd6a742de6541c7452a` FOREIGN KEY (`contactId`) REFERENCES `contact` (`id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of address_contacts_contact
-- ----------------------------

-- ----------------------------
-- Table structure for ambient
-- ----------------------------
DROP TABLE IF EXISTS `ambient`;
CREATE TABLE `ambient` (
  `id` varchar(36) NOT NULL,
  `code` varchar(3) NOT NULL,
  `name` varchar(45) NOT NULL,
  `status` tinyint NOT NULL DEFAULT '1',
  `created_at` datetime(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
  `modified_at` datetime(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
  `revision` int DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `IDX_95f9101f24822e60e099527844` (`code`),
  UNIQUE KEY `IDX_b6f5b5fdf79036b5422473f76b` (`name`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of ambient
-- ----------------------------

-- ----------------------------
-- Table structure for carrier
-- ----------------------------
DROP TABLE IF EXISTS `carrier`;
CREATE TABLE `carrier` (
  `id` varchar(36) NOT NULL,
  `id_number` varchar(20) NOT NULL,
  `name` varchar(255) NOT NULL,
  `license_plate` varchar(10) NOT NULL,
  `landline` varchar(255) NOT NULL,
  `mobile_phone` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `status` tinyint NOT NULL DEFAULT '1',
  `created_at` datetime(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
  `modified_at` datetime(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
  `revision` int DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `IDX_321f8b2879c6b496020feaa95d` (`id_number`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of carrier
-- ----------------------------

-- ----------------------------
-- Table structure for category
-- ----------------------------
DROP TABLE IF EXISTS `category`;
CREATE TABLE `category` (
  `id` varchar(36) NOT NULL,
  `name` varchar(45) NOT NULL,
  `status` tinyint NOT NULL DEFAULT '1',
  `created_at` datetime(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
  `modified_at` datetime(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
  `revision` int DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `IDX_23c05c292c439d77b0de816b50` (`name`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of category
-- ----------------------------

-- ----------------------------
-- Table structure for city
-- ----------------------------
DROP TABLE IF EXISTS `city`;
CREATE TABLE `city` (
  `id` varchar(36) NOT NULL,
  `name` varchar(255) NOT NULL,
  `status` tinyint NOT NULL DEFAULT '1',
  `created_at` datetime(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
  `modified_at` datetime(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
  `revision` int DEFAULT NULL,
  `provinceId` varchar(36) DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `IDX_f8c0858628830a35f19efdc0ec` (`name`),
  KEY `FK_95959bed787b5e4fd4be4e94fc5` (`provinceId`),
  CONSTRAINT `FK_95959bed787b5e4fd4be4e94fc5` FOREIGN KEY (`provinceId`) REFERENCES `province` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of city
-- ----------------------------

-- ----------------------------
-- Table structure for company
-- ----------------------------
DROP TABLE IF EXISTS `company`;
CREATE TABLE `company` (
  `id` varchar(36) NOT NULL,
  `business_name` varchar(255) NOT NULL,
  `tradename` varchar(255) NOT NULL,
  `ruc` varchar(13) NOT NULL,
  `main_address` varchar(255) NOT NULL,
  `logo` varchar(255) NOT NULL,
  `phone` varchar(20) NOT NULL,
  `keep_accounting_record` tinyint NOT NULL DEFAULT '0',
  `special_taxpayer` varchar(13) NOT NULL,
  `status` tinyint NOT NULL DEFAULT '1',
  `created_at` datetime(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
  `modified_at` datetime(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
  `revision` int DEFAULT NULL,
  `ambientId` varchar(36) DEFAULT NULL,
  `locationId` varchar(36) DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `IDX_bcd52151c53de781aead0ea4f1` (`business_name`),
  KEY `FK_ce8f440b2737cafca979114f10f` (`ambientId`),
  KEY `FK_f1496c85773700592e82a331aee` (`locationId`),
  CONSTRAINT `FK_ce8f440b2737cafca979114f10f` FOREIGN KEY (`ambientId`) REFERENCES `ambient` (`id`),
  CONSTRAINT `FK_f1496c85773700592e82a331aee` FOREIGN KEY (`locationId`) REFERENCES `location` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of company
-- ----------------------------

-- ----------------------------
-- Table structure for contact
-- ----------------------------
DROP TABLE IF EXISTS `contact`;
CREATE TABLE `contact` (
  `id` varchar(36) NOT NULL,
  `id_number` varchar(20) NOT NULL,
  `business_name` varchar(255) NOT NULL,
  `tradename` varchar(255) DEFAULT NULL,
  `landline` varchar(255) DEFAULT NULL,
  `mobile_phone` varchar(255) DEFAULT NULL,
  `email` varchar(255) DEFAULT NULL,
  `client` tinyint DEFAULT '0',
  `provider` tinyint DEFAULT '0',
  `special_taxpayer` tinyint DEFAULT '0',
  `additional_information` text,
  `status` tinyint NOT NULL DEFAULT '1',
  `created_at` datetime(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
  `modified_at` datetime(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
  `revision` int DEFAULT NULL,
  `typeIdentificationId` varchar(36) DEFAULT NULL,
  `address` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `IDX_ecac63a3cbe5502bf5341d0830` (`id_number`),
  KEY `FK_9dff888f322589e2161933d2957` (`typeIdentificationId`),
  CONSTRAINT `FK_9dff888f322589e2161933d2957` FOREIGN KEY (`typeIdentificationId`) REFERENCES `type_identification` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of contact
-- ----------------------------
INSERT INTO `contact` VALUES ('8de34f80-d300-4e23-bc2e-c32174f92476', '9999999999999', 'CONSUMIDOR FINAL', null, null, null, null, '1', '0', '0', null, '1', '2020-08-06 17:40:29.078934', '2020-08-15 09:40:02.344840', '2', 'f6dc1c0a-a60c-4c43-8938-7f16c04576db', null);

-- ----------------------------
-- Table structure for document
-- ----------------------------
DROP TABLE IF EXISTS `document`;
CREATE TABLE `document` (
  `id` varchar(36) NOT NULL,
  `date_of_issue` datetime NOT NULL,
  `authorization_sri` varchar(45) DEFAULT NULL,
  `date_of_authorization` datetime DEFAULT NULL,
  `numeric_code` varchar(8) DEFAULT NULL,
  `access_code` varchar(49) DEFAULT NULL,
  `subtotal` decimal(12,2) NOT NULL,
  `additional_discount` decimal(12,2) NOT NULL,
  `total_discount` decimal(12,2) NOT NULL,
  `subtotal_iva0` decimal(12,2) NOT NULL,
  `subtotal_iva12` decimal(12,2) NOT NULL,
  `subtotal_no_object_iva` decimal(12,2) DEFAULT NULL,
  `subtotal_exempt_from_iva` decimal(12,2) DEFAULT NULL,
  `subtotal_without_taxes` decimal(12,2) DEFAULT NULL,
  `ice_value` decimal(12,2) DEFAULT NULL,
  `irbpnr_value` decimal(12,4) DEFAULT NULL,
  `iva_value` decimal(12,4) NOT NULL,
  `gratuity_value` decimal(12,4) DEFAULT NULL,
  `total_value` decimal(12,4) NOT NULL,
  `additional_information` text,
  `shipping_document_number` varchar(15) DEFAULT NULL,
  `check_digit` tinyint DEFAULT NULL,
  `fiscal_year` varchar(6) DEFAULT NULL,
  `type_code_cod_doc` varchar(3) DEFAULT NULL,
  `type_label_cod_doc` varchar(50) DEFAULT NULL,
  `number_invoice_cod_doc` varchar(17) DEFAULT NULL,
  `date_invoice_cod_doc` datetime DEFAULT NULL,
  `authorization_sri_code_doc` varchar(45) DEFAULT NULL,
  `reason_for_the_transfer` varchar(255) DEFAULT NULL,
  `number_of_the_customs_declaration` varchar(45) DEFAULT NULL,
  `transportation_start_date` datetime DEFAULT NULL,
  `transportation_termination_date` datetime DEFAULT NULL,
  `route` varchar(255) DEFAULT NULL,
  `status` tinyint NOT NULL DEFAULT '1',
  `created_at` datetime(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
  `modified_at` datetime(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
  `revision` int DEFAULT NULL,
  `typeIssuanceId` varchar(36) DEFAULT NULL,
  `typeDocumentId` varchar(36) DEFAULT NULL,
  `statusDocumentId` varchar(36) DEFAULT NULL,
  `contactId` varchar(36) DEFAULT NULL,
  `carrierId` varchar(36) DEFAULT NULL,
  `paymentMethodId` varchar(36) DEFAULT NULL,
  `number` varchar(15) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `IDX_6240b26a386eb70017dcf8411d` (`authorization_sri`),
  KEY `FK_d190ea2aa49720deb7e75e55822` (`typeIssuanceId`),
  KEY `FK_f31aaf44fd0441ab9aa0c289c6c` (`typeDocumentId`),
  KEY `FK_bf56510aa923a7ef21d0f728935` (`statusDocumentId`),
  KEY `FK_7d076bd579359516de382003147` (`contactId`),
  KEY `FK_3290a7fb70aa5af32747003f656` (`carrierId`),
  KEY `FK_467d5263679f0d12f20cdb1c841` (`paymentMethodId`),
  CONSTRAINT `FK_3290a7fb70aa5af32747003f656` FOREIGN KEY (`carrierId`) REFERENCES `carrier` (`id`),
  CONSTRAINT `FK_467d5263679f0d12f20cdb1c841` FOREIGN KEY (`paymentMethodId`) REFERENCES `payment_method` (`id`),
  CONSTRAINT `FK_7d076bd579359516de382003147` FOREIGN KEY (`contactId`) REFERENCES `contact` (`id`),
  CONSTRAINT `FK_bf56510aa923a7ef21d0f728935` FOREIGN KEY (`statusDocumentId`) REFERENCES `status_document` (`id`),
  CONSTRAINT `FK_d190ea2aa49720deb7e75e55822` FOREIGN KEY (`typeIssuanceId`) REFERENCES `type_issuance` (`id`),
  CONSTRAINT `FK_f31aaf44fd0441ab9aa0c289c6c` FOREIGN KEY (`typeDocumentId`) REFERENCES `type_document` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of document
-- ----------------------------

-- ----------------------------
-- Table structure for ice_rate
-- ----------------------------
DROP TABLE IF EXISTS `ice_rate`;
CREATE TABLE `ice_rate` (
  `id` varchar(36) NOT NULL,
  `name` varchar(255) NOT NULL,
  `code` varchar(6) NOT NULL,
  `ad_valorem` varchar(4) DEFAULT NULL,
  `status` tinyint NOT NULL DEFAULT '1',
  `created_at` datetime(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
  `modified_at` datetime(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
  `revision` int DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `IDX_6509adbb31c6524e0a82ea7e6e` (`name`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of ice_rate
-- ----------------------------
INSERT INTO `ice_rate` VALUES ('01dbad40-c7b3-4821-8dd9-c3314b857ce2', 'Vehículos Híbridos Cuyo PVP Superior USD. 35.000 Hasta 40.000 SENAE', '3690', '8%', '1', '2020-07-21 09:44:16.316561', '2020-07-21 09:44:16.316561', '1');
INSERT INTO `ice_rate` VALUES ('06eb76f9-d63f-4df8-875b-736e5caa234e', 'Vehículos Motorizados Camionetas Y De Rescate Cuyo PVP Sea Hasta De 30.000 USD', '3684', '5%', '1', '2020-07-21 09:13:28.985458', '2020-07-21 09:13:28.985458', '1');
INSERT INTO `ice_rate` VALUES ('071e21ac-f957-465f-a319-59944cf838e0', 'Servicios Telefonía Sociedades', '3093', '15%', '1', '2020-07-21 09:10:40.204917', '2020-07-21 09:10:40.204917', '1');
INSERT INTO `ice_rate` VALUES ('093236e4-085a-4715-a636-259b2c1afd2b', 'Productos del Tabaco y Sucedaneos del Tabaco Excepto Cigarrillos CAE', '3544', '150%', '1', '2020-07-21 09:19:29.786362', '2020-07-21 09:19:29.786362', '1');
INSERT INTO `ice_rate` VALUES ('0d7760d3-7c2f-405f-9e37-0bf8600cdef5', 'Bebidas No Alcoholicas SENAE', '3602', '-', '1', '2020-07-21 09:41:52.181567', '2020-07-21 09:41:52.181567', '1');
INSERT INTO `ice_rate` VALUES ('0f9b3c33-219c-4cc4-9899-5f58d975d3a0', 'Aviones, Tricares, Yates, Barcos De REC SENAE', '3878', '15%', '1', '2020-07-21 09:40:55.787104', '2020-07-21 09:40:55.787104', '1');
INSERT INTO `ice_rate` VALUES ('16ffcadd-a222-48b8-afbc-52a5267be80c', 'Vehículos Motorizados cuyo PVP superior USD\n40.000 hasta 50.000', '3077', '20%', '1', '2020-07-21 09:04:34.019748', '2020-07-21 09:04:34.019748', '1');
INSERT INTO `ice_rate` VALUES ('1f9130e2-daa1-415e-853b-b8a5ea2b12c7', 'Vehículos Híbridos Cuyo PVP Superior USD. 50.000 Hasta 60.000 SENAE', '3694', '20%', '1', '2020-07-21 09:44:37.289750', '2020-07-21 09:44:37.289750', '1');
INSERT INTO `ice_rate` VALUES ('200bd6b2-2b63-4c99-b6f2-73e8c3ac0fe8', 'Vehículos Motorizados PVP entre 30000 y 40000', '3075', '15%', '1', '2020-07-21 09:04:09.906827', '2020-07-21 09:04:09.906827', '1');
INSERT INTO `ice_rate` VALUES ('227eb9ef-d50b-46b8-a50b-d6ddddacacca', 'Bebidas Alcohólicas', '3031', '75%', '1', '2020-07-21 09:01:58.329830', '2020-07-21 09:01:58.329830', '1');
INSERT INTO `ice_rate` VALUES ('2325117c-d1d1-406e-b644-e1f3f72f9d0b', 'Perfumes Aguas de Tocador CAE', '3710', '20%', '1', '2020-07-21 09:23:35.540071', '2020-07-21 09:23:35.540071', '1');
INSERT INTO `ice_rate` VALUES ('24f5f114-467d-4cc5-8e4e-6a4231b1dc89', 'Vehículos Híbridos Cuyo PVP Sea De Hasta USD. 35.000 SENAE', '3689', '0%', '1', '2020-07-21 09:44:03.568767', '2020-07-21 09:44:03.568767', '1');
INSERT INTO `ice_rate` VALUES ('2905be81-9851-406e-8493-7219d06ee85f', 'Import. Alcohol SENAE', '3532', '75%', '1', '2020-07-21 09:42:27.551272', '2020-07-21 09:42:27.551272', '1');
INSERT INTO `ice_rate` VALUES ('2cb77588-59ae-4d17-8147-c3d6b73efba8', 'Consumibles Tabaco Calentado Y Líquidos Con Nicotina SRI', '3682', '150%', '1', '2020-07-21 09:17:44.045559', '2020-07-21 09:17:44.045559', '1');
INSERT INTO `ice_rate` VALUES ('344016b7-01a2-4a4a-b2b1-8814ba5eff1f', 'Vehículos Motorizados Camionetas Y De RescatE PVP Sea Hasta De 30.000 USD SENAE', '3685', '5%', '1', '2020-07-21 09:43:22.053862', '2020-07-21 09:43:22.053862', '1');
INSERT INTO `ice_rate` VALUES ('363ddcf7-2aad-4186-8987-00ec0abb063b', 'Servicios De Telefonía Móvil Personas Naturales', '3681', '10%', '1', '2020-07-21 09:17:58.274877', '2020-07-21 09:17:58.274877', '1');
INSERT INTO `ice_rate` VALUES ('3971e04b-b03b-4036-a639-8c94d049b5bf', 'Aviones, Tricares, yates, Barcos de Recreo', '3081', '15%', '1', '2020-07-21 09:06:29.303749', '2020-07-21 09:06:29.303749', '1');
INSERT INTO `ice_rate` VALUES ('39df62a1-4ea8-4ce0-a5a8-e2be02a745d1', 'Vehículos Motorizados Cuyo PVP Superior USD 60.000 Hasta 70.000 SENAE', '3876', '30%', '1', '2020-07-21 09:40:27.412613', '2020-07-21 09:40:27.412613', '1');
INSERT INTO `ice_rate` VALUES ('3b2f4d07-79e5-4ca4-a917-f37ad6066192', 'Armas de Fuego, Armas deportivas y Municiones', '3630', '300%', '1', '2020-07-21 09:09:58.525271', '2020-07-21 09:09:58.525271', '1');
INSERT INTO `ice_rate` VALUES ('3d32bb0e-852b-4714-9a0e-ca7fdc8ecd4b', 'Importaciones Armas de Fuego, Armas deportivas y Municiones CAE', '3730', '300%', '1', '2020-07-21 09:24:02.477560', '2020-07-21 09:24:02.477560', '1');
INSERT INTO `ice_rate` VALUES ('3eb2cf52-ef94-447a-afc6-a6fa225acf2d', 'Vehículos Motorizados cuyo PVP superior USD\n50.000 hasta 60.000', '3078', '25%', '1', '2020-07-21 09:04:56.780420', '2020-07-21 09:04:56.780420', '1');
INSERT INTO `ice_rate` VALUES ('42f3c549-a9e6-47c4-a494-e3928606a86d', 'Cuotas Membresías Afiliaciones Acciones', '3660', '35%', '1', '2020-07-21 09:10:26.129059', '2020-07-21 09:10:26.129059', '1');
INSERT INTO `ice_rate` VALUES ('445c7e26-63e6-4faa-9800-5ac7a5d15554', 'Vehículos Híbridos Cuyo PVP Sea De Hasta USD. 35.000', '3688', '0%', '1', '2020-07-21 09:15:51.440296', '2020-07-21 09:15:51.440296', '1');
INSERT INTO `ice_rate` VALUES ('45dd2808-c631-4965-b805-1845746c3e5c', 'Aeronaves CAE', '3581', '15%', '1', '2020-07-21 09:19:41.779422', '2020-07-21 09:19:41.779422', '1');
INSERT INTO `ice_rate` VALUES ('478415f1-b5d3-4cc5-bbab-c74a78208921', 'Cigarrillos Negros CAE', '3543', '-', '1', '2020-07-21 09:19:16.063811', '2020-07-21 09:19:16.063811', '1');
INSERT INTO `ice_rate` VALUES ('517aa286-eb0a-4f15-9847-d843300a68ed', 'Vehículos Híbridos Cuyo PVP Superior USD. 40.000 Hasta 50.000', '3692', '14%', '1', '2020-07-21 09:16:31.962673', '2020-07-21 09:16:31.962673', '1');
INSERT INTO `ice_rate` VALUES ('55bbe6f4-8b44-4a81-80df-d6228f21eab2', 'Cerveza Industrial de Pequeña Escala CAE', '3541', '75%', '1', '2020-07-21 09:18:51.918517', '2020-07-21 09:18:51.918517', '1');
INSERT INTO `ice_rate` VALUES ('5663539e-bd90-4700-a875-8847e812b96f', 'Bebidas No Alcohólicas', '3111', '-', '1', '2020-07-21 09:11:46.238501', '2020-07-21 09:11:46.238501', '1');
INSERT INTO `ice_rate` VALUES ('5f450672-0eae-4bf1-8262-7a167100a4fe', 'Vehículos Motorizados Cuyo PVP Superior USD 70.000 SENAE', '3877', '35%', '1', '2020-07-21 09:40:43.568397', '2020-07-21 09:40:43.568397', '1');
INSERT INTO `ice_rate` VALUES ('634530cd-5ad8-4860-bb99-c75eb0c5b9aa', 'Vehículos Motorizados Excepto Camionetas Y De Rescate Cuyo PVP Sea Superior USD 20.000 Hasta De 30.000 SENAE\n', '3687', '10%', '1', '2020-07-21 09:43:44.556688', '2020-07-21 09:43:44.556688', '1');
INSERT INTO `ice_rate` VALUES ('681b74d1-4e87-4de3-af51-ed94f85e5326', 'Cigarrillos Rubios', '3011', '-', '1', '2020-07-21 08:21:43.227507', '2020-07-21 08:21:43.227507', '1');
INSERT INTO `ice_rate` VALUES ('71d17653-4d44-4ff9-b514-a0835b5a7a22', 'Aviones, Avionetas y Helicópteros Exct. Aquellos Destinados Al Trans. CAE', '3582', '15%', '1', '2020-07-21 09:23:22.249700', '2020-07-21 09:23:22.249700', '1');
INSERT INTO `ice_rate` VALUES ('749730a1-9c07-4690-99bc-02ff62592b5d', 'Vehículos Híbridos Cuyo PVP Superior A USD 70.000 SENAE', '3699', '32%', '1', '2020-07-21 09:45:01.250387', '2020-07-21 09:45:01.250387', '1');
INSERT INTO `ice_rate` VALUES ('75b02455-c2cd-4909-a9be-65a0e8160b0a', 'Import. Bebidas Alcohólicas', '3533', '75%', '1', '2020-07-21 09:18:22.548117', '2020-07-21 09:18:22.548117', '1');
INSERT INTO `ice_rate` VALUES ('79726785-970a-4530-9c2c-d6336ce53454', 'Videojuegos', '3620', '35%', '1', '2020-07-21 09:09:26.145301', '2020-07-21 09:09:26.145301', '1');
INSERT INTO `ice_rate` VALUES ('7ac6ea4e-b120-40b7-8b7c-b01a673e5b2e', 'Vehículos Motorizados PVP Entre 30000 Y 40000 SENAE', '3873', '15%', '1', '2020-07-21 09:38:40.383714', '2020-07-21 09:38:40.383714', '1');
INSERT INTO `ice_rate` VALUES ('7ae75a77-194e-4ecf-b6a1-d69793000710', 'Bebidas Energizantes', '3101', '10%', '1', '2020-07-21 09:11:00.030122', '2020-07-21 09:11:00.030122', '1');
INSERT INTO `ice_rate` VALUES ('7e5922e5-0a5d-4390-b216-233260899844', 'Consumibles Tabaco Calentado Y Liquidos Con Nicotina SENAE', '3683', '150%', '1', '2020-07-21 09:45:16.915835', '2020-07-21 09:45:16.915835', '1');
INSERT INTO `ice_rate` VALUES ('8a066783-eea8-4b85-a1f9-cd149d4cade9', 'Vehículos Motorizados Cuyo PVP Superior USD 50.000 Hasta 60.000 SENAE', '3875', '25%', '1', '2020-07-21 09:40:15.108993', '2020-07-21 09:40:15.108993', '1');
INSERT INTO `ice_rate` VALUES ('8a1d522d-f127-4c97-a946-f314dbad2ff1', 'Vehículos Híbridos Cuyo PVP Superior USD. 50.000 Hasta 60.000', '3695', '20%', '1', '2020-07-21 09:16:45.141041', '2020-07-21 09:16:45.141041', '1');
INSERT INTO `ice_rate` VALUES ('8aa274ac-a885-4919-9ae2-3ccdf5f432ff', 'Vehículos Híbridos Cuyo PVP Superior USD. 35.000 Hasta 40.000', '3691', '8%', '1', '2020-07-21 09:16:17.393662', '2020-07-21 09:16:17.393662', '1');
INSERT INTO `ice_rate` VALUES ('8bc1cdbf-ff91-4af3-92f9-b52e184a8961', 'Video Juegos CAE', '3720', '35%', '1', '2020-07-21 09:23:48.931549', '2020-07-21 09:23:48.931549', '1');
INSERT INTO `ice_rate` VALUES ('9330b823-5b3a-4f47-8e24-6d762e2d0285', 'Perfumes y Aguas de Tocador', '3610', '20%', '1', '2020-07-21 09:09:07.713212', '2020-07-21 09:09:07.713212', '1');
INSERT INTO `ice_rate` VALUES ('94301a40-570d-4e2c-9190-763f3ded645d', 'Cerveza Artesanal SENAE', '3545', '75%', '1', '2020-07-21 09:42:09.128567', '2020-07-21 09:42:09.128567', '1');
INSERT INTO `ice_rate` VALUES ('986ec538-87a4-4686-8e36-d5a3b331bd26', 'Cerveza Industrial Mediana Escala', '3041', '75%', '1', '2020-07-21 09:03:13.713428', '2020-07-21 09:03:13.713428', '1');
INSERT INTO `ice_rate` VALUES ('98e7a85b-5ef7-491a-b8f8-84ec95988235', 'Cerveza Industrial Gran Escala', '3041', '75%', '1', '2020-07-21 09:02:15.293342', '2020-07-21 09:02:15.293342', '1');
INSERT INTO `ice_rate` VALUES ('99cc1b38-0788-45e9-8050-d79864a9e392', 'Productos del Tabaco y Sucedáneos del Tabaco excepto Cigarrillos', '3023', '150%', '1', '2020-07-21 09:01:38.850620', '2020-07-21 09:01:38.850620', '1');
INSERT INTO `ice_rate` VALUES ('9bc815e1-b00c-4b2b-b1e8-bdbe8ef78acd', 'Vehículos Motorizados Excepto Camionetas Y De Rescate Cuyo PVP Sea Superior USD 20.000 Hasta De 30.000', '3686', '10%', '1', '2020-07-21 09:14:46.951247', '2020-07-21 09:14:46.951247', '1');
INSERT INTO `ice_rate` VALUES ('9bca7198-7422-4b44-a2af-82e0e6860741', 'Bebidas Energizantes SENAE', '3601', '10%', '1', '2020-07-21 09:41:09.872135', '2020-07-21 09:41:09.872135', '1');
INSERT INTO `ice_rate` VALUES ('9d769c4c-9b5e-4a7f-8dcf-e3a8719da984', 'Vehículos Motorizados cuyo PVP sea hasta de 20000 USD', '3073', '5%', '1', '2020-07-21 09:03:56.300792', '2020-07-21 09:03:56.300792', '1');
INSERT INTO `ice_rate` VALUES ('9f301fe0-6a89-4540-8a78-db6707e5783d', 'Calefones Y Sistemas De Calentamiento De Agua A Gas SRI', '3671', '100%', '1', '2020-07-21 09:12:41.307454', '2020-07-21 09:12:41.307454', '1');
INSERT INTO `ice_rate` VALUES ('a3339106-8b7c-4a81-9c63-9dd821a8c1ca', 'Cigarrillos Negros', '3021', '-', '1', '2020-07-21 08:22:02.498167', '2020-07-21 08:22:02.498167', '1');
INSERT INTO `ice_rate` VALUES ('a89ca48c-c146-4fbb-b9d3-2582f3261aa3', 'Servicios de Televisión Prepagada', '3092', '15%', '1', '2020-07-21 09:08:52.607213', '2020-07-21 09:08:52.607213', '1');
INSERT INTO `ice_rate` VALUES ('aa2e0db1-0b9a-4801-a8cb-a302599e1316', 'Vehículos Motorizados cuyo PVP superior USD 70.000', '3080', '35%', '1', '2020-07-21 09:06:06.629991', '2020-07-21 09:06:06.629991', '1');
INSERT INTO `ice_rate` VALUES ('b0c498aa-710e-4f92-830b-a349bd3da6c7', 'Cerveza Artesanal', '3043', '-', '1', '2020-07-21 09:12:02.968791', '2020-07-21 09:12:02.968791', '1');
INSERT INTO `ice_rate` VALUES ('ba0fe6d6-fdc5-4508-8e87-c2a427539c4c', 'Focos Incandescentes CAE', '3740', '100%', '1', '2020-07-21 09:24:17.331889', '2020-07-21 09:24:17.331889', '1');
INSERT INTO `ice_rate` VALUES ('bbb208d0-2f8d-4db8-b77c-1bd45404da3a', 'Alcohol', '3033', '75%', '1', '2020-07-21 09:12:15.922628', '2020-07-21 09:12:15.922628', '1');
INSERT INTO `ice_rate` VALUES ('bcf0765d-9cc4-46d1-a5d6-4074adcc2c9b', 'Vehículos Motorizados Cuyo PVP Sea Hasta De 20000 USD SENAE', '3871', '5%', '1', '2020-07-21 09:38:24.605288', '2020-07-21 09:38:24.605288', '1');
INSERT INTO `ice_rate` VALUES ('be070d7d-eba9-4467-b6b5-f8edc98a505d', 'Cigarrillos Rubios CAE', '3542', '-', '1', '2020-07-21 09:19:07.835201', '2020-07-21 09:19:07.835201', '1');
INSERT INTO `ice_rate` VALUES ('c210243e-acf6-46d1-960b-6c76cf6fb136', 'Bebidas Gaseosas Con Bajo Contenido De Azúcar', '3054', '10%', '1', '2020-07-21 09:11:31.080755', '2020-07-21 09:11:31.080755', '1');
INSERT INTO `ice_rate` VALUES ('cd8a119e-cac4-405b-81d9-6074538030ed', 'Bebidas Gaseosas Con Alto Contenido De Azucar SENAE', '3552', '-', '1', '2020-07-21 09:41:25.594040', '2020-07-21 09:41:25.594040', '1');
INSERT INTO `ice_rate` VALUES ('cea6c706-df10-4b94-be0a-72b186e681fd', 'Vehículos Híbridos Cuyo PVP Superior USD. 60.000 Hasta 70.000 SENAE', '3697', '26%', '1', '2020-07-21 09:44:50.595939', '2020-07-21 09:44:50.595939', '1');
INSERT INTO `ice_rate` VALUES ('d83c7cf2-fc3b-485c-8b15-1cd7a7027bb9', 'Calefones Y Sistemas De Calentamiento De Agua A Gas SENAE', '3771', '100%', '1', '2020-07-21 09:42:59.805395', '2020-07-21 09:42:59.805395', '1');
INSERT INTO `ice_rate` VALUES ('da01363e-826b-4d50-a5d1-c7ed56139eed', 'Vehículos Motorizados cuyo PVP superior USD 60.000 hasta 70.000', '3079', '30%', '1', '2020-07-21 09:05:47.084177', '2020-07-21 09:05:47.084177', '1');
INSERT INTO `ice_rate` VALUES ('da8a54a8-3e69-40e7-9d48-ec178b0d5ca0', 'Cerveza Industrial Pequeña Escala', '3041', '75%', '1', '2020-07-21 09:03:22.373179', '2020-07-21 09:03:22.373179', '1');
INSERT INTO `ice_rate` VALUES ('dac8b945-7ee9-429b-91e2-a5a95d24d316', 'Cerveza Gran Escala CAE', '3541', '75%', '1', '2020-07-21 09:18:35.832928', '2020-07-21 09:18:35.832928', '1');
INSERT INTO `ice_rate` VALUES ('db773b59-962e-4111-a536-1b110ba142c9', 'Cerveza Industrial de Mediana Escala CAE', '3541', '75%', '1', '2020-07-21 09:18:46.268063', '2020-07-21 09:18:46.268063', '1');
INSERT INTO `ice_rate` VALUES ('dbc46d3d-bcb5-4c62-b678-5fb2f9f758f5', 'Bebidas Gaseosas Con Bajo Contenido De Azucar SENAE', '3553', '10%', '1', '2020-07-21 09:41:38.027996', '2020-07-21 09:41:38.027996', '1');
INSERT INTO `ice_rate` VALUES ('e4a20720-5530-44a5-ab49-7be646d36b89', 'Vehículos Híbridos Cuyo PVP Superior USD. 60.000 Hasta 70.000', '3696', '26%', '1', '2020-07-21 09:16:57.976309', '2020-07-21 09:16:57.976309', '1');
INSERT INTO `ice_rate` VALUES ('e9299c0f-817a-4cf8-86ff-acce8ced7915', 'Vehículos Motorizados Cuyo PVP Superior USD 40.000 Hasta 50.000 SENAE', '3874', '20%', '1', '2020-07-21 09:40:02.492276', '2020-07-21 09:40:02.492276', '1');
INSERT INTO `ice_rate` VALUES ('e95db185-4e41-45dc-82ee-bb5fd5b3d48b', 'Fundas Plásticas', '3680', '-', '1', '2020-07-21 09:18:09.494888', '2020-07-21 09:18:09.494888', '1');
INSERT INTO `ice_rate` VALUES ('efe60271-f05b-445b-864c-eb7de86b63f0', 'Focos Incandescentes', '3640', '100%', '1', '2020-07-21 09:10:12.710306', '2020-07-21 09:10:12.710306', '1');
INSERT INTO `ice_rate` VALUES ('f10acb33-68bd-4aa3-93fe-2dd3d75e0c31', 'Vehículos Híbridos Cuyo PVP Superior USD. 40.000 Hasta 50.000 SENAE', '3693', '14%', '1', '2020-07-21 09:44:27.874456', '2020-07-21 09:44:27.874456', '1');
INSERT INTO `ice_rate` VALUES ('fbf36a49-3bce-4371-bb89-e73a9532dd6b', 'Bebidas Gaseosas Con Alto Contenido De Azúcar', '3053', '-', '1', '2020-07-21 09:11:15.364861', '2020-07-21 09:11:15.364861', '1');
INSERT INTO `ice_rate` VALUES ('fc301e64-488c-4351-976b-20d5cda316e1', 'Vehículos Híbridos Cuyo PVP Superior A USD 70.000', '3698', '32%', '1', '2020-07-21 09:17:25.922809', '2020-07-21 09:17:25.922809', '1');

-- ----------------------------
-- Table structure for invoice_detailment
-- ----------------------------
DROP TABLE IF EXISTS `invoice_detailment`;
CREATE TABLE `invoice_detailment` (
  `id` varchar(36) NOT NULL,
  `quantity` decimal(12,2) NOT NULL,
  `unitary_discount` decimal(12,4) DEFAULT NULL,
  `subtotal` decimal(12,4) NOT NULL,
  `additional_information` text,
  `status` tinyint NOT NULL DEFAULT '1',
  `created_at` datetime(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
  `modified_at` datetime(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
  `revision` int DEFAULT NULL,
  `documentId` varchar(36) DEFAULT NULL,
  `productId` varchar(36) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `FK_30f1075b9b6f4edc104c522f6da` (`documentId`),
  KEY `FK_128e774ad7538e6deea6b0e811a` (`productId`),
  CONSTRAINT `FK_128e774ad7538e6deea6b0e811a` FOREIGN KEY (`productId`) REFERENCES `product` (`id`),
  CONSTRAINT `FK_30f1075b9b6f4edc104c522f6da` FOREIGN KEY (`documentId`) REFERENCES `document` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of invoice_detailment
-- ----------------------------

-- ----------------------------
-- Table structure for iva_rate
-- ----------------------------
DROP TABLE IF EXISTS `iva_rate`;
CREATE TABLE `iva_rate` (
  `id` varchar(36) NOT NULL,
  `status` tinyint NOT NULL DEFAULT '1',
  `created_at` datetime(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
  `modified_at` datetime(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
  `revision` int DEFAULT NULL,
  `name` varchar(255) NOT NULL,
  `code` varchar(3) NOT NULL,
  `sort` smallint NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `IDX_45436d30c2d7482a313aa611aa` (`name`),
  UNIQUE KEY `IDX_095aaf64e785ede16e7d001b8e` (`code`),
  UNIQUE KEY `IDX_2cc7c3a48055490e56d50fcea6` (`sort`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of iva_rate
-- ----------------------------
INSERT INTO `iva_rate` VALUES ('138a3c18-586c-49d7-a25e-a32b4b1a6613', '1', '2020-07-21 08:05:23.494022', '2020-07-21 08:05:23.494022', '1', '14%', '3', '2');
INSERT INTO `iva_rate` VALUES ('169cb158-049f-49e2-a662-863ed240a004', '1', '2020-07-21 08:05:06.549305', '2020-07-21 08:05:06.549305', '1', '0%', '0', '1');
INSERT INTO `iva_rate` VALUES ('195604e7-8629-4e42-8fdf-4aec45f67fe6', '1', '2020-07-21 08:05:14.307525', '2020-07-21 08:05:14.307525', '1', '12%', '2', '0');
INSERT INTO `iva_rate` VALUES ('3740e5cb-959a-44df-9aca-65a7aae8dede', '1', '2020-07-21 08:05:54.493110', '2020-07-21 08:05:54.493110', '1', 'No Objeto de Impuesto', '6', '3');
INSERT INTO `iva_rate` VALUES ('3d3357b3-0011-41b7-9c3c-80f565e53ca1', '1', '2020-07-21 08:05:43.646675', '2020-07-21 08:05:43.646675', '1', 'Exento de IVA', '7', '4');

-- ----------------------------
-- Table structure for location
-- ----------------------------
DROP TABLE IF EXISTS `location`;
CREATE TABLE `location` (
  `id` varchar(36) NOT NULL,
  `location_code` varchar(3) NOT NULL,
  `emission_point_code` varchar(3) NOT NULL,
  `name` varchar(255) NOT NULL,
  `address` varchar(255) NOT NULL,
  `phone` varchar(20) NOT NULL,
  `email` varchar(255) NOT NULL,
  `sequential_invoice` varchar(9) NOT NULL,
  `sequential_retention` varchar(9) NOT NULL,
  `status` tinyint NOT NULL DEFAULT '1',
  `created_at` datetime(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
  `modified_at` datetime(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
  `revision` int DEFAULT NULL,
  `cityId` varchar(36) DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `IDX_e2769051a458c233a2856be320` (`location_code`),
  UNIQUE KEY `IDX_2dd44fa4d31b7bb2d8971dd96a` (`emission_point_code`),
  UNIQUE KEY `IDX_f0336eb8ccdf8306e270d400cf` (`name`),
  KEY `FK_7e10147ab0b2b8b0742a6869847` (`cityId`),
  CONSTRAINT `FK_7e10147ab0b2b8b0742a6869847` FOREIGN KEY (`cityId`) REFERENCES `city` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of location
-- ----------------------------

-- ----------------------------
-- Table structure for manufacturer
-- ----------------------------
DROP TABLE IF EXISTS `manufacturer`;
CREATE TABLE `manufacturer` (
  `id` varchar(36) NOT NULL,
  `name` varchar(45) NOT NULL,
  `status` tinyint NOT NULL DEFAULT '1',
  `created_at` datetime(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
  `modified_at` datetime(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
  `revision` int DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `IDX_a4687de45b74542072a2656b77` (`name`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of manufacturer
-- ----------------------------

-- ----------------------------
-- Table structure for parameter
-- ----------------------------
DROP TABLE IF EXISTS `parameter`;
CREATE TABLE `parameter` (
  `id` varchar(36) NOT NULL,
  `preset` smallint NOT NULL,
  `printerName` varchar(255) NOT NULL,
  `printerFontFamily` varchar(255) NOT NULL,
  `printerFontSize` smallint NOT NULL DEFAULT '8',
  `printerHeaderPositionX` smallint NOT NULL DEFAULT '0',
  `printerHeaderPositionY` smallint NOT NULL DEFAULT '0',
  `printerMainPositionX` smallint NOT NULL DEFAULT '0',
  `printerMainPositionY` smallint NOT NULL DEFAULT '0',
  `printerFooterPositionX` smallint NOT NULL DEFAULT '0',
  `printerFooterPositionY` smallint NOT NULL DEFAULT '0',
  `status` tinyint NOT NULL DEFAULT '1',
  `created_at` datetime(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
  `modified_at` datetime(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
  `revision` int DEFAULT NULL,
  `printerPageWidth` smallint NOT NULL DEFAULT '58',
  `printerPageHeight` smallint NOT NULL DEFAULT '140',
  `numberInvoice` varchar(15) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `IDX_0a66993328235ee0a08cc504bf` (`preset`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of parameter
-- ----------------------------
INSERT INTO `parameter` VALUES ('7c18cd1c-34dd-4875-93c5-0135127caf99', '1', 'EPSON FX-890 ESC/P', 'Open Sans', '8', '10', '10', '10', '40', '10', '200', '1', '2020-08-07 11:05:30.803794', '2020-08-11 10:04:37.539333', '1', '58', '140', '001003000000001');
INSERT INTO `parameter` VALUES ('7e223e08-7ad0-4a5a-87a5-3790fc5d9f86', '2', 'Adobe PDF', 'Roboto Light', '7', '10', '0', '7', '60', '100', '300', '1', '2020-08-07 18:07:45.747809', '2020-08-18 14:23:47.033439', '13', '76', '140', '001002000000011');
INSERT INTO `parameter` VALUES ('c1f9c11a-6490-49ba-9be8-12a761913cab', '3', 'EPSON TM-U220 Receipt', 'Roboto Light', '7', '10', '0', '7', '60', '100', '300', '1', '2020-08-08 10:53:51.335254', '2020-08-17 07:54:26.177946', '18', '76', '140', '001001000000010');

-- ----------------------------
-- Table structure for payment_method
-- ----------------------------
DROP TABLE IF EXISTS `payment_method`;
CREATE TABLE `payment_method` (
  `id` varchar(36) NOT NULL,
  `name` varchar(100) NOT NULL,
  `code` varchar(3) NOT NULL,
  `status` tinyint NOT NULL DEFAULT '1',
  `created_at` datetime(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
  `modified_at` datetime(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
  `revision` int DEFAULT NULL,
  `sort` smallint NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `IDX_f558eaa59d2ceaa387b95cf60d` (`sort`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of payment_method
-- ----------------------------
INSERT INTO `payment_method` VALUES ('0aa9b777-324d-4e64-ab70-d391b0701912', 'Endoso de Títulos', '21', '1', '2020-08-05 12:20:08.098120', '2020-08-05 12:20:08.098120', '1', '7');
INSERT INTO `payment_method` VALUES ('3d3cb17e-7f89-4ee4-9015-3e903a48675c', 'Sin utilización del Sistema Financiero', '01', '1', '2020-08-05 12:13:12.264551', '2020-08-05 12:13:12.264551', '1', '0');
INSERT INTO `payment_method` VALUES ('5fcf10d2-fa8a-405b-a5e7-19ad9cea3aed', 'Tarjeta prepago', '18', '1', '2020-08-05 12:18:49.988135', '2020-08-05 12:18:49.988135', '1', '5');
INSERT INTO `payment_method` VALUES ('6171d768-b70a-4480-9e9b-ba0e71292e57', 'Otros con utilización del Sistema Financiero', '20', '1', '2020-08-05 12:19:54.097991', '2020-08-05 12:19:54.097991', '1', '3');
INSERT INTO `payment_method` VALUES ('66d6d2a0-ba45-445e-8233-8491c664ba21', 'Tarjeta de débito', '16', '1', '2020-08-05 12:15:29.600551', '2020-08-05 12:15:29.600551', '1', '2');
INSERT INTO `payment_method` VALUES ('7ebe08cf-eb04-4ba0-adec-3a2f3710b098', 'Dinero electrónico', '17', '1', '2020-08-05 12:15:44.962057', '2020-08-05 12:15:44.962057', '1', '4');
INSERT INTO `payment_method` VALUES ('9e4e588e-4f23-487d-99e1-7e2a77fd8dc6', 'Tarjeta de crédito', '19', '1', '2020-08-05 12:19:27.581435', '2020-08-05 12:19:27.581435', '1', '1');
INSERT INTO `payment_method` VALUES ('ef9b0bdd-5ccb-4b95-b291-26a9c6ef240b', 'Compensación de deudas', '15', '1', '2020-08-05 12:15:07.126236', '2020-08-05 12:15:07.126236', '1', '6');

-- ----------------------------
-- Table structure for product
-- ----------------------------
DROP TABLE IF EXISTS `product`;
CREATE TABLE `product` (
  `id` varchar(36) NOT NULL,
  `main_code` varchar(45) NOT NULL,
  `aux_code` varchar(45) DEFAULT NULL,
  `name` varchar(255) NOT NULL,
  `detail` text,
  `cost` decimal(12,4) NOT NULL,
  `percentage_price` decimal(10,4) NOT NULL,
  `price` decimal(12,4) NOT NULL,
  `percentage_price2` decimal(10,4) DEFAULT NULL,
  `price2` decimal(12,4) DEFAULT NULL,
  `percentage_price3` decimal(10,4) DEFAULT NULL,
  `price3` decimal(12,4) DEFAULT NULL,
  `status` tinyint NOT NULL DEFAULT '1',
  `created_at` datetime(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
  `modified_at` datetime(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
  `revision` int DEFAULT NULL,
  `categoryId` varchar(36) DEFAULT NULL,
  `iceRateId` varchar(36) DEFAULT NULL,
  `ivaRateId` varchar(36) DEFAULT NULL,
  `typeProductId` varchar(36) DEFAULT NULL,
  `unitMeasurementId` varchar(36) DEFAULT NULL,
  `manufacturerId` varchar(36) DEFAULT NULL,
  `stock` int NOT NULL,
  `minimum_stock_level` int NOT NULL DEFAULT '0',
  `stock_indicator` int NOT NULL DEFAULT '0',
  `pvp` decimal(12,2) DEFAULT NULL,
  `pvp2` decimal(12,2) DEFAULT NULL,
  `pvp3` decimal(12,2) DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `IDX_4918144c576497e0f67999bd5c` (`main_code`),
  UNIQUE KEY `IDX_22cc43e9a74d7498546e9a63e7` (`name`),
  UNIQUE KEY `IDX_003c01d841a6869197a2847f23` (`aux_code`),
  KEY `FK_ff0c0301a95e517153df97f6812` (`categoryId`),
  KEY `FK_b2e3128e35254aa9444b38eb6ad` (`iceRateId`),
  KEY `FK_fc65d6a11d439f154cb27644533` (`ivaRateId`),
  KEY `FK_d304079ecdc3c8f3d0389c99270` (`typeProductId`),
  KEY `FK_c3229fac8194e5ff4ba27e8cd70` (`unitMeasurementId`),
  KEY `FK_da883f8d02581a40e6059bd7b38` (`manufacturerId`),
  CONSTRAINT `FK_b2e3128e35254aa9444b38eb6ad` FOREIGN KEY (`iceRateId`) REFERENCES `ice_rate` (`id`),
  CONSTRAINT `FK_c3229fac8194e5ff4ba27e8cd70` FOREIGN KEY (`unitMeasurementId`) REFERENCES `unit_measurement` (`id`),
  CONSTRAINT `FK_d304079ecdc3c8f3d0389c99270` FOREIGN KEY (`typeProductId`) REFERENCES `type_product` (`id`),
  CONSTRAINT `FK_da883f8d02581a40e6059bd7b38` FOREIGN KEY (`manufacturerId`) REFERENCES `manufacturer` (`id`),
  CONSTRAINT `FK_fc65d6a11d439f154cb27644533` FOREIGN KEY (`ivaRateId`) REFERENCES `iva_rate` (`id`),
  CONSTRAINT `FK_ff0c0301a95e517153df97f6812` FOREIGN KEY (`categoryId`) REFERENCES `category` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of product
-- ----------------------------

-- ----------------------------
-- Table structure for province
-- ----------------------------
DROP TABLE IF EXISTS `province`;
CREATE TABLE `province` (
  `id` varchar(36) NOT NULL,
  `name` varchar(255) NOT NULL,
  `status` tinyint NOT NULL DEFAULT '1',
  `created_at` datetime(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
  `modified_at` datetime(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
  `revision` int DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `IDX_aa290c4049a8aa685a81483389` (`name`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of province
-- ----------------------------

-- ----------------------------
-- Table structure for retention_concept
-- ----------------------------
DROP TABLE IF EXISTS `retention_concept`;
CREATE TABLE `retention_concept` (
  `id` varchar(36) NOT NULL,
  `name` varchar(255) NOT NULL,
  `code` varchar(5) NOT NULL,
  `percentage` smallint NOT NULL,
  `status` tinyint NOT NULL DEFAULT '1',
  `created_at` datetime(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
  `modified_at` datetime(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
  `revision` int DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of retention_concept
-- ----------------------------

-- ----------------------------
-- Table structure for retention_detailment
-- ----------------------------
DROP TABLE IF EXISTS `retention_detailment`;
CREATE TABLE `retention_detailment` (
  `id` varchar(36) NOT NULL,
  `tax_base` decimal(10,2) NOT NULL,
  `total` decimal(10,2) NOT NULL,
  `status` tinyint NOT NULL DEFAULT '1',
  `created_at` datetime(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
  `modified_at` datetime(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
  `revision` int DEFAULT NULL,
  `documentId` varchar(36) DEFAULT NULL,
  `retentionConceptId` varchar(36) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `FK_90277b2a21edcfedce82769dce9` (`documentId`),
  KEY `FK_e45e9dd5b6af087f338c8caf3b3` (`retentionConceptId`),
  CONSTRAINT `FK_90277b2a21edcfedce82769dce9` FOREIGN KEY (`documentId`) REFERENCES `document` (`id`),
  CONSTRAINT `FK_e45e9dd5b6af087f338c8caf3b3` FOREIGN KEY (`retentionConceptId`) REFERENCES `retention_concept` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of retention_detailment
-- ----------------------------

-- ----------------------------
-- Table structure for status_document
-- ----------------------------
DROP TABLE IF EXISTS `status_document`;
CREATE TABLE `status_document` (
  `id` varchar(36) NOT NULL,
  `name` varchar(255) NOT NULL,
  `acronym` varchar(25) NOT NULL,
  `status` tinyint NOT NULL DEFAULT '1',
  `created_at` datetime(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
  `modified_at` datetime(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
  `revision` int DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of status_document
-- ----------------------------
INSERT INTO `status_document` VALUES ('bbd5fc7c-b14c-40ad-8502-c9812cf2b18d', 'Anulado', 'ANL', '1', '2020-08-11 10:58:46.796247', '2020-08-11 10:58:46.796247', '1');
INSERT INTO `status_document` VALUES ('cd26423c-9993-45cb-97be-39741e757b5e', 'En procesamiento', 'PPR', '1', '2020-08-11 10:59:01.858514', '2020-08-11 10:59:01.858514', '1');
INSERT INTO `status_document` VALUES ('d2bd9937-c7fc-4757-9550-9c2b132b0d54', 'No Autorizado', 'NAT', '1', '2020-08-11 10:59:12.465871', '2020-08-11 10:59:12.465871', '1');
INSERT INTO `status_document` VALUES ('eec7ab12-9f43-459e-a7f0-c14b43157a74', 'Autorizado', 'AUT', '1', '2020-08-11 10:58:26.889597', '2020-08-11 10:58:26.889597', '1');

-- ----------------------------
-- Table structure for type_document
-- ----------------------------
DROP TABLE IF EXISTS `type_document`;
CREATE TABLE `type_document` (
  `id` varchar(36) NOT NULL,
  `name` varchar(50) NOT NULL,
  `code` varchar(3) NOT NULL,
  `status` tinyint NOT NULL DEFAULT '1',
  `created_at` datetime(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
  `modified_at` datetime(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
  `revision` int DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of type_document
-- ----------------------------
INSERT INTO `type_document` VALUES ('2d6e57da-0890-474a-9794-51edb49c9371', 'FACTURA VENTA', '01', '1', '2020-08-05 12:23:23.708021', '2020-08-05 12:23:23.708021', '1');
INSERT INTO `type_document` VALUES ('779ac1a5-a314-4a71-bcf6-6142119bbb24', 'NOTA DE CRÉDITO', '04', '1', '2020-08-05 12:23:58.238641', '2020-08-05 12:23:58.238641', '1');
INSERT INTO `type_document` VALUES ('8105ea05-a222-4032-bc86-a04f1c52269d', 'FACTURA COMPRA', '01', '1', '2020-08-11 16:06:50.365642', '2020-08-11 16:06:50.365642', '1');
INSERT INTO `type_document` VALUES ('8df29d45-f7c7-450e-940e-973b666387d5', 'GUÍA DE REMISIÓN', '06', '1', '2020-08-05 12:24:19.560171', '2020-08-05 12:24:19.560171', '1');
INSERT INTO `type_document` VALUES ('977a881c-8fdc-4f68-8b27-b4c51a55ed6a', 'NOTA DE DÉBITO', '05', '1', '2020-08-05 12:24:09.308757', '2020-08-05 12:24:09.308757', '1');
INSERT INTO `type_document` VALUES ('f28727ab-e02f-4b9b-80f2-f94a31c519eb', 'COMPROBANTE DE RETENCIÓN', '07', '1', '2020-08-05 12:24:28.498071', '2020-08-05 12:24:28.498071', '1');

-- ----------------------------
-- Table structure for type_identification
-- ----------------------------
DROP TABLE IF EXISTS `type_identification`;
CREATE TABLE `type_identification` (
  `id` varchar(36) NOT NULL,
  `code` varchar(3) NOT NULL,
  `description` varchar(45) NOT NULL,
  `status` tinyint NOT NULL DEFAULT '1',
  `created_at` datetime(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
  `modified_at` datetime(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
  `revision` int DEFAULT NULL,
  `sort` smallint NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `IDX_be21fd683f642c757dad785181` (`code`),
  UNIQUE KEY `IDX_9d9399f116c3567e5d52e73287` (`description`),
  UNIQUE KEY `IDX_120c24784f6a903c9fd5c5fad4` (`sort`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of type_identification
-- ----------------------------
INSERT INTO `type_identification` VALUES ('083bfb53-2cb2-4b16-b5cc-bbecd85f893a', '06', 'Pasaporte', '1', '2020-07-27 17:45:10.062875', '2020-07-27 17:45:10.062875', '1', '2');
INSERT INTO `type_identification` VALUES ('47b91a40-6b15-45c2-ac72-1dd99ae65762', '05', 'Cédula', '1', '2020-07-27 17:44:58.913823', '2020-07-27 17:44:58.913823', '1', '0');
INSERT INTO `type_identification` VALUES ('704fbffc-f951-4fa5-bddf-cbf21a113966', '08', 'Identificación del exterior', '1', '2020-07-27 17:47:47.104062', '2020-07-27 17:47:47.104062', '1', '3');
INSERT INTO `type_identification` VALUES ('f6dc1c0a-a60c-4c43-8938-7f16c04576db', '04', 'RUC', '1', '2020-07-27 17:44:30.796197', '2020-07-27 17:44:30.796197', '1', '1');

-- ----------------------------
-- Table structure for type_issuance
-- ----------------------------
DROP TABLE IF EXISTS `type_issuance`;
CREATE TABLE `type_issuance` (
  `id` varchar(36) NOT NULL,
  `name` varchar(45) NOT NULL,
  `code` varchar(3) NOT NULL,
  `status` tinyint NOT NULL DEFAULT '1',
  `created_at` datetime(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
  `modified_at` datetime(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
  `revision` int DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of type_issuance
-- ----------------------------
INSERT INTO `type_issuance` VALUES ('7960f419-fb2d-4d27-bae9-b9202d1874d3', 'Emisión Normal', '1', '1', '2020-07-21 08:00:35.125443', '2020-07-21 08:00:35.125443', '1');

-- ----------------------------
-- Table structure for type_product
-- ----------------------------
DROP TABLE IF EXISTS `type_product`;
CREATE TABLE `type_product` (
  `id` varchar(36) NOT NULL,
  `name` varchar(45) NOT NULL,
  `status` tinyint NOT NULL DEFAULT '1',
  `created_at` datetime(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
  `modified_at` datetime(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
  `revision` int DEFAULT NULL,
  `sort` smallint NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `IDX_f13d98326da9e40a0ac47ca341` (`name`),
  UNIQUE KEY `IDX_0b09d2c1ef03908da825aa0c52` (`sort`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of type_product
-- ----------------------------
INSERT INTO `type_product` VALUES ('16cb2c57-758c-4b0b-92c5-e240391c8ca5', 'Tasa', '1', '2020-07-21 07:57:45.194318', '2020-07-21 07:57:45.194318', '1', '3');
INSERT INTO `type_product` VALUES ('69b52f73-3412-4c90-9bd7-4d588ef8156d', 'Servicio', '1', '2020-07-21 07:57:31.129783', '2020-07-21 07:57:31.129783', '1', '1');
INSERT INTO `type_product` VALUES ('8865e586-b8bf-4b01-afad-b228392d227a', 'Bien', '1', '2020-07-21 07:57:25.691383', '2020-07-21 07:57:25.691383', '1', '0');
INSERT INTO `type_product` VALUES ('ebd9c9ea-07b2-45c1-96a0-0647cd426da0', 'Reembolso', '1', '2020-07-21 07:57:39.109674', '2020-07-21 07:57:39.109674', '1', '2');

-- ----------------------------
-- Table structure for unit_measurement
-- ----------------------------
DROP TABLE IF EXISTS `unit_measurement`;
CREATE TABLE `unit_measurement` (
  `id` varchar(36) NOT NULL,
  `name` varchar(255) NOT NULL,
  `symbol` varchar(45) DEFAULT NULL,
  `status` tinyint NOT NULL DEFAULT '1',
  `created_at` datetime(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
  `modified_at` datetime(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
  `revision` int DEFAULT NULL,
  `sort` smallint NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `IDX_356c56a2d0eff4b5aebe508bc9` (`name`),
  UNIQUE KEY `IDX_80b789aab16a8f7cb8e7febe5e` (`sort`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of unit_measurement
-- ----------------------------
INSERT INTO `unit_measurement` VALUES ('0d197275-58b3-4b16-8335-2ef2dbca2a43', 'Litro', 'lt', '1', '2020-07-21 07:50:45.977294', '2020-07-21 07:50:45.977294', '1', '6');
INSERT INTO `unit_measurement` VALUES ('0dbf1c26-2620-4168-8c67-277e36f31656', 'Gramo', 'g', '1', '2020-07-21 07:51:13.721772', '2020-07-21 07:51:13.721772', '1', '9');
INSERT INTO `unit_measurement` VALUES ('0e83cf79-e5bc-4cb1-8414-f4a66e015796', 'Kilogramo', 'kg', '1', '2020-07-21 07:51:04.527568', '2020-07-21 07:51:04.527568', '1', '8');
INSERT INTO `unit_measurement` VALUES ('1ed2160a-9b6a-4ddd-837e-54fa132d9dd5', 'Galón', 'gl', '1', '2020-07-21 07:54:10.914568', '2020-07-21 07:54:10.914568', '1', '15');
INSERT INTO `unit_measurement` VALUES ('28f47479-51c1-4746-bbe1-43dc3c24256e', 'Centímetro', 'cm', '1', '2020-07-21 07:50:17.709309', '2020-07-21 07:50:17.709309', '1', '3');
INSERT INTO `unit_measurement` VALUES ('2ff0d701-c3c3-4091-abe2-9c77d7a0d8b5', 'Unidad', 'u', '1', '2020-07-21 07:42:50.915228', '2020-07-21 07:46:37.000000', '2', '0');
INSERT INTO `unit_measurement` VALUES ('3b122cfe-bb3f-4a06-8da3-390e4e5d3891', 'Pie', 'ft', '1', '2020-07-21 08:01:29.148596', '2020-07-21 08:01:29.148596', '1', '5');
INSERT INTO `unit_measurement` VALUES ('3b8628d7-5db3-4bc1-b15f-5e1bf7158591', 'Arroba', 'a', '1', '2020-07-21 07:53:58.967125', '2020-07-21 07:53:58.967125', '1', '14');
INSERT INTO `unit_measurement` VALUES ('536d7e45-d14c-4965-b35f-0a392dbc1cc4', 'Par', 'par', '1', '2020-07-21 07:54:42.759550', '2020-07-21 07:54:42.759550', '1', '17');
INSERT INTO `unit_measurement` VALUES ('7f48c8bb-94b2-4dda-9ee9-dcd2c5ee1ff0', 'Quintal', 'q', '1', '2020-07-21 07:52:05.852426', '2020-07-21 07:52:05.852426', '1', '13');
INSERT INTO `unit_measurement` VALUES ('87b95f96-a4f3-413f-8e7e-2c2dba909036', 'Tonelada', 't', '1', '2020-07-21 07:54:27.955663', '2020-07-21 07:54:27.955663', '1', '16');
INSERT INTO `unit_measurement` VALUES ('8ce219b0-8ca8-468a-bf8d-37aefc0bed65', 'Metro cúbico', 'm3', '1', '2020-07-21 07:55:48.949264', '2020-07-21 07:55:48.949264', '1', '20');
INSERT INTO `unit_measurement` VALUES ('936110f7-f65c-41ab-9e86-e6e949ebbe43', 'Pulgada', 'In', '1', '2020-07-21 07:44:01.661769', '2020-07-21 07:44:01.661769', '1', '2');
INSERT INTO `unit_measurement` VALUES ('a9af3e07-4880-41f5-85b2-09f61f4731f1', 'Miligramo', 'mg', '1', '2020-07-21 07:51:20.476846', '2020-07-21 07:51:20.476846', '1', '10');
INSERT INTO `unit_measurement` VALUES ('abf7d069-5c1b-4118-a43b-eac48f0ad196', 'Paquete', 'pk', '1', '2020-07-21 07:52:18.445873', '2020-07-21 07:52:18.445873', '1', '1');
INSERT INTO `unit_measurement` VALUES ('be152ef2-e997-4abf-8979-8f86c19d4b0b', 'Metro cuadrado', 'm2', '1', '2020-07-21 07:55:41.064686', '2020-07-21 07:55:41.064686', '1', '19');
INSERT INTO `unit_measurement` VALUES ('db0040b4-d596-4c34-99dc-bd34de8648f4', 'Mililitro', 'ml', '1', '2020-07-21 07:50:56.118912', '2020-07-21 07:50:56.118912', '1', '7');
INSERT INTO `unit_measurement` VALUES ('de558fe5-410e-4436-9896-18d905147130', 'Libra', 'lb', '1', '2020-07-21 07:51:29.063646', '2020-07-21 07:51:29.063646', '1', '11');
INSERT INTO `unit_measurement` VALUES ('f999fb5a-82c9-4450-95d7-b3e32c8168e7', 'Yarda', 'yd', '1', '2020-07-21 07:55:05.433144', '2020-07-21 07:55:05.433144', '1', '18');
INSERT INTO `unit_measurement` VALUES ('fc4a7137-91ce-4aa1-a026-a9d705b81de3', 'Metro', 'm', '1', '2020-07-21 07:50:28.638510', '2020-07-21 07:50:28.638510', '1', '4');
INSERT INTO `unit_measurement` VALUES ('ff2d1170-e0a0-4cd2-b909-3159841995d6', 'Onza', 'oz', '1', '2020-07-21 07:51:36.017890', '2020-07-21 07:51:36.017890', '1', '12');

-- ----------------------------
-- Table structure for user
-- ----------------------------
DROP TABLE IF EXISTS `user`;
CREATE TABLE `user` (
  `id` varchar(36) NOT NULL,
  `username` varchar(16) NOT NULL,
  `email` varchar(255) NOT NULL,
  `password` varchar(32) NOT NULL,
  `status` tinyint NOT NULL DEFAULT '1',
  `created_at` datetime(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
  `modified_at` datetime(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
  `revision` int DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `IDX_78a916df40e02a9deb1c4b75ed` (`username`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of user
-- ----------------------------
INSERT INTO `user` VALUES ('2c2f7b0c-d234-4447-9392-fa976d61aeb4', 'user', 'user@example.com', '123', '1', '2020-07-13 15:24:27.459980', '2020-07-13 15:24:27.459980', '1');
INSERT INTO `user` VALUES ('65587b94-9b29-43e4-a224-24dfb85d5cbd', 'admin', 'admin@example.com', 'sluggard.avid.prohibit.redden', '1', '2020-07-13 16:20:28.646443', '2020-07-13 16:20:28.646443', '1');

-- ----------------------------
-- View structure for document_history
-- ----------------------------
DROP VIEW IF EXISTS `document_history`;
CREATE ALGORITHM=UNDEFINED DEFINER=`andres`@`localhost` SQL SECURITY DEFINER VIEW `document_history` AS select insert(insert(`document`.`number`,4,0,'-'),8,0,'-') AS `number`,`contact`.`business_name` AS `name`,`product`.`name` AS `product`,`invoice_detailment`.`quantity` AS `quantity`,`document`.`date_of_issue` AS `date_of_issue`,`document`.`total_value` AS `total_value`,`status_document`.`name` AS `status_document`,`document`.`id` AS `idDocument`,`invoice_detailment`.`id` AS `invoice_detailment`,substr(`type_document`.`name`,9,7) AS `type_document`,`payment_method`.`name` AS `payment_method`,`invoice_detailment`.`subtotal` AS `subtotal` from ((((((`document` join `contact` on((`document`.`contactId` = `contact`.`id`))) join `type_document` on((`document`.`typeDocumentId` = `type_document`.`id`))) join `status_document` on((`document`.`statusDocumentId` = `status_document`.`id`))) join `payment_method` on((`document`.`paymentMethodId` = `payment_method`.`id`))) join `invoice_detailment` on((`invoice_detailment`.`documentId` = `document`.`id`))) join `product` on((`invoice_detailment`.`productId` = `product`.`id`))) order by `document`.`date_of_issue` desc,`document`.`number` desc ;

-- ----------------------------
-- View structure for facturas_autorizadas
-- ----------------------------
DROP VIEW IF EXISTS `facturas_autorizadas`;
CREATE ALGORITHM=UNDEFINED DEFINER=`andres`@`localhost` SQL SECURITY DEFINER VIEW `facturas_autorizadas` AS select `document`.`number` AS `number`,`type_document`.`name` AS `type_document`,`status_document`.`name` AS `status_document`,`document`.`date_of_issue` AS `date_of_issue`,`document`.`total_value` AS `total_value` from ((`document` join `type_document` on((`document`.`typeDocumentId` = `type_document`.`id`))) join `status_document` on((`document`.`statusDocumentId` = `status_document`.`id`))) where ((`status_document`.`name` = 'Autorizado') and (`type_document`.`name` = 'FACTURA VENTA')) ;

-- ----------------------------
-- View structure for product_iva_rate_view
-- ----------------------------
DROP VIEW IF EXISTS `product_iva_rate_view`;
CREATE ALGORITHM=UNDEFINED DEFINER=`andres`@`localhost` SQL SECURITY DEFINER VIEW `product_iva_rate_view` AS select `product`.`id` AS `id`,`product`.`main_code` AS `main_code`,`product`.`name` AS `name`,`product`.`stock` AS `stock`,`product`.`cost` AS `cost`,`product`.`price` AS `price`,`product`.`price2` AS `price2`,`product`.`price3` AS `price3`,`iva_rate`.`name` AS `iva_rate_name` from (`product` join `iva_rate` on((`product`.`ivaRateId` = `iva_rate`.`id`))) ;
