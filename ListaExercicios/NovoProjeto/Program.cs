using System.Reflection.Metadata;
// Criar um vetor
int[] vetor = new int [100];
Random aleatorio = new Random();

//preencher os valores no vetor
for (int i = 0; i < vetor.Length; i++) {
    vetor[i] = aleatorio.Next(100) + 1;
}

//imprimir valores no vetor
for (int i = 0; i < vetor.Length; i++) {
    Console.Write(vetor[i] + "-");
}


bool troca;
//ordenação do vetor com Bubble Sort
do
{ 
    troca = false;
    for ( int i = 0; i < vetor.Length - 1; i++){
        if(vetor[i] > vetor[i + 1])
        {
            int aux = vetor[i];
            vetor[i] = vetor[i + 1];
            vetor[i + 1] = aux;
            troca = true;
        }
    }
} while (troca == true);

Console.WriteLine("\n");

//imprimir valores no vetor
for (int i = 0; i < vetor.Length; i++) {
    Console.Write(vetor[i] + "-");
}


