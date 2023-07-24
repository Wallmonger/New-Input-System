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
        tData.heightmapResolution = size;                       // Définit la résolution de la carte de hauteur
        tData.size = new Vector3(size, height, size);           // Taille du terrain en Vector3
        float[,] h = new float[size, size];                     // Création d'un array en deux dimensions [,] pour stocker les hauteurs de terrain


        // On remplit le tableau avec des valeurs de bruit de Perlin pour générer
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                // Génération d'une hauteur aléatoire et enregistrement dans l'array
                h[i, j] = Mathf.PerlinNoise((float)i / size * 10, (float)j / size * 10);
            }
        }
        return tData;
    }

    
}
