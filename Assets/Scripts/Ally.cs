using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ally : MonoBehaviour
{
    [SerializeField] private int initialHealth;
    [SerializeField] IntVariable allyHealth;

    public int Health
    {
        get { return allyHealth.value; }
        private set {  }
    }

    private Bomb bombObject;

    // Start is called before the first frame update
    void Start()
    {
        allyHealth.value = initialHealth;   //Possibilité mettre dans Awake
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GetHurt(int damage)
    {
        allyHealth.value -= damage;
        //Si les hp descendent à 0 ou moins, le player est désactivé
        if (allyHealth.value <= 10)
        {
            Debug.Log("Ally is badly wounded !");
            gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
        }

        if (allyHealth.value <= 0)
        {
            Debug.Log("Ally is dead. You're on your own !");
            gameObject.SetActive(false);
        }
    }
}
