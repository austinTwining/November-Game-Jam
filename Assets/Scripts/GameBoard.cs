using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBoard : MonoBehaviour
{

    public GameObject firstPlayer;
    public GameObject secondPlayer;

    // Start is called before the first frame update
    void Start()
    {
        firstPlayer.GetComponent<Player>().ShowDeck();
    }

    // Update is called once per frame
    void Update()
    {
    }
}
