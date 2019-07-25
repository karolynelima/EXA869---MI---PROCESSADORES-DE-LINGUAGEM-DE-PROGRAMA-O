
using System;
using System.IO;
using System.Runtime.Serialization;
using com.calitha.goldparser.lalr;
using com.calitha.commons;

namespace com.calitha.goldparser
{

    [Serializable()]
    public class SymbolException : System.Exception
    {
        public SymbolException(string message) : base(message)
        {
        }

        public SymbolException(string message,
            Exception inner) : base(message, inner)
        {
        }

        protected SymbolException(SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }

    }

    [Serializable()]
    public class RuleException : System.Exception
    {

        public RuleException(string message) : base(message)
        {
        }

        public RuleException(string message,
                             Exception inner) : base(message, inner)
        {
        }

        protected RuleException(SerializationInfo info,
                                StreamingContext context) : base(info, context)
        {
        }

    }

    enum SymbolConstants : int
    {
        SYMBOL_EOF                   =  0, // (EOF)
        SYMBOL_ERROR                 =  1, // (Error)
        SYMBOL_WHITESPACE            =  2, // Whitespace
        SYMBOL_EXCLAM                =  3, // '!'
        SYMBOL_LPAREN                =  4, // '('
        SYMBOL_RPAREN                =  5, // ')'
        SYMBOL_RPARENCOLON           =  6, // '):'
        SYMBOL_COMMA                 =  7, // ','
        SYMBOL_SEMI                  =  8, // ';'
        SYMBOL_LBRACKET              =  9, // '['
        SYMBOL_RBRACKET              = 10, // ']'
        SYMBOL_LBRACE                = 11, // '{'
        SYMBOL_RBRACE                = 12, // '}'
        SYMBOL_EQ                    = 13, // '='
        SYMBOL_CADEIACARACTERES      = 14, // CadeiaCaracteres
        SYMBOL_CONSTANTES            = 15, // constantes
        SYMBOL_ENQUANTO              = 16, // enquanto
        SYMBOL_ENTAO                 = 17, // entao
        SYMBOL_ESCREVA               = 18, // escreva
        SYMBOL_IDENTIFICADORES       = 19, // Identificadores
        SYMBOL_INCREMENTADOR         = 20, // Incrementador
        SYMBOL_LEIA                  = 21, // leia
        SYMBOL_METODO                = 22, // metodo
        SYMBOL_NUMEROS               = 23, // Numeros
        SYMBOL_OPERADORARITMETICOS   = 24, // OperadorAritmeticos
        SYMBOL_OPERADORESARITMETICOS = 25, // OperadoresAritmeticos
        SYMBOL_OPERADORESLOGICOS     = 26, // OperadoresLogicos
        SYMBOL_OPERADORESRELACIONAIS = 27, // OperadoresRelacionais
        SYMBOL_PROGRAMA              = 28, // programa
        SYMBOL_RESULTADO             = 29, // resultado
        SYMBOL_SE                    = 30, // se
        SYMBOL_SENAO                 = 31, // senao
        SYMBOL_TIPO                  = 32, // Tipo
        SYMBOL_TIPOBOOLEANO          = 33, // TipoBooleano
        SYMBOL_VARIAVEIS             = 34, // variaveis
        SYMBOL_ATRIBUICAODEVARIAVEL  = 35, // <atribuicaoDeVariavel>
        SYMBOL_BLOCOCONSTANTES       = 36, // <blocoConstantes>
        SYMBOL_BLOCOSE               = 37, // <blocoSe>
        SYMBOL_BOOLEANO              = 38, // <booleano>
        SYMBOL_CHAMADADEMETODO       = 39, // <chamadaDeMetodo>
        SYMBOL_COMANDOS              = 40, // <comandos>
        SYMBOL_COMPLEMENTO_OPERADOR  = 41, // <complemento_operador>
        SYMBOL_COMPLEMENTOV          = 42, // <complementoV>
        SYMBOL_COND                  = 43, // <cond>
        SYMBOL_CONDSE                = 44, // <condse>
        SYMBOL_CONDSENAO             = 45, // <condSenao>
        SYMBOL_CONSTANTE             = 46, // <constante>
        SYMBOL_CONSTANTES2           = 47, // <constantes>
        SYMBOL_CONTEUDO_LACO         = 48, // <conteudo_laco>
        SYMBOL_CONTEUDOLEIA          = 49, // <conteudoLeia>
        SYMBOL_DECLARACAOVARIAVEIS   = 50, // <DeclaracaoVariaveis>
        SYMBOL_ENQUANTO2             = 51, // <enquanto>
        SYMBOL_ESCOPOMETODO          = 52, // <escopoMetodo>
        SYMBOL_ESCOPOPROGRAMA        = 53, // <escopoPrograma>
        SYMBOL_ESCREVA2              = 54, // <escreva>
        SYMBOL_ESTRUTURA_CONSTANTE   = 55, // <estrutura_constante>
        SYMBOL_EXPRESSAO             = 56, // <expressao>
        SYMBOL_INCREMENTADOR2        = 57, // <incrementador>
        SYMBOL_INCREMENTO            = 58, // <incremento>
        SYMBOL_LEIA2                 = 59, // <leia>
        SYMBOL_LERMAIS               = 60, // <lerMais>
        SYMBOL_LISTAPARAMETROS       = 61, // <listaParametros>
        SYMBOL_MAISCOND              = 62, // <maisCond>
        SYMBOL_MAISOPERACOES         = 63, // <maisOperacoes>
        SYMBOL_MAISPARAMETROE        = 64, // <MaisParametroE>
        SYMBOL_MAISPARAMETROS        = 65, // <maisParametros>
        SYMBOL_MAISVARIAVEIS         = 66, // <MaisVariaveis>
        SYMBOL_MAISVARIAVEL          = 67, // <maisVariavel>
        SYMBOL_MATRIZ                = 68, // <Matriz>
        SYMBOL_METODO2               = 69, // <metodo>
        SYMBOL_METODOPARAMETRO       = 70, // <metodoParametro>
        SYMBOL_MULTIPLASCONSTANTES   = 71, // <multiplasConstantes>
        SYMBOL_NEGAR                 = 72, // <negar>
        SYMBOL_OP                    = 73, // <op>
        SYMBOL_OPERACAO_RELACIONAL   = 74, // <operacao_relacional>
        SYMBOL_OPERADOR              = 75, // <operador>
        SYMBOL_OPI2                  = 76, // <OpI2>
        SYMBOL_OPINDICE              = 77, // <OpIndice>
        SYMBOL_PARAMESCRITA          = 78, // <Param Escrita>
        SYMBOL_PROGRAMA2             = 79, // <programa>
        SYMBOL_RETORNO               = 80, // <retorno>
        SYMBOL_SE2                   = 81, // <se>
        SYMBOL_SENAO2                = 82, // <senao>
        SYMBOL_TERMO                 = 83, // <termo>
        SYMBOL_TIPOTERMO             = 84, // <tipoTermo>
        SYMBOL_VAR                   = 85, // <var>
        SYMBOL_VARIAVELMESMOTIPO     = 86, // <variavelMesmoTipo>
        SYMBOL_VARV                  = 87, // <VarV>
        SYMBOL_VERIFICACASO          = 88, // <verificaCaso>
        SYMBOL_VETOR                 = 89  // <Vetor>
    };

