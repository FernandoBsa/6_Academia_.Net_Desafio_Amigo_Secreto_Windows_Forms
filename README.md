# 6_Academia_.Net_Desafio_Amigo_Secreto_Windows_Forms

# Amigo Secreto App

O Amigo Secreto App é uma aplicação simples em C# que permite aos usuários organizar e gerenciar listas de amigos para eventos de Amigo Secreto. A aplicação utiliza o Windows Forms para uma interface gráfica intuitiva.

## Funcionalidades

- Cadastro de amigos com nome e e-mail.
- Geração aleatória de pares para o Amigo Secreto.
- Salvamento e leitura dos dados em um arquivo CSV.

## Requisitos

- [Visual Studio](https://visualstudio.microsoft.com/) para a compilação e execução do projeto.
- .NET Framework 4.5 ou superior.

## Como Usar

-Cadastro de Amigos:
Preencha os campos "Nome" e "E-mail".
Clique no botão "Adicionar Amigo" para incluir um novo amigo na lista.
Repita esse processo para adicionar todos os amigos desejados.

-Sorteio do Amigo Secreto e Exportacao para Arquivo CSV:
Após cadastrar os amigos, clique no botão "Sortear Amigo Secreto" para gerar as duplas aleatórias.
Será solicitado se deseja salvar as duplas geradas em um arquivo CSV chamado "amigoSecreto.csv".

-Remoção de Amigos:
O botão "Remover" permite que você exclua um amigo da lista ao selecionar o mesmo.

-Limpar Dados:
Utilize o botão "Limpar Tudo" para remover todos os amigos e reiniciar o processo.
Persistência de Dados
Os dados dos amigos são armazenados automaticamente no arquivo CSV amigos.csv ao adicionar novos amigos.
Ao iniciar o aplicativo, os dados existentes no arquivo são carregados automaticamente.
