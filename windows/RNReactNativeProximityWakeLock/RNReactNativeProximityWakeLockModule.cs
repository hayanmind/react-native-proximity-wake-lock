using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Com.Reactlibrary.RNReactNativeProximityWakeLock
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNReactNativeProximityWakeLockModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNReactNativeProximityWakeLockModule"/>.
        /// </summary>
        internal RNReactNativeProximityWakeLockModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNReactNativeProximityWakeLock";
            }
        }
    }
}
