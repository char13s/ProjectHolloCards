using System.Collections.Generic;
using UnityEngine;

public class PlayersHand : MonoBehaviour
{
    public List<Card> hand = new List<Card>();
    public Deck deck;
    public GameObject cardPrefab;
    public GameObject handPoint;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetCards();
    }
    private void GetCards() {
        for (int i = 0; i < 5; i++) {
            Card card = deck.DealCard();
            hand.Add(card);
            GameObject newCard = Instantiate(cardPrefab, handPoint.transform);
            newCard.GetComponent<Card>().Rank = card.Rank;
            newCard.GetComponent<Card>().CardColor = card.CardColor;
        }
    }
}
