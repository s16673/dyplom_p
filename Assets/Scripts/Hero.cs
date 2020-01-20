using System.Xml.Serialization;

[XmlRoot("Knight")]
public class Hero
{
    [XmlElement("n")]
    public string name;

    [XmlAttribute("boss")]
    public bool isBoss;

    [XmlIgnore]
    public int hitPoints;

    public float baseDamage;

    [XmlArray("rewards"), XmlArrayItem("reward")]
    public int[] comboRewards;
}