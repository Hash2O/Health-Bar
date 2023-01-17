using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealthDisplay : MonoBehaviour
{
    public IntVariable playerHp;
    public IntVariable allyHp;

    [SerializeField] private TextMeshProUGUI playerHealthDisplay;
    [SerializeField] private TextMeshProUGUI allyHealthDisplay;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        //Actualisation de l'affichage de la jauge de HP
        playerHealthDisplay.text = "Player HP : " + playerHp.value;
        allyHealthDisplay.text = "Ally HP : " + allyHp.value;
    }
}
