using System.Collections;

public class MagicCard : Card {

    public short cNumber;  //マジックの識別番号
    public bool cardCost;	//カードコストがあればtrue,なければfalse
    public enum type
    {
        single_effect,
        multiple_effect,
        single_curse,
        multiple_curse
    }//マジックの種別(単体効果・複数効果・単体呪い・複数呪い)）


}
