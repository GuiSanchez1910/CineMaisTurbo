# 📚 Cine+Turbo

> Sistema para cadastro e gerenciamento de filmes e séries.

## 🧾 Descrição

**Cine+Turbo** é uma aplicação web que simula o controle de um acervo de filmes e séries.  
O sistema permite realizar o cadastro, listagem, edição, exclusão de filmes e séries de forma prática e organizada.

> "Esta API simula o funcionamento de uma plataforma de gerenciamento de biblioteca de filmes e séries, como um acervo pessoal."

---

## 👥 Integrantes da Equipe

- Guilherme Cerqueira Sanchez (33008060)
- Guilherme Krelling (34764763)
- Nicolas Perandré Rapp (39152391)
- Tobias Albieri (34255052)

---

## 🛠️ Tecnologias Utilizadas

- **Linguagem:** C# (.NET 8)
- **Framework:** ASP.NET Core
- **ORM:** Entity Framework Core
- **Banco de Dados:** MySQL
- **Front-end:** HTML, CSS e JavaScript
- **Versionamento:** Git + GitHub

---

## 📷 Video Pitch

- https://www.youtube.com/watch?v=iodfROTlSdo

---

## 💻 Acesso ao MVP

- https://nicolasrapp05.github.io/CineMaisTurboDeploy/front-end/html/home.html

---

## 🚀 Como Executar o Projeto

### Pré-requisitos

- [.NET SDK 8.0+](https://dotnet.microsoft.com/en-us/download)
- [MySQL Server](https://dev.mysql.com/downloads/mysql/)
- Git instalado

---

### Passos

```bash
# 1. Clone o repositório
git clone https://github.com/GuiSanchez1910/CineMaisTurbo.git

# 2. Acesse a pasta do projeto
cd .\CineMaisTurbo\

# 3. Altere a senha do banco de dados, para sua senha local
arquivo "appsettings.json" > password:"sua senha"

# 4. Restaure os pacotes
dotnet restore

# 5. Aplique as migrações
dotnet ef database update

# 6. Execute a API
dotnet run

# 7. Instale a extensão "Live Serer"
Extensões > Live Server

# 8. Entre no arquivo home.html
front-end > html > home.html

# 9. Execute o front-end
Clique em "Go Live" no canto inferior direito
