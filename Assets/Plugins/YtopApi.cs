using UnityEngine;
using System.Runtime.InteropServices;
using System;

public class YtopApi {

    private static AndroidJavaClass getYtopApi()
    {
        return new AndroidJavaClass("kr.co.ytop.plugin.YtopApi");
    }

    public static bool isBonusEnabled(string bonus) {
        var req_data = Resources.Load ("ytop_request") as TextAsset;
        return getYtopApi().CallStatic<bool>("isBonusEnabled", req_data.ToString(), bonus);
    }

    public static string getBonus(string bonus) {
        var req_data = Resources.Load ("ytop_request") as TextAsset;
        return getYtopApi().CallStatic<string>("getBonus", req_data.ToString(), bonus);
    }
}
