using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateTerrain : MonoBehaviour
{
    public Terrain t;

    // Hauteur des montagnes
    public int height = 25;

    // Largeur du terrain 
    public int size = 256;


    void Start()
    {
        t.terrainData = GenTdata(t.terrainData);
    }

    public TerrainData GenTdata(TerrainData tData)
    {
        tData.heightmapResolution = size;
        tData.size = new Vector3(size, height, size);
        float[,] h = new float[size, size];

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {

            }
        }
        return tData;
    }

    
}
