using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public int health = 8;
    public int stamina = 8;
    public Card[] deck;

    public bool isStunned = false;
    public bool isCurrent = false;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 4; i++){
            Instantiate(deck[i], new Vector3(transform.position.x, transform.position.y, 0), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);

            foreach(var card in deck){
                if (hit.collider == card.boxCollider){

                }
            }
        }
    }

    public void ShowDeck(){
        for(int i = 0; i < deck.Length; i++){
            deck[i].transform.position = new Vector3(i*2, -3, 0);
        }
    }
    void HideDeck(){

    }
}
