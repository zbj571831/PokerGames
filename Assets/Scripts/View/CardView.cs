using TMPro;
using UnityEngine;
using PokerGame.Core;

namespace PokerGame.View
{
    public class CardView : MonoBehaviour
    {
        #region UI元件
        [SerializeField] //可在Unity編輯器面板顯示
        private TMP_Text _suitLabel;
        [SerializeField]
        private TMP_Text _rankLabel;
        #endregion UI元件

        #region 公開方法
        public void Bind(PlayingCard card)
        {
            //改文字
            _suitLabel.text = GetSuitText(card.Suit);  // 顯示花色
            _rankLabel.text = GetRankText(card.Rank);  // 顯示點數
            //改顏色
            _suitLabel.color = GetSuitColor(card.Suit);  // 顯示花色
            _rankLabel.color = GetSuitColor(card.Suit);

        }
        #endregion 公開方法

        #region 私有方法
        /// <summary>
        /// 取得翻譯完成的數值文字
        /// </summary>
        /// <param name="rank">數值原始資料</param>
        /// <returns>翻譯好的數值</returns>
        private string GetRankText(Rank rank)
        {
            //邏輯判斷式
            switch (rank)
            {
                case Rank.Ace: return "A";
                case Rank.Jack: return "J";
                case Rank.Queen: return "Q";
                case Rank.King: return "K";
            }
            //同等於default
            return ((int)rank).ToString();
        }
        /// <summary>
        /// 取得翻譯完成的花色文字
        /// </summary>
        /// <param name="suit">花色原始資料</param>
        /// <returns>翻譯好的花色</returns>
        private string GetSuitText(Suit suit)
        {
            //邏輯判斷式  ♠️. ♥️. ♣️. ♦️
            switch (suit)
            {
                case Suit.Clubs: return "♣️";
                case Suit.Diamonds: return "♦️";
                case Suit.Hearts: return "♥️";
                case Suit.Spades: return "♠️";
                default: return "";
            }
        }

        private Color GetSuitColor(Suit suit) 
        {
            switch (suit)
            {
                case Suit.Diamonds:
                case Suit.Hearts: return Color.red;

                case Suit.Clubs:
                case Suit.Spades: return Color.black;
                default: return Color.white;
            }
        }

        #endregion 私有方法
    }

}
