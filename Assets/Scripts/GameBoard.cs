using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBoard : MonoBehaviour
{

    public GameObject firstPlayer;
    public GameObject secondPlayer;
    public GameObject[] globalDeck;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < globalDeck.Length; i++){
            firstPlayer.GetComponent<Player>().deck.Add(Instantiate(globalDeck[i]));
            secondPlayer.GetComponent<Player>().deck.Add(Instantiate(globalDeck[i]));
        }
        firstPlayer.GetComponent<Player>().ShowDeck();
    }

    // Update is called once per frame
    void Update()
    {
    }
}
