using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using TMPro;
using UnityEngine;

public class canvas : MonoBehaviour
{
    [SerializeField] private GameObject winCanvas;
    [SerializeField] private TextMeshProUGUI _pointText;
    [SerializeField] private GameObject loseCanvas;
    [SerializeField] private TextMeshProUGUI missedBallText;
    void Start()
    {
        _pointText.text = DetectCollisionsX.point.ToString();
        missedBallText.text=DestroyOutOfBoundsX.missedBall.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        _pointText.text = DetectCollisionsX.point.ToString();
        missedBallText.text = DestroyOutOfBoundsX.missedBall.ToString();
        wincanvas();
        losecanvas();
    }

    void wincanvas()
    {
        if (DetectCollisionsX.point == 10)
        {
            winCanvas.SetActive(true);
            StartCoroutine(gameStop());
        }
    }
    void losecanvas()
    {
        if (DestroyOutOfBoundsX.missedBall == 5)
        {
            loseCanvas.SetActive(true);
            StartCoroutine(gameStop());
        }
    }
    IEnumerator gameStop()
    {
        yield return new WaitForSeconds(0.01f);
        Time.timeScale = 0;
    }
}
