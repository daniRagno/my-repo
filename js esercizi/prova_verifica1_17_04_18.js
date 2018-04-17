const fetch = require('node-fetch');

const accreditamento = () => {
	fetch('http://192.168.1.231:8000/accreditamento', {
		method: 'POST',
		headers: {
			 'content-type': 'application/json'
		},
		body: JSON.stringify({
			nome: 'Daniele Maria Ragno' 
		})
	  })
	.then(res => res.json())
  	.then(data => console.log(data))
  	.catch(console.log)
}

const es1 = () => {
	fetch('http://192.168.1.231:8000/esercizi/1')
	.then(res => res.json())
	.then(({message, data}) => {
		console.log(message);
   		console.log(data);
   		const result = data.reduce ((acc, e)=> acc + e, 0)
   		console.log(result);
   		return fetch ('http://192.168.1.231:8000/esercizi/1', {
   			method: 'POST',
   			headers: {'content-type': 'application/json'
   			},
   			body: JSON.stringify({
   				data:result
   			})	
   		})	
	})	
}

accreditamento();

es1();