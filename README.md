# Ploomes

[Documentação da API](https://estoquewebapi.azurewebsites.net/swagger/index.html)
[GitHub](https://github.com/CaiqueBurssed/estoquewebapi)

# API com ASP.NET Core & EntityFramework Core

Projeto de uma API de estoque de produtos.

## Pré-requisitos

* Visual Studio 2019
* .NET Core SDK
* SQL Server versão 15.SQLEXPRESS
* Postman (Opcional)

## Estoque WebAPI

*  Essa aplicação Web API foi desenvolvida em C#, com acesso a um banco de dados SQL Server, com o intuito de armazenar, manipular e obter dados de registro de um produto qualquer (para demonstração de  teste  optei por usar videogames  como produto exemplo), utilizando HTTP e JSON.
* Para a documentação da API foi escolhida a a  aplicação  opensource Swagger, que visa padronizar este tipo de integração, descrevendo os recursos que uma API deve possuir, como _endpoints_, dados recebidos, dados retornados, códigos HTTP e métodos de autenticação, entre outros.
* O local de deploy escolhido foi o Microsoft Azure. 

## Instruções de Teste da API

Abaixo irei listar um passo-a-passo com exemplos práticos de teste dos cincos métodos implementados na API, para o armazenamento, manipulação e visualização dos dados. São eles:
* GET/ api/products : onde irá listar todos os produtos cadastrados.
* GET/ api/products/id : onde irá listar o produto escolhido pelo Id.
* POST/ api/products : onde irá criar um produto com as variáveis de: Id, Name, Quantity e Manufacturer.
* PUT/ api/products/id : onde ao passar o Id do produto escolhido, poderá alterar os dados das variávies.
* DELETE/ api/products/id : onde ao passar o Id do produto, deletará o produto escolhido.

## Criar Produto

Para a criação de um produto, acesse a página de [Documentação da API:](https://estoquewebapi.azurewebsites.net/swagger/index.html) 

* Na categoria de **Products**,  selecione a opção de método **POST /api/products**
* Ao abri-la, nota-se que esse método não necessita de parâmetros, então aperte o botão de **Try it out**.
* O **Request body** irá aparecer com a opção de preenchimento de um objeto JSON.
* Preencha os atributos **name**, **quantity** e **manufacturer** com os dados desejados.
> Exemplo: 
```json
{
  "name": "MegaDrive",
  "quantity": 10,
  "manufacturer": "Sega"
}
``` 
* Clique no botão de **Execute**.
* Após a execução do botão, um **Response boyd** abrirá com os dados preenchidos; Seguido do código **201** (Created).

> Nota: Ao definir o padrão de projeto **Data Tranfer Objects** foi optado que a variável **manufacturer** não seria permitida a  visualização pelo usuário ao criar um produto. Por isso no retorno, a variável é omitida.

## Listar Produtos

Para a listagem de um produto, acesse a página de [Documentação da API:](https://estoquewebapi.azurewebsites.net/swagger/index.html) 

* Na categoria de **Products**,  selecione a opção de método **GET /api/products**
* Ao abri-la, nota-se que esse método não necessita de parâmetros, então aperte o botão de **Try it out**.
* Clique no botão de **Execute**.
* Após a execução do botão, um **Response boyd** abrirá com os dados preenchidos de todos os produtos cadastrados; Seguido do código **200** (OK).
>Exemplo Response body:
```json
{
    "id": 1,
    "name": "Xbox One",
    "quantity": 75
  },
  {
    "id": 2,
    "name": "Playstation 4",
    "quantity": 105
  },
  {
    "id": 3,
    "name": "Playstation 3",
    "quantity": 35
  },
  {
    "id": 4,
    "name": "Nintendo Ds",
    "quantity": 70
  },
  {
    "id": 8,
    "name": "Playstation 2",
    "quantity": 57
  },
  {
    "id": 9,
    "name": "Nintendo Switch",
    "quantity": 50
  },
  {
    "id": 10,
    "name": "MegaDrive",
    "quantity": 10
  }
```

> Nota: Ao definir o padrão de projeto **Data Tranfer Objects** foi optado que a variável **manufacturer** não seria permitida a  visualização pelo usuário ao listar um produto. Por isso no retorno, a variável é omitida.

## Listar Produto Específico

Para a listagem de um produto específico, acesse a página de [Documentação da API:](https://estoquewebapi.azurewebsites.net/swagger/index.html) 

* Na categoria de **Products**,  selecione a opção de método **GET /api/products/{id}**
* Ao abri-la, nota-se que esse método necessita do parâmetro de **Id** do  produto, então aperte o botão de **Try it out**.
* Preencha o campo de parâmetro com  o **Id** do produto escolhido para listagem.
> Exemplo: id = 1
* Clique no botão de **Execute**.
* Após a execução do botão, um **Response boyd** abrirá com os dados preenchidos do produto desejado; Seguido do código **200** (OK).
>Exemplo Response body:
```json
{
  "id": 1,
  "name": "Xbox One",
  "quantity": 75
}
```

> Nota: Ao definir o padrão de projeto **Data Tranfer Objects** foi optado que a variável **manufacturer** não seria permitida a  visualização pelo usuário ao listar um produto. Por isso no retorno, a variável é omitida.

## Deletar Produto

Para deletar um produto específico, acesse a página de [Documentação da API:](https://estoquewebapi.azurewebsites.net/swagger/index.html) 

* Na categoria de **Products**,  selecione a opção de método **DELETE /api/products/{id}**
* Ao abri-la, nota-se que esse método necessita do parâmetro de **Id** do  produto, então aperte o botão de **Try it out**.
* Preencha o campo de parâmetro com  o **Id** do produto escolhido para exclusão.
> Exemplo: id = 10
* Clique no botão de **Execute**.
* Após a execução do botão, um **Response boyd** abrirá com os dados preenchidos do produto deletado; Seguido do código **200** (OK).
>Exemplo Response body:
```json
{
  "id": 10,
  "name": "MegaDrive",
  "quantity": 10,
  "manufacturer": "Sega"
}
```

>Observação: Para conferir se o produto foi realmente deletado, basta realizar a etapa de listar os produtos denovo.

## Editar Produto

Para editar um produto específico, acesse a página de [Documentação da API:](https://estoquewebapi.azurewebsites.net/swagger/index.html) 

* Na categoria de **Products**,  selecione a opção de método **PUT /api/products/{id}**
* Ao abri-la, nota-se que esse método necessita do parâmetro de **Id** do  produto, então aperte o botão de **Try it out**.
* Preencha o campo de parâmetro com  o **Id** do produto escolhido para exclusão.
> Exemplo: id = 1
* O **Request body** irá aparecer com a opção de preenchimento de um objeto JSON. Preencha os atributos **name**, **quantity** e **manufacturer** com os dados desejados.
>Exemplo alterando a variável de quantidade desse produto:
```json
{
  "name": "Xbox One",
  "quantity": 150,
  "manufacturer": "Microsoft"
}
```
* Clique no botão de **Execute**.
* Após a execução do botão, um **Response boyd** abrirá com os dados preenchidos do produto editado; Seguido do código **201** (Created).
>Exemplo Response body:
```json
{
  "id": 1,
  "name": "Xbox One",
  "quantity": 150,
  "manufacturer": "Microsoft"
}
```
##
