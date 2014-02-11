using UnityEngine;
using System.Collections;

public class Map{
	
	public string name;     //マップの名前
    public string note;     //マップの説明
    public int maxDice; //ダイスの最大値
    public int fort;       //それぞれの砦が存在するかどうか
    public int hasArea;       //それぞれのエリアが存在するかどうか
    public int reward;     //基本報酬
    public int minTarget;  //目標魔力の最低値
    public Land[] lands = new Land[100];//マップが持つそれぞれの土地。可変長にした方がいいか？→ランダムアクセスするので配列でいい
    public int branchBonus=100;//分社を通ったときの報酬
    public int shrineBonus=180;//神社を通ったときの基本報酬

    public Map()
    {
        name = "博麗神社";
        maxDice = 6;
        for (int i = 0; i < 20;i++ )
            lands[i] = new LiveableLand(i);
    }
}
