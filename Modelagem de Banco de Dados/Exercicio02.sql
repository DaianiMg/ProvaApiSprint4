CREATE DATABASE minimercado;
USE minimercado;

CREATE TABLE fornecedor( 
id INT,
nome VARCHAR (50) NOT NULL,
telefone VARCHAR(12) NOT NULL,
email VARCHAR (50),
CONSTRAINT PK_FORNECEDOR primary key (id));
    
CREATE TABLE produto_fornecedor( 
id INT,
preco_custo DOUBLE PRECISION NOT NULL,
telefone VARCHAR(12) NOT NULL,
id_produto INT,
CONSTRAINT PK_PRODUTO_FORNECEDOR PRIMARY KEY (id),
CONSTRAINT FK_ID_PRODUTO FOREIGN KEY (id_produto) REFERENCES fornecedor (id));

CREATE TABLE cadastro_produto(
id INT,
nome VARCHAR (50) NOT NULL,
preco_unitario DOUBLE PRECISION NOT NULL,
id_fornecedor_produto INT,
CONSTRAINT PK_CADASTRO_PRODUTO PRIMARY KEY (id),
CONSTRAINT FK_PRODUTO_FORNECEDOR FOREIGN KEY (id_fornecedor_produto) REFERENCES produto_fornecedor (id));

CREATE TABLE tipo_produto(
id INT,
descricao VARCHAR (50),
id_produto INT,
CONSTRAINT PK_TIPO_PRODUTO PRIMARY KEY (id),
CONSTRAINT FK_CADASTRO_PRODUTO FOREIGN KEY (id_produto) REFERENCES cadastro_produto (id));

CREATE TABLE cadastro_estoque(
id INT,
quantidade INT,
validade DATE NOT NULL,
id_tipo_produto INT,
CONSTRAINT PK_CADASTRO_ESTOQUE PRIMARY KEY (id),
CONSTRAINT FK_TIPO_PRODUTO FOREIGN KEY (id_tipo_produto) REFERENCES tipo_produto (id));

CREATE TABLE cadastro_venda(
id INT,
data_venda DATE NOT NULL,
id_produto INT,
quantidade int NOT NULL,
id_estoque int,
CONSTRAINT PK_CADASTRO_VENDA PRIMARY KEY (id),
CONSTRAINT FK_CADASTRO_ESTOQUE FOREIGN KEY (id_estoque) REFERENCES cadastro_estoque (id));
SHOW TABLES from minimercado;
