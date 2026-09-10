using UnityEngine;

public class Bar : MonoBehaviour
{
    protected int CurrentValue { get; private set; }
    protected int MaxValue { get; private set; }

    public void Initialize(int currentValue, int maxValue)
    {
        MaxValue = maxValue;
        OnValueChanged(currentValue);
    }

    public void OnValueChanged(int currentValue)
    {
        CurrentValue = currentValue;
        UpdateView();
    }

    protected virtual void UpdateView() { }
}
