using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml.Serialization;

public class GeneratedMap : MonoBehaviour
{
    
}
[XmlRoot("GeneratedMap")]


    // Start is called before the first frame update
    //clone.transform.position = new Vector3();
    //clone.transform.rotation = new Quaternion();

public class Generation
{
  
    [XmlArray("Klocki"), XmlArrayItem("Lokacje")]
    //public GameObject[] mapGenerated;
    public int[] klocki;
}