using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsScript : MonoBehaviour
{
    public int myNum;
    private CoinMachine generate;
    private Renderer rend;


    void Start()
    {
        generate = GetComponentInParent<CoinMachine>();
        rend = GetComponent<Renderer>();
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            generate.Message(myNum);
            rend.material.color = Color.red;
        }
    }
}
