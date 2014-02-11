using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

public class XmlLoadTest{

    public List<CreatureCard> cardList;

    // Use this for initialization
    public XmlLoadTest()
    {
        XmlSerializer xmls = new XmlSerializer(typeof(List<CreatureCard>));

        XmlWriterSettings settings = new XmlWriterSettings { OmitXmlDeclaration = true, Indent = true };
        using (var stream = File.OpenRead("creatureExportUni.xml"))
        //using (var stream = File.OpenRead("creatureExportUni.xml"))
        {
            cardList = xmls.Deserialize(stream) as List<CreatureCard>;
        }

    }

    // Update is called once per frame
    /*void Update()
    {
        print(cardList[(int)Time.time % 60].name);
    }*/
}
