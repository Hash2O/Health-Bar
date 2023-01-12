using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ally : MonoBehaviour
{
    [SerializeField] private int initialHealth;
    private int allyHealth;

    public int Health
    {
        get { return allyHealth; }
        set { allyHealth = value; }
    }

    private Bomb bombObject;

    // Start is called before the first frame update
    void Start()
    {
        allyHealth = initialHealth;
        //Debug.Log("Ally HP : " + allyHealth);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Bomb"))
        {
            Debug.Log(gameObject.name + " a reçu une " + collision.collider.name + " sur la tête.");
            //Récupération des infos du GO
            bombObject = GameObject.FindWithTag("Bomb").GetComponent<Bomb>();
            //Actualisation de la jauge de HP en fonction des dommages reçus
            allyHealth -= bombObject.damage;
        }
    }
}
