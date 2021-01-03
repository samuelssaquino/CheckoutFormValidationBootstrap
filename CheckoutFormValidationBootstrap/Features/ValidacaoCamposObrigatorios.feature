Feature: Validacao Campos Obrigatórios Bootstrap
	
	Validacao Campos Obrigatórios Bootstrap

Scenario: Validacao Campos Obrigatórios Bootstrap
	Given eu acesso a pagina "https://getbootstrap.com/docs/4.5/examples/checkout/?"
	Then o titulo da pagina deve ser "Checkout example · Bootstrap"
	When clico no botao Continue to Checkout
	Then a validacao do campo First name deve ser "Valid first name is required."
	Then a validacao do campo Last name deve ser "Valid last name is required."
	Then a validacao do campo Username deve ser "Your username is required."
	Then a validacao do campo Address deve ser "Please enter your shipping address."
	Then a validacao do campo Country deve ser "Please select a valid country."
	Then a validacao do campo State deve ser "Please provide a valid state."
	Then a validacao do campo Zip deve ser "Zip code required."
	Then a validacao do campo Name on card deve ser "Name on card is required"
	Then a validacao do campo Credit card number deve ser "Credit card number is required"
	Then a validacao do campo Expiration deve ser "Expiration date required"
	Then a validacao do campo CVV deve ser "Security code required"