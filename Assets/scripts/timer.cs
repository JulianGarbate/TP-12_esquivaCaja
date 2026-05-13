using UnityEngine;
using TMPro;

public class timer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    private float timeElapsed;
    private bool isRunning = true; 

    void Update()
    {
        if(isRunning)
        {
            timeElapsed += Time.deltaTime;
            timerText.text = timeElapsed.ToString("F2");
        }
    }

    public void StopTimer()
    {
        isRunning = false;
    }

    public void ResumeTimer()
    {
        isRunning = true;
    }
}
