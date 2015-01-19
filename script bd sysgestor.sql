SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema SysGestor
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `SysGestor` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci ;
USE `SysGestor` ;

-- -----------------------------------------------------
-- Table `SysGestor`.`pessoa`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `SysGestor`.`pessoa` (
  `idpessoa` INT NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(100) NOT NULL,
  `tipopessoa` VARCHAR(25) NOT NULL,
  `cpfcnpj` VARCHAR(20) NULL,
  `rgie` VARCHAR(20) NULL,
  `datanascimento` DATE NULL,
  `datacadastro` DATETIME NULL,
  `ativo` INT NOT NULL DEFAULT 0,
  `observacao` LONGTEXT NULL,
  PRIMARY KEY (`idpessoa`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `SysGestor`.`contato`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `SysGestor`.`contato` (
  `idcontato` INT NOT NULL AUTO_INCREMENT,
  `telfixo` VARCHAR(20) NULL,
  `telcel` VARCHAR(20) NULL,
  `telcomercial` VARCHAR(20) NULL,
  `email` VARCHAR(45) NULL,
  `idpessoa` INT NOT NULL,
  PRIMARY KEY (`idcontato`),
  INDEX `fk_contato_pessoa_idx` (`idpessoa` ASC),
  CONSTRAINT `fk_contato_pessoa`
    FOREIGN KEY (`idpessoa`)
    REFERENCES `SysGestor`.`pessoa` (`idpessoa`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `SysGestor`.`cidade`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `SysGestor`.`cidade` (
  `idcidade` INT NOT NULL AUTO_INCREMENT,
  `cidade` VARCHAR(70) NOT NULL,
  `uf` VARCHAR(2) NOT NULL,
  PRIMARY KEY (`idcidade`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `SysGestor`.`endereco`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `SysGestor`.`endereco` (
  `idendereco` INT NOT NULL AUTO_INCREMENT,
  `logradouro` VARCHAR(100) NOT NULL,
  `numero` VARCHAR(15) NOT NULL,
  `complemento` VARCHAR(45) NULL,
  `cep` VARCHAR(10) NOT NULL,
  `bairro` VARCHAR(100) NOT NULL,
  `idpessoa` INT NOT NULL,
  `idcidade` INT NOT NULL,
  PRIMARY KEY (`idendereco`),
  INDEX `fk_endereco_pessoa1_idx` (`idpessoa` ASC),
  INDEX `fk_endereco_cidade1_idx` (`idcidade` ASC),
  CONSTRAINT `fk_endereco_pessoa1`
    FOREIGN KEY (`idpessoa`)
    REFERENCES `SysGestor`.`pessoa` (`idpessoa`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_endereco_cidade1`
    FOREIGN KEY (`idcidade`)
    REFERENCES `SysGestor`.`cidade` (`idcidade`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `SysGestor`.`perfil`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `SysGestor`.`perfil` (
  `idperfil` INT NOT NULL AUTO_INCREMENT,
  `descrperfil` VARCHAR(45) NOT NULL,
  `ativo` INT NOT NULL DEFAULT 0,
  PRIMARY KEY (`idperfil`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `SysGestor`.`usuario`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `SysGestor`.`usuario` (
  `idusuario` INT NOT NULL AUTO_INCREMENT,
  `login` VARCHAR(45) NOT NULL,
  `senha` VARCHAR(45) NOT NULL,
  `ativo` INT NOT NULL DEFAULT 0,
  `idperfil` INT NOT NULL,
  `idpessoa` INT NOT NULL,
  PRIMARY KEY (`idusuario`),
  INDEX `fk_usuario_perfil1_idx` (`idperfil` ASC),
  INDEX `fk_usuario_pessoa1_idx` (`idpessoa` ASC),
  CONSTRAINT `fk_usuario_perfil1`
    FOREIGN KEY (`idperfil`)
    REFERENCES `SysGestor`.`perfil` (`idperfil`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_usuario_pessoa1`
    FOREIGN KEY (`idpessoa`)
    REFERENCES `SysGestor`.`pessoa` (`idpessoa`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `SysGestor`.`valorproduto`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `SysGestor`.`valorproduto` (
  `idvalorprod` INT NOT NULL AUTO_INCREMENT,
  `valorcompra` DOUBLE NOT NULL,
  `valorvenda` DOUBLE NOT NULL,
  `margem` DECIMAL(12,3) NULL COMMENT 'Margem de lucro do produto ou serviç' /* comment truncated */ /*
*/,
  `comisao` DECIMAL(12,3) NULL COMMENT 'Porcentagem da comissão do serviço executado pelo funcionário.',
  PRIMARY KEY (`idvalorprod`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `SysGestor`.`categoria`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `SysGestor`.`categoria` (
  `idcategoria` INT NOT NULL AUTO_INCREMENT,
  `descrcategoria` VARCHAR(60) NOT NULL,
  `ativo` INT NOT NULL DEFAULT 0,
  PRIMARY KEY (`idcategoria`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `SysGestor`.`grade`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `SysGestor`.`grade` (
  `idgrade` INT NOT NULL AUTO_INCREMENT,
  `descrgrade` VARCHAR(20) NOT NULL,
  `ativo` INT NOT NULL DEFAULT 0,
  PRIMARY KEY (`idgrade`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `SysGestor`.`produto`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `SysGestor`.`produto` (
  `idproduto` INT NOT NULL AUTO_INCREMENT,
  `codigointerno` VARCHAR(45) NULL,
  `descricao` VARCHAR(100) NOT NULL,
  `estoqueminimo` DECIMAL(12,3) NULL,
  `localizacaofisica` VARCHAR(20) NULL COMMENT 'Localização do produto na loja.',
  `ativo` INT NOT NULL DEFAULT 0,
  `idvalorproduto` INT NOT NULL,
  `idcategoria` INT NOT NULL,
  `idgrade` INT NOT NULL,
  PRIMARY KEY (`idproduto`),
  INDEX `fk_produto_valor_produto1_idx` (`idvalorproduto` ASC),
  INDEX `fk_produto_categoria1_idx` (`idcategoria` ASC),
  INDEX `fk_produto_grade1_idx` (`idgrade` ASC),
  CONSTRAINT `fk_produto_valor_produto1`
    FOREIGN KEY (`idvalorproduto`)
    REFERENCES `SysGestor`.`valorproduto` (`idvalorprod`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_produto_categoria1`
    FOREIGN KEY (`idcategoria`)
    REFERENCES `SysGestor`.`categoria` (`idcategoria`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_produto_grade1`
    FOREIGN KEY (`idgrade`)
    REFERENCES `SysGestor`.`grade` (`idgrade`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `SysGestor`.`departamento`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `SysGestor`.`departamento` (
  `iddepartamento` INT NOT NULL AUTO_INCREMENT,
  `descrdepartamento` VARCHAR(45) NOT NULL,
  `ativo` INT NOT NULL DEFAULT 0,
  PRIMARY KEY (`iddepartamento`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `SysGestor`.`funcao`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `SysGestor`.`funcao` (
  `idfuncao` INT NOT NULL AUTO_INCREMENT,
  `descrfuncao` VARCHAR(45) NOT NULL,
  `ativo` INT NOT NULL DEFAULT 0,
  PRIMARY KEY (`idfuncao`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `SysGestor`.`funcionario`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `SysGestor`.`funcionario` (
  `idfuncionario` INT NOT NULL AUTO_INCREMENT,
  `iddepartamento` INT NOT NULL,
  `idfuncao` INT NOT NULL,
  `idpessoa` INT NOT NULL,
  PRIMARY KEY (`idfuncionario`),
  INDEX `fk_funcionario_departamento1_idx` (`iddepartamento` ASC),
  INDEX `fk_funcionario_funcao1_idx` (`idfuncao` ASC),
  INDEX `fk_funcionario_pessoa1_idx` (`idpessoa` ASC),
  CONSTRAINT `fk_funcionario_departamento1`
    FOREIGN KEY (`iddepartamento`)
    REFERENCES `SysGestor`.`departamento` (`iddepartamento`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_funcionario_funcao1`
    FOREIGN KEY (`idfuncao`)
    REFERENCES `SysGestor`.`funcao` (`idfuncao`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_funcionario_pessoa1`
    FOREIGN KEY (`idpessoa`)
    REFERENCES `SysGestor`.`pessoa` (`idpessoa`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `SysGestor`.`cliente`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `SysGestor`.`cliente` (
  `idcliente` INT NOT NULL AUTO_INCREMENT,
  `idpessoa` INT NOT NULL,
  PRIMARY KEY (`idcliente`),
  INDEX `fk_cliente_pessoa1_idx` (`idpessoa` ASC),
  CONSTRAINT `fk_cliente_pessoa1`
    FOREIGN KEY (`idpessoa`)
    REFERENCES `SysGestor`.`pessoa` (`idpessoa`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `SysGestor`.`pedido`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `SysGestor`.`pedido` (
  `idpedido` INT NOT NULL AUTO_INCREMENT,
  `datapedido` DATE NOT NULL,
  `status` INT NOT NULL COMMENT 'Define se é orçamento ou pedido concret' /* comment truncated */ /*.
0=Orçamento
1=Pedido Concreto*/,
  `idusuario` INT NOT NULL,
  `idfuncionario` INT NOT NULL,
  `idcliente` INT NOT NULL,
  PRIMARY KEY (`idpedido`),
  INDEX `fk_pedido_usuario1_idx` (`idusuario` ASC),
  INDEX `fk_pedido_funcionario1_idx` (`idfuncionario` ASC),
  INDEX `fk_pedido_cliente1_idx` (`idcliente` ASC),
  CONSTRAINT `fk_pedido_usuario1`
    FOREIGN KEY (`idusuario`)
    REFERENCES `SysGestor`.`usuario` (`idusuario`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_pedido_funcionario1`
    FOREIGN KEY (`idfuncionario`)
    REFERENCES `SysGestor`.`funcionario` (`idfuncionario`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_pedido_cliente1`
    FOREIGN KEY (`idcliente`)
    REFERENCES `SysGestor`.`cliente` (`idcliente`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `SysGestor`.`itempedido`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `SysGestor`.`itempedido` (
  `idpedido` INT NOT NULL,
  `idproduto` INT NOT NULL,
  `qtd` DECIMAL(12,3) NOT NULL,
  `desconto` DOUBLE NULL,
  PRIMARY KEY (`idpedido`, `idproduto`),
  INDEX `fk_itempedido_produto1_idx` (`idproduto` ASC),
  CONSTRAINT `fk_itempedido_pedido1`
    FOREIGN KEY (`idpedido`)
    REFERENCES `SysGestor`.`pedido` (`idpedido`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_itempedido_produto1`
    FOREIGN KEY (`idproduto`)
    REFERENCES `SysGestor`.`produto` (`idproduto`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `SysGestor`.`parcela`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `SysGestor`.`parcela` (
  `idparcela` INT NOT NULL AUTO_INCREMENT,
  `idpedido` INT NOT NULL,
  `datavenc` DATE NOT NULL,
  `valorparc` DOUBLE NOT NULL,
  `datapag` DATE NULL,
  `valorpago` DOUBLE NULL,
  PRIMARY KEY (`idparcela`, `idpedido`),
  INDEX `fk_parcela_pedido1_idx` (`idpedido` ASC),
  CONSTRAINT `fk_parcela_pedido1`
    FOREIGN KEY (`idpedido`)
    REFERENCES `SysGestor`.`pedido` (`idpedido`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
