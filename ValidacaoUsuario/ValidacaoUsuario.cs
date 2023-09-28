using System;
using System.Linq.Expressions;

namespace Validacao
{
    class ValidacaoUsuario
    {
        // Atributos de Variáveis
        private string nome;
        private int idade;
        private double altura;
        private string sexo;

        // Metodo Main
        static void Main(string[] args)
        {
            // Instância da Classe Validação Usuário
            ValidacaoUsuario usuario = new ValidacaoUsuario();
            
            // Captura dados do Usuário
            Console.Write("Digite o seu Nome: ");
            usuario.nome = Console.ReadLine();

            Console.Write("Digite sua Idade: ");
            usuario.idade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite sua Altura: ");
            usuario.altura = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o seu Sexo (M para Masculino e F para Feminino): ");
            usuario.sexo = Console.ReadLine();


            // Validação dos Dados
            Console.WriteLine("O seu nome é: " + usuario.nome);
            Console.WriteLine("A sua idade é: " + usuario.idade);
            Console.WriteLine("A sua altura é: " + usuario.altura);

            switch (usuario.sexo)
            {
                case "M":
                    Console.WriteLine("O seu sexo é Masculino");
                    break;
                case "m":
                    Console.WriteLine("O seu sexo é Masculino");
                    break;
                case "F":
                    Console.WriteLine("O seu sexo é Feminino");
                    break;
                case "f":
                    Console.WriteLine("O seu sexo é Feminino");
                    break;
                default:
                    Console.WriteLine("Digite o seu Sexo (M para Masculino e F para Feminino): ");
                    break;
            }
        }
        
    }
}