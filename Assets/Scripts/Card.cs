using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public enum CardType{
    Offensive,
    Defensive
}
public enum Element{
    Earth,
    Air,
    Fire,
    Water
}

public class Card : MonoBehaviour
{
    public CardType _type = CardType.Offensive;
    public Element _element = Element.Earth;
    public int damage = 0;
    public int staminaCost = 0;

    

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World");
    }

    // Update is called once per frame
    void Update()
    {
    }

    void flip(){
        _type = _type == CardType.Offensive ? _type = CardType.Defensive : _type = CardType.Offensive;
    }
}
