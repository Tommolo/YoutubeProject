using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    int score = 0;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Avvenuta Collisone");
        Destroy(gameObject);
        score++;
        Debug.Log("Score: " + score);
    }
}