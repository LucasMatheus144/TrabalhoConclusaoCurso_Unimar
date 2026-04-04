# 📚 Sistema de Gestão de Professores

## 🎓 Trabalho de Conclusão de Curso (TCC)

---

## 📌 Descrição do Projeto

Este projeto tem como objetivo o desenvolvimento de uma API REST utilizando .NET Core integrada ao Firebase Firestore para gerenciamento de professores.

A aplicação permite realizar operações completas (CRUD), além de consultas avançadas utilizando os recursos do Firestore.

---

## 🎯 Objetivo

- Desenvolver uma API RESTful
- Integrar com Firebase Firestore
- Aplicar boas práticas de desenvolvimento backend
- Implementar consultas otimizadas no banco NoSQL

---

## 🔥 Firebase

### 📌 Configuração

O aluno deverá:

- Criar um projeto no Firebase
- Ativar o **Cloud Firestore**
- Criar uma coleção chamada:



---

### 📄 Estrutura dos Documentos

Cada documento da coleção deve conter:

| Campo          | Tipo      | Descrição                          |
|----------------|----------|----------------------------------|
| id             | string   | Identificador do professor        |
| nome           | string   | Nome completo                     |
| disciplina     | string   | Área de atuação                   |
| email          | string   | Email institucional               |
| ativo          | boolean  | Status do professor               |
| dataCadastro   | timestamp| Data de criação (automática)      |

---

## 🛠️ Backend - API .NET Core

### 📌 Endpoints Obrigatórios

| Método | Endpoint                 | Descrição                |
|--------|--------------------------|--------------------------|
| POST   | /api/professor           | Criar professor          |
| GET    | /api/professor           | Listar professores       |
| GET    | /api/professor/{id}      | Buscar por ID            |
| PUT    | /api/professor/{id}      | Atualizar professor      |
| DELETE | /api/professor/{id}      | Remover professor        |

---

## 🔎 Consultas (Queries) Obrigatórias

A API deve implementar consultas utilizando o Firestore:

- Buscar professores ativos
- Filtrar por disciplina
- Ordenar por nome
- Limitar quantidade de resultados
- Consulta combinada (ex: ativos + ordenado)

---

### 📌 Exemplos de Queries

#### 🔹 Buscar professores ativos


---

#### 🔹 Filtros

