using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllyFollowPlayer : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GameObject.FindWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
 
        var distance = Vector3.Distance(transform.position, playerTransform.position);

        Vector3 playerDirection = (playerTransform.position - transform.position);

        if (distance > 2f)
        {
            Debug.Log("Need to be closer of the player");
            //transform.position += playerDirection * 1f * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, playerDirection, 5f * Time.deltaTime);
        }
       
    }
}
