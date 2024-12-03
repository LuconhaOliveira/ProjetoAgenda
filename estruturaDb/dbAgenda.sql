CREATE DATABASE IF NOT EXISTS dbAgenda;

use dbAgenda;

CREATE TABLE IF NOT EXISTS tbUsuarios(
	nome VARCHAR(50) NOT NULL,
    usuario VARCHAR(30) PRIMARY KEY,
    telefone VARCHAR(15),
    senha VARCHAR(20) NOT NULL
);

CREATE TABLE IF NOT EXISTS tbContatos(
	id INT PRIMARY KEY AUTO_INCREMENT,
	nome VARCHAR(50) NOT NULL,
    telefone VARCHAR(15) NOT NULL,
    categoria VARCHAR(30),
    usuario VARCHAR(30)
);

CREATE TABLE IF NOT EXISTS tbLogContatos(
	id INT PRIMARY KEY AUTO_INCREMENT,
    idContato INT,
	usuario VARCHAR(30),
    dtAcao DATETIME,
    acao VARCHAR(50)
);

CREATE TABLE IF NOT EXISTS tbCategorias(
	id INT PRIMARY KEY AUTO_INCREMENT,
    categoria VARCHAR(30) NOT NULL,
    usuario VARCHAR(30)
);

CREATE TABLE IF NOT EXISTS tbLogCategorias(
	id INT PRIMARY KEY AUTO_INCREMENT,
    idCategoria INT,
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
CREATE TRIGGER trinsertcontato
BEFORE INSERT ON tbcontatos
FOR EACH ROW BEGIN
	SET NEW.usuario = USER();
END;
//

DELIMITER ;

DELIMITER //
CREATE TRIGGER trCadastroLogCategoriaDelete
BEFORE DELETE ON tbcategorias
FOR EACH ROW
BEGIN
	INSERT INTO tblogcategorias(usuario,idcategoria,dtAcao,acao) VALUES(user(),OLD.id,now(), concat('a categoria ', old.categoria ,' foi deletada'));
END;
//

DELIMITER ;

DELIMITER //
CREATE TRIGGER trCadastroLogCategoriaInsert
AFTER INSERT ON tbcategorias
FOR EACH ROW
BEGIN
	INSERT INTO tblogcategorias(usuario,idcategoria,dtAcao,acao) VALUES(user(),NEW.id,now(), concat('a categoria ', new.categoria ,' foi inserida'));
END;
//

DELIMITER ;

DELIMITER //
CREATE TRIGGER trCadastroLogCategoriaUpdate
AFTER UPDATE ON tbcategorias
FOR EACH ROW
BEGIN
	INSERT INTO tblogcategorias(usuario,idcategoria,dtAcao,acao) VALUES(user(),OLD.id,now(), concat('a categoria ', old.categoria ,' foi modificada para ', new.categoria));
END;
//

DELIMITER ;

DELIMITER //
CREATE TRIGGER trCadastroLogContatoDelete
BEFORE DELETE ON tbcontatos
FOR EACH ROW
BEGIN
	INSERT INTO tblogcontatos(usuario,idcontato,dtAcao,acao) VALUES(user(),OLD.id,now(), concat('o contato ', old.nome ,' foi deletado'));
END;
//

DELIMITER ;

DELIMITER //
CREATE TRIGGER trCadastroLogContatoInsert
AFTER INSERT ON tbcontatos
FOR EACH ROW
BEGIN
	INSERT INTO tblogcontatos(usuario,idcontato,dtAcao,acao) VALUES(user(),NEW.id,now(), concat('o contato ', new.nome ,' foi inserido'));
END;
//

DELIMITER ;

DELIMITER //
CREATE TRIGGER trCadastroLogContatoUpdate
AFTER UPDATE ON tbcontatos
FOR EACH ROW
BEGIN
	INSERT INTO tblogcontatos(usuario,idcontato,dtAcao,acao) VALUES(user(),OLD.id,now(), concat('o contato ', old.nome ,' foi modificada para ', new.nome));
END;
//

DELIMITER ;
