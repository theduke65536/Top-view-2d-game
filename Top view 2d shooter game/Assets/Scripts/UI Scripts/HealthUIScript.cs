using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class HealthUIScript : MonoBehaviour
{
    public Slider healthBar;
    public TextMeshProUGUI healthNumber;
    

    public void SetMaxHealth(float maxHealth)
    {
        healthNumber.text = Convert.ToString(maxHealth);
        healthBar.maxValue = maxHealth;
    }


    public void SetHealth(float health)
    {
        healthBar.value = health;
        healthNumber.text = Convert.ToString(healthBar.value);
    }
}
