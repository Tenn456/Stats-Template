using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<GameObject> units = new List<GameObject>();
    public Transform[] spawnPoint;
    public int index;
    public int unitSpawnAmount;
    public GameObject spawnedUnit;

    // Start is called before the first frame update
    void Start()
    {
        SpawnUnit();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnUnit()
    {
        if (units.Count == 0) return;

        unitSpawnAmount = Random.Range(1, 3);
        //unitSpawnAmount = 3;

        for (int i = 0; i < unitSpawnAmount; i++)
        {
            index = Random.Range(0, units.Count);
            GameObject unit = units[index];

            spawnedUnit = Instantiate(unit, spawnPoint[i].position, Quaternion.identity);

            units.Add(spawnedUnit);
        }
    }
}
