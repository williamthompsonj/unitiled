using System.ComponentModel;
using System.Xml.Serialization;
using System.Xml;

[System.Serializable]
public class TiledGrid
{
    [XmlAttribute("orientation")]
    [DefaultValue("orthogonal")]
    public string orientation { get; set; }

    [XmlAttribute("width")]
    public int width { get; set; }

    [XmlAttribute("height")]
    public int height { get; set; }
}