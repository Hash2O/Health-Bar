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
        health.value = initialHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetHurt(int damage)
    {
        health.value -= damage;
    }
}
