//1º
  Console.WriteLine("Esta frase está na primeira linha"+"\n"+"Esta frase esta na segunda linha.");
//2º
     int[] entradas = new int[3];
            entradas[0] = 20;
            entradas[1] = 15;
            entradas[2] = 30;
            int somatorio = (entradas[0] + entradas[1] + entradas[2]);
            Console.WriteLine(somatorio);
//3º
            Console.WriteLine("Informe a base: ");
            double numbase = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe a altura:");
            double numaltura = Convert.ToDouble(Console.ReadLine());
            double resp = ((numaltura * numbase) / 2);
            Console.Write(resp);
//4º
             Console.WriteLine("Informe sua idade: ");
            int age = Convert.ToInt32(Console.ReadLine());
            int days = (age * 365)+(age/4);
            Console.WriteLine("Quantidade de dias: "+days);
//5º
             Console.WriteLine("Informe um numero : ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("O numero é: "+num+"\n"+"Seu Antecessor é:"+(num-1)+"\n"+"Seu sucessor é:"+(num+1));
//6º
			Console.WriteLine("Informe a  distancia[KM] : ");
            double dist = Convert.ToDouble(Console.ReadLine());
            double fuel = dist / 12;
            Console.WriteLine("A quantidade de combustivel nescessaria é [Lt]: "+fuel);
