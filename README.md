# API de Autenticação e Autorização com JWT

## Visão Geral

Este projeto é uma **API REST em ASP.NET Core** que implementa:

* Cadastro de usuários
* Login com geração de **JWT (JSON Web Token)**
* Autenticação baseada em token
* Autorização por **Policy personalizada** (idade mínima)

O objetivo do projeto é **estudar e compreender** os conceitos de autenticação, autorização, Identity, JWT e policies no ASP.NET Core.

---

## Tecnologias Utilizadas

* ASP.NET Core
* Entity Framework Core
* ASP.NET Core Identity
* JWT Bearer Authentication
* AutoMapper
* MySQL

---

## Autenticação

A autenticação é feita via **JWT**:

1. O usuário realiza login
2. A API valida as credenciais
3. Um token JWT é gerado contendo claims do usuário

---

## Autorização

O projeto utiliza **Policies de autorização**.

### Policy: `MinimumAge`

* Controla o acesso a endpoints com base na idade mínima do usuário
* A idade é calculada a partir da `BirthDate`, armazenada como claim no token

---

## Estrutura Geral

* **Controllers**: Endpoints da API
* **Services**: Regras de negócio (login, geração de token)
* **Models**: Entidades do sistema
* **DTOs**: Objetos de transferência de dados
* **Authorization**: Policies, Requirements e Handlers
