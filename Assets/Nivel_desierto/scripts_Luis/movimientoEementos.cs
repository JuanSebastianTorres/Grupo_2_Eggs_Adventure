using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoEementos : MonoBehaviour
{
   
    public Transform objectoReferencia;
    public Vector3 coordenadasInicial; 
     public Vector3 coordenadasFinal; 

    public float velocidadMovimeinto;

    public  bool enemigoInerte;
    public bool  estaEnCoordenadaInicial=false;
    public bool  estaEnCoordenadaFinal=false;

    // Start is called before the first frame update
    void Start()
    {
       coordenadasInicial= transform.position;
       coordenadasFinal=objectoReferencia.position;

    }

    // Update is called once per frame
    void Update()
    {
   
        if(transform.position==coordenadasInicial){
                estaEnCoordenadaInicial=true;
                estaEnCoordenadaFinal=false;
        }else if(transform.position==coordenadasFinal){
                estaEnCoordenadaInicial=false;
                estaEnCoordenadaFinal=true;
        }

        if((transform.position != coordenadasInicial) && estaEnCoordenadaInicial==false){
            transform.position = Vector3.MoveTowards(transform.position, coordenadasInicial, velocidadMovimeinto* Time.deltaTime);            
           
        }

        if((transform.position != coordenadasFinal) && estaEnCoordenadaInicial==true){
            transform.position = Vector3.MoveTowards(transform.position, coordenadasFinal, velocidadMovimeinto* Time.deltaTime);
            
        }

        
    }
}
