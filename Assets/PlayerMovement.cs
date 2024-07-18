using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 50;

    public static Action OnCoinCollected;
    public static Action OnCoinCollected2;
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Gold")
        {
            OnCoinCollected?.Invoke();
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "Gold2")
        {
            OnCoinCollected2?.Invoke();
            Destroy(other.gameObject);
        }
    }

    void Update()
    {
        Move();
    }

    public void Move()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 hareket = new Vector3(horizontal, 0, vertical) * speed * Time.deltaTime;

        transform.position += hareket;
    }
}
