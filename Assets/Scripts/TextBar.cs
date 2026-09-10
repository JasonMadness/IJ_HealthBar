using UnityEngine;
using TMPro;

public class TextBar : Bar
{
    [SerializeField] private TextMeshProUGUI _text;

    protected override void UpdateView()
    {
        _text.text = $"{CurrentValue}/{MaxValue}";
    }
}
