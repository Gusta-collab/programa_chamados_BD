    using Microsoft.Extensions.Configuration;
    using System.IO;

    // Esta classe estática será acessível de qualquer lugar do seu projeto
    public static class ConfigurationHelper
    {
        // 1. A propriedade IConfiguration armazena todas as configurações carregadas
        public static IConfiguration Configuration { get; }

        // O construtor estático é executado apenas uma vez, na primeira vez que a classe é acessada.
        static ConfigurationHelper()
        {
            // 2. Constrói o objeto de configuração
            Configuration = new ConfigurationBuilder()
                // Define a pasta base (onde o .exe está rodando)
                .SetBasePath(Directory.GetCurrentDirectory())
                // Adiciona a fonte do arquivo JSON. Se ele não for encontrado, a aplicação irá falhar.
                .AddJsonFile("jsconfig1.json", optional: false, reloadOnChange: true)
                // Finaliza a construção
                .Build();
        }

        /// <summary>
        /// Método de conveniência para buscar strings de conexão
        /// </summary>
        /// <param name="name">O nome da chave da string de conexão (ex: "DB_Chamados")</param>
        public static string GetConnectionString(string name)
        {
            // O método GetConnectionString sabe como procurar em "ConnectionStrings:NomeDaChave"
            return Configuration.GetConnectionString(name); 
        }
    }