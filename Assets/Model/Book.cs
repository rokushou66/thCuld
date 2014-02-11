using UnityEngine;
using System.Collections;

public class Book : MonoBehaviour {
    //public string name;	//ブックの名前
    public string comment;	//ブックについてのコメント
    public int cover;	//ブックカバー
    public Card[] card = new Card[50];//ブックを構成するカード群

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
