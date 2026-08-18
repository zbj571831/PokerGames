using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace PokerGame.Core
{
    /// <summary>
    /// 保存一副標準的樸克牌(4花色各13種和52張)
    /// </summary>
    public class Deck
    {
        #region 私有欄位
        /// <summary>
        /// 保管卡牌資料的清單
        /// </summary>
        private readonly List<PlayingCard> _cards = new List<PlayingCard>();
        #endregion 私有欄位

        #region 公開屬性
        #endregion 公開屬性

        #region 建構式
        public Deck()
        {
            CreateStandardCards();
        }
        #endregion 建構式

        #region 公開方法
        #endregion 公開方法

        #region 私有方法
        /// <summary>
        /// 創建一組標準的卡牌(4花色各13種和52張)
        /// </summary>
        private void CreateStandardCards()
        {
            //遍歷四個花色 (宣告單體 in 整包列舉內(描述型別))
            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                //遍歷13個點數 (宣告單體 in 整包列舉內(描述型別))
                foreach (Rank rank in Enum.GetValues(typeof(Rank)))
                {
                    //記錄到清單上 : 新建 卡牌實體 (花, 值)(存取資料)
                    _cards.Add(new PlayingCard( suit, rank));
                }
            }

        }
        #endregion 私有方法
    }
}


