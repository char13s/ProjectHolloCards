// 2. VIEW LAYER (Attached to the Card Prefab)
using UnityEngine;
using TMPro;

public class CardView : MonoBehaviour
{
    [SerializeField] private TMP_Text rankText;
    [SerializeField] private TMP_Text colorText;

    public CardData Data { get; private set; }
    private PlayersHand ownerHand;

    public void Initialize(CardData data, PlayersHand hand) {
        Data = data;
        ownerHand = hand;

        // Update visuals
        if (rankText != null) rankText.text = data.Rank.ToString();
        if (colorText != null) colorText.text = data.CardColor.ToString();
    }

    public void OnCardClicked() {
        ownerHand.PlayCard(this);
    }
}