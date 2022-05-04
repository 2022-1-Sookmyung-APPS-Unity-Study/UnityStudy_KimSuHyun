using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuctions : MonoBehaviour
{

    int health = 10;
    public int damageAmount;

    void TakeDamage (int damage) {
        health -= damage;
        print("Ouch! You took damage! You are now down to " + health);
    }

    bool IsDead () {
        if (health <= 0)
        {
            return true;
        }else{
            return false;
        }
    }
        


    // Start is called before the first frame update
    void Start()
    {
     
        
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown("space"))
       {
           TakeDamage(damageAmount);
           print("Player dead:" + IsDead());
       }
    }
}
