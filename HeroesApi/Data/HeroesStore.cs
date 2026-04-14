
using HeroesApi.Models;

namespace HeroesApi.Data;

public static class HeroesStore {
    public static List<Hero> Heroes { get; } = new(){
        new Hero
        {
            Id = 1,
            Name = "Человек-паук",
            RealName = "Питер Паркер",
            Universe = Universe.Marvel,
            PowerLevel = 75,
            Powers = new(){"патуина", "лазане по стенам", "паучье чутье"},
            Weapon = new() {Name = "Паутинострел", IsRanged = true},
            InternalNotes = "Любтимый герой редактора и мой"

        },
        new Hero
        {
            Id = 2,
            Name = "Бэтмен",
            RealName = "Брюс Уэйн",
            Universe = Universe.DC,
            PowerLevel = 70,
            Powers = new(){"интеллект", "боевые искусства", "технологии"},
            Weapon = new() {Name = "БЭтэранг", IsRanged = true},
            InternalNotes = "Богатый малый"

        },
        new Hero
        {
            Id = 3,
            Name = "Железный человек",
            RealName = "Тони Старк",
            Universe = Universe.Marvel,
            PowerLevel = 85,
            Powers = new(){"броня", "полет", "лазеры"},
            Weapon = new() {Name = "Костюм от бати", IsRanged = true},
            InternalNotes = "Я - Железнвй человек"

        },
        new Hero
        {
            Id = 4,
            Name = "Грут",
            RealName = "Грут",
            Universe = Universe.Marvel,
            PowerLevel = 90,
            Powers = new(){"регенерация", "фотосинтез", "дерево"},
            Weapon = new() {Name = "Крапива", IsRanged = false},
            InternalNotes = "Я есть Грут"

        },
        new Hero
        {
            Id = 5,
            Name = "Тор",
            RealName = "Тор Одинсон",
            Universe = Universe.Marvel,
            PowerLevel = 95,
            Powers = new(){"молния", "полет", "бессмертие"},
            Weapon = new() {Name = "Мьельнир", IsRanged = false},
            InternalNotes = "Он кощей получпется"

        },
        new Hero
        {
            Id = 6,
            Name = "Росомаха",
            RealName = "Логан",
            Universe = Universe.Marvel,
            PowerLevel = 85,
            Powers = new(){"маникюр балерина", "суперсила", "замедленное старение"},
            Weapon = new() {Name = "Когти", IsRanged = false},
            InternalNotes = "Лучший у меня есть"

        },
        new Hero
        {
            Id = 7,
            Name = "Дэдпул",
            RealName = "Уэйд Улсон",
            Universe = Universe.Marvel,
            PowerLevel = 80,
            Powers = new(){"регенерация", "владение кухонным ножом", "долтовня"},
            Weapon = new() {Name = "Катаны и котлеты", IsRanged = true},
            InternalNotes = "Разрушает четвертую стену"

        },
    };
}