using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System;

public class XmlSaveTest : GeneralBehaviour
{

    List<CreatureCard> cardList = new List<CreatureCard>();
    Map map = new Map();

    // Use this for initialization
    void Start()
    {
        cardList.Add(new CreatureCard());
        cardList.Add(new CreatureCard("アリスに化けたマミゾウ"));
        XmlSerializer xmls = new XmlSerializer(typeof(List<CreatureCard>));

        XmlWriterSettings settings = new XmlWriterSettings { OmitXmlDeclaration = true, Indent = true };
        using (var stream = File.OpenWrite("cardList.xml"))
        {
            using (var xmlWriter = XmlWriter.Create(stream, settings))
            {
                xmls.Serialize(xmlWriter, cardList);
            }
        }

        Type[] extraTypes = { typeof(Land), typeof(LiveableLand) };
        xmls = new XmlSerializer(typeof(Map),extraTypes);
        using (var stream = File.OpenWrite("map.xml"))
        {
            using (var xmlWriter = XmlWriter.Create(stream, settings))
            {
                xmls.Serialize(xmlWriter, map);
            }
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}