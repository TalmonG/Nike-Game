using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickuphealth : MonoBehaviour
{
    PlayerMovement player;
    Health health;
    private int pickupValue = 1;
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<PlayerMovement>();
        health = FindObjectOfType<Health>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            health.Healing(10);
            ScoreManager.instance.ChangeScore(pickupValue);
        }
    }
}
