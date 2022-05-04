using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour
{
    int[] randonNumbers = new int[3];

    // Start is called before the first frame update
    void Start()
    {
        randonNumbers[0] = Random.Range(0, 100);
        print(randonNumbers[0]);

        randonNumbers[1] = Random.Range(0, 100);
        print(randonNumbers[1]);

        randonNumbers[2] = Random.Range(0, 100);
        print(randonNumbers[2]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
