using UnityEngine;
using System.Collections;

public class Killplane : MonoBehaviour
{
    private GameManager gm;

    private void Awake()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

   private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player")
        {
            //collider.GetComponentInChildren<Camera>().transform.parent = null;
            Destroy(collider.gameObject);
            gm.Dead();
        }

    }
}
