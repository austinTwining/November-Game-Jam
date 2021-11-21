using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static int handSize = 2;
    public static int deckSize = 4;
    public int health = 8;
    public int stamina = 8;
    public GameObject[] deck = new GameObject[deckSize];
    public GameObject[] hand = new GameObject[handSize];

    public bool isStunned = false;
    public bool isCurrent = false;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);

            for(int i = 0; i < deckSize; i++){
                if (hit.collider == deck[i].GetComponent<BoxCollider2D>()){
                    addCardToHand(deck[i]);
                }
            }
            for(int i = 0; i < handSize; i++){
                if (hit.collider == hand[i].GetComponent<BoxCollider2D>()){
                    removeCardFromHand(i);
                }
            }
        }

        foreach(var card in hand){
            card.transform.position = new Vector3(0,0,0);
        }
    }

    public void ShowDeck(){
        for(int i = 0; i < deck.Length; i++){
            deck[i].transform.position = new Vector3((i*2) - 3, -3, 0);
            Debug.Log(deck[i] + " : " + deck[i].transform.position);
        }
    }
    public void HideDeck(){
        for(int i = 0; i < deck.Length; i++){
            deck[i].transform.position = new Vector3(0, -13, 0);
            Debug.Log(deck[i] + " : " + deck[i].transform.position);
        }
    }

    void addCardToHand(GameObject card){
        for(int i = 0; i < handSize; i++){
            if(!hand[i]){
                hand[i] = card;
                return;
            }
        }
    }
    void removeCardFromHand(int index){
        for(int i = 0; i < deckSize; i++){
            if(!deck[i]){
                deck[i] = hand[i];
                return;
            }
        }
    }
}
