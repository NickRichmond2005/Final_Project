using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float speed = 0.1f;
    public Vector3 pointA;
    public Vector3 pointB;

    // Start is called before the first frame update
    void Start()
    {
        pointA = transform.position;
        pointB = transform.position + new Vector3(6, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        float time = Mathf.PingPong(Time.time * speed, 1);

        transform.position = Vector3.Lerp(pointA, pointB, time);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Player has died.");
            Main.ResetPlayer();
        }
    }
}
