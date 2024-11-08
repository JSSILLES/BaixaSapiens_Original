using Microsoft.EntityFrameworkCore;
using API_Baixa_Sapiens.Models;

namespace API_Baixa_Sapiens.Models
{
    public class ContextoAPI : DbContext
    {
        public ContextoAPI(DbContextOptions<ContextoAPI> options)
            : base(options)
        {
        }

        public DbSet<TblDocumento> TblDocumento { get; set; }

        // Aqui você pode adicionar outras entidades (tabelas) do seu banco de dados como DbSets
    }

}