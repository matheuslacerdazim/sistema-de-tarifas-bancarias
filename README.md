Sistema de tarifas bancarias em C#.

Este sistema consiste em:

* Pega os dados do aquivo Dados.txt através do método LerArquivoClientes e insere-os na variável lista.
* Instancia-se o GerenciadorDeTarifa, o qual roda item por item instanciando la dentro cada um dos
tipos de conta e calculando suas respectivas tarifas e convertendo para reais as contas que estão em dolar.
Ainda no GenrenciadorDeTarifa, através de events e delegates, imprime-se no console um contador que mostra o
progresso dos calculos, e ao fim exibe uma mensagem indicando que o arquivo com os dados do cliente ,ja tarifados e convertidos, foi gerado com sucesso.
 

Recursos:

Cálculo de tarifas para diferentes tipos de contas.
Uso de classes abstratas, interfaces, polimorfismo e Linq para diminuir a verbosidade do código.
Geração de arquivos de saída.
Uso de delegates e events para notificar o progresso e coletar dados.
Programação orientada a objetos para representar as contas bancárias.

Sinta-se à vontade para ajustar ou expandir essa descrição de acordo com suas preferências e para adicionar detalhes adicionais sobre o projeto, como instruções de como executá-lo ou qualquer outra informação relevante.
