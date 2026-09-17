using PokerGame.Game;
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
        _dealer.DealTo(_playerHand);
        _dealer.DealTo(_dealerHand);
    }
    #endregion 公開方法

}
