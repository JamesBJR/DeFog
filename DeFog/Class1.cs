using MelonLoader;
using System;
using System.Linq;
using UnityEngine;
using Tropos;
using Lirp;
public class DeFog : MelonMod
{

    private GameObject refrenceObj;
    private TroposCamera troposRefrence;
    bool loadCheck = false;

    public override void OnSceneWasLoaded(int buildIndex, string sceneName)

    {
        if (loadCheck == true)
        {
            troposRefrence.renderFog = false;
            troposRefrence.renderAerialPerspective = false;
            troposRefrence.renderClouds = true;
            
        }
        if (sceneName == "mountain01Logic")
        {
            if (loadCheck == false)
            {
                refrenceObj = GameObject.Find("VRCamera");
                troposRefrence = refrenceObj.GetComponent<TroposCamera>();
                troposRefrence.renderFog = false;
                troposRefrence.renderAerialPerspective = false;
                troposRefrence.renderClouds = true;
                loadCheck = true;
                
            }
            
        }

        return;
    }



}
