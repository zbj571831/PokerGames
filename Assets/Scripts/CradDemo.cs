using UnityEngine;
using PokerGame.Core;

public class CradDemo : MonoBehaviour
{
    //宣告類型 名稱 = 新建 實體();
    public PlayingCard testCard = new PlayingCard(Suit.Spades,
        Rank.King);
    

    void Start()
    {
        //利用除錯訊息視窗印出指定內容
        Debug.Log(testCard.Info());
    }

    
    void Update()
    {
        
    }
}
