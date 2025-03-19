using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] private GameObject PreFabs;
    private float cowndown;
    [SerializeField] private float TimeSpawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spawnItem();
    }
    private void spawnItem()
    {
        cowndown -= Time.deltaTime;

        if (cowndown < 0)
        {          
            Instantiate(PreFabs, new Vector3(Random.Range(-8f,50f),0,5f),Quaternion.identity);
            cowndown = TimeSpawn;
        }
    }
}
