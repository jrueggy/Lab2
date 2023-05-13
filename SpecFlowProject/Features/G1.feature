Feature: G1

Realizar una transacción

Background:
	Given Una cuenta del usuario con 100 soles de saldo
	And Una cuenta del vendedor con 1000 soles de saldo

@tag1

Scenario Outline: Realizar una transacción - con saldo
	When usuario compra artículo de 17 soles de valor
	Then el resultado de la transaccion es True
	And usuario tiene 83 soles de saldo
	And vendedor tiene 1017 soles de saldo


Scenario Outline: Realizar una transacción - sin saldo suficiente
	When usuario compra artículo de 170 soles de valor
	Then el resultado de la transaccion es False
	And usuario tiene 100 soles de saldo