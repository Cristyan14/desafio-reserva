# Sistema de Hospedagem - Reserva de Suíte

## Descrição

Este projeto consiste em um sistema simples para gerenciar reservas em um hotel. O sistema utiliza três classes principais:

- **Pessoa**: representa um hóspede, com nome e idade.
- **Suite**: representa a suíte do hotel, contendo tipo, capacidade máxima e valor da diária.
- **Reserva**: relaciona hóspedes e suíte, gerenciando a reserva, cálculo do valor total e quantidade de hóspedes.

O sistema calcula o valor total da reserva com base na quantidade de dias reservados e no valor da diária da suíte, aplicando um desconto de 10% para reservas acima de 10 dias.

---

## Funcionalidades

- Cadastrar hóspedes com nome e idade.
- Cadastrar uma suíte com tipo, capacidade e valor da diária.
- Registrar uma reserva com a suíte escolhida, lista de hóspedes e número de dias.
- Validar se o número de hóspedes cabe na capacidade da suíte.
- Calcular o valor total da reserva, aplicando desconto quando aplicável.
- Obter a quantidade de hóspedes da reserva.

---

## Tecnologias Utilizadas

- Linguagem: C#
- Plataforma: .NET 8.0 (Console Application)

---

## Estrutura do Projeto

| Arquivo       | Descrição                                        |
|---------------|-------------------------------------------------|
| `Pessoa.cs`   | Classe que representa um hóspede (nome, idade). |
| `Suite.cs`    | Classe que representa a suíte (tipo, capacidade, valor). |
| `Reserva.cs`  | Classe que gerencia a reserva (hóspedes, suíte, cálculo). |
| `Program.cs`  | Ponto de entrada da aplicação, onde ocorre a execução e testes. |

---

## Como Rodar o Projeto

1. Certifique-se de ter o [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) instalado.

2. Clone ou baixe este repositório.

3. Navegue até o diretório do projeto no terminal/PowerShell:

   ```bash
   cd caminho/para/o/projeto
Compile e execute o projeto com:

bash
Copiar
Editar
dotnet run
A saída esperada deve ser similar a:

yaml
Copiar
Editar
Hóspedes: 2
Valor da diária total: R$ 1620.00
Exemplo de Código
Trecho do Program.cs demonstrando o uso do sistema:

csharp
Copiar
Editar
var hospedes = new List<Pessoa>
{
    new Pessoa("João", 28),
    new Pessoa("Maria", 25)
};

var suite = new Suite("Premium", 2, 150.00m);

var reserva = new Reserva(12, suite);
reserva.CadastrarHospedes(hospedes);

Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor da diária total: R$ {reserva.CalcularValorDiaria():0.00}");
Considerações
O sistema não possui interface gráfica, funcionando via console.

Valida a capacidade máxima da suíte ao cadastrar hóspedes.

Aplica desconto de 10% em reservas acima de 10 dias automaticamente.

Pode ser expandido para incluir entrada de dados pelo usuário, persistência em banco de dados, entre outras funcionalidades.
