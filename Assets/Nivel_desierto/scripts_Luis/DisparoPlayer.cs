using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoPlayer : MonoBehaviour
{
    [Header("Balas")]
    public GameObject bala;
    public float tiempoVidaBala;
        

    // Start is called before the first frame update
    void Start()
    {
       
        if (tiempoVidaBala <= 0) {tiempoVidaBala = 1f;}
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space)) { 
            Destroy( Instantiate(bala, transform.position, Quaternion.identity), tiempoVidaBala);
        }
    }
}
