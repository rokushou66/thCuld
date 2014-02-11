using System.Collections;

public class ItemCard : Card {
    public int iNumber;	//アイテムの識別番号
    public enum type
    {
        weapon,
        protector,
        scroll,
        tool
    }//アイテムの種別（0:武器・1:防具・2:巻物・3:道具）
    public int hp;	//アイテムを使うことで増えるHP
    public int ap;	//アイテムを使うことで増えるAP(ただし、巻物の場合は固定されるAP)
    public enum speed
    {
        slow,
        normal,
        quick
    }//クリーチャーが先制持ちなら2,後攻持ちなら0,どっちでもないなら1
    public bool snow;	//アイテムが雪辱能力を持つかどうか。持つならtrue,なければfalse

}
