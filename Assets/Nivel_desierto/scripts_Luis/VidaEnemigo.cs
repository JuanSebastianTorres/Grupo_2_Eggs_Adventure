using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaEnemigo : MonoBehaviour
{

    public int vidaTotalEnemigo;
    public int vidaActualEnemigo;
    public int danoRecibeEnemigo;
        bool enemigoRecuperaVida;
  
   

    // Start is called before the first frame update
    void Start()
    {
        if (vidaTotalEnemigo <= 0) { vidaTotalEnemigo = 10; }
        vidaActualEnemigo = vidaTotalEnemigo;

        if (danoRecibeEnemigo <= 0) { danoRecibeEnemigo = 1; }
    }

    // Update is called once per frame
    void Update()
    {
        if (vidaActualEnemigo <= 2)
        {
            gameObject.GetComponent<SpriteRenderer>().color = Color.red;
            enemigoRecuperaVida = true;
        }
        else { gameObject.GetComponent<SpriteRenderer>().color = Color.white; }

        if (enemigoRecuperaVida == true)
        {
            StartCoroutine("TiempoRecueracionVida");
        }
        

        if (vidaActualEnemigo <= 0) { Destroy(gameObject); }
    }

    public void EnemigoRecibeGolpe(int danoRecibidoBala) {
       vidaActualEnemigo -= danoRecibidoBala * danoRecibeEnemigo; 
    }

    IEnumerator TiempoRecueracionVida() {
        yield return new WaitForSeconds(3);
        if (vidaActualEnemigo < 10) {
            vidaActualEnemigo += 1;
        }
        else if (vidaActualEnemigo >= 10) {            
            enemigoRecuperaVida = false; 
        }

    }
}
