# api.braspag

A api está projetada para receber as seguintes requisições: 

- via GET através da URL: http://apibraspag.azurewebsites.net/api/home/mdr
Essa requisição retorna a tabela de Merchant Discount Rates(MDR).


- via POST através da URL: http://apibraspag.azurewebsites.net/api/home/transaction
Essa requisição precisa receber parâmetros em formato JSON através do Body e então retornará o ValorLiquido.
Os parâmetros devem ser: Valor, Adquirente, Bandeira e Tipo.
O retorno será: ValorLiquido.

Exemplo:
	{
		"Valor": 100.00,
		"Adquirente": "A",
		"Bandeira": "Visa",
		"Tipo": "Credito"
	}

	{
		"ValorLiquido": 97.75
	}


OBS: Utilizar postman para testes