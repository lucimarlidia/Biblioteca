namespace Biblioteca;

public class MembroBiblioteca
{
    public string Nome { get; set; }
    private int Id { get; set; }

    public MembroBiblioteca(string nome, int id)
    {
        Nome = nome;
        Id = id;
    }

    internal void PegarLivroEmprestado()
    {
    }
        
    protected void BuscarInformacoesDetalhadas()
    {    
    }
}

