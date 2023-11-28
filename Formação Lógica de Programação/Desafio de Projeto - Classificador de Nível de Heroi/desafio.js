//#01 - Desafio Classificador de nível de Herói

let listaDeHerois = [["Jailson", 8000], ["Edevai", 3000], ["Jamesson", 10002]]

listaDeHerois.forEach(heroi => {
    switch (true) {
        case heroi[1] < 1000:
            heroi.push("Ferro")            
            break;
        case heroi[1] <= 2000:
            heroi.push("Bronze")          
            break;
        case heroi[1] <= 5000:
            heroi.push("Prata")       
            break;
        case heroi[1] <= 7000:
            heroi.push("Ouro")         
            break;
        case heroi[1] <= 8000:
            heroi.push("Platina")            
            break;
        case heroi[1] <= 9000:
            heroi.push("Ascendente")            
            break;
        case heroi[1] <= 10000:
            heroi.push("Imortal")       
            break;
        default:
            heroi.push("Radiante") 
            break;
    }
    console.log(`O Herói de nome ${heroi[0]} está no nível de ${heroi[2]}"`)
});
