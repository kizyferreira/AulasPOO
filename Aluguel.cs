public class Aluguel
{
    public double totalHoras;
    public DateTime data;
    public double valorHora;
    public string numVaga;

    public void CalcularValor()
    {
        double valorTotal = totalHoras * valorHora;
        Console.WriteLine($"O valor total dessa reserva será de: R${valorTotal}, considerando {totalHoras} horas a R${valorHora} a hora. ");
    }

    public double CalcularValorComRetorno(double bonus)
    {
        double valorTotal = totalHoras * valorHora;
        //Console.WriteLine($"O valor total dessa reserva será de: R${valorTotal}, considerando {totalHoras} horas a R${valorHora} a hora. ");
        return valorHora;
    }


    public Aluguel (double valorHora, string numVaga)
    {
        this.valorHora = valorHora;
        this.data = DateTime.Now; ;

        Console.WriteLine($"Criando um obejto da classe aluguel. ");

    }



}