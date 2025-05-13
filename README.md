# 🎬 MovieCatalog - Catálogo de Filmes com ASP.NET

Projeto desenvolvido com **.NET** que implementa um catálogo de filmes com interface inspirada na **Netflix**. O sistema permite ao usuário visualizar, pesquisar, adicionar, editar e excluir filmes de forma intuitiva e responsiva.

---

## 📋 Visão Geral

Este projeto é uma aplicação web simples e modular, ideal para estudos de arquitetura MVC, CRUD e estilização com Bootstrap. Foi criado como parte de um exemplo prático de uso do framework .NET e pode servir como base para sistemas mais complexos com integração a banco de dados e autenticação futuramente.

---

## 🧩 Funcionalidades

- 📺 **Visualização do catálogo de filmes**
- 🔍 **Pesquisa por nome, diretor ou gênero**
- 📄 **Exibição de detalhes completos de cada filme**
- ➕ **Cadastro de novos filmes**
- ✏️ **Edição de filmes existentes**
- ❌ **Remoção de filmes do catálogo**

---

## 📁 Estrutura do Projeto

O projeto segue a estrutura padrão do **MVC (Model-View-Controller)** do ASP.NET:

### 📂 `Controllers`
- `MovieController.cs`: Controlador responsável pelas operações de CRUD dos filmes.

### 📂 `Models`
- `Movie.cs`: Modelo que representa a entidade "filme".
- `Genre.cs`: Enumeração contendo os gêneros disponíveis.

### 📂 `Views/Movie`
- `Index.cshtml`: Página inicial com catálogo de filmes e barra de pesquisa.
- `Details.cshtml`: Exibe os detalhes completos de um filme.
- `Add.cshtml`: Formulário para cadastro de novo filme.
- `Edit.cshtml`: Formulário para edição de filmes existentes.

---

## 🎨 Estilo Visual

- Tema escuro inspirado na interface da Netflix
- Cards organizados em carrossel interativo
- Botões e campos com cantos arredondados
- Efeito de zoom nas imagens ao passar o mouse
- Layout responsivo e adaptável a diferentes dispositivos

---

## 👁️ Telas do Sistema

### 1. Tela Inicial
Catálogo de filmes em formato de carrossel interativo com barra de pesquisa.

### 2. Tela de Cadastro
Formulário para inserir novos filmes com título, gênero, ano, sinopse e imagem.

### 3. Tela de Detalhes / Edição / Exclusão
Informações detalhadas sobre o filme, com opções de editar ou remover.

### 4. Política de Privacidade
Página informativa sobre coleta e uso de dados (ideal para conformidade futura).

---

## ⚙️ Tecnologias Utilizadas

- **C#**
- **ASP.NET MVC**
- **HTML5 / CSS3**
- **Bootstrap**
- **Razor Pages**

---
# 👨‍💻 Integrantes
  - Gabriel Dias Menezes, RM 555019 
  - Hellen Marinho Cordeiro, RM 558841 
  - Heloisa Alves de Mesquita, RM 559145 
  - Júlia Soares Farias dos Santos, RM 554609 
  - Sofia Domingues Gonçalves, RM 554920 

---

## 📦 Como Executar o Projeto

1. Clone o repositório:
   ```bash
   git clone https://github.com/gabrieldiasmenezes/MovieCatalog.git

2. Acesse a pasta do projeto:
   ```bash
   cd MovieCatalog
3. Restaure as dependências:
   ```bash
   dotnet restore
4. Restaure as dependências:
   ```bash
   dotnet run
5. Abra o navegador e acesse:
   ```bash
   http://localhost:5000
  
---

## 📚 Considerações Finais

Este projeto serve como um exemplo de CRUD completo com ASP.NET MVC, com foco na apresentação agradável e usabilidade. A estrutura modular permite fácil extensão com persistência de dados, login de usuários ou até mesmo consumo de APIs externas no futuro.











