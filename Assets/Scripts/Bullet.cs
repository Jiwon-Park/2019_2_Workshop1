﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 5f;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.transform.tag);

        if (collision.transform.CompareTag("Player"))
        {
            collision.transform.position = new Vector3(0, 3, -40);
        }
        if (collision.transform.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }
    }
}
