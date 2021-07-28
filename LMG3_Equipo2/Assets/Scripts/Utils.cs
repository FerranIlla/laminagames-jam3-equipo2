using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Utils
{
    
    public static float Map(float value, float low1, float high1, float low2, float high2)
    {
        float result;
        result = low2 + (value - low1) * (high2 - low2) / (high1 - low1);
        return result;
    }

    public static float SignedToUnsignedDegrees(float signedAngle, bool clamp)
    {
        float unsignedAngle;
        if(signedAngle >= 0)
        {
            unsignedAngle = signedAngle;
            if (clamp) unsignedAngle %= 360f;
        }
        else
        {
            if (clamp) signedAngle = signedAngle % 360f;
            unsignedAngle = signedAngle + 360f;
        }
        return unsignedAngle;
    }

    public static float UnsignedToSignedDegrees(float unsignedAngle, bool clamp)
    {
        float signedAngle;
        if(clamp) unsignedAngle = unsignedAngle % 360;
        if(unsignedAngle > 180)
        {
            signedAngle = unsignedAngle - 360f;
        }
        else
        {
            signedAngle = unsignedAngle;
        }
        return signedAngle;
    }
}
