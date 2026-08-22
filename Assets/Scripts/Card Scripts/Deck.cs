// 4. DECK MANAGEMENT
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    private List<CardData> drawPile = new List<CardData>();

    private void Awake() {
        BuildDeck();
        Shuffle();
    }

    private void BuildDeck() {
        // Populate deck with standard cards and item cards
        for (int c = 0; c < 4; c++) {
            for (int r = 0; r < 10; r++) {
                drawPile.Add(new CardData {
                    Rank = (RankSuit)r,
                    CardColor = (ColorSuit)c,
                    Type = CardType.Standard
                });
            }
        }
    }

    public void Shuffle() {
        for (int i = 0; i < drawPile.Count; i++) {
            CardData temp = drawPile[i];
            int randomIndex = Random.Range(i, drawPile.Count);
            drawPile[i] = drawPile[randomIndex];
            drawPile[randomIndex] = temp;
        }
    }

    public CardData DrawCard() {
        if (drawPile.Count == 0) return null;

        CardData drawn = drawPile[0];
        drawPile.RemoveAt(0);
        return drawn;
    }
}