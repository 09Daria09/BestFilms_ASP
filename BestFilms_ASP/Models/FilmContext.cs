using BestFilms_ASP.Models;
using Microsoft.EntityFrameworkCore;

namespace BestFilms_ASP.Models
{
    public class FilmContext : DbContext
    {
        public DbSet<Film> Films { get; set; }
        public FilmContext(DbContextOptions<FilmContext> options) : base(options)
        {
        }

    }
public static class DbInitializer
{
    public static void Initialize(FilmContext context)
    {
        context.Database.EnsureCreated();

        if (context.Films.Any())
        {
            return;
        }

        var films = new Film[]
        {
            new Film { Title = "Начало", Director = "Кристофер Нолан", Genre = "Фантастика, Боевик, Триллер", ReleaseYear = 2010, PosterUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/ubj7fEmtNqxwtZtMk6wAIc0SCFJ.jpg", Description = "Путешествие в сознание человека с целью посадки идеи." },
            new Film { Title = "Побег из Шоушенка", Director = "Фрэнк Дарабонт", Genre = "Драма", ReleaseYear = 1994, PosterUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/yvmKPlTIi0xdcFQIFcQKQJcI63W.jpg", Description = "История о несгибаемом духе и надежде за решеткой." },
            new Film { Title = "Интерстеллар", Director = "Кристофер Нолан", Genre = "Фантастика, Драма, Приключения", ReleaseYear = 2014, PosterUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/vReLRjDV9XPhiOSEW7QWow4DXwf.jpg", Description = "Путешествие к звездам в поисках нового дома для человечества." },
            new Film { Title = "Леон", Director = "Люк Бессон", Genre = "Триллер, Драма, Криминал", ReleaseYear = 1994, PosterUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/qKvvqLOyfz6QDp7BH5OoQhYLfcb.jpg", Description = "История профессионального убийцы и его юной подопечной." },
            new Film { Title = "Форрест Гамп", Director = "Роберт Земекис", Genre = "Драма, Романтика", ReleaseYear = 1994, PosterUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/oTiRsQCIHJPUR7wA1chpTf8j9go.jpg", Description = "Жизнь обыкновенного человека с необыкновенной судьбой." },
            new Film { Title = "Матрица", Director = "Лана и Лилли Вачовски", Genre = "Фантастика, Боевик", ReleaseYear = 1999, PosterUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/a5cMdAGykFnzVhsyGhNYE0NEnkR.jpg", Description = "Хакер Нео открывает шокирующую правду о реальности." },
            new Film { Title = "Гладиатор", Director = "Ридли Скотт", Genre = "Исторический, Драма, Боевик", ReleaseYear = 2000, PosterUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/1wjNqlfsuHNTXTpCt2ZOV2iPxaf.jpg", Description = "Мстительный римский генерал вступает в гладиаторские бои, чтобы отомстить убийцам своей семьи и императора." },
            new Film { Title = "Бойцовский клуб", Director = "Дэвид Финчер", Genre = "Драма, Триллер", ReleaseYear = 1999, PosterUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/66RvLrRJTm4J8l3uHXWF09AICol.jpg", Description = "Разочарованный своим серым бытием мужчина оказывается втянут в подпольный клуб боев без правил и экспериментальную игру в саморазрушение." },
            new Film { Title = "Престиж", Director = "Кристофер Нолан", Genre = "Драма, Мистика, Триллер", ReleaseYear = 2006, PosterUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/9jMvxh1Ib6BPnE0pprRcaNibKDO.jpg", Description = "Два иллюзиониста викторианской эпохи вступают в смертельное соперничество, постоянно соревнуясь друг с другом за превосходство в искусстве обмана." },
            new Film { Title = "Властелин колец: Возвращение короля", Director = "Питер Джексон", Genre = "Фэнтези, Приключения, Драма", ReleaseYear = 2003, PosterUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/x6NqCWwU1SrQnvfdmVPAuATyUgD.jpg", Description = "Гэндальф и Арагорн возглавляют мир Средиземья против армии Саурона, чтобы отвлечь его внимание и дать шанс Фродо уничтожить Кольцо Всевластия." },
    };
        foreach (Film f in films)
        {
            context.Films.Add(f);
        }
        context.SaveChanges();
    }
}

}