#include <iostream>
#include <locale>
using namespace std;

class Retangulo
{
public:
    double Altura;
    double Largura;

    Retangulo(double altura, double largura)
    {
        Altura = altura;
        Largura = largura;
    }

    void calcArea()
    {
        double area = Altura * Largura;
        cout << "A área do retângulo é " << area << "." << endl;
    }

    void calcPerimetro()
    {
        double perimetro = (2 * Altura) + (2 * Largura);
        cout << "O perímetro do retângulo é " << perimetro << "." << endl;
    }
};

int main()
{
    setlocale(LC_ALL, "Portuguese");

    double alt, lar;

    cout << "Digite a altura do retângulo: ";
    cin >> alt;

    cout << "Digite a largura do retângulo: ";
    cin >> lar;

    Retangulo ret(alt, lar);

    ret.calcArea();
    ret.calcPerimetro();

}