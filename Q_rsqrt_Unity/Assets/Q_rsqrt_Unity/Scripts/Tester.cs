using UnityEngine;
using Q3;

public class Tester : MonoBehaviour
{
    public float testValue = 1f;

    private void Start()
    {
        float result = Qmath.Q_rsqrt(testValue);
        Debug.Log(result);
    }

    private void Update()
    {
        Qmath.Q_rsqrt(testValue);
        Debug.Log(Time.deltaTime);
    }
}
