using Br.Com.FiapInvestiments.Domain.Entidades;

namespace Br.Com.FiapInvestiments.Infrastructure.Data
{
    public static class ContextInitializer
    {
        public static void Initialize(ApiContext context)
        {
            try
            {
                context.Database.EnsureCreated();

                if (!context.TiposUsuarios.Where(p => p.Nome == "Administrador").Any())
                {
                    var admin = new TipoUsuario { Nome = "Administrador", Descricao = "Usuário administrador", Status = true, CriadoEm = DateTime.UtcNow };
                    context.TiposUsuarios.Add(admin);

                    var consultor = new TipoUsuario { Nome = "Consultor", Descricao = "Usuário consultor", Status = true, CriadoEm = DateTime.UtcNow };
                    context.TiposUsuarios.Add(consultor);

                    var investidor = new TipoUsuario { Nome = "Investidor", Descricao = "Usuário investidor", Status = true, CriadoEm = DateTime.UtcNow };
                    context.TiposUsuarios.Add(investidor);

                    context.SaveChanges();

                    if (!context.Usuarios.Where(u => u.Nome == "api-admin").Any())
                    {
                        var apiAdmin = new Usuario
                        {
                            Cpf = "85165985008",
                            Nome = "api-admin",
                            Email = "admin@api-admin.com.br",
                            Login = "admin",
                            Senha = "admin",
                            UltimoAcesso = DateTime.UtcNow,
                            TipoUsuario = admin,
                        };

                        context.Usuarios.Add(apiAdmin);
                        context.SaveChanges();
                    }
                }

                if (!context.Perfis.Any())
                {
                    var conservador = new Perfil { Nome = "Conservador", Descricao = "Investidor conservador", Status = true, CriadoEm = DateTime.UtcNow };
                    context.Perfis.Add(conservador);

                    var moderado = new Perfil { Nome = "Moderado", Descricao = "Investidor moderado", Status = true, CriadoEm = DateTime.UtcNow };
                    context.Perfis.Add(moderado);

                    var arrojado = new Perfil { Nome = "Arrojado", Descricao = "Investidor arrojado", Status = true, CriadoEm = DateTime.UtcNow };
                    context.Perfis.Add(arrojado);

                    context.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
