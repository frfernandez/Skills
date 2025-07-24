CREATE DATABASE "Rodonaves"
    WITH
    OWNER = postgres
    ENCODING = 'UTF8'
    LOCALE_PROVIDER = 'libc'
    CONNECTION LIMIT = -1
    IS_TEMPLATE = False;

--------------------------------------------------

CREATE TABLE public."Unidades"
(
    "Codigo" integer NOT NULL GENERATED ALWAYS AS IDENTITY ( INCREMENT 1 START 1 ),
    "Nome" character varying(50) NOT NULL,
    CONSTRAINT "PK_Unidades_Codigo" PRIMARY KEY ("Codigo")
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public."Unidades"
    OWNER to postgres;

--------------------------------------------------

CREATE TABLE public."Logins"
(
    "Codigo" integer NOT NULL GENERATED ALWAYS AS IDENTITY ( INCREMENT 1 START 1 ),
    "Login" character varying(50) NOT NULL,
    "Senha" character varying(50) NOT NULL,
    "Status" character varying(1) NOT NULL,
    CONSTRAINT "PK_Logins_Codigo" PRIMARY KEY ("Codigo")
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public."Logins"
    OWNER to postgres;

--------------------------------------------------

CREATE TABLE public."Colaboradores"
(
    "Codigo" integer NOT NULL GENERATED ALWAYS AS IDENTITY ( INCREMENT 1 START 1 ),
    "Nome" character varying(50) NOT NULL,
    "CodigoLogin" integer NOT NULL,
    "CodigoUnidade" integer NOT NULL,
    CONSTRAINT "PK_Colaboradores_Codigo" PRIMARY KEY ("Codigo"),
    CONSTRAINT "FK_Colaboradores_Logins" FOREIGN KEY ("CodigoLogin")
        REFERENCES public."Logins" ("Codigo") MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
        NOT VALID,
    CONSTRAINT "FK_Colaboradores_Unidades" FOREIGN KEY ("CodigoUnidade")
        REFERENCES public."Unidades" ("Codigo") MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
        NOT VALID
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public."Colaboradores"
    OWNER to postgres;

--------------------------------------------------
