using UnityEngine;
using PokerGame.Core;
using PokerGame.View;

public class CradDemo : MonoBehaviour
{
    //宣告類型 名稱 = 新建 實體();
    public PlayingCard testCard = new PlayingCard(Suit.Spades,
        Rank.King);
    public CardView cardView;
    
    private Deck _deck = new Deck();
    void Start()
    {
        //利用除錯訊息視窗印出指定內容
        //Debug.Log(testCard.Info());
        testCard = _deck.Draw();
        testCard = _deck.Draw();
        testCard = _deck.Draw();
        testCard = _deck.Draw();
        testCard = _deck.Draw();
        testCard = _deck.Draw();
        testCard = _deck.Draw();
        testCard = _deck.Draw();
    }

    
    void Update()
    {
        //視覺顯示 綁定(卡牌資料)
        cardView.Bind(testCard);
    }
}