    enum RuleConstants : int
    {
        RULE_OPINDICE_OPERADORESARITMETICOS                                      =  0, // <OpIndice> ::= OperadoresAritmeticos <OpI2> <OpIndice>
        RULE_OPINDICE                                                            =  1, // <OpIndice> ::= 
        RULE_OPI2_NUMEROS                                                        =  2, // <OpI2> ::= Numeros
        RULE_OPI2_IDENTIFICADORES                                                =  3, // <OpI2> ::= Identificadores
        RULE_VETOR_LBRACKET_RBRACKET                                             =  4, // <Vetor> ::= '[' <OpI2> <OpIndice> ']' <Matriz>
        RULE_VETOR                                                               =  5, // <Vetor> ::= 
        RULE_MATRIZ_LBRACKET_RBRACKET                                            =  6, // <Matriz> ::= '[' <OpI2> <OpIndice> ']'
        RULE_MATRIZ                                                              =  7, // <Matriz> ::= 
        RULE_PROGRAMA_PROGRAMA_LBRACE_RBRACE                                     =  8, // <programa> ::= programa '{' <blocoConstantes> <escopoPrograma> '}'
        RULE_ESCOPOPROGRAMA                                                      =  9, // <escopoPrograma> ::= <metodo> <escopoPrograma>
        RULE_ESCOPOPROGRAMA2                                                     = 10, // <escopoPrograma> ::= 
        RULE_DECLARACAOVARIAVEIS_VARIAVEIS_LBRACE_RBRACE                         = 11, // <DeclaracaoVariaveis> ::= variaveis '{' <VarV> '}'
        RULE_DECLARACAOVARIAVEIS                                                 = 12, // <DeclaracaoVariaveis> ::= 
        RULE_VARV_TIPO                                                           = 13, // <VarV> ::= Tipo <complementoV> <MaisVariaveis>
        RULE_COMPLEMENTOV_IDENTIFICADORES                                        = 14, // <complementoV> ::= Identificadores <Vetor> <variavelMesmoTipo>
        RULE_VARIAVELMESMOTIPO_COMMA                                             = 15, // <variavelMesmoTipo> ::= ',' <complementoV>
        RULE_VARIAVELMESMOTIPO_SEMI                                              = 16, // <variavelMesmoTipo> ::= ';'
        RULE_MAISVARIAVEIS                                                       = 17, // <MaisVariaveis> ::= <VarV>
        RULE_MAISVARIAVEIS2                                                      = 18, // <MaisVariaveis> ::= 
        RULE_BLOCOCONSTANTES_CONSTANTES_LBRACE_RBRACE                            = 19, // <blocoConstantes> ::= constantes '{' <estrutura_constante> '}'
        RULE_BLOCOCONSTANTES                                                     = 20, // <blocoConstantes> ::= 
        RULE_ESTRUTURA_CONSTANTE_TIPO_SEMI                                       = 21, // <estrutura_constante> ::= Tipo <constantes> ';' <estrutura_constante>
        RULE_ESTRUTURA_CONSTANTE                                                 = 22, // <estrutura_constante> ::= 
        RULE_CONSTANTES_IDENTIFICADORES_EQ                                       = 23, // <constantes> ::= Identificadores '=' <constante> <multiplasConstantes>
        RULE_CONSTANTES_IDENTIFICADORES_EQ2                                      = 24, // <constantes> ::= Identificadores '=' <constante>
        RULE_MULTIPLASCONSTANTES_COMMA                                           = 25, // <multiplasConstantes> ::= ',' <constantes>
        RULE_CONSTANTE_IDENTIFICADORES                                           = 26, // <constante> ::= Identificadores
        RULE_CONSTANTE_CADEIACARACTERES                                          = 27, // <constante> ::= CadeiaCaracteres
        RULE_CONSTANTE_NUMEROS                                                   = 28, // <constante> ::= Numeros
        RULE_ATRIBUICAODEVARIAVEL_IDENTIFICADORES_EQ_SEMI                        = 29, // <atribuicaoDeVariavel> ::= Identificadores <Vetor> '=' <verificaCaso> ';'
        RULE_VERIFICACASO                                                        = 30, // <verificaCaso> ::= <incremento>
        RULE_VERIFICACASO2                                                       = 31, // <verificaCaso> ::= <expressao>
        RULE_VERIFICACASO3                                                       = 32, // <verificaCaso> ::= <booleano>
        RULE_INCREMENTO_LPAREN_INCREMENTADOR_IDENTIFICADORES_RPAREN              = 33, // <incremento> ::= '(' Incrementador Identificadores <Vetor> ')'
        RULE_INCREMENTO_LPAREN_IDENTIFICADORES_INCREMENTADOR_RPAREN              = 34, // <incremento> ::= '(' Identificadores <Vetor> Incrementador ')'
        RULE_INCREMENTO_INCREMENTADOR_IDENTIFICADORES                            = 35, // <incremento> ::= Incrementador Identificadores <Vetor>
        RULE_INCREMENTO_IDENTIFICADORES_INCREMENTADOR                            = 36, // <incremento> ::= Identificadores <Vetor> Incrementador
        RULE_BOOLEANO_LPAREN_TIPOBOOLEANO_RPAREN                                 = 37, // <booleano> ::= '(' TipoBooleano ')'
        RULE_BOOLEANO_LPAREN_EXCLAM_TIPOBOOLEANO_RPAREN                          = 38, // <booleano> ::= '(' '!' TipoBooleano ')'
        RULE_BOOLEANO_LPAREN_EXCLAM_IDENTIFICADORES_RPAREN                       = 39, // <booleano> ::= '(' '!' Identificadores <Vetor> ')'
        RULE_BOOLEANO_TIPOBOOLEANO                                               = 40, // <booleano> ::= TipoBooleano
        RULE_BOOLEANO_EXCLAM_TIPOBOOLEANO                                        = 41, // <booleano> ::= '!' TipoBooleano
        RULE_BOOLEANO_EXCLAM_IDENTIFICADORES                                     = 42, // <booleano> ::= '!' Identificadores <Vetor>
        RULE_EXPRESSAO_LPAREN_RPAREN                                             = 43, // <expressao> ::= '(' <expressao> ')'
        RULE_EXPRESSAO_LPAREN_RPAREN_OPERADORESARITMETICOS                       = 44, // <expressao> ::= '(' <expressao> ')' OperadoresAritmeticos <expressao>
        RULE_EXPRESSAO                                                           = 45, // <expressao> ::= <operador> <maisOperacoes>
        RULE_MAISOPERACOES_OPERADORESARITMETICOS                                 = 46, // <maisOperacoes> ::= OperadoresAritmeticos <maisOperacoes>
        RULE_MAISOPERACOES_OPERADORESARITMETICOS2                                = 47, // <maisOperacoes> ::= OperadoresAritmeticos <expressao>
        RULE_MAISOPERACOES                                                       = 48, // <maisOperacoes> ::= 
        RULE_OPERADOR_NUMEROS                                                    = 49, // <operador> ::= Numeros
        RULE_OPERADOR_CADEIACARACTERES                                           = 50, // <operador> ::= CadeiaCaracteres
        RULE_OPERADOR_IDENTIFICADORES                                            = 51, // <operador> ::= Identificadores <Vetor>
        RULE_OPERADOR                                                            = 52, // <operador> ::= <chamadaDeMetodo>
        RULE_INCREMENTADOR_IDENTIFICADORES_INCREMENTADOR_SEMI                    = 53, // <incrementador> ::= Identificadores <Vetor> Incrementador ';'
        RULE_ESCREVA_ESCREVA_LPAREN_RPAREN_SEMI                                  = 54, // <escreva> ::= escreva '(' <Param Escrita> ')' ';'
        RULE_PARAMESCRITA                                                        = 55, // <Param Escrita> ::= <verificaCaso> <MaisParametroE>
        RULE_MAISPARAMETROE_COMMA                                                = 56, // <MaisParametroE> ::= ',' <Param Escrita>
        RULE_MAISPARAMETROE                                                      = 57, // <MaisParametroE> ::= 
        RULE_LEIA_LEIA_LPAREN_RPAREN_SEMI                                        = 58, // <leia> ::= leia '(' <conteudoLeia> ')' ';'
        RULE_CONTEUDOLEIA_IDENTIFICADORES                                        = 59, // <conteudoLeia> ::= Identificadores <Vetor> <lerMais>
        RULE_LERMAIS_COMMA                                                       = 60, // <lerMais> ::= ',' <conteudoLeia>
        RULE_LERMAIS                                                             = 61, // <lerMais> ::= 
        RULE_NEGAR_EXCLAM                                                        = 62, // <negar> ::= '!'
        RULE_NEGAR                                                               = 63, // <negar> ::= 
        RULE_MAISCOND_OPERADORESLOGICOS                                          = 64, // <maisCond> ::= OperadoresLogicos <cond> <maisCond>
        RULE_MAISCOND                                                            = 65, // <maisCond> ::= 
        RULE_SE_SE_ENTAO_LBRACE_RBRACE                                           = 66, // <se> ::= se <condse> entao '{' <blocoSe> '}' <senao>
        RULE_CONDSE_LPAREN_RPAREN                                                = 67, // <condse> ::= '(' <cond> <maisCond> ')'
        RULE_COND_OPERADORESRELACIONAIS                                          = 68, // <cond> ::= <termo> OperadoresRelacionais <termo>
        RULE_COND_IDENTIFICADORES                                                = 69, // <cond> ::= <negar> Identificadores <Vetor>
        RULE_TIPOTERMO_IDENTIFICADORES                                           = 70, // <tipoTermo> ::= Identificadores <Vetor>
        RULE_TIPOTERMO_NUMEROS                                                   = 71, // <tipoTermo> ::= Numeros
        RULE_TIPOTERMO_CADEIACARACTERES                                          = 72, // <tipoTermo> ::= CadeiaCaracteres
        RULE_TIPOTERMO_TIPOBOOLEANO                                              = 73, // <tipoTermo> ::= TipoBooleano
        RULE_TERMO                                                               = 74, // <termo> ::= <tipoTermo> <op>
        RULE_OP_OPERADORARITMETICOS                                              = 75, // <op> ::= OperadorAritmeticos <tipoTermo> <op>
        RULE_OP                                                                  = 76, // <op> ::= 
        RULE_BLOCOSE                                                             = 77, // <blocoSe> ::= <comandos> <blocoSe>
        RULE_BLOCOSE2                                                            = 78, // <blocoSe> ::= 
        RULE_CONDSENAO_ENTAO                                                     = 79, // <condSenao> ::= <condse> entao
        RULE_CONDSENAO                                                           = 80, // <condSenao> ::= 
        RULE_SENAO                                                               = 81, // <senao> ::= 
        RULE_SENAO_SENAO_LBRACE_RBRACE                                           = 82, // <senao> ::= senao <condSenao> '{' <blocoSe> '}'
        RULE_COMANDOS                                                            = 83, // <comandos> ::= <leia>
        RULE_COMANDOS2                                                           = 84, // <comandos> ::= <escreva>
        RULE_COMANDOS3                                                           = 85, // <comandos> ::= <se>
        RULE_COMANDOS4                                                           = 86, // <comandos> ::= <enquanto>
        RULE_COMANDOS5                                                           = 87, // <comandos> ::= <atribuicaoDeVariavel>
        RULE_COMANDOS_SEMI                                                       = 88, // <comandos> ::= <chamadaDeMetodo> ';'
        RULE_COMANDOS6                                                           = 89, // <comandos> ::= <incrementador>
        RULE_COMANDOS_RESULTADO_SEMI                                             = 90, // <comandos> ::= resultado <retorno> ';'
        RULE_RETORNO                                                             = 91, // <retorno> ::= <verificaCaso>
        RULE_RETORNO2                                                            = 92, // <retorno> ::= 
        RULE_METODO_METODO_IDENTIFICADORES_LPAREN_RPARENCOLON_TIPO_LBRACE_RBRACE = 93, // <metodo> ::= metodo Identificadores '(' <listaParametros> '):' Tipo '{' <DeclaracaoVariaveis> <escopoMetodo> '}'
        RULE_LISTAPARAMETROS_TIPO_IDENTIFICADORES                                = 94, // <listaParametros> ::= Tipo Identificadores <maisParametros>
        RULE_LISTAPARAMETROS                                                     = 95, // <listaParametros> ::= 
        RULE_MAISPARAMETROS_COMMA                                                = 96, // <maisParametros> ::= ',' <listaParametros>
        RULE_MAISPARAMETROS                                                      = 97, // <maisParametros> ::= 
        RULE_CHAMADADEMETODO_IDENTIFICADORES_LPAREN_RPAREN                       = 98, // <chamadaDeMetodo> ::= Identificadores '(' <var> ')'
        RULE_VAR_IDENTIFICADORES                                                 = 99, // <var> ::= Identificadores <Vetor> <maisVariavel>
        RULE_VAR                                                                 = 100, // <var> ::= <metodoParametro>
        RULE_VAR2                                                                = 101, // <var> ::= 
        RULE_MAISVARIAVEL_COMMA                                                  = 102, // <maisVariavel> ::= ',' <var>
        RULE_MAISVARIAVEL                                                        = 103, // <maisVariavel> ::= 
        RULE_METODOPARAMETRO_IDENTIFICADORES_LPAREN_RPAREN                       = 104, // <metodoParametro> ::= Identificadores '(' <var> ')' <maisVariavel>
        RULE_ESCOPOMETODO                                                        = 105, // <escopoMetodo> ::= <comandos> <escopoMetodo>
        RULE_ESCOPOMETODO2                                                       = 106, // <escopoMetodo> ::= 
        RULE_ENQUANTO_ENQUANTO_LPAREN_RPAREN_LBRACE_RBRACE                       = 107, // <enquanto> ::= enquanto '(' <operacao_relacional> ')' '{' <conteudo_laco> '}'
        RULE_OPERACAO_RELACIONAL_OPERADORESRELACIONAIS                           = 108, // <operacao_relacional> ::= <complemento_operador> OperadoresRelacionais <complemento_operador>
        RULE_OPERACAO_RELACIONAL_IDENTIFICADORES                                 = 109, // <operacao_relacional> ::= <negar> Identificadores <Vetor>
        RULE_COMPLEMENTO_OPERADOR_IDENTIFICADORES                                = 110, // <complemento_operador> ::= Identificadores <Vetor>
        RULE_COMPLEMENTO_OPERADOR_NUMEROS                                        = 111, // <complemento_operador> ::= Numeros
        RULE_COMPLEMENTO_OPERADOR_CADEIACARACTERES                               = 112, // <complemento_operador> ::= CadeiaCaracteres
        RULE_COMPLEMENTO_OPERADOR_TIPOBOOLEANO                                   = 113, // <complemento_operador> ::= TipoBooleano
        RULE_CONTEUDO_LACO                                                       = 114, // <conteudo_laco> ::= <comandos> <conteudo_laco>
        RULE_CONTEUDO_LACO2                                                      = 115  // <conteudo_laco> ::= 
    };

