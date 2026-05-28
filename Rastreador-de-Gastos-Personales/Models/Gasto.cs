namespace Rastreador_de_Gastos_Personales.Models{
public class Gasto
{
    public int Id {get;set;}
    public string Descripcion {get;set;}= string.Empty;
    public decimal Monto {get;set;}
    public string Categoria {get;set;}= string.Empty;
    public DateTime Fecha {get;set;} = DateTime.Now;
}
}