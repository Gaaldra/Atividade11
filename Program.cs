// Numeros
// Textos

int VerificarInteiro()
{
	// Subescopo VerificarInteiro
	string? entrada;
	bool converteu;
	int numero;
	do
	{
		Console.WriteLine("Digite um número: ");
		entrada = Console.ReadLine();
		converteu = int.TryParse(entrada, out numero);
	} while (!converteu);
	return numero;
}

// Escopo global
int valor1 = VerificarInteiro();
int valor2 = VerificarInteiro();
int resultado = valor1 + valor2;
Console.WriteLine($"O resultado é {resultado}");

/* Criar um método chamado VerificaTexto()
 * Retorna uma string
 * Duas variaveis no subescopo VerificaTexto: entrada (string) e estaVazia (bool)
 * Peça ao usuário que digite um texto e salve a entrada do usuário na variavel entrada
 * Use o string.IsNullOrWhiteSpace(argumento) passando a entrada como argumento
 * Salve o retorno do metodo acima dentro de estaVazia
 * Repita enquanto (While) estaVazia for verdadeiro (true)
 * Ao sair do loop, retorne a entrada
*/

string VerificaTexto()
{
	string entrada;
	bool estaVazia;
	do
	{
		Console.WriteLine("Digite um texto: ");
		entrada = Console.ReadLine();
		estaVazia = string.IsNullOrWhiteSpace(entrada);
	} while (estaVazia);
	return entrada;// 
}

string texto = VerificaTexto();
Console.WriteLine($"O texto digitado é \"{texto}\"");