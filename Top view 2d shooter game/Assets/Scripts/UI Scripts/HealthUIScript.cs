using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

// This script is responsible for the changing the healthbar of the player
public class HealthUIScript : MonoBehaviour
{
    public Slider healthBar;
    public TextMeshProUGUI healthNumber;
    public Color lingerDamageColor;
    private Color normalHealthColor;


    private void Start()
    {
        normalHealthColor = healthBar.transform.GetChild(0).GetComponent<Image>().color;
    }
    
    // Sets the health of the healthbar to max when it's made
    public void SetMaxHealth(float maxHealth)
    {
        healthNumber.text = Convert.ToString(maxHealth);
        healthBar.maxValue = maxHealth;
    }

    // changes the value of the heathbar
    public void SetHealth(float health)
    {
        healthBar.value = health;
        healthNumber.text = Convert.ToString(healthBar.value);
    }
}
