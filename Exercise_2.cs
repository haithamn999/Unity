using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string[] names = { "Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird" };
        int iterator = 7;
        string Sentence = " ";
        while (iterator > 0)
        {
            int num = Random.Range(0, names.Length);
            Sentence += names[num] + " ";
            iterator--;
        }
        Debug.Log(Sentence);
    }


}

