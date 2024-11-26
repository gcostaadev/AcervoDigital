
using AcervoDigital.Models;

void ExibirLogo()
        {
            Console.WriteLine(@"
░█████╗░░█████╗░███████╗██████╗░██╗░░░██╗░█████╗░  ██████╗░██╗░██████╗░██╗████████╗░█████╗░██╗░░░░░
██╔══██╗██╔══██╗██╔════╝██╔══██╗██║░░░██║██╔══██╗  ██╔══██╗██║██╔════╝░██║╚══██╔══╝██╔══██╗██║░░░░░
███████║██║░░╚═╝█████╗░░██████╔╝╚██╗░██╔╝██║░░██║  ██║░░██║██║██║░░██╗░██║░░░██║░░░███████║██║░░░░░
██╔══██║██║░░██╗██╔══╝░░██╔══██╗░╚████╔╝░██║░░██║  ██║░░██║██║██║░░╚██╗██║░░░██║░░░██╔══██║██║░░░░░
██║░░██║╚█████╔╝███████╗██║░░██║░░╚██╔╝░░╚█████╔╝  ██████╔╝██║╚██████╔╝██║░░░██║░░░██║░░██║███████╗
╚═╝░░╚═╝░╚════╝░╚══════╝╚═╝░░╚═╝░░░╚═╝░░░░╚════╝░  ╚═════╝░╚═╝░╚═════╝░╚═╝░░░╚═╝░░░╚═╝░░╚═╝╚══════╝
");
            Console.WriteLine("\nBem vindo ao Acervo Digital!\n");
        }

bool home = true;
bool menuCadastroUsuario = false;
bool menuCadastroEmprestimo = false;
bool menuCadastroLivro = false;


List<Livro> livros = new List<Livro>();
List<Usuario> usuarios = new List<Usuario>();
List<Emprestimo> emprestimos = new List<Emprestimo>();

while (home)
{
    Console.Clear();
    ExibirLogo();
    Console.WriteLine("1- Livro\n2- Usuário\n3- Emprestimo\n4- Sair\n ");

    Console.WriteLine("Digite a sua opção:");
    string opcaoEscolida = Console.ReadLine();
    int opcaoEscolidaInt;

    // Verifique se a opção digitada é um número válido
    if (int.TryParse(opcaoEscolida, out opcaoEscolidaInt))
    {
        switch (opcaoEscolidaInt)
        {
            case 1:
                menuCadastroLivro = true;
                while (menuCadastroLivro) 
                {
                    Console.Clear();
                    LogoLivro();
                    Console.WriteLine("1- Cadastrar Livro\n2- Listar Livros \n3- Consultar Livro\n4- Remover Livro\n5- Voltar para Home\n ");

                    Console.WriteLine("Digite a sua opção:");
                    string opcaoLivro = Console.ReadLine();
                    int opcaoLivroInt;

                    if (int.TryParse(opcaoLivro, out opcaoLivroInt))
                    {
                        switch (opcaoLivroInt)
                        {
                            case 1:
                                RegistrarLivro(livros);
                                break;
                            case 2:
                                ListaDeTodosOsLivros(livros);
                                break;
                            case 3:
                                PesquisarLivro(livros);
                                break;
                            case 4:
                                RemoverLivro(livros);
                                break;
                            case 5:
                                menuCadastroLivro = false; 
                                break;
                            default:
                                Console.WriteLine("\nOpção inválida!");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nOpção inválida! Digite um número.");
                    }

                    Console.WriteLine("\nPressione uma tecla para continuar");
                    Console.ReadLine();
                }
                break;

            case 2:
                menuCadastroUsuario = true;
                while (menuCadastroUsuario) 
                {
                    Console.Clear();
                    LogoUsuarios();
                    Console.WriteLine("1- Cadastrar Usuario\n2- Listar Usuários\n3- Consultar Usuário\n4- Remover Usuário\n5- Voltar para Home\n ");

                    Console.WriteLine("Digite a sua opção:");
                    string opcaoUsuario = Console.ReadLine();
                    int opcaoUsuarioInt;

                    if (int.TryParse(opcaoUsuario, out opcaoUsuarioInt))
                    {
                        switch (opcaoUsuarioInt)
                        {
                            case 1:
                                RegistrarUsuario(usuarios);
                                break;
                            case 2:
                                ListaDeUsuario(usuarios);
                                break;
                            case 3:
                                PesquisarUsuario(usuarios);
                                break;
                            case 4:
                                RemoverUsuario(usuarios);
                                break;
                            case 5:
                                menuCadastroUsuario = false; 
                                break;
                            default:
                                Console.WriteLine("\nOpção inválida!");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nOpção inválida! Digite um número.");
                    }

                    Console.WriteLine("\nPressione uma tecla para continuar");
                    Console.ReadLine();
                }
                break;

            case 3:
                menuCadastroEmprestimo = true;
                while (menuCadastroEmprestimo) 
                {
                    Console.Clear();
                    LogoEmprestimo();
                    Console.WriteLine("1- Cadastrar emprestimo\n2- Lista de emprestimos\n3- Registrar Devolução\n4- Voltar para Home\n ");

                    Console.WriteLine("Digite a sua opção:");
                    string opcaoEmprestimo = Console.ReadLine();
                    int opcaoEmprestimoInt;

                    if (int.TryParse(opcaoEmprestimo, out opcaoEmprestimoInt))
                    {
                        switch (opcaoEmprestimoInt)
                        {
                            case 1:
                                RegistrarEmprestimo(emprestimos);

                                break;
                            case 2:
                                ListaDeEmprestimo(emprestimos);

                                break;
                            case 3:
                                RegistrarDevoulucao(emprestimos);
                                break;
                            case 4:
                                menuCadastroEmprestimo = false;
                                break;
                            default:
                                Console.WriteLine("\nOpção inválida!");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nOpção inválida! Digite um número.");
                    }

                    Console.WriteLine("\nPressione uma tecla para continuar");
                    Console.ReadLine();
                }
                break;

            case 4:
                home = false; 
                break;
            default:
                Console.WriteLine("\nOpção inválida!");
                break;
        }
    }
    else
    {
        Console.WriteLine("\nOpção inválida! Digite um número.");
    }
}

Console.WriteLine("\nObrigado por utilizar o nosso sistema! Sua sessão foi finalizada com sucesso.");


#region MetodosDeLivro

void LogoLivro()
{
    Console.WriteLine(@"
██╗░░░░░██╗██╗░░░██╗██████╗░░█████╗░░██████╗
██║░░░░░██║██║░░░██║██╔══██╗██╔══██╗██╔════╝
██║░░░░░██║╚██╗░██╔╝██████╔╝██║░░██║╚█████╗░
██║░░░░░██║░╚████╔╝░██╔══██╗██║░░██║░╚═══██╗
███████╗██║░░╚██╔╝░░██║░░██║╚█████╔╝██████╔╝
╚══════╝╚═╝░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░╚═════╝░");
    Console.WriteLine();
}

static void RegistrarLivro(List<Livro> livros)
{
    Livro novoLivro = new Livro();
    Console.Clear();

    ExibirTituloDaOpcao("CADASTRAR LIVRO");

    Console.WriteLine("Digite um numero de ID:");
    novoLivro.IdLivro = int.Parse(Console.ReadLine() ?? "Não informado");

    Console.WriteLine("Digite o título do livro:");
    novoLivro.Titulo = Console.ReadLine();

    Console.WriteLine("Digite o autor do livro:");
    novoLivro.Autor = Console.ReadLine();

    Console.WriteLine("Digite o ISBN do livro:");
    novoLivro.Isbn = Console.ReadLine();

    Console.WriteLine("Digite o ano de publicação do livro:");
    novoLivro.AnoDePublicacao = int.Parse(Console.ReadLine() ?? "0000");

    if (livros.Exists(l => l.IdLivro == novoLivro.IdLivro))
    {
        Console.WriteLine($"\nO numero de Id {novoLivro.IdLivro} já foi cadastrado anteriormente");
    }
    else if(livros.Exists(l => l.Titulo == novoLivro.Titulo))
    {
        Console.WriteLine($"\nO livro com o Titulo {novoLivro.Titulo} já foi cadastrado anteriormente");
    }
    else
    {
        livros.Add(novoLivro);
        Console.WriteLine($"\nO livro {novoLivro.Titulo} foi registrada com sucesso!");
    }
            
}

static void ListaDeTodosOsLivros(List<Livro> livros)
{
    Console.Clear();

    ExibirTituloDaOpcao("LIVROS CADASTRADOS");

    if (livros.Count == 0)
    {
        Console.WriteLine("Nenhum livro cadastrado.");
        return;
    }else
    {
        foreach (var livro in livros)
        {
        livro.ExibirInformacoes();
        Console.WriteLine();
        }

    }
}

static void PesquisarLivro(List<Livro> livros)
{
    Console.Clear();

    ExibirTituloDaOpcao("CONSULTAR LIVRO");

    Console.WriteLine("Digite o numero do ID do livro que deseja consultar:");
    string inputId = Console.ReadLine();

    if (int.TryParse(inputId, out var idProdurado))
    {
        Livro livroEncontrado = livros.FirstOrDefault(l => l.IdLivro == idProdurado);

        if(livroEncontrado != null)
        {
            Console.WriteLine("\nLivro encontrado:\n");
            livroEncontrado.ExibirInformacoes();
        }
        else
        {
            Console.WriteLine("Nenhum livro foi encontardo");
        }
    }
    else
    {
        Console.WriteLine("ID inválido.");
    }

}

static void RemoverLivro(List<Livro> livros)
{
    Console.Clear();

    ExibirTituloDaOpcao("REMOVER LIVRO");

    Console.WriteLine("Digite o numero do ID do livro que deseja remover:");
    string inputId = Console.ReadLine();

    if(int.TryParse(inputId, out int idRemovido))
    {
        Livro livroARemover = livros.FirstOrDefault(l=> l.IdLivro==idRemovido);

        if(livroARemover != null)
        {
            livros.Remove(livroARemover);
            Console.WriteLine($"O livro '{livroARemover.Titulo}' foi removido com sucesso.");
        }
        else
        {
            Console.WriteLine("Nenhum livro foi encontrado com o ID informado.");
        }

    }
    else
    {
        Console.WriteLine("ID invalido");
    }
    
}

#endregion

#region MetodosDeUsuario
void LogoUsuarios()
{
    Console.WriteLine(@"
██╗░░░██╗░██████╗██╗░░░██╗░█████╗░██████╗░██╗░█████╗░░██████╗
██║░░░██║██╔════╝██║░░░██║██╔══██╗██╔══██╗██║██╔══██╗██╔════╝
██║░░░██║╚█████╗░██║░░░██║███████║██████╔╝██║██║░░██║╚█████╗░
██║░░░██║░╚═══██╗██║░░░██║██╔══██║██╔══██╗██║██║░░██║░╚═══██╗
╚██████╔╝██████╔╝╚██████╔╝██║░░██║██║░░██║██║╚█████╔╝██████╔╝
░╚═════╝░╚═════╝░░╚═════╝░╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░╚════╝░╚═════╝░");
    Console.WriteLine();
}
static void RegistrarUsuario(List<Usuario> usuarios)
{
    Usuario novoUsuario = new Usuario();
    Console.Clear();

    ExibirTituloDaOpcao("CADASTRAR USUÁRIO");

    Console.WriteLine("Digite um numero de ID:");
    novoUsuario.IdUsuario = int.Parse(Console.ReadLine() ?? "Não informado");

    Console.WriteLine("Digite o nome do usuário:");
    novoUsuario.Nome = Console.ReadLine();

    Console.WriteLine("Digite o e-mail do usuário:");
    novoUsuario.Email = Console.ReadLine();

    if (usuarios.Exists(u => u.IdUsuario == novoUsuario.IdUsuario))
    {
        Console.WriteLine($"\nO numero de Id {novoUsuario.IdUsuario} já foi cadastrado anteriormente");
    }
    else
    {
        usuarios.Add(novoUsuario);
        Console.WriteLine($"\nO usuário {novoUsuario.Nome} foi registrada com sucesso!");
    }
}

static void ListaDeUsuario(List<Usuario> usuarios)

{
    Console.Clear();

    ExibirTituloDaOpcao("USUÁRIOS CADASTRADOS");

    if (usuarios.Count == 0)
    {
        Console.WriteLine("Nenhum usuário cadastrado.");
        return;
    }
    else
    {
        foreach (var usuario in usuarios)
        {
            usuario.ExibirInformacoesDeUsuario();
            Console.WriteLine();
        }

    }

}

static void PesquisarUsuario(List<Usuario> usuarios)
{
    Console.Clear();

    ExibirTituloDaOpcao("CONSULTAR USUÁRIO");

    Console.WriteLine("Digite o numero do ID do usuário que deseja consultar:");
    string inputId = Console.ReadLine();

    if (int.TryParse(inputId, out var idProcurado))
    {
        Usuario usuarioEncontrado = usuarios.FirstOrDefault(u => u.IdUsuario == idProcurado);

        if (usuarioEncontrado != null)
        {
            Console.WriteLine("\nUsuário encontrado:\n");
            usuarioEncontrado.ExibirInformacoesDeUsuario();
        }
        else
        {
            Console.WriteLine("Nenhum usuário foi encontardo");
        }
    }
    else
    {
        Console.WriteLine("ID inválido.");
    }
}

static void RemoverUsuario(List<Usuario> usuarios)
{
    Console.Clear();

    ExibirTituloDaOpcao("REMOVER USUÁRIO");

    Console.WriteLine("Digite o numero do ID do usuário que deseja remover:");
    string inputId = Console.ReadLine();

    if (int.TryParse(inputId, out int idRemovido))
    {
        Usuario usuarioARemover = usuarios.FirstOrDefault(u => u.IdUsuario == idRemovido);

        if (usuarioARemover != null)
        {
            usuarios.Remove(usuarioARemover);
            Console.WriteLine($"O Usuário '{usuarioARemover.Nome}' foi removido com sucesso.");
        }
        else
        {
            Console.WriteLine("Nenhum usuário foi encontrado com o ID informado.");
        }

    }
    else
    {
        Console.WriteLine("ID invalido");
    }

}

#endregion

#region MetodosDeEmprestimo

void LogoEmprestimo()
{
    Console.WriteLine(@"
███████╗███╗░░░███╗██████╗░██████╗░███████╗░██████╗████████╗██╗███╗░░░███╗░█████╗░
██╔════╝████╗░████║██╔══██╗██╔══██╗██╔════╝██╔════╝╚══██╔══╝██║████╗░████║██╔══██╗
█████╗░░██╔████╔██║██████╔╝██████╔╝█████╗░░╚█████╗░░░░██║░░░██║██╔████╔██║██║░░██║
██╔══╝░░██║╚██╔╝██║██╔═══╝░██╔══██╗██╔══╝░░░╚═══██╗░░░██║░░░██║██║╚██╔╝██║██║░░██║
███████╗██║░╚═╝░██║██║░░░░░██║░░██║███████╗██████╔╝░░░██║░░░██║██║░╚═╝░██║╚█████╔╝
╚══════╝╚═╝░░░░░╚═╝╚═╝░░░░░╚═╝░░╚═╝╚══════╝╚═════╝░░░░╚═╝░░░╚═╝╚═╝░░░░░╚═╝░╚════╝░");
    Console.WriteLine();
}

static void RegistrarEmprestimo(List<Emprestimo> emprestimos)
{
    Emprestimo novoEmprestimo = new Emprestimo();
    Console.Clear();

    ExibirTituloDaOpcao("CADASTRAR UM EMPRESTIMO");

    Console.WriteLine("Digite um número de ID:");
    if (int.TryParse(Console.ReadLine(), out int idEmprestimo))
    {
        novoEmprestimo.IdEmprestimo = idEmprestimo;
    }
    else
    {
        Console.WriteLine("ID inválido. Por favor, insira um número válido.");
        return;
    }

    Console.WriteLine("Digite a data de empréstimo (formato: dd/MM/yyyy):");
    string inputData = Console.ReadLine();

    if (DateTime.TryParseExact(inputData, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime dataDeEmprestimo))
    {
        novoEmprestimo.DataDeEmprestimo = dataDeEmprestimo; // Atribui a data antes de adicionar à lista
        novoEmprestimo.DataDeDevolucao = dataDeEmprestimo.AddDays(7);
        emprestimos.Add(novoEmprestimo); // Adiciona o novo empréstimo à lista
        Console.WriteLine("\nEmpréstimo registrado com sucesso!");
    }
    else
    {
        Console.WriteLine("Data inválida. Por favor, insira uma data no formato correto.");
        return;
    }
}

static void ListaDeEmprestimo(List<Emprestimo> emprestimos)
{
    Console.Clear();

    ExibirTituloDaOpcao("EMPRESTIMOS CADASTRADOS");

    if (emprestimos.Count == 0)
    {
        Console.WriteLine("Nenhum emprestimo registrado.");
        return;
    }
    else
    {
        foreach (var emprestimo in emprestimos)
        {
            emprestimo.ExibirInformacoesDeEmprestimo();
            Console.WriteLine();
        }

    }

}

static void RegistrarDevoulucao(List<Emprestimo> emprestimos)
{
    Console.Clear();

    ExibirTituloDaOpcao("REGISTRAR DEVOLUÇÃO DE UM LIVRO");

    if (emprestimos.Count == 0)
    {
        Console.WriteLine("Nenhum emprestimo registrado");
        return;
    }
    Console.WriteLine("Digite o ID do empréstimo que deseja devolver:");
    if(int.TryParse(Console.ReadLine(), out int idEmpretimo))
    {
        Emprestimo emprestimo = emprestimos.Find(e => e.IdEmprestimo == idEmpretimo);

        if (emprestimo != null)
        {
            if (!emprestimo.DataDevolucaoReal.HasValue) // Verifica se ainda não foi devolvido
            {
                emprestimo.DataDevolucaoReal = DateTime.Now;

                if(emprestimo.DataDevolucaoReal.Value > emprestimo.DataDeDevolucao)
                {
                    int diasAtraso = (emprestimo.DataDevolucaoReal.Value - emprestimo.DataDeDevolucao).Days;
                    Console.WriteLine($"\nLivro com ID {emprestimo.IdEmprestimo} devolvido com atraso de {diasAtraso} dia(s).");
                }
                else
                {
                    Console.WriteLine($"\nLivro com ID {emprestimo.IdEmprestimo} devolvido dentro do prazo.");
                }
                emprestimos.Remove(emprestimo);
                Thread.Sleep(3000);
                Console.WriteLine($"\nEmpréstimo com ID {emprestimo.IdEmprestimo} removido da lista.");
            }
            else
            {
                Console.WriteLine("Este empréstimo já foi devolvido.");
            }
        }
        else
        {
            Console.WriteLine("Empréstimo não encontrado.");
        }
    }
    else
    {
        Console.WriteLine("ID inválido. Por favor, insira um número válido.");
    }

}

#endregion

static void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string linha = string.Empty.PadLeft(quantidadeDeLetras, '-');
    Console.WriteLine(linha);
    Console.WriteLine(titulo);
    Console.WriteLine(linha + "\n");
}
