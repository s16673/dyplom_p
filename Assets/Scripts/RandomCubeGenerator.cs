using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using UnityEngine;



public class RandomCubeGenerator : MonoBehaviour
{
    public GameObject[] itemsToPickFrom;
    public int gridX;
    public int gridZ;
    public float gridSpacingOffset = 1f;
    public Vector3 gridOrigin = Vector3.zero;
    [XmlArray("mapa"), XmlArrayItem("klocek")]
    public GameObject[,] tab = new GameObject[10, 10];
    

    public void SpawnOnClick()
    {
        SpawnGrid();
    }

    public void SpawnGrid()
    {
        for (int x = 0; x < gridX; x++)
        {
            for (int z = 0; z < gridZ; z++)
            {
                Vector3 spawnPosition = new Vector3(x * gridSpacingOffset, 0, z * gridSpacingOffset) + gridOrigin;
                tab [x,z] = PickAndSpawn(spawnPosition, Quaternion.identity);
            }
        }
    }

    public GameObject PickAndSpawn(Vector3 positionToSpawn, Quaternion rotationToSpawn)
    {
        int randomIndex = Random.Range(0, itemsToPickFrom.Length);
        GameObject clone = Instantiate(itemsToPickFrom[randomIndex], positionToSpawn, rotationToSpawn);
        clone.transform.parent = GameObject.Find("kontrolerMapy").transform;
        return clone;
        

    }
}


