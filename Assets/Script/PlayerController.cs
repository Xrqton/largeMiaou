using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public float speed;
    float moveHorizontal;
    float moveVertical;

    ////----------------Correpond à la boule sur laquelle nous allons exercer une force
    private Rigidbody rb;

    //----------------Lance la première frame du jeu
    void Start()
    {
        //Permet de récupérer la référence du RB et jouer avec
        rb = GetComponent<Rigidbody>();

    }

    void Update()
    {
        moveHorizontal = Input.GetAxis("Horizontal");
        moveVertical = Input.GetAxis("Vertical");

    }

    ////----------------Permet de lancer tout ce qui calcul physique 
    void FixedUpdate()
    {

        //float moveHorizontal = Input.GetAxis("Horizontal");
        //float moveVertical = Input.GetAxis("Vertical");

        //Application de la force sur la boule Rigibody e        
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement*speed);
    }

}
