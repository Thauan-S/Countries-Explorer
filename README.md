# Countries-Explorer
Aplicativo multiplataforma desenvolvido em .NET MAUI que consome a API [RestCountries](https://restcountries.com/) para exibir informações de países, incluindo nome, capital, região, bandeira e moedas.

## Tecnologias
- .NET MAUI (Android, iOS, Windows, macOS)
- C# 11
- MVVM com CommunityToolkit.Mvvm
- HttpClient com Polly para resiliência
- REST API: [RestCountries](https://restcountries.com/)

## Funcionalidades

- Listagem de todos os países
- Exibição detalhada das informações de cada país
- Resiliência na comunicação HTTP com retry exponencial
- Interface adaptativa para múltiplas plataformas

## Estrutura do Projeto

CountriesExplorer.sln

├─ CountriesExplorer/  

│  ├─ Views/

│  ├─ ViewModels/

│  └─ App.xaml

├─ Domain/      

│  ├─ Models/   

│  ├─ Interfaces/      


├─ Infrastructure/      

│  ├─ Services/               

## Vantagens dessa abordagem

Facilita testes unitários, porque você pode mockar ICountriesService.

Permite trocar implementações sem alterar o MAUI (ex.: trocar API por banco local).

Deixa o projeto mais organizado e escalável, especialmente se for crescer ou integrar outras APIs.

## Instruções para executar o projeto :

 1-Clone o repositório com o comando : git clone https://github.com/Thauan-S/Countries-Explorer.git
 
 2-Clique no botão para executar o projeto  <img width="140" height="30" alt="image" src="https://github.com/user-attachments/assets/9a617b73-f55c-4fd5-b1d1-589299a2bf61" />

 3-Clique no botão para realizar a busca dos países <img width="164" height="89" alt="image" src="https://github.com/user-attachments/assets/3281ce3c-0fdf-4646-98a0-42041bdc42ec" />

 4-Escolha um card para ver mais detalhes do país <img width="295" height="178" alt="image" src="https://github.com/user-attachments/assets/6942a4c2-a172-4fd6-b0f4-fcf01f4bd8af" />

