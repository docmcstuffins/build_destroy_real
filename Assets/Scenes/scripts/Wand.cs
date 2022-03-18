using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wand : MonoBehaviour
{
    [SerializeField] private Transform spawnPoint;
    public GameObject cubeType;
    
    public void MakeCube()
    {
        Instantiate(cubeType, spawnPoint.position,spawnPoint.rotation);
        print("you suck lol");
    }

}
