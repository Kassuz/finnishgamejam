using UnityEngine;
using System.Collections;

public class Fish : MonoBehaviour
{
    [SerializeField] private float upperLimitX, lowerLimitX;
    [SerializeField] private float upperLimitY, lowerLimitY;

    public int pointValue;

    private Rigidbody2D rb2d;
    private SpriteRenderer sprite;
    private GameManager gm;


    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        sprite = GetComponentInChildren<SpriteRenderer>();
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();

    }

    private void Start()
    {
        float x = Random.Range(lowerLimitX, upperLimitX);
        float y = Random.Range(lowerLimitY, upperLimitY);
        int direction;
        if (Random.Range(0f, 1f) < .5f)
        {
            direction = 1;
            sprite.flipX = true;
        }
        else
        {
            direction = -1;
        }
        //print("Fish jumps x:" + x + " y:" + y);
        rb2d.AddForce(new Vector2(direction * x, y));
        Destroy(gameObject, 3f);
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player")
        {
            gm.AddPoints(pointValue);
            Destroy(gameObject);
        }
    }
}
