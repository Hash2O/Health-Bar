using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public int damage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {      
        if (collision.collider.CompareTag("Player"))
        {
            //Supprimer le Game Object
             Destroy(gameObject);        
        }
    }
}
