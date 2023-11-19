using System;
using CSharpShellCore;
namespace Notas{
	class classe{
	static void Main(String[] args){
	double nota1, nota2, nota3 , nota4;
	string frase = "digite sua {0}° nota";
	
	
	Console.WriteLine(frase, 1);
	nota1 = Convert.ToDouble (Console.ReadLine() );
	
	Console.WriteLine(frase, 2);
	nota2 = Convert.ToDouble (Console.ReadLine() );
	
	Console.WriteLine(frase, 3);
    nota3 = Convert.ToDouble( Console.ReadLine() );
	
	Console.WriteLine(frase,4);
	nota4 = Convert.ToDouble(Console.ReadLine());
	
	double total, media;
	total = nota1 + nota2 + nota3 + nota4;
	media = total / 4;
	
	Console.WriteLine("sua média foi:  "+ media);
	
	if(media < 5){
	Console.WriteLine("você està reprovado");
	}
	if(media < 7){
	Console.WriteLine("você terá que fazer recuperação");
	}
	else{
	Console.WriteLine("voce esta aprovado");
	}
	}
	}
}