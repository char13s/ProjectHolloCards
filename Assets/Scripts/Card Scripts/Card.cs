using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;
public class Card : MonoBehaviour,IPointerEnterHandler, IPointerExitHandler
{
    RankSuit rank;
    ColorSuit color;
    TextMeshProUGUI rankText;
    Image colorImage;
    private PlayersHand hand;
    bool played;
    public RankSuit Rank { get => rank; set => rank = value; }
    public ColorSuit CardColor { get => color; set => color = value; }
    public PlayersHand Hand { get => hand; set => hand = value; }
    public bool Played { get => played; set => played = value; }

    private void Start() {
        SetUpCard();
    }
    public void SetUpCard() {
        rankText = GetComponentInChildren<TextMeshProUGUI>();
        colorImage = GetComponentInChildren<Image>();
        rankText.text = ((int)rank).ToString();
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
    public void PlayCard() {
        Played = true;

        // 1. Remove from logical hand data structure
        //Hand.hand.Remove(this);

        // 2. Reparent to the play area (worldPositionStays = false keeps clean UI transforms)
        transform.SetParent(Hand.playPoint.transform, false);

        // 3. Reset local transform values to align cleanly inside the play point
        transform.localPosition = Vector3.zero;
        transform.localRotation = Quaternion.identity;
        transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);
    }

    void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData) {
        if(!Played)
            colorImage.gameObject.transform.position+= new Vector3(0, 20, 0);
    }

    void IPointerExitHandler.OnPointerExit(PointerEventData eventData) {
        if (!Played)
            colorImage.gameObject.transform.position-= new Vector3(0, 20, 0);
    }
}
