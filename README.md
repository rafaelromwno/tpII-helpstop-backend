![Logotipo HelpApp](https://github.com/user-attachments/assets/e541bdbb-5840-4a29-8e61-8f97e0c4b78d)

# 🎧 HelpApp

Um sistema intuitivo para gerenciar atendimentos voluntários, projetado com boas práticas de arquitetura de software para garantir escalabilidade e manutenção eficiente.

## 📚 Sobre o Projeto

O **HelpApp** conecta pessoas que precisam de assistência com voluntários dispostos a ajudar. Ele oferece uma plataforma organizada para solicitação e administração de atendimentos, garantindo um fluxo eficiente entre os envolvidos.

---

## 🎯 Qual o Problema a ser Resolvido?

Dificuldades na coordenação de atendimentos voluntários de forma eficiente, garantindo transparência e um histórico organizado.

---

## 👥 Quem Pode Usar?

- **Solicitantes:** Pessoas que necessitam de suporte voluntário para resolver problemas ou atender necessidades específicas.
- **Voluntários:** Indivíduos dispostos a oferecer tempo e habilidades para ajudar os solicitantes.
- **Organizações:** ONGs e instituições sociais que gerenciam e coordenam atendimentos voluntários para beneficiar comunidades.

---

## 🔑 Principais Funcionalidades

- Cadastro de perfis de solicitantes e voluntários.
- Registro e acompanhamento de atendimentos.
- Agenda personalizada para gestão de compromissos.
- Geração de relatórios e histórico de atividades.
- Sistema de autenticação seguro com permissões diferenciadas.
- Notificações automatizadas por e-mail e SMS.
- API REST para integração com outros sistemas.

---

## 🛠️ Stack Tecnológica

- **Linguagem:** C# (.NET Core)
- **Banco de Dados:** SQL Server
- **Infraestrutura:** Azure App Services
- **ORM:** Entity Framework Core
- **Testes:** xUnit / NUnit
- **Versionamento:** Git e GitHub

---

## 🏛️ Arquitetura do Projeto

A solução foi desenvolvida em **.NET Core**, utilizando **SQL Server** para armazenamento de dados e hospedagem via **Azure App Services**. O projeto segue padrões de engenharia como **SOLID**, **Domain-Driven Design (DDD)** e **Clean Architecture**, assegurando um sistema flexível e bem estruturado.

## 🗂 Estrutura de Pastas

Abaixo está a estrutura de pastas do projeto, organizada com base na **Clean Architecture**:

```
HelpApp/
├── HelpApp.API/               # Camada de interface, responsável pela comunicação com o usuário
│   ├── Controllers/           # Controladores que expõem os endpoints da API
│   └── Properties/            # Configurações específicas da API
├── HelpApp.Application/       # Camada de aplicação, contendo os casos de uso e serviços
│   └── Services/              # Serviços auxiliares para os casos de uso
├── HelpApp.Domain/            # Camada de domínio, contendo regras de negócio e abstrações
│   ├── Entities/              # Classes que representam as entidades do sistema
│   ├── Interfaces/            # Interfaces para abstrações de repositórios e serviços
│   └── Validation/            # Validações específicas das entidades
├── HelpApp.Domain.Test/       # Testes unitários relacionados à camada de domínio
├── HelpApp.Infra.Data/        # Camada de infraestrutura, gerencia persistência e dependências externas
│   └── Repositories/          # Implementações de repositórios para acesso ao banco de dados
├── HelpApp.Infra.IoC/         # Configuração de injeção de dependências
```

## 👨🏽‍🏫 Explicação das Camadas de Arquitetura

### **HelpApp.API**

- **Controllers/**: Contém os controladores responsáveis por expor os endpoints da API e gerenciar as requisições HTTP.
- **Properties/**: Contém arquivos de configuração específicos da API, como `launchSettings.json`.

### **HelpApp.Application**

- **Services/**: Implementa os serviços que orquestram os casos de uso, conectando a camada de domínio com a interface.

### **HelpApp.Domain**

- **Entities/**: Define as entidades principais do sistema, representando os objetos do domínio.
- **Interfaces/**: Contém as abstrações para repositórios e serviços, garantindo o desacoplamento entre as camadas.
- **Validation/**: Implementa regras de validação específicas para as entidades.

### **HelpApp.Domain.Test**

- Contém os testes unitários relacionados à camada de domínio, garantindo a integridade das regras de negócio.

### **HelpApp.Infra.Data**

- **Repositories/**: Implementa os repositórios para acesso ao banco de dados, seguindo as abstrações definidas na camada de domínio.

### **HelpApp.Infra.IoC**

- Gerencia a configuração de injeção de dependências, conectando as implementações às abstrações.

## 🖼 Diagrama de Arquitetura

                          +---------------------------------+
                          |             📡 API             |
                          |  (Controllers, Properties)     |
                          +---------------+-----------------+
                                          |
                                          v
                          +---------------+-----------------+
                          |          ⚡ Application         |
                          |    (Services, Use Cases)       |
                          +---------------+-----------------+
                                          |
                                          v
                          +---------------------------------+
                          |             🏛️ Domain          |
                          |  (Entities, Interfaces,         |
                          |   Validation - Business Rules)  |
                          +---------------+-----------------+
                                          |
                         +----------------+----------------+
                         |                                |
                         v                                v
    +---------------------------------+     +---------------------------------+
    |          🧩 Infra.IoC           |     |         💾 Infra.Data          |
    |  (Dependency Injection Config)  |     | (Repositories, Persistence)    |
    +---------------+-----------------+     +---------------+----------------+
                                                                |
                                                                v
                                      +---------------------------------+
                                      |      🏢 Database (SQL Server)   |
                                      |  (Entity Framework, Migrations) |
                                      +---------------------------------+

                          +---------------------------------+
                          |         🧪 Domain.Test          |
                          |  (Unit Tests for Domain Layer)  |
                          +---------------------------------+

---

## 🤔 O que são os Princípios SOLID?

- **S** - _Single Responsibility Principle_ (Princípio da Responsabilidade Única):  
  Cada classe ou módulo deve ter uma única responsabilidade ou motivo para mudar.

- **O** - _Open/Closed Principle_ (Princípio do Aberto/Fechado):  
  Entidades de software (classes, módulos, funções, etc.) devem estar abertas para extensão, mas fechadas para modificação.

- **L** - _Liskov Substitution Principle_ (Princípio da Substituição de Liskov):  
  Objetos de uma superclasse devem poder ser substituídos por objetos de suas subclasses sem alterar a funcionalidade do programa.

- **I** - _Interface Segregation Principle_ (Princípio da Segregação de Interfaces):  
  Nenhum cliente deve ser forçado a depender de métodos que não utiliza.

- **D** - _Dependency Inversion Principle_ (Princípio da Inversão de Dependência):  
  Módulos de alto nível não devem depender de módulos de baixo nível. Ambos devem depender de abstrações. Abstrações não devem depender de detalhes; detalhes devem depender de abstrações.

## 🏆 Princípios SOLID utilizados no Projeto

- **S**:  
  O `UserManager` trata apenas da lógica de criação e atualização de usuários, sem interferir em regras de agendamento ou autenticação.

- **O**:  
  Interfaces como `IUserRepository` e `IAttendanceService` permitem que novas implementações sejam adicionadas sem alterar o código existente.

- **L**:  
  Serviços de notificação como `EmailNotifier` e `SmsNotifier` herdam de uma interface comum e podem ser alternados sem quebrar funcionalidades.

- **I**:  
  Interfaces distintas, como `ILoginService` e `IAgendaManager`, evitam que uma classe tenha que implementar métodos que não utiliza.

- **D**:  
  A configuração de IoC garante a inversão de dependência:
  ```csharp
  builder.Services.AddScoped<IProductRepository, ProductRepository>();
  ```

---

## 📐 Padrão Domain-Driven Design (DDD)

> Domain-Driven Design (DDD) é uma abordagem de desenvolvimento de software que se concentra no domínio de negócios.

O projeto adota o padrão **DDD** para organizar e estruturar o código, garantindo foco nas regras de negócio.

### 🗂️ Camadas do DDD

- **Domínio (Domain):** Entidades, agregados, objetos de valor e regras de negócio.
- **Aplicação (Application):** Orquestra os casos de uso, conectando domínio e interfaces externas.
- **Infraestrutura (Infrastructure):** Persistência de dados e serviços externos.
- **Interface (Interface):** Interação com o usuário ou sistemas externos.

### 🔑 Conceitos Fundamentais

- **Entidades:** Objetos principais do domínio, identificados por um ID único.
- **Objetos de Valor:** Conceitos imutáveis e sem identidade própria.
- **Agregados:** Agrupam entidades e objetos de valor logicamente relacionados.
- **Repositórios:** Abstrações para manipulação de dados persistentes.
- **Serviços de Domínio:** Lógica de negócio fora de entidades específicas.

---

## ▶️ Como Executar o Projeto

### Pré-requisitos

- **.NET SDK:** Versão 6.0.  
  [Download .NET SDK](https://dotnet.microsoft.com/download)
- **SQL Server:** Versão 2019 ou superior.  
  [Download SQL Server](https://www.microsoft.com/sql-server)
- **Visual Studio 2022** (ou outra IDE compatível com .NET Core).  
  [Download Visual Studio](https://visualstudio.microsoft.com)

### Passos

1. Clonar o repositório:
   ```sh
   git clone https://github.com/rafaelromwno/tpII-helpstop-backend.git
   ```
2. Configurar a string de conexão no **appsettings.json**.
3. Abrir o arquivo `HelpApp.sln` no Visual Studio.
4. Aplicar as migrations:
   ```sh
   Update-Database
   ```
5. Iniciar a aplicação:
   ```sh
   dotnet run
   ```
6. Testar as rotas com **Swagger** ou **Postman**.

---

## 👨🏽‍🔬 Testes Automatizados

- Implementados nas camadas **Application** e **Domain**.
- Para executar os testes:
  ```sh
  dotnet test
  ```
- Utiliza xUnit / NUnit para testes de unidade e integração.
- Testes priorizam validação de regras de negócio e segurança.

---

## 👨🏽‍💻 Equipe de Desenvolvimento

- **Rafael Romano Silva** - Backend, Frontend, Testes e Documentação - [GitHub](https://github.com/rafaelromwno)

---

## 📜 Licença

Este projeto está licenciado sob a **MIT License**. Consulte o arquivo `LICENSE` para mais informações.