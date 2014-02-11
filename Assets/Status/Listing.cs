using UnityEngine;
using System.Collections;

public class Listing : State {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public override void process()
    {
        print("List状態");
        if (this.clicked == true)
        {
            foreach (GameObject g in GameObject.FindGameObjectsWithTag("Respawn"))
            {
                print(g.GetComponent<CardV>());
                g.SetActive(false);
            }
            gameObject.AddComponent<Viwing>();
            Destroy(this);
        }
        //bool flg = false;
        /*foreach (GameObject g in GameObject.FindGameObjectsWithTag("Respawn")){
            print("探索状態");
            if (g.GetComponent<CreatureCard>().Clicked() == true)
            {
                //flg = true;
                gameObject.AddComponent<Viwing>();
                Destroy(this);
            }
        }*/
        //if (flg == true)
        //    Destroy(this);
    }
}
