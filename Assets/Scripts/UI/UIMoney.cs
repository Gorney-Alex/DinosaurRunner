using TMPro;
using UnityEngine;

public class UIMoney : UIBase
{
    [SerializeField] private TextMeshPro _textMoney;

    public void DisplayMoney(int amountMoney)
    {
        _textMoney.text = amountMoney.ToString();
    }
}
