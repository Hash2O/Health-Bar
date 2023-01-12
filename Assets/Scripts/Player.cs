using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int initialHealth;
    private int health;

    public int Health
    {
        get { return health; }
        set { health = value; }
    }

    private Bomb bombObject;

    // Start is called before the first frame update
    void Start()
    {
        health = initialHealth;
        Debug.Log("HP : " + health);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Bomb"))
        {
            //Debug.Log(gameObject.name + " a reçu une " + collision.collider.name + " sur la tête.");
            //Récupération des infos du GO
            bombObject = GameObject.FindWithTag("Bomb").GetComponent<Bomb>();
            //Actualisation de la jauge de HP en fonction des dommages reçus
            health -= bombObject.damage;  
        }
    }
}
