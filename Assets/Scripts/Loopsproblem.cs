using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loopsproblem : MonoBehaviour
{

    int x = 1;

    // Start is called before the first frame update
    void Start()
    {
        while (x <= 100) {
            if (x % 5 == 0 && x % 3 == 0)
            {
                print(x);
            }
            x += 1;

        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
