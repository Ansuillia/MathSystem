# MathSystem

Sistema que calcula os divisores de um número e determina quais desses divisores é número primo.

## Mini Manual

Instanciar o Projeto MathSystem.Worker

Usar o MathSystem Console ou um consumidor qualquer de API para processar o número.

### Notas sobre o sistema

Nessa primeira versão o sistema simula uma aplicação que consome um item, processa e devolve o resultado.
Em breve irei implementar um producer que recebe a requisição, insere numa fila, talvez RabbitMQ ou pode Kafka também
e o processa, devolvendo o resultado para algum storage, quem sabe Redis ou Mongo.

Será implementado um melhor controle de de acesso de thread, usando Semphore ou Monitor, para que o recurso que está sendo
processado não possa ser utilizado por nenhuma outra thread.

Também implementarei um sistema de evento e o AppMetrics, porque acho legal.

Enfim, será um sistema inútil, porém bem feito.
