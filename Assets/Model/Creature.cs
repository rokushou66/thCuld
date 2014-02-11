using UnityEngine;
using System.Collections;

public class Creature : GeneralBehaviour
{

    public int curse;      //土地にかかった呪い
    public int capture = -1;   //どのプレイヤーが持ってるか。もっている奴がいなければ-1
    public int cNumber;  //クリーチャーの識別番号
    public int mhp;       //HPの最大値
    public int hp;        //HPの現在値
    public int ap;        //AP（攻撃力）の現在値

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
