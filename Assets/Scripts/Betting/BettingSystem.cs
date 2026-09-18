using UnityEngine;

namespace PokerGame.Betting
{
    /// <summary>
    /// 下注管理系統
    /// </summary>
    public class BettingSystem
    {
        #region 常數
        /// <summary>
        /// [常數]定義籌碼的最小單位值
        /// </summary>
        private const int MinimumBet = 10;
        #endregion 常數

        #region 私有欄位
        /// <summary>
        /// 籌碼錢包的託管欄位
        /// </summary>
        private readonly ChipWallet _chipWallet;
        #endregion 私有欄位

        #region 公開屬性(UI能讀)
        /// <summary>
        /// 顯示錢包餘額
        /// </summary>
        public int Balance => _chipWallet.Balance;
        /// <summary>
        /// 當前的下注值
        /// </summary>
        public int CurrentBet {  get; private set; }
        #endregion 公開屬性(UI能讀)

        #region 建構式
        /// <summary>
        /// 啟動下注系統時託管籌碼錢包
        /// </summary>
        /// <param name="wallet"></param>
        public BettingSystem(ChipWallet wallet)
        {
            _chipWallet = wallet;
        }
        #endregion 建構式

        #region 公開方法
        /// <summary>
        /// 嘗試放置籌碼到下注區
        /// </summary>
        /// <param name="amount">下注金額</param>
        /// <returns>是否成功完成下注</returns>
        public bool TryPlaceBet(int amount)
        {
            if(amount < MinimumBet) 
                return false;
            if(!_chipWallet.TryWithdraw(amount)) 
                    return false;
            CurrentBet = amount;
            return true;
        }
        #endregion 公開方法

    }
}

