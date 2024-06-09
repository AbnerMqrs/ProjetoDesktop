CREATE DATABASE LOJAUNIFUNEC2024;

create table sexo (
	codsexo int identity primary key,
	nomesexo varchar(9) not null
);

INSERT INTO sexo (nomesexo) VALUES 
('Masculino'),
('Feminino'),
('Outro'),
('Nao sei'),
('Invalido')

select * from sexo;

create table rua(
	codrua int identity primary key,
	nomerua varchar (80) not null unique
);

INSERT INTO rua (nomerua) VALUES 
('Rua Isaura Parente'),
('Rua Epaminondas Jácome'),
('Avenida Padre Júlio Maria Lombaerd'),
('Avenida André Araújo'),
('Largo do Pelourinho'),
('Avenida Beira Mar'),
('SHIN Quadra 116'),
('Rua Joaquim Lírio'),
('Alameda dos Buritis'),
('Avenida dos Africanos'),
('Rua das Garças'),
('Avenida Afonso Pena'),
('Rua Antônio de Albuquerque'),
('Rua dos Pariquis'),
('Avenida Argemiro de Figueiredo'),
('Avenida do Batel'),
('Avenida Boa Viagem'),
('Rua Coelho de Resende'),
('Avenida Atlântica'),
('Rua Trairi'),
('Rua Padre Chagas'),
('Rua 7 de Setembro'),
('Avenida Getúlio Vargas'),
('Avenida Beira Mar Norte'),
('Avenida Paulista'),
('Avenida Beira Mor'),
('Avenida NS 4'); 

select * from rua;

create table bairro (
	codbairro int identity primary key, 
	nomebairro varchar (80) not null unique
);

INSERT INTO bairro (nomebairro) VALUES 
('Bosque'),
('Pajuçara'),
('Buritizal'),
('Adrianópolis'),
('Pelourinho'),
('Beira Mar'),
('Asa Norte'),
('Praia do Canto'),
('Setor Bueno'),
('Ponta d Areia'),
('Santa Rosa'),
('Centro'),
('Savassi'),
('Batista Campos'),
('Bessa'),
('Batel'),
('Boa Viagem'),
('Jóquei'),
('Copacabana'),
('Tirol'),
('Moinhos de Vento'),
('Cidade Alta'),
('Centro Norte'),
('Beira Mar Norte'),
('Jardins'),
('Atalaia'),
('Plano Diretor Sul');

select * from bairro;

create table cep (
	codcep int identity primary  key,
	numerocep varchar(8) not null
);

INSERT INTO cep (numerocep) VALUES 
('69900000'),
('57000000'),
('68900000'),
('69000000'),
('40000000'),
('60000000'),
('70000000'),
('29000000'),
('74000000'),
('65000000'),
('78000000'),
('79000000'),
('30100000'),
('66000000'),
('58000000'),
('80000000'),
('50000000'),
('64000000'),
('20000000'),
('59000000'),
('90000000'),
('76800000'),
('69300000'),
('88000000'),
('01000000'),
('49000000'),
('77000000');

select * from cep;

create table uf (
	coduf int identity primary key,
	nomeuf varchar(80) not null,
	siglauf char(2) not null
);

INSERT INTO uf (nomeuf, siglauf) VALUES 
('Acre', 'AC'),
('Alagoas', 'AL'),
('Amapá', 'AP'),
('Amazonas', 'AM'),
('Bahia', 'BA'),
('Ceará', 'CE'),
('Distrito Federal', 'DF'),
('Espírito Santo', 'ES'),
('Goiás', 'GO'),
('Maranhão', 'MA'),
('Mato Grosso', 'MT'),
('Mato Grosso do Sul', 'MS'),
('Minas Gerais', 'MG'),
('Pará', 'PA'),
('Paraíba', 'PB'),
('Paraná', 'PR'),
('Pernambuco', 'PE'),
('Piauí', 'PI'),
('Rio de Janeiro', 'RJ'),
('Rio Grande do Norte', 'RN'),
('Rio Grande do Sul', 'RS'),
('Rondônia', 'RO'),
('Roraima', 'RR'),
('Santa Catarina', 'SC'),
('São Paulo', 'SP'),
('Sergipe', 'SE'),
('Tocantins', 'TO');

