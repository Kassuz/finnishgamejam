using UnityEngine;
using System.Collections;

public class WaveBackAndForth : MonoBehaviour
{
    [SerializeField] private float startDelay;

    [SerializeField] private bool movingRight;
    private float startingX;
    private float moveDist = .5f;

    private void Awake()
    {
        startingX = transform.position.x;
    }

    private void Update()
    {
        if (transform.position.x > startingX + moveDist)
            movingRight = false;
        if (transform.position.x < startingX - moveDist)
            movingRight = true;

        if (movingRight)
            transform.Translate(Vector2.right * Time.deltaTime);
        else
            transform.Translate(Vector2.left * Time.deltaTime);

    }
}
