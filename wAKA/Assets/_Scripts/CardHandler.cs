using System.Collections;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CardHandler : MonoBehaviour
{
    // Start is called before the first frame update
    public Deck Deck;

    [SerializeField]
    private GameObject CardPrefab;

    [SerializeField]
    private GameObject ImageLevelPrefab;

    private void Start()
    {
        StartCoroutine(ShowCards());
    }

    private GameObject CreateCard(Card Card)
    {
        Card.PrintInfo();

        var cardObject = Instantiate(CardPrefab);

        var cardName = cardObject
            .GetComponentsInChildren<TextMeshProUGUI>()
            .FirstOrDefault(x => x.name == "CardName");
        var cardAttack = cardObject
            .GetComponentsInChildren<TextMeshProUGUI>()
            .FirstOrDefault(x => x.name == "CardAttack");
        var cardDefense = cardObject
            .GetComponentsInChildren<TextMeshProUGUI>()
            .FirstOrDefault(x => x.name == "CardDefense");

        cardName.text = Card.Name;
        cardAttack.text = Card.Attack.ToString();
        cardDefense.text = Card.Health.ToString();

        var cardLevel = GameObject
            .FindGameObjectWithTag("Level");

        for (int i = 0; i < Card.Level; i++)
        {
            var star = Instantiate(ImageLevelPrefab);
            star.transform.SetParent(cardLevel.transform);
            
        }

        if (Card.Image != null)
        {
            var cardImage = cardObject
                .GetComponentInChildren<Image>();
            cardImage.sprite = Card.Image;
        }

        return cardObject;
    }

    private IEnumerator ShowCards()
    {
        foreach (var card in Deck.Cards)
        {
            var go = CreateCard(card);
            yield return new WaitForSeconds(1);
            Destroy(go);
            yield return new WaitForSeconds(1);
        }
    }
}