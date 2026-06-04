using UnityEngine;
using DG.Tweening;

public class KyleMovementAnimation : MonoBehaviour
{

    public float Duration = 1f;
    public Ease ease = Ease.Linear; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Sequence seq = DOTween.Sequence();

        seq.Append(transform.DOMoveZ(-0.5f, Duration).SetEase(ease));
        seq.Append(transform.DORotate(new Vector3(0, -90f, 0), Duration).SetEase(ease));
        seq.Append(transform.DOMoveX(-0.6f, Duration).SetEase(ease));
        seq.Append(transform.DORotate(new Vector3(0, 3f, 0), Duration).SetEase(ease));
        seq.Append(transform.DOMoveZ(3f, Duration).SetEase(ease));
    }

    // Update is called once per frame
    void Update()
    {

    }
}
