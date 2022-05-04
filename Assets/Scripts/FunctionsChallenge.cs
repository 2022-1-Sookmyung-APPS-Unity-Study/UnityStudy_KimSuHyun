using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionsChallenge : MonoBehaviour
{
    bool IsEven(int number) {
        if (number % 2 == 0 )
        {
            return true;
        }else{
            return false;
        }

    }

    int WhatIsBigger (int number1, int number2) {
        if (number1>number2)
        {
            return number1;
        }else {
            return number2;
        }
    }

    void Repeat(string text, int number0fREpeats) {
        for (int i = 0; i < number0fREpeats; i++) {
            print(text);
        }
    }

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
