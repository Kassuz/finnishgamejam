using UnityEngine;
using System.Collections;

public class WaveSpawner : MonoBehaviour
{
    [SerializeField] private GameObject wavePrefab;
    [SerializeField] private float spawnTime;

    private float timer;

    private void Update()
    {
        if (timer < 0f)
        {
            Instantiate(wavePrefab, transform.position, Quaternion.identity);
            timer = spawnTime + Random.Range(-.5f, .5f);
        }
        timer -= Time.deltaTime;
    }

}
