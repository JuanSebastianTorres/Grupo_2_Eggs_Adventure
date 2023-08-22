using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoSaltoPlayer : MonoBehaviour
{
    [Header("MovimientoHorizontal")]
    public float fuerzaHorizontal;   
        float valorHorizontal;   
        Animator animator;

    [Header("Salto")]
    public float fuerzaSalto;
    public float alturaRayo;
    public LayerMask capaPiso;
        Rigidbody2D rigidbody2D;


    // Start is called before the first frame update
    void Start()
    {
        animator= GetComponent<Animator>();
        rigidbody2D = GetComponent<Rigidbody2D>();


        if (fuerzaHorizontal <= 0) {fuerzaHorizontal = 1;}
        if (fuerzaSalto <= 0){fuerzaSalto = 5f;}
        if (alturaRayo <= 0){alturaRayo = 1.5f;}



    }

    // Update is called once per frame
    void Update()
    {
        //MoviminetoHorizontal
        valorHorizontal = Input.GetAxisRaw("Horizontal");
        if (valorHorizontal != 0) {
            if (valorHorizontal > 0)
            {
                transform.rotation= Quaternion.Euler(0,0,0);
            }
            else if (valorHorizontal < 0) {
                transform.rotation = Quaternion.Euler(0, 180, 0);
            }
            transform.position += Vector3.right * valorHorizontal * fuerzaHorizontal *  Time.deltaTime;
        }
        animator.SetFloat("Correr", Mathf.Abs(valorHorizontal));

        //MovimientoVertical
        Debug.DrawRay(transform.position, Vector2.down * alturaRayo, Color.red, 0.01f);
        if (Physics2D.Raycast(transform.position, Vector2.down, alturaRayo, capaPiso)) {
            Debug.Log("Tocando Piso");
            if (Input.GetKeyDown(KeyCode.UpArrow)) {
                rigidbody2D.velocity = Vector2.up * fuerzaSalto;
                Debug.Log("Salta");
                
            }
        }

    }
}
