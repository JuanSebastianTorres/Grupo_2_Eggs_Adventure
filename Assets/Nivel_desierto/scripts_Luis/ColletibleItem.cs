using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColletibleItem : MonoBehaviour
{

    public int value = 1; //Valor al objeto que será recolectado


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) ; //Asegurar que el personaje tenga el tag "Player"
        {
            GameManager.instance.CollectItem(value); //llama a la funcion Game Manager
            Destroy(gameObject); //Destruimos el objeto recolectado
        }
    }


}
