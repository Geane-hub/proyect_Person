-- Script de Base de Datos para el proyecto proyect_Person (db_igmr)
-- Diseñado con Entidad-Relación (Herencia / TPT: Tabla por Tipo)

CREATE DATABASE IF NOT EXISTS `db_igmr` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `db_igmr`;

-- 1. Tabla Padre: person
CREATE TABLE IF NOT EXISTS `person` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `dni` VARCHAR(10) DEFAULT NULL,
  `name` VARCHAR(50) DEFAULT NULL,
  `yearBirth` INT DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- 2. Tabla Hija: student (Relacionada 1 a 1 con person por id)
CREATE TABLE IF NOT EXISTS `student` (
  `id` INT NOT NULL,
  `nota1` DOUBLE DEFAULT NULL,
  `nota2` DOUBLE DEFAULT NULL,
  PRIMARY KEY (`id`),
  CONSTRAINT `fk_student_person` FOREIGN KEY (`id`) REFERENCES `person` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- 3. Tabla Hija: teacher (Relacionada 1 a 1 con person por id)
CREATE TABLE IF NOT EXISTS `teacher` (
  `id` INT NOT NULL,
  `title` VARCHAR(50) DEFAULT NULL,
  `sueldo` DOUBLE DEFAULT NULL,
  PRIMARY KEY (`id`),
  CONSTRAINT `fk_teacher_person` FOREIGN KEY (`id`) REFERENCES `person` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
