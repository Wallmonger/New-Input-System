using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenProcSample : MonoBehaviour
{
    public GameObject[] blocs;
    public int levelSize;

    private void Start()
    {
        for (int i = 0; i < levelSize; i++)
        {
            for (int j = 0; j < levelSize; j++)
            {
                // Instanciation d'un bloc à une distance de 5 car les niveaux font 5 blocs
                Instantiate(blocs[Random.Range(0, blocs.Length)], 
                   new Vector3(j*5,0,i*5),
                   Quaternion.identity);
                
            }
        }
    }

}
