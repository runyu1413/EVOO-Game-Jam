using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MentalHealthBar : MonoBehaviour
{
    Image healthBar;
    float maxHealth = 100f;
    public static float health;

    // Start is called before the first frame update
    void Start()
    {
        healthBar = GetComponent<Image>();
        health = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.fillAmount = health / maxHealth;
    }
}
