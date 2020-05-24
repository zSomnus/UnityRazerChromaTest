using ChromaSDK;
using System;
using System.Collections.Generic;
using UnityEngine;

enum Animations
{
    Blank = 0,
    RingGray = 1,
    FadeInOut = 2
}
public class Chroma : MonoBehaviour
{
    [SerializeField] bool w = true;
    [SerializeField] bool a = true;
    [SerializeField] bool s = true;
    [SerializeField] bool d = true;

    [SerializeField] Animations animations;

    private float _mHotkeyIntensity = 1;
    private float _mBaseIntensity = 1;
    private float _mEffectIntensity = 1;

    string baseLayer;
    string layer2;

    // Start is called before the first frame update
    void Start()
    {
        UnityNativeChromaSDK.Uninit();
        UnityNativeChromaSDK.Init();
        Debug.Log("Start");
        baseLayer = "Blank_Keyboard.chroma";
        layer2 = "RingGray_Keyboard.chroma";
        //UnityNativeChromaSDK.PlayAnimationName(baseLayer, true);
    }

    private void OnApplicationQuit()
    {
        UnityNativeChromaSDK.Uninit();
    }

    // Update is called once per frame
    void Update()
    {
        //switch (animations)
        //{
        //    case Animations.Blank:
        //        Blank();
        //        baseLayer = "Blank_Keyboard.chroma";
        //        break;
        //    case Animations.FadeInOut:
        //        FadeInOut();
        //        baseLayer = "FadeInOutGray_Keyboard.chroma";
        //        break;
        //    case Animations.RingGray:
        //        RingGray();
        //        baseLayer = "RingGray_Keyboard.chroma";
        //        break;
        //}
        //Blank();
    }

    public void RingGray()
    {
        //UnityNativeChromaSDK.PlayAnimationName("Blank_Keyboard.chroma");

        baseLayer = "RingGray_Keyboard.chroma";
        UnityNativeChromaSDK.CloseAnimationName(baseLayer);
        UnityNativeChromaSDK.MultiplyIntensityAllFramesName(baseLayer, 1.0f + 64.0f * _mBaseIntensity);

        List<int> keyList = new List<int>();

        if (w)
        {
            keyList.Add((int)UnityNativeChromaSDK.Keyboard.RZKEY.RZKEY_W);
        }
        if (a)
        {
            keyList.Add((int)UnityNativeChromaSDK.Keyboard.RZKEY.RZKEY_A);
        }
        if (s)
        {
            keyList.Add((int)UnityNativeChromaSDK.Keyboard.RZKEY.RZKEY_S);
        }
        if (d)
        {
            keyList.Add((int)UnityNativeChromaSDK.Keyboard.RZKEY.RZKEY_D);
        }

        int[] keys = keyList.ToArray();

        Color color = new Color(_mHotkeyIntensity * 1, _mHotkeyIntensity * 0.5f, 0);
        UnityNativeChromaSDK.SetKeysColorAllFramesName(baseLayer, keys, color);

        UnityNativeChromaSDK.PlayAnimationName(baseLayer, true);
    }

    public void FadeInOut()
    {
        //UnityNativeChromaSDK.PlayAnimationName("Blank_Keyboard.chroma");

        baseLayer = "FadeInOutGray_Keyboard.chroma";
        UnityNativeChromaSDK.CloseAnimationName(baseLayer);
        UnityNativeChromaSDK.MultiplyIntensityAllFramesName(baseLayer, 1.0f + 64.0f * _mBaseIntensity);

        List<int> keyList = new List<int>();

        if (w)
        {
            keyList.Add((int)UnityNativeChromaSDK.Keyboard.RZKEY.RZKEY_W);
        }
        if (a)
        {
            keyList.Add((int)UnityNativeChromaSDK.Keyboard.RZKEY.RZKEY_A);
        }
        if (s)
        {
            keyList.Add((int)UnityNativeChromaSDK.Keyboard.RZKEY.RZKEY_S);
        }
        if (d)
        {
            keyList.Add((int)UnityNativeChromaSDK.Keyboard.RZKEY.RZKEY_D);
        }

        int[] keys = keyList.ToArray();

        Color color = new Color(_mHotkeyIntensity * 1, _mHotkeyIntensity * 0.5f, 0);
        UnityNativeChromaSDK.SetKeysColorAllFramesName(baseLayer, keys, color);

        UnityNativeChromaSDK.PlayAnimationName(baseLayer, true);
    }

    public void Blank()
    {
        //UnityNativeChromaSDK.PlayAnimationName("Blank_Keyboard.chroma");
        baseLayer = "Blank_Keyboard.chroma";
        UnityNativeChromaSDK.CloseAnimationName(baseLayer);
        UnityNativeChromaSDK.MultiplyIntensityAllFramesName(baseLayer, 1.0f + 64.0f * _mBaseIntensity);

        List<int> keyList = new List<int>();

        if (w)
        {
            keyList.Add((int)UnityNativeChromaSDK.Keyboard.RZKEY.RZKEY_W);
        }
        if (a)
        {
            keyList.Add((int)UnityNativeChromaSDK.Keyboard.RZKEY.RZKEY_A);
        }
        if (s)
        {
            keyList.Add((int)UnityNativeChromaSDK.Keyboard.RZKEY.RZKEY_S);
        }
        if (d)
        {
            keyList.Add((int)UnityNativeChromaSDK.Keyboard.RZKEY.RZKEY_D);
        }

        int[] keys = keyList.ToArray();

        Color color = new Color(_mHotkeyIntensity * 1, _mHotkeyIntensity * 0.5f, 0);
        UnityNativeChromaSDK.SetKeysColorAllFramesName(baseLayer, keys, color);

        UnityNativeChromaSDK.PlayAnimationName(baseLayer, true);
    }
}
