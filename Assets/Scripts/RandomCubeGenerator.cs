using System.Collections;
using System.Collections.Generic;
//using System.Xml;
//using System.Xml.Serialization;
using UnityEngine;



public class RandomCubeGenerator : MonoBehaviour
{
    public GameObject[] itemsToPickFrom;
    public int gridX;
    public int gridZ;
    public float gridSpacingOffset = 1f;
    public Vector3 gridOrigin = Vector3.zero;
    public GameObject[] clonesPosition;
    //public Vector3[] clonePositions;
    //public GameObject[] clonesRotation;
    //public GameObject[] clonesName;

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
                PickAndSpawn(spawnPosition, Quaternion.identity);
            }
        }
    }

    public void PickAndSpawn(Vector3 positionToSpawn, Quaternion rotationToSpawn)
    {
        int randomIndex = Random.Range(0, itemsToPickFrom.Length);
        GameObject clone = Instantiate(itemsToPickFrom[randomIndex], positionToSpawn, rotationToSpawn);
        clone.transform.parent = GameObject.Find("kontrolerMapy").transform;
        //clonePositions = new Vector3[3];
        //Vector3 position = clone.transform.position;
        //clonePositions[0] = position;
        //int clonePositionIndex = Vector3Int;
        // clonesPosition[int clone.GetComponent<Vector3Int>];
        // clonesRotation[int clone.GetComponent<Quaternion>];
        // clonesName[clone.name];

    }
}

