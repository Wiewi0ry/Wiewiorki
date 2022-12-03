using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gameplayy : MonoBehaviour
{
    public static int numberOfCoins;
    public GameObject coinOriginal;
    public GameObject coinContainer;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name != "Player")
        {
            return;
        }
        Destroy(gameObject);
    }

    void Start()
    {
        CreateCoins(Random.Range(10, 150));

    }


    private void CreateCoins(int coinsNum)
    {
        for (int i = 0; i < coinsNum; i++)
        {
            // GameObject CoinClone = Instantiate(coinOriginal);
            GameObject CoinClone = Instantiate(coinOriginal, new Vector3(transform.position.x, coinOriginal.transform.position.y, i * 0.75f), coinOriginal.transform.rotation);
            CoinClone.name = "CoinClone" + (i + 1);
            CoinClone.transform.parent = coinContainer.transform;
        }

    }
}