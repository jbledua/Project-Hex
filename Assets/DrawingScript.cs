using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawingScript : MonoBehaviour
{
    public Camera drawingCamera;
    public GameObject brushStrokePrefab;
    public float brushSize = 0.1f;

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector2 mousePosition = Input.mousePosition;
            Vector3 worldPosition = drawingCamera.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, drawingCamera.nearClipPlane));

            GameObject brushStroke = Instantiate(brushStrokePrefab, worldPosition, Quaternion.identity);
            brushStroke.transform.localScale = new Vector3(brushSize, brushSize, brushSize);
            brushStroke.layer = LayerMask.NameToLayer("Drawing"); // The layer your drawing camera captures
        }
    }
}
