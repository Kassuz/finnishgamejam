using UnityEngine;
using System.Collections;

public class Fish : MonoBehaviour
{


    private Rigidbody2D rb2d;


    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        rb2d.AddForce( 50 * new Vector2(-5, 5));
    }
  
}
