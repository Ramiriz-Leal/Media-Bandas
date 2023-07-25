# Armazenamento e média de valores

Projeto de contagem de média de bandas
## Como funciona?

O projeto é um programa de console em C# que permite registrar, avaliar e exibir a média de bandas. Quando você executa o programa, uma tela de boas-vindas é mostrada com algumas opções para escolher.

As opções disponíveis são as seguintes:

1. **Registrar uma banda:**
   Permite que o usuário insira o nome de uma banda e a adicione à lista de bandas registradas. As bandas são armazenadas em um dicionário.

2. **Mostrar todas as bandas:**
   Exibe uma lista de todas as bandas que foram registradas anteriormente.

3. **Avaliar uma banda:**
   Permite que o usuário dê uma nota para uma banda específica que foi registrada. As notas são armazenadas em uma lista associada à banda.

4. **Exibir a média das bandas:**
   Calcula e mostra a média das notas atribuídas a uma banda específica.

5. **Sair:**
   Encerra o programa.

## Estrutura do Código

O código foi organizado utilizando métodos para separar as diferentes funcionalidades do programa:

- `ShowOpcMenu()`: Exibe o menu principal com as opções disponíveis e permite que o usuário escolha uma opção.

- `RegBanda()`: Permite que o usuário registre uma nova banda, inserindo o nome da banda, que é adicionado ao dicionário de bandas.

- `AllBanda()`: Mostra todas as bandas que foram registradas anteriormente.

- `EvalBanda()`: Permite que o usuário avalie uma banda específica, atribuindo uma nota que é armazenada na lista associada à banda.

- `AverBanda()`: Calcula e mostra a média das notas atribuídas a uma banda específica.

- `BackMenu()`: Exibe uma mensagem e aguarda que o usuário pressione qualquer tecla para retornar ao menu principal.

## Tratamento de Erros

O programa inclui tratamento de erro para evitar que o programa quebre caso o usuário digite uma opção inválida no menu principal. Se o usuário inserir algo que não pode ser convertido para um número inteiro, o programa exibirá a mensagem "Opção inválida, tente novamente!" e oferecerá a opção de tentar novamente.

## Observações

Este projeto é uma implementação simples de um sistema de avaliação de bandas musicais e pode ser estendido ou aprimorado para adicionar mais funcionalidades, como armazenamento persistente dos dados, interface gráfica, entre outros.

## Como Executar o Programa

Para executar o programa, basta compilar o código-fonte em um ambiente C# compatível e executar o arquivo resultante. O programa será iniciado no console, e o usuário poderá interagir com as opções disponíveis digitando o número correspondente e pressionando Enter.
## Autores

- [GitHub](https://github.com/Ramiriz-Leal?tab=repositories)
- [Linkedin](https://www.linkedin.com/in/ramiriz-leal/)
- [Instagram](https://instagram.com/ramiriz.js?igshid=MjEwN2IyYWYwYw==)
