using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
using UnityEngine;

[XmlRoot("CubeCollection")]
public class CubeContainer
{
    [XmlArray("Cubes")]
    [XmlArrayItem("Cube")]
    public List<RandomCubeGenerator> Cubes = new List<RandomCubeGenerator>();

    public void Save(string path)
    {
        var serializer = new XmlSerializer(typeof(CubeContainer));
        using (var stream = new FileStream(path, FileMode.Create))
        {
            serializer.Serialize(stream, this);
        }
    }
    public static CubeContainer Load(string path)
    {
        var serializer = new XmlSerializer(typeof(CubeContainer));
        using(var stream = new FileStream(path, FileMode.Open))
        {
            return serializer.Deserialize(stream) as CubeContainer;
        }

    }
}
