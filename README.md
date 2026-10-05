# Ecommerce Checkout - xUnit

Projeto desenvolvido para a disciplina de Gestão e Qualidade de Software, com o objetivo de praticar testes unitários utilizando .NET 10, C# e xUnit.

## Funcionalidades

A classe `PedidoService` possui os seguintes métodos:

### GerarCodigoRastreio

Gera um código de rastreio utilizando a região em letras maiúsculas e o número do pedido com quatro dígitos.

Exemplo:

`SUDESTE-0042`

### CalcularPontosFidelidade

Calcula os pontos de fidelidade do cliente.

A cada R$ 10,00 em compras, o cliente recebe 2 pontos.

Exemplo:

R$ 150,00 = 30 pontos.

### TemDireitoAFreteGratis

Verifica se o cliente possui direito a frete grátis.

O frete é grátis quando:

- O valor da compra é maior ou igual a R$ 200,00; ou
- O cliente é VIP.

## Testes Unitários

Foram implementados testes utilizando xUnit para validar:

- Geração do código de rastreio;
- Cálculo dos pontos de fidelidade;
- Frete grátis para cliente VIP;
- Ausência de frete grátis para cliente não VIP abaixo de R$ 200,00.

Resultado:

- 4 testes executados;
- 4 testes aprovados;
- 0 testes com falha.

## Executar os testes

No terminal, na pasta principal do projeto, execute:

```bash
dotnet test