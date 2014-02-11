using UnityEngine;
using System.Collections;

public abstract class State : GeneralBehaviour
{

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public abstract void process();
}
