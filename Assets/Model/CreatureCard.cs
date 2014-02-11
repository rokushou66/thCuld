using System.Collections;
using System;

public class CreatureCard : Card {

    public int cNumber;  //クリーチャーの識別番号
    public int hp;       //HP
    public int ap;        //AP（攻撃力）
    public enum speed
    {
        slow,
        normal,
        quick
    }//クリーチャーが先制持ちなら2,後攻持ちなら0,どっちでもないなら1

    [Flags]
    enum permittedBranch
    {
        North = 1,
        South = 2,
        East = 4,
        West = 8
    }//それぞれの分社を通っているかどうか

    [Flags]
    enum invality
    {
        None = 1,
        Fire = 2,
        Water = 4,
        Earth = 8,
        Wind = 16
    }//２進で表現した場合、小さい位から無、火、水、地、風が無効ならば1,そうでないなら0

    [Flags]
    enum landCost
    {
        Fire1 = 1,
        Fire2 = 2,
        Water1 = 4,
        Water2 = 8,
        Earth1 = 16,
        Earth2 = 32,
        Wind1 = 64,
        Wind2 = 128
    }//土地コスト。２進で表現した場合、火火水水地地風風の各位において,コストが要るなら1,そうでないなら0
    public bool cardCost;	//カードコストがあればtrue,なければfalse
    [Flags]
    enum element
    {
        None = 1,
        Fire = 2,
        Water = 4,
        Earth = 8,
        Wind = 16
    }//クリーチャーの属性。２進で表現した場合、小さい位から無、火、水、地、風に当てはまるなら1,そうでないなら0
    [Flags]
    enum landLimit
    {
        None = 1,
        Fire = 2,
        Water = 4,
        Earth = 8,
        Wind = 16
    }//クリーチャーの配置制限。２進で表現した場合、小さい位から無、火、水、地、風に置けないなら1,そうでないなら0
    [Flags]
    enum itemLimit
    {
        Weapon = 1,
        Protector = 2,
        Scroll = 4,
        Tool = 8,
    }//クリーチャーのアイテム使用制限。２進で表現した場合、小さい位から武器、防具、巻物、道具が使えないなら1,使えるなら0


    public bool landAbility;	//クリーチャーが領地能力を持つかどうか。持つならtrue,なければfalse
    public int landAbilityCost;	//クリーチャーの領地能力のコスト
    public bool snow;           //雪辱能力の有無

    enum keywordAbility
    {
        Regenerate = 1,     //再生
        Support = 2,        //援護
        MagicProtect = 4,   //魔防
        Guard = 8,          //防御型
        Immediately = 16    //即時
    }//キーワード能力の有無

    public CreatureCard()
    {
        name = "アリス";
        note = "人形使い。";
        effectText = "援護とか";
        supplementText = "";
        cNumber = 0;
        hp = 40;
        ap = 30;
    }

    public CreatureCard(string n):this()
    {
        name = n;
    }



}
