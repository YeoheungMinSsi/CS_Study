namespace ObserverPattern.homework;

[Flags]
public enum NewsCategory
{
    None = 0,
    PoliticsDomestic = 1 << 0,
    PoliticsInternational = 1 << 1,
    EconomyDomestic = 1 << 2,
    EconomyInternational = 1 << 3,
    SportsDomestic = 1 << 4,
    SportsInternational = 1 << 5,
    It = 1 << 6,
    Tech = 1 << 7,
    Culture = 1 << 8
}