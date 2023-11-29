// #03 - Desafio Escrevendo as Classes de um Jogo

class Heroi {
    constructor(nome, idade, tipo) {
        this.nome = nome;
        this.idade = idade;
        this.tipo = tipo;
    }

    attack() {
        let msgAtaque = "";

        switch (true) {
            case this.tipo === "mago":
                msgAtaque = "magia"      
                break;
            case this.tipo === "guerreiro":
                msgAtaque = "espada"      
                break;
            case this.tipo === "monge":
                msgAtaque = "artes marciais"      
                break;
            default:
                msgAtaque = "shuriken"
                break;
        }
        console.log(`o ${this.tipo} atacou usando ${msgAtaque}`);
    }
}

let player = new Heroi("Mateus", 29, "mago")
let player01 = new Heroi("helena", 32, "guerreiro")
let player02 = new Heroi("joao", 8, "monge")
let player03 = new Heroi("estefane", 52, "ninja")

player.attack()
player01.attack()
player02.attack()
player03.attack()
