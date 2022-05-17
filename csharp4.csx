public bool media(double nota1, double nota2, double nota3)
{
    bool x = (nota1 + nota2 + nota3) >= 5;
    return x;
}
bool y = media(10, 10, 10);
Console.WriteLine(y);