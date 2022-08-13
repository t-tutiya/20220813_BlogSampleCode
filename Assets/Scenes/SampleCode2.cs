using UnityEngine;

public class SampleCode2 : MonoBehaviour
{
    public Vector2 SizeDelta;


#if UNITY_EDITOR
    private void OnValidate()
    {
        UnityEditor.EditorApplication.update += OnValidateImpl;
    }

    void OnValidateImpl()
    {
        UnityEditor.EditorApplication.update -= OnValidateImpl;
        if (this == null) return;
        Debug.Log(this);
        GetComponent<RectTransform>().sizeDelta = SizeDelta;

    }
#endif
}
