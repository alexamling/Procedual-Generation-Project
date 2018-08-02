using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour {

    public int mapWidth;
    public int mapheight;
    public float noiseScale;

    public bool autoUpdate;

    public void Generate()
    {
        float[,] noiseMap = Noise.GenerateNoiseMap(mapWidth, mapheight, noiseScale);

        MapDisplay display = FindObjectOfType<MapDisplay>();
        display.DrawNoiseMap(noiseMap);
    }
}
