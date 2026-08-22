// 1. DATA LAYER (ScriptableObject or pure C# class)
[System.Serializable]
public class CardData
{
    public RankSuit Rank;
    public ColorSuit CardColor;
    public CardType Type; // Regular, Item, etc.
    public int BonusValue;

    public int GetEffectiveValue() {
        return (int)Rank + BonusValue;
    }
}

public enum CardType { Standard, Item }