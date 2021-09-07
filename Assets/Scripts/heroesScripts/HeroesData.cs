[System.Serializable]
public class HeroesData
{
    public HeroesStat[] Heroes;
}

[System.Serializable]
public class HeroesStat
{
    public string Name;
    public string Level;
    public string Health;
    public string Defence;
    public string Mana;
    public string Price;
}
