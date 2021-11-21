using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBoard : MonoBehaviour
{
    public Player firstPlayer;
    public Player secondPlayer;

    public Card[] firstHand;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(firstPlayer, new Vector3(0, -33, 0), Quaternion.identity);
        firstPlayer.ShowDeck();
    }

    // Update is called once per frame
    void Update()
    {
    }
}
