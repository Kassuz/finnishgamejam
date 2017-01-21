using UnityEngine;
using System.Collections;

public class FishSpawner : MonoBehaviour
{

    [SerializeField] private GameObject[] fishPrefabs;
    [SerializeField] private float playAreaSize;
    [SerializeField] private float spawnHeight;
    [SerializeField] private bool showGizmos;
    [SerializeField] private float spawnTime;

    private float timer;

    private void Update()
    {
        if (timer < 0f)
        {
            SpawnFish();
            timer = spawnTime + Random.Range(-1.5f, .5f);
        }
        timer -= Time.deltaTime;
    }

    private void SpawnFish()
    {
        float playareaMaxX = playAreaSize / 2;
        float spawnX = Random.Range(-playareaMaxX, playareaMaxX);

        GameObject fish;
        float spawnChance = Random.Range(0f, 1f);
        //print(spawnChance);

        if (spawnChance < .05f)
            fish = fishPrefabs[3];
        else if (spawnChance < .15f)
            fish = fishPrefabs[2];
        else if (spawnChance < .4f)
            fish = fishPrefabs[1];
        else
            fish = fishPrefabs[0];


        Instantiate(fish, new Vector2(spawnX, spawnHeight), Quaternion.identity);
    }
    
    // Draw a wirecube to the scene for easier play area setup
    private void OnDrawGizmos()
    {
        if (showGizmos)
            Gizmos.DrawWireCube(new Vector3(0, spawnHeight), new Vector3(playAreaSize, 1));
    }


}
