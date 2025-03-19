using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vacham : MonoBehaviour
{
    private Manager gameManager;
    private void Awake()
    {
        gameManager = FindAnyObjectByType<Manager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Coin"))
        {
            Destroy(collision.gameObject);
            gameManager.AddScore(1);            
        }
    }
}
