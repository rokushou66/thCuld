using UnityEngine;
using System.Collections;

public class Viwing : State {

	// Use this for initialization
	void Start () {
        foreach (GameObject g in GameObject.FindGameObjectsWithTag("Respawn"))
        {
            g.GetComponent<CardV>().DestroyMyself();
        }
        //Destroy(GameObject.FindGameObjectsWithTag("Respawn"));
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public override void process()
    {
        print("View状態");
        //return this;
    }
}