select * from uf;

create table cidade (
	codcidade int identity primary key,
	nomecidade varchar (80) not null,
	codsiglauffk int references uf(coduf) on delete cascade on update cascade
);

INSERT INTO cidade (nomecidade, codsiglauffk) VALUES 
('Acrelândia', 1), 
('Assis Brasil', 1), 
('Alto Alegre', 1),
('Barra de Santo Antônio', 2), 
('Boca da Mata', 2), 
('Batalha', 2),
('Cantá', 22), 
('Caracaraí', 22), 
('Canta', 22),
('Doutor Ulysses', 16), 
('Dois Vizinhos', 16), 
('Diamante D''Oeste', 16),
('Espírito Santo', 20), 
('Extremoz', 20), 
('Encanto', 20),
('Florianópolis', 24), 
('Fraiburgo', 24), (
'Forquilhinha', 24),
('Goiânia', 9), 
('Goiás', 9), ('Guapó', 9),
('Humaitá', 4), 
('Hidrolândia', 4), 
('Humaitá', 4),
('Icó', 6), 
('Iguatu', 6), 
('Itapipoca', 6),
('Jaguariaíva', 16), 
('Jandaia do Sul', 16), 
('Japira', 16),
('Kubitschek de Oliveira', 13), 
('Kennedy', 13), 
('Kokama', 13),
('Lucas do Rio Verde', 11), 
('Luciara', 11), 
('Lambari D''Oeste', 11),
('Manari', 17), 
('Maraial', 17), 
('Moreno', 17),
('Nova Olímpia', 11), 
('Nova Bandeirantes', 11), 
('Nossa Senhora do Livramento', 11),
('Ouro Verde de Goiás', 9), 
('Orizona', 9), 
('Ouvidor', 9),
('Praia Grande', 25), 
('Pedreira', 25), 
('Paraibuna', 25),
('Quixeramobim', 6), 
('Quixeré', 6), 
('Quixelô', 6),
('Rondonópolis', 11), 
('Rosário Oeste', 11), 
('Rio Branco', 11),
('Santana do Matos', 20), 
('São José do Seridó', 20), 
('São Rafael', 20),
('Tibagi', 16), 
('Terra Rica', 16), 
('Tapejara', 16),
('Ubatã', 5), 
('Ubaíra', 5), 
('Ubatã', 5),
('Valparaíso de Goiás', 9), 
('Varjão', 9), 
('Valparaíso de Goiás', 9),
('Wenceslau Braz', 16), 
('Witmarsum', 16), 
('Wanderlândia', 16),
('Xique-Xique', 5), 
('Xique-Xique', 5), 
('Xique-Xique', 5),
('Ypiranga', 2), 
('Ypiranga do Sul', 21), 
('Ypiranga', 5),
('Zabelê', 25), 
('Zortéa', 24), 
('Zé Doca', 10);

CREATE VIEW DADOS_CIDADE AS
SELECT C.codcidade, C.nomecidade, U.siglauf
FROM cidade C, uf U
WHERE C.codsiglauffk = U.coduf;

SELECT * FROM DADOS_CIDADE;
select * from cidade;


create table trabalho (
	codtrabalho int identity primary key,
	nometrabalho varchar(80) not null,
	cargotrabalho varchar(80) not null,
	salariotrabalho numeric (10,2)
);

INSERT INTO trabalho (nometrabalho, cargotrabalho, salariotrabalho) VALUES 
('Desenvolvedor Full Stack', 'Programador', 5000.00),
('Engenheiro Civil', 'Engenheiro', 7000.00),
('Professor', 'Educador', 3000.00),
('Médico', 'Profissional da Saúde', 10000.00),
('Designer Gráfico', 'Designer', 4000.00);


select * from trabalho;

