/*
 * Esperado que em 1/3 das vezes ficar na porta faça o jogador ganhar
 * e que em 2/3 das vezes trocar de porta faça o jogador ganhar.
 * Ou seja, ao trocar de porta as chances de ganhar dobram, chegando a 66%
 */

var acertariaMudando = 0;
var acertariaFicando = 0;

for (int i = 0; i < 1_000_000; i++) Simular();
Console.WriteLine("Fica na porta: " + acertariaFicando);
Console.WriteLine("Muda de porta: " + acertariaMudando);

void Simular()
{
    // São 3 portas fechadas, atrás de uma delas tem um prêmio!
    var portaPremiada = Sortear();

    // O jogador escolhe uma porta
    var primeiraEscolha = Sortear();

    // O apresentador abre uma das outras duas portas, e o premio não está na porta aberta
    var portaAberta = Sortear(primeiraEscolha, portaPremiada);

    // O que aconteceria em cada situação
    if (primeiraEscolha == portaPremiada) acertariaFicando++;
    else acertariaMudando++;
}


int Sortear(params int[] excexoes)
{
    int sorteada;
    do sorteada = Random.Shared.Next(0, 3);
    while(excexoes.Contains(sorteada));
    return sorteada;
}