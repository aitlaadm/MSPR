using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VoxelBusters.NativePlugins;
using Object = System.Object;

public class VoxelBustersManager : MonoBehaviour
{

    private bool isSharing = false;
    public GameObject modalWindow;
    public void ShareSocialMedia()
    {
        modalWindow = GameObject.FindWithTag("modalWindow");
        Debug.Log("Button click!");
        modalWindow.SetActive(false);
        isSharing = true;
      
    }

    private void LateUpdate()
    {

        if (isSharing == true)
        {
            isSharing = false;

            StartCoroutine(CaptureScreenShoot());
        }
    }

    IEnumerator CaptureScreenShoot()
    {
        yield return  new WaitForEndOfFrame();

        Texture2D texture = ScreenCapture.CaptureScreenshotAsTexture();
        
        ShareSheet(texture);

        Destroy(texture);
    }

    private void ShareSheet(Texture2D texture)
    {
        ShareSheet _shareSheet = new ShareSheet();
        _shareSheet.Text = "Hello World !!";
        _shareSheet.URL = "https://twitter.com/tweet";
        _shareSheet.AttachImage(texture);
        
        NPBinding.Sharing.ShowView(_shareSheet, FinishSharing);
    }

    private void FinishSharing(eShareResult _result)
    {
        Debug.Log(_result);
    }
}
