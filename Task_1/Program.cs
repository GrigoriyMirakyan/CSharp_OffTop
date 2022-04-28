Console.WriteLine("Эта программа поможет выбрать фильм для вечернего просмотра");
Console.WriteLine("Как вас зовут?");
string name = Console.ReadLine();
Console.WriteLine("Здравствуйте, " + name);
Console.WriteLine("Фильм какого жанра, Вы бы хотели посмотреть: комедия, фантастика, триллер, боевик или драма?");
string genre = Console.ReadLine();
Console.WriteLine("В таком случае, порекомендую посмотреть следующие фильмы: ");
if (genre == "комедия")
{
    Console.WriteLine("Главный герой");
    Console.WriteLine("Дедпул");
    Console.WriteLine("Секс по дружбе");
}
else if (genre == "фантастика")
{
    Console.WriteLine("Веном");
    Console.WriteLine("Хэнкок");
    Console.WriteLine("Мстители");
}
else if (genre == "триллер")
{
    Console.WriteLine("Аватар");
    Console.WriteLine("Начало");
    Console.WriteLine("Побег из Шоушенка");
}
else if (genre == "боевик")
{
    Console.WriteLine("Джентельмены");
    Console.WriteLine("Никто");
    Console.WriteLine("Гнев человеческий");
}
else
{
    Console.WriteLine("Дом GUCCI");
    Console.WriteLine("Корль Ричард");
    Console.WriteLine("Отец");
}
Console.ReadLine();
