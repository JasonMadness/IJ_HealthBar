using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextBar : Bar
{
    [SerializeField] private TMPro.TextMeshPro _text;

    protected override void UpdateView()
    {
        _text.text = $"{CurrentValue}/{MaxValue}";
    }
}
