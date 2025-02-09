using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{ 
    public int value;
    private CoinCollectible coinCollectible;

    private void Start()
    {
        coinCollectible = CoinCollectible.instance;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            CoinCollectible.instance.IncreaseCoins(value);
        }
    }
}
