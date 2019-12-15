using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

public class XmlManager : MonoBehaviour
{
    public static XmlManager ins;
    //public RandomCubeGenerator RandomGenerator;

    void Awake()
    {
        ins = this;
       // RandomGenerator.SpawnOnClick();
    }

    // list of items
    public ItemDatabase itemDB;

    // saving function
    public void SaveItems()
    {
        //create a new xml file
        XmlSerializer serializer = new XmlSerializer(typeof(ItemDatabase));
        FileStream stream = new FileStream(Application.dataPath + "/XML/generated_map_data.xml", FileMode.Create);
        serializer.Serialize(stream, itemDB);
        stream.Close();
    }
    //loading function
    public void LoadItems()
    {
        XmlSerializer serializer = new XmlSerializer(typeof(ItemDatabase));
        FileStream stream = new FileStream(Application.dataPath + "/XML/generated_map_data.xml", FileMode.Open);
        serializer.Serialize(stream, itemDB);
        stream.Close();
    }
}
[System.Serializable]
public class ItemEntry
{
    //items to choose from attributes
    //public string, material, int, float itd
}

[System.Serializable]

public class ItemDatabase
{
    public List<ItemEntry> list = new List<ItemEntry>();
}

// public enum jakistam {Jeden, drugi, trzeci}, może się przydać
