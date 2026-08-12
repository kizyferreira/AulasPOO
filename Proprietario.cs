class Proprietario
{
    public string Nome;
    public string Cpf;

    public bool ValidarCpf()
    {
       string cpfLimpo = Cpf.Replace(".", "").Replace("-", "");

        if (cpfLimpo.Length != 11)
        {
            return false;
        }

        int somaPrimeiroDigito;
        int multiplicador = 10;

        for (int i = 0; i < 9; i++)
        {
            int digito = int.Parse(cpfLimpo[i].ToString());
            somaPrimeiroDigito = somaPrimeiroDigito + (digito * multiplicador);
            multiplicador--;
        }

        int resto1 = somaPrimeiroDigito % 11;
        int primeiroDigitoCalculado;

        if (resto1 < 2)
        {
            primeiroDigitoCalculado = 0;
        }
        else
        {
            primeiroDigitoCalculado = 11 - resto1;
        }

        int primeiroDigitoReal = int.Parse(cpfLimpo[9].ToString());
        if (primeiroDigitoCalculado != primeiroDigitoReal)
        {
            return false;
        }

        // Calcular o segundo dígito 
        int somaSegundoDigito;
        multiplicador = 11;

        for (int i = 0; i < 10; i++)
        {
            int digito = int.Parse(cpfLimpo[i].ToString());
            somaSegundoDigito = somaSegundoDigito + (digito * multiplicador);
            multiplicador--;
        }

        int resto2 = somaSegundoDigito % 11;
        int segundoDigitoCalculado;

        if (resto2 < 2)
        {
            segundoDigitoCalculado = 0;
        }
        else
        {
            segundoDigitoCalculado = 11 - resto2;
        }

        int segundoDigitoReal = int.Parse(cpfLimpo[10].ToString());
        if (segundoDigitoCalculado != segundoDigitoReal)
        {
            return false;
        }

        return true;
    }
}


