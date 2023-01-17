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
        allyHealth.value = initialHealth;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GetHurt(int damage)
    {
        allyHealth.value -= damage;
    }
}
