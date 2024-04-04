using System;
class desafio_02
{
    static void Main()
    {
       while(true)
        {
            int opcao;
            int ano_atual = 2024;
            int gatos = 4;
            int resto = 5;
            string nome = "Coraline";
            string idade = "11 anos";
            string descricao = "Eu sou Coraline, sei que sou muito nova para participar, mas adoraria ajudar uma instituição como essa, pois eu amo gatinhos e ajudar os outros. Aliás, até tenho um gato como amigo, é o gatinho preto do Wybe. Apesar de ser um bichano muito debochado eu gosto muito dele.\n";
            Console.WriteLine(" Selecione o número referente a sua opção:\n 1. Faça seu perfil;\n 2. Sobre a 'Gatunos Aliados';\n 3. Doe para nós ou se alie;");
            opcao = int.Parse(Console.ReadLine());              

            switch(opcao)
            {
                case 1:

                    Console.WriteLine($"Nome: {nome}");
                    Console.WriteLine($"Idade: {idade}");
                    Console.WriteLine($"Descreva-se para sabermos se você é uma pessoa adequada para nossa instituição:");
                    Console.WriteLine(descricao);
                   break;

                case 2:

                    Console.WriteLine("Nós somos a 'Gatunos Aliados' e estamos felizes de te receber! Somos uma instituição de auxílio a gatos perdidos ou abandonados.");
                    Console.WriteLine($"Em que ano estamos? {ano_atual}");

                    if (ano_atual < 2020)
                    {
                        Console.WriteLine("Ainda somos uma instituição nova, começamos em 2015!");
                    }
                    else if (ano_atual >= 2020)
                    {
                        Console.WriteLine($"Uau {ano_atual}! é incrível saber que estamos há tanto tempo atuando, começamos em 2015!\n");
                    }
                   break;

                    case 3:

                    Console.WriteLine($"Olá {nome}! Gostaria de ajudar:\n 1. Adotando;\n 2. Se aliando;");
                    int escolha = int.Parse(Console.ReadLine());

                     switch (escolha)
                    {
                        case 1:

                            Console.WriteLine($"Digite quantos gatos você vai adotar: {gatos}");

                            for (int p = 1; p <= gatos; p++)
                            {
                                Console.WriteLine($"Então aqui vai mais 1 gatinho pra sua cestinha, já são {p}");

                            }
                            Console.WriteLine("Muito obrigado por essa atitude.\n");

                            Console.WriteLine($"Consegue imaginar quantos ainda restam?Teste suas especulações: ");

                            do
                            {
                                Console.WriteLine(resto);
                                Console.WriteLine("Não é essa quantidade hein.");
                                resto++;
                            } while (resto != 12 );

                            Console.WriteLine("12");
                            Console.WriteLine("Exatamente. Por isso, pedimos que compartilhe sobre nós com seus amigos.\n");

                            break;

                            case 2:

                            Console.WriteLine("Adicionada a lista de aliados.\n");

                            break;
                    }
             
                  break;
            }
        }




    }
}