create table cliente (
	codcliente int identity primary key,
	nomecliente varchar (80) not null,
	imagem VARBINARY(MAX),
	datacliente date not null,
	salario numeric(10,2) not null,
	numerocasa int not null,
	codsexofk int not null references sexo(codsexo) on delete cascade on update cascade, 
	codruafk int not null references rua(codrua) on delete cascade on update cascade,
	codbairrofk int not null references bairro(codbairro) on delete cascade on update cascade,
	codcepfk int not null references cep(codcep) on delete cascade on update cascade,
	codcidadefk int not null references cidade(codcidade) on delete cascade on update cascade,
	codtrabalhofk int not null references trabalho(codtrabalho) on delete cascade on update cascade
);

INSERT INTO cliente (nomecliente, imagem, datacliente, salario, numerocasa, codsexofk, codruafk, codbairrofk, codcepfk, codcidadefk, codtrabalhofk) VALUES 
('João Silva', null, '1990-05-15', 3500.00, 123, 1, 1, 1, 1, 1, 1),
('Maria Santos', null, '1985-10-20', 4000.00, 456, 2, 2, 2, 2, 2, 2),
('José Oliveira', null, '1978-03-07', 2800.00, 789, 1, 3, 3, 3, 3, 3),
('Ana Pereira', null, '1995-12-10', 4500.00, 1011, 2, 4, 4, 4, 4, 4),
('Carlos Santos', null, '1982-08-25', 3200.00, 1213, 1, 5, 5, 5, 5, 5);

CREATE VIEW DADOS_CLIENTES AS
SELECT C.codcliente, C.nomecliente, C.imagem, C.datacliente, C.salario, C.numerocasa, S.nomesexo, R.nomerua, B.nomebairro, CE.numerocep, CI.nomecidade, TR.nometrabalho
FROM cliente C, sexo S, rua R, bairro B, cep CE, cidade CI, trabalho TR
WHERE C.codsexofk = S.codsexo AND C.codruafk = R.codrua AND C.codbairrofk = B.codbairro
AND C.codcepfk = CE.codcep AND C.codcidadefk = CI.codcidade AND C.codtrabalhofk = TR.codtrabalho;

SELECT * FROM DADOS_CLIENTES;
select * from cliente;

create table operadora(
	codopera int identity primary key,
	nomeopera varchar(20) not null,
	nomeplano varchar(20) not null
);

INSERT INTO operadora (nomeopera, nomeplano) VALUES 
('Vivo', 'Plano Gold'),
('Claro', 'Plano Premium'),
('TIM', 'Plano Família'),
('Oi', 'Plano Pré-Pago'),
('Nextel', 'Plano Corporativo');


select * from operadora;

create table telefone (
	codtelefone int identity primary key,
	numerotelefone varchar(11) not null,
	codoperafk int references operadora (codopera) on delete cascade on update cascade
);

INSERT INTO telefone (numerotelefone, codoperafk) VALUES 
('11987654321', 1),
('21987654321', 2),
('31987654321', 3),
('41987654321', 4),
('51987654321', 5);

CREATE VIEW DADOS_TELEFONE AS
SELECT T.codtelefone, T.numerotelefone, O.nomeopera
FROM telefone T, operadora O
WHERE T.codoperafk = O.codopera;

SELECT * FROM DADOS_TELEFONE;
select * from telefone;

create table itenstelefonecliente (
	codtelefonefk int references telefone (codtelefone) on delete cascade on update cascade,
	codclientefk int references cliente (codcliente) on delete cascade on update cascade,
	primary key(codtelefonefk,codclientefk)
);

INSERT INTO itenstelefonecliente (codtelefonefk, codclientefk) VALUES 
(1, 1),
(2, 2),
(3, 3),
(4, 4),
(5, 5);

CREATE VIEW DADOS_TELEFONECLIENTE AS
SELECT T.numerotelefone, C.nomecliente
FROM itenstelefonecliente I, telefone T, cliente C
WHERE I.codtelefonefk = T.codtelefone AND I.codclientefk = C.codcliente;

select * from DADOS_TELEFONECLIENTE;
select * from itenstelefonecliente;

