public abstract class Maquina
{
    public int id {get; set;}
    public string Nome {get; set;}
    public int valor { get; set; }
    public int quntidade_de_maquinas{ get; set; } = 0;
    public int adiciona { get; protected set; } = 1;
    public static List<Maquina> Tipos { get; set; } = new List<Maquina>();
    public int index { get; set; } = 0;

    public static void AddTipo(Maquina maquina)
    {
        Maquina.Tipos.Add(maquina);
    }
}