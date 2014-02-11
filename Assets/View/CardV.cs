using Extensions;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CardV : GeneralBehaviour {

    ///画面に表示されるカードの表示に関するクラス

    public Card card = new CreatureCard();

    public CardV()
    {
    }
    public CardV(Card c)
    {
        card = c;
    }

	// Use this for initialization
	void Start () {
        
	}

	
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseOver()
    {
        guiTexture.pixelInset = new Rect(guiTexture.pixelInset.x, guiTexture.pixelInset.y, 10 + 40 * Mathf.Cos((float)Time.frameCount / 10), 10 + 40 * Mathf.Cos((float)Time.frameCount / 10));
        //transform.localScale = new Vector3(Screen.width / 1280f * Mathf.Cos(Time.time), Screen.height / 720f * Mathf.Sin(Time.time), 0);
        print("カーソル載ってます");

    }

    void OnMouseExit()
    {
        //transform.localScale = new Vector3(Screen.width / 1280f * 0.12f, Screen.height / 720f * 0.27f, 0);
        guiTexture.pixelInset = new Rect(guiTexture.pixelInset.x, guiTexture.pixelInset.y, 0, 0);
        print("カーソル載ってません");
    }

    void OnMouseDown()
    {
        GameObject.Find("BookEdit").GetComponent<State>().Clicked(true);
        tag = "Player";
        guiTexture.pixelInset = new Rect((float)(Screen.width * 0.5), (float)(Screen.height * 0.5), 0, 0);
        //this.clicked = true;
    }

    void OnMouseEnter()
    {
        GameObject.Find("pickUpObj").GetSafeComponent<GeneralBehaviour>().SetGUIText(card.note);
        //GameObject.Find("BookEdit").GetSafeComponent<GUIText>().text = str;//こっちは無理だった
        print(card.note);
    }
}
