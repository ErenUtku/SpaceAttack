using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject asteroid;
   
    
    void Update()
    {
        if (Random.Range(0, 100) < 1)
        {
            //Instantiate(asteroid, this.transform.position + new Vector3(Random.Range(-10,10),0,0), Quaternion.identity);
            GameObject a = Pool.singleton.Get("Asteroid");
            if (a != null)
            {
                a.transform.position = this.transform.position + new Vector3(Random.Range(-10, 10), 0, 0);
                a.SetActive(true);
            }
        }
    }

}
