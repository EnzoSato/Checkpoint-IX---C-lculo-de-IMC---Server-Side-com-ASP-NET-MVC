# Checkpoint IX - Calculadora de IMC (Server Side) ⚖️

Aplicação desenvolvida para o cálculo de Índice de Massa Corporal (IMC) utilizando **ASP.NET MVC**, conforme solicitado na disciplina de Desenvolvimento Web da UNINOVE.

## 🧠 Explicação da Implementação

Esta aplicação utiliza a arquitetura MVC com processamento **Server-Side** (no servidor). A lógica de implementação funcionou da seguinte maneira:

1. **Model (`ImcModel.cs`):** Criamos uma classe contendo as propriedades `Peso`, `Altura`, `ResultadoImc` e `Classificacao`. Ela é responsável por carregar e estruturar os dados que trafegam entre a tela e o nosso código C#.
2. **View (`Views/Imc/Index.cshtml`):** Construímos um formulário fortemente tipado utilizando a tag helper `asp-for` (Model Binding) para vincular os campos digitados diretamente ao Model. A tabela com o resultado só é exibida na tela se o cálculo já tiver sido processado.
3. **Controller (`ImcController.cs`):** Quando o usuário clica em "Calcular", os dados são enviados via método `POST` para o servidor. O C# intercepta os valores, realiza o cálculo matemático do IMC `(Peso / Altura²)` no back-end, define a classificação do peso (Abaixo do peso, Peso normal, Sobrepeso ou Obesidade) e devolve a página atualizada com o resultado final, sem depender de scripts no navegador (JavaScript).

## 📸 Print da Aplicação Rodando
<img width="1907" height="914" alt="image" src="https://github.com/user-attachments/assets/57676c3e-1db1-4e31-a0bd-07daccffa0a2" />
<img width="1904" height="915" alt="image" src="https://github.com/user-attachments/assets/232c3b97-60d3-46cc-89f5-6f99f93d7f46" />
<img width="1912" height="911" alt="image" src="https://github.com/user-attachments/assets/e39b47e7-0337-49e0-b138-f83728241b52" />
<img width="1912" height="912" alt="image" src="https://github.com/user-attachments/assets/54a6e7a2-40fc-44b7-bdf8-1a739c43b1ae" />
