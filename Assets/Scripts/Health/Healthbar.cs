using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    public Health playerHealth;
    [SerializeField] private Image totalhealthBar;
    [SerializeField] private Image currenthealthBar;

    public void Start()
    {
        totalhealthBar.fillAmount = playerHealth.currentHealth / 10;
    }
    public void Update()
    {
        currenthealthBar.fillAmount = playerHealth.currentHealth / 10;
    }
}
