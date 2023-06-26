using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class CSVWriter
{
    string path;

    public void SetPath(string path)
    {
        this.path = path;
    }

    public void WriteDataCSV(List<string[]> dataList)
    {
        // verifier s'il y a au moins 1 capteur à logger
        using (TextWriter tw = new StreamWriter(path, true))
        {
            string data = "";

            for (int i = 0; i < dataList.Count; i++)
            {
                for (int j = 0; j < dataList[0].Length; j++)
                {
                    data += dataList[i][j] + ";";
                }
                tw.WriteLine(data);
                data = "";
            }
            tw.Close();
        }
    }

    public void WriteHeaderCSV()
    {
        using (TextWriter tw = new StreamWriter(path, false))
        {
            tw.WriteLine("TimeStamp" +
                "leftPrimary2DAxis;leftGrip;leftGripButton;leftMenuButton;LeftPrimaryButton;leftPrimaryTouch;leftSecondaryButton;leftSecondaryTouch;leftTrigger;leftTriggerButton;leftPrimary2DAxisClick;leftPrimary2DAxisTouch;leftIsTracked;leftTrackingState;leftDevicePosition;leftDeviceRotation;leftDeviceVelocity;leftDeviceAngularVelocity;" + // Oculus Quest pro left hand controller
                "rightPrimary2DAxis;rightGrip;rightGripButton;rightMenuButton;rightPrimaryButton;rightPrimaryTouch;rightSecondaryButton;rightSecondaryTouch;rightTrigger;rightTriggerButton;rightPrimary2DAxisClick;rightPrimary2DAxisTouch;rightIsTracked;rightTrackingState;rightDevicePosition;rightDeviceRotation;rightDeviceVelocity;rightDeviceAngularVelocity;" + // Oculus Quest pro right hand controller
                "isUserPresence;isHeadSetTracked;isHeadSetTrackingState;isHeadSetDevicePosition;isHeadSetDeviceRotation;isHeadSetDeviceVelocity;isHeadSetDeviceAngularVelocity;isHeadSetDeviceAcceleration;isHeadSetDeviceAngularAcceleration;isHeadSetLeftEyePosition;isHeadSetLeftEyeRotation;isHeadSetLeftEyeVelocity;isHeadSetLeftEyeAngularVelocity;isHeadSetLeftEyeAcceleration;isHeadSetLeftEyeAngularAcceleration;isHeadSetRightEyePosition;isHeadSetRightEyeRotation;isHeadSetRightEyeVelocity;isHeadSetRightEyeAngularVelocity;isHeadSetRightEyeAcceleration;isHeadSetRightEyeAngularAcceleration;isHeadSetCenterEyePosition;isHeadSetCenterEyeRotation;isHeadSetCenterEyeVelocity;isHeadSetCenterEyeAngularVelocity;isHeadSetCenterEyeAcceleration;isHeadSetCenterEyeAngularAcceleration;this.isHeadSetBatterieLevel = isHeadSetBatterieLevel;HeadsetColorCameraAcceleration;HeadsetColorCameraAngularAcceleration;HeadsetColorCameraAngularVelocity;HeadsetColorCameraPosition;HeadsetColorCameraRotation;HeadsetColorCameraVelocity;LeftFixationPoint;RightFixationPoint"); // Oculus Quest pro headset
            tw.Close();
        }
    }
}
