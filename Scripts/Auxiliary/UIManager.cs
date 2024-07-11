using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    private Canvas[] canvases;
    private Canvas activeCanvas;

    private void Start()
    {
        canvases = GameObject.FindObjectsOfType<Canvas>();
        SetCanvasesInactive();
    }

    private void SetCanvasesInactive(){
        foreach(Canvas canvas in canvases){
            canvas.gameObject.SetActive(false);
        }
    }

    public void SwitchActiveCanvas(Canvas ActiveCanvas){
        SetCanvasesInactive();
        if(ActiveCanvas==activeCanvas){
            activeCanvas.gameObject.SetActive(false);
            activeCanvas = null;
        }
        else{
            activeCanvas = ActiveCanvas;
            activeCanvas.gameObject.SetActive(true);
        }
    }
}
