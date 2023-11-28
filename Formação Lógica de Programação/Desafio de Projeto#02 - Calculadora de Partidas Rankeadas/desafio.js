let qtdVitorias = 100
let qtdDerrotas = 30
let nivel = ""

let saldoDeRankeadas = calcularSaldoDeRankeadas(qtdVitorias, qtdDerrotas)

switch (true) {
    case qtdVitorias < 10:
        nivel = "Ferro"
        break;
    case qtdVitorias <= 20:
        nivel = "Bronze"
        break;
    case qtdVitorias <= 50:
        nivel = "Prata"
        break;
    case qtdVitorias <= 80:
        nivel = "Ouro"
        break;
    case qtdVitorias <= 90:
        nivel = "Diamante"
        break;
    case qtdVitorias <= 100:
        nivel = "Lendário"
        break;
    default:
        nivel = "Imortal"
        break;
}

function calcularSaldoDeRankeadas(vitorias, derrotas) {
    return vitorias - derrotas
}
console.log(`O Herói tem de saldo de ${saldoDeRankeadas} está no nível de ${nivel}`)
