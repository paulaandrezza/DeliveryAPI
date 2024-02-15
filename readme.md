# Overview do DeliveryAPI 🚚

O DeliveryAPI é uma API desenvolvida para gerenciar entregas e entregadores em um sistema de delivery.
Este projeto é uma atividade do módulo de Programação Web II (ASP.NET MVC / WEB AP) do curso Diversedev na Ada tech, com o objetivo de treinar o uso de endpoints, middlewares e filtros.

## Funcionalidades Principais 🛠️

- **Gerenciamento de Entregas:** Os usuários podem criar, visualizar, atualizar e excluir informações sobre entregas.
- **Gerenciamento de Entregadores:** Os usuários podem adicionar, listar, atualizar e excluir informações sobre entregadores.
- **Autenticação e Autorização:** A API utiliza autenticação e autorização para garantir acesso seguro aos endpoints. Os usuários precisam fazer login para acessar os recursos protegidos da API. Mais detalhes sobre autenticação e autorização podem ser encontrados na seção "Como Executar o Projeto".

## Tecnologias Utilizadas 🚀

- ASP.NET Core: Framework utilizado para desenvolver a API.
- C#: Linguagem de programação principal do projeto.
- Swagger: Ferramenta para documentar e testar a API.

## Como Executar o Projeto ▶️

1. Certifique-se de ter o Visual Studio instalado em sua máquina.
2. Clone o repositório do projeto.
3. Abra o projeto no Visual Studio.
4. Pressione F5 ou clique em "Iniciar" para rodar a aplicação.
5. Abra o navegador e acesse a URL `https://localhost:5103/swagger` para visualizar a documentação da API e testar os endpoints disponíveis.
6. Para acessar os recursos protegidos da API, como a criação de novas entregas ou entregadores, será necessário fazer login. Utilize as seguintes credenciais:
   - **Username:** admin
   - **Senha:** admin123
7. Após fazer login, você receberá um token de acesso. Adicione este token ao cabeçalho de autorização nas solicitações subsequentes.