    public class MyParser
    {
        private LALRParser parser;

        public MyParser(string filename)
        {
            FileStream stream = new FileStream(filename,
                                               FileMode.Open, 
                                               FileAccess.Read, 
                                               FileShare.Read);
            Init(stream);
            stream.Close();
        }

        public MyParser(string baseName, string resourceName)
        {
            byte[] buffer = ResourceUtil.GetByteArrayResource(
                System.Reflection.Assembly.GetExecutingAssembly(),
                baseName,
                resourceName);
            MemoryStream stream = new MemoryStream(buffer);
            Init(stream);
            stream.Close();
        }

        public MyParser(Stream stream)
        {
            Init(stream);
        }

        private void Init(Stream stream)
        {
            CGTReader reader = new CGTReader(stream);
            parser = reader.CreateNewParser();
            parser.TrimReductions = false;
            parser.StoreTokens = LALRParser.StoreTokensMode.NoUserObject;

            parser.OnReduce += new LALRParser.ReduceHandler(ReduceEvent);
            parser.OnTokenRead += new LALRParser.TokenReadHandler(TokenReadEvent);
            parser.OnAccept += new LALRParser.AcceptHandler(AcceptEvent);
            parser.OnTokenError += new LALRParser.TokenErrorHandler(TokenErrorEvent);
            parser.OnParseError += new LALRParser.ParseErrorHandler(ParseErrorEvent);
        }

