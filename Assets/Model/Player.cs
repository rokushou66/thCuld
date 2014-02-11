using UnityEngine;
using System.Collections;
using System;


public class Player : GeneralBehaviour
{

	public int holdPower;   //手持ち魔力
    //public BufferedImage figure;     //アバターの姿
    public int controller=0; //誰がそのプレイヤーを操作するか
    public int locateNumber;//今乗っているマスの番号
    public int beforeLNumber;//前（一マス前）どこのマスに乗っていたかを表す番号

    [Flags]
    enum permittedBranch
    {
        North = 0,
        South = 1,
        East = 2,
        West = 4
    }//既に通った分社

	public int number;     //識別番号
    public int team;       //どの同盟に属するか
    public int curse=0;     //持っている呪い
    //public string name="プレイヤー１";//名前
    public Book book;	//使うブック
    public Card[] hand = new Card[6];//手札
    public Card[] currentBook = new Card[50];//現在のブック
    public int laps=1;//周回数
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
