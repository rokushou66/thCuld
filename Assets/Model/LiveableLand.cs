using UnityEngine;
using System.Collections;

public class LiveableLand : Land {
    
    public enum element
    {
        none,
        fire,
        water,
        earth,
        wind,
        multiple,
        morph
    }    //属性
    public int level = 1;      //レベル
    public int price;      //単位地価

    public LiveableLand()
    {
        coordinate[0] = 0;
        coordinate[1] = 1;
        number = 0;
        price = 100;
    }

    public LiveableLand(int num) : base(num)
    {
        price = 100;
    }
}