        public void Parse(string source)
        {
            parser.Parse(source);

        }

        private void TokenReadEvent(LALRParser parser, TokenReadEventArgs args)
        {
            try
            {
                args.Token.UserObject = CreateObject(args.Token);
            }
            catch (Exception e)
            {
                args.Continue = false;
                //todo: Report message to UI?
            }
        }

        private Object CreateObject(TerminalToken token)
        {
            switch (token.Symbol.Id)
            {
                case (int)SymbolConstants.SYMBOL_EOF :
                //(EOF)
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_ERROR :
                //(Error)
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_WHITESPACE :
                //Whitespace
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_EXCLAM :
                //'!'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_LPAREN :
                //'('
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_RPAREN :
                //')'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_RPARENCOLON :
                //'):'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_COMMA :
                //','
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_SEMI :
                //';'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_LBRACKET :
                //'['
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_RBRACKET :
                //']'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_LBRACE :
                //'{'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_RBRACE :
                //'}'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_EQ :
                //'='
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_CADEIACARACTERES :
                //CadeiaCaracteres
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_CONSTANTES :
                //constantes
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_ENQUANTO :
                //enquanto
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_ENTAO :
                //entao
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_ESCREVA :
                //escreva
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_IDENTIFICADORES :
                //Identificadores
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_INCREMENTADOR :
                //Incrementador
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_LEIA :
                //leia
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_METODO :
                //metodo
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_NUMEROS :
                //Numeros
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_OPERADORARITMETICOS :
                //OperadorAritmeticos
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_OPERADORESARITMETICOS :
                //OperadoresAritmeticos
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_OPERADORESLOGICOS :
                //OperadoresLogicos
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_OPERADORESRELACIONAIS :
                //OperadoresRelacionais
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_PROGRAMA :
                //programa
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_RESULTADO :
                //resultado
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_SE :
                //se
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_SENAO :
                //senao
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_TIPO :
                //Tipo
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_TIPOBOOLEANO :
                //TipoBooleano
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_VARIAVEIS :
                //variaveis
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_ATRIBUICAODEVARIAVEL :
                //<atribuicaoDeVariavel>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_BLOCOCONSTANTES :
                //<blocoConstantes>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_BLOCOSE :
                //<blocoSe>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_BOOLEANO :
                //<booleano>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_CHAMADADEMETODO :
                //<chamadaDeMetodo>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_COMANDOS :
                //<comandos>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_COMPLEMENTO_OPERADOR :
                //<complemento_operador>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_COMPLEMENTOV :
                //<complementoV>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_COND :
                //<cond>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_CONDSE :
                //<condse>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_CONDSENAO :
                //<condSenao>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_CONSTANTE :
                //<constante>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_CONSTANTES2 :
                //<constantes>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_CONTEUDO_LACO :
                //<conteudo_laco>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_CONTEUDOLEIA :
                //<conteudoLeia>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_DECLARACAOVARIAVEIS :
                //<DeclaracaoVariaveis>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_ENQUANTO2 :
                //<enquanto>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_ESCOPOMETODO :
                //<escopoMetodo>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_ESCOPOPROGRAMA :
                //<escopoPrograma>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_ESCREVA2 :
                //<escreva>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_ESTRUTURA_CONSTANTE :
                //<estrutura_constante>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_EXPRESSAO :
                //<expressao>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_INCREMENTADOR2 :
                //<incrementador>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_INCREMENTO :
                //<incremento>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_LEIA2 :
                //<leia>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_LERMAIS :
                //<lerMais>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_LISTAPARAMETROS :
                //<listaParametros>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_MAISCOND :
                //<maisCond>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_MAISOPERACOES :
                //<maisOperacoes>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_MAISPARAMETROE :
                //<MaisParametroE>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_MAISPARAMETROS :
                //<maisParametros>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_MAISVARIAVEIS :
                //<MaisVariaveis>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_MAISVARIAVEL :
                //<maisVariavel>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_MATRIZ :
                //<Matriz>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_METODO2 :
                //<metodo>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_METODOPARAMETRO :
                //<metodoParametro>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_MULTIPLASCONSTANTES :
                //<multiplasConstantes>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_NEGAR :
                //<negar>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_OP :
                //<op>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_OPERACAO_RELACIONAL :
                //<operacao_relacional>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_OPERADOR :
                //<operador>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_OPI2 :
                //<OpI2>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_OPINDICE :
                //<OpIndice>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_PARAMESCRITA :
                //<Param Escrita>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_PROGRAMA2 :
                //<programa>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_RETORNO :
                //<retorno>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_SE2 :
                //<se>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_SENAO2 :
                //<senao>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_TERMO :
                //<termo>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_TIPOTERMO :
                //<tipoTermo>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_VAR :
                //<var>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_VARIAVELMESMOTIPO :
                //<variavelMesmoTipo>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_VARV :
                //<VarV>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_VERIFICACASO :
                //<verificaCaso>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_VETOR :
                //<Vetor>
                //todo: Create a new object that corresponds to the symbol
                return null;

            }
            throw new SymbolException("Unknown symbol");
        }

