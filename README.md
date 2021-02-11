# CadastroCliente
Simples CRUD para cadastro de pessoas.

#### Passos para instalação da aplicação:

1. Baixe o SDK do dotnet 5: <br>
  [Microsoft .NET 5](https://dotnet.microsoft.com/download/dotnet/5.0)

2. Escolha um diretório na sua máquina e clone o repositório da aplicação: <br>
  `git clone https://github.com/lucaslrc/CadastroCliente.git`

3. Utilizando um terminal (bash, powershell etc.) entre no diretório do repositório, exemplo: <br>
`cd $PATH/CadastroCliente`

4. Utilize o comando `dotnet build` para fazer o build da aplicação. <br>

5. Instale a ferramenta Entity Framework com o seguinte comando no terminal: <br>
`dotnet tool install --global dotnet-ef`

6. Agora digite o comando `dotnet ef database update` (dentro do diretório do repositório) para atualizar o banco no servidor MySql (o servidor MySql precisa está rodando). <br>

7. Posteriormente digite o comando `dotnet run`.

8. Caso a aplicação rode sem nenhum problema, basta fazer as chamadas através do Postman usando os seguintes links: <br>

`https://localhost:5001/api/CadastroCliente/ListarClientes`

`https://localhost:5001/api/CadastroCliente/AdicionarCliente`

`https://localhost:5001/api/CadastroCliente/EditarCliente`

`https://localhost:5001/api/CadastroCliente/RemoverCliente`

Ps.: Lembrando que é necessário preencher o campo body em cada chamada na API (utilizando o Postman).
