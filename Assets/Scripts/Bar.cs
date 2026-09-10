using UnityEngine;

public class Bar : MonoBehaviour
{
    private int _currentValue;
    private int _maxValue;

    public void Initialize(int currentValue, int maxValue)
    {
        _currentValue = currentValue;
        _maxValue = maxValue;
    }

    public virtual void UpdateView() { }
}
