using UnityEngine;

public class Bootstrapper : MonoBehaviour
{
    [SerializeField] private Health _health;
    [SerializeField] private Bar[] _bars;

    private void Start()
    {
        foreach (var bar in _bars)
            bar.Initialize(_health.Current, _health.Max);
    }

    private void OnEnable()
    {
        foreach (var bar in _bars)
            _health.ValueChanged += bar.OnValueChanged;
    }

    private void OnDisable()
    {
        foreach (var bar in _bars)
            _health.ValueChanged -= bar.OnValueChanged;
    }
}
