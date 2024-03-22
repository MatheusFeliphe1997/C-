var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<Produto> produtos = new List<Produto>();
produtos.Add(new Produto("Celular", "IOS"));
produtos.Add(new Produto("Celular", "Android"));
produtos.Add(new Produto("Televisão", "Samsung"));
produtos.Add(new Produto("Notbook", "Avell"));


//EndPoints - Funcionalidades
//Get: http://localhost:5155
app.MapGet("/", () => "Minha primeira API C# com watch");

//Get: http://localhost:5155/api/produtos7listar
app.MapGet("/api/produto/listar", () => "Lista de produtos");

//Post: http://localhost:5155/api/produtos/cadastrar
app.MapPost("/api/produto/cadastrar", () => "Cadastro de produtos");

app.Run();

record Produto(string Nome, string Descricao);
