using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControllerCapsule: MonoBehaviour
{

    [Header("PARAMETROS VIDAS")]
    public int maxLives = 3;
    private int currentLives;
    public Image[] hearts; 
    public  GameObject gameOver;


    // Start is called before the first frame update
    void Start()
    {
        currentLives = maxLives;
        UpdateHeartsUI();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void LoseLife()
    {
        currentLives--;


        //Si el personaje muere, puedes activar animación de morir y pantalla game over
        if (currentLives <= 0 )
        {
            gameOver.SetActive(true);
        }


       
        UpdateHeartsUI();

    }


    private void UpdateHeartsUI()
    {
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < currentLives)
            {
                hearts[i].enabled = true;
               
            }
            else
            {
                hearts[i].enabled = false;
               
            }
        }
    }


  
  


}
