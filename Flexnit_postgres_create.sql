DROP TABLE IF EXISTS "filmes" CASCADE;
DROP TABLE IF EXISTS "cliente" CASCADE;
DROP TABLE IF EXISTS "genero" CASCADE;
DROP TABLE IF EXISTS "filmes_assistidos" CASCADE;
DROP TABLE IF EXISTS "admin" CASCADE;

CREATE TABLE "filmes" (
	"id_filme" SERIAL NOT NULL,
	"titulo_filme" varchar(30) NOT NULL,
	"descricao_filme" varchar(255) NOT NULL,
	"ano_filme" integer NOT NULL,
	"id_genero" integer NOT NULL,
	CONSTRAINT "filmes_pk" PRIMARY KEY ("id_filme")
);
CREATE TABLE "genero" (
	"id_genero" SERIAL NOT NULL,
	"nome_gen" varchar(100) NOT NULL,
	CONSTRAINT "gênero_pk" PRIMARY KEY ("id_genero")


);
CREATE TABLE "cliente" (
	"id_cliente" SERIAL NOT NULL UNIQUE,
	"nome_cliente" varchar(100) NOT NULL,
	"email_cliente" varchar(150) NOT NULL UNIQUE,
	"username_cliente" varchar(100) NOT NULL UNIQUE,
	"estado_cliente" varchar(50) NOT NULL,
	"senha_cliente" varchar(200) NOT NULL,
	"excluido" BOOLEAN NOT NULL DEFAULT 'false',
	CONSTRAINT "cliente_pk" PRIMARY KEY ("id_cliente")
);
CREATE TABLE "admin"(
	"id_admin" SERIAL NOT NULL UNIQUE,
	"nome_admin" CHARACTER VARYING(100) NOT NULL,
	"user_admin" CHARACTER VARYING(100)NOT NULL UNIQUE,
	"email_admin" CHARACTER VARYING(100) NOT NULL UNIQUE,
	"senha_admin" CHARACTER VARYING(100)NOT NULL,
	CONSTRAINT "admin_pk" PRIMARY KEY ("id_admin")
	
);
CREATE TABLE "filmes_assistidos" (
	"id_assistido" SERIAL NOT NULL,
	"id_cliente" INTEGER NOT NULL,
	"id_filme" INTEGER NOT NULL,
	CONSTRAINT "filmes_assistidos_pk" PRIMARY KEY ("id_assistido")
);
ALTER TABLE "filmes" ADD CONSTRAINT "filmes_fk0" FOREIGN KEY ("id_genero") REFERENCES "genero"("id_genero");



ALTER TABLE "filmes_assistidos" ADD CONSTRAINT "filmes_assistidos_fk0" FOREIGN KEY ("id_cliente") REFERENCES "cliente"("id_cliente");
ALTER TABLE "filmes_assistidos" ADD CONSTRAINT "filmes_assistidos_fk1" FOREIGN KEY ("id_filme") REFERENCES "filmes"("id_filme");
