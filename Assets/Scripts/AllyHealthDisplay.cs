using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AllyHealthDisplay : MonoBehaviour
{
    private Ally ally;

    [SerializeField] private TextMeshProUGUI allyHealthDisplay;
    // Start is called before the first frame update
    void Start()
    {
        //Récupération du component (script) "Ally"
        ally = GetComponent<Ally>();


        //Attribution des points de vie de départ
        ally.Health = 50;
    }

    // Update is called once per frame
    void Update()
    {
        //Actualisation de l'affichage de la jauge de HP
        allyHealthDisplay.text = "Ally HP : " + ally.Health;
    }
}
