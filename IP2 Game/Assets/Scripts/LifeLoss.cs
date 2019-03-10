using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeLoss : MonoBehaviour
{
    public Slider healthBar;
    public static int health;

    void Start()
    {
        health = 100;
    }
    private void Update()
    {
        ChangeHealth();
        healthBar.value = health;
    }
    void ChangeHealth()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            health = health - 20;
        }
    }

    public void LoseHealth()
    {
        health = health - 20;
    }
}
