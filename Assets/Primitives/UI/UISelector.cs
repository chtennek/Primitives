using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Primitives.Core;

namespace Primitives
{
    namespace UI
    {
        public class UISelector : MonoBehaviour
        {
            [Header("Input")]
            public string axisPairName = "UI";

            [Header("")]
            public Component selected;
        }
    }
}
