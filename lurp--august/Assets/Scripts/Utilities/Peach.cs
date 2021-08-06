using UnityEngine;
using DG.Tweening;

public class Peach : MonoBehaviour
{
    [Header("Shake Params")]
    public float duration;
    public float strength;
    public int vibrato;
    public float randomness;

    public void Shake()
    {
        transform.DOShakePosition(duration, strength, vibrato, randomness);
    }
}
