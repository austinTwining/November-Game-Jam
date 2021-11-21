using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static int handSize = 2;
    public static int deckSize = 4;
    public int health = 8;
    public int stamina = 8;
    public List<GameObject> deck = new List<GameObject>();
    public List<GameObject> hand = new List<GameObject>();

    public bool isStunned = false;

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

            for(int i = 0; i < deck.Count; i++){
                if(hit.collider == deck[i].GetComponent<BoxCollider2D>()){
                    if(hand.Count < handSize){
                        hand.Add(Instantiate(deck[i]));
                        Destroy(deck[i]);
                        deck.RemoveAt(i);
                    }
                    
                }
            }
            for(int i = 0; i < hand.Count; i++){
                if (hit.collider == hand[i].GetComponent<BoxCollider2D>()){
                    deck.Add(Instantiate(hand[i]));
                    Destroy(hand[i]);
                    hand.RemoveAt(i);
                    ShowDeck();
                }
            }
        }

        for(int i = 0; i < hand.Count; i++){
            if(hand[i]) hand[i].transform.position = new Vector3((i*2) - 1, 0, 0);
        }
    }

    public void ShowDeck(){
        for(int i = 0; i < deck.Count; i++){
            deck[i].transform.position = new Vector3((i*2) - 3, -3, 0);
            Debug.Log(deck[i] + " : " + deck[i].transform.position);
        }
    }
    public void HideDeck(){
        for(int i = 0; i < deck.Count; i++){
            deck[i].transform.position = new Vector3(0, -13, 0);
            Debug.Log(deck[i] + " : " + deck[i].transform.position);
        }
    }

    bool addCardToHand(GameObject card){
        if(hand.Count < handSize){
            hand.Add(card);
            return true;
        }else{
            return false;
        }
    }
}
