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
            _suitLabel.text = card.Suit.ToString();  // 顯示花色
            _rankLabel.text = card.Rank.ToString();  // 顯示點數
        }
        #endregion 公開方法

        #region 私有方法
        #endregion 私有方法
    }

}
