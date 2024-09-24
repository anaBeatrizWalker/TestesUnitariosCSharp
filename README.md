# Anotações de desenvolvimento

## Projetos

- Criando projeto de console na pasta Calculadora

```bash
dotnet new console
```

- Criando projeto de teste na pasta CalculadoraTestes

```bash
dotnet new xunit
```

## Solução

- Criando uma solução para os projetos na pasta "TestesUnitariosCSharp"

```bash
dotnet new sln -n "TestesUnitariosCSharp"
```

- Adicionando os arquivos .csproj de cada projeto na solução
```bash
cd "c:\...\TestesUnitariosCSharp\TestesUnitariosCSharp.sln" add "c:\...\TestesUnitariosCSharp\CalculadoraTestes\CalculadoraTestes.csproj"

cd "c:\...\TestesUnitariosCSharp" 

dotnet sln "c:\...\TestesUnitariosCSharp\TestesUnitariosCSharp.sln" add "c:\...\TestesUnitariosCSharp\Calculadora\Calculadora.csproj"
```

- Adicionando referência de projeto
```bash
cd "c:\...\CalculadoraTestes"

dotnet add "c:\...\TestesUnitariosCSharp\CalculadoraTestes\CalculadoraTestes.csproj" reference "c:\...\TestesUnitariosCSharp\Calculadora\Calculadora.csproj"
```