create table itenstelefonetrabalho(
	codtrabalhofk int references trabalho (codtrabalho) on delete cascade on update cascade,
	codtelefonefk int references telefone (codtelefone) on delete cascade on update cascade,
	primary key(codtrabalhofk,codtelefonefk)
);

INSERT INTO itenstelefonetrabalho (codtrabalhofk, codtelefonefk) VALUES 
(1, 1),
(2, 2),
(3, 3),
(4, 4),
(5, 5);

CREATE VIEW DADOS_TELEFONETRABALHO AS
SELECT T.numerotelefone, TR.nometrabalho
FROM itenstelefonetrabalho I, telefone T, trabalho TR
WHERE I.codtelefonefk = T.codtelefone AND I.codtrabalhofk = TR.codtrabalho;

select * from DADOS_TELEFONETRABALHO;
select * from itenstelefonetrabalho;

create table funcao(
	codfuncao int identity primary key,
	nomefuncao varchar(80) not null,
	itensfuncao varchar (50) not null
);

INSERT INTO funcao (nomefuncao, itensfuncao) VALUES 
('Desenvolvedor', 'Desenvolvimento de Software'),
('Engenheiro Civil', 'Projeto e Construção de Obras Civis'),
('Professor', 'Educação e Ensino'),
('Médico', 'Assistência Médica'),
('Designer Gráfico', 'Criação de Elementos Visuais');


select * from funcao;

create table loja(
	codloja int identity primary key,
	nomeloja varchar(80) not null,
	cnpjloja char(9) not null unique,
	nomefantasia varchar(80) not null,
	razaosocial varchar(80) not null unique
);

INSERT INTO loja (nomeloja, cnpjloja, nomefantasia, razaosocial) VALUES 
('Loja A', '123456789', 'A Super Loja', 'Empresa A Ltda'),
('Loja B', '987654321', 'Bem Barato', 'Empresa B S.A.'),
('Loja C', '234567890', 'Casa dos Eletrônicos', 'Empresa C & Cia'),
('Loja D', '876543219', 'Divina Moda', 'Empresa D EIRELI'),
('Loja E', '345678901', 'EletroMais', 'Empresa E Ltda');


select * from loja;

create table funcionarios(
	codfuncionarios int identity primary key,
	nomefuncionarios varchar(80) not null,
	numerocasa int not null,
	codruafk int references rua (codrua) on delete cascade on update cascade,
	codbairrofk int references bairro (codbairro) on delete cascade on update cascade,
	codcepfk int references cep (codcep) on delete cascade on update cascade,
	codcidadefk int references cidade (codcidade) on delete cascade on update cascade,
	codfuncaofk int references funcao(codfuncao) on delete cascade on update cascade,
	salario numeric (10,2) not null,
	codlojafk int references loja(codloja) on delete cascade on update cascade
);

INSERT INTO funcionarios (nomefuncionarios, numerocasa, codruafk, codbairrofk, codcepfk, codcidadefk, codfuncaofk, salario, codlojafk) VALUES 
('Fulano Silva', 101, 1, 1, 1, 1, 1, 5000.00, 1),
('Ciclano Souza', 202, 2, 2, 2, 2, 2, 6000.00, 2),
('Beltrano Santos', 303, 3, 3, 3, 3, 3, 4000.00, 3),
('Maria Oliveira', 404, 4, 4, 4, 4, 4, 5500.00, 4),
('João Pereira', 505, 5, 5, 5, 5, 5, 4500.00, 5);

CREATE VIEW DADOS_FUNCIONARIOS AS
SELECT F.codfuncionarios, F.nomefuncionarios, F.numerocasa, R.nomerua, B.nomebairro, CE.numerocep, CI.nomecidade, FU.nomefuncao, F.salario, L.nomeloja
FROM funcionarios F, rua R, bairro B, cep CE, cidade CI, funcao FU, loja L
WHERE F.codruafk = R.codrua AND F.codbairrofk = B.codbairro
AND F.codcepfk = CE.codcep AND F.codcidadefk = CI.codcidade 
AND F.codfuncaofk = FU.codfuncao AND F.codlojafk = L.codloja;

