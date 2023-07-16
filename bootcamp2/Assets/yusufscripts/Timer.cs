using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Timer : MonoBehaviour
{
    public float time;
    public TextMeshProUGUI timerText;
    private bool isCounting;

    void ResetTimer()
{
    // Zamanı sıfırla
    time = 0f;

    // Zamanı TextMeshPro'ya yansıt
    timerText.text = time.ToString("F2"); // İstediğiniz formatı burada belirleyebilirsiniz
}
    void Start()
    {
        // Başlangıçta zamanı 0 olarak ayarla
        time = 0f;
        isCounting = false;
    }

    void Update()
{
    if (Input.GetKey(KeyCode.F))
    {
        // "F" tuşu basılı tutulduğu sürece zamanı artır
        time += Time.deltaTime;

        // Zamanı TextMeshPro'ya yansıt
        timerText.text = time.ToString("F2"); // İstediğiniz formatı burada belirleyebilirsiniz
    }

    if (Input.GetKeyUp(KeyCode.F))
    {
        // "F" tuşuna basılı tutmayı bıraktığında zamanı sıfırla
        ResetTimer();
    }
}

}

    

