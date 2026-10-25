using UnityEngine;
using ChaiWala.Core.Application;

namespace ChaiWala.Core.Bootstrap
{
    public sealed class Bootstrapper : MonoBehaviour
    {
        private void Awake()
        {
            var applicationRoot = new ApplicationRoot();
            applicationRoot.Initialize();
        }
    }
}