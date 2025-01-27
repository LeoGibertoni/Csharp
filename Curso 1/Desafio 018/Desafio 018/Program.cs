//Modelar o sistema de uma escola. Crie classes para Aluno, Professor e Disciplina.
//A classe Aluno deve ter informações como nome, idade e notas.
//A classe Professor deve ter informações sobre nome e disciplinas lecionadas.
//A classe Disciplina deve armazenar o nome da disciplina e a lista de alunos matriculados.


class Aluno
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public List<double> Notas { get; set; } = new List<double>();
}

class Professor
{
    public string Nome { get; set; }
    public List<string> DisciplinasLecionadas { get; set; } = new List<string>();
}

class Disciplina
{
    public string NomeDisciplina { get; set; }
    public List<Aluno> AlunosMatriculados { get; set; } = new List<Aluno>();
}