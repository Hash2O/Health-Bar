using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealthDisplay : MonoBehaviour
{
    private Player player;

    [SerializeField] private TextMeshProUGUI healthDisplay;
    // Start is called before the first frame update
    void Start()
    {
        //R�cup�ration du component (script) "Player"
        player = GetComponent<Player>();

        //Attribution des points de vie de d�part
        player.Health = 100;
       
    }

    // Update is called once per frame
    void Update()
    {
        //Actualisation de l'affichage de la jauge de HP
        healthDisplay.text = "HP : " + player.Health;
    }
}
