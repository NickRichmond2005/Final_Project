using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    [Header("Inscribed")]
    public GameObject powerUpPrefab;

    public GameObject player;


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Player player = other.GetComponent<Player>();
            if (player != null)
            {
                player.PickupPowerUp();
                Destroy(gameObject);
            }
        }
    }
}
