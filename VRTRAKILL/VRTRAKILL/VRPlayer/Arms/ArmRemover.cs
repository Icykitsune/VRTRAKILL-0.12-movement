﻿using UnityEngine;
using Plugin.Helpers;

namespace Plugin.VRTRAKILL.VRPlayer.Arms
{
    internal class ArmRemover : MonoBehaviour
    {
        Transform Armature;
        Feedbacker.Armature FBArm; Knuckleblaster.Armature KBArm;
        Vector3 ArmSize, HandSize;
        public void Start()
        {
            if (gameObject.HasComponent<Revolver>())
            {
                Armature = transform.GetChild(0);
                FBArm = new Feedbacker.Armature(Armature);
                ArmSize = new Vector3(1, 1, 1); HandSize = new Vector3(100, 100, 100);
            }
            else if (gameObject.HasComponent<Sandbox.Arm.SandboxArm>())
            {
                Armature = transform;
                FBArm = new Feedbacker.Armature(Armature);
                ArmSize = new Vector3(1, 1, 1); HandSize = new Vector3(100, 100, 100);
            }
            else if (gameObject.HasComponent<Punch>())
            {
                ArmSize = new Vector3(.01f, .01f, .01f);
                switch (GetComponent<Punch>().type)
                {
                    case FistType.Standard:
                        Armature = transform.GetChild(0);
                        FBArm = new Feedbacker.Armature(Armature);
                        HandSize = new Vector3(35, 35, 35);
                        break;
                    case FistType.Heavy:
                        Armature = transform.GetChild(0);

                        HandSize = new Vector3(100, 100, 100);
                        break;
                    case FistType.Spear:
                        break;
                }
            }
        }
        public void LateUpdate()
        {
            if (FBArm != null)
            {
                FBArm.RArmature.localScale = ArmSize;
                FBArm.Hand.localScale = HandSize;
            }
            else if (KBArm != null)
            {

            }
        }
    }
}
