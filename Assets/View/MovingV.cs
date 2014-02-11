using Extensions;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MovingV : GeneralBehaviour {

    ///プレイヤー等、マップ上を動くものに関する振る舞い

	// Use this for initialization
	void Start () {
        GameObject.mu;
        Texture2D test = new Texture2D();
        test.
	}

	public static Texture2D loadTextureIcon (string path)
	{
        Texture2D test = new Texture2D();
        test.		
	}
	
	// Update is called once per frame
	void Update () {
	  transform.position += 1;
	}

}
