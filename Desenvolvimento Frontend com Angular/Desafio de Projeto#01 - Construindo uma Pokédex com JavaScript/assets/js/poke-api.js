const url = "https://pokeapi.co/api/v2/pokemon/1/"

fetch(url)
    .then(function(response) {
        return response.json()
    })
    .then(function (jsonBody) {
        console.log(jsonBody)
    })
    .catch(function (error) {
        console.log(error)
    })
    .finally(function () {
        console.log("Requisição está sendo um sucesso!")
    })