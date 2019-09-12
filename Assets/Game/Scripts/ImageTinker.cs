using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageTinker : MonoBehaviour {
    [SerializeField]
    private Texture2D sourceTexture2D;

    [SerializeField]
    private RawImage uiImage; 

    
    // Start is called before the first frame update
    void Start() {
        // Create a clone of the sourceTexture and apply it to the rawImage on the UI
        var width = sourceTexture2D.width;
        var height = sourceTexture2D.height;
        
        var targetTexture2D = new Texture2D(width, height, TextureFormat.RGBA32, false);
        Debug.Log(targetTexture2D.isReadable);
        var targetPixels = sourceTexture2D.GetPixels();
        
        for (var i = 0; i < width; i++) {
            for (var j = 0; j < height; j++) {
                var pixelIndex = (i * width) + j;
                // Do stuff with pixels :)
            }
        }
        
        targetTexture2D.SetPixels(targetPixels);
        targetTexture2D.Apply();

        uiImage.texture = targetTexture2D;
    }
}
