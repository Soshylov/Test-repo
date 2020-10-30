using Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private void Start()
    {
        Debug.Log($"Test repository");
        Debug.Log($"Новая строка");
        Debug.Log($"Новая строка в ветке");
       
        
    }

    private void Awake()
    {

       // PlayerPrefs.DeleteAll();
    }

}
