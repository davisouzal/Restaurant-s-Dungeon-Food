﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeDrop : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float timeMove;

    private float timeCount;

    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        timeCount += Time.deltaTime;
        if (timeCount < timeMove)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.GetComponent<PlayerItems>().totalSlime++;
            Destroy(gameObject);
        }
    }
}
