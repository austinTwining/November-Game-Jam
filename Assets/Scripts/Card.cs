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
    public int defense = 0;
    public int staminaCost = 0;

    public Transform transform;
    public BoxCollider2D boxCollider;

    // Start is called before the first frame update
    void Start()
    {
        transform = this.GetComponent<Transform>();
        boxCollider = this.GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);

            if (hit.collider == boxCollider) {
                flip();
            }
        }
    }

    public void OnPointerClick(PointerEventData pointerEventData){
        Debug.Log(" Game Object Clicked!");
    }

    void flip(){
        _type = _type == CardType.Offensive ? _type = CardType.Defensive : _type = CardType.Offensive;
    }
}
