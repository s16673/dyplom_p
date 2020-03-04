using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;

public class RandomCubeGenerator : MonoBehaviour
{
    public GameObject[] itemsToPickFrom;
    public int gridX;
    public int gridZ;
    public float gridSpacingOffset = 1f;
    public Vector3 gridOrigin = Vector3.zero;
    [XmlArray("mapa"), XmlArrayItem("klocek")]
    public GameObject[,] tab = new GameObject[10, 10];
<<<<<<< HEAD
    public int[,] tabint = new int[10, 10];
    public bool serialized = false;
=======
>>>>>>> 3c187bba7fc6454513067a38dec514d8d6e6fa9e
    

    public void SpawnOnClick()
    {
        SpawnGrid();
    }

    public void SpawnGrid()
    {
        int randomIndex;
        GameObject clone;
        
            for (int x = 0; x < gridX; x++)
            {
<<<<<<< HEAD
                for (int z = 0; z < gridZ; z++)
                {
                    Vector3 spawnPosition = new Vector3(x * gridSpacingOffset, 0, z * gridSpacingOffset) + gridOrigin;
                    //tab[x, z] = PickAndSpawn(spawnPosition, Quaternion.identity);

                    randomIndex = Random.Range(0, itemsToPickFrom.Length);
                    tabint[x, z] = randomIndex;
                    clone = Instantiate(itemsToPickFrom[randomIndex], spawnPosition, Quaternion.identity);
                    clone.transform.parent = GameObject.Find("kontrolerMapy").transform;
                    tab[x, z] = clone;
                }
=======
                Vector3 spawnPosition = new Vector3(x * gridSpacingOffset, 0, z * gridSpacingOffset) + gridOrigin;
                tab [x,z] = PickAndSpawn(spawnPosition, Quaternion.identity);
>>>>>>> 3c187bba7fc6454513067a38dec514d8d6e6fa9e
            }
        //XmlSerializer serializer = new XmlSerializer(typeof(GameObject));
        //StreamWriter writer = new StreamWriter("mapa.xml");
        //serializer.Serialize(writer.BaseStream, tab[0,0]);
        //writer.Close();
        if (!serialized)
        {
            //BinaryFormatter bf = new BinaryFormatter();
            //MemoryStream ms = new MemoryStream();
            //bf.Serialize(ms, tabint);
            XMLOp.Serialize(tabint, "cubemap.xml");
            serialized = true;
        }
        else 
        {
            Debug.Log("qwerty");
        }
    }

    public GameObject PickAndSpawn(Vector3 positionToSpawn, Quaternion rotationToSpawn)
    {
        int randomIndex = Random.Range(0, itemsToPickFrom.Length);
        GameObject clone = Instantiate(itemsToPickFrom[randomIndex], positionToSpawn, rotationToSpawn);
        clone.transform.parent = GameObject.Find("kontrolerMapy").transform;
        return clone;
<<<<<<< HEAD
=======
        

>>>>>>> 3c187bba7fc6454513067a38dec514d8d6e6fa9e
    }
}


