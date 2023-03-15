namespace ExercicioAlunos;
class Program
{
    static void Main(string[] args)
    {
        Aluno aluno1 = new Aluno();
        Console.WriteLine("Digite o seu nome: ");
        aluno1.nome = Console.ReadLine();
        Console.WriteLine("Digite a 1º nota: ");
        aluno1.nota1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite a 2º nota: ");
        aluno1.nota2 = Convert.ToDouble(Console.ReadLine());

        aluno1.mensagem();
        //Console.WriteLine(nome+" está "+" ??? "+" com média "+" ??? ");
    }
}