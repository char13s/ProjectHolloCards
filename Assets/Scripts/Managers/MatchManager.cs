using UnityEngine;

public class MatchManager : MonoBehaviour
{
    public static MatchManager Instance { get; private set; }

    private void Awake() => Instance = this;

    public void EvaluateRound(CardData player1Card, CardData player2Card) {
        int p1Value = player1Card.GetEffectiveValue();
        int p2Value = player2Card.GetEffectiveValue();

        if (p1Value > p2Value) {
            // Player 1 wins round, award cards/points
        }
        else if (p2Value > p1Value) {
            // Player 2 wins round
        }
        else {
            // Tie / Draw handling
        }
    }
}