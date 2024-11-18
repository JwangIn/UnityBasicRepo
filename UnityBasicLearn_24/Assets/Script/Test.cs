using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string A = "Hello Unity!";
        Debug.Log(A);

        A = A.Replace("Unity", "Friend");
        Debug.Log(A);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
