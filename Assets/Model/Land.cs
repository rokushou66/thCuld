using UnityEngine;
using System.Collections;

public abstract class Land{
	    
	public int number;     //識別番号
    public int area;		//エリア番号
    public int[] coordinate = new int[2];//描画する際のx,y座標
    public int[] next = new int[4];   //となりの土地の識別番号.-1は何もないものとして扱う

    public Land()
    {
    }
    public Land(int num)
    {
        this.number = num;
        area = 0;
        coordinate = new int[] {0,0};
        next = new int[] { -1, -1, -1, -1 };
    }

}