select * from DADOS_FUNCIONARIOS;
select * from funcionarios;

create table itenstelefonefuncionario(
	codtelefonefk int references telefone(codtelefone) on delete cascade on update cascade,
	codfuncionariosfk int references funcionarios (codfuncionarios) on delete cascade on update cascade
	primary key(codtelefonefk,codfuncionariosfk)
);

INSERT INTO itenstelefonefuncionario (codtelefonefk, codfuncionariosfk) VALUES 
(1, 1),
(2, 2),
(3, 3),
(4, 4),
(5, 5);

CREATE VIEW DADOS_TELEFONEFUNCIONARIO AS
SELECT T.numerotelefone, F.nomefuncionarios
FROM itenstelefonefuncionario I, telefone T, funcionarios F
WHERE I.codtelefonefk = T.codtelefone AND I.codfuncionariosfk = F.codfuncionarios;

select * from DADOS_TELEFONEFUNCIONARIO;
select * from itenstelefonefuncionario;

create table logins(
	codlogin int identity primary key,
	nomeusuario varchar(80) not null,
	senhalogin int not null,
	codfuncionariosfk int references funcionarios (codfuncionarios) on delete cascade on update cascade
);

INSERT INTO logins (nomeusuario, senhalogin, codfuncionariosfk) VALUES 
('gerente', 1111, 1),
('admin', 123, 2),
('vendedor', 3333, 3),
('funcionario', 4444, 4),
('user', 5555, 5);

--DELETE from logins WHERE codlogin=5;

CREATE VIEW DADOS_LOGINS AS
SELECT C.codlogin , C.nomeusuario, C.senhalogin, F.nomefuncionarios
FROM logins C, funcionarios F
WHERE C.codfuncionariosfk = F.codfuncionarios;

select * from DADOS_LOGINS;
select * from logins;

create table controlelogsistema(
	codcontrole int identity primary key,
	codloginfk int references logins(codlogin) on delete cascade on update cascade,
	datacontrole date not null,
	horacontrole time not null
);

INSERT INTO controlelogsistema (codloginfk, datacontrole, horacontrole) VALUES 
(1, '2024-06-01', '09:00:00'),
(2, '2024-06-01', '09:15:00'),
(3, '2024-06-01', '09:30:00'),
(4, '2024-06-01', '09:45:00'),
(5, '2024-06-01', '10:00:00');

CREATE VIEW DADOS_CONTROLELOGSISTEMA AS
SELECT C.codcontrole, L.nomeusuario, C.datacontrole, C.horacontrole
FROM controlelogsistema C , logins L
WHERE C.codloginfk = L.codlogin;

select * from DADOS_CONTROLELOGSISTEMA;
select * from controlelogsistema;

create table acesso(
	codacesso int identity primary key,
	nomeacesso varchar(80) not null
);

INSERT INTO acesso (nomeacesso) VALUES 
('GERENTE'),
('ADMINISTRADOR'),
('VENDEDOR'),
('FUNCIONARIO'),
('CLIENTE');


select * from acesso;


create table itensacessologin(
	codacessofk int references acesso (codacesso) on delete cascade on update cascade,
	codloginfk int references logins (codlogin) on delete cascade on update cascade,
	primary key (codacessofk,codloginfk)
);

INSERT INTO itensacessologin (codacessofk, codloginfk) VALUES 
(1, 1),
(2, 2),
(3, 3),
(4, 4),
(5, 5)

CREATE VIEW DADOS_ITENSACESSOLOGIN AS
SELECT A.nomeacesso, L.nomeusuario
FROM itensacessologin I, acesso A, logins L
WHERE I.codacessofk = A.codacesso AND I.codloginfk = L.codlogin;

select * from DADOS_ITENSACESSOLOGIN;
select * from itensacessologin;


