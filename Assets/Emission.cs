using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Emission : MonoBehaviour
{

    [SerializeField] private GameObject[] gameObjects;
    [SerializeField] private int howMuchObjects;
    
    
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < howMuchObjects; i++)
        {
            var position = new Vector3(Random.Range(-3,3),Random.Range(0,3),Random.Range(-3,3));
            position += transform.position;
            GameObject.Instantiate(gameObjects[Random.Range(0, gameObjects.Length)], position,Quaternion.identity);
        }

    }
 
}

    
