using System.Collections;
using System.Collections.Generic;
//using System.Xml;
//using System.Xml.Serialization;
using UnityEngine;
using System.IO;
using System.Xml.Serialization;


public class RandomCubeGenerator : MonoBehaviour
{
    public GameObject[] itemsToPickFrom;
    public int gridX;
    public int gridZ;
    public float gridSpacingOffset = 1f;
    public Vector3 gridOrigin = Vector3.zero;
    public GameObject[] clonesPosition;
    public GameObject[,] tab = new GameObject[10, 10];
    public int[] tabint = new int[100];
    

    public void SpawnOnClick()
    {
        SpawnGrid();
    }

    public void SpawnGrid()
    {
        int randomIndex;
        XmlSerializer ser = new XmlSerializer(typeof(int[]));
        TextWriter write = new StreamWriter("ser.xml");
        for (int x = 0; x < gridX; x++)
        {
            for (int z = 0; z < gridZ; z++)
            {
                Vector3 spawnPosition = new Vector3(x * gridSpacingOffset, 0, z * gridSpacingOffset) + gridOrigin;
                randomIndex = Random.Range(0, itemsToPickFrom.Length);
                tabint[x * 10 + z] = randomIndex;
                GameObject clone = Instantiate(itemsToPickFrom[randomIndex], spawnPosition, Quaternion.identity);
                clone.transform.parent = GameObject.Find("kontrolerMapy").transform;
                tab[x, z] = clone;
            }
        }
        try
        {
            ser.Serialize(write, tabint);
        }catch(System.Exception ex)
        {
            //TODO tag, ze blad xd 
        }
        write.Close();
    }

    /**
    public GameObject PickAndSpawn(Vector3 positionToSpawn, Quaternion rotationToSpawn)
    {
        int randomIndex = Random.Range(0, itemsToPickFrom.Length);
        GameObject clone = Instantiate(itemsToPickFrom[randomIndex], positionToSpawn, rotationToSpawn);
        clone.transform.parent = GameObject.Find("kontrolerMapy").transform;
        return clone;
    }*/
}

