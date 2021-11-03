using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;
using System.Runtime.InteropServices;

public class HPowerUp : MonoBehaviour
{
    [DllImport("ModDLL")]
    public static extern float getHPup();

    static float HPup = 3f;
    static float speed = 180;

    private GameObject player;
    private bool dirty = false;

    private void Start()
    {
        HPup = getHPup();
        dirty = false;
        player = GameObject.Find("Player");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 6)
        {
            collision.gameObject.GetComponent<Player>().ChangeHealth(HPup);
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        if((Mathf.Abs(player.transform.position.x - gameObject.transform.position.x) <= 17f) 
            && (Mathf.Abs(player.transform.position.y - gameObject.transform.position.y) <= 13f))
        {
            dirty = true;
        }

        if (dirty)
        {
            transform.rotation *= Quaternion.AngleAxis(Time.deltaTime * speed, Vector3.up);
        }

        dirty = false;

    }
}
