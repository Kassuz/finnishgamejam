using UnityEngine;
using System.Collections;

public class Killplane : MonoBehaviour
{

   private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player")
        {
            collider.GetComponentInChildren<Camera>().transform.parent = null;
            Destroy(collider.gameObject);
        }

    }
}
