CREATE DATABASE IF NOT EXISTS dbAgenda;

use dbAgenda;

CREATE TABLE IF NOT EXISTS tbUsuarios(
	nome VARCHAR(50) NOT NULL,
    usuario VARCHAR(30) PRIMARY KEY,
    telefone VARCHAR(15),
    senha VARCHAR(20) NOT NULL
);

CREATE TABLE IF NOT EXISTS tbCategorias(
	id INT PRIMARY KEY AUTO_INCREMENT,
    categoria VARCHAR(30) NOT NULL,
    usuario VARCHAR(30)
);

CREATE TABLE IF NOT EXISTS tbLog(
	id INT PRIMARY KEY AUTO_INCREMENT,
	usuario VARCHAR(30),
    dtAcao DATETIME,
    acao VARCHAR(50)
);

DELIMITER //
CREATE TRIGGER trinsertcategoria
BEFORE INSERT ON tbcategorias
FOR EACH ROW BEGIN
	SET NEW.usuario = USER();
END;
//

DELIMITER ;

DELIMITER //
CREATE TRIGGER trCadastroLogDelete
BEFORE DELETE ON tbcategorias
FOR EACH ROW
BEGIN
	INSERT INTO tblog(usuario,dtAcao,acao) VALUES(user(),now(), concat('a categoria ', old.categoria ,' foi deletada'));
END;
//

DELIMITER ;

DELIMITER //
CREATE TRIGGER trCadastroLogInsert
AFTER INSERT ON tbcategorias
FOR EACH ROW
BEGIN
	INSERT INTO tblog(usuario,dtAcao,acao) VALUES(user(),now(), concat('a categoria ', new.categoria ,' foi inserida'));
END;
//

DELIMITER ;

DELIMITER //
CREATE TRIGGER trCadastroLogUpdate
AFTER UPDATE ON tbcategorias
FOR EACH ROW
BEGIN
	INSERT INTO tblog(usuario,dtAcao,acao) VALUES(user(),now(), concat('a categoria ', old.categoria ,' foi modificada para ', new.categoria));
END;
//

DELIMITER ;