        private void ReduceEvent(LALRParser parser, ReduceEventArgs args)
        {
            try
            {
                args.Token.UserObject = CreateObject(args.Token);
            }
            catch (Exception e)
            {
                args.Continue = false;
                //todo: Report message to UI?
            }
        }

        public static Object CreateObject(NonterminalToken token)
        {
            switch (token.Rule.Id)
            {
                case (int)RuleConstants.RULE_OPINDICE_OPERADORESARITMETICOS :
                //<OpIndice> ::= OperadoresAritmeticos <OpI2> <OpIndice>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_OPINDICE :
                //<OpIndice> ::= 
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_OPI2_NUMEROS :
                //<OpI2> ::= Numeros
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_OPI2_IDENTIFICADORES :
                //<OpI2> ::= Identificadores
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_VETOR_LBRACKET_RBRACKET :
                //<Vetor> ::= '[' <OpI2> <OpIndice> ']' <Matriz>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_VETOR :
                //<Vetor> ::= 
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_MATRIZ_LBRACKET_RBRACKET :
                //<Matriz> ::= '[' <OpI2> <OpIndice> ']'
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_MATRIZ :
                //<Matriz> ::= 
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_PROGRAMA_PROGRAMA_LBRACE_RBRACE :
                //<programa> ::= programa '{' <blocoConstantes> <escopoPrograma> '}'
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_ESCOPOPROGRAMA :
                //<escopoPrograma> ::= <metodo> <escopoPrograma>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_ESCOPOPROGRAMA2 :
                //<escopoPrograma> ::= 
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_DECLARACAOVARIAVEIS_VARIAVEIS_LBRACE_RBRACE :
                //<DeclaracaoVariaveis> ::= variaveis '{' <VarV> '}'
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_DECLARACAOVARIAVEIS :
                //<DeclaracaoVariaveis> ::= 
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_VARV_TIPO :
                //<VarV> ::= Tipo <complementoV> <MaisVariaveis>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_COMPLEMENTOV_IDENTIFICADORES :
                //<complementoV> ::= Identificadores <Vetor> <variavelMesmoTipo>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_VARIAVELMESMOTIPO_COMMA :
                //<variavelMesmoTipo> ::= ',' <complementoV>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_VARIAVELMESMOTIPO_SEMI :
                //<variavelMesmoTipo> ::= ';'
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_MAISVARIAVEIS :
                //<MaisVariaveis> ::= <VarV>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_MAISVARIAVEIS2 :
                //<MaisVariaveis> ::= 
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_BLOCOCONSTANTES_CONSTANTES_LBRACE_RBRACE :
                //<blocoConstantes> ::= constantes '{' <estrutura_constante> '}'
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_BLOCOCONSTANTES :
                //<blocoConstantes> ::= 
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_ESTRUTURA_CONSTANTE_TIPO_SEMI :
                //<estrutura_constante> ::= Tipo <constantes> ';' <estrutura_constante>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_ESTRUTURA_CONSTANTE :
                //<estrutura_constante> ::= 
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_CONSTANTES_IDENTIFICADORES_EQ :
                //<constantes> ::= Identificadores '=' <constante> <multiplasConstantes>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_CONSTANTES_IDENTIFICADORES_EQ2 :
                //<constantes> ::= Identificadores '=' <constante>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_MULTIPLASCONSTANTES_COMMA :
                //<multiplasConstantes> ::= ',' <constantes>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_CONSTANTE_IDENTIFICADORES :
                //<constante> ::= Identificadores
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_CONSTANTE_CADEIACARACTERES :
                //<constante> ::= CadeiaCaracteres
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_CONSTANTE_NUMEROS :
                //<constante> ::= Numeros
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_ATRIBUICAODEVARIAVEL_IDENTIFICADORES_EQ_SEMI :
                //<atribuicaoDeVariavel> ::= Identificadores <Vetor> '=' <verificaCaso> ';'
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_VERIFICACASO :
                //<verificaCaso> ::= <incremento>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_VERIFICACASO2 :
                //<verificaCaso> ::= <expressao>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_VERIFICACASO3 :
                //<verificaCaso> ::= <booleano>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_INCREMENTO_LPAREN_INCREMENTADOR_IDENTIFICADORES_RPAREN :
                //<incremento> ::= '(' Incrementador Identificadores <Vetor> ')'
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_INCREMENTO_LPAREN_IDENTIFICADORES_INCREMENTADOR_RPAREN :
                //<incremento> ::= '(' Identificadores <Vetor> Incrementador ')'
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_INCREMENTO_INCREMENTADOR_IDENTIFICADORES :
                //<incremento> ::= Incrementador Identificadores <Vetor>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_INCREMENTO_IDENTIFICADORES_INCREMENTADOR :
                //<incremento> ::= Identificadores <Vetor> Incrementador
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_BOOLEANO_LPAREN_TIPOBOOLEANO_RPAREN :
                //<booleano> ::= '(' TipoBooleano ')'
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_BOOLEANO_LPAREN_EXCLAM_TIPOBOOLEANO_RPAREN :
                //<booleano> ::= '(' '!' TipoBooleano ')'
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_BOOLEANO_LPAREN_EXCLAM_IDENTIFICADORES_RPAREN :
                //<booleano> ::= '(' '!' Identificadores <Vetor> ')'
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_BOOLEANO_TIPOBOOLEANO :
                //<booleano> ::= TipoBooleano
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_BOOLEANO_EXCLAM_TIPOBOOLEANO :
                //<booleano> ::= '!' TipoBooleano
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_BOOLEANO_EXCLAM_IDENTIFICADORES :
                //<booleano> ::= '!' Identificadores <Vetor>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_EXPRESSAO_LPAREN_RPAREN :
                //<expressao> ::= '(' <expressao> ')'
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_EXPRESSAO_LPAREN_RPAREN_OPERADORESARITMETICOS :
                //<expressao> ::= '(' <expressao> ')' OperadoresAritmeticos <expressao>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_EXPRESSAO :
                //<expressao> ::= <operador> <maisOperacoes>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_MAISOPERACOES_OPERADORESARITMETICOS :
                //<maisOperacoes> ::= OperadoresAritmeticos <maisOperacoes>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_MAISOPERACOES_OPERADORESARITMETICOS2 :
                //<maisOperacoes> ::= OperadoresAritmeticos <expressao>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_MAISOPERACOES :
                //<maisOperacoes> ::= 
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_OPERADOR_NUMEROS :
                //<operador> ::= Numeros
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_OPERADOR_CADEIACARACTERES :
                //<operador> ::= CadeiaCaracteres
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_OPERADOR_IDENTIFICADORES :
                //<operador> ::= Identificadores <Vetor>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_OPERADOR :
                //<operador> ::= <chamadaDeMetodo>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_INCREMENTADOR_IDENTIFICADORES_INCREMENTADOR_SEMI :
                //<incrementador> ::= Identificadores <Vetor> Incrementador ';'
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_ESCREVA_ESCREVA_LPAREN_RPAREN_SEMI :
                //<escreva> ::= escreva '(' <Param Escrita> ')' ';'
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_PARAMESCRITA :
                //<Param Escrita> ::= <verificaCaso> <MaisParametroE>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_MAISPARAMETROE_COMMA :
                //<MaisParametroE> ::= ',' <Param Escrita>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_MAISPARAMETROE :
                //<MaisParametroE> ::= 
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_LEIA_LEIA_LPAREN_RPAREN_SEMI :
                //<leia> ::= leia '(' <conteudoLeia> ')' ';'
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_CONTEUDOLEIA_IDENTIFICADORES :
                //<conteudoLeia> ::= Identificadores <Vetor> <lerMais>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_LERMAIS_COMMA :
                //<lerMais> ::= ',' <conteudoLeia>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_LERMAIS :
                //<lerMais> ::= 
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_NEGAR_EXCLAM :
                //<negar> ::= '!'
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_NEGAR :
                //<negar> ::= 
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_MAISCOND_OPERADORESLOGICOS :
                //<maisCond> ::= OperadoresLogicos <cond> <maisCond>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_MAISCOND :
                //<maisCond> ::= 
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_SE_SE_ENTAO_LBRACE_RBRACE :
                //<se> ::= se <condse> entao '{' <blocoSe> '}' <senao>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_CONDSE_LPAREN_RPAREN :
                //<condse> ::= '(' <cond> <maisCond> ')'
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_COND_OPERADORESRELACIONAIS :
                //<cond> ::= <termo> OperadoresRelacionais <termo>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_COND_IDENTIFICADORES :
                //<cond> ::= <negar> Identificadores <Vetor>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_TIPOTERMO_IDENTIFICADORES :
                //<tipoTermo> ::= Identificadores <Vetor>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_TIPOTERMO_NUMEROS :
                //<tipoTermo> ::= Numeros
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_TIPOTERMO_CADEIACARACTERES :
                //<tipoTermo> ::= CadeiaCaracteres
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_TIPOTERMO_TIPOBOOLEANO :
                //<tipoTermo> ::= TipoBooleano
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_TERMO :
                //<termo> ::= <tipoTermo> <op>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_OP_OPERADORARITMETICOS :
                //<op> ::= OperadorAritmeticos <tipoTermo> <op>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_OP :
                //<op> ::= 
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_BLOCOSE :
                //<blocoSe> ::= <comandos> <blocoSe>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_BLOCOSE2 :
                //<blocoSe> ::= 
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_CONDSENAO_ENTAO :
                //<condSenao> ::= <condse> entao
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_CONDSENAO :
                //<condSenao> ::= 
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_SENAO :
                //<senao> ::= 
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_SENAO_SENAO_LBRACE_RBRACE :
                //<senao> ::= senao <condSenao> '{' <blocoSe> '}'
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_COMANDOS :
                //<comandos> ::= <leia>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_COMANDOS2 :
                //<comandos> ::= <escreva>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_COMANDOS3 :
                //<comandos> ::= <se>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_COMANDOS4 :
                //<comandos> ::= <enquanto>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_COMANDOS5 :
                //<comandos> ::= <atribuicaoDeVariavel>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_COMANDOS_SEMI :
                //<comandos> ::= <chamadaDeMetodo> ';'
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_COMANDOS6 :
                //<comandos> ::= <incrementador>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_COMANDOS_RESULTADO_SEMI :
                //<comandos> ::= resultado <retorno> ';'
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_RETORNO :
                //<retorno> ::= <verificaCaso>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_RETORNO2 :
                //<retorno> ::= 
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_METODO_METODO_IDENTIFICADORES_LPAREN_RPARENCOLON_TIPO_LBRACE_RBRACE :
                //<metodo> ::= metodo Identificadores '(' <listaParametros> '):' Tipo '{' <DeclaracaoVariaveis> <escopoMetodo> '}'
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_LISTAPARAMETROS_TIPO_IDENTIFICADORES :
                //<listaParametros> ::= Tipo Identificadores <maisParametros>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_LISTAPARAMETROS :
                //<listaParametros> ::= 
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_MAISPARAMETROS_COMMA :
                //<maisParametros> ::= ',' <listaParametros>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_MAISPARAMETROS :
                //<maisParametros> ::= 
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_CHAMADADEMETODO_IDENTIFICADORES_LPAREN_RPAREN :
                //<chamadaDeMetodo> ::= Identificadores '(' <var> ')'
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_VAR_IDENTIFICADORES :
                //<var> ::= Identificadores <Vetor> <maisVariavel>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_VAR :
                //<var> ::= <metodoParametro>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_VAR2 :
                //<var> ::= 
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_MAISVARIAVEL_COMMA :
                //<maisVariavel> ::= ',' <var>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_MAISVARIAVEL :
                //<maisVariavel> ::= 
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_METODOPARAMETRO_IDENTIFICADORES_LPAREN_RPAREN :
                //<metodoParametro> ::= Identificadores '(' <var> ')' <maisVariavel>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_ESCOPOMETODO :
                //<escopoMetodo> ::= <comandos> <escopoMetodo>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_ESCOPOMETODO2 :
                //<escopoMetodo> ::= 
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_ENQUANTO_ENQUANTO_LPAREN_RPAREN_LBRACE_RBRACE :
                //<enquanto> ::= enquanto '(' <operacao_relacional> ')' '{' <conteudo_laco> '}'
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_OPERACAO_RELACIONAL_OPERADORESRELACIONAIS :
                //<operacao_relacional> ::= <complemento_operador> OperadoresRelacionais <complemento_operador>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_OPERACAO_RELACIONAL_IDENTIFICADORES :
                //<operacao_relacional> ::= <negar> Identificadores <Vetor>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_COMPLEMENTO_OPERADOR_IDENTIFICADORES :
                //<complemento_operador> ::= Identificadores <Vetor>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_COMPLEMENTO_OPERADOR_NUMEROS :
                //<complemento_operador> ::= Numeros
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_COMPLEMENTO_OPERADOR_CADEIACARACTERES :
                //<complemento_operador> ::= CadeiaCaracteres
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_COMPLEMENTO_OPERADOR_TIPOBOOLEANO :
                //<complemento_operador> ::= TipoBooleano
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_CONTEUDO_LACO :
                //<conteudo_laco> ::= <comandos> <conteudo_laco>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_CONTEUDO_LACO2 :
                //<conteudo_laco> ::= 
                //todo: Create a new object using the stored user objects.
                return null;

            }
            throw new RuleException("Unknown rule");
        }

        private void AcceptEvent(LALRParser parser, AcceptEventArgs args)
        {
            //todo: Use your fully reduced args.Token.UserObject
        }

        private void TokenErrorEvent(LALRParser parser, TokenErrorEventArgs args)
        {
            string message = "Token error with input: '"+args.Token.ToString()+"'";
            //todo: Report message to UI?
        }

        private void ParseErrorEvent(LALRParser parser, ParseErrorEventArgs args)
        {
            string message = "Parse error caused by token: '"+args.UnexpectedToken.ToString()+"'";
            //todo: Report message to UI?
        }


    }
}
