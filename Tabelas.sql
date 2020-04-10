CREATE TABLE RM{SEU_RM}.ALUNO (
	ID VARCHAR2(100) NOT NULL,
	TURMAID VARCHAR2(100),
	NOME VARCHAR2(100) NOT NULL,
	ENDERECOID VARCHAR2(100) NOT NULL,
	TELEFONEID VARCHAR2(100) NOT NULL,
	EMAIL VARCHAR2(100),
	DTNASCIMENTO DATE NOT NULL,
	CONSTRAINT ALUNO_PK PRIMARY KEY (ID)
);

CREATE TABLE RM{SEU_RM}.TURMA (
	ID VARCHAR2(100) NOT NULL,
	SERIE INTEGER NOT NULL,
	ANO INTEGER NOT NULL,
	CONSTRAINT TURMA_PK PRIMARY KEY (ID)
);

CREATE TABLE RM{SEU_RM}.PROFESSOR (
	ID VARCHAR2(100) NOT NULL,
	NOME VARCHAR2(100) NOT NULL,
	EMAIL VARCHAR2(100),
	DTNASCIMENTO DATE NOT NULL,
	CONSTRAINT PROFESSOR_PK PRIMARY KEY (ID)
);
