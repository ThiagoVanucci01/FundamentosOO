using Fundamentos;

internal class Program
{
    private static void Main(string[] args)
    {
        //livro livro1 = new livro();
        //livro1.titulo = "Harry Potter";
        //livro1.Editora = "Editora Abril";
        //livro1.Autor = "J.K.H.";
        //livro1.AnoLancamento = 2001;

        //livro livro2 = new livro();

        //livro2.titulo = "Programando em c#";
        //livro2.Editora = "Editora Nova";
        //livro2.Autor = "Gustavo Castello";
        //livro2.AnoLancamento = 1982;

        //livro livro3 = new livro();

        //livro3.titulo = "Programando em Java";
        //livro3.Editora = "Editora Minha";
        //livro3.Autor = "Prof. Cris";
        //livro3.AnoLancamento = 1999;

        //Aluno aluno1 = new Aluno();

        //aluno1.Nome = "Thiago Candarola vanucci";
        //aluno1.RM = "4413";
        //aluno1.Email = "thiago.dev24@gmail.com";
        //aluno1.Nascimento = new DateOnly(2007, 07, 20);

        //Aluno aluno2 = new Aluno();

        //aluno2.Nome = "Pedro Henrique Silva Araujo";
        //aluno2.RM = "4448";
        //aluno2.Email = "mxpedro.araujo11@gmail.com";
        //aluno2.Nascimento = new DateOnly(2007, 09, 27);

        //Aluno aluno3 = new Aluno();

        //aluno3.Nome = "Erick Penazzi";
        //aluno3.RM = "4364";
        //aluno3.Email = "penazzi1234@gmail.com";
        //aluno3.Nascimento = new DateOnly(2007, 07, 17);


        //Console.WriteLine("Aluno 01");
        //Console.WriteLine("Nome: " + aluno1.Nome);
        //Console.WriteLine("RM: " + aluno1.RM);
        //Console.WriteLine("Email: " + aluno1.Email);
        //Console.WriteLine("Nascimento: " + aluno1.Nascimento);
        //Console.WriteLine("------------------------------------------------");

        //Console.WriteLine("Aluno 02");
        //Console.WriteLine("Nome: " + aluno2.Nome);
        //Console.WriteLine("RM: " + aluno2.RM);
        //Console.WriteLine("Email: " + aluno2.Email);
        //Console.WriteLine("Nascimento: " + aluno2.Nascimento);
        //Console.WriteLine("------------------------------------------------");

        //Console.WriteLine("Aluno 03");
        //Console.WriteLine("Nome: " + aluno3.Nome);
        //Console.WriteLine("RM: " + aluno3.RM);
        //Console.WriteLine("Email: " + aluno3.Email);
        //Console.WriteLine("Nascimento: " + aluno3.Nascimento);
        //Console.WriteLine("------------------------------------------------");


        ////istanciar um Objeto do tipo Produto
        //Produto p1 = new Produto();
        //p1.Codigo = 123456;
        //p1.Nome = "Coca-Cola 2 litros";
        //p1.preco = 12.99;
        //p1.Estoque = 96;

        ////Chamar o metodo QuantidadeEstoque
        //p1.QuantidadeEstoque();
        //p1.Estoque = 85;

        ////Chamar o metodo QuantidadeEstoque
        //p1.QuantidadeEstoque();
        //Console.WriteLine("------------------------------------------------");
        //Console.WriteLine();

        ////Istanciar um objeto do tipo Carro
        //Carro carro1 = new Carro();

        //carro1.Marca = "Ferrari";
        //carro1.Modelo = "488";
        //carro1.Velocidade = 80;

        //carro1.Acelerar();
        //carro1.Acelerar();
        //carro1.Desacelerar();

        //Console.WriteLine("------------------------------------------------");

        //Pessoa pessoa1 = new Pessoa();

        //pessoa1.Nome = "Thiago Vanucci";
        //pessoa1.Idade = 17;

        //pessoa1.Envelhecer(2);

        //Console.WriteLine("------------------------------------------------");

        //Funcionario func1 = new Funcionario();
        //func1.Nome = "Erick";
        //func1.Idade = 20;
        //func1.Cargo = "Aprendiz";
        //func1.Salario = 1400.00;
        //func1.ApresentarSe();

        //Console.WriteLine("------------------------------------------------");

        ////instanciar um objeto
        //Animal animal1 = new Animal();

        ////inserindo dados no atributo
        //animal1.Especie = "Cachorro";

        ////chamando o metodo do objeto
        //animal1.emitirSom();

        ////imprimindo a informação na tela
        //Console.WriteLine("O Animal " + animal1.Especie + " emitiu um som.");

        Gato gato = new Gato();
        gato.Nome = "Frajola";
        Console.WriteLine(gato.Nome + " faz: ");
        gato.emitirSom();

        Console.WriteLine("------------------------------------------------");

        Galinha galinha = new Galinha();
        galinha.Nome = "phiu";
        Console.WriteLine(galinha.Nome + " faz: ");
        galinha.emitirSom();

        Console.WriteLine("------------------------------------------------");

        Porco porco = new Porco();
        porco.Nome = "Pig";
        Console.WriteLine(porco.Nome + " faz: ");
        porco.emitirSom();
    }
}