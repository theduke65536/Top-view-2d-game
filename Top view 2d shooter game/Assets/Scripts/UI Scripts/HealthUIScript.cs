using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using System.Net.Sockets;

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
    
    public IEnumerator LingerDamageColor(float lingerDamageLength)
    {
        Image healthImage = healthBar.transform.GetChild(0).GetComponent<Image>();

        healthImage.color = lingerDamageColor;
        yield return new WaitForSeconds(lingerDamageLength);
        healthImage.color = normalHealthColor;

    }
}
