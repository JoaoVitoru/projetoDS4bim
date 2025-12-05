INTEGRANTES DA DUPLA 2DS:
Henrico Saeki Rolim Issomura //
João Vitor dos Santos Nunes

Para conectar meu projeto ASP.NET Core MVC ao banco de dados MySQL, primeiro eu configurei a Connection String no arquivo appsettings.json,
dizendo onde meu banco está, qual o nome dele e o usuário e a senha para acessar. Depois disso, no Program.cs, eu adicionei o serviço do Entity Framework e configurei o MySQL usando essa Connection String.
É isso que faz a aplicação conseguir se comunicar diretamente com o banco.
Criei também a classe AppDbContext, que é quem representa a conexão com o banco dentro do código.
Nela eu coloquei um DbSet chamado “Usuarios”, que significa que vai existir uma tabela no banco com essa estrutura.
Essa estrutura é definida pela classe Usuario, que eu criei como meu Model contendo Id, Nome Completo, Email e Telefone — cada propriedade dessa classe vira uma coluna no banco de dados.
Depois implementei o UsuarioController,
onde recebo o AppDbContext pelo construtor. Assim, sempre que esse controller for usado, ele já vem com o acesso ao banco disponível. Na action Create que recebe o POST do formulário,
eu adiciono o usuário no contexto e mando salvar no banco com o _context.SaveChanges(). Isso faz os dados preenchidos ficarem registrados no MySQL.
Por fim, na View Create, eu coloquei o formulário usando asp-for em cada campo, o que faz com que as informações digitadas no HTML sejam automaticamente associadas às propriedades do meu Model Usuario.
Quando o usuário clica no botão para salvar, o formulário envia os dados para o controller, que coloca tudo no banco. Desse jeito, meu sistema já está todo ligado ao MySQL, funcionando do cadastro na tela até gravar realmente no banco de dados.
