using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{

    [Header("Contador de Items")]
    public static GameManager instance; //Singleton del GameManager
    public TMP_Text itemCountText; //Referencia la cantidad de items recolectados en texto

    private int itemCount = 0; //Contador de Objetos recolectados


    private void Awake()
    {
        instance = this; 
    }

    public void CollectItem(int value)
    {
        itemCount += value;
        UpdateItemCountText();
    }

    void UpdateItemCountText()
    {
        itemCountText.text = "X:  " + itemCount.ToString();
    }


}
