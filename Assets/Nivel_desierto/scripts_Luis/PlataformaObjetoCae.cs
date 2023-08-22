using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaObjetoCae : MonoBehaviour
{

    public Rigidbody2D objetoCae;

   
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            objetoCae.bodyType = RigidbodyType2D.Dynamic;
            objetoCae.mass = 5;
            Debug.Log("Hit");
        }
    }
}
