using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Card : MonoBehaviour
{
    RankSuit rank;
    ColorSuit color;
    TextMeshProUGUI rankText;
    Image colorImage;
    public RankSuit Rank { get => rank; set => rank = value; }
    public ColorSuit CardColor { get => color; set => color = value; }

    private void Start() {
        SetUpCard();
    }
    public void SetUpCard() {
        rankText = GetComponentInChildren<TextMeshProUGUI>();
        colorImage = GetComponentInChildren<Image>();
        rankText.text = rank.ToString();
        colorImage.color = GetColorFromSuit(color);
    }
    Color GetColorFromSuit(ColorSuit color) {
        switch (color) { 
        case ColorSuit.Blue:
            return Color.blue;
                case ColorSuit.Green:
                return Color.green;
                case ColorSuit.Yellow:
                return Color.yellow;
                case ColorSuit.Red:
                return Color.red;
                default:
                return Color.white;
        }
    }
    public void CreateCard() { 
        
    }
}
