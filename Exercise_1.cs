using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        while (true)
        {
            int num = Random.Range(1, 21);
            if (num == 5) 
                continue;
            Debug.Log(num);
            if (num == 15)
                break;
        
        }
        
    }

   
}
