using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHP : MonoBehaviour
{
    [SerializeField] private bool isGameOver;
        private int HP = 100;
    public int damage = 30;


    // Start is called before the first frame update
    void Start()
    {
        /* 
         
         las dos maneras de hacer el ejercicio
         hp -= damage;

          hp = hp - damage
        */

        HP -= damage;

    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver = false)
        {

        }
        else if (HP <= 0)
        {
            Debug.Log(message: "Te has quedado sin vida... GAME OVER");
        }
        else if (HP < 20)
        {
            Debug.Log(message: "¡Tienes poca vida!");
        }
        else
        {
            Debug.Log(message: $"vas bien de vida: tienes (HP) puntos de vida");
        
        }
    }
}
