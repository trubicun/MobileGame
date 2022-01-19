using System;
using UnityEngine;

public class Building : MonoBehaviour
{
    [SerializeField] BuildingType buildingType;

    public void Place()
    {
        
    }
    
    public BuildingType Type => buildingType;

    public enum BuildingType
    {
        Empty,
        Civilian,
        Commercial,
        Industrial
    }
}
