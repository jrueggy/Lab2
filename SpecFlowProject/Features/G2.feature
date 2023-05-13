Feature: G2

Consulta saldo

@tag1
Scenario: Consulta saldo
	Given Una cuenta de usuario con <montoInicial> soles de saldo
	When Se consulta el saldo de la cuenta
	Then Se muestra que el saldo de la cuenta es <montoInicial>

Examples: Montos
	| montoInicial | montoConsultado |
	| 10          | 10             |
	| 999          | 999             |
	| 982          | 982             |
