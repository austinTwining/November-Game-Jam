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
    public CardType type = CardType.Offensive;
    public Element element = Element.Earth;
    public int damage = 0;
    public int defense = 0;
    public int staminaCost = 0;
    public BoxCollider2D boxCollider;

    public SpriteRenderer spriteRenderer;
    public Sprite offensiveSprite;
    public Sprite defensiveSprite;

    // Start is called before the first frame update
    void Start()
    {
        boxCollider = this.GetComponent<BoxCollider2D>();
        spriteRenderer = this.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1)) {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);

            if (hit.collider == boxCollider) {
                flip();
            }
        }

        if(type == CardType.Offensive)spriteRenderer.sprite = offensiveSprite;
        if(type == CardType.Defensive)spriteRenderer.sprite = defensiveSprite;
    }

    void flip(){
        type = type == CardType.Offensive ? type = CardType.Defensive : type = CardType.Offensive;
    }

    public void Move(int x, int y){
    }
}
