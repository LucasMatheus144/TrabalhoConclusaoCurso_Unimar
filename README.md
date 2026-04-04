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
<img width="1071" height="633" alt="image" src="https://github.com/user-attachments/assets/c48ecc5d-8eb5-46cb-85ed-f522b0ed86e8" />

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

<img width="1555" height="683" alt="image" src="https://github.com/user-attachments/assets/447d03cb-cbfb-4804-85b2-3bad00564837" />
<img width="1594" height="758" alt="image" src="https://github.com/user-attachments/assets/ab6db7e4-6b35-4bd2-815d-6eb8b329e7f7" />

---

## 🛠️ Backend - API .NET Core

### 📌 Endpoints Obrigatórios

| Método | Endpoint                 | Descrição                |
|--------|--------------------------|--------------------------|
| POST   | /api/professor           | Criar professor          |
| GET    | /api/professor           | Listar professores       |
| GET    | /api/professor/{id}      | Buscar por ID            |
| PUT    | /api/professor/          | Atualizar professor      |
| DELETE | /api/professor/{id}      | Remover professor        |
<img width="1898" height="980" alt="image" src="https://github.com/user-attachments/assets/d03fcd79-a0c0-4776-821d-5704cc02cb48" />

---

## 🔎 Consultas (Queries) Obrigatórias

A API deve implementar consultas utilizando o Firestore:

- Buscar professores ativos
- Filtrar por disciplina
- Ordenar por nome
- Limitar quantidade de resultados
- Consulta combinada (ex: ativos + ordenado)
<img width="784" height="197" alt="image" src="https://github.com/user-attachments/assets/523d4b0c-4494-4193-9138-08249cf4bb1f" />


---

### 📌 Exemplos de Request

--Post
<img width="1071" height="937" alt="image" src="https://github.com/user-attachments/assets/635bcefc-43fd-45a6-8188-99e8f99d7b1f" />


--Gets
<img width="1108" height="896" alt="image" src="https://github.com/user-attachments/assets/192761f4-1d17-4f9c-8be6-4cc43b417f2c" />
<img width="1060" height="884" alt="image" src="https://github.com/user-attachments/assets/9336daf8-12ab-4181-9709-bffddd7d6060" />
<img width="1111" height="904" alt="image" src="https://github.com/user-attachments/assets/48114a50-573b-40d6-82de-102eebccc30b" />
<img width="1075" height="753" alt="image" src="https://github.com/user-attachments/assets/3e66fb12-8d92-45ea-b38a-de49ed3775ea" />

--Put
<img width="1066" height="946" alt="image" src="https://github.com/user-attachments/assets/edcf8d5c-23f8-40df-8157-4c39027bbc80" />

--Delete
Antes
<img width="1565" height="680" alt="image" src="https://github.com/user-attachments/assets/90cc80fb-dbdc-4db6-b094-e94896321b64" />
depois
<img width="1072" height="720" alt="image" src="https://github.com/user-attachments/assets/1f6f55de-3ac0-45cd-ac88-5306facc3a36" />
<img width="1625" height="720" alt="image" src="https://github.com/user-attachments/assets/52b1eb23-9c8d-41aa-9238-a4baa7715d3b" />

## 🧾 7. CONCLUSÃO

O desenvolvimento deste projeto proporcionou a aplicação prática de conceitos fundamentais de construção de APIs, integração com serviços externos e utilização de banco de dados NoSQL.

### 📚 Conhecimentos adquiridos

---

### ⚠️ Dificuldades encontradas e soluções aplicadas

Uma das principais dificuldades encontradas foi a integração com o banco de dados NoSQL, especialmente por se tratar de um paradigma diferente dos bancos relacionais tradicionais(sofri bastante).

Outro ponto relevante foi a adaptação ao comportamento do Firestore, como o fato de não ser case sensitive em determinadas operações, o que exigiu atenção no padrão de escrita e consultas.

---

### 🚀 Benefícios do uso de banco NoSQL

- Flexibilidade na estrutura dos dados
- Ausência de necessidade de mapeamento rígido entre entidade e banco
- Possibilidade de adicionar ou alterar campos dinamicamente

---

### ⚖️ Diferenças entre banco relacional e Firestore

Durante o desenvolvimento, foi possível observar diferenças importantes:

| Banco Relacional        | Firestore (NoSQL)            |
|-------------------------|-----------------------------|
| Estrutura rígida        | Estrutura flexível          |
| Uso de tabelas          | Uso de coleções/documentos  |
| Necessita migrations    | Não necessita migrations    |
| Relacionamentos (JOIN)  | Dados geralmente desnormalizados |
| Tipagem forte           | Estrutura dinâmica          |

---

### 🔮 Possíveis melhorias futuras

O sistema pode ser evoluído com as seguintes melhorias:

- Criação de logs estruturados
- Implementação de testes automatizados
- Melhor organização das queries no Firestore
