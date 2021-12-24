using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransGas : MonoBehaviour
{
    [SerializeField] List<Sprite> sprites;
    [SerializeField] GameObject o2;
    SpriteRenderer spriteRenderer;
    int countPre = 0;
    int countPost = 0;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
        countPost = sprites.Count;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<CarbonDO>())
        {

            if (countPre >= countPost)
            {
                GameArea.activePlaces[(int)transform.position.x, (int)transform.position.y] = 0;
                Destroy(gameObject);
            }
            else if (countPost > 0)
            {
                spriteRenderer.sprite = sprites[countPre];
                countPre++;
            }
            Destroy(collision.gameObject);
            Destroy(Instantiate(o2, transform.position, transform.rotation), 5);

        }

    }
}
