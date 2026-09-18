using PokerGame.Core;
using PokerGame.Game;
using PokerGame.Game.HighCard;
using UnityEngine;

public class HighCardGameController : MonoBehaviour
{
　　#region 欄位
    [SerializeField]
    private Dealer _dealer;
    [SerializeField]
    private Transform _playerHand;
    [SerializeField]
    private Transform _dealerHand;
    #endregion 欄位

    #region 私有欄位
    /// <summary>
    /// 該遊戲專屬持有的遊戲規則書
    /// </summary>
    private readonly HighCardRules _rules = new HighCardRules();
    #endregion 私有欄位
    void Start()
    {
        PlayRound();
    }

    /// <summary>
    ///遊玩回合 
    /// </summary>
    #region 公開方法
    public void PlayRound()
    {
        //荷官開局
        _dealer.BeginRound();
        //發牌給參與者
        PlayingCard playCard = _dealer.DealTo(_playerHand);
        PlayingCard dealerCard = _dealer.DealTo(_dealerHand);

        string result = _rules.Resolve(playCard, dealerCard);

        Debug.Log(result);
    }
    #endregion 公開方法

}
