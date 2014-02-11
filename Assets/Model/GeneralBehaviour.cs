using Extensions;
using UnityEngine;
using System.Collections;
//using System.Collections.Generic;

public class GeneralBehaviour : MonoBehaviour {

    protected bool clicked = false;
    public bool Clicked(){return this.clicked;}
    public void Clicked(bool c) { this.clicked = c; }


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void DestroyMyself()
    {
        Destroy(this);
    }

    public void SetGUIText(string str)
    {
        if (GetComponent<GUIText>() != null)
            GetComponent<GUIText>().text = str;
        else
            print("GUIText無いです");
    }

}
