using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenSpawn : MonoBehaviour
{

    public GameObject Evil;
    public GameObject Chicken;

    
    private void Start()
    {
        float randomNumber = Random.Range(0, 10);
    }
    void Update()
    {
        
        if (Input.anyKey)
        {
            var copy = Instantiate(Chicken);
            Destroy(copy, 5.0f);
        }

        if (Input.anyKey)
        {
            var coopy = Instantiate(Evil);
            Destroy(coopy, 10.0f);
        }
    }

    



}
