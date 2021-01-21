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

Foi verifcado que o teste fica com codigos duplicados e uma forma de organiza-los é necessario.

Abordado o padrão AAA para organizar o teste sobre essas secções e os cenarios que podem ser passados pelo cliente do negócio.
Analise dos cenários de acordo com os valores de entrada e principalmente com os valores de saida para ser mais eficiente na criação dos testes.
É uma tecnica para otimizar os cenários de testes necessários com a quantidade de execução de testes a serem criados.
Referencia https://en.wikipedia.org/wiki/Equivalence_partitioning

Inificiencia e codigos duplicados podem ser um problema nos testes e usar o xunit para usar a teoria (theory)(anotação no xunit) nos testes existentes. Trocamos a anotação fact pelo theory no méotodo de teste. Parametrizar os dados de entrada do teste. Dessa forma organiza-se melhor o teste deixando-o enxuto e fácil leitura.
Referencia https://xunit.net/docs/getting-started/netcore/cmdline#write-first-theory

Melhores práticas em nomenclaturas para indicar no teste descrevendo-o já no nome do método. 
Referencia https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-best-practices#best-practices

Implantaão das Classes de equivalencia, nomenclatura de codigo e fatos e teorias.

Ajudam em testes regressivos com feedbacks instantaneos quando o comportamento do sistema é alterado evidenciando a necessidade de codigos de qualidade nos testes.

Orientar o desenvolvimento de novas funcionalidade de acordo com os testes.

Exemplo da nova funcionalidade:
  dado leilao iniciado e interessado X realiou o ultimo lance
  quando o mesmo interessado X realizer o proximo lance
  entao não aceita o segundo lance

Como testas metodos privados? Na maioria dos casos nao ha necessidade de efetuar testes privados pois em algum momento um metodo publico ira sensibilizar o metodo privado.
Referencia https://docs.microsoft.com/pt-br/dotnet/core/testing/unit-testing-best-practices#validate-private-methods-by-unit-testing-public-methods

Ciclo TDD
  novo teste -> falha -> correção -> sucesso -> refatorar
  refatorar -> sucesso
  refatorar -> falha -> correção -> sucesso

Poderá ocorrer momentos em que o teste de um nova funcionalidade não falhe mesmo sabendo que o nosso codigo não está feito para ele, como por exemplo testes de exception.

Assim cobrimos o código para encontrar partes não testadas do sistema.
Referencia https://www.martinfowler.com/bliki/TestCoverage.html

TDD também ajuda no design da codificação do sistema e as interfaces das classes.

Inicio do conseito SOLID para design de classes.
