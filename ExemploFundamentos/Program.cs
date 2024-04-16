




List<string> listaString = new List<string>();   

listaString.Add("SP");
listaString.Add("RJ");
listaString.Add("MG"); 
listaString.Add("BA");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade {listaString.Capacity}");

listaString.Add("SC");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade {listaString.Capacity}");

listaString.Remove("MG");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade {listaString.Capacity}");




// for (int i = 0; i < listaString.Count; i++)
// {
//     Console.WriteLine($"Posição N* {i} - {listaString[i]}");
// }

// int contador = 0;
// foreach (string item in listaString)
// {
//     Console.WriteLine($"Posição N* {contador} - {item}");
//     contador ++;
// }




























// int[] arrayInteiros = new int[4];
// arrayInteiros[0] = 72;
// arrayInteiros[1] = 64;
// arrayInteiros[2] = 50;
// arrayInteiros[3] = 100;

// // for (int i = 0; i < arrayInteiros.Length; i++)
// // {
// //     Console.WriteLine(arrayInteiros[i]);
// // }


// int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
// Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);

// // Array.Resize(ref arrayInteiros, arrayInteiros.Length *2);

// foreach (int item in arrayInteiros)
// {
//     Console.WriteLine(item);
// }
























// using ExemploFundamentos.PessoaCopia;

// Pessoa pessoa = new Pessoa();

// pessoa.Nome = "João";
// pessoa.Idade = 30;
// pessoa.Apresentar();






// string opcao = "";
// bool exebirMenu = true; 

// while(exebirMenu){
//     Console.WriteLine("Digite a opção desejada:");
//     Console.WriteLine("1 - Cadastrar cliente");
//     Console.WriteLine("2 - Buscar clientes");
//     Console.WriteLine("3 - Apagar cliente");
//     Console.WriteLine("4 - Sair");

//     opcao = Console.ReadLine();

//     switch(opcao){
//         case "1":
//             Console.WriteLine("Cadastrando cliente...");
//             break;
//         case "2":
//             Console.WriteLine("Buscando clientes...");
//             break;
//         case "3":
//             Console.WriteLine("Apagando cliente...");
//             break;
//         case "4":
//             Console.WriteLine("Saindo do sistema...");
//             // Environment.Exit(0);
//             exebirMenu = false;
//             break;
//         default:
//             Console.WriteLine("Opção inválida!");
//             break;
//     }

// }

// Console.WriteLine("Fim do programa!");
























// int numero = 10;

// Console.WriteLine($"{numero} x 1 = {numero * 1}\n");



// for (int i = 1; i <= 10; i++)
// {
//     Console.WriteLine($"{numero} x {i} = {numero * i}");
// }


// Calculadora calc = new Calculadora();

// calc.Somar(10, 30);
// calc.Subtrair(10,50);
// calc.Multiplicar(15,45);
// calc.Dividir(2,2);
// calc.Potencia(3,3);

// calc.Seno(30);
// calc.Cosseno(30);
// calc.Tangente(30);

// calc.RaizQuadrada(9);
























































// bool choveu = true;
// bool estaTarde = true;  

// if(!choveu && !estaTarde){
//     Console.WriteLine("Vou assistir um pedalar!");
// }else{
//     Console.WriteLine("Vou pedalar outro dia!");
// }    




































// bool presencaMinimar = true;
// double media = 7.5;

// if(presencaMinimar && media >= 7){
//     Console.WriteLine("Aluno aprovado!");
// }else{
//     Console.WriteLine("Aluno reprovado!");
// }



























// bool maiorDeIdade = true;
// bool autorizacaoDoResponsavel = false;

// if(maiorDeIdade || autorizacaoDoResponsavel){
//     Console.WriteLine("Entrada liberada!");
// }else{
//     Console.WriteLine("Entrada não liberada!");
// }



// Console.WriteLine("Digite uma letra:");
// string letra = Console.ReadLine();

// switch(letra){
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("A letra digitada é uma vogal!");
//         break;
//     default:
//         Console.WriteLine("A letra digitada é uma consoante!");
//         break;
// }

// if(letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u"){
//     Console.WriteLine("A letra digitada é uma vogal!");
// }else{
//     Console.WriteLine("A letra digitada é uma consoante!");
// }



// int qtdEmEstoque = 10;
// int qtdCompra = 0;
// bool possivelVenda = qtdCompra > 0 && qtdEmEstoque >= qtdCompra;

// Console.WriteLine($"Quantidade em estoque: {qtdEmEstoque}");
// Console.WriteLine("Quantidade compra: " + qtdCompra);
// Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

// if(qtdCompra ==0){
//     Console.WriteLine("Compra não realizada!");
// } 
// else if(possivelVenda){
//     Console.WriteLine("Compra realizada com sucesso!");
// }else{
//     Console.WriteLine("Quantidade em estoque insuficiente!");
// }
