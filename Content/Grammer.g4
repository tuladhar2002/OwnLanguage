grammar Grammer;

program: line* EOF; // program is a list of lines // tsarts here

line: statement | ifBlock | whileBlock;

statement: (assignment | printStatement)';';

ifBlock: 'if' expression block ('else' elseIfBlock);

elseIfBlock: block | ifBlock;

block: '{' line* '}';

whileBlock: WHILE expression block ('else' elseIfBlock);

WHILE: 'while' | 'until';

assignment: IDENTIFIER IS_ASSIGN expression | IDENTIFIER '=' expression;
printStatement: 'show yourself' '(' expression ')';

functionCall: IDENTIFIER '(' (expression (',' expression)*)? ')';

expression
    : constant                              # constantExpression    
    | IDENTIFIER                            # identifierExpression  
    | functionCall                          # functionCallExpression
    | '(' expression ')'                    # parenExpression
    | '!'expression                         # notExpression
    | expression mult_op expression         # multExpression    
    | expression add_op expression          # addExpression
    | expression comp_op expression         # compExpression    
    | expression bool_op expression         # boolExpression
    ;
    

//define order of expressions
mult_op: '*' | '/' | '%' | 'times' | 'divided by' | 'modulus';
add_op: '+' | '-' | 'plus' | 'minus';
comp_op: '==' | '!=' | '<' | '<=' | '>' | '>=' | 'is equal to' | 'is not equal to' | 'is less than' | 'is less than or equal to' | 'is greater than' | 'is greater than or equal to';
bool_op: BOOL_OPERATOR;

BOOL_OPERATOR: 'and' | 'or';


constant: INTEGER | FLOAT | STRING | BOOLEAN | NULL;

INTEGER: [0-9]+;
FLOAT: [0-9]+'.'[0-9]+;
STRING: ('"' ~'"'* '"') | ('\'' ~'\''* '\'');
NULL: 'null';
BOOLEAN: 'true' | 'false';
WS: [ \t\r\n]+ -> skip;
IDENTIFIER: [a-zA-Z_][a-zA-Z0-9_]*;

IS_ASSIGN: '->';
Comment: '//';








