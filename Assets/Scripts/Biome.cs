using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Biome", menuName ="Biome")]
public class Biome : ScriptableObject{
    
    public enum LEVEL{
        LOW,
        MEDIUM,
        HIGH
    }

    public string name;
    public float averageTemp;
    public float averagePrecipitationPerYear;
    public LEVEL averageHumidity;
    public LEVEL vegetationLevel;

}
