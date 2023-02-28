using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManzSpawner : MonoBehaviour
{
    [SerializeField] private float minDistY;
    [SerializeField] private float maxDistX;
    [SerializeField] private float speed;
    [SerializeField] private GameObject Manzana;
    [SerializeField] private float timeToSpawn;

    private float timer;


    void Start()
    {
        timer = timeToSpawn;
    }

    
    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            timer = timeToSpawn;
            float distRandom = Random.Range(minDistY, maxDistX);
            GameObject objeto = Instantiate(Manzana, new Vector3(15, distRandom, 0), Quaternion.identity);
            objeto.GetComponent<MovManz>().vel = speed;
        }
    }
}
