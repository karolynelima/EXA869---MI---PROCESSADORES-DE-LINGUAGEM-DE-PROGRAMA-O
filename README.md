# EXA869---MI---PROCESSADORES-DE-LINGUAGEM-DE-PROGRAMA-O

GLOSSÁRIO:

## Terminais

Os seguintes não terminais devem ser escritos em letra minúsculas: 'se', 'enquanto', 'leia', 'escreva'

Newline - permite muitas linhas.

Whitespace - define espaços em brancos.   

Identificadores - conjuntos de simbolos que podem ser utilizados como identificadores.

Numeros - define números.

CadeiaCaracteres - define uma cadeia de caracteres.

TipoMetodos - define os tipos de retorno dos métodos.

Tipo - define os tipos de variáveis.

OperadoresAritmeticos -	define os operadores aritméticos.

Incrementador - define o '++' e '--'.

OperadoresRelacionais - define o conjunto de operadores relacionais.

OperadoresLogicos - define o conjunto de operadores lógicos.

TipoBooleano - strings que definem o que os tipos booleanos podem receber.

## Não terminais
\<newline\> - permite novas linhas ou vazio



### Bloco de constantes
\<blocoConstantes\> - permite a declaração do bloco de constantes.

\<estruturaConstante\> - estrutura de como se deve declarar uma constantes.

\<constantes\> - identificador da constante e sua inicialização.

\<multiplasConstantes\> - permite a adicionar mais de uma constante do mesmo tipo.

\<constante\> - valores que uma constantes pode receber.


### Chamada de método
\<chamadaDeMetodo\> - chamada de método existente.

\<metodoParametro\> - para passar um método como parâmetro.

### Atribuição de Variáveis
\<atribuicaoDeVariavel\> - permite a atribuição de um valor a uma variável

\<verificaCaso\> - faz a verificação entre incremento, expressão e booleano

\<incremento\> - incremento do valor de uma variável (++/--) 

\<expressao\> - expressões numéricas e concatenações de strings

\<booleano\> - atribuição dos valores booleanos a uma variável (verdadeiro/falso)

\<maisOperacoes\> - permite mais de um termo na expressão 

\<operador\> - o próprio termo da expressão

\<vetorMatriz\> - permite o uso de matrizes e vetores 

### Incrementador

\<incrementador\> - permite que haja no meio no código a seguinte expressão b++; ou b--;

### Declaração de Variáveis

\<DeclaracaoVariaveis\> - Permite a declaração de variáveis definindo sua estrutura
\<Var\> - Define a estrutura da declaração de um tipo determinado de variável  
\<tipo\> - Define os tipos permitidos para declaração de variáveis
\<complemento\> - Define o nome da variável
\<MaisVariaveis\> - Define a estrutura da declaração de um tipo diferente de variável 
\<variavelMesmoTipo\> - Define a estrutura da declaração caso existam variáveis do mesmo tipo, senão finaliza com ';'
\<boleano\> - Atribui o valor de verdadeiro ou falso em uma variável de tipo boleano

### Declaração do enquanto

\<enquanto\> - Permite a declaração do laço enquanto
\<operacao_relacional\> - Define a estrutura de uma operação relacional
\<complemento_enquanto\> - Define a estrutura do bloco do enquanto 
\<conteudo_laco\> - Permite a declaração dos comandos que são permitidos no bloco do enquanto 
\<operador_rel\> - Associa o primeiro elemento da operação relacional com as operações específicas
\<complemento_operador\> Associa o segundo elemento da operação relacional
\<comando\> - Define os comandos no bloco do enquanto, permitindo repetição de comandos ou vazio

