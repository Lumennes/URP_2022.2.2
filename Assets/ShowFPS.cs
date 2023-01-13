using TMPro;
using UnityEngine;

public class ShowFPS : MonoBehaviour
{
    [SerializeField] TMP_Text m_Text;

    public float updateFpsTime = 0.5f;

    float fps;


    private void Start()
    {
        InvokeRepeating(nameof(UpdateFPS), 0, updateFpsTime);
    }

    void UpdateFPS()
    {
        fps = 1.0f / Time.deltaTime;

        m_Text.text = $"FPS: {(int)fps}";
    }
}