-- Active: 1711142108469@@35.87.147.206@3306@honest_wendigo_9013b4_db
CREATE TABLE accounts(
  id VARCHAR(255) NOT NULL primary key COMMENT 'primary key',
  createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
  updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
  name varchar(255) COMMENT 'User Name',
  email varchar(255) COMMENT 'User Email',
  picture varchar(255) COMMENT 'User Picture'
) default charset utf8mb4 COMMENT '';


CREATE TABLE houses( 
  id INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
  createdAt DATETIME DEFAULT CURRENT_TIMESTAMP,
  updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  title VARCHAR(100) NOT NULL,
  bedrooms INT NOT NULL,
  bathrooms INT NOT NULL,
  ownedOutright BOOLEAN DEFAULT FALSE,
  price INT NOT NULL,
  description VARCHAR(1000),
  creatorId VARCHAR(255) NOT NULL,
  FOREIGN KEY(creatorId) REFERENCES accounts(id) ON DELETE CASCADE
  )

  -- DROP TABLE houses;

  SELECT id, name FROM accounts;



INSERT INTO 
houses
(title, bedrooms, bathrooms, ownedOutright, price, creatorId, description)
VALUES
("Trailer", 2, 1, true, 25000, "65ea1327f93050d16317c396", "Nice enough!");