using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    public List<Card> deck= new List<Card>();

    public Card DealCard()
    {
        Card dealtCard=CreateRandomCard();
        deck.Add(dealtCard);
        return dealtCard;
    }
    private Card CreateRandomCard() { 
        Card newCard = new Card();
        newCard.Rank = (RankSuit)Random.Range(0, 10);
        newCard.CardColor = (ColorSuit)Random.Range(0, 4);
        return newCard;
    }
}
