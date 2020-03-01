using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml.Serialization;
using System.IO;

public class XMLSerializer : MonoBehaviour
{
    void Start()
    {
        RandomCubeGenerator generator = new RandomCubeGenerator();

        XmlSerializer serializer = new XmlSerializer(typeof(RandomCubeGenerator));
        StreamWriter writer = new StreamWriter("mapa.xml");
        serializer.Serialize(writer.BaseStream, generator);
        writer.Close();
    }

}
