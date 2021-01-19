# XunitTDD
Projeto console usado no curso de xUnit e TDD da Alura

Negocio: aplicativo de leilão para lances com ganhador, verificação de valores, incio e termino do pregão para uso do teste unitário e TDD.

Inicia alterando o projeto de negócio para indicar o ganhador do projeto exibindo o último lance como ganhador.
E criado um projeto console para efetuar o teste da funcionalidade e verificando que o código não está funcional, tentando automatizar o teste da funcionalidade usando o seu conceito e abrindo a contextualização para o uso de um framwork de teste.

Para isso iniciamos com o conceito de Arrange Act e Assert de teste autimatizado.
Referencia http://wiki.c2.com/?ArrangeActAssert
E deacordo com Martin Fowler usnado o Given When Then
Referencia https://martinfowler.com/bliki/GivenWhenThen.html

Já se começar a ter um retonro rapido do teste automatizado com o retorno obtido.

Abordando o conceito de teste unitário.
Referencia https://wiki.c2.com/?UnitTest

Ao criar o programa de teste ve-se que não é o ideal pois estamos nos afastando do negocio que seria trabalhar no programa de leilão e dedicando esforço na automatização do teste.

Atualmente, os maiores concorrentes desta área na plataforma .NET são o xUnit, MSTest e NUnit
Abrindo a abordagem ao xUnit
Referecia https://dev.to/hatsrumandcode/net-core-2-why-xunit-and-not-nunit-or-mstest--aei
Comparativo entre os framworks https://xunit.github.io/docs/comparisons

Executado mais de uma teste no assert de um testes, é possível fazer uma colão de validações para um mesmo arrenge e act.
