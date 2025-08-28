# Fluent Result [![NuGet](https://img.shields.io/nuget/v/MrP.FluentResult.svg)](https://www.nuget.org/packages/MrP.FluentResult)

#### Fornece uma maneira simples e clara de retornar **sucesso, erros, mensagens e valores**
sem depender de exceções para controle de fluxo.  

---

## 📖 Sumário
- [Instalação](#-instalação)
- [Exemplos de Uso](#-exemplos-de-uso)
  - [Resultado simples (Result)](#-resultado-simples-result)
  - [Resultado com valor (Result<T>)](#-resultado-com-valor-resultt)
- [Estrutura dos Tipos](#-estrutura-dos-tipos)
- [Extensões Fluentes](#-extensões-fluentes)
- [Interface Base](#-interface-base)
- [Contribuições](#-contribuições)
- [Autor](#-autor)

---

## 📦 Instalação

Via **NuGet CLI**:

```bash
dotnet add package MrP.FluentResult
````
Ou diretamente no seu arquivo `.csproj`:

```xml
<ItemGroup>
  <PackageReference Include="MrP.FluentResult" Version="1.0.1" />
</ItemGroup>
```


## 📚 Exemplos de Uso

### ✅ Resultado simples (`Result`)

```csharp
var result = new Result(true)
    .AddMessage("Operação concluída com sucesso")
    .AddErrorMessage("Mas atenção: campo opcional não preenchido");
```

### ✅ Resultado com valor (`Result<T>`)

```csharp
var pedido = new PedidoDto();

var result = new Result<PedidoDto>(pedido, true)
    .AddMessage("Pedido enviado")
    .AddErrorMessages(["Campo obrigatório ausente", "Erro de validação"]);
```

---

## 🧱 Estrutura dos Tipos

### `Result`

```csharp
public class Result : IFluentResult
{
    public bool Success { get; set; }
    public List<string> Messages { get; set; }
    public List<string> ErrorMessages { get; set; }
}
```

### `Result<T>`

```csharp
public class Result<T> : Result
{
    public T Value { get; set; }
}
```

---

## 🔁 Extensões Fluentes

A biblioteca inclui métodos de extensão para encadeamento fluente:

```csharp
result
    .AddMessage("Tudo certo")
    .AddErrorMessages(["Erro 1", "Erro 2"]);
```

Esses métodos funcionam tanto para `Result` quanto para `Result<T>`, mantendo o tipo original e a fluência.

---

## 🧩 Interface Base

Todos os tipos implementam `IFluentResult`, que garante acesso a:

- `Success`
- `Messages`
- `ErrorMessages`

---

## 🤝 Contribuições

Sinta-se à vontade para abrir issues, enviar PRs ou sugerir melhorias. Esse pacote é feito pra ser simples, útil e extensível.

---

# 🧑‍🔬Autor🧑‍🔬

Paulo Roberto S. Gomes Conceição

