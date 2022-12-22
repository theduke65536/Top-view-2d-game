using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class PlayerUIScript : MonoBehaviour
{
    public Slider healthBar;
    public TextMeshProUGUI healthNumber;
    

    public void SetMaxHealth(float maxHealth)
    {
        healthNumber.text = Convert.ToString(maxHealth);
        healthBar.maxValue = maxHealth;
    }


    public void OnTakeDamage(float damage)
    {
        healthBar.value -= damage;
        healthNumber.text = Convert.ToString(healthBar.value);
    }
}
