using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using TMPro;
using UnityEngine;

public class canvas : MonoBehaviour
{
    [SerializeField] private GameObject winCanvas;
    [SerializeField] private TextMeshProUGUI _pointText;
    void Start()
    {
        _pointText.text = DetectCollisionsX.point.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        _pointText.text = DetectCollisionsX.point.ToString();
        wincanvas();
    }

    void wincanvas()
    {
        if (DetectCollisionsX.point == 2)
        {
            winCanvas.SetActive(true);
            StartCoroutine(gameStop());
        }
    }
    IEnumerator gameStop()
    {
        yield return new WaitForSeconds(0.01f);
        Time.timeScale = 0;
    }
}
