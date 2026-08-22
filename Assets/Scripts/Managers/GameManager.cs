using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]private GameObject cardPrefab;
    public void CreateCard(Transform hand,Card card) {
        Instantiate(cardPrefab, hand);
    }
    public void PlayCard() { 
    
    }
}
