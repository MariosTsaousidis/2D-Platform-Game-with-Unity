using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinCollectible : MonoBehaviour
{
    public static CoinCollectible instance;

    public TMP_Text coinText;
    public int currentCoins = 0;
    [SerializeField] private AudioClip coinSound;

    void Awake()
    {
        //Check if instance already exists
        if (instance == null)
        {
            //if not, set instance to this
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (instance != null && instance != this)
            Destroy(gameObject);
    }

    private void OnGUI()
    {
        //coinText = GetComponent<TMP_Text>();
        coinText.text = currentCoins.ToString();

    }

    public void IncreaseCoins(int v)
    {
        currentCoins += v;
        SoundManager.instance.PlaySound(coinSound);
        coinText.text = currentCoins.ToString();
    }
}
