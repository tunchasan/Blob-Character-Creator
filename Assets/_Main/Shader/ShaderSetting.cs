using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ShaderSetting : ScriptableObject
{
    public Color TotalColor = Color.yellow;
    public float Smooth = 17.5F;
    public float HeadScale = 0;
    public float TorsoUpperScale = 0;
    public float TorsoMidScale = 0;
    public float TorsoLowerScale = 0;
    public float TorsoMidExtraScale = 0;
    public float LeftArmUpperScale = 0;
    public float LeftArmMidScale = 0;
    public float LeftArmLowerScale = 0;
    public float RightArmUpperScale = 0;
    public float RightArmMidScale = 0;
    public float RightArmLowerScale = 0;
    public float LeftLegUpperScale = 0;
    public float LeftLegLowerScale = 0;
    public float LeftLegMidScale = 0;
    public float RightLegUpperScale = 0;
    public float RightLegLowerScale = 0;
    public float RightLegMidScale = 0;

    public float ValueByString(string value)
    {
        switch (value)
        {
            case "_HeadScale":
                return HeadScale;
            case "_TorsoUpperScale":
                return TorsoUpperScale;
            case "_TorsoMidScale":
                return TorsoMidScale;
            case "_TorsoLowerScale":
                return TorsoLowerScale;
            case "_TorsoMidExtraScale":
                return TorsoMidExtraScale;
            case "_LeftArmUpperScale":
                return LeftArmUpperScale;
            case "_LeftArmMidScale":
                return LeftArmMidScale;
            case "_LeftArmLowerScale":
                return LeftArmLowerScale;
            case "_RightArmUpperScale":
                return RightArmUpperScale;
            case "_RightArmMidScale":
                return RightArmMidScale;
            case "_RightArmLowerScale":
                return RightArmLowerScale;
            case "_LeftLegUpperScale":
                return LeftLegUpperScale;
            case "_LeftLegLowerScale":
                return LeftLegLowerScale;
            case "_LeftLegMidScale":
                return LeftLegMidScale;
            case "_RightLegUpperScale":
                return RightLegUpperScale;
            case "_RightLegLowerScale":
                return RightLegLowerScale;
            case "_RightLegMidScale":
                return RightLegMidScale;
            default:
                return 0;
        }
    }
}
