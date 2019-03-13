using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeLoss : MonoBehaviour
{
    public RawImage Health;
    public static int health;
    public Texture m_texture;

    void Start()
    {
        Health = GetComponent<RawImage>();
        Health.texture = m_texture;
    }
    private void Update()
    {
        //ChangeHealth();
        // healthBar.value = health;
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
