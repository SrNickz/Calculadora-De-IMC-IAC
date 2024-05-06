using System;
using System.Globalization;
using System.Collections.Generic;
using CalculoIMCeIAC;

namespace Exercicio {
    class Program {
        static void Main(string[] args) {

            char refazCalculo;

            do {
                Console.Clear();
                Console.WriteLine("CALCULADORA DE IMC E IAC");
                Console.WriteLine("\n------------------------\n");

                Console.Write("Você deseja calcular seu IMC ou seu IAC? ");
                string escolha = Console.ReadLine();

                while (escolha != "IMC" && escolha != "imc" && escolha != "IAC" && escolha != "iac") {
                    Console.Write("Entrada errada, por favor, digite novamente \n Entre com \"IMC\" ou \"IAC\": ");
                    escolha = Console.ReadLine();
                }

                Console.WriteLine("\n------------------------\n");

                if (escolha == "IMC" || escolha == "imc") {
                    Console.WriteLine("Digite sua massa corporal e sua altura \n * Por favor, use o ponto ao invés da vírgula como separador decimal.");

                    Console.WriteLine();

                    Console.Write("Massa: ");
                    double massa = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Altura: ");
                    double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.WriteLine("\n------------------------\n");

                    Pessoa pessoa = new Pessoa(massa, altura);
                    double imc = pessoa.Imc(pessoa.MassaCorporal, pessoa.Altura);
                    Console.WriteLine("Você tem um IMC de " + imc.ToString("F1") + " Kg/m²");

                    if (imc < 18.5) {
                        Console.WriteLine("Peso abaixo do normal!");
                    }
                    else if (imc <= 24.9) {
                        Console.WriteLine("Peso normal, parabéns!");
                    }
                    else if (imc <= 29.9) {
                        Console.WriteLine("Sobrepeso!");
                    }
                    else if (imc <= 34.9) {
                        Console.WriteLine("Obesidade grau 1!");
                    }
                    else if (imc <= 39.9) {
                        Console.WriteLine("Obesidade grau 2!");
                    }
                    else if (imc <= 49.9) {
                        Console.WriteLine("Obesidade grau 3! Cuidado.");
                    }
                    else if (imc <= 59.9) {
                        Console.WriteLine("Obesidade grau 4!");
                    }
                    else {
                        Console.WriteLine("Obesidade grau 5! Procure ajuda médica.");
                    }
                    Console.WriteLine();
                }
                else {
                    Console.WriteLine("Digite a circunferenicia do seu quadril e sua altura \n * Por favor, use o ponto ao invés da vírgula como separador decimal.");

                    Console.WriteLine();

                    Console.Write("Circunferencia: ");
                    double circunferencia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Altura: ");
                    double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.WriteLine("\n------------------------\n");

                    Pessoa pessoa = new Pessoa(circunferencia, altura);
                    double iac = pessoa.Iac(pessoa.CircunferenciaDoQuadril, pessoa.Altura);
                    Console.WriteLine("Você tem um IAC de " + iac.ToString("F1") + "%");
                    Console.WriteLine();
                }

                Console.Write("Você deseja refazer a operação? (s/n) ");
                refazCalculo = char.Parse(Console.ReadLine());
                while (refazCalculo != 's' && refazCalculo != 'S' && refazCalculo != 'n' && refazCalculo != 'N') {
                    Console.Write("Por favor, digite um parâmetro válido: ");
                    refazCalculo = char.Parse(Console.ReadLine());
                }
            } while (refazCalculo == 's');
        }
    }
}