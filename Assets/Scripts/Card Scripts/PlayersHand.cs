// 3. CONTROLLER LAYER (Player Hand Management)
using System.Collections.Generic;
using UnityEngine;

public class PlayersHand : MonoBehaviour
{
    public List<CardView> handViews = new List<CardView>();
    public Deck deck;
    public GameObject cardPrefab;
    public Transform handPoint;
    public Transform playPoint;

    private void Start() {
        DrawInitialHand();
    }

    private void DrawInitialHand() {
        for (int i = 0; i < 5; i++) {
            CardData data = deck.DrawCard();
            if (data == null) break;

            GameObject newCardObj = Instantiate(cardPrefab, handPoint);
            CardView view = newCardObj.GetComponent<CardView>();

            view.Initialize(data, this);
            handViews.Add(view);
        }
    }

    public void PlayCard(CardView cardView) {
        if (!handViews.Contains(cardView)) return;

        handViews.Remove(cardView);

        // Reparent cleanly without scale distortion
        cardView.transform.SetParent(playPoint, false);
        cardView.transform.localPosition = Vector3.zero;

        // Send to turn evaluator
        //MatchManager.Instance.SubmitPlay(this, cardView.Data);
    }
}