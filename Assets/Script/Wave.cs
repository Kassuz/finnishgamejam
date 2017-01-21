using UnityEngine;
using System.Collections;

public class Wave : MonoBehaviour
{
    [SerializeField] private float moveHeight;
    [SerializeField] private float speed;

    private float startingHeight;
    private bool movingDown;

    private void Awake()
    {
        startingHeight = transform.position.y;
        Destroy(gameObject, 15f);
    }

    private void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime * speed);

        if (transform.position.y > startingHeight + moveHeight)
            movingDown = true;
        if (transform.position.y < startingHeight - moveHeight)
            movingDown = false;

        if (movingDown)
            transform.Translate(Vector2.down * Time.deltaTime);
        else
            transform.Translate(Vector2.up * Time.deltaTime);

    }

    
}
