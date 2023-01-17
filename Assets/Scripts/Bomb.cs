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

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
           other.gameObject.GetComponent<Player>().GetHurt(damage);
        }
        else if (other.gameObject.tag == "Ally")
        {
            other.gameObject.GetComponent<Ally>().GetHurt(damage);
        }
        Destroy(gameObject);
    }
}
