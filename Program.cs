
Clicker clicker = new Clicker();
Galinha.Activate();
Gaviao.Activate();
Avestruz.Activate();
Pinguim.Activate();
Jacare.Activate();

clicker.Start();



class Clicker
{
    public int cash { get; private set; } = 30;

    public int producao { get; private set; } = 1;

    public void Start()
    {

        while (true)
        {
            Console.WriteLine($"{cash} ovos");
            Console.WriteLine("0 -> produzir \n1 -> Menu de aves\n9 -> sair do jogo");
            var opcao = Console.ReadKey().Key;


            if (opcao == ConsoleKey.D9)
            {
                Console.Clear();
                foreach (var maquina in Maquina.Tipos)
                {
                    Console.WriteLine($"{maquina.Nome}: {maquina.quntidade_de_maquinas}");
                }
                break;
            }

            else if (opcao ==  ConsoleKey.D0)
            {
                this.cash += producao;
                Console.Clear();
            }

            else if (opcao ==  ConsoleKey.D1)
            {
                Console.Clear();
                Console.WriteLine($"{cash} ovos");
                foreach (var maquina in Maquina.Tipos)
                    Console.WriteLine($"{maquina.id} - {maquina.Nome} --> {maquina.valor}");
                Console.WriteLine("0 - voltar");



                Console.WriteLine("Código da máquina que deseja comprar: ");
                int maq = int.Parse(Console.ReadLine());

                foreach (var maquina in Maquina.Tipos)
                {
                    if(maq == maquina.id)
                    {
                        if(maquina.valor <= cash)
                        {
                            maquina.quntidade_de_maquinas += 1;
                            this.cash -= maquina.valor;
                            this.producao += maquina.adiciona;
                            maquina.valor = ((maquina.valor * 9) + 23)/2;

                        }

                    }
                }
                Console.Clear();
            }
        }
    }
}