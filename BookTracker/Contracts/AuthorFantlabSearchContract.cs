namespace BookTracker.Contracts;

public class AuthorFantlabSearchContract
{
    // autor_id: Int,           # id автора
    public int autor_id { get; init; }
    // birthyear: Int,          # год рождения
    public int birthyear { get; init; }
    // country: String,         # страна
    public string country { get; init; }    
    // country_id: Int,         # id страны
    public int country_id { get; init; }
    // deathyear: Int,          # год смерти
    public int deathyear { get; init; }
    // doc: Int,                # ?
    public int doc { get; init; }
    // editioncount: Int,       # количество изданий
    public int editioncount { get; init; }
    // is_opened: Boolean,      # открыта ли страница автора
    public int is_opened { get; init; }
    // markcount: Int,          # количество оценок
    public int markcount { get; init; }
    // midmark: Int,            # средняя оценка автора * 100
    public int midmark { get; init; }
    // moviecount: Int,         # количество фильмов (экранизаций и т.д.)
    public int moviecount { get; init; }
    // name: String,            # имя в оригинале
    public string name { get; init; }    
    // pseudo_names: String,    # список псевдонимов
    public string pseudo_names { get; init; }
    // responsecount: Int,      # количество отзывов
    public int responsecount { get; init; }
    // rusname: String,         # русскоязычное имя
    public string rusname { get; init; }
    // weight: Int              # степень релевантности (влияет на порядковый номер в выдаче - чем больше, тем выше)
    public int weight { get; init; }

}