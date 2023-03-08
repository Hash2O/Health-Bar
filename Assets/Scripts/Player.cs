using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int initialHealth;
    [SerializeField] IntVariable health;

    public int Health
    {
        get { return health.value; }
        private set { }
    }

    // Start is called before the first frame update
    void Start()
    {
        health.value = initialHealth;   //Possibilité mettre dans Awake
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetHurt(int damage)
    {
        health.value -= damage;
        //Si les hp descendent à 0 ou moins, le player est désactivé
        if(health.value <= 10)
        {
            Debug.Log("Player is badly wounded !");
            gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
        }
        
        if (health.value <= 0)
        {
            Debug.Log("Player is dead. GAME OVER !");
            gameObject.SetActive(false);
        }
    }
}
