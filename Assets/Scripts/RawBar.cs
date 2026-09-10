using UnityEngine;
using UnityEngine.UI;

public class RawBar : Bar
{
    [SerializeField] private Slider _slider;

    protected override void UpdateView()
    {
        _slider.value = (float)CurrentValue / MaxValue;
    }
}
