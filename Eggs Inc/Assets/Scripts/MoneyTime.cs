using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyTime : MonoBehaviour
{
    public GameObject[] Chicken;
        int moola = 0;


    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
        moola = moola + 1;
        Debug.Log("Money:" + moola);
    }

}
