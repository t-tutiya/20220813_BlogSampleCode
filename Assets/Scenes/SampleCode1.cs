using UnityEngine;

public class SampleCode1 : MonoBehaviour
{
    public Vector2 SizeDelta;

#if UNITY_EDITOR
    private void OnValidate()
    {
        Debug.Log("OnValidate called");
    }
#endif
}
