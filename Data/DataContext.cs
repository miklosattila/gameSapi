using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Catolog.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Player> Players => Set<Player>();
        public DbSet<Map> Maps => Set<Map>();
        public DbSet<MapEntity> MapEntitys => Set<MapEntity>();
        public DbSet<MapEntityType> MapEntityTypes => Set<MapEntityType>();
        public DbSet<Question> Questions => Set<Question>();
        public DbSet<QustionAnswer> QustionAnswers => Set<QustionAnswer>();
        public DbSet<Quiz> Quizzes => Set<Quiz>();
        public DbSet<QuizAnswer> QuizAnswers => Set<QuizAnswer>();
        public DbSet<QustionAnswerPicked> QustionAnswersPicked => Set<QustionAnswerPicked>();
        public DbSet<PlayerMap> PlayerMap => Set<PlayerMap>();


    }
}