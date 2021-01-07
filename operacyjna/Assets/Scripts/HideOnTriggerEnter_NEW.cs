//======= Copyright (c) Valve Corporation, All rights reserved. ===============
//
// Purpose: Destroys this object when it enters a trigger
//
//=============================================================================

using UnityEngine;
using System.Collections;

namespace Valve.VR.InteractionSystem
{
    //-------------------------------------------------------------------------
    public class HideOnTriggerEnter_NEW : MonoBehaviour
    {
        public string tagFilter;

        private bool useTag;

        //-------------------------------------------------
        void Start()
        {
            if (!string.IsNullOrEmpty(tagFilter))
            {
                useTag = true;
            }
        }


        //-------------------------------------------------
        void OnTriggerEnter(Collider collider)
        {
            if ((!useTag || (useTag && collider.gameObject.tag == tagFilter)) && gameObject.activeSelf)
            {
                gameObject.SetActive(false);
            }
           // else if ((!useTag || (useTag && collider.gameObject.tag == tagFilter)) && !gameObject.activeSelf)
         //   {
         //       gameObject.SetActive(true);
         //   }
        }
    }
}
