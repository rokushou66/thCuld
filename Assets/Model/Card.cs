using System.Collections;

public abstract class Card{
	
    public string name;//カードの名前
    public string illName;//カードの画像ファイルの名前
    public string note;//フレーバーテキスト
    public string effectText;//効果の説明文
    public string supplementText;//効果の補足
    public enum rarelity
    {
        normal,
        strange,
        rare,
        extra
    }//レアリティ
    public int category;//カードのカテゴリ（クリーチャー、アイテム、マジック）
    int powerCost;//必要霊力
    
}
