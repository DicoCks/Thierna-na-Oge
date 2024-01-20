using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class LocalDataManager
{
    public static void SetInt(string key, int value)
    {
        PlayerPrefs.SetInt(key, value);
    }

    public static void SetString(string key, string value)
    {
        PlayerPrefs.SetString(key, value);
    }

    public static void SetFloat(string key, float value)
    {
        PlayerPrefs.SetFloat(key, value);
    }

    public static int GetInt(string key)
    {
        return PlayerPrefs.GetInt(key, 0);
    }

    public static string GetString(string key)
    {
        return PlayerPrefs.GetString(key, string.Empty);
    }

    public static float GetFloat(string key)
    {
        return PlayerPrefs.GetFloat(key, 0f);
    }
}