create table itenstelefoneloja(
	codtelefonefk int references telefone (codtelefone) on delete cascade on update cascade,
	codlojafk int references loja (codloja) on delete cascade on update cascade,
	primary key (codtelefonefk, codlojafk)
);

INSERT INTO itenstelefoneloja (codtelefonefk, codlojafk) VALUES 
(1, 1),
(2, 2),
(3, 3),
(4, 4),
(5, 5);

CREATE VIEW DADOS_ITENSTELEFONELOJA AS
SELECT T.numerotelefone, L.nomeloja
FROM itenstelefoneloja I, telefone T, loja L
WHERE I.codtelefonefk = T.codtelefone AND I.codlojafk = L.codloja;

select * from DADOS_ITENSTELEFONELOJA;
select * from itenstelefoneloja;

create table marca(
	codmarca int identity primary key,
	nomemarca varchar(50) not null unique
);

INSERT INTO marca (nomemarca) VALUES 
('Marca A'),
('Marca B'),
('Marca C'),
('Marca D'),
('Marca E');


select * from marca;

create table tipo (
	codtipo int identity primary key,
	nometipo varchar(50) not null
);

INSERT INTO tipo (nometipo) VALUES 
('Tipo A'),
('Tipo B'),
('Tipo C'),
('Tipo D'),
('Tipo E');


select * from tipo;

create table produto(
	codproduto int identity primary key,
	nomeproduto varchar(50) not null unique,
	quantidadeproduto int not null,
	valorproduto numeric(10,2) not null,
	codmarcafk int references marca (codmarca) on delete cascade on update cascade,
	codtipofk int references tipo (codtipo) on delete cascade on update cascade
);

INSERT INTO produto (nomeproduto, quantidadeproduto, valorproduto, codmarcafk, codtipofk) VALUES 
('Produto A', 100, 50.00, 1, 1),
('Produto B', 150, 75.00, 2, 2),
('Produto C', 200, 100.00, 3, 3),
('Produto D', 120, 80.00, 4, 4),
('Produto E', 80, 120.00, 5, 5);

CREATE VIEW DADOS_PRODUTO AS
SELECT P.codproduto, P.nomeproduto, P.quantidadeproduto, P.valorproduto, M.nomemarca, T.nometipo
FROM  produto P, marca M, tipo T
WHERE P.codmarcafk = M.codmarca AND P.codtipofk = T.codtipo;

select * from DADOS_PRODUTO;
select * from produto;


create table fornecedor(
	codfornecedor int identity primary key,
	nomefornecedor varchar(80) not null,
	numerocasa int not null,
	codruafk int references rua (codrua) on delete cascade on update cascade,
	codbairrofk int references bairro (codbairro) on delete cascade on update cascade,
	codcepfk int references cep (codcep) on delete cascade on update cascade,
	codcidadefk int references cidade (codcidade) on delete cascade on update cascade
);

INSERT INTO fornecedor (nomefornecedor, numerocasa, codruafk, codbairrofk, codcepfk, codcidadefk) VALUES 
('Fornecedor 1', 123, 1, 1, 1, 1),
('Fornecedor 2', 456, 2, 2, 2, 2),
('Fornecedor 3', 789, 3, 3, 3, 3),
('Fornecedor 4', 1011, 4, 4, 4, 4),
('Fornecedor 5', 1213, 5, 5, 5, 5);

CREATE VIEW DADOS_FORNECEDOR AS
SELECT F.codfornecedor, F.nomefornecedor, F.numerocasa, R.nomerua, B.nomebairro, CE.numerocep, CI.nomecidade
FROM fornecedor F, rua R, bairro B, cep CE, cidade CI
WHERE F.codruafk = R.codrua AND F.codbairrofk = B.codbairro
AND F.codcepfk = CE.codcep AND F.codcidadefk = CI.codcidade 

select * from DADOS_FORNECEDOR;
select * from fornecedor;


create table ITENSTELEFONEFORNECEDOR(
	codtelefonefk int references telefone (codtelefone) on delete cascade on update cascade,
	codfornecedorfk int references fornecedor (codfornecedor) on delete cascade on update cascade,
	primary key (codtelefonefk, codfornecedorfk)
);

