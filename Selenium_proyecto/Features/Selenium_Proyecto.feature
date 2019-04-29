Feature: Selenium_Proyecto


@Chrome
Scenario: el usuario desea abrir un navegador 
	Given el usuario navega a la url " http://automationpractice.com/"
	When el usuario ingresa la palabra "dresses" en la unica caja de texto de busqueda
	And el usuario hace click en el boton de buscar producto
	And el usuario sobrepone el mouse en el  PRIMER vestido deseado
	And el usuario agrega al PRIMER vestido a la opción compare
	And el usuario sobrepone el mouse en el  SEGUNDO vestido deseado
	And el usuario agrega al SEGUNDO vestido a la opción compare
	And el usuario hace click en el boton de comparar
	Then Verificar que el PRIMER vestido sea su precio "26.00" dolares
	And Verificar que el SEGUNDO vestido sea su precio "16.51" dolares