INSERT INTO ITENSTELEFONEFORNECEDOR (codtelefonefk, codfornecedorfk) VALUES 
(1, 1),
(2, 2),
(3, 3),
(4, 4),
(5, 5);

CREATE VIEW DADOS_ITENSTELEFONEFORNECEDOR AS
SELECT T.numerotelefone, F.nomefornecedor
FROM ITENSTELEFONEFORNECEDOR I, telefone T, fornecedor F
WHERE I.codtelefonefk = T.codtelefone AND I.codfornecedorfk = F.codfornecedor;

select * from DADOS_ITENSTELEFONEFORNECEDOR;
select * from ITENSTELEFONEFORNECEDOR;

create table COMPRAPRODUTO(
	codcompra int identity primary key,
	datacompra date not null,
	codfornecedorfk int references fornecedor (codfornecedor) on delete cascade on update cascade,
	codfuncionariosfk int references funcionarios (codfuncionarios)
);

INSERT INTO COMPRAPRODUTO (datacompra, codfornecedorfk, codfuncionariosfk) VALUES 
('2024-06-01', 1, 1),
('2024-06-02', 2, 2),
('2024-06-03', 3, 3),
('2024-06-04', 4, 4),
('2024-06-05', 5, 5);

CREATE VIEW DADOS_COMPRAPRODUTO AS
SELECT C.codcompra, C.datacompra, FO.nomefornecedor, FU.nomefuncionarios
FROM COMPRAPRODUTO C, fornecedor FO, funcionarios FU
WHERE C.codfornecedorfk = FO.codfornecedor AND C.codfuncionariosfk = FU.codfuncionarios;

select * from DADOS_COMPRAPRODUTO;
select * from COMPRAPRODUTO;


CREATE TABLE itenscompraproduto (
    codcomprafk INT references COMPRAPRODUTO (codcompra) on delete cascade on update cascade,
    codprodutofk INT references produto (codproduto) on delete cascade on update cascade,
    quantidadeproduto INT not null,
    valorRC numeric (10,2) not null,
    PRIMARY KEY (codcomprafk, codprodutofk)
);

INSERT INTO itenscompraproduto (codcomprafk, codprodutofk, quantidadeproduto, valorRC) VALUES 
(1, 1, 10, 500.00),
(2, 2, 20, 1500.00),
(3, 3, 30, 3000.00),
(4, 4, 15, 1200.00),
(5, 5, 25, 3000.00);

CREATE VIEW DADOS_ITENSCOMPRAPRODUTO AS
SELECT C.datacompra, P.nomeproduto, I.quantidadeproduto, I.valorRC
FROM itenscompraproduto I, COMPRAPRODUTO C, produto P
WHERE I.codcomprafk = C.codcompra AND I.codprodutofk = P.codproduto;

select * from DADOS_ITENSCOMPRAPRODUTO;
select * from itenscompraproduto;

create table situacao(
	codsituacao int identity primary key,
	nomesituacao varchar(80) not null
);

INSERT INTO situacao (nomesituacao) VALUES 
('Em andamento'),
('Aguardando pagamento'),
('Pago'),
('Cancelado'),
('Entregue');


select * from situacao;

create table PARCELACOMPRA(
	codparcelacompra int identity primary key,
	datavencimento date not null,
	valor numeric(10,2) not null,
	codsituacaofk int references situacao (codsituacao) on delete cascade on update cascade,
	codcomprafk int references COMPRAPRODUTO (codcompra) on delete cascade on update cascade
);

INSERT INTO PARCELACOMPRA (datavencimento, valor, codsituacaofk, codcomprafk) VALUES 
('2024-06-10', 1000.00, 1, 1),
('2024-06-15', 2000.00, 2, 2),
('2024-06-20', 2500.00, 3, 3),
('2024-06-25', 1500.00, 4, 4),
('2024-06-30', 1800.00, 5, 5);

CREATE VIEW DADOS_PARCELACOMPRA AS
SELECT P.codparcelacompra, P.datavencimento, P.valor, S.nomesituacao, C.datacompra
FROM PARCELACOMPRA P, situacao S, COMPRAPRODUTO C
WHERE P.codsituacaofk = S.codsituacao AND P.codcomprafk = C.codcompra;

select * from DADOS_PARCELACOMPRA;
select * from PARCELACOMPRA;

create table VENDAPRODUTO(
	codvenda int identity primary key,
	datavenda date not null,
	codclientefk int references cliente(codcliente) on delete cascade on update cascade,
	codfuncionariosfk int references funcionarios (codfuncionarios)
);

INSERT INTO VENDAPRODUTO (datavenda, codclientefk, codfuncionariosfk) VALUES 
('2024-06-01', 1, 1),
('2024-06-02', 2, 2),
('2024-06-03', 3, 3),
('2024-06-04', 4, 4),
('2024-06-05', 5, 5);

CREATE VIEW DADOS_VENDAPRODUTO AS
SELECT P.codvenda, P.datavenda, C.nomecliente, F.nomefuncionarios
FROM VENDAPRODUTO P, cliente C, funcionarios F
WHERE P.codclientefk = C.codcliente AND P.codfuncionariosfk = F.codfuncionarios;

select * from DADOS_VENDAPRODUTO;
select * from VENDAPRODUTO;

create table ITENSVENDAPRODUTO(
	codvendafk int references vendaproduto(codvenda) on delete cascade on update cascade,
	codprodutofk int references produto (codproduto) on delete cascade on update cascade,
	quantidade int not null,
	valor numeric (10,2) not null,
	primary key (codvendafk,codprodutofk)
);

INSERT INTO ITENSVENDAPRODUTO (codvendafk, codprodutofk, quantidade, valor) VALUES 
(1, 1, 25, 500.00),
(2, 2, 10, 1500.00),
(3, 3, 5, 3000.00),
(4, 4, 15, 1200.00),
(5, 5, 12, 3000.00);

CREATE VIEW DADOS_ITENSVENDAPRODUTO AS
SELECT V.datavenda, P.nomeproduto, I.quantidade, I.valor
FROM ITENSVENDAPRODUTO I, VENDAPRODUTO V, produto P
WHERE I.codvendafk = V.codvenda AND I.codprodutofk = P.codproduto;

select * from DADOS_ITENSVENDAPRODUTO;
select * from ITENSVENDAPRODUTO;

create table PARCELAVENDA(
	codparcela int identity primary key,
	datavencimento date not null,
	valorparcela numeric (10,2) not null,
	codsituacaofk int references situacao (codsituacao) on delete cascade on update cascade,
	codvendafk int references VENDAPRODUTO (codvenda) on delete cascade on update cascade
);

INSERT INTO PARCELAVENDA (datavencimento, valorparcela, codsituacaofk, codvendafk) VALUES 
('2024-06-10', 1000.00, 1, 1),
('2024-06-15', 2000.00, 2, 2),
('2024-06-20', 2500.00, 3, 3),
('2024-06-25', 1500.00, 4, 4),
('2024-06-30', 1800.00, 5, 5);

CREATE VIEW DADOS_PARCELAVENDA AS
SELECT P.codparcela, P.datavencimento, P.valorparcela, S.nomesituacao, V.datavenda
FROM PARCELAVENDA P, situacao S, VENDAPRODUTO V
WHERE P.codsituacaofk = S.codsituacao AND P.codvendafk = V.codvenda;

select * from DADOS_PARCELAVENDA;
select * from PARCELAVENDA;

create table IMAGENS(
	codimagens int identity primary key,
	imagem VARBINARY(MAX),
	descricao varchar(80) not null,
	codprodutofk int references produto (codproduto) on delete cascade on update cascade
);

CREATE VIEW DADOS_IMAGENS AS
SELECT I.codimagens, I.imagem, I.descricao, P.nomeproduto
FROM IMAGENS I, produto P
WHERE I.codprodutofk = P.codproduto

select * from DADOS_IMAGENS;
select * from IMAGENS